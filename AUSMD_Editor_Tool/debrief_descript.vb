Public Class debrief_descript


    Public endingClass As String = ""
    Public endingTitle As String = ""
    Public endingDescript As String = ""
    Public endingPic As String = ""
    Public debriefText As String = ""
    Public usingDebriefing As Boolean

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim oldText As String = debriefText
        debriefText = oldText & vbCrLf & vbTab & "class " & endingClass & vbCrLf & vbTab & "{" & vbCrLf & vbTab & "title = """ & endingTitle & """;" & vbCrLf & vbTab & "description = """ & endingDescript & """;" & vbCrLf & vbTab & "picture = """ & endingPic & """;" & vbCrLf & vbTab & "};"
        TextBox17.Text = debriefText
        descriptionEXTCreator.debriefingTextSave = debriefText
    End Sub


    Private Sub debrief_descript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim savedText As String = descriptionEXTCreator.debriefingTextSave
        If (savedText = "") Then
            CheckBox1.Checked = False
            TextBox17.Text = "class cfgDebriefing " & vbCrLf & "{" & vbCrLf
        Else
            TextBox17.Text = savedText
            CheckBox1.Checked = True
        End If

    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        debriefText = TextBox17.Text
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        endingClass = TextBox13.Text
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        endingTitle = TextBox14.Text
    End Sub

    Private Sub TextBox15_TextChanged(sender As Object, e As EventArgs) Handles TextBox15.TextChanged
        endingDescript = TextBox15.Text
    End Sub

    Private Sub TextBox16_TextChanged(sender As Object, e As EventArgs) Handles TextBox16.TextChanged
        endingPic = TextBox16.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            usingDebriefing = True
            descriptionEXTCreator.Label14.Text = "Set = True"
        Else
            usingDebriefing = False
            descriptionEXTCreator.Label14.Text = "Set = False"
        End If
    End Sub
End Class