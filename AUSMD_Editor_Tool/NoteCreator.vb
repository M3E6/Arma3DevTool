Public Class NoteCreator
    Public noteTitle As String = ""
    Public noteContents As String = ""

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        noteTitle = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        noteContents = TextBox2.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Clipboard.SetText("player createDiaryRecord [""Diary"",[" & """" & noteTitle & """" & "," & """" & noteContents & """" & "]];")
    End Sub
End Class