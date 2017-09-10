Public Class FancyText

    Private formattingStringS As String = "<t "
    Private formattingStringE As String = "</t> "
    Private colorFormatting As String = ""
    Private pictureFormatting As String = ""
    Private sizeFormatting As String = ""
    Private shadowFormatting As String = ""
    Private alignmentFormatting As String = ""
    Private underlineFormatting As String = ""
    Private textColor As String = ""
    Private pictureToUse As String = ""
    Private sizeR As String = ""
    Private shadowColor As String = ""
    Private userText As String = ""
    Private formattingStringFinal As String = ""
    Dim aligmentFormatting As String = ""

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            TextBox1.Enabled = True
        Else
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        textColor = TextBox1.Text
        colorFormatting = "color='" & textColor & "' "
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            TextBox2.Enabled = True
        Else
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        pictureToUse = TextBox2.Text
        pictureFormatting = "img image='" & pictureToUse & "' "
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If (CheckBox3.Checked) Then
            TextBox3.Enabled = True
        Else
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        sizeR = TextBox3.Text
        sizeFormatting = "size='" & sizeR & "' "
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If (CheckBox4.Checked) Then
            TextBox4.Enabled = True
        Else
            TextBox4.Enabled = False
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        shadowColor = TextBox5.Text
        If (ComboBox3.SelectedText = "No Shadow") Then
            shadowFormatting = " "
        Else
            shadowFormatting = "shadowColor='" & shadowColor & "' "
        End If

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        userText = TextBox6.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If (ComboBox1.SelectedIndex = 0) Then
            alignmentFormatting = ""
        ElseIf (ComboBox1.SelectedIndex = 1) Then
            aligmentFormatting = "align='" & "left" & "' "
        ElseIf (ComboBox1.SelectedIndex = 2) Then
            aligmentFormatting = "align='" & "right" & "' "
        ElseIf (ComboBox1.SelectedIndex = 3) Then
            aligmentFormatting = "align='" & "center" & "' "
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If (ComboBox2.SelectedText = "No Underline") Then
            underlineFormatting = " "
        Else
            underlineFormatting = "underline='true'"
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If (ComboBox3.SelectedIndex = 0) Then
            shadowFormatting = " "
            TextBox5.Enabled = False
        ElseIf (ComboBox3.SelectedIndex = 1) Then
            TextBox5.Enabled = True
            shadowFormatting = "shadow='1' "
        ElseIf (ComboBox3.SelectedIndex = 2) Then
            TextBox5.Enabled = True
            shadowFormatting = "shadow='2' "
        End If
    End Sub

    Private Sub FancyText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        formattingStringFinal = formattingStringS
        If (CheckBox1.Checked) Then
            formattingStringFinal = formattingStringFinal & colorFormatting
        End If

        If (CheckBox2.Checked) Then
            formattingStringFinal = formattingStringFinal & pictureFormatting
        End If

        If (CheckBox3.Checked) Then
            formattingStringFinal = formattingStringFinal & sizeFormatting
        End If

        If (CheckBox4.Checked) Then
            formattingStringFinal = formattingStringFinal & "font='" & TextBox4.Text & "' "
        End If
        If (Not ComboBox1.SelectedIndex = 0) Then
            formattingStringFinal = formattingStringFinal & aligmentFormatting
        Else
            aligmentFormatting = ""
            formattingStringFinal = formattingStringFinal & ""
        End If

        If (ComboBox2.SelectedIndex = 1) Then
            formattingStringFinal = formattingStringFinal & underlineFormatting
        End If
        If (ComboBox3.SelectedIndex = 1 Or ComboBox3.SelectedIndex = 2) Then
            formattingStringFinal = formattingStringFinal & shadowFormatting & " shadowColor='" & shadowColor & "' "
        End If

        formattingStringFinal = formattingStringFinal & " >" & userText & "</t>"

        TextBox7.Text = formattingStringFinal
    End Sub
End Class