Public Class FormAddActionCreator

    Public unitToAdd As String = ""
    Public actionText As String = ""
    Public scriptText As String = ""
    Public variabletopass As String = ""
    Public priority As String = ""
    Public showtext As Boolean = False
    Public hideonUse As Boolean = False
    Public shortcut As String = ""
    Public conditions As String = ""
    Public mystr As String = ""
    Public dataType As String = ""

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        unitToAdd = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        actionText = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        variabletopass = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        scriptText = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        priority = TextBox5.Text
    End Sub


    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        shortcut = TextBox6.Text
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        conditions = TextBox7.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            showtext = True
        Else
            showtext = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            hideonUse = True
        Else
            hideonUse = False
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            unitToAdd = "player"
        End If
        If TextBox2.Text = "" Then
            actionText = "My Action"
        End If
        If TextBox3.Text = "" Then
            variabletopass = "nil"
        End If
        If TextBox4.Text = "" And dataType = "Function" Then
            scriptText = "TAG_fnc_myFunc"
        ElseIf TextBox4.Text = "" And dataType = "Script" Then
            scriptText = "myscript.sqf"
        ElseIf TextBox4.Text = "" And dataType = "Code" Then
            scriptText = "{true}"
        End If
        If TextBox5.Text = "" Then
            priority = "1"
        End If
        If TextBox6.Text = "" Then
            shortcut = ""
        End If
        If TextBox7.Text = "" Then
            conditions = "true"
        End If
        If (dataType = "Function") Then
            mystr = ("" & unitToAdd & " " & "addaction [""" & actionText & """" & "," & scriptText & "," & variabletopass & ",")
        ElseIf (dataType = "Script") Then
            mystr = ("" & unitToAdd & " " & "addaction [""" & actionText & """" & ",""" & scriptText & """" & "," & variabletopass & ",")
        ElseIf (dataType = "Code") Then
            mystr = ("" & unitToAdd & " " & "addaction [""" & actionText & """" & ",{" & scriptText & "}," & variabletopass & ",")
        End If
        mystr = (mystr & priority & "," & showtext & "," & hideonUse & "," & """" & shortcut & """" & "," & "' " & conditions & " '" & "];")
        My.Computer.Clipboard.SetText(mystr)
        MessageBox.Show("Copied action to clipboard")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim fakeData As Object = ComboBox1.SelectedItem
        dataType = ComboBox1.GetItemText(fakeData)
        Debug.Write(dataType & vbCrLf)
    End Sub

    Private Sub FormAddActionCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        dataType = "Script"
    End Sub
End Class