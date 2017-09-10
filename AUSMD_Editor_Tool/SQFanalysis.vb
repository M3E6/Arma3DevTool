Imports System.IO
Imports Microsoft.VisualBasic.FileIO
Imports System.Collections.ObjectModel
Imports System.Threading

Public Class SQFanalysis

    Private foundFiles As ReadOnlyCollection(Of String)
    Private selectedFolder As String
    Private commandsCanBeMadeFaster As Array = {"visiblePosition", "nearestObjects", "BIS_fnc_arrayCompare", "BIS_fnc_areEqual", "BIS_fnc_selectRandom", "BIS_fnc_MP", "BIS_fnc_relPos", "BIS_fnc_selectRandom"}
    Private assessFile As String
    Private countLines As Integer = 0
    Private currentLine As String
    Private selectedIndex As Integer = 0
    Private selectedFile As String = ""
    Private scanAll As Boolean = False
    Private scanAll2 As Boolean = False
    Private oneachFrameFound = False
    Private timer As Integer
    Private folderName
    Private folderName2
    Private folderName3
    Private folderName4
    Private foldername5
    Private foldername6
    Private openBraceList As New List(Of String)
    Private closedBraceList As New List(Of String)
    Private fileParseThread
    Private fileBraceFinderThread


    Public sqfScriptsFound As New List(Of String)


    'function counts number of real lines. takes file path as argument
    Function CountNumOfLines(ByVal fileToSearch As String)
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


    Private Sub SQFanalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        FolderBrowserDialog1.ShowDialog()

        selectedFolder = FolderBrowserDialog1.SelectedPath

        foundFiles = My.Computer.FileSystem.GetFiles(selectedFolder)

        For Each listboxfile As String In foundFiles
            If (listboxfile.Contains(".sqf")) Then
                sqfScriptsFound.Add(listboxfile)
                ListBox1.Items.Add(Path.GetFileName(listboxfile))
            End If
        Next

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        Label2.Text = "File To Be Scanned: " & (ListBox1.GetItemText(ListBox1.SelectedItem))
        If (scanAll = True) Then
            Label2.Text = "Files to be Scanned: Whole Directory"
        End If
        If (scanAll2 = True) Then
            Label2.Text = "Files to be Scanned: Everything"
        End If

        selectedIndex = ListBox1.SelectedIndex
        selectedFile = sqfScriptsFound.Item(selectedIndex)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = ""
        Dim index As Integer = 0
        timer = My.Computer.Clock.TickCount

        If (scanAll) Then

            Dim oneachFrameFound = False
            For Each File In sqfScriptsFound
                oneachFrameFound = False
                Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(File)


                If (File.Contains(".sqf")) Then




                    countLines = CountNumOfLines(File)
                        If (countLines > 300) Then
                            TextBox1.Text = TextBox1.Text & vbCrLf & "INFO: " & Path.GetFileName(File) & " is bigger than 300 lines, consider making it smaller."
                        End If

                        If (Path.GetFileName(File) = "init.sqf") Then
                            If ((readStream.ReadToEnd).Contains("sleep")) Then
                                TextBox1.Text = TextBox1.Text & vbCrLf & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."
                            End If
                        End If

                        For index = 1 To countLines
                        currentLine = readStream.ReadLine




                        If (Not currentLine = Nothing = True) Then

                            For Each item As String In commandsCanBeMadeFaster

                                If (currentLine.Contains("""#lightsource"" createVehicle") Or currentLine.Contains("""#particlesource"" createVehicle")) Then
                                    TextBox1.Text = TextBox1.Text & vbCrLf & Path.GetFileName(File) & ": Detected lightsource or particle source using createVehicle, " & " needs to be created with createVehicleLocal on line" & (index.ToString) & "."
                                ElseIf currentLine.Contains("onEachFrame") And oneachFrameFound = False Then
                                    TextBox1.Text = TextBox1.Text & vbCrLf & Path.GetFileName(File) & ": Detected onEachFrame" & " should use stacked event handler on line" & (index.ToString) & "."
                                    oneachFrameFound = True
                                ElseIf currentLine.Contains(item) Then
                                    TextBox1.Text = TextBox1.Text & vbCrLf & Path.GetFileName(File) & ": Detected " & item & " Could be changed on line " & (index.ToString) & "."
                                End If
                            Next

                        End If
                    Next

                    End If
                    readStream.Close()


            Next

        ElseIf (scanAll2 = True) Then

            fileParseThread = New Thread(New ThreadStart(AddressOf Me.ReadSubDirectory))
            Me.fileParseThread.Start()

        ElseIf (scanAll = False And scanAll2 = False) Then

            If (selectedFile = "") Then
                MessageBox.Show("No Selected File.")
            Else

                If (selectedFile.Contains(".sqf")) Then

                    Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(selectedFile)

                    countLines = CountNumOfLines(selectedFile)

                    Debug.Write(countLines.ToString & vbCrLf)

                    For index = 1 To countLines
                        currentLine = readStream.ReadLine

                        If (Not currentLine = Nothing = True) Then

                            For Each item As String In commandsCanBeMadeFaster
                                If (currentLine.Contains("""#lightsource"" createVehicle") Or currentLine.Contains("""#particlesource"" createVehicle")) Then
                                    TextBox1.Text = TextBox1.Text & vbCrLf & Path.GetFileName(selectedFile) & ": Detected lightsource or particle source using createVehicle, " & " needs to be created with createVehicleLocal on line" & (index.ToString) & "."
                                ElseIf currentLine.Contains("onEachFrame {") Then
                                    TextBox1.Text = TextBox1.Text & vbCrLf & Path.GetFileName(selectedFile) & ": Detected onEachFrame" & " should use stacked event handler on line" & (index.ToString) & "."
                                ElseIf currentLine.Contains(item) Then
                                    TextBox1.Text = TextBox1.Text & vbCrLf & Path.GetFileName(selectedFile) & ": Detected " & item & " Could be changed on line " & (index.ToString) & "."
                                End If
                            Next
                        End If
                    Next

                    If (Path.GetFileName(selectedFile) = "init.sqf") Then
                        If ((readStream.ReadToEnd).Contains("sleep")) Then
                            TextBox1.Text = TextBox1.Text & vbCrLf & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."
                        End If
                    End If

                    readStream.Close()



                End If
            End If
        End If

        Dim timer2 As Integer = My.Computer.Clock.TickCount

        index = 1

        Label3.Text = "Task Time: " & (timer2 - timer).ToString

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        TextBox1.Text = ""
        sqfScriptsFound.Clear()

        FolderBrowserDialog1.ShowDialog()

        selectedFolder = FolderBrowserDialog1.SelectedPath

        foundFiles = My.Computer.FileSystem.GetFiles(selectedFolder)


        For Each listboxfile As String In foundFiles
            If (listboxfile.Contains(".sqf")) Then
                sqfScriptsFound.Add(listboxfile)
                ListBox1.Items.Add(Path.GetFileName(listboxfile))
            End If
        Next
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            scanAll = True
            scanAll2 = False
            CheckBox2.Checked = False
            Label2.Text = "Files to be Scanned: Whole Directory"
        Else
            scanAll = False
            Label2.Text = "Files to be Scanned: "
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (CheckBox2.Checked) Then
            scanAll2 = True
            scanAll = False
            CheckBox1.Checked = False
            Label2.Text = "Files to be Scanned: Everything"
        Else
            scanAll2 = False
            Label2.Text = "Files to be Scanned: "
        End If
    End Sub


    Delegate Sub StringArgReturningVoidDelegate([text] As String)



    Private Function PerformCommandChecks(ByVal lineOfCode As String, ByVal File As String, ByVal index As Integer)
        For Each item As String In commandsCanBeMadeFaster
            If (currentLine.Contains("""#lightsource"" createVehicle") Or currentLine.Contains("""#particlesource"" createVehicle")) Then
                Dim ccc As New StringArgReturningVoidDelegate(AddressOf setText)
                Me.Invoke(ccc, New Object() {TextBox1.Text & vbCrLf & Path.GetFileName(File) & ": Detected lightsource or particle source using createVehicle, " & " needs to be created with createVehicleLocal on line " & (index.ToString) & "."})
            ElseIf currentLine.Contains("onEachFrame {") And oneachFrameFound = True Then
                Dim cccc As New StringArgReturningVoidDelegate(AddressOf setText)
                Me.Invoke(cccc, New Object() {TextBox1.Text & vbCrLf & Path.GetFileName(File) & ": Detected onEachFrame" & " should use stacked event handler on line " & (index.ToString) & "."})
            ElseIf currentLine.Contains(item) Then
                Dim ccccc As New StringArgReturningVoidDelegate(AddressOf setText)
                Me.Invoke(ccccc, New Object() {TextBox1.Text & vbCrLf & Path.GetFileName(File) & ": Detected " & item & " Could be changed on line " & (index.ToString) & "."})
            End If
        Next
        Return True
    End Function
    Private Function braceMatcher(ByVal line As String, ByVal index As Integer, ByVal file As String)
        Dim myCounter = 0

        Do Until myCounter = line.Length - 1
            myCounter = myCounter + 1
            Dim foundBracket = line.ElementAt(myCounter)
            If (foundBracket = "{") Then
                openBraceList.Add(myCounter.ToString)
            End If
            If (foundBracket = "}") Then
                closedBraceList.Add(myCounter.ToString)
            End If
        Loop

        If ((openBraceList.Count = closedBraceList.Count) = False) Then
            Dim text As New StringArgReturningVoidDelegate(AddressOf setText)
            Me.Invoke(text, New Object() {TextBox1.Text & vbCrLf & Path.GetFileName(file) & ": Detected " & "Opening and Closing bracket count does not match." & " check for missing brackets."})
        End If
        Return True
    End Function

    Private Sub ReadSubDirectory()
        Dim myCount As Integer = 0

        Dim oneachFrameFound = False
        Dim locatedSubDirectories As ReadOnlyCollection(Of String)

        locatedSubDirectories = My.Computer.FileSystem.GetDirectories(selectedFolder)

        For Each subDirectory As String In locatedSubDirectories

            folderName = IO.Path.GetFileName(subDirectory)



            Dim cc As New StringArgReturningVoidDelegate(AddressOf setText)
            Me.Invoke(cc, New Object() {TextBox1.Text & vbCrLf & vbCrLf & "===" & "FOLDER " & folderName & " CONTENTS===" & vbCrLf & vbCrLf})

            foundFiles = My.Computer.FileSystem.GetFiles(subDirectory)



            For Each File In foundFiles

                Debug.WriteLine(File)

                Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(File)

                If (File.Contains(".sqf")) Then
                    myCount = myCount + 1
                    Dim h As New StringArgReturningVoidDelegate(AddressOf setFileCount)
                    Me.Invoke(h, New Object() {myCount.ToString})

                    countLines = CountNumOfLines(File)
                    For index = 1 To countLines
                        currentLine = readStream.ReadLine

                        If (Not currentLine = Nothing = True) Then

                            PerformCommandChecks(currentLine, File, index)

                        End If

                        If (Path.GetFileName(File) = "init.sqf") Then
                            If ((readStream.ReadToEnd).Contains("sleep")) Then
                                Dim cccccc As New StringArgReturningVoidDelegate(AddressOf setText)
                                Me.Invoke(cccccc, New Object() {TextBox1.Text & vbCrLf & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."})
                            End If
                        End If
                    Next
                End If
                readStream.Close()
            Next

            Dim subDir2 As ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(subDirectory)

            If (subDir2.Count > 0) Then

                For Each subDir In subDir2
                    folderName2 = IO.Path.GetFileName(subDir)

                    Dim bb As New StringArgReturningVoidDelegate(AddressOf setText)
                    Me.Invoke(bb, New Object() {TextBox1.Text & vbCrLf & vbCrLf & vbTab & "===" & "SUB-FOLDER " & folderName2 & " CHILD OF " & folderName & " CONTENTS===" & vbCrLf & vbCrLf})
                    foundFiles = My.Computer.FileSystem.GetFiles(subDir)

                    For Each File In foundFiles

                        Debug.WriteLine(File)

                        Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(File)

                        If (File.Contains(".sqf")) Then

                            myCount = myCount + 1
                            Dim h As New StringArgReturningVoidDelegate(AddressOf setFileCount)
                            Me.Invoke(h, New Object() {myCount.ToString})

                            countLines = CountNumOfLines(File)
                            For index = 1 To countLines
                                currentLine = readStream.ReadLine

                                If (Not currentLine = Nothing = True) Then
                                    PerformCommandChecks(currentLine, File, index)
                                End If

                                If (Path.GetFileName(File) = "init.sqf") Then
                                    If ((readStream.ReadToEnd).Contains("sleep")) Then
                                        Dim bbbbbb As New StringArgReturningVoidDelegate(AddressOf setText)
                                        Me.Invoke(bbbbbb, New Object() {TextBox1.Text & vbCrLf & vbTab & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."})
                                    End If
                                End If
                            Next
                        End If
                        readStream.Close()
                    Next
                Next
            End If
            Dim subDir3 As ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(subDirectory)

            If (subDir3.Count > 0) Then

                For Each subDir In subDir3
                    folderName3 = IO.Path.GetFileName(subDir)

                    Dim aa As New StringArgReturningVoidDelegate(AddressOf setText)
                    Me.Invoke(aa, New Object() {TextBox1.Text & vbCrLf & vbCrLf & vbTab & vbTab & "===" & "SUB-FOLDER " & folderName3 & " CHILD OF " & folderName2 & " CONTENTS===" & vbCrLf & vbCrLf})
                    foundFiles = My.Computer.FileSystem.GetFiles(subDir)

                    For Each File In foundFiles

                        Debug.WriteLine(File)

                        Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(File)

                        If (File.Contains(".sqf")) Then

                            myCount = myCount + 1
                            Dim h As New StringArgReturningVoidDelegate(AddressOf setFileCount)
                            Me.Invoke(h, New Object() {myCount.ToString})

                            countLines = CountNumOfLines(File)
                            For index = 1 To countLines
                                currentLine = readStream.ReadLine



                                If (Not currentLine = Nothing = True) Then
                                    PerformCommandChecks(currentLine, File, index)
                                End If

                                If (Path.GetFileName(File) = "init.sqf") Then
                                    If ((readStream.ReadToEnd).Contains("sleep")) Then
                                        Dim aaaaaa As New StringArgReturningVoidDelegate(AddressOf setText)
                                        Me.Invoke(aaaaaa, New Object() {TextBox1.Text & vbCrLf & vbTab & vbTab & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."})
                                    End If
                                End If
                            Next
                        End If
                        readStream.Close()
                    Next
                Next
            End If
            Dim subDir4 As ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(subDirectory)

            If (subDir4.Count > 0) Then

                For Each subDir In subDir4
                    folderName4 = IO.Path.GetFileName(subDir)

                    Dim gg As New StringArgReturningVoidDelegate(AddressOf setText)
                    Me.Invoke(gg, New Object() {TextBox1.Text & vbCrLf & vbCrLf & vbTab & vbTab & vbTab & "===" & "SUB-FOLDER " & folderName4 & " CHILD OF " & folderName3 & " CONTENTS===" & vbCrLf & vbCrLf})
                    foundFiles = My.Computer.FileSystem.GetFiles(subDir)

                    For Each File In foundFiles

                        'Debug.WriteLine(File)


                        Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(File)

                        If (File.Contains(".sqf")) Then

                            myCount = myCount + 1
                            Dim h As New StringArgReturningVoidDelegate(AddressOf setFileCount)
                            Me.Invoke(h, New Object() {myCount.ToString})

                            countLines = CountNumOfLines(File)
                            For index = 1 To countLines
                                currentLine = readStream.ReadLine

                                If (Not currentLine = Nothing = True) Then
                                    PerformCommandChecks(currentLine, File, index)
                                End If

                                If (Path.GetFileName(File) = "init.sqf") Then
                                    If ((readStream.ReadToEnd).Contains("sleep")) Then
                                        Dim gggggg As New StringArgReturningVoidDelegate(AddressOf setText)
                                        Me.Invoke(gggggg, New Object() {TextBox1.Text & vbCrLf & vbTab & vbTab & vbTab & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."})
                                    End If
                                End If
                            Next
                        End If
                        readStream.Close()
                    Next
                Next

                Dim subDir5 As ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(subDirectory)

                If (subDir5.Count > 0) Then

                    For Each subDir In subDir5
                        foldername5 = IO.Path.GetFileName(subDir)
                        Dim f As New StringArgReturningVoidDelegate(AddressOf setText)
                        Me.Invoke(f, New Object() {TextBox1.Text & vbCrLf & vbCrLf & vbTab & vbTab & vbTab & vbTab & "===" & "SUB-FOLDER " & foldername5 & " CHILD OF " & folderName4 & " CONTENTS===" & vbCrLf & vbCrLf})
                        foundFiles = My.Computer.FileSystem.GetFiles(subDir)

                        For Each File In foundFiles

                            Debug.WriteLine(File)


                            Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(File)

                            If (File.Contains(".sqf")) Then
                                myCount = myCount + 1
                                Dim h As New StringArgReturningVoidDelegate(AddressOf setFileCount)
                                Me.Invoke(h, New Object() {myCount.ToString})

                                countLines = CountNumOfLines(File)
                                For index = 1 To countLines
                                    currentLine = readStream.ReadLine

                                    If (Not currentLine = Nothing = True) Then
                                        PerformCommandChecks(currentLine, File, index)
                                    End If

                                    If (Path.GetFileName(File) = "init.sqf") Then
                                        If ((readStream.ReadToEnd).Contains("sleep")) Then
                                            Dim ffffff As New StringArgReturningVoidDelegate(AddressOf setText)
                                            Me.Invoke(ffffff, New Object() {TextBox1.Text & vbCrLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."})
                                        End If
                                    End If
                                Next
                            End If
                            readStream.Close()
                        Next
                    Next

                    Dim subDir6 As ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(subDirectory)

                    If (subDir6.Count > 0) Then

                        For Each subDir In subDir6
                            foldername6 = IO.Path.GetFileName(subDir)
                            Dim ee As New StringArgReturningVoidDelegate(AddressOf setText)
                            Me.Invoke(ee, New Object() {TextBox1.Text & vbCrLf & vbCrLf & vbTab & vbTab & vbTab & "===" & "SUB-FOLDER " & foldername6 & " CHILD OF " & foldername5 & " CONTENTS===" & vbCrLf & vbCrLf})
                            foundFiles = My.Computer.FileSystem.GetFiles(subDir)

                            For Each File In foundFiles

                                Debug.WriteLine(File)

                                Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(File)

                                If (File.Contains(".sqf")) Then
                                    myCount = myCount + 1
                                    Dim h As New StringArgReturningVoidDelegate(AddressOf setFileCount)
                                    Me.Invoke(h, New Object() {myCount.ToString})

                                    countLines = CountNumOfLines(File)
                                    For index = 1 To countLines
                                        currentLine = readStream.ReadLine

                                        If (Not currentLine = Nothing = True) Then
                                            PerformCommandChecks(currentLine, File, index)
                                        End If

                                        If (Path.GetFileName(File) = "init.sqf") Then
                                            If ((readStream.ReadToEnd).Contains("sleep")) Then
                                                Dim eeeeee As New StringArgReturningVoidDelegate(AddressOf setText)
                                                Me.Invoke(eeeeee, New Object() {TextBox1.Text & vbCrLf & vbTab & vbTab & vbTab & vbTab & vbTab & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."})
                                            End If
                                        End If
                                    Next
                                End If
                                readStream.Close()
                            Next
                        Next
                    End If

                    Dim subDir7 As ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(subDirectory)

                    If (subDir7.Count > 0) Then

                        For Each subDir In subDir7
                            foldername6 = IO.Path.GetFileName(subDir)
                            Dim ee As New StringArgReturningVoidDelegate(AddressOf setText)
                            Me.Invoke(ee, New Object() {TextBox1.Text & vbCrLf & vbCrLf & vbTab & vbTab & vbTab & "===" & "SUB-FOLDER " & foldername6 & " CHILD OF " & foldername5 & " CONTENTS===" & vbCrLf & vbCrLf})
                            foundFiles = My.Computer.FileSystem.GetFiles(subDir)

                            For Each File In foundFiles

                                Debug.WriteLine(File)

                                Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(File)

                                If (File.Contains(".sqf")) Then
                                    myCount = myCount + 1
                                    Dim h As New StringArgReturningVoidDelegate(AddressOf setFileCount)
                                    Me.Invoke(h, New Object() {myCount.ToString})

                                    countLines = CountNumOfLines(File)
                                    For index = 1 To countLines
                                        currentLine = readStream.ReadLine

                                        If (Not currentLine = Nothing = True) Then
                                            PerformCommandChecks(currentLine, File, index)
                                        End If

                                        If (Path.GetFileName(File) = "init.sqf") Then
                                            If ((readStream.ReadToEnd).Contains("sleep")) Then
                                                Dim eeeeee As New StringArgReturningVoidDelegate(AddressOf setText)
                                                Me.Invoke(eeeeee, New Object() {TextBox1.Text & vbCrLf & vbTab & vbTab & vbTab & vbTab & vbTab & vbTab & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."})
                                            End If
                                        End If
                                    Next
                                End If
                                readStream.Close()
                            Next
                        Next
                    End If

                    Dim subDir8 As ReadOnlyCollection(Of String) = My.Computer.FileSystem.GetDirectories(subDirectory)

                    If (subDir8.Count > 0) Then

                        For Each subDir In subDir8
                            foldername6 = IO.Path.GetFileName(subDir)
                            Dim ee As New StringArgReturningVoidDelegate(AddressOf setText)
                            Me.Invoke(ee, New Object() {TextBox1.Text & vbCrLf & vbCrLf & vbTab & vbTab & vbTab & vbTab & vbTab & "===" & "SUB-FOLDER " & foldername6 & " CHILD OF " & foldername5 & " CONTENTS===" & vbCrLf & vbCrLf})
                            foundFiles = My.Computer.FileSystem.GetFiles(subDir)

                            For Each File In foundFiles

                                Debug.WriteLine(File)

                                Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(File)

                                If (File.Contains(".sqf")) Then
                                    myCount = myCount + 1
                                    Dim h As New StringArgReturningVoidDelegate(AddressOf setFileCount)
                                    Me.Invoke(h, New Object() {myCount.ToString})

                                    countLines = CountNumOfLines(File)
                                    For index = 1 To countLines
                                        currentLine = readStream.ReadLine

                                        If (Not currentLine = Nothing = True) Then
                                            PerformCommandChecks(currentLine, File, index)
                                        End If

                                        If (Path.GetFileName(File) = "init.sqf") Then
                                            If ((readStream.ReadToEnd).Contains("sleep")) Then
                                                Dim eeeeee As New StringArgReturningVoidDelegate(AddressOf setText)
                                                Me.Invoke(eeeeee, New Object() {TextBox1.Text & vbCrLf & vbTab & vbTab & vbTab & vbTab & vbTab & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."})
                                            End If
                                        End If
                                    Next
                                End If
                                readStream.Close()
                            Next
                        Next
                    End If

                End If

            End If
        Next

        Dim dd As New StringArgReturningVoidDelegate(AddressOf setText)
        Me.Invoke(dd, New Object() {TextBox1.Text & vbCrLf & vbCrLf & "===BASE FOLDER SCRIPTS===" & vbCrLf & vbCrLf})

        For Each File In sqfScriptsFound
            oneachFrameFound = False
            Dim readStream As StreamReader = My.Computer.FileSystem.OpenTextFileReader(File)

            If (File.Contains(".sqf")) Then

                myCount = myCount + 1

                Dim h As New StringArgReturningVoidDelegate(AddressOf setFileCount)
                Me.Invoke(h, New Object() {myCount.ToString})

                countLines = CountNumOfLines(File)

                If (countLines > 300) Then
                    Dim ddd As New StringArgReturningVoidDelegate(AddressOf setText)
                    Me.Invoke(ddd, New Object() {TextBox1.Text & vbCrLf & "INFO: " & Path.GetFileName(File) & " is bigger than 300 lines, consider making it smaller."})
                End If

                If (Path.GetFileName(File) = "init.sqf") Then
                    If ((readStream.ReadToEnd).Contains("sleep")) Then
                        Dim dddd As New StringArgReturningVoidDelegate(AddressOf setText)
                        Me.Invoke(dddd, New Object() {TextBox1.Text & vbCrLf & "INFO: Init.sqf shouldn't have any sleep if possible, should only use to initalize other scripts."})
                    End If
                End If

                For index = 1 To countLines
                    currentLine = readStream.ReadLine

                    If (Not currentLine = Nothing = True) Then
                        PerformCommandChecks(currentLine, File, index)
                        braceMatcher(currentLine, index, File)
                    End If
                Next

            End If
            readStream.Close()


        Next

        Dim d As New StringArgReturningVoidDelegate(AddressOf setFileCount)
        Me.Invoke(d, New Object() {myCount.ToString})
    End Sub

    Private Sub setText(ByVal text As String)
        TextBox1.Text = text

    End Sub

    Private Sub setFileCount(ByVal fileCount As Integer)
        Label4.Text = "Files scanned: " & fileCount.ToString
    End Sub

End Class