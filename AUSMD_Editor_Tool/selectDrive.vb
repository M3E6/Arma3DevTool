Public Class selectDrive

    Public selectedDriveLetter As String = "C:/"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedDriveLetterF As Integer = ComboBox1.SelectedIndex
        If (selectedDriveLetterF = 0.0) Then
            selectedDriveLetter = "A:/"
        ElseIf selectedDriveLetterF = 1.0 Then
            selectedDriveLetter = "B:/"
        ElseIf selectedDriveLetterF = 2.0 Then
            selectedDriveLetter = "C:/"
        ElseIf selectedDriveLetterF = 3.0 Then
            selectedDriveLetter = "D:/"
        ElseIf selectedDriveLetterF = 4.0 Then
            selectedDriveLetter = "E:/"
        ElseIf selectedDriveLetterF = 5.0 Then
            selectedDriveLetter = "F:/"
        ElseIf selectedDriveLetterF = 6.0 Then
            selectedDriveLetter = "G:/"
        ElseIf selectedDriveLetterF = 7.0 Then
            selectedDriveLetter = "H:/"
        ElseIf selectedDriveLetterF = 8.0 Then
            selectedDriveLetter = "I:/"
        ElseIf selectedDriveLetterF = 9.0 Then
            selectedDriveLetter = "J:/"
        ElseIf selectedDriveLetterF = 10.0 Then
            selectedDriveLetter = "K:/"
        ElseIf selectedDriveLetterF = 11.0 Then
            selectedDriveLetter = "L:/"
        ElseIf selectedDriveLetterF = 12.0 Then
            selectedDriveLetter = "M:/"
        ElseIf selectedDriveLetterF = 13.0 Then
            selectedDriveLetter = "N:/"
        ElseIf selectedDriveLetterF = 14.0 Then
            selectedDriveLetter = "O:/"
        ElseIf selectedDriveLetterF = 15.0 Then
            selectedDriveLetter = "P:/"
        ElseIf selectedDriveLetterF = 16.0 Then
            selectedDriveLetter = "Q:/"
        ElseIf selectedDriveLetterF = 17.0 Then
            selectedDriveLetter = "R:/"
        ElseIf selectedDriveLetterF = 18.0 Then
            selectedDriveLetter = "S:/"
        ElseIf selectedDriveLetterF = 19.0 Then
            selectedDriveLetter = "T:/"
        ElseIf selectedDriveLetterF = 20.0 Then
            selectedDriveLetter = "U:/"
        ElseIf selectedDriveLetterF = 21.0 Then
            selectedDriveLetter = "V:/"
        ElseIf selectedDriveLetterF = 22.0 Then
            selectedDriveLetter = "W:/"
        ElseIf selectedDriveLetterF = 23.0 Then
            selectedDriveLetter = "X:/"
        ElseIf selectedDriveLetterF = 24.0 Then
            selectedDriveLetter = "Y:/"
        ElseIf selectedDriveLetterF = 25.0 Then
            selectedDriveLetter = "Z:/"
        ElseIf selectedDriveLetterF = 27.0 Then

        End If

        MessageBox.Show("Drive Letter set to " & selectedDriveLetter)
        My.Settings.selectedDriveLetter = selectedDriveLetter
        My.Settings.selectedDriveLetterSet = True
        My.Settings.Save()
        Me.Enabled = False
        Me.Visible = False
    End Sub
End Class