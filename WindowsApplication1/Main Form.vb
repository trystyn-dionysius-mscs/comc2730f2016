' Name:  Average Project
' Purpose: Displays the average of 3 test scores
Public Class frmAvgcalc

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblAvgScore.Text = Val(txtScore1.Text) + (txtScore2.Text) + (txtScore3.Text) / 3
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblAvgScore.Text = String.Empty
        txtScore1.Text = String.Empty
        txtScore2.Text = String.Empty
        txtScore3.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
