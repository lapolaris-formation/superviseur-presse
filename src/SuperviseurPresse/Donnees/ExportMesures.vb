Imports System.IO
Imports Newtonsoft.Json
Imports SuperviseurPresse.Metier

Namespace Donnees

    ''' <summary>
    ''' Export des mesures au format JSON, pour l'analyse hors ligne.
    ''' </summary>
    Friend NotInheritable Class ExportMesures

        Private Sub New()
        End Sub

        Public Shared Function VersJson(mesures As IEnumerable(Of Mesure)) As String
            Return JsonConvert.SerializeObject(mesures, Formatting.Indented)
        End Function

        Public Shared Sub Enregistrer(mesures As IEnumerable(Of Mesure), chemin As String)
            File.WriteAllText(chemin, VersJson(mesures))
        End Sub

    End Class

End Namespace
