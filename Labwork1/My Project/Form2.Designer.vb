<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SampleTestTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TahomaRadioButton = New System.Windows.Forms.RadioButton()
        Me.MagnetoRadioButton = New System.Windows.Forms.RadioButton()
        Me.LoadPictureButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BoldItalic = New System.Windows.Forms.CheckBox()
        Me.Bold = New System.Windows.Forms.CheckBox()
        Me.Italic = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RedRadioButton = New System.Windows.Forms.RadioButton()
        Me.BlueRadioButton = New System.Windows.Forms.RadioButton()
        Me.GreenRadioButton = New System.Windows.Forms.RadioButton()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GaramondRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SampleTestTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(272, 133)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Display Test"
        '
        'SampleTestTextBox
        '
        Me.SampleTestTextBox.Location = New System.Drawing.Point(34, 53)
        Me.SampleTestTextBox.Name = "SampleTestTextBox"
        Me.SampleTestTextBox.Size = New System.Drawing.Size(179, 29)
        Me.SampleTestTextBox.TabIndex = 0
        Me.SampleTestTextBox.Text = "Sample test"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TahomaRadioButton)
        Me.GroupBox2.Controls.Add(Me.MagnetoRadioButton)
        Me.GroupBox2.Controls.Add(Me.GaramondRadioButton)
        Me.GroupBox2.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(314, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(555, 132)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Font"
        '
        'TahomaRadioButton
        '
        Me.TahomaRadioButton.AutoSize = True
        Me.TahomaRadioButton.Location = New System.Drawing.Point(412, 56)
        Me.TahomaRadioButton.Name = "TahomaRadioButton"
        Me.TahomaRadioButton.Size = New System.Drawing.Size(100, 26)
        Me.TahomaRadioButton.TabIndex = 1
        Me.TahomaRadioButton.TabStop = True
        Me.TahomaRadioButton.Text = "Tahoma"
        Me.TahomaRadioButton.UseVisualStyleBackColor = True
        '
        'MagnetoRadioButton
        '
        Me.MagnetoRadioButton.AutoSize = True
        Me.MagnetoRadioButton.Location = New System.Drawing.Point(217, 56)
        Me.MagnetoRadioButton.Name = "MagnetoRadioButton"
        Me.MagnetoRadioButton.Size = New System.Drawing.Size(104, 26)
        Me.MagnetoRadioButton.TabIndex = 1
        Me.MagnetoRadioButton.TabStop = True
        Me.MagnetoRadioButton.Text = "Magneto"
        Me.MagnetoRadioButton.UseVisualStyleBackColor = True
        '
        'LoadPictureButton
        '
        Me.LoadPictureButton.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadPictureButton.Location = New System.Drawing.Point(46, 457)
        Me.LoadPictureButton.Name = "LoadPictureButton"
        Me.LoadPictureButton.Size = New System.Drawing.Size(196, 46)
        Me.LoadPictureButton.TabIndex = 3
        Me.LoadPictureButton.Text = "Load Picture"
        Me.LoadPictureButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BoldItalic)
        Me.GroupBox3.Controls.Add(Me.Bold)
        Me.GroupBox3.Controls.Add(Me.Italic)
        Me.GroupBox3.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(314, 179)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(256, 244)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Font Style"
        '
        'BoldItalic
        '
        Me.BoldItalic.AutoSize = True
        Me.BoldItalic.Font = New System.Drawing.Font("Modern No. 20", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BoldItalic.Location = New System.Drawing.Point(19, 171)
        Me.BoldItalic.Name = "BoldItalic"
        Me.BoldItalic.Size = New System.Drawing.Size(134, 26)
        Me.BoldItalic.TabIndex = 2
        Me.BoldItalic.Text = "Bold Italic"
        Me.BoldItalic.UseVisualStyleBackColor = True
        '
        'Bold
        '
        Me.Bold.AutoSize = True
        Me.Bold.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bold.Location = New System.Drawing.Point(19, 107)
        Me.Bold.Name = "Bold"
        Me.Bold.Size = New System.Drawing.Size(79, 26)
        Me.Bold.TabIndex = 1
        Me.Bold.Text = "Bold"
        Me.Bold.UseVisualStyleBackColor = True
        '
        'Italic
        '
        Me.Italic.AutoSize = True
        Me.Italic.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Italic.Location = New System.Drawing.Point(19, 44)
        Me.Italic.Name = "Italic"
        Me.Italic.Size = New System.Drawing.Size(79, 26)
        Me.Italic.TabIndex = 0
        Me.Italic.Text = "Italic"
        Me.Italic.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RedRadioButton)
        Me.GroupBox4.Controls.Add(Me.BlueRadioButton)
        Me.GroupBox4.Controls.Add(Me.GreenRadioButton)
        Me.GroupBox4.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(613, 179)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(256, 244)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Font Color"
        '
        'RedRadioButton
        '
        Me.RedRadioButton.AutoSize = True
        Me.RedRadioButton.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedRadioButton.Location = New System.Drawing.Point(25, 171)
        Me.RedRadioButton.Name = "RedRadioButton"
        Me.RedRadioButton.Size = New System.Drawing.Size(67, 26)
        Me.RedRadioButton.TabIndex = 2
        Me.RedRadioButton.TabStop = True
        Me.RedRadioButton.Text = "Red"
        Me.RedRadioButton.UseVisualStyleBackColor = True
        '
        'BlueRadioButton
        '
        Me.BlueRadioButton.AutoSize = True
        Me.BlueRadioButton.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlueRadioButton.Location = New System.Drawing.Point(25, 109)
        Me.BlueRadioButton.Name = "BlueRadioButton"
        Me.BlueRadioButton.Size = New System.Drawing.Size(73, 26)
        Me.BlueRadioButton.TabIndex = 1
        Me.BlueRadioButton.TabStop = True
        Me.BlueRadioButton.Text = "Blue"
        Me.BlueRadioButton.UseVisualStyleBackColor = True
        '
        'GreenRadioButton
        '
        Me.GreenRadioButton.AutoSize = True
        Me.GreenRadioButton.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GreenRadioButton.Location = New System.Drawing.Point(25, 48)
        Me.GreenRadioButton.Name = "GreenRadioButton"
        Me.GreenRadioButton.Size = New System.Drawing.Size(83, 26)
        Me.GreenRadioButton.TabIndex = 0
        Me.GreenRadioButton.TabStop = True
        Me.GreenRadioButton.Text = "Green"
        Me.GreenRadioButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Modern No. 20", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(638, 457)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(113, 46)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(26, 191)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(258, 232)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'GaramondRadioButton
        '
        Me.GaramondRadioButton.AutoSize = True
        Me.GaramondRadioButton.Location = New System.Drawing.Point(43, 56)
        Me.GaramondRadioButton.Name = "GaramondRadioButton"
        Me.GaramondRadioButton.Size = New System.Drawing.Size(119, 26)
        Me.GaramondRadioButton.TabIndex = 0
        Me.GaramondRadioButton.TabStop = True
        Me.GaramondRadioButton.Text = "Garamond"
        Me.GaramondRadioButton.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(891, 534)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.LoadPictureButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Object Demonstrations"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents SampleTestTextBox As TextBox
    Friend WithEvents TahomaRadioButton As RadioButton
    Friend WithEvents MagnetoRadioButton As RadioButton
    Friend WithEvents LoadPictureButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BoldItalic As CheckBox
    Friend WithEvents Bold As CheckBox
    Friend WithEvents Italic As CheckBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RedRadioButton As RadioButton
    Friend WithEvents BlueRadioButton As RadioButton
    Friend WithEvents GreenRadioButton As RadioButton
    Friend WithEvents ExitButton As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GaramondRadioButton As RadioButton
End Class
