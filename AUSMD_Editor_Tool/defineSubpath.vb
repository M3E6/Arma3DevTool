Imports System.Collections.ObjectModel
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class defineSubpath

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        music_descript.subPath = TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()

        Dim files = My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath)

        For Each sound As String In files
            Dim soundName As String = Path.GetFileName(sound)

            music_descript.soundFiles.Add(soundName)

        Next

        For Each sound As String In music_descript.soundFiles
            Dim soundnoExt As String = (sound.Substring(0, sound.Length - 4))
            music_descript.currentSound = vbTab & "class " & soundnoExt & vbCrLf & vbTab & "{" & vbCrLf & vbTab & vbTab & "name = """ & soundnoExt & """;" & vbCrLf & vbTab & vbTab & "sound[] = {" & """" & music_descript.subPath & "/" & sound & """," & "db+0" & ",1};""" & vbCrLf & vbTab & "};" & vbCrLf

            music_descript.finalList.Add(music_descript.currentSound)
        Next
        music_descript.TextBox4.Text = ""
        For Each sound As String In music_descript.finalList
            music_descript.TextBox4.Text = music_descript.TextBox4.Text & sound
        Next

        music_descript.finalList = Nothing

        music_descript.soundFiles = Nothing

        files = Nothing

        Me.Close()
    End Sub
End Class