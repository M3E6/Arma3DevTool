Public Class descriptionEXTCreator
    Public disableAI As String = ""
    Public showmap As String = ""
    Public showgps As String = ""
    Public showcompass As String = ""
    Public showwatch As String = ""
    Public showuavFeed As String = ""
    Public author As String = ""
    Public loadname As String = ""
    Public overviewtext As String = ""
    Public overviewpic As String = ""
    Public gameMode As String = ""
    Public minplayers As String = ""
    Public maxplayers As String = ""
    Public loadScreen As String = ""
    Public respawnType As String = ""
    Public respawnDialog As String = ""
    Public respawnDelay As String = ""
    Public FrotorLib As String = ""
    Public taskmgmt2D As String = ""
    Public taskmgmt3D As String = ""
    Public taskDistance As String = ""
    Public disableChannels As String = ""
    Public functionLog As String = ""
    Public revivedelay As String = ""
    Public reviveForceRespawn As String = ""
    Public reviveBleedout As String = ""
    Public briefing As String = ""
    Public debriefing As String = ""
    Public aiKills As String = ""
    Public saving As String = ""
    Public debriefingTextSave As String = ""
    Public useDebrief = False
    Public useRevive As Boolean = False
    Public useFunctions As Boolean = False
    Public currentFunctions As String = ""
    Public yourTag As String = ""
    Public className As String = ""
    Public disableRandomization As String = ""
    Public functionsFinal As String = ""
    Public functionsSetup As String = "cfgFunctions " & vbCrLf & "{" & vbCrLf & vbTab & "class " & yourTag & " " & className & vbCrLf & vbTab & "{"
    Public usingFunctions As Boolean = False
    Public oneClassAlready As Boolean = False
    Public useSoundCfg As Boolean = False
    Public soundText As String = ""
    Public musicConfiguration As String = ""
    Public useMusic As Boolean = False
    Public useMultipleClasses As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (revive_descript.Visible) Then
            useRevive = revive_descript.useReviveE
        End If


        If (debrief_descript.Visible) Then
            useDebrief = debrief_descript.usingDebriefing
        ElseIf (Not debriefingTextSave = "") Then
            useDebrief = True
        ElseIf debriefingTextSave = "" Then
            useDebrief = False
        End If

        If (cfgFunctions.Visible) Then
            useFunctions = cfgFunctions.useFunctionss
        ElseIf (Not functionsFinal = "") Then
            useFunctions = True
        ElseIf functionsFinal = "" Then
            useFunctions = False
        End If
        'replace the number with text so the string will be recognized by the game'
        If (respawnType.StartsWith("0") Or respawnType.StartsWith("1") Or respawnType.StartsWith("2") Or respawnType.StartsWith("3") Or respawnType.StartsWith("4") Or respawnType.StartsWith("5")) Then
            If (respawnType.StartsWith("0")) Then
                respawnType = "NONE"
            ElseIf (respawnType.StartsWith("1")) Then
                respawnType = "SEAGULL"
            ElseIf (respawnType.StartsWith("2")) Then
                respawnType = "INSTANT"
            ElseIf (respawnType.StartsWith("3")) Then
                respawnType = "BASE"
            ElseIf (respawnType.StartsWith("4")) Then
                respawnType = "GROUP"
            ElseIf (respawnType.StartsWith("5")) Then
                respawnType = "SIDE"
            End If
        End If



        'using debriefing or not?'
        Dim mytext As String = ""
        If (useDebrief = True) Then
            mytext = "" & "class Header" & vbCrLf & "{" & vbCrLf & vbTab & "gameType = " & gameMode & ";" & vbCrLf & vbTab & "minPlayers = " & minplayers & ";" & vbCrLf & vbTab & "maxPlayers = " & maxplayers & ";" & vbCrLf & "};" & vbCrLf & "author = """ & author & """;" & vbCrLf & briefing & vbCrLf & debriefing & vbCrLf & aiKills & vbCrLf & saving & vbCrLf & "overViewText = """ & overviewtext & """;" & vbCrLf & "overviewPicture = """ & overviewpic & """;" & vbCrLf & "onLoadName = """ & loadname & """;" & vbCrLf & "loadScreen = """ & loadScreen & """;" & vbCrLf & "respawn = " & """" & respawnType & """;" & vbCrLf & "respawnDelay = " & respawnDelay & ";" & vbCrLf & respawnDialog & vbCrLf & disableAI & vbCrLf & showmap & vbCrLf & showgps & vbCrLf & showcompass & vbCrLf & showwatch & vbCrLf & showuavFeed & vbCrLf & FrotorLib & vbCrLf & taskmgmt2D & vbCrLf & taskmgmt3D & vbCrLf & taskDistance & vbCrLf & disableChannels & vbCrLf & functionLog & vbCrLf & debriefingTextSave & vbCrLf & "};"
        Else
            mytext = "" & "class Header" & vbCrLf & "{" & vbCrLf & vbTab & "gameType = " & gameMode & ";" & vbCrLf & vbTab & "minPlayers = " & minplayers & ";" & vbCrLf & vbTab & "maxPlayers = " & maxplayers & ";" & vbCrLf & "};" & vbCrLf & "author = """ & author & """;" & vbCrLf & briefing & vbCrLf & debriefing & vbCrLf & aiKills & vbCrLf & saving & vbCrLf & "overViewText = """ & overviewtext & """;" & vbCrLf & "overviewPicture = """ & overviewpic & """;" & vbCrLf & "onLoadName = """ & loadname & """;" & vbCrLf & "loadScreen = """ & loadScreen & """;" & vbCrLf & "respawn = " & """" & respawnType & """;" & vbCrLf & "respawnDelay = " & respawnDelay & ";" & vbCrLf & respawnDialog & vbCrLf & disableAI & vbCrLf & showmap & vbCrLf & showgps & vbCrLf & showcompass & vbCrLf & showwatch & vbCrLf & showuavFeed & vbCrLf & FrotorLib & vbCrLf & taskmgmt2D & vbCrLf & taskmgmt3D & vbCrLf & taskDistance & vbCrLf & disableChannels & vbCrLf & functionLog & vbCrLf
        End If


        'Add randomization config

        If (Not disableRandomization = "" And Not disableRandomization = "disableRandomization = {};") Then
            mytext = mytext & vbCrLf & disableRandomization
        End If

        'add revive to the end if its being used too
        If useRevive Then
            mytext = mytext & "reviveDelay = " & revivedelay & ";" & vbCrLf & "reviveForceRespawnDelay = " & reviveForceRespawn & "; " & vbCrLf & "reviveBleedOutDelay = " & reviveBleedout & ";" & vbCrLf & " respawnTemplates[] = {""Counter"",""Revive""};"
        End If


        'cfgSounds Stuff

        If (useSoundCfg) Then
            mytext = mytext & "class cfgSounds" & vbCrLf & "{" & vbCrLf & vbTab & "sounds[] = {};" & vbCrLf & vbTab & soundText & vbCrLf & "};" 'add closing bracket to end
        End If

        'cfgMusic Stuff
        If (useMusic) Then
            mytext = mytext & "class cfgMusic" & vbCrLf & "{" & vbCrLf & vbTab & "tracks[] = {};" & vbCrLf & vbTab & musicConfiguration & vbCrLf & "};"
        End If

        If (useFunctions = True) Then
            mytext = mytext & functionsFinal
            If (useMultipleClasses = True) Then
                mytext = mytext & "};" & vbCrLf & "};"
            End If
        End If

        My.Computer.Clipboard.SetText(mytext)
        MessageBox.Show("Copied to Clipboard")
    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            disableAI = "disabledAI = 1;"
        Else
            disableAI = "disabledAI = 0;"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            showmap = "showMap = 1;"
        Else
            showmap = "showMap = 0;"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            showcompass = "showCompass = 1;"
        Else
            showcompass = "showCompass = 0;"
        End If
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If (CheckBox4.Checked) Then
            showgps = "showGPS = 1;"
        Else
            showgps = "showGPS = 0;"
        End If
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If (CheckBox5.Checked) Then
            showwatch = "showWatch = 1;"
        Else
            showWatch = "showWatch = 0;"
        End If
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If (CheckBox6.Checked) Then
            showuavFeed = "showUAVFeed = 1;"
        Else
            showuavFeed = "showUAVFeed = 0;"
        End If
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If (CheckBox7.Checked) Then
            respawnDialog = "respawnDialog = 1;"
        Else
            respawnDialog = "respawnDialog = 0;"
        End If
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If (CheckBox8.Checked) Then

            FrotorLib = "forceRotorLibSimulation = 1;"
        Else
            FrotorLib = "forceRotorLibSimulation = 0;"
        End If
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If (CheckBox9.Checked) Then
            taskmgmt2D = "taskManagement_markers2D = 1;"
        Else
            taskmgmt2D = "taskManagement_markers2D = 0;"
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If (CheckBox10.Checked) Then
            taskmgmt3D = "taskManagement_markers3D = 1;"
        Else
            taskmgmt3D = "taskManagement_markers3D = 0;"
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If (CheckBox11.Checked) Then
            taskDistance = "taskManagement_drawDist = " & TextBox11.Text & ";"
        Else
            taskDistance = "taskManagement_drawDist = 2000;"
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If (CheckBox12.Checked) Then
            functionLog = "allowFunctionsLog = 1;"
        Else
            functionLog = "allowFunctionsLog = 0;"
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If (CheckBox14.Checked) Then
            briefing = "briefing = 1;"
        Else
            briefing = "briefing = 0;"
        End If
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If (CheckBox15.Checked) Then
            debriefing = "debriefing = 1;"
        Else
            debriefing = "debriefing = 0;"
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If (CheckBox16.Checked) Then
            aiKills = "aiKills = 1;"
        Else
            aiKills = "aiKills = 0;"
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If (CheckBox17.Checked) Then
            saving = "saving = 1;"
        Else
            saving = "saving = 0;"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        author = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        loadname = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        overviewtext = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        overViewPic = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        gameMode = TextBox5.Text
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        minplayers = TextBox6.Text
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        maxplayers = TextBox7.Text
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        loadScreen = TextBox8.Text
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        respawnType = TextBox9.Text
    End Sub

    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        respawnDelay = TextBox10.Text
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Dim oldchannels As String = TextBox12.Text
        disableChannels = "disableChannels[] = {" & oldchannels & "};"
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        disableRandomization = "disableRandomization = {" & TextBox13.Text & "};" & vbCrLf
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        debrief_descript.Enabled = True
        debrief_descript.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        revive_descript.Enabled = True
        revive_descript.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cfgFunctions.Visible = True
        cfgFunctions.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sound_descript.Visible = True
        sound_descript.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        music_descript.Visible = True
        music_descript.Enabled = True
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("https://community.bistudio.com/wiki/Description.ext")
    End Sub

End Class