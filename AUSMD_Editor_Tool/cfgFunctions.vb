Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Collections.ObjectModel


Public Class cfgFunctions

    Public yourTag As String = ""
    Public className As String = ""
    Public useFunctionss As Boolean = descriptionEXTCreator.usingFunctions

    Public myFiles As ReadOnlyCollection(Of String)

    Public functionSetup As String = descriptionEXTCreator.FunctionsSetup

    Public fileSearchPath As String = ""

    Public finalFunctionSetup = descriptionEXTCreator.functionsFinal

    Public oneClassAlready As Boolean = descriptionEXTCreator.oneClassAlready

    Public useMultipleClasses As Boolean = descriptionEXTCreator.useMultipleClasses

    ' Public functionSearch As StreamReader

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            useFunctionss = True
            descriptionEXTCreator.useFunctions = True
            descriptionEXTCreator.Label16.Text = "Set = True"
        Else
            useFunctionss = False
            descriptionEXTCreator.useFunctions = False
            descriptionEXTCreator.Label16.Text = "Set = False"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        functionSetup = vbCrLf & vbTab & "class " & yourTag & vbCrLf & vbTab & "{" & vbCrLf & vbTab & vbTab & "class " & className & vbCrLf & vbTab & vbTab & "{" & vbCrLf

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)
        If (oneClassAlready = False) Then
            functionSetup = "class cfgFunctions " & vbCrLf & "{" & vbCrLf & vbTab & "class " & yourTag & vbCrLf & vbTab & "{" & vbCrLf & vbTab & vbTab & "class " & className & vbCrLf & vbTab & vbTab & "{" & vbCrLf
        Else
            functionSetup = functionSetup & vbCrLf & vbTab & "class " & yourTag & vbCrLf & vbTab & "{" & vbCrLf & vbTab & vbTab & "class " & className & vbCrLf & vbTab & vbTab & "{" & vbCrLf
        End If
    End Sub

    Private Sub cfgFunctions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        

        FolderBrowserDialog1.ShowDialog()

        fileSearchPath = FolderBrowserDialog1.SelectedPath

        myFiles = My.Computer.FileSystem.GetFiles(fileSearchPath)

        For Each file As String In myFiles
            If (Path.GetFileName(file).EndsWith(".sqf") And Path.GetFileName(file).StartsWith("fn_")) Then

                ListBox1.Items.Add(file)

            End If

        Next

        TextBox3.Text = functionSetup

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        oneClassAlready = True


        Dim functionsAdd As String = ""

        Dim selectedFiles = ListBox1.SelectedItems

        Dim realFiles As New List(Of String)



        For Each num As String In selectedFiles

            realFiles.Add(ListBox1.GetItemText(num))

        Next

        For Each index As String In realFiles
            Dim file As String = index

            Dim fileName As String = Path.GetFileName(file)

            Dim fileNameNew As String = ""

            fileNameNew = fileName.Substring(3, fileName.Length - 6)

            functionsAdd = functionsAdd & vbCrLf & vbTab & vbTab & vbTab & "class " & fileNameNew & " {" & "};"

        Next


        descriptionEXTCreator.functionsFinal = functionSetup & functionsAdd & vbCrLf & vbTab & vbTab & "};" & vbCrLf & vbTab & "};" & vbCrLf & "};"

        descriptionEXTCreator.functionsSetup = functionSetup & functionsAdd & vbCrLf & vbTab & vbTab & "};" & vbCrLf & vbTab & "};" & vbCrLf & "};"

        If (Not useMultipleClasses = True) Then
            TextBox3.Text = functionSetup & functionsAdd & vbCrLf & vbTab & vbTab & "};" & vbCrLf & vbTab & "};" & vbCrLf & "};"
        Else
            TextBox3.Text = functionSetup & functionsAdd & vbCrLf & vbTab & vbTab & "};" & vbCrLf & vbTab & "};" & vbCrLf & vbTab
        End If



    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        functionSetup = TextBox3.Text
        descriptionEXTCreator.functionsSetup = functionSetup
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            useMultipleClasses = True
            descriptionEXTCreator.useMultipleClasses = True

        Else
            useMultipleClasses = False
            descriptionEXTCreator.useMultipleClasses = False
        End If
    End Sub
End Class