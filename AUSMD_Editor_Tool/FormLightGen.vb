Public Class FormLightGen
    Public lightBrightness As String = "0"
    Public lightGreen As String = "0"
    Public lightRed As String = "0"
    Public lightBlue As String = "0"
    Public lightFlareSize As String = "0"
    Public lightSpawnPos As String = "0"
    Public lightFlareMaxDist As String = "0"
    Public lightFlareUse As Boolean = False
    Public lightBrightnessRandomize As Boolean = False
    'Public lightBrightnessRandom As Boolean = False'

    Private Sub AUSMD_LightEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxFlareSizeEdit.Visible = False
        TextBoxMaxDistanceEdit.Visible = False
        TextBox5.Visible = False
        TextBoxMaxDistance.Visible = False
        TextBox4.Visible = False
    End Sub

    Private Sub TextBoxRedEdit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRedEdit.TextChanged
        lightRed = TextBoxRedEdit.Text
    End Sub

    Private Sub TextBoxGreenEdit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxGreenEdit.TextChanged
        lightGreen = TextBoxGreenEdit.Text
    End Sub

    Private Sub TextBoxBlueEdit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBlueEdit.TextChanged
        lightBlue = TextBoxBlueEdit.Text
    End Sub

    Private Sub TextBoxBrightnessEdit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBrightnessEdit.TextChanged
        lightBrightness = TextBoxBrightnessEdit.Text
    End Sub
    Private Sub TextBoxSpawnPosEdit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSpawnPosEdit.TextChanged
        lightSpawnPos = TextBoxSpawnPosEdit.Text
    End Sub
    Private Sub TextBoxMaxDistanceEdit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMaxDistanceEdit.TextChanged
        lightFlareMaxDist = TextBoxMaxDistanceEdit.Text
    End Sub
    Private Sub TextBoxFlareSizeEdit_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFlareSizeEdit.TextChanged
        lightFlareSize = TextBoxFlareSizeEdit.Text
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'clear all fields'
        TextBoxBrightnessEdit.Text = ""
        TextBoxBlueEdit.Text = ""
        TextBoxRedEdit.Text = ""
        TextBoxGreenEdit.Text = ""
        TextBoxFlareSizeEdit.Text = ""
        TextBoxSpawnPosEdit.Text = ""
        TextBoxMaxDistanceEdit.Text = ""
        'uncheck the checkbox.'
        CheckBox2.CheckState = CheckState.Unchecked
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'generate local vars for the command itself'
        Dim mylightCreate As String = "_light = ""#lightpoint"" createVehicle "
        Dim myLightColors As String = "_light setLightColor "
        Dim myLightBrightness As String = "_light setLightBrightness "
        Dim myLightUseFlare As String = "_light setLightUseFlare "
        Dim myLightFlareSize As String = "_light setLightFlareSize "
        Dim myLightFlareDist As String = "_light setLightFlareMaxDistance "
        Dim myLightUseFlareV As String = ""
        'line terminator is seperate'
        Dim endLine As String = ";"
        'error checking'
        If lightSpawnPos = "" Then
            MessageBox.Show("Spawn Position Not Defined")
        End If
        If lightRed = "" Or lightGreen = "" Or lightBlue = "" Then
            MessageBox.Show("A Color isn't Defined")
        End If
        If lightBrightness = "" Then
            MessageBox.Show("Brightness Not Defined")
        End If
        If lightFlareMaxDist = "" Then
            MessageBox.Show("Flare Max Distance Not Defined")
        End If
        If lightFlareSize = "" Then
            MessageBox.Show("Flare Size not Defined")
        End If
        'checking if the checkboxes are checked'
        If lightFlareUse Then
            myLightUseFlareV = "true"
        Else
            myLightUseFlareV = "false"
        End If
        'generate string'
        My.Computer.Clipboard.SetText(" " & mylightCreate & lightSpawnPos & endLine & myLightColors & "[" & lightRed & "," & lightGreen & "," & lightBlue & "]" & endLine & myLightBrightness & lightBrightness & endLine & myLightUseFlare & myLightUseFlareV & endLine & myLightFlareSize & lightFlareSize & endLine & myLightFlareDist & lightFlareMaxDist & endLine)
        MessageBox.Show("Exported Code Successfully")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'generate example values'
        TextBoxBrightnessEdit.Text = "1"
        TextBoxBlueEdit.Text = "0.5"
        TextBoxRedEdit.Text = "0.1"
        TextBoxGreenEdit.Text = "0.2"
        TextBoxFlareSizeEdit.Text = "0"
        TextBoxSpawnPosEdit.Text = "(position player)"
        TextBoxMaxDistanceEdit.Text = "0"
    End Sub
    'check box to hide or unhide flare variables'
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If lightFlareUse Then
            lightFlareUse = False
            lightFlareSize = "0"
            lightFlareMaxDist = "0"
            TextBoxFlareSizeEdit.Text = lightFlareSize
            TextBoxMaxDistanceEdit.Text = lightFlareMaxDist
            TextBoxFlareSizeEdit.Visible = False
            TextBoxMaxDistanceEdit.Visible = False
            TextBox5.Visible = False
            TextBoxMaxDistance.Visible = False
            TextBox4.Visible = False
        Else
            lightFlareUse = True
            TextBoxFlareSizeEdit.Visible = True
            TextBoxMaxDistanceEdit.Visible = True
            TextBox5.Visible = True
            TextBoxMaxDistance.Visible = True
            TextBox4.Visible = True
        End If
    End Sub
End Class
