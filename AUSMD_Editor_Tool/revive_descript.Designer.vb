<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class revive_descript
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
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox23 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TextBox22 = New System.Windows.Forms.TextBox()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 89)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(116, 13)
        Me.Label26.TabIndex = 68
        Me.Label26.Text = "Revive Bleedout Delay"
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(125, 86)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(225, 20)
        Me.TextBox23.TabIndex = 65
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(0, 63)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(119, 13)
        Me.Label25.TabIndex = 67
        Me.Label25.Text = "Revive Force Respawn"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(125, 60)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(225, 20)
        Me.TextBox22.TabIndex = 64
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(125, 34)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(225, 20)
        Me.TextBox21.TabIndex = 63
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(48, 37)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(71, 13)
        Me.Label24.TabIndex = 66
        Me.Label24.Text = "Revive Delay"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox1.TabIndex = 69
        Me.CheckBox1.Text = "Use Revive"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'revive_descript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 118)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.TextBox23)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.TextBox22)
        Me.Controls.Add(Me.TextBox21)
        Me.Controls.Add(Me.Label24)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "revive_descript"
        Me.Text = "revive_descript"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
