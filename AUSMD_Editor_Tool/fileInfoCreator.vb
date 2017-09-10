Imports Microsoft.VisualBasic.FileIO
Imports System.Collections.ObjectModel
Imports System.IO

Public Class fileInfoCreator

    Private author As String
    Private useFileNames As Boolean = False
    Private filesAreFunctions As Boolean = False
    Private myTag As String = ""
    Private currentFileString As String = "error"

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        author = TextBox1.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            useFileNames = True
        Else
            useFileNames = False
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            filesAreFunctions = True
            TextBox2.Visible = True
            TextBox2.Enabled = True
            Label3.Visible = True
            Label3.Enabled = True
        Else
            filesAreFunctions = False
            TextBox2.Visible = False
            TextBox2.Enabled = False
            Label3.Visible = False
            Label3.Enabled = False
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        myTag = TextBox2.Text
    End Sub

    Private Sub fileInfoCreator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Visible = False
        TextBox2.Enabled = False
        Label3.Visible = False
        Label3.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim myFolder As String = ""
        Dim myFiles As ReadOnlyCollection(Of String)
        Dim myWriter As System.IO.StreamWriter
        Dim subFolders As ReadOnlyCollection(Of String)

        FolderBrowserDialog1.ShowDialog()

        myFolder = FolderBrowserDialog1.SelectedPath


        'do it for main folder
        If (myFolder = "") Then
            MessageBox.Show("No Folder Defined.")
        Else
            myFiles = My.Computer.FileSystem.GetFiles(myFolder)

            For Each file As String In myFiles
                If (Path.GetFileName(file).Contains(".sqf")) Then
                    myTag = Path.GetFileName(file)


                    If (useFileNames = True And filesAreFunctions = False) Then
                        currentFileString = "/*" & vbCrLf & vbTab & "author: " & author & vbCrLf & vbTab & "File: " & file & vbCrLf & "*/"
                    ElseIf (useFileNames = False And filesAreFunctions = True) Then
                        currentFileString = "/*" & vbCrLf & vbTab & "author: " & author & vbCrLf & vbTab & "Function: " & myTag & vbCrLf & "*/"
                    ElseIf (useFileNames = False And filesAreFunctions = False) Then
                        currentFileString = "/*" & vbCrLf & vbTab & "author: " & author & vbCrLf & "*/"
                    ElseIf (useFileNames = True And filesAreFunctions = True) Then
                        currentFileString = vbCrLf & "/*" & vbCrLf & vbTab & "author: " & author & vbCrLf & vbTab & "File: " & file & vbCrLf & vbTab & "Function: " & myTag & vbCrLf & "*/"
                    End If

                    If (file.StartsWith("/*")) Then
                        ' do nothing to it because it already has a log here
                    Else
                        'write to it
                        Dim fileReader = My.Computer.FileSystem.OpenTextFileReader(file)
                        Dim oldFileText As String = fileReader.ReadToEnd
                        fileReader.Close()
                        myWriter = My.Computer.FileSystem.OpenTextFileWriter(file, False)
                        myWriter.Write(currentFileString & vbCrLf)
                        myWriter.WriteLine()
                        myWriter.Write(oldFileText)
                        myWriter.WriteLine()
                        myWriter.Close()
                    End If
                End If
            Next

            'do for subfolders
            subFolders = My.Computer.FileSystem.GetDirectories(myFolder)


            For Each folder As String In subFolders

                myFiles = My.Computer.FileSystem.GetFiles(folder)

                For Each file As String In myFiles
                    If (Path.GetFileName(file).Contains(".sqf")) Then


                        myTag = Path.GetFileName(file)


                        If (useFileNames = True And filesAreFunctions = False) Then
                            currentFileString = "/*" & vbCrLf & vbTab & "author: " & author & vbCrLf & vbTab & "File: " & file & vbCrLf & "*/"
                        ElseIf (useFileNames = False And filesAreFunctions = True) Then
                            currentFileString = "/*" & vbCrLf & vbTab & "author: " & author & vbCrLf & vbTab & "Function: " & myTag & vbCrLf & "*/"
                        ElseIf (useFileNames = False And filesAreFunctions = False) Then
                            currentFileString = "/*" & vbCrLf & vbTab & "author: " & author & vbCrLf & "*/"
                        ElseIf (useFileNames = True And filesAreFunctions = True) Then
                            currentFileString = vbCrLf & "/*" & vbCrLf & vbTab & "author: " & author & vbCrLf & vbTab & "File: " & file & vbCrLf & vbTab & "Function: " & myTag & vbCrLf & "*/"
                        End If

                        If (file.StartsWith("/*")) Then
                            ' do nothing to it because it already has a log here
                        Else
                            'write to it
                            Dim fileReader = My.Computer.FileSystem.OpenTextFileReader(file)
                            Dim oldFileText As String = fileReader.ReadToEnd
                            fileReader.Close()
                            myWriter = My.Computer.FileSystem.OpenTextFileWriter(file, False)
                            myWriter.Write(currentFileString & vbCrLf)
                            myWriter.WriteLine()
                            myWriter.Write(oldFileText)
                            myWriter.WriteLine()
                            myWriter.Close()
                        End If
                    End If
                Next

            Next
        End If
    End Sub
End Class