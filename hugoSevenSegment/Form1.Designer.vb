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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button0 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(194, 52)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 102)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button0
        '
        Me.Button0.Enabled = False
        Me.Button0.Location = New System.Drawing.Point(69, 52)
        Me.Button0.Name = "Button0"
        Me.Button0.Size = New System.Drawing.Size(123, 34)
        Me.Button0.TabIndex = 14
        Me.Button0.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(69, 138)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(123, 35)
        Me.Button6.TabIndex = 20
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(69, 225)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 34)
        Me.Button3.TabIndex = 19
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(36, 157)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(31, 102)
        Me.Button4.TabIndex = 18
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(36, 52)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(31, 102)
        Me.Button5.TabIndex = 17
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(194, 157)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 102)
        Me.Button2.TabIndex = 16
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(260, 310)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button0)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button0 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
End Class
