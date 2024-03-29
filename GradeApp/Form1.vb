Public Class Form1
    Private Sub btngrade_Click(sender As Object, e As EventArgs) Handles btngrade.Click
        Dim iSub1, iSub2, iSub3, iSub4 As Integer
        Dim iAverage As Decimal


        iSub1 = txtSubject1.Text
        iSub2 = txtSubject2.Text
        iSub3 = txtSubject3.Text
        iSub4 = txtSubject4.Text

        iAverage = (iSub1 + iSub2 + iSub3 + iSub4) / 4

        If iAverage < 50 Then
            MsgBox("Fail")
        ElseIf iAverage < 65 Then
            MsgBox("C")
        ElseIf iAverage < 75 Then
            MsgBox("B")
        Else
            MsgBox("A")
        End If
    End Sub
End Class
