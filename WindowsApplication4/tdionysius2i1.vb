Option Strict On
Option Infer Off

Public Class tdionysius2i1
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        '#03: Insert
        Dim strWord As String = txt03RemoveInsert.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert.Text = strWord

        '#04: Substring
        Dim strItem As String = txt04Substring.Text
        strItem = strItem.Remove(2, 5)
        strItem = strItem.Remove(0, 2)
        strItem = strItem.Insert(0, "Blue")
        lbl04Substring.Text = strItem

        '#05a: Length
        Dim strDisk As String = txt05aLength.Text
        Dim intNumChars As Integer = txt05aLength.Text.IndexOf(strDisk)


        '#05b: Trim
        Dim strRed As String = txt05bTrim.Text
        strRed = txt05bTrim.Text.Trim
        lbl05bTrim.Text = strRed

        '#05c: Remove/Insert
        Dim strCate As String = txt05cRandomInsert.Text
        strCate = strCate.Remove(1, 2)
        strCate = strCate.Insert(1, "ritt")
        lbl05cRemoveInsert.Text = strCate

        '#05d: Insert
        Dim strNum As String = txt05dInsert.Text
        strNum = strNum.Insert(0, "Mon")
        lbl05dInsert.Text = strNum

        '#05e: Pad
        Dim strPay As String = txt05ePad.Text
        strPay = strPay.PadLeft(10, "*"c)
        lbl05ePad.Text = strPay

        '#06 Remove
        Dim strAmount As String = txt06Remove.Text
        strAmount = strAmount.Remove(1, 1)
        lbl06Remove.Text = strAmount

        '#07 Contain
        Dim strAddress As String = txt07Contain.Text
        Dim blnIsContained As Boolean
        blnIsContained = strAddress.Contains("308 JEfFeRsOn StFoUnD")
        If blnIsContained = False Then
            lbl07Contain.Text = "St. Jeff Not Found"
            If blnIsContained = True Then
                lbl07Contain.Text = "St. Jeff Found"
            End If
        End If

        '#12 Len/Remove
        Dim strPercent As String = txt12LenRemove.Text
        Dim intCommaIndex As Integer

        '#13 Like
        Dim strId As String = txt13Like.Text
        If strId Like "***" Then
            lbl13Like.Text = "Shipping $25"
        ElseIf strId Like "***" Then
            lbl13Like.Text = "Shipping $30"
        End If
        lbl13Like.Text = strId
        txt13Like.Focus()
    End Sub
End Class
