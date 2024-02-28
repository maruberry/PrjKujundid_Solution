Public Class Rööpkylik
    Inherits Nelinurk
    Private korgus As Double
    Public Sub New(ByVal kylgA As Double, ByVal kylgB As Double, ByVal korgus As Double)
        MyBase.New("Rööpkülik", kylgA, kylgB, kylgA, kylgB)
        Me.korgus = korgus
    End Sub

    Public Overrides Function leiaPindala() As Double
        Return korgus * kylgA
    End Function
End Class
