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
        Me.components = New System.ComponentModel.Container()
        Me.LoadObjectDemoButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'LoadObjectDemoButton
        '
        Me.LoadObjectDemoButton.Font = New System.Drawing.Font("Modern No. 20", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoadObjectDemoButton.Location = New System.Drawing.Point(76, 155)
        Me.LoadObjectDemoButton.Name = "LoadObjectDemoButton"
        Me.LoadObjectDemoButton.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.LoadObjectDemoButton.Size = New System.Drawing.Size(221, 58)
        Me.LoadObjectDemoButton.TabIndex = 0
        Me.LoadObjectDemoButton.Text = "Load Object Demo"
        Me.LoadObjectDemoButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.LoadObjectDemoButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Modern No. 20", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(382, 155)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Padding = New System.Windows.Forms.Padding(10, 5, 0, 0)
        Me.ExitButton.Size = New System.Drawing.Size(216, 58)
        Me.ExitButton.TabIndex = 1
        Me.ExitButton.Text = "EXIT"
        Me.ExitButton.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.LoadObjectDemoButton)
        Me.Name = "Form1"
        Me.Text = "Welcome form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LoadObjectDemoButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
