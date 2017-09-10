Public Class FormTaskGen
    Public TaskID As String = ""
    Public TaskName As String = ""
    Public taskDescription As String = ""
    Public waypointname As String = ""
    Public taskOwners As String = ""
    Public commaPoint As String = ","
    Public taskDestination As String = ""
    Public taskState As String = "CREATED"
    Public taskPriority As String = "0"
    Public showNotif As Boolean = False
    Public isglobal As Boolean = False
    Public taskTypes(4) As String

    Private Sub FormTaskGen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        taskTypes(0) = "CREATED"
        taskTypes(1) = "ASSIGNED"
        taskTypes(2) = "SUCCEEDED"
        taskTypes(3) = "FAILED"
        taskTypes(4) = "AUTOASSIGNED"

        For num As Integer = 0 To taskTypes.Length - 1
            ComboBox1.Items.Add(taskTypes(num))
        Next

        ComboBox1.SelectedIndex = 0

        taskState = ComboBox1.SelectedItem
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Clipboard.SetText("" & "[" & """" & TaskID & """" & commaPoint & taskOwners & commaPoint & "[" & """" & taskDescription & """" & commaPoint & """" & TaskName & """" & commaPoint & """" & waypointname & """" & "]" & commaPoint & """" & taskDestination & """" & commaPoint & """" & taskState & """" & commaPoint & taskPriority & commaPoint & showNotif & commaPoint & isglobal & "] spawn BIS_fnc_setTask;")
        MessageBox.Show("Exported to Clipboard")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TaskID = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        taskOwners = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TaskName = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        taskDescription = TextBox4.Text
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        waypointname = TextBox5.Text
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        taskDestination = TextBox6.Text
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        taskPriority = TextBox8.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (showNotif) Then
            showNotif = False
        Else
            showNotif = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If (isglobal) Then
            isglobal = False
        Else
            isglobal = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        ComboBox1.SelectedIndex = 0
        taskState = ComboBox1.SelectedItem
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        isglobal = False
        showNotif = False
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        taskState = ComboBox1.SelectedItem
    End Sub
End Class