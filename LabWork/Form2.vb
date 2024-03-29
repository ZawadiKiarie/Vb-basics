Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub rbGaramond_CheckedChanged(sender As Object, e As EventArgs) Handles rbGaramond.CheckedChanged
        If rbGaramond.Checked Then
            txtSampleTest.Font = New Font("Garamond", txtSampleTest.Font.Size, txtSampleTest.Font.Style)
        End If
    End Sub

    Private Sub rbMagneto_CheckedChanged(sender As Object, e As EventArgs) Handles rbMagneto.CheckedChanged
        If rbMagneto.Checked Then
            txtSampleTest.Font = New Font("Magneto", txtSampleTest.Font.Size, txtSampleTest.Font.Style)
        End If
    End Sub

    Private Sub rbTahoma_CheckedChanged(sender As Object, e As EventArgs) Handles rbTahoma.CheckedChanged
        If rbTahoma.Checked Then
            txtSampleTest.Font = New Font("Tahoma", txtSampleTest.Font.Size, txtSampleTest.Font.Style)
        End If
    End Sub

    Private Sub CheckBoxItalic_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxItalic.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub CheckBoxBold_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBold.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub CheckBoxBoldItalic_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxBoldItalic.CheckedChanged
        UpdateFontStyle()
    End Sub

    Private Sub UpdateFontStyle()
        Dim style As FontStyle = FontStyle.Regular

        If CheckBoxBold.Checked Then
            style = style Or FontStyle.Bold
        End If

        If CheckBoxItalic.Checked Then
            style = style Or FontStyle.Italic
        End If

        If CheckBoxBoldItalic.Checked Then
            style = style Or FontStyle.Bold Or FontStyle.Italic
        End If

        txtSampleTest.Font = New Font(txtSampleTest.Font.FontFamily, txtSampleTest.Font.Size, style)
    End Sub

    Private Sub rbGreen_CheckedChanged(sender As Object, e As EventArgs) Handles rbGreen.CheckedChanged
        UpdateFontColor()
    End Sub

    Private Sub rbBlue_CheckedChanged(sender As Object, e As EventArgs) Handles rbBlue.CheckedChanged
        UpdateFontColor()
    End Sub

    Private Sub rbRed_CheckedChanged(sender As Object, e As EventArgs) Handles rbRed.CheckedChanged
        UpdateFontColor()
    End Sub

    Private Sub UpdateFontColor()
        If rbGreen.Checked Then
            txtSampleTest.ForeColor = Color.Green
        ElseIf rbBlue.Checked Then
            txtSampleTest.ForeColor = Color.Blue
        ElseIf rbRed.Checked Then
            txtSampleTest.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnLoadPicture_Click(sender As Object, e As EventArgs) Handles btnLoadPicture.Click
        ' Create an instance of OpenFileDialog
        Dim openFileDialog As New OpenFileDialog()

        ' Set properties of the OpenFileDialog
        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.png;*.gif)|*.bmp;*.jpg;*.png;*.gif|All files (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        ' Show the OpenFileDialog and check if the user selected a file
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Load the selected image into the PictureBox
                PictureBox1.Image = Image.FromFile(openFileDialog.FileName)
            Catch ex As Exception
                MessageBox.Show("Error loading image: " & ex.Message)
            End Try
        End If
    End Sub
End Class