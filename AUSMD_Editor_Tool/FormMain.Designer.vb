<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(15, 33)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Light Generator"
        Me.ToolTip1.SetToolTip(Me.Button1, "Light point generator lets you enter parameters to create lights in-game.")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(153, 63)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(108, 25)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Color Finder"
        Me.ToolTip1.SetToolTip(Me.Button2, "Color Finder lets you find RGB or hex values to values that arma can use.")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(153, 34)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 25)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Intel Generator"
        Me.ToolTip1.SetToolTip(Me.Button3, "Intel Generator lets you create code that makes intel objects useable")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Created by austin_medic"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Click any button below to open that respective menu."
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(15, 62)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(108, 25)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Task Generator"
        Me.ToolTip1.SetToolTip(Me.Button4, "Task Generator lets you create tasks easily by filling out parameters.")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(234, 364)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(27, 25)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Button5, "Extra Info")
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(153, 93)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(108, 25)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Script Snippets"
        Me.ToolTip1.SetToolTip(Me.Button6, "This is a list of script snippets that could be useful in any mission.")
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(15, 92)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(108, 25)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Note Creator"
        Me.ToolTip1.SetToolTip(Me.Button7, "Note creator lets you fill out parameters then export code that will create a ""Si" & _
        "tuations""" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " section in the map before and during the mission.")
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(153, 122)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(108, 25)
        Me.Button8.TabIndex = 8
        Me.Button8.Text = "Notification Creator"
        Me.ToolTip1.SetToolTip(Me.Button8, "Notification Creator lets you create notifications for your missions.")
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button9.Location = New System.Drawing.Point(153, 151)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(108, 25)
        Me.Button9.TabIndex = 9
        Me.Button9.Text = "Description.ext"
        Me.ToolTip1.SetToolTip(Me.Button9, "Description.ext Creator helps you to build description.ext files")
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(15, 121)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(108, 25)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "Script Creator"
        Me.ToolTip1.SetToolTip(Me.Button10, "Script creator lets you easily build code blocks using buttons")
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button11.Location = New System.Drawing.Point(15, 150)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(108, 25)
        Me.Button11.TabIndex = 11
        Me.Button11.Text = "AddAction Creator"
        Me.ToolTip1.SetToolTip(Me.Button11, "AddAction Creator lets you create actions easily")
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button13.Location = New System.Drawing.Point(15, 180)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(108, 25)
        Me.Button13.TabIndex = 13
        Me.Button13.Text = "BIS_fnc_MP"
        Me.ToolTip1.SetToolTip(Me.Button13, "BIS_fnc_MP tool helps you to create functions to send things across the network")
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button12.Location = New System.Drawing.Point(153, 180)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(108, 25)
        Me.Button12.TabIndex = 14
        Me.Button12.Text = "Command List"
        Me.ToolTip1.SetToolTip(Me.Button12, "This opens the scripting command list on the biki")
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button20.Location = New System.Drawing.Point(15, 211)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(108, 25)
        Me.Button20.TabIndex = 21
        Me.Button20.Text = "Help Form"
        Me.ToolTip1.SetToolTip(Me.Button20, "Help form for various other forms in this program." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.Button20.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button14.Location = New System.Drawing.Point(151, 211)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(108, 25)
        Me.Button14.TabIndex = 22
        Me.Button14.Text = "RPT Helper"
        Me.ToolTip1.SetToolTip(Me.Button14, "This opens the scripting command list on the biki")
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button15.Location = New System.Drawing.Point(15, 242)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(246, 25)
        Me.Button15.TabIndex = 23
        Me.Button15.Text = "Structured Text Editor"
        Me.ToolTip1.SetToolTip(Me.Button15, "This opens the scripting command list on the biki")
        Me.Button15.UseVisualStyleBackColor = True
        '
        'Button16
        '
        Me.Button16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button16.Location = New System.Drawing.Point(15, 273)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(246, 25)
        Me.Button16.TabIndex = 24
        Me.Button16.Text = "File Header Creator"
        Me.ToolTip1.SetToolTip(Me.Button16, "This allows you to add file headers to your scripts")
        Me.Button16.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Button17.Location = New System.Drawing.Point(15, 304)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(246, 25)
        Me.Button17.TabIndex = 25
        Me.Button17.Text = "SQF Analysis"
        Me.ToolTip1.SetToolTip(Me.Button17, "This will tell you how to make your scripts more efficient.")
        Me.Button17.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(141, 369)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(83, 17)
        Me.CheckBox1.TabIndex = 26
        Me.CheckBox1.Text = "auto update"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 392)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Button16)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button20)
        Me.Controls.Add(Me.Button12)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AUSMD Editor Tool"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
