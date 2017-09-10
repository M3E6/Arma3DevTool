Public Class configBuilder
    Public rootFolderPath
    Private Sub configBuilder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FolderBrowserDialog1.ShowDialog()

        rootFolderPath = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class