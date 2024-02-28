Imports System.Math
Public Class formKujundid
    Private Sub tootleKujund(ByRef kujund As Kujund)
        lblTyyp.Text = kujund.annaTyyp

        txtPindala.Text = Round(kujund.leiaPindala, comboNum.SelectedItem)
        txtYmbermoot.Text = Round(kujund.leiaYmberMoot, comboNum.SelectedItem)
    End Sub

    Private Sub btnKolmnurk_Click(sender As Object, e As EventArgs) Handles btnKolmnurk.Click
        If Not String.IsNullOrEmpty(txtKylgA.Text) And Not String.IsNullOrEmpty(txtKylgB.Text) Then
            Dim objektKolmnurk As New Kolmnurk(txtKylgA.Text, txtKylgB.Text)
            tootleKujund(objektKolmnurk)
        Else
            txtPindala.Text = "error"
            txtYmbermoot.Text = "error"
        End If
    End Sub

    Private Sub btnRuut_Click(sender As Object, e As EventArgs) Handles btnRuut.Click
        If Not String.IsNullOrEmpty(txtKylgA.Text) Then
            Dim objektRuut As New Ruut(txtKylgA.Text)
            tootleKujund(objektRuut)
        Else
            txtPindala.Text = "error"
            txtYmbermoot.Text = "error"
        End If
    End Sub

    Private Sub btnRistkylik_Click(sender As Object, e As EventArgs) Handles btnRistkylik.Click
        If Not String.IsNullOrEmpty(txtKylgA.Text) And Not String.IsNullOrEmpty(txtKylgB.Text) Then
            tootleKujund(New Ristkylik(txtKylgA.Text, txtKylgB.Text))
        Else
            txtPindala.Text = "error"
            txtYmbermoot.Text = "error"
        End If

    End Sub

    Private Sub formKujundid_Load(sender As Object, e As EventArgs) Handles Me.Load

        comboNum.Items.Add(0)
        comboNum.Items.Add(1)
        comboNum.Items.Add(2)
        comboNum.Items.Add(3)

        comboNum.SelectedIndex = 0
    End Sub

    Private Sub btnRomb_Click(sender As Object, e As EventArgs) Handles btnRomb.Click
        If Not String.IsNullOrEmpty(txtKylgA.Text) And Not String.IsNullOrEmpty(txtKorgus.Text) Then
            tootleKujund(New Romb(txtKylgA.Text, txtKorgus.Text))
        Else
            txtPindala.Text = "error"
            txtYmbermoot.Text = "error"
        End If
    End Sub

    Private Sub btnKylik_Click(sender As Object, e As EventArgs) Handles btnKylik.Click
        If Not String.IsNullOrEmpty(txtKylgA.Text) And Not String.IsNullOrEmpty(txtKylgB.Text) _
            And Not String.IsNullOrEmpty(txtKorgus.Text) Then
            tootleKujund(New Rööpkylik(txtKylgA.Text, txtKylgB.Text, txtKorgus.Text))
        Else
            txtPindala.Text = "error"
            txtYmbermoot.Text = "error"
        End If

    End Sub

    Private Sub txtKylgA_TextChanged(sender As Object, e As EventArgs) Handles txtKylgA.TextChanged
        If Not IsNumeric(txtKylgA.Text) Then
            txtKylgA.Text = ""
        End If
    End Sub

    Private Sub txtKylgB_TextChanged(sender As Object, e As EventArgs) Handles txtKylgB.TextChanged
        If Not IsNumeric(txtKylgB.Text) Then
            txtKylgB.Text = ""
        End If
    End Sub

    Private Sub txtKorgus_TextChanged(sender As Object, e As EventArgs) Handles txtKorgus.TextChanged
        If Not IsNumeric(txtKorgus.Text) Then
            txtKorgus.Text = ""
        End If
    End Sub
End Class
