Imports Fournisseur.Automate
Imports SuperviseurPresse.Donnees
Imports SuperviseurPresse.Metier
Imports SuperviseurPresse.Securite

Public Class FrmPrincipal

    ' Adresse de l'automate et adresse mémoire du capteur de pression
    Private Const AdresseAutomate As String = "192.168.10.20"
    Private Const PortAutomate As Integer = 502
    Private Const MotCapteurPression As Integer = 40001

    Private ReadOnly _calcul As New CalculPression(seuilAlarmeBar:=200.0)
    Private ReadOnly _mesures As New List(Of Mesure)
    Private _automate As ConnexionAutomate

    Private Sub BtnDemarrer_Click(sender As Object, e As EventArgs) Handles BtnDemarrer.Click
        If _automate Is Nothing Then
            _automate = New ConnexionAutomate(AdresseAutomate, PortAutomate)
            _automate.Connecter()
            TmrLecture.Start()
            BtnDemarrer.Text = "Arrêter"
            LblEtat.Text = $"Connecté à {AdresseAutomate}:{PortAutomate}"
        Else
            TmrLecture.Stop()
            _automate.Dispose()
            _automate = Nothing
            BtnDemarrer.Text = "Démarrer"
            LblEtat.Text = "Déconnecté"
        End If
    End Sub

    Private Sub TmrLecture_Tick(sender As Object, e As EventArgs) Handles TmrLecture.Tick
        Dim pression = _calcul.ConvertirEnBars(_automate.LireMot(MotCapteurPression))
        _mesures.Add(New Mesure(DateTime.Now, pression))

        LblPression.Text = $"{pression:0.0} bar"
        LblPression.ForeColor = If(_calcul.EstEnSurpression(pression), Color.Red, Color.Black)
    End Sub

    Private Sub BtnExporter_Click(sender As Object, e As EventArgs) Handles BtnExporter.Click
        Using dialogue As New SaveFileDialog With {.Filter = "JSON|*.json", .FileName = "mesures.json"}
            If dialogue.ShowDialog(Me) = DialogResult.OK Then
                ExportMesures.Enregistrer(_mesures, dialogue.FileName)
            End If
        End Using
    End Sub

    Private Sub BtnMaintenance_Click(sender As Object, e As EventArgs) Handles BtnMaintenance.Click
        Dim saisie = InputBox("Mot de passe de maintenance :", "Accès maintenance")
        If ControleAcces.AccesMaintenanceAutorise(saisie) Then
            MessageBox.Show(Me, "Accès maintenance accordé.", "Maintenance")
        Else
            MessageBox.Show(Me, "Mot de passe incorrect.", "Maintenance",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

End Class
