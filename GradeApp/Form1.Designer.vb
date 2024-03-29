<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblSubject1 = New System.Windows.Forms.Label()
        Me.lblSubject2 = New System.Windows.Forms.Label()
        Me.lblSubject3 = New System.Windows.Forms.Label()
        Me.lblSubject4 = New System.Windows.Forms.Label()
        Me.txtSubject1 = New System.Windows.Forms.TextBox()
        Me.txtSubject2 = New System.Windows.Forms.TextBox()
        Me.txtSubject3 = New System.Windows.Forms.TextBox()
        Me.txtSubject4 = New System.Windows.Forms.TextBox()
        Me.btngrade = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSubject1
        '
        Me.lblSubject1.AutoSize = True
        Me.lblSubject1.Location = New System.Drawing.Point(181, 90)
        Me.lblSubject1.Name = "lblSubject1"
        Me.lblSubject1.Size = New System.Drawing.Size(72, 20)
        Me.lblSubject1.TabIndex = 0
        Me.lblSubject1.Text = "Subject1"
        '
        'lblSubject2
        '
        Me.lblSubject2.AutoSize = True
        Me.lblSubject2.Location = New System.Drawing.Point(181, 141)
        Me.lblSubject2.Name = "lblSubject2"
        Me.lblSubject2.Size = New System.Drawing.Size(76, 20)
        Me.lblSubject2.TabIndex = 1
        Me.lblSubject2.Text = "Subject 2"
        '
        'lblSubject3
        '
        Me.lblSubject3.AutoSize = True
        Me.lblSubject3.Location = New System.Drawing.Point(181, 192)
        Me.lblSubject3.Name = "lblSubject3"
        Me.lblSubject3.Size = New System.Drawing.Size(76, 20)
        Me.lblSubject3.TabIndex = 2
        Me.lblSubject3.Text = "Subject 3"
        '
        'lblSubject4
        '
        Me.lblSubject4.AutoSize = True
        Me.lblSubject4.Location = New System.Drawing.Point(181, 243)
        Me.lblSubject4.Name = "lblSubject4"
        Me.lblSubject4.Size = New System.Drawing.Size(76, 20)
        Me.lblSubject4.TabIndex = 3
        Me.lblSubject4.Text = "Subject 4"
        '
        'txtSubject1
        '
        Me.txtSubject1.Location = New System.Drawing.Point(342, 87)
        Me.txtSubject1.Name = "txtSubject1"
        Me.txtSubject1.Size = New System.Drawing.Size(190, 26)
        Me.txtSubject1.TabIndex = 4
        '
        'txtSubject2
        '
        Me.txtSubject2.Location = New System.Drawing.Point(342, 139)
        Me.txtSubject2.Name = "txtSubject2"
        Me.txtSubject2.Size = New System.Drawing.Size(190, 26)
        Me.txtSubject2.TabIndex = 5
        '
        'txtSubject3
        '
        Me.txtSubject3.Location = New System.Drawing.Point(342, 191)
        Me.txtSubject3.Name = "txtSubject3"
        Me.txtSubject3.Size = New System.Drawing.Size(190, 26)
        Me.txtSubject3.TabIndex = 6
        '
        'txtSubject4
        '
        Me.txtSubject4.Location = New System.Drawing.Point(342, 243)
        Me.txtSubject4.Name = "txtSubject4"
        Me.txtSubject4.Size = New System.Drawing.Size(190, 26)
        Me.txtSubject4.TabIndex = 7
        '
        'btngrade
        '
        Me.btngrade.Location = New System.Drawing.Point(245, 302)
        Me.btngrade.Name = "btngrade"
        Me.btngrade.Size = New System.Drawing.Size(190, 73)
        Me.btngrade.TabIndex = 8
        Me.btngrade.Text = "get grade"
        Me.btngrade.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btngrade)
        Me.Controls.Add(Me.txtSubject4)
        Me.Controls.Add(Me.txtSubject3)
        Me.Controls.Add(Me.txtSubject2)
        Me.Controls.Add(Me.txtSubject1)
        Me.Controls.Add(Me.lblSubject4)
        Me.Controls.Add(Me.lblSubject3)
        Me.Controls.Add(Me.lblSubject2)
        Me.Controls.Add(Me.lblSubject1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSubject1 As Label
    Friend WithEvents lblSubject2 As Label
    Friend WithEvents lblSubject3 As Label
    Friend WithEvents lblSubject4 As Label
    Friend WithEvents txtSubject1 As TextBox
    Friend WithEvents txtSubject2 As TextBox
    Friend WithEvents txtSubject3 As TextBox
    Friend WithEvents txtSubject4 As TextBox
    Friend WithEvents btngrade As Button
End Class
