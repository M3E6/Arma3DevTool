Public Class ScriptSnippets
    Public trashRemover As String
    Public strClasses(5) As String
    Public myText As String = ""
    Public paramsText As String = ""
    Public paramsText2 As String = ""
    Public paramstext3 As String = ""


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Clipboard.SetText(myText)
        MessageBox.Show("Copied snippet to clipboard")
    End Sub

    Private Sub ScriptSnippets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()

        strClasses(0) = "Trash Remover"
        strClasses(1) = "Randomize Position"
        strClasses(2) = "Under Roof Checking"
        strClasses(3) = "Tracers"
        strClasses(4) = "Bullets Landing Around You"
        strClasses(5) = "Transformer Power Grid"

        For num As Integer = 0 To strClasses.Length - 1
            ListBox1.Items.Add(strClasses(num))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim selection As String = ""
        Dim spaceAndtab As String = vbCrLf & vbTab
        Dim string1 As String = ""
        Dim string2 As String = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""

        selection = ListBox1.SelectedItem
        If selection = "Trash Remover" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("while{true} do " & vbCrLf & "{" & spaceAndtab & "{deletevehicle _x} foreach allDead;" & spaceAndtab & "sleep 60;" & vbCrLf & "};")
        ElseIf selection = "Randomize Position" Then
            TextBox2.Visible = True
            TextBox3.Visible = False
            TextBox4.Visible = False
            paramsText = "POSITION-HERE"
            myText = ("_pos = " & paramsText & ";" & vbCrLf & "_pos set [0,""(_pos select 0) + random 100 - random 100""];" & vbCrLf & "_pos set [1,""(_pos select 1) + random 100 - random 100""];" & vbCrLf & "_pos set [2,""(_pos select 2) + random 100 - random 100""];")
        ElseIf selection = "Under Roof Checking" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("_intersects = LineIntersects[getpos player,[getpos player select 0,getpos player select 1,(getpos player select 2) + 20],player];" & vbCrLf & "if(_intersects) then" & vbCrLf & "{" & spaceAndtab & "your-code-here;" & vbCrLf & "};")
        ElseIf selection = "Tracers" Then
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox2.Visible = True
            paramsText = "PARAM 1: POSITION"
            paramsText2 = "PARAM 2: SIDE (0 = west, 1 = east, 2 = resistance/AFF)"
            paramstext3 = "PARAM 3: SIDE (west,east, resistance)"
            TextBox2.Text = paramsText
            TextBox3.Text = paramsText2
            TextBox4.Text = paramstext3
            string1 = ("_sideID = " & paramsText2 & ";" & vbCrLf & "_logic = ""Logic"" createVehicle (getpos" & paramsText & ");" & vbCrLf & "_veh = createvehicle [""B_Boat_Armed_01_minigun_F""," & paramsText & ",[],0,""none""];" & vbCrLf & "_veh attachto [_logic,[0,0,10]];" & vbCrLf & "_veh hideobject true;" & vbCrLf & "_veh setvehicleammo 0;" & vbCrLf & "_veh addmagazine ([""200Rnd_65x39_belt_Tracer_Green"",""200Rnd_65x39_belt_Tracer_Red"",""200Rnd_65x39_belt_Tracer_Yellow""] select _sideID);" & vbCrLf & "_vehPos = position _veh;" & vbCrLf & "_vehPosX = _vehPos select 0;" & vbCrLf & "_vehPosY = _vehPos select 1;" & vbCrLf & "_vehPosZ = _vehPos select 2;" & vbCrLf & "_side = " & paramsText2 & ";" & "createcenter _side;" & vbCrLf & "_grp = creategroup _side;" & vbCrLf & "_gunner = _grp createunit [""b_soldier_f"",_vehPos,[],0,""none""];" & vbCrLf & "_gunner disableai ""move"";" & vbCrLf & "_gunner disableai ""target"";" & vbCrLf & "_gunner disableai ""autotarget"";" & vbCrLf & "_gunner setBehaviour ""combat"";" & vbCrLf & "_gunner moveingunner _veh;" & vbCrLf)
            string2 = ("_weapon = weapons _veh select 0;" & vbCrLf & "_veh selectweapon _weapon;" & vbCrLf & "_veh action [""lightoff"",_veh];" & vbCrLf & "while {!isnull _veh} do {" & vbCrLf & vbTab & "_veh setvehicleammo 1;" & vbCrLf & vbTab & "_time = time + 0.1 + random 0.9;" & vbCrLf & vbTab & "_delay = 0.05 + random 0.1;" & vbCrLf & vbTab & "_dir = -5 + random 10;" & vbCrLf & vbTab & "while{time < _time} do {" & vbCrLf & vbTab & vbTab & "_veh fire _weapon;" & vbCrLf & vbTab & vbTab & "_ammo = _veh ammo _weapon;" & vbCrLf & vbTab & vbTab & "_veh setdir (direction _veh + _dir);" & vbCrLf & vbTab & vbTab & "sleep _delay;" & vbCrLf & vbTab & vbTab & "if (random 1 > 0.95) then {sleep (2* _delay);};" & vbCrLf & vbTab & "};" & "_Veh setdir (random 360);" & vbCrLf & vbTab & "_veh dowatch [_vehPosX,_vehPosY,_vehPosZ + 2 + random 8];" & vbCrLf & vbTab & "sleep 3;" & vbCrLf & vbTab & "};" & vbCrLf & "} else {" & vbCrLf & vbTab & "deletevehicle _veh;" & vbCrLf & "};")
            myText = (string1 + string2)
        ElseIf selection = "Bullets Landing Around You" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("_intersects = LineIntersects[getpos player,[getpos player select 0,getpos player select 1,(getpos player select 2) + 20],player];" & vbCrLf & "if(_intersects) then" & vbCrLf & "{" & spaceAndtab & "your-code-here;" & vbCrLf & "};")
        ElseIf selection = "Transformer Power Grid" Then
            TextBox2.Visible = True
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("_centerPos = _this select 0;" & vbCrLf & "blowlights = [""Lamps_base_f"",""Land_PowerPoleWooden_L_F"",""PowerLines_base_f"",""PowerLines_small_base_f""];" & vbCrLf & "_nearestGenerator = nearestObject[_centerPos,""Land_spp_transformer_f""];" & vbCrLf & "_allLights = nearestObjects[_nearestGenerator,blowlights," & TextBox2.Text & "];" & vbCrLf & "waitUntil{damage _nearestgenerator >= 1};" & vbCrLf & "hint ""Generator Down"";" & vbCrLf & "{" & vbCrLf & vbTab & "_x setHit [""light_1_hitpoint"",0.97];" & vbCrLf & vbTab & "_x setHit [""light_2_hitpoint"",0.97];" & "_x setHit [""light_3_hitpoint"",0.97];" & vbCrLf & vbTab & "_x setHit [""light_4_hitpoint"",0.97];" & vbCrLf & "} foreach nearestObjects[_nearestGenerator,blowlights," & TextBox2.Text & "];")
        End If
        TextBox1.Text = myText
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        paramsText = TextBox2.Text
        Dim selection As String = ""
        Dim spaceAndtab As String = vbCrLf & vbTab
        Dim string1 As String = ""
        Dim string2 As String = ""

        selection = ListBox1.SelectedItem
        If selection = "Trash Remover" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("while{true} do " & vbCrLf & "{" & spaceAndtab & "{deletevehicle _x} foreach allDead;" & spaceAndtab & "sleep 60;" & vbCrLf & "};")
        ElseIf selection = "Randomize Position" Then
            TextBox2.Visible = True
            TextBox3.Visible = False
            TextBox4.Visible = False
            If paramsText.Equals("") Then
                myText = ("_pos = " & "POSITION-HERE" & ";" & vbCrLf & "_pos set [0,""(_pos select 0) + random 100 - random 100""];" & vbCrLf & "_pos set [1,""(_pos select 1) + random 100 - random 100""];" & vbCrLf & "_pos set [2,""(_pos select 2) + random 100 - random 100""];")
            Else
                myText = ("_pos = " & paramsText & ";" & vbCrLf & "_pos set [0,""(_pos select 0) + random 100 - random 100""];" & vbCrLf & "_pos set [1,""(_pos select 1) + random 100 - random 100""];" & vbCrLf & "_pos set [2,""(_pos select 2) + random 100 - random 100""];")
            End If
            ElseIf selection = "Under Roof Checking" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
                myText = ("_line = LineIntersects[getpos player,[getpos player select 0,getpos player select 1,(getpos player select 2) + 20],player];" & vbCrLf & "if(_intersects) then" & vbCrLf & "{" & spaceAndtab & "your-code-here;" & vbCrLf & "};")
        ElseIf selection = "Tracers" Then
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            If paramsText.Equals("") Then
                paramsText = "PARAM 1: POSITION"
            End If

            If paramsText2.Equals("") Then
                paramsText2 = "PARAM 2: SIDE (0 = west, 1 = east, 2 = resistance/AFF)"
            End If

            If paramstext3.Equals("") Then
                paramstext3 = "PARAM 3: SIDE (west,east, resistance)"
            End If

            string1 = ("_sideID = " & paramsText2 & ";" & vbCrLf & "_logic = ""Logic"" createVehicle (getpos " & paramsText & ");" & vbCrLf & "_veh = createvehicle [""B_Boat_Armed_01_minigun_F""," & "getpos" & paramsText & ",[],0,""none""];" & vbCrLf & "_veh attachto [_logic,[0,0,10]];" & vbCrLf & "_veh hideobject true;" & vbCrLf & "_veh setvehicleammo 0;" & vbCrLf & "_veh addmagazine ([""200Rnd_65x39_belt_Tracer_Green"",""200Rnd_65x39_belt_Tracer_Red"",""200Rnd_65x39_belt_Tracer_Yellow""] select _sideID);" & vbCrLf & "_vehPos = position _veh;" & vbCrLf & "_vehPosX = _vehPos select 0;" & vbCrLf & "_vehPosY = _vehPos select 1;" & vbCrLf & "_vehPosZ = _vehPos select 2;" & vbCrLf & "_side = " & paramstext3 & ";" & vbCrLf & "createcenter _side;" & vbCrLf & "_grp = creategroup _side;" & vbCrLf & "_gunner = _grp createunit [""b_soldier_f"",_vehPos,[],0,""none""];" & vbCrLf & "_gunner disableai ""move"";" & vbCrLf & "_gunner disableai ""target"";" & vbCrLf & "_gunner disableai ""autotarget"";" & vbCrLf & "_gunner setBehaviour ""combat"";" & vbCrLf & "_gunner moveingunner _veh;" & vbCrLf)
            string2 = ("_weapon = weapons _veh select 0;" & vbCrLf & "_veh selectweapon _weapon;" & vbCrLf & "_veh action [""lightoff"",_veh];" & vbCrLf & "while {!isnull _veh} do {" & vbCrLf & vbTab & "_veh setvehicleammo 1;" & vbCrLf & vbTab & "_time = time + 0.1 + random 0.9;" & vbCrLf & vbTab & "_delay = 0.05 + random 0.1;" & vbCrLf & vbTab & "_dir = -5 + random 10;" & vbCrLf & vbTab & "while{time < _time} do {" & vbCrLf & vbTab & vbTab & "_veh fire _weapon;" & vbCrLf & vbTab & vbTab & "_ammo = _veh ammo _weapon;" & vbCrLf & vbTab & vbTab & "_veh setdir (direction _veh + _dir);" & vbCrLf & vbTab & vbTab & "sleep _delay;" & vbCrLf & vbTab & vbTab & "if (random 1 > 0.95) then {sleep (2* _delay);};" & vbCrLf & vbTab & "};" & "_Veh setdir (random 360);" & vbCrLf & vbTab & "_veh dowatch [_vehPosX,_vehPosY,_vehPosZ + 2 + random 8];" & vbCrLf & vbTab & "sleep 3;" & vbCrLf & vbTab & "};")
            myText = (string1 & string2)
        ElseIf selection = "Bullets Landing Around You" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("_intersects = LineIntersects[getpos player,[getpos player select 0,getpos player select 1,(getpos player select 2) + 20],player];" & vbCrLf & "if(_intersects) then" & vbCrLf & "{" & spaceAndtab & "your-code-here;" & vbCrLf & "};")
        ElseIf selection = "Transformer Power Grid" Then
            TextBox2.Visible = True
            TextBox3.Visible = False
            TextBox4.Visible = False
            If paramsText.Equals("") Then
                paramsText = "RANGE (NUMBER)"
            End If
            TextBox2.Text = paramsText
            TextBox3.Text = paramsText2
            TextBox4.Text = paramstext3
            myText = ("_centerPos = _this select 0;" & vbCrLf & "blowlights = [""Lamps_base_f"",""Land_PowerPoleWooden_L_F"",""PowerLines_base_f"",""PowerLines_small_base_f""];" & vbCrLf & "_nearestGenerator = nearestObject[_centerPos,""Land_spp_transformer_f""];" & vbCrLf & "_allLights = nearestObjects[_nearestGenerator,blowlights," & TextBox2.Text & "];" & vbCrLf & "waitUntil{damage _nearestgenerator >= 1};" & vbCrLf & "hint ""Generator Down"";" & vbCrLf & "{" & vbCrLf & vbTab & "_x setHit [""light_1_hitpoint"",0.97];" & vbCrLf & vbTab & "_x setHit [""light_2_hitpoint"",0.97];" & "_x setHit [""light_3_hitpoint"",0.97];" & vbCrLf & vbTab & "_x setHit [""light_4_hitpoint"",0.97];" & vbCrLf & "} foreach nearestObjects[_nearestGenerator,blowlights," & TextBox2.Text & "];")
        End If
            TextBox1.Text = myText
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        paramstext3 = TextBox4.Text
        Dim selection As String = ""
        Dim spaceAndtab As String = vbCrLf & vbTab
        Dim string1 As String = ""
        Dim string2 As String = ""

        selection = ListBox1.SelectedItem
        If selection = "Trash Remover" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("while{true} do " & vbCrLf & "{" & spaceAndtab & "{deletevehicle _x} foreach allDead;" & spaceAndtab & "sleep 60;" & vbCrLf & "};")
        ElseIf selection = "Randomize Position" Then
            TextBox2.Visible = True
            TextBox3.Visible = False
            TextBox4.Visible = False
            If paramsText.Equals("") Then
                myText = ("_pos = " & "POSITION-HERE" & ";" & vbCrLf & "_pos set [0,""(_pos select 0) + random 100 - random 100""];" & vbCrLf & "_pos set [1,""(_pos select 1) + random 100 - random 100""];" & vbCrLf & "_pos set [2,""(_pos select 2) + random 100 - random 100""];")
            Else
                myText = ("_pos = " & paramsText & ";" & vbCrLf & "_pos set [0,""(_pos select 0) + random 100 - random 100""];" & vbCrLf & "_pos set [1,""(_pos select 1) + random 100 - random 100""];" & vbCrLf & "_pos set [2,""(_pos select 2) + random 100 - random 100""];")
            End If
        ElseIf selection = "Under Roof Checking" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("_line = LineIntersects[getpos player,[getpos player select 0,getpos player select 1,(getpos player select 2) + 20],player];" & vbCrLf & "if(_intersects) then" & vbCrLf & "{" & spaceAndtab & "your-code-here;" & vbCrLf & "};")
        ElseIf selection = "Tracers" Then
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            If paramsText.Equals("") Then
                paramsText = "PARAM 1: POSITION"
            End If

            If paramsText2.Equals("") Then
                paramsText2 = "PARAM 2: SIDE (0 = west, 1 = east, 2 = resistance/AFF)"
            End If

            If paramstext3.Equals("") Then
                paramstext3 = "PARAM 3: SIDE (west,east, resistance)"
            End If

            string1 = ("_sideID = " & paramsText2 & ";" & vbCrLf & "_logic = ""Logic"" createVehicle (getpos " & paramsText & ");" & vbCrLf & "_veh = createvehicle [""B_Boat_Armed_01_minigun_F""," & "getpos" & paramsText & ",[],0,""none""];" & vbCrLf & "_veh attachto [_logic,[0,0,10]];" & vbCrLf & "_veh hideobject true;" & vbCrLf & "_veh setvehicleammo 0;" & vbCrLf & "_veh addmagazine ([""200Rnd_65x39_belt_Tracer_Green"",""200Rnd_65x39_belt_Tracer_Red"",""200Rnd_65x39_belt_Tracer_Yellow""] select _sideID);" & vbCrLf & "_vehPos = position _veh;" & vbCrLf & "_vehPosX = _vehPos select 0;" & vbCrLf & "_vehPosY = _vehPos select 1;" & vbCrLf & "_vehPosZ = _vehPos select 2;" & vbCrLf & "_side = " & paramstext3 & ";" & "createcenter _side;" & vbCrLf & "_grp = creategroup _side;" & vbCrLf & "_gunner = _grp createunit [""b_soldier_f"",_vehPos,[],0,""none""];" & vbCrLf & "_gunner disableai ""move"";" & vbCrLf & "_gunner disableai ""target"";" & vbCrLf & "_gunner disableai ""autotarget"";" & vbCrLf & "_gunner setBehaviour ""combat"";" & vbCrLf & "_gunner moveingunner _veh;" & vbCrLf)
            string2 = ("_weapon = weapons _veh select 0;" & vbCrLf & "_veh selectweapon _weapon;" & vbCrLf & "_veh action [""lightoff"",_veh];" & vbCrLf & "while {!isnull _veh} do {" & vbCrLf & vbTab & "_veh setvehicleammo 1;" & vbCrLf & vbTab & "_time = time + 0.1 + random 0.9;" & vbCrLf & vbTab & "_delay = 0.05 + random 0.1;" & vbCrLf & vbTab & "_dir = -5 + random 10;" & vbCrLf & vbTab & "while{time < _time} do {" & vbCrLf & vbTab & vbTab & "_veh fire _weapon;" & vbCrLf & vbTab & vbTab & "_ammo = _veh ammo _weapon;" & vbCrLf & vbTab & vbTab & "_veh setdir (direction _veh + _dir);" & vbCrLf & vbTab & vbTab & "sleep _delay;" & vbCrLf & vbTab & vbTab & "if (random 1 > 0.95) then {sleep (2* _delay);};" & vbCrLf & vbTab & "};" & "_Veh setdir (random 360);" & vbCrLf & vbTab & "_veh dowatch [_vehPosX,_vehPosY,_vehPosZ + 2 + random 8];" & vbCrLf & vbTab & "sleep (_min + random _max);" & vbCrLf & vbTab & "};" & vbCrLf & "} else {" & vbCrLf & vbTab & "deletevehicle _veh;" & vbCrLf & "};")
            myText = (string1 & string2)
        ElseIf selection = "Bullets Landing Around You" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("_intersects = LineIntersects[getpos player,[getpos player select 0,getpos player select 1,(getpos player select 2) + 20],player];" & vbCrLf & "if(_intersects) then" & vbCrLf & "{" & spaceAndtab & "your-code-here;" & vbCrLf & "};")
        ElseIf selection = "Transformer Power Grid" Then
            TextBox2.Visible = True
            TextBox3.Visible = False
            TextBox4.Visible = False
            If paramsText.Equals("") Then
                paramsText = "RANGE (NUMBER)"
            End If
            TextBox2.Text = paramsText
            TextBox3.Text = paramsText2
            TextBox4.Text = paramstext3
            myText = ("_centerPos = _this select 0;" & vbCrLf & "blowlights = [""Lamps_base_f"",""Land_PowerPoleWooden_L_F"",""PowerLines_base_f"",""PowerLines_small_base_f""];" & vbCrLf & "_nearestGenerator = nearestObject[_centerPos,""Land_spp_transformer_f""];" & vbCrLf & "_allLights = nearestObjects[_nearestGenerator,blowlights," & TextBox2.Text & "];" & vbCrLf & "waitUntil{damage _nearestgenerator >= 1};" & vbCrLf & "hint ""Generator Down"";" & vbCrLf & "{" & vbCrLf & vbTab & "_x setHit [""light_1_hitpoint"",0.97];" & vbCrLf & vbTab & "_x setHit [""light_2_hitpoint"",0.97];" & "_x setHit [""light_3_hitpoint"",0.97];" & vbCrLf & vbTab & "_x setHit [""light_4_hitpoint"",0.97];" & vbCrLf & "} foreach nearestObjects[_nearestGenerator,blowlights," & TextBox2.Text & "];")
        End If
        TextBox1.Text = myText
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        paramsText2 = TextBox3.Text
        Dim selection As String = ""
        Dim spaceAndtab As String = vbCrLf & vbTab
        Dim string1 As String = ""
        Dim string2 As String = ""

        selection = ListBox1.SelectedItem
        If selection = "Trash Remover" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("while{true} do " & vbCrLf & "{" & spaceAndtab & "{deletevehicle _x} foreach allDead;" & spaceAndtab & "sleep 60;" & vbCrLf & "};")
        ElseIf selection = "Randomize Position" Then
            TextBox2.Visible = True
            TextBox3.Visible = False
            TextBox4.Visible = False
            If paramsText.Equals("") Then
                myText = ("_pos = " & "POSITION-HERE" & ";" & vbCrLf & "_pos set [0,""(_pos select 0) + random 100 - random 100""];" & vbCrLf & "_pos set [1,""(_pos select 1) + random 100 - random 100""];" & vbCrLf & "_pos set [2,""(_pos select 2) + random 100 - random 100""];")
            Else
                myText = ("_pos = " & paramsText & ";" & vbCrLf & "_pos set [0,""(_pos select 0) + random 100 - random 100""];" & vbCrLf & "_pos set [1,""(_pos select 1) + random 100 - random 100""];" & vbCrLf & "_pos set [2,""(_pos select 2) + random 100 - random 100""];")
            End If
        ElseIf selection = "Under Roof Checking" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("_line = LineIntersects[getpos player,[getpos player select 0,getpos player select 1,(getpos player select 2) + 20],player];" & vbCrLf & "if(_intersects) then" & vbCrLf & "{" & spaceAndtab & "your-code-here;" & vbCrLf & "};")
        ElseIf selection = "Tracers" Then
            TextBox2.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            If paramsText.Equals("") Then
                paramsText = "POSITION"
            End If

            If paramsText2.Equals("") Then
                paramsText2 = "SIDE (0 = west, 1 = east, 2 = resistance/AFF)"
            End If

            If paramstext3.Equals("") Then
                paramstext3 = "SIDE (west,east, resistance)"
            End If
            'this string will be MASSIVE so seperate it into two smaller strings, still a clusterfuck either way
            string1 = ("_sideID = " & paramsText2 & ";" & vbCrLf & "_logic = ""Logic"" createVehicle (getpos " & paramsText & ");" & vbCrLf & "_veh = createvehicle [""B_Boat_Armed_01_minigun_F""," & "getpos" & paramsText & ",[],0,""none""];" & vbCrLf & "_veh attachto [_logic,[0,0,10]];" & vbCrLf & "_veh hideobject true;" & vbCrLf & "_veh setvehicleammo 0;" & vbCrLf & "_veh addmagazine ([""200Rnd_65x39_belt_Tracer_Green"",""200Rnd_65x39_belt_Tracer_Red"",""200Rnd_65x39_belt_Tracer_Yellow""] select _sideID);" & vbCrLf & "_vehPos = position _veh;" & vbCrLf & "_vehPosX = _vehPos select 0;" & vbCrLf & "_vehPosY = _vehPos select 1;" & vbCrLf & "_vehPosZ = _vehPos select 2;" & vbCrLf & "_side = " & paramstext3 & ";" & vbCrLf & "createcenter _side;" & vbCrLf & "_grp = creategroup _side;" & vbCrLf & "_gunner = _grp createunit [""b_soldier_f"",_vehPos,[],0,""none""];" & vbCrLf & "_gunner disableai ""move"";" & "_gunner disableai ""target"";" & vbCrLf & "_gunner disableai ""autotarget"";" & vbCrLf & "_gunner setBehaviour ""combat"";" & vbCrLf & "_gunner moveingunner _veh;" & vbCrLf)
            string2 = ("_weapon = weapons _veh select 0;" & vbCrLf & "_veh selectweapon _weapon;" & vbCrLf & "_veh action [""lightoff"",_veh];" & vbCrLf & "while {!isnull _veh} do {" & vbCrLf & vbTab & "_veh setvehicleammo 1;" & vbCrLf & vbTab & "_time = time + 0.1 + random 0.9;" & vbCrLf & vbTab & "_delay = 0.05 + random 0.1;" & vbCrLf & vbTab & "_dir = -5 + random 10;" & vbCrLf & vbTab & "while{time < _time} do {" & vbCrLf & vbTab & vbTab & "_veh fire _weapon;" & vbCrLf & vbTab & vbTab & "_ammo = _veh ammo _weapon;" & vbCrLf & vbTab & vbTab & "_veh setdir (direction _veh + _dir);" & vbCrLf & vbTab & vbTab & "sleep _delay;" & vbCrLf & vbTab & vbTab & "if (random 1 > 0.95) then {sleep (2* _delay);};" & vbCrLf & vbTab & "};" & "_Veh setdir (random 360);" & vbCrLf & vbTab & "_veh dowatch [_vehPosX,_vehPosY,_vehPosZ + 2 + random 8];" & vbCrLf & vbTab & "sleep (_min + random _max);" & vbCrLf & vbTab & "};" & vbCrLf & "} else {" & vbCrLf & vbTab & "deletevehicle _veh;" & vbCrLf & "};")
            myText = (string1 & string2)
        ElseIf selection = "Bullets Landing Around You" Then
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("_intersects = LineIntersects[getpos player,[getpos player select 0,getpos player select 1,(getpos player select 2) + 20],player];" & vbCrLf & "if(_intersects) then" & vbCrLf & "{" & spaceAndtab & "your-code-here;" & vbCrLf & "};")
        ElseIf selection = "Transformer Power Grid" Then
            TextBox2.Visible = True
            TextBox3.Visible = False
            TextBox4.Visible = False
            myText = ("_centerPos = _this select 0;" & vbCrLf & "blowlights = [""Lamps_base_f"",""Land_PowerPoleWooden_L_F"",""PowerLines_base_f"",""PowerLines_small_base_f""];" & vbCrLf & "_nearestGenerator = nearestObject[_centerPos,""Land_spp_transformer_f""];" & vbCrLf & "_allLights = nearestObjects[_nearestGenerator,blowlights," & paramsText & "];" & vbCrLf & "waitUntil{damage _nearestgenerator >= 1};" & vbCrLf & "hint ""Generator Down"";" & vbCrLf & "{" & vbCrLf & vbTab & "_x setHit [""light_1_hitpoint"",0.97];" & vbCrLf & vbTab & "_x setHit [""light_2_hitpoint"",0.97];" & "_x setHit [""light_3_hitpoint"",0.97];" & vbCrLf & vbTab & "_x setHit [""light_4_hitpoint"",0.97];" & vbCrLf & "} foreach nearestObjects[_nearestGenerator,blowlights," & paramsText & "];")
            End If
            TextBox1.Text = myText
    End Sub
End Class