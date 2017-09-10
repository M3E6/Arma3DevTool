Imports System.Collections.ObjectModel
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class music_descript


    Public musicClass As String = ""
    Public musicName As String = ""
    Public musicPath As String = ""
    Public decibles As Integer = 0
    Public dbText As String = "db+"
    Public musicConfig As String = descriptionEXTCreator.musicConfiguration
    Public subPath As String = ""

    Public soundFiles As New List(Of String)

    Public finalList As New List(Of String)

    Public currentSound As String = ""

    Public pathToFolder As String = ""

    Public files As ReadOnlyCollection(Of String)


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (decibles = 0 Or decibles > 0) Then
            dbText = "db+"
        Else
            dbText = "db-"
        End If

        If (musicConfig = "") Then
            musicConfig =  vbCrLf & vbTab & "class " & musicClass & vbCrLf & vbTab & "{" & vbCrLf & vbTab & vbTab & "name = """ & musicName & """;" & vbCrLf & vbTab & vbTab & "sound[] = {" & """" & musicPath & """," & dbText & decibles.ToString & ",1};""" & vbCrLf & vbTab & "};" & vbCrLf
        Else
            musicConfig = musicConfig & vbTab & "class " & musicClass & vbCrLf & vbTab & "{" & vbCrLf & vbTab & vbTab & "name = """ & musicName & """;" & vbCrLf & vbTab & vbTab & "sound[] = {" & """" & musicPath & """," & dbText & decibles.ToString & ",1};""" & vbCrLf & vbTab & "};" & vbCrLf
        End If

        descriptionEXTCreator.musicConfiguration = musicConfig

        TextBox1.Text = ""
        TextBox2.Text = ""
        NumericUpDown1.Value = 0

        TextBox4.Text = musicConfig

        If (CheckBox1.Checked = False) Then
            MessageBox.Show("Created Track, but use cfgMusic is not checked...")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            descriptionEXTCreator.useMusic = True
            descriptionEXTCreator.Label19.Text = "Set = True"
        Else
            descriptionEXTCreator.useMusic = False
            descriptionEXTCreator.Label19.Text = "Set = False"
        End If
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        decibles = NumericUpDown1.Value
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        musicPath = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        musicName = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        musicClass = TextBox3.Text
    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        musicConfig = TextBox4.Text
        descriptionEXTCreator.musicConfiguration = musicConfig
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        defineSubpath.Visible = True
        defineSubpath.Enabled = True

    End Sub
End Class