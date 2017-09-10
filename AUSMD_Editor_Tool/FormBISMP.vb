Public Class FormBISMP

    Public params As String = ""
    Public Func As String = ""
    Public receivers As String = ""
    Public presistant As Boolean = False
    Public iscall As Boolean = False
    Public finalText As String = ""
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        params = TextBox1.Text
        finalText = "[[" & params & "],""" & Func & """," & receivers & "," & presistant & "," & iscall & "] spawn BIS_fnc_MP;"
        TextBox6.Text = finalText
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Func = TextBox2.Text
        finalText = "[[" & params & "],""" & Func & """," & receivers & "," & presistant & "," & iscall & "] spawn BIS_fnc_MP;"
        TextBox6.Text = finalText
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        receivers = TextBox3.Text
        finalText = "[[" & params & "],""" & Func & """," & receivers & "," & presistant & "," & iscall & "] spawn BIS_fnc_MP;"
        TextBox6.Text = finalText
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            iscall = True
        Else
            iscall = False
        End If
        finalText = "[[" & params & "],""" & Func & """," & receivers & "," & presistant & "," & iscall & "] spawn BIS_fnc_MP;"
        TextBox6.Text = finalText
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            presistant = True
        Else
            presistant = False
        End If
        finalText = "[[" & params & "],""" & Func & """," & receivers & "," & presistant & "," & iscall & "] spawn BIS_fnc_MP;"
        TextBox6.Text = finalText
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Clipboard.SetText(finalText)
        TextBox6.Text = finalText
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = "params"
        TextBox2.Text = "function"
        TextBox3.Text = "people to send to"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        finalText = "[[" & params & "],""" & Func & """," & receivers & "," & presistant & "," & iscall & "] spawn BIS_fnc_MP;"
        TextBox6.Text = finalText
    End Sub

    Private Sub FormBISMP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = "params"
        TextBox2.Text = "function"
        TextBox3.Text = "people to send to"
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        presistant = False
        iscall = False
        finalText = "[[" & params & "],""" & Func & """," & receivers & "," & presistant & "," & iscall & "] spawn BIS_fnc_MP;"
        TextBox6.Text = finalText
    End Sub
End Class