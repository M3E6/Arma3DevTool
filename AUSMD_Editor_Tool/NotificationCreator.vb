Public Class NotificationCreator
    Public classname As String = ""
    Public notifname As String = ""
    Public pictureName As String = ""
    Public pictureText As String = ""
    Public description As String = ""
    Public colors As String = ""
    Public duration As String = ""
    Public priority As String = ""
    Public thecodez As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (CheckBox1.Checked) Then
            My.Computer.Clipboard.SetText(thecodez)
            TextBox9.Text = thecodez
        Else
            thecodez = "class Notifications" & vbCrLf & "{" & thecodez & vbCrLf & "};"
            TextBox9.Text = thecodez
            My.Computer.Clipboard.SetText(thecodez)
        End If
        thecodez = ""
        classname = ""
        notifname = ""
        pictureName = ""
        pictureText = ""
        description = ""
        colors = ""
        duration = ""
        priority = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        classname = TextBox1.Text
        thecodez = vbCrLf & vbTab & "class " & classname & vbCrLf & vbTab & " {" & vbCrLf & vbTab & vbTab & "title = " & """" & notifname & """" & ";" & vbCrLf & vbTab & vbTab & "iconPicture = " & """" & pictureName & """" & ";" & vbCrLf & vbTab & vbTab & "iconText = " & """" & pictureText & """" & ";" & vbCrLf & vbTab & vbTab & "description = " & """" & description & """" & ";" & vbCrLf & vbTab & vbTab & "colors = " & colors & ";" & vbCrLf & vbTab & vbTab & "duration = " & duration & ";" & vbCrLf & vbTab & vbTab & "priority = " & priority & ";" & vbCrLf & vbTab & "};"
        If (CheckBox1.Checked) Then
            TextBox9.Text = thecodez
        Else
            thecodez = "class Notifications" & vbCrLf & "{" & thecodez & vbCrLf & "};"
            TextBox9.Text = thecodez
        End If
        TextBox9.Text = thecodez
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        notifname = TextBox2.Text
        thecodez = vbCrLf & vbTab & "class " & classname & vbCrLf & vbTab & " {" & vbCrLf & vbTab & vbTab & "title = " & """" & notifname & """" & ";" & vbCrLf & vbTab & vbTab & "iconPicture = " & """" & pictureName & """" & ";" & vbCrLf & vbTab & vbTab & "iconText = " & """" & pictureText & """" & ";" & vbCrLf & vbTab & vbTab & "description = " & """" & description & """" & ";" & vbCrLf & vbTab & vbTab & "colors = " & colors & ";" & vbCrLf & vbTab & vbTab & "duration = " & duration & ";" & vbCrLf & vbTab & vbTab & "priority = " & priority & ";" & vbCrLf & vbTab & "};"
        If (CheckBox1.Checked) Then
            TextBox9.Text = thecodez
        Else
            thecodez = "class Notifications" & vbCrLf & "{" & thecodez & vbCrLf & "};"
            TextBox9.Text = thecodez
        End If
        TextBox9.Text = thecodez
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        pictureName = TextBox3.Text
        thecodez = vbCrLf & vbTab & "class " & classname & vbCrLf & vbTab & " {" & vbCrLf & vbTab & vbTab & "title = " & """" & notifname & """" & ";" & vbCrLf & vbTab & vbTab & "iconPicture = " & """" & pictureName & """" & ";" & vbCrLf & vbTab & vbTab & "iconText = " & """" & pictureText & """" & ";" & vbCrLf & vbTab & vbTab & "description = " & """" & description & """" & ";" & vbCrLf & vbTab & vbTab & "colors = " & colors & ";" & vbCrLf & vbTab & vbTab & "duration = " & duration & ";" & vbCrLf & vbTab & vbTab & "priority = " & priority & ";" & vbCrLf & vbTab & "};"
        If (CheckBox1.Checked) Then
            TextBox9.Text = thecodez
        Else
            thecodez = "class Notifications" & vbCrLf & "{" & thecodez & vbCrLf & "};"
            TextBox9.Text = thecodez
        End If
        TextBox9.Text = thecodez
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        pictureText = TextBox4.Text
        thecodez = vbCrLf & vbTab & "class " & classname & vbCrLf & vbTab & " {" & vbCrLf & vbTab & vbTab & "title = " & """" & notifname & """" & ";" & vbCrLf & vbTab & vbTab & "iconPicture = " & """" & pictureName & """" & ";" & vbCrLf & vbTab & vbTab & "iconText = " & """" & pictureText & """" & ";" & vbCrLf & vbTab & vbTab & "description = " & """" & description & """" & ";" & vbCrLf & vbTab & vbTab & "colors = " & colors & ";" & vbCrLf & vbTab & vbTab & "duration = " & duration & ";" & vbCrLf & vbTab & vbTab & "priority = " & priority & ";" & vbCrLf & vbTab & "};"
        If (CheckBox1.Checked) Then
            TextBox9.Text = thecodez
        Else
            thecodez = "class Notifications" & vbCrLf & "{" & thecodez & vbCrLf & "};"
            TextBox9.Text = thecodez
        End If
        TextBox9.Text = thecodez
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        description = TextBox5.Text
        thecodez = vbCrLf & vbTab & "class " & classname & vbCrLf & vbTab & " {" & vbCrLf & vbTab & vbTab & "title = " & """" & notifname & """" & ";" & vbCrLf & vbTab & vbTab & "iconPicture = " & """" & pictureName & """" & ";" & vbCrLf & vbTab & vbTab & "iconText = " & """" & pictureText & """" & ";" & vbCrLf & vbTab & vbTab & "description = " & """" & description & """" & ";" & vbCrLf & vbTab & vbTab & "colors = " & colors & ";" & vbCrLf & vbTab & vbTab & "duration = " & duration & ";" & vbCrLf & vbTab & vbTab & "priority = " & priority & ";" & vbCrLf & vbTab & "};"
        If (CheckBox1.Checked) Then
            TextBox9.Text = thecodez
        Else
            thecodez = "class Notifications" & vbCrLf & "{" & thecodez & vbCrLf & "};"
            TextBox9.Text = thecodez
        End If
        TextBox9.Text = thecodez
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        colors = TextBox6.Text
        thecodez = vbCrLf & vbTab & "class " & classname & vbCrLf & vbTab & " {" & vbCrLf & vbTab & vbTab & "title = " & """" & notifname & """" & ";" & vbCrLf & vbTab & vbTab & "iconPicture = " & """" & pictureName & """" & ";" & vbCrLf & vbTab & vbTab & "iconText = " & """" & pictureText & """" & ";" & vbCrLf & vbTab & vbTab & "description = " & """" & description & """" & ";" & vbCrLf & vbTab & vbTab & "colors = " & colors & ";" & vbCrLf & vbTab & vbTab & "duration = " & duration & ";" & vbCrLf & vbTab & vbTab & "priority = " & priority & ";" & vbCrLf & vbTab & "};"
        If (CheckBox1.Checked) Then
            TextBox9.Text = thecodez
        Else
            thecodez = "class Notifications" & vbCrLf & "{" & thecodez & vbCrLf & "};"
            TextBox9.Text = thecodez
        End If
        TextBox9.Text = thecodez
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        duration = TextBox7.Text
        thecodez = vbCrLf & vbTab & "class " & classname & vbCrLf & vbTab & " {" & vbCrLf & vbTab & vbTab & "title = " & """" & notifname & """" & ";" & vbCrLf & vbTab & vbTab & "iconPicture = " & """" & pictureName & """" & ";" & vbCrLf & vbTab & vbTab & "iconText = " & """" & pictureText & """" & ";" & vbCrLf & vbTab & vbTab & "description = " & """" & description & """" & ";" & vbCrLf & vbTab & vbTab & "colors = " & colors & ";" & vbCrLf & vbTab & vbTab & "duration = " & duration & ";" & vbCrLf & vbTab & vbTab & "priority = " & priority & ";" & vbCrLf & vbTab & "};"
        If (CheckBox1.Checked) Then
            TextBox9.Text = thecodez
        Else
            thecodez = "class Notifications" & vbCrLf & "{" & thecodez & vbCrLf & "};"
            TextBox9.Text = thecodez
        End If
        TextBox9.Text = thecodez
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        priority = TextBox8.Text
        thecodez = vbCrLf & vbTab & "class " & classname & vbCrLf & vbTab & " {" & vbCrLf & vbTab & vbTab & "title = " & """" & notifname & """" & ";" & vbCrLf & vbTab & vbTab & "iconPicture = " & """" & pictureName & """" & ";" & vbCrLf & vbTab & vbTab & "iconText = " & """" & pictureText & """" & ";" & vbCrLf & vbTab & vbTab & "description = " & """" & description & """" & ";" & vbCrLf & vbTab & vbTab & "colors = " & colors & ";" & vbCrLf & vbTab & vbTab & "duration = " & duration & ";" & vbCrLf & vbTab & vbTab & "priority = " & priority & ";" & vbCrLf & vbTab & "};"
        If (CheckBox1.Checked) Then
            TextBox9.Text = thecodez
        Else
            thecodez = "class Notifications" & vbCrLf & "{" & thecodez & vbCrLf & "};"
            TextBox9.Text = thecodez
        End If
        TextBox9.Text = thecodez
    End Sub
End Class