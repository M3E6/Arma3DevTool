Public Class FormInitSQF
    Public yourCode As String = ""
    Public Parameters As String = ""
    Public Code As String = ""
    Public blockCode As String = ""
    Public blockCode2 As String = ""

    Private Sub FormInitSQF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.Visible = False
        TextBox4.Enabled = False
        Label5.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        blockCode = TextBox3.text
        Code = (vbCrLf & "if(" & Parameters & ") then" & vbCrLf & "{" & vbCrLf & vbTab & blockCode & vbCrLf & vbTab & vbCrLf & "};")
        yourCode = yourCode + Code
        TextBox2.Text = yourCode
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        blockCode = TextBox3.text
        Code = (vbCrLf & "{" & vbCrLf & vbTab & blockCode & vbCrLf & "} " & Parameters & ";")
        yourCode = yourCode + Code
        TextBox2.Text = yourCode
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Clipboard.SetText(yourCode)
        MessageBox.Show("Exported to Clipboard")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        blockCode = TextBox3.Text
        Code = (vbCrLf & "if(" & Parameters & ") then" & vbCrLf & "{" & vbCrLf & vbTab & blockCode & vbCrLf & vbTab & vbCrLf & "} else" & vbCrLf & "{" & vbCrLf & vbTab & blockCode2 & vbCrLf & "};")
        yourCode = yourCode + Code
        TextBox2.Text = yourCode
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        blockCode = TextBox3.Text
        Code = vbCrLf & "while{" & Parameters & "} do" & vbCrLf & "{" & vbCrLf & vbTab & blockCode & vbCrLf & "};"
        yourCode = yourCode + Code
        TextBox2.Text = yourCode
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        blockCode = TextBox3.Text
        Code = vbCrLf & "for ""_i"" from " & Parameters & " to" & TextBox4.Text & " do " & vbCrLf & "{" & vbCrLf & blockCode & vbCrLf & "};"
        yourCode = yourCode + Code
        TextBox2.Text = yourCode
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Parameters = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        yourCode = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        blockCode = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        blockCode2 = TextBox4.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            TextBox4.Visible = True
            TextBox4.Enabled = True
            Label5.Visible = True
        Else
            TextBox4.Visible = False
            TextBox4.Enabled = False
            Label5.Visible = False
        End If
    End Sub
End Class