Public Class Ruut
    Inherits Nelinurk

    Public Sub New(ByVal kylg As Double)
        MyBase.New("Ruut", kylg, kylg, kylg, kylg)
    End Sub

    Public Overrides Function leiaPindala() As Double
        Return kylgA * kylgB
    End Function
End Class
