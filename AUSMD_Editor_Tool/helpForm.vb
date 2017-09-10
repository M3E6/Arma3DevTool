Public Class helpForm
    Public allForms(7) As String
    Private Sub helpForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        allForms(0) = "RPT Helper"
        allForms(1) = "Description.ext"
        allForms(2) = "BIS_fnc_MP"
        allForms(3) = "Color Picker"
        allForms(4) = "Light Generator"
        allForms(5) = "Addaction Creator"
        allForms(6) = "Task Generator"
        allForms(7) = "SQF Analysis"
        For num As Integer = 0 To allForms.Length - 1
            ListBox1.Items.Add(allForms(num))
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim myText As String = ""
        If (ListBox1.SelectedItem = "Description.ext") Then
            myText = "Description.ext is a file that acts as a config and holds information relevant to the mission file itself, such as the name of the mission, the overview, and the picture displayed in the loading screen." & vbCrLf & vbCrLf & "There is also other things handled here such as what type of mission it is, and what type of respawn system it uses." & vbCrLf & vbCrLf & "Also has support for multiple common 'class' types such as debriefing, music, and sounds."
        ElseIf ListBox1.SelectedItem = "BIS_fnc_MP" Then
            myText = "BIS_fnc_MP is a function that is capable of sending data across the network, particularly useful in multiplayer where some commands only happen on the machine they are executed on." & vbCrLf & vbCrLf & "Also useful for sending information to and from the server."
        ElseIf ListBox1.SelectedItem = "Color Picker" Then
            myText = "Color Picker lets you see what color of hex or RGBA values come out as after being divided to fit into the range of 0-1 that arma works with."
        ElseIf ListBox1.SelectedItem = "Light Generator" Then
            myText = "Light Generator lets you select some values from the dialog then automatically creates the code for a light that you can put into a script, or into the init of an object in the editor."
        ElseIf ListBox1.SelectedItem = "Addaction Creator" Then
            myText = "Addaction Creator lets you select the parameters for an action you want to create, and generates the code for you." & vbCrLf & "It is particularly useful for when you want to use the conditions part of the action, and allows you to easily see what is being done in the action itself."
        ElseIf ListBox1.SelectedItem = "Task Generator" Then
            myText = "Task Generator lets you make values for the task in an easy to use dialog that prevents syntax errors by only allowing you to put in the value and then generating the code for the task."
        ElseIf ListBox1.SelectedItem = "RPT Helper" Then
            myText = "RPT Helper lets you access your RPT logs from within the program itself. The filter button allows you to sort through junk that you don't want by entering a few keywords into the list."
        ElseIf ListBox1.SelectedItem = "SQF Analysis" Then
            myText = "SQF Analysis is designed to help you optimize your scripts by pointing out things that could be changed to improve performance. It will ask you to select a folder to search on start up, scripts will appear in the listbox. You can also select to run the analysis on all scripts in the directory if you wish. It can also analyze every script in subdirectories as well."
        End If
        TextBox1.Text = myText
    End Sub
End Class