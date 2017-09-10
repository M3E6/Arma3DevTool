Imports Microsoft.VisualBasic.FileIO
Imports System.Collections.ObjectModel
Imports System.IO

Public Class RPTHelper

    Private currentDir As String = My.Settings.selectedDriveLetter & "Users\" & System.Environment.UserName & "\AppData\Local\Arma 3"

    Public currentFilters As New List(Of String)

    Private rptFiles As ReadOnlyCollection(Of String)

    'function counts number of real lines. takes file path as argument
    Function CountNumOfLines(ByVal fileToSearch As String)

        ''name count and set it to 0
        Dim count As Integer
        count = 0
        Dim obj As StreamReader
        obj = New StreamReader(fileToSearch)
        ''loop through the file until the end
        Do Until obj.ReadLine Is Nothing
            count = count + 1
        Loop
        ''close file and show count
        obj.Close()
        Return count

    End Function

    Private Sub RPTHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        rptFiles = My.Computer.FileSystem.GetFiles(currentDir)

        For Each file As String In rptFiles
            If file.Contains(".rpt") Then
                ListBox1.Items.Add(file)
            End If
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim selectedObject As Object = ListBox1.SelectedItem
        Dim selectedFile As String = ListBox1.GetItemText(selectedObject)



        Dim countLines As Integer = CountNumOfLines(selectedFile)

        Dim endBlock As String = ""

        Dim stringReader As String

        Dim currentLineIsBad As Boolean = False

        Dim fileReader = My.Computer.FileSystem.OpenTextFileReader(selectedFile)

        For indext As Integer = 0 To countLines

            currentLineIsBad = False

            stringReader = fileReader.ReadLine

            If (Not stringReader = Nothing) Then
                For Each Filter As String In currentFilters
                    If (stringReader.Contains(Filter) = True) Then
                        currentLineIsBad = True
                    End If
                Next

                If (currentLineIsBad = False) Then
                    endBlock = endBlock & stringReader & vbCrLf
                End If
            End If
            indext = indext + 1
        Next


        fileReader.Close()
        RichTextBox1.Text = endBlock

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        rptFilter.Visible = True
        rptFilter.Enabled = True
    End Sub
End Class