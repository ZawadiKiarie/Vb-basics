Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LoadObjectDemoButton.Click
        Dim form2 As New Form2()

        form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.Red
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim toolTip1 As New ToolTip()

        toolTip1.SetToolTip(LoadObjectDemoButton, "Click to Load Object Demonstrations")
        toolTip1.SetToolTip(ExitButton, "Click to Exit Application")
    End Sub
End Class
