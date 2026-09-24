Namespace Metier

    ''' <summary>
    ''' Conversion de la valeur brute du capteur en bars, et contrôle des seuils.
    ''' Aucune dépendance à l'interface : c'est la partie testable de l'application.
    ''' </summary>
    Friend Class CalculPression

        ' Le capteur renvoie un mot de 12 bits : 0 à 4095 pour 0 à 250 bars.
        Public Const ValeurBruteMax As Integer = 4095
        Public Const PressionMaxBar As Double = 250.0

        Private ReadOnly _seuilAlarmeBar As Double

        Public Sub New(seuilAlarmeBar As Double)
            If seuilAlarmeBar <= 0 OrElse seuilAlarmeBar > PressionMaxBar Then
                Throw New ArgumentOutOfRangeException(NameOf(seuilAlarmeBar),
                    $"Le seuil doit être compris entre 0 et {PressionMaxBar} bars.")
            End If
            _seuilAlarmeBar = seuilAlarmeBar
        End Sub

        Public ReadOnly Property SeuilAlarmeBar As Double
            Get
                Return _seuilAlarmeBar
            End Get
        End Property

        ''' <summary>
        ''' Convertit la valeur brute en bars. Une valeur hors plage est ramenée aux bornes.
        ''' </summary>
        Public Function ConvertirEnBars(valeurBrute As Integer) As Double
            Dim bornee = Math.Max(0, Math.Min(ValeurBruteMax, valeurBrute))
            Return Math.Round(bornee * PressionMaxBar / ValeurBruteMax, 1)
        End Function

        Public Function EstEnSurpression(pressionBar As Double) As Boolean
            Return pressionBar >= _seuilAlarmeBar
        End Function

    End Class

End Namespace
