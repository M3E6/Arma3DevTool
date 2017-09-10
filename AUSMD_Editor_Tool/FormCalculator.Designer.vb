<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormCalculator))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxHexR = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBoxHexG = New System.Windows.Forms.TextBox()
        Me.TextBoxHexB = New System.Windows.Forms.TextBox()
        Me.TextBoxHexA = New System.Windows.Forms.TextBox()
        Me.TextBoxAC = New System.Windows.Forms.TextBox()
        Me.TextBoxBC = New System.Windows.Forms.TextBox()
        Me.TextBoxGC = New System.Windows.Forms.TextBox()
        Me.TextBoxRC = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonConvertHex = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBoxHexString = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate!"
        Me.ToolTip1.SetToolTip(Me.Button1, "Convert your values to A3 values (Check your input before doing this).")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxHexR
        '
        Me.TextBoxHexR.Location = New System.Drawing.Point(23, 81)
        Me.TextBoxHexR.Name = "TextBoxHexR"
        Me.TextBoxHexR.Size = New System.Drawing.Size(49, 20)
        Me.TextBoxHexR.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(5, 58)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(71, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Values:"
        Me.ToolTip1.SetToolTip(Me.TextBox1, "RGB Values")
        '
        'TextBoxHexG
        '
        Me.TextBoxHexG.Location = New System.Drawing.Point(23, 107)
        Me.TextBoxHexG.Name = "TextBoxHexG"
        Me.TextBoxHexG.Size = New System.Drawing.Size(49, 20)
        Me.TextBoxHexG.TabIndex = 4
        '
        'TextBoxHexB
        '
        Me.TextBoxHexB.Location = New System.Drawing.Point(23, 133)
        Me.TextBoxHexB.Name = "TextBoxHexB"
        Me.TextBoxHexB.Size = New System.Drawing.Size(49, 20)
        Me.TextBoxHexB.TabIndex = 5
        '
        'TextBoxHexA
        '
        Me.TextBoxHexA.Location = New System.Drawing.Point(23, 159)
        Me.TextBoxHexA.Name = "TextBoxHexA"
        Me.TextBoxHexA.Size = New System.Drawing.Size(49, 20)
        Me.TextBoxHexA.TabIndex = 6
        '
        'TextBoxAC
        '
        Me.TextBoxAC.Location = New System.Drawing.Point(171, 159)
        Me.TextBoxAC.Name = "TextBoxAC"
        Me.TextBoxAC.ReadOnly = True
        Me.TextBoxAC.Size = New System.Drawing.Size(78, 20)
        Me.TextBoxAC.TabIndex = 10
        '
        'TextBoxBC
        '
        Me.TextBoxBC.Location = New System.Drawing.Point(171, 133)
        Me.TextBoxBC.Name = "TextBoxBC"
        Me.TextBoxBC.ReadOnly = True
        Me.TextBoxBC.Size = New System.Drawing.Size(78, 20)
        Me.TextBoxBC.TabIndex = 9
        '
        'TextBoxGC
        '
        Me.TextBoxGC.Location = New System.Drawing.Point(171, 107)
        Me.TextBoxGC.Name = "TextBoxGC"
        Me.TextBoxGC.ReadOnly = True
        Me.TextBoxGC.Size = New System.Drawing.Size(78, 20)
        Me.TextBoxGC.TabIndex = 8
        '
        'TextBoxRC
        '
        Me.TextBoxRC.Location = New System.Drawing.Point(171, 81)
        Me.TextBoxRC.Name = "TextBoxRC"
        Me.TextBoxRC.ReadOnly = True
        Me.TextBoxRC.Size = New System.Drawing.Size(78, 20)
        Me.TextBoxRC.TabIndex = 7
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(179, 58)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(62, 20)
        Me.TextBox6.TabIndex = 11
        Me.TextBox6.Text = "A3 Values:"
        Me.ToolTip1.SetToolTip(Me.TextBox6, "Arma 3 Values")
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.Red
        Me.TextBox7.Location = New System.Drawing.Point(99, 81)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(48, 20)
        Me.TextBox7.TabIndex = 12
        Me.TextBox7.Text = "Red"
        Me.TextBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.Lime
        Me.TextBox8.Location = New System.Drawing.Point(99, 107)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(48, 20)
        Me.TextBox8.TabIndex = 13
        Me.TextBox8.Text = "Green"
        Me.TextBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.Aqua
        Me.TextBox9.Location = New System.Drawing.Point(99, 133)
        Me.TextBox9.Multiline = True
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(48, 20)
        Me.TextBox9.TabIndex = 14
        Me.TextBox9.Text = "Blue"
        Me.TextBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox10
        '
        Me.TextBox10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox10.Location = New System.Drawing.Point(99, 159)
        Me.TextBox10.Multiline = True
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(48, 20)
        Me.TextBox10.TabIndex = 15
        Me.TextBox10.Text = "Alpha"
        Me.TextBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(82, 58)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(91, 17)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Array Format?"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Do you want it in array format?")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Your Color looks like this"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.Label1, "What your color should look like ingame")
        '
        'ButtonConvertHex
        '
        Me.ButtonConvertHex.Location = New System.Drawing.Point(68, 253)
        Me.ButtonConvertHex.Name = "ButtonConvertHex"
        Me.ButtonConvertHex.Size = New System.Drawing.Size(105, 39)
        Me.ButtonConvertHex.TabIndex = 18
        Me.ButtonConvertHex.Text = "Convert Hex to RGB"
        Me.ButtonConvertHex.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(-9, 227)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(71, 20)
        Me.TextBox2.TabIndex = 19
        Me.TextBox2.Text = "Hex String"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxHexString
        '
        Me.TextBoxHexString.Location = New System.Drawing.Point(68, 227)
        Me.TextBoxHexString.Name = "TextBoxHexString"
        Me.TextBoxHexString.Size = New System.Drawing.Size(105, 20)
        Me.TextBoxHexString.TabIndex = 20
        Me.ToolTip1.SetToolTip(Me.TextBoxHexString, "Use this to convert hex values to RGB")
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(179, 253)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(79, 30)
        Me.CheckBox2.TabIndex = 21
        Me.CheckBox2.Text = "Invert " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(rgb to hex)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 52)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Simply input your rgba code into the box " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "below and click calculate. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "You can c" & _
    "onvert hex to rgb with the hex converter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " below the calculate button" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'FormCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(261, 300)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.TextBoxHexString)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.ButtonConvertHex)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBoxAC)
        Me.Controls.Add(Me.TextBoxBC)
        Me.Controls.Add(Me.TextBoxGC)
        Me.Controls.Add(Me.TextBoxRC)
        Me.Controls.Add(Me.TextBoxHexA)
        Me.Controls.Add(Me.TextBoxHexB)
        Me.Controls.Add(Me.TextBoxHexG)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBoxHexR)
        Me.Controls.Add(Me.Button1)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Color Finder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBoxHexR As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHexG As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHexB As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHexA As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAC As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxBC As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxGC As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxRC As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtonConvertHex As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxHexString As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
