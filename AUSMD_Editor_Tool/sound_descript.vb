Imports System.Collections.ObjectModel
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class sound_descript

    Public soundClass As String = ""
    Public soundName As String = ""
    Public soundPath As String = ""
    Public soundConfig As String = descriptionEXTCreator.soundText & vbCrLf & vbTab

    Public soundFiles As New List(Of String)

    Public finalList As New List(Of String)

    Public currentSound As String = ""

    Public pathToFolder As String = ""

    Public subPath As String = ""

    Public files As ReadOnlyCollection(Of String)



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        If (soundConfig = "") Then
            soundConfig = vbTab & "class " & soundClass & vbCrLf & vbTab & "{" & vbCrLf & vbTab & vbTab & "name = """ & soundName & """;" & vbCrLf & vbTab & vbTab & "sound[] = {" & """" & soundPath & """,1,1};" & vbCrLf & vbTab & vbTab & "titles[] = {0,""""};" & vbCrLf & vbTab & "};" & vbCrLf
        Else
            soundConfig = soundConfig & vbTab & "class " & soundClass & vbCrLf & vbTab & "{" & vbCrLf & vbTab & vbTab & "name = """ & soundName & """;" & vbCrLf & vbTab & vbTab & "sound[] = {" & """" & soundPath & """,1,1};" & vbCrLf & vbTab & vbTab & "titles[] = {0,""""};" & vbCrLf & vbTab & "};" & vbCrLf
        End If

        descriptionEXTCreator.soundText = soundConfig

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""

        TextBox4.Text = soundConfig

        If (CheckBox1.Checked = False) Then
            MessageBox.Show("Created Sound, but use cfgSounds is not checked...")
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        soundPath = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        soundName = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        soundClass = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        soundConfig = TextBox4.Text
        descriptionEXTCreator.soundText = soundConfig
    End Sub

    Private Sub sound_descript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox4.Text = soundConfig
        descriptionEXTCreator.soundText = soundConfig

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            descriptionEXTCreator.useSoundCfg = True
            descriptionEXTCreator.Label17.Text = "Set = True"
        Else
            descriptionEXTCreator.useSoundCfg = False
            descriptionEXTCreator.Label17.Text = "Set = False"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        defineSubpath2.Visible = True
        defineSubpath2.Enabled = True
    End Sub
End Class