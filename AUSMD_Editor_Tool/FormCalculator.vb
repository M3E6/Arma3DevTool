Public Class FormCalculator
    Public hexValueR As String = "0"
    Public hexValueG As String = "0"
    Public hexValueB As String = "0"
    Public hexValueA As String = "0"
    Public convertedHexR As Double
    Public convertedHexG As Double
    Public convertedHexB As Double
    Public convertedHexA As Double
    Public invert As Boolean = False
    Public hexes(3) As String




    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxHexA.Text = hexValueA
        TextBoxHexB.Text = hexValueB
        TextBoxHexG.Text = hexValueG
        TextBoxHexR.Text = hexValueR
    End Sub

    'convert it to something arma can use, needs to be double since it has decimal points
    Private Function convertToDouble(ByVal convertednum As Double) As Double
        If (Not IsNothing(convertednum)) Then

            Dim convertedval As Double = convertednum / 255
            Dim roundedVal As Double
            'dont want it with way too many decimal places. arma will probably explode if it encounters > 8
            roundedVal = Math.Round(convertedval, 6)
            Return roundedVal
        Else
            'return error string if no data was passed
            Return "ERROR"
        End If
    End Function
    'convert hex to RGB
    Public Function HEXCOL2RGB(ByVal HexColor As String) As String

        'The input at this point could be HexColor = "#00FF1F"

        Dim Red As String
        Dim Green As String
        Dim Blue As String

        Dim color As String

        'number sign is useless, lets get rid of it
        color = Replace(HexColor, "#", "")

        Red = Val("&H" & Mid(HexColor, 1, 2))
        'The red value is now the long version of "00"

        Green = Val("&H" & Mid(HexColor, 3, 2))
        'The red value is now the long version of "FF"

        Blue = Val("&H" & Mid(HexColor, 5, 2))
        'The red value is now the long version of "1F"

        'define vars
        hexValueR = Red
        hexValueG = Green
        hexValueB = Blue
        hexValueA = 255
        TextBoxHexB.Text = hexValueB
        TextBoxHexG.Text = hexValueG
        TextBoxHexR.Text = hexValueR
        'hex doesn't need an alpha value, so we'll just use default
        TextBoxHexA.Text = hexValueA

        HEXCOL2RGB = RGB(Red, Green, Blue)
        'The output is an RGB value

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If (Not IsNothing(hexValueA) & Not IsNothing(hexValueB) & Not IsNothing(hexValueG) & Not IsNothing(hexValueR)) Then

        Dim commaLine As String = ","
        Dim hexvaluecR As Integer
        Dim hexvaluecG As Integer
        Dim hexvaluecB As Integer
        Dim hexvaluecA As Integer
        hexvaluecR = CDbl(hexValueR)
        hexvaluecG = CDbl(hexValueG)
        hexvaluecB = CDbl(hexValueB)
        hexvaluecA = CDbl(hexValueA)
        convertedHexR = convertToDouble(hexvaluecR)
        convertedHexG = convertToDouble(hexvaluecG)
        convertedHexB = convertToDouble(hexvaluecB)
        convertedHexA = convertToDouble(hexvaluecA)
        TextBoxGC.Text = CStr(convertedHexG)
        TextBoxBC.Text = CStr(convertedHexB)
        TextBoxAC.Text = CStr(convertedHexA)
        TextBoxRC.Text = CStr(convertedHexR)
        'do they want it in array format?
        If CheckBox1.Checked Then
            My.Computer.Clipboard.SetText("[" & convertedHexR & commaLine & convertedHexG & commaLine & convertedHexB & convertedHexA & "]")
        Else
            My.Computer.Clipboard.SetText("" & convertedHexR & vbCrLf & convertedHexG & vbCrLf & convertedHexB & vbCrLf & convertedHexA)
        End If
    End Sub

    Private Sub TextBoxHexR_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHexR.TextChanged
        hexValueR = TextBoxHexR.Text
    End Sub

    Private Sub TextBoxHexG_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHexG.TextChanged
        hexValueG = TextBoxHexG.Text
    End Sub

    Private Sub TextBoxHexB_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHexB.TextChanged
        hexValueB = TextBoxHexB.Text
    End Sub

    Private Sub TextBoxHexA_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHexA.TextChanged
        hexValueA = TextBoxHexA.Text
    End Sub

    Private Sub ButtonConvertHex_Click(sender As Object, e As EventArgs) Handles ButtonConvertHex.Click
        HEXCOL2RGB(TextBoxHexString.Text)
        Label1.BackColor = Color.FromArgb(hexValueA, hexValueR, hexValueG, hexValueB)
    End Sub
End Class
