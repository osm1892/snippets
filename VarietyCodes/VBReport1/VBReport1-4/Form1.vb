Public Class frmForm
    Dim num1 As Double = 0
    Dim num2 As Double = 0
    Dim oprNum As Integer = 0

    Private Sub TxtInsert(character As String)
        Dim location As Integer = txtCalc.SelectionStart
        txtCalc.Text = txtCalc.Text.Insert(location, character)
        txtCalc.SelectionStart = location
    End Sub

    Private Sub Calculation()
        Try
            Select Case oprNum
                Case 1
                    num1 += num2
                Case 2
                    num1 -= num2
                Case 3
                    num1 *= num2
                Case 4
                    num1 /= num2
                Case 5
                    num1 = Math.Pow(num1, 2)
                Case 6
                    num1 = Math.Pow(num1, 3)
                Case 7
                    num1 = Math.Sqrt(num1)
                Case Else
                    Return
            End Select
        Catch e As Exception
            txtCalc.Text = "에러가 발생하였습니다. AC버튼 또는 esc키를 눌러주십시오."
        End Try
    End Sub

    Private Sub BtnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        txtCalc.Text = ""
        num1 = 0
        num2 = 0
    End Sub

    Private Sub TxtCalc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCalc.KeyPress
        If (e.KeyChar < "0" Or "9" < e.KeyChar Or e.KeyChar = ".") And e.KeyChar <> Chr(8) Then
            If e.KeyChar = "+" Then
                e.KeyChar = ""
                If oprNum = 0 Then
                    Double.TryParse(txtCalc.Text, num1)
                    oprNum = 1
                    txtCalc.Text = ""
                    Return
                End If
                Double.TryParse(txtCalc.Text, num2)
                oprNum = 1
                Calculation()
                txtCalc.Text = ""
            ElseIf e.KeyChar = "-" Then
                e.KeyChar = ""
                If oprNum = 0 Then
                    Double.TryParse(txtCalc.Text, num1)
                    oprNum = 2
                    txtCalc.Text = ""
                    Return
                End If
                Double.TryParse(txtCalc.Text, num2)
                oprNum = 2
                Calculation()
                txtCalc.Text = ""
            ElseIf e.KeyChar = "*" Then
                e.KeyChar = ""
                If oprNum = 0 Then
                    Double.TryParse(txtCalc.Text, num1)
                    oprNum = 3
                    txtCalc.Text = ""
                    Return
                End If
                Double.TryParse(txtCalc.Text, num2)
                oprNum = 3
                Calculation()
                txtCalc.Text = ""
            ElseIf e.KeyChar = "/" Then
                e.KeyChar = ""
                If oprNum = 0 Then
                    Double.TryParse(txtCalc.Text, num1)
                    oprNum = 4
                    txtCalc.Text = ""
                    Return
                End If
                Double.TryParse(txtCalc.Text, num2)
                oprNum = 4
                Calculation()
                txtCalc.Text = ""
            ElseIf e.KeyChar = "=" Then
                e.KeyChar = ""
                Calculation()
                txtCalc.Text = num1
            ElseIf e.KeyChar = Chr(27) Then
                e.KeyChar = ""
                txtCalc.Text = ""
                num1 = 0
                num2 = 0
                oprNum = 0
            End If
        End If
    End Sub

    Private Sub BtnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        TxtInsert(1)
    End Sub

    Private Sub BtnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        TxtInsert(2)
    End Sub

    Private Sub BtnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        TxtInsert(3)
    End Sub

    Private Sub BtnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        TxtInsert(4)
    End Sub

    Private Sub BtnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        TxtInsert(5)
    End Sub

    Private Sub BtnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        TxtInsert(6)
    End Sub

    Private Sub BtnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        TxtInsert(7)
    End Sub

    Private Sub BtnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        TxtInsert(8)
    End Sub

    Private Sub BtnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        TxtInsert(9)
    End Sub

    Private Sub BtnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        TxtInsert(".")
    End Sub

    Private Sub BtnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        TxtInsert(0)
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Double.TryParse(txtCalc.Text, num2)
        Calculation()
        txtCalc.Text = num1
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If oprNum = 0 Then
            Double.TryParse(txtCalc.Text, num1)
            oprNum = 1
            txtCalc.Text = ""
            Return
        End If
        Double.TryParse(txtCalc.Text, num2)
        oprNum = 1
        Calculation()
        txtCalc.Text = ""
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        If oprNum = 0 Then
            Double.TryParse(txtCalc.Text, num1)
            oprNum = 2
            txtCalc.Text = ""
            Return
        End If
        Double.TryParse(txtCalc.Text, num2)
        oprNum = 2
        Calculation()
        txtCalc.Text = ""
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If oprNum = 0 Then
            Double.TryParse(txtCalc.Text, num1)
            oprNum = 3
            txtCalc.Text = ""
            Return
        End If
        Double.TryParse(txtCalc.Text, num2)
        oprNum = 3
        Calculation()
        txtCalc.Text = ""
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        If oprNum = 0 Then
            Double.TryParse(txtCalc.Text, num1)
            oprNum = 4
            txtCalc.Text = ""
            Return
        End If
        Double.TryParse(txtCalc.Text, num2)
        oprNum = 4
        Calculation()
        txtCalc.Text = ""
    End Sub

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        Double.TryParse(txtCalc.Text, num1)
        oprNum = 5
        Calculation()
        txtCalc.Text = num1
    End Sub

    Private Sub frmForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCalc.Focus()
    End Sub

    Private Sub btnCube_Click(sender As Object, e As EventArgs) Handles btnCube.Click
        Double.TryParse(txtCalc.Text, num1)
        oprNum = 6
        Calculation()
        txtCalc.Text = num1
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        Double.TryParse(txtCalc.Text, num1)
        oprNum = 7
        Calculation()
        txtCalc.Text = num1
    End Sub
End Class
