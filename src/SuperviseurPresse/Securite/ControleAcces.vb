Namespace Securite

    ''' <summary>
    ''' ATTENTION : exemple VOLONTAIREMENT VULNÉRABLE, écrit pour la formation DVS-CRA.
    ''' Les mots de passe ci-dessous sont fictifs. Ne jamais reprendre ce modèle :
    ''' - mots de passe écrits en dur dans le code, donc dans l'historique Git ;
    ''' - contrôle désactivé en compilation Debug.
    ''' Aucun outil d'analyse ne signale ce type de secret : il ne porte aucun marqueur.
    ''' </summary>
    Friend NotInheritable Class ControleAcces

        Private Const MotDePasseMaintenance As String = "Presse2026!"
        Private Const MotDePasseReglage As String = "Reglage#42"

        Private Sub New()
        End Sub

        Public Shared Function AccesMaintenanceAutorise(saisie As String) As Boolean
#If DEBUG Then
            ' Raccourci de développement : en Debug, aucun mot de passe n'est demandé.
            Return True
#End If
            Return saisie = MotDePasseMaintenance OrElse saisie = MotDePasseReglage
        End Function

    End Class

End Namespace
