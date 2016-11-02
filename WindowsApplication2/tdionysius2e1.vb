Public Class tdionysius2E1
    Private Sub btnCalcAND_Click(sender As Object, e As EventArgs) Handles btnCalcAND.Click
        If txtOrder.Text >= "100" And txtYN.Text.ToUpper = "Y" Or txtYN.Text.ToUpper = "y" Then lblShipping.Text = "9"
    End Sub

    Private Sub btnCalcOR_Click(sender As Object, e As EventArgs) Handles btnCalcOR.Click

    End Sub

    Private Sub txtYN_TextChanged(sender As Object, e As EventArgs) Handles txtYN.TextChanged

    End Sub
End Class
