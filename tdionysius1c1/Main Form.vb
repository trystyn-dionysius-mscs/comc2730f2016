﻿Public Class frmPark

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        frmStarWars.Show()
        Timer1.Enabled = False
        'Me.Close()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        frmTucan.Show()
        Timer2.Enabled = False
        'Me.Close()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Me.Close()
    End Sub
End Class
