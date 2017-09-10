Public NotInheritable Class AboutAUSMDEditing

    Private Sub AboutAUSMDEditing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        ApplicationTitle = "AUSMD Editing Tool"
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "AUSMD Editing Tool"
        Me.LabelVersion.Text = String.Format("Version2.2.0.0")
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = "Author: austin_medic"
        Me.TextBoxDescription.Text = "AUSMD Editing Tool was created by austin_medic to help make repetitive tasks easier to acomplish." & vbCrLf & vbCrLf & "This tool was created using Visual Basic & Visual Studio"
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://forums.bistudio.com/member.php?121504-austin_medic")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        selectDrive.Enabled = True
        selectDrive.Visible = True
    End Sub
End Class
