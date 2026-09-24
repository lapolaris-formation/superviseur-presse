Imports SuperviseurPresse.Metier

<TestClass>
Public Class CalculPressionTests

    <TestMethod>
    Public Sub ConvertirEnBars_ValeurMaximale_Retourne250()
        ' Arrange
        Dim calcul As New CalculPression(seuilAlarmeBar:=200.0)

        ' Act
        Dim resultat = calcul.ConvertirEnBars(4095)

        ' Assert
        Assert.AreEqual(250.0, resultat, 0.01)
    End Sub

    <DataTestMethod>
    <DataRow(0, 0.0)>
    <DataRow(2048, 125.0)>
    <DataRow(-50, 0.0)>
    <DataRow(5000, 250.0)>
    Public Sub ConvertirEnBars_DiversesValeurs_RetourneValeurBornee(brut As Integer, attendu As Double)
        Dim calcul As New CalculPression(seuilAlarmeBar:=200.0)

        Assert.AreEqual(attendu, calcul.ConvertirEnBars(brut), 0.1)
    End Sub

    <TestMethod>
    Public Sub EstEnSurpression_AuSeuil_RetourneVrai()
        Dim calcul As New CalculPression(seuilAlarmeBar:=200.0)

        Assert.IsTrue(calcul.EstEnSurpression(200.0))
        Assert.IsFalse(calcul.EstEnSurpression(199.9))
    End Sub

    <TestMethod>
    <ExpectedException(GetType(ArgumentOutOfRangeException))>
    Public Sub Constructeur_SeuilHorsPlage_LeveUneException()
        Dim calcul As New CalculPression(seuilAlarmeBar:=300.0)
    End Sub

End Class
