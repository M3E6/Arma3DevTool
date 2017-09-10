Imports System.Collections.ObjectModel
Imports System.IO
Imports Microsoft.VisualBasic.FileIO

Public Class defineSubpath2

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        sound_descript.subPath = TextBox1.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FolderBrowserDialog1.ShowDialog()

        Dim files = My.Computer.FileSystem.GetFiles(FolderBrowserDialog1.SelectedPath)

        For Each sound As String In files
            Dim soundName As String = Path.GetFileName(sound)

            sound_descript.soundFiles.Add(soundName)

        Next

        For Each sound As String In sound_descript.soundFiles
            Dim soundnoExt As String = (sound.Substring(0, sound.Length - 4))
            sound_descript.currentSound = vbTab & "class " & soundnoExt & vbCrLf & vbTab & "{" & vbCrLf & vbTab & vbTab & "name = """ & soundnoExt & """;" & vbCrLf & vbTab & vbTab & "sound[] = {" & """" & sound_descript.subPath & "/" & sound & """," & "db+0" & ",1};""" & vbCrLf & vbTab & "};" & vbCrLf

            sound_descript.finalList.Add(sound_descript.currentSound)
        Next
        sound_descript.TextBox4.Text = ""
        For Each sound As String In sound_descript.finalList
            sound_descript.TextBox4.Text = sound_descript.TextBox4.Text & sound
        Next

        sound_descript.finalList = Nothing

        sound_descript.soundFiles = Nothing

        files = Nothing

        Me.Close()
    End Sub
End Class