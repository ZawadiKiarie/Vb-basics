Public Class Form2
    Private Sub GaramondRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondRadioButton.CheckedChanged
        If GaramondRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Garamond", SampleTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub MagnetoRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoRadioButton.CheckedChanged
        If MagnetoRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Magneto", SampleTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub TahomaRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles TahomaRadioButton.CheckedChanged
        If TahomaRadioButton.Checked Then
            SampleTestTextBox.Font = New Font("Tahoma", SampleTestTextBox.Font.Size)
        End If
    End Sub

    Private Sub Italic_CheckedChanged(sender As Object, e As EventArgs) Handles Italic.CheckedChanged
        UpdateSampleTestFontStyle()
    End Sub

    Private Sub Bold_CheckedChanged(sender As Object, e As EventArgs) Handles Bold.CheckedChanged
        UpdateSampleTestFontStyle()
    End Sub

    Private Sub BoldItalic_CheckedChanged(sender As Object, e As EventArgs) Handles BoldItalic.CheckedChanged
        UpdateSampleTestFontStyle()
    End Sub

    Private Sub UpdateSampleTestFontStyle()
        Dim style As FontStyle = FontStyle.Regular

        If Italic.Checked Then
            style = style Or FontStyle.Italic
        End If

        If Bold.Checked Then
            style = style Or FontStyle.Bold
        End If

        If BoldItalic.Checked Then
            style = style Or FontStyle.Bold Or FontStyle.Italic
        End If

        SampleTestTextBox.Font = New Font(SampleTestTextBox.Font, style)
    End Sub

    Private Sub GreenRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles GreenRadioButton.CheckedChanged
        If GreenRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Green
        End If
    End Sub

    Private Sub BlueRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles BlueRadioButton.CheckedChanged
        If BlueRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RedRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RedRadioButton.CheckedChanged
        If RedRadioButton.Checked Then
            SampleTestTextBox.ForeColor = Color.Red
        End If
    End Sub

    Private Sub LoadPictureButton_Click(sender As Object, e As EventArgs) Handles LoadPictureButton.Click
        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        openFileDialog.Title = "Select an Image File"
        openFileDialog.Multiselect = False ' 

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = openFileDialog.FileName

            Try
                Dim selectedImage As Image = Image.FromFile(selectedFilePath)

                PictureBox1.Image = selectedImage
            Catch ex As Exception
                MessageBox.Show("Error loading the image: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class