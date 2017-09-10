Public Class selectBestPlaces

    Public forestF As Decimal = 0.0
    Public treeF As Decimal = 0.0
    Public medaowsF As Decimal = 0.0
    Public housesF As Decimal = 0.0
    Public hillsF As Decimal = 0.0
    Public nightF As Decimal = 0.0
    Public windF As Decimal = 0.0
    Public bodyF As Decimal = 0.0

    Public thingToCompare As String = "forest"

    Public finalString As String = "selectBestPlaces[_position,"""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        finalString = "selectBestPlaces[_position,""" & thingToCompare



        If (Not NumericUpDown1.Value = 0.0 And Not thingToCompare = "forest") Then
            finalString = finalString & forestF.ToString
        End If

        If (Not NumericUpDown2.Value = 0.0 And Not thingToCompare = "trees") Then
            finalString = finalString & treeF.ToString
        End If

        If (Not NumericUpDown3.Value = 0.0 And Not thingToCompare = "medaows") Then
            finalString = finalString & medaowsF.ToString
        End If

        If (Not NumericUpDown4.Value = 0.0 And Not thingToCompare = "houses") Then
            finalString = finalString & housesF.ToString
        End If

        If (Not NumericUpDown5.Value = 0.0 And Not thingToCompare = "hills") Then
            finalString = finalString & hillsF.ToString
        End If

        If (Not NumericUpDown6.Value = 0.0 And Not thingToCompare = "night") Then
            finalString = finalString & nightF.ToString
        End If

        If (Not NumericUpDown7.Value = 0.0 And Not thingToCompare = "wind") Then
            finalString = finalString & windF.ToString
        End If

        If (Not NumericUpDown8.Value = 0.0 And Not thingToCompare = "deadBody") Then
            finalString = finalString & bodyF.ToString
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        thingToCompare = TextBox1.Text
    End Sub
End Class