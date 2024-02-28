Public Class Nelinurk
    Inherits Kujund

    Protected kylgD As Double

    Public Sub New(ByVal tyyp As String, ByVal kylgA As Double,
                   ByVal kylgB As Double, ByVal kylgC As Double, ByVal kylgD As Double)
        MyBase.New(tyyp, kylgA, kylgB, kylgC)
        Me.kylgD = kylgD
    End Sub
    Public Overrides Function leiaPindala() As Double
        Return 0
    End Function

    Public Overrides Function leiaYmberMoot() As Double
        Return kylgA + kylgB + kylgC + kylgD
    End Function
End Class
