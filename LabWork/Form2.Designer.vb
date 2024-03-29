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
        Me.gbDisplayTest = New System.Windows.Forms.GroupBox()
        Me.txtSampleTest = New System.Windows.Forms.TextBox()
        Me.gbFont = New System.Windows.Forms.GroupBox()
        Me.rbTahoma = New System.Windows.Forms.RadioButton()
        Me.rbMagneto = New System.Windows.Forms.RadioButton()
        Me.rbGaramond = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbFontStyle = New System.Windows.Forms.GroupBox()
        Me.CheckBoxBoldItalic = New System.Windows.Forms.CheckBox()
        Me.CheckBoxBold = New System.Windows.Forms.CheckBox()
        Me.CheckBoxItalic = New System.Windows.Forms.CheckBox()
        Me.gbFontColor = New System.Windows.Forms.GroupBox()
        Me.rbRed = New System.Windows.Forms.RadioButton()
        Me.rbBlue = New System.Windows.Forms.RadioButton()
        Me.rbGreen = New System.Windows.Forms.RadioButton()
        Me.btnLoadPicture = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.gbDisplayTest.SuspendLayout()
        Me.gbFont.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbFontStyle.SuspendLayout()
        Me.gbFontColor.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbDisplayTest
        '
        Me.gbDisplayTest.Controls.Add(Me.txtSampleTest)
        Me.gbDisplayTest.Location = New System.Drawing.Point(39, 37)
        Me.gbDisplayTest.Name = "gbDisplayTest"
        Me.gbDisplayTest.Size = New System.Drawing.Size(206, 123)
        Me.gbDisplayTest.TabIndex = 0
        Me.gbDisplayTest.TabStop = False
        Me.gbDisplayTest.Text = "Display Test"
        '
        'txtSampleTest
        '
        Me.txtSampleTest.Location = New System.Drawing.Point(24, 49)
        Me.txtSampleTest.Name = "txtSampleTest"
        Me.txtSampleTest.Size = New System.Drawing.Size(151, 26)
        Me.txtSampleTest.TabIndex = 0
        '
        'gbFont
        '
        Me.gbFont.Controls.Add(Me.rbTahoma)
        Me.gbFont.Controls.Add(Me.rbMagneto)
        Me.gbFont.Controls.Add(Me.rbGaramond)
        Me.gbFont.Location = New System.Drawing.Point(286, 37)
        Me.gbFont.Name = "gbFont"
        Me.gbFont.Size = New System.Drawing.Size(483, 123)
        Me.gbFont.TabIndex = 1
        Me.gbFont.TabStop = False
        Me.gbFont.Text = "Font"
        '
        'rbTahoma
        '
        Me.rbTahoma.AutoSize = True
        Me.rbTahoma.Location = New System.Drawing.Point(314, 47)
        Me.rbTahoma.Name = "rbTahoma"
        Me.rbTahoma.Size = New System.Drawing.Size(92, 24)
        Me.rbTahoma.TabIndex = 2
        Me.rbTahoma.TabStop = True
        Me.rbTahoma.Text = "Tahoma"
        Me.rbTahoma.UseVisualStyleBackColor = True
        '
        'rbMagneto
        '
        Me.rbMagneto.AutoSize = True
        Me.rbMagneto.Location = New System.Drawing.Point(191, 47)
        Me.rbMagneto.Name = "rbMagneto"
        Me.rbMagneto.Size = New System.Drawing.Size(97, 24)
        Me.rbMagneto.TabIndex = 1
        Me.rbMagneto.TabStop = True
        Me.rbMagneto.Text = "Magneto"
        Me.rbMagneto.UseVisualStyleBackColor = True
        '
        'rbGaramond
        '
        Me.rbGaramond.AutoSize = True
        Me.rbGaramond.Location = New System.Drawing.Point(55, 47)
        Me.rbGaramond.Name = "rbGaramond"
        Me.rbGaramond.Size = New System.Drawing.Size(110, 24)
        Me.rbGaramond.TabIndex = 0
        Me.rbGaramond.TabStop = True
        Me.rbGaramond.Text = "Garamond"
        Me.rbGaramond.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(42, 175)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(202, 199)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'gbFontStyle
        '
        Me.gbFontStyle.Controls.Add(Me.CheckBoxBoldItalic)
        Me.gbFontStyle.Controls.Add(Me.CheckBoxBold)
        Me.gbFontStyle.Controls.Add(Me.CheckBoxItalic)
        Me.gbFontStyle.Location = New System.Drawing.Point(286, 175)
        Me.gbFontStyle.Name = "gbFontStyle"
        Me.gbFontStyle.Size = New System.Drawing.Size(209, 199)
        Me.gbFontStyle.TabIndex = 3
        Me.gbFontStyle.TabStop = False
        Me.gbFontStyle.Text = "Font Style"
        '
        'CheckBoxBoldItalic
        '
        Me.CheckBoxBoldItalic.AutoSize = True
        Me.CheckBoxBoldItalic.Location = New System.Drawing.Point(37, 131)
        Me.CheckBoxBoldItalic.Name = "CheckBoxBoldItalic"
        Me.CheckBoxBoldItalic.Size = New System.Drawing.Size(104, 24)
        Me.CheckBoxBoldItalic.TabIndex = 2
        Me.CheckBoxBoldItalic.Text = "Bold Italic"
        Me.CheckBoxBoldItalic.UseVisualStyleBackColor = True
        '
        'CheckBoxBold
        '
        Me.CheckBoxBold.AutoSize = True
        Me.CheckBoxBold.Location = New System.Drawing.Point(37, 85)
        Me.CheckBoxBold.Name = "CheckBoxBold"
        Me.CheckBoxBold.Size = New System.Drawing.Size(67, 24)
        Me.CheckBoxBold.TabIndex = 1
        Me.CheckBoxBold.Text = "Bold"
        Me.CheckBoxBold.UseVisualStyleBackColor = True
        '
        'CheckBoxItalic
        '
        Me.CheckBoxItalic.AutoSize = True
        Me.CheckBoxItalic.Location = New System.Drawing.Point(37, 39)
        Me.CheckBoxItalic.Name = "CheckBoxItalic"
        Me.CheckBoxItalic.Size = New System.Drawing.Size(68, 24)
        Me.CheckBoxItalic.TabIndex = 0
        Me.CheckBoxItalic.Text = "Italic"
        Me.CheckBoxItalic.UseVisualStyleBackColor = True
        '
        'gbFontColor
        '
        Me.gbFontColor.Controls.Add(Me.rbRed)
        Me.gbFontColor.Controls.Add(Me.rbBlue)
        Me.gbFontColor.Controls.Add(Me.rbGreen)
        Me.gbFontColor.Location = New System.Drawing.Point(538, 175)
        Me.gbFontColor.Name = "gbFontColor"
        Me.gbFontColor.Size = New System.Drawing.Size(209, 199)
        Me.gbFontColor.TabIndex = 4
        Me.gbFontColor.TabStop = False
        Me.gbFontColor.Text = "Font Color"
        '
        'rbRed
        '
        Me.rbRed.AutoSize = True
        Me.rbRed.Location = New System.Drawing.Point(48, 131)
        Me.rbRed.Name = "rbRed"
        Me.rbRed.Size = New System.Drawing.Size(64, 24)
        Me.rbRed.TabIndex = 2
        Me.rbRed.TabStop = True
        Me.rbRed.Text = "Red"
        Me.rbRed.UseVisualStyleBackColor = True
        '
        'rbBlue
        '
        Me.rbBlue.AutoSize = True
        Me.rbBlue.Location = New System.Drawing.Point(48, 86)
        Me.rbBlue.Name = "rbBlue"
        Me.rbBlue.Size = New System.Drawing.Size(66, 24)
        Me.rbBlue.TabIndex = 1
        Me.rbBlue.TabStop = True
        Me.rbBlue.Text = "Blue"
        Me.rbBlue.UseVisualStyleBackColor = True
        '
        'rbGreen
        '
        Me.rbGreen.AutoSize = True
        Me.rbGreen.Location = New System.Drawing.Point(48, 41)
        Me.rbGreen.Name = "rbGreen"
        Me.rbGreen.Size = New System.Drawing.Size(79, 24)
        Me.rbGreen.TabIndex = 0
        Me.rbGreen.TabStop = True
        Me.rbGreen.Text = "Green"
        Me.rbGreen.UseVisualStyleBackColor = True
        '
        'btnLoadPicture
        '
        Me.btnLoadPicture.Location = New System.Drawing.Point(49, 398)
        Me.btnLoadPicture.Name = "btnLoadPicture"
        Me.btnLoadPicture.Size = New System.Drawing.Size(150, 43)
        Me.btnLoadPicture.TabIndex = 5
        Me.btnLoadPicture.Text = "Load Picture"
        Me.btnLoadPicture.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(573, 398)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 42)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnLoadPicture)
        Me.Controls.Add(Me.gbFontColor)
        Me.Controls.Add(Me.gbFontStyle)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbFont)
        Me.Controls.Add(Me.gbDisplayTest)
        Me.Name = "Form2"
        Me.Text = "Object Demonstrations"
        Me.gbDisplayTest.ResumeLayout(False)
        Me.gbDisplayTest.PerformLayout()
        Me.gbFont.ResumeLayout(False)
        Me.gbFont.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbFontStyle.ResumeLayout(False)
        Me.gbFontStyle.PerformLayout()
        Me.gbFontColor.ResumeLayout(False)
        Me.gbFontColor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbDisplayTest As GroupBox
    Friend WithEvents gbFont As GroupBox
    Friend WithEvents rbTahoma As RadioButton
    Friend WithEvents rbMagneto As RadioButton
    Friend WithEvents rbGaramond As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents gbFontStyle As GroupBox
    Friend WithEvents gbFontColor As GroupBox
    Friend WithEvents CheckBoxBoldItalic As CheckBox
    Friend WithEvents CheckBoxBold As CheckBox
    Friend WithEvents CheckBoxItalic As CheckBox
    Friend WithEvents rbRed As RadioButton
    Friend WithEvents rbBlue As RadioButton
    Friend WithEvents rbGreen As RadioButton
    Friend WithEvents btnLoadPicture As Button
    Friend WithEvents txtSampleTest As TextBox
    Friend WithEvents btnExit As Button
End Class
