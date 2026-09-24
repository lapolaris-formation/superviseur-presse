Namespace Metier

    ''' <summary>
    ''' Une mesure de pression horodatée.
    ''' </summary>
    Friend Class Mesure

        Public Sub New(horodatage As DateTime, pressionBar As Double)
            Me.Horodatage = horodatage
            Me.PressionBar = pressionBar
        End Sub

        Public ReadOnly Property Horodatage As DateTime
        Public ReadOnly Property PressionBar As Double

    End Class

End Namespace
