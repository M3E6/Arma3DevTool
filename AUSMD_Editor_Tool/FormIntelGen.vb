Public Class FormIntelGen
    Public ifStatement As String = "if(isServer) then {"
    Public BlockTerminator As String = "};"
    Public LineTerminator As String = ";"
    Public textureStart As String = "this setVariable ["
    Public textureStart2 As String = """RscAttributeDiaryRecord_texture"""
    Public textureEnd As String = ", true];"
    Public CommaPoint As String = ","
    Public textStart As String = "[this,"
    Public textStart2 As String = """RscAttributeDiaryRecord"""
    Public textEnd As String = ",""""]] call bis_fnc_setServerVariable;"
    Public recipientstart As String = "this setVariable [""recipients"""
    Public recipientEnd As String = ", true]"
    Public codeEnd As String = "[this,""init""] spawn bis_fnc_initIntelObject;"
    Public TextBlock As String = ""
    Public textureBlock As String = ""
    Public recipientBlock As String = ""

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        textureBlock = TextBox2.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        recipientBlock = TextBox1.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TextBlock = TextBox3.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Replace(TextBlock, "---", "<br/>")
        'TextBlock =
        MessageBox.Show("Exported to Clipboard")
        My.Computer.Clipboard.SetText("" & ifStatement & vbCrLf & vbTab & textureStart & textureStart2 & CommaPoint & """" & textureBlock & """" & textureEnd & vbCrLf & vbTab & textStart & textStart2 & CommaPoint & """" & TextBlock & """" & textEnd & vbCrLf & vbTab & recipientstart & CommaPoint & recipientBlock & recipientEnd & LineTerminator & vbCrLf & vbTab & codeEnd & vbCrLf & BlockTerminator)
    End Sub

    Private Sub FormIntelGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
End Class