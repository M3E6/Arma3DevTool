<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class debrief_descript
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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox17 = New System.Windows.Forms.TextBox()
        Me.TextBox16 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox15 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox14 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(91, 149)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(191, 26)
        Me.Label19.TabIndex = 82
        Me.Label19.Text = "Note: The bracket at the end is added " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "automatically"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(10, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 81
        Me.Button2.Text = "Add Entry"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(10, 176)
        Me.TextBox17.Multiline = True
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox17.Size = New System.Drawing.Size(290, 253)
        Me.TextBox17.TabIndex = 80
        Me.TextBox17.Text = "class cfgDebriefing " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "{" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " "
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(70, 120)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(230, 20)
        Me.TextBox16.TabIndex = 79
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 120)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(40, 13)
        Me.Label18.TabIndex = 78
        Me.Label18.Text = "Picture"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(70, 94)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(230, 20)
        Me.TextBox15.TabIndex = 77
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(7, 97)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 13)
        Me.Label17.TabIndex = 76
        Me.Label17.Text = "Description"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(70, 68)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(230, 20)
        Me.TextBox14.TabIndex = 75
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Title"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(70, 42)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(230, 20)
        Me.TextBox13.TabIndex = 73
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 72
        Me.Label15.Text = "Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(55, -30)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Debriefing"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(13, 13)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(96, 17)
        Me.CheckBox1.TabIndex = 83
        Me.CheckBox1.Text = "Use Debriefing"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'debrief_descript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 434)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox17)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TextBox15)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "debrief_descript"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "debrief_descript"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
