Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub btnLoadObjectDemo_Click(sender As Object, e As EventArgs) Handles btnLoadObjectDemo.Click
        Dim form2 As New Form2()

        form2.ShowDialog()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolTip1.SetToolTip(btnLoadObjectDemo, "Load Object Demo")
        ToolTip2.SetToolTip(btnExit, "Exit")
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        ' Maximize the form
        Me.WindowState = FormWindowState.Maximized

        ' Change background color to red
        Me.BackColor = Color.Red
    End Sub
End Class
