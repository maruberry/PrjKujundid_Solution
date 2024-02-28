Public MustInherit Class Kujund
    Private tyyp As String
    Protected kylgA As Double
    Protected kylgB As Double
    Protected kylgC As Double

    Public Sub New(ByVal tyyp As String, ByVal kylgA As Double,
                   ByVal kylgB As Double, ByVal kylgC As Double)
        Me.tyyp = tyyp
        Me.kylgA = kylgA
        Me.kylgB = kylgB
        Me.kylgC = kylgC
    End Sub

    Public Function annaTyyp() As String
        Return tyyp
    End Function

    Public MustOverride Function leiaYmberMoot() As Double

    Public MustOverride Function leiaPindala() As Double
End Class
