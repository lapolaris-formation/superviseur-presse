<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.LblPression = New System.Windows.Forms.Label()
        Me.LblEtat = New System.Windows.Forms.Label()
        Me.BtnDemarrer = New System.Windows.Forms.Button()
        Me.BtnExporter = New System.Windows.Forms.Button()
        Me.BtnMaintenance = New System.Windows.Forms.Button()
        Me.TmrLecture = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LblTitre.Location = New System.Drawing.Point(20, 15)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(230, 21)
        Me.LblTitre.TabIndex = 0
        Me.LblTitre.Text = "Supervision presse hydraulique"
        '
        'LblPression
        '
        Me.LblPression.AutoSize = True
        Me.LblPression.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.LblPression.Location = New System.Drawing.Point(20, 50)
        Me.LblPression.Name = "LblPression"
        Me.LblPression.Size = New System.Drawing.Size(80, 37)
        Me.LblPression.TabIndex = 1
        Me.LblPression.Text = "-- bar"
        '
        'LblEtat
        '
        Me.LblEtat.AutoSize = True
        Me.LblEtat.Location = New System.Drawing.Point(22, 95)
        Me.LblEtat.Name = "LblEtat"
        Me.LblEtat.Size = New System.Drawing.Size(70, 15)
        Me.LblEtat.TabIndex = 2
        Me.LblEtat.Text = "Déconnecté"
        '
        'BtnDemarrer
        '
        Me.BtnDemarrer.Location = New System.Drawing.Point(20, 125)
        Me.BtnDemarrer.Name = "BtnDemarrer"
        Me.BtnDemarrer.Size = New System.Drawing.Size(110, 30)
        Me.BtnDemarrer.TabIndex = 3
        Me.BtnDemarrer.Text = "Démarrer"
        Me.BtnDemarrer.UseVisualStyleBackColor = True
        '
        'BtnExporter
        '
        Me.BtnExporter.Location = New System.Drawing.Point(140, 125)
        Me.BtnExporter.Name = "BtnExporter"
        Me.BtnExporter.Size = New System.Drawing.Size(110, 30)
        Me.BtnExporter.TabIndex = 4
        Me.BtnExporter.Text = "Exporter"
        Me.BtnExporter.UseVisualStyleBackColor = True
        '
        'BtnMaintenance
        '
        Me.BtnMaintenance.Location = New System.Drawing.Point(260, 125)
        Me.BtnMaintenance.Name = "BtnMaintenance"
        Me.BtnMaintenance.Size = New System.Drawing.Size(110, 30)
        Me.BtnMaintenance.TabIndex = 5
        Me.BtnMaintenance.Text = "Maintenance"
        Me.BtnMaintenance.UseVisualStyleBackColor = True
        '
        'TmrLecture
        '
        Me.TmrLecture.Interval = 500
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 175)
        Me.Controls.Add(Me.BtnMaintenance)
        Me.Controls.Add(Me.BtnExporter)
        Me.Controls.Add(Me.BtnDemarrer)
        Me.Controls.Add(Me.LblEtat)
        Me.Controls.Add(Me.LblPression)
        Me.Controls.Add(Me.LblTitre)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SuperviseurPresse"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitre As System.Windows.Forms.Label
    Friend WithEvents LblPression As System.Windows.Forms.Label
    Friend WithEvents LblEtat As System.Windows.Forms.Label
    Friend WithEvents BtnDemarrer As System.Windows.Forms.Button
    Friend WithEvents BtnExporter As System.Windows.Forms.Button
    Friend WithEvents BtnMaintenance As System.Windows.Forms.Button
    Friend WithEvents TmrLecture As System.Windows.Forms.Timer

End Class
