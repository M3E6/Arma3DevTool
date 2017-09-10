Imports Microsoft.VisualBasic.FileIO
Imports System.Collections.ObjectModel
Imports System.IO

Public Class FormMain

    Public selectedDriveLetter As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormLightGen.Visible = True
        FormLightGen.Enabled = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FormCalculator.Visible = True
        FormCalculator.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormIntelGen.Visible = True
        FormIntelGen.Enabled = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormTaskGen.Visible = True
        FormTaskGen.Enabled = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        AboutAUSMDEditing.Visible = True
        AboutAUSMDEditing.Enabled = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        ScriptSnippets.Visible = True
        ScriptSnippets.Enabled = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        NoteCreator.Visible = True
        NoteCreator.Enabled = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        NotificationCreator.Visible = True
        NotificationCreator.Enabled = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        descriptionEXTCreator.Visible = True
        descriptionEXTCreator.Enabled = True
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FormInitSQF.Visible = True
        FormInitSQF.Enabled = True
    End Sub

    Private Sub Button11_Click_1(sender As Object, e As EventArgs) Handles Button11.Click
        FormAddActionCreator.Visible = True
        FormAddActionCreator.Enabled = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        System.Diagnostics.Process.Start("https://community.bistudio.com/wiki/Category:Scripting_Commands_Arma_3")
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        FormBISMP.Visible = True
        FormBISMP.Enabled = True
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        helpForm.Visible = True
        helpForm.Enabled = True
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        RPTHelper.Visible = True
        RPTHelper.Enabled = True
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        FancyText.Visible = True
        FancyText.Enabled = True
    End Sub

    Private Sub FormMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (My.Settings.selectedDriveLetterSet = False) Then
            selectDrive.Visible = True
            selectDrive.Enabled = True
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        fileInfoCreator.Enabled = True
        fileInfoCreator.Visible = True
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        SQFanalysis.Enabled = True
        SQFanalysis.Visible = True
    End Sub

End Class