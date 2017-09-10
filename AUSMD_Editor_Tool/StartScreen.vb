Imports Microsoft.VisualBasic.FileIO
Imports System.Collections.ObjectModel
Imports System.IO

Public Class StartScreen


    Private Sub StartScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (My.Settings.selectedDriveLetterSet = True Or My.Settings.firstLogin = False) Then
            My.Settings.firstLogin = True
            My.Settings.Save()
            Dim time As Date = My.Settings.updateTimeCheck
            Debug.Write(time.DayOfYear.ToString & vbCrLf & My.Computer.Clock.LocalTime.DayOfYear & vbCrLf)
            If (Not time.DayOfYear = My.Computer.Clock.LocalTime.DayOfYear) Then
                My.Settings.updateTimeCheck = My.Computer.Clock.LocalTime
                My.Settings.Save()
                For mynum As Integer = 0 To 50 Step 1
                    ProgressBar1.PerformStep()
                    Threading.Thread.Sleep(10)
                Next
            End If
        End If





    End Sub
End Class