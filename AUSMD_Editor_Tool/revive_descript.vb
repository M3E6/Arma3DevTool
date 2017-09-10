Public Class revive_descript

    Public useReviveE As Boolean = False
    Public reviveDelay As String = ""
    Public forceRespawnDelay As String = ""
    Public bleedoutDELAY As String = ""

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            useReviveE = True
            descriptionEXTCreator.useRevive = True
            descriptionEXTCreator.Label15.Text = "Set = True"
        Else
            useReviveE = False
            descriptionEXTCreator.useRevive = False
            descriptionEXTCreator.Label15.Text = "Set = False"
        End If
    End Sub

    Private Sub revive_descript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (descriptionEXTCreator.useRevive = True) Then
            CheckBox1.Checked = True
        Else
            CheckBox1.Checked = False
        End If
    End Sub

    Private Sub TextBox21_TextChanged(sender As Object, e As EventArgs) Handles TextBox21.TextChanged
        reviveDelay = TextBox21.Text
        descriptionEXTCreator.revivedelay = reviveDelay
    End Sub

    Private Sub TextBox22_TextChanged(sender As Object, e As EventArgs) Handles TextBox22.TextChanged
        forceRespawnDelay = TextBox22.Text
        descriptionEXTCreator.reviveForceRespawn = forceRespawnDelay
    End Sub

    Private Sub TextBox23_TextChanged(sender As Object, e As EventArgs) Handles TextBox23.TextChanged
        bleedoutDELAY = TextBox23.Text
        descriptionEXTCreator.reviveBleedout = bleedoutDELAY
    End Sub
End Class