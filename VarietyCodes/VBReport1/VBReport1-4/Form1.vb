Public Class frmForm
    Dim num1 As Double = 0 '누적 연산에서 Left 부분을 담당합니다.
    Dim num2 As Double = 0 '누적 연산에서 Right 부분을 담당합니다.
    Dim result As Double = 0 '연산 결과를 저장하는 부분입니다.
    Dim oprNum As Integer = 0 '계산 실행시, 연산자를 결정하는 변수입니다.

    '사칙연산을 실행하는 함수입니다.
    Private Sub Calculation()
        Select Case oprNum
            Case 1
                result = num1 + num2
            Case 2
                result = num1 - num2
            Case 3
                result = num1 * num2
            Case 4
                result = num1 / num2
            Case Else
                Return
        End Select
    End Sub

    'AC버튼을 눌렀을 시, 초기화를 하는 함수입니다.
    Private Sub BtnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        txtCalc.Text = ""
        num1 = 0
        num2 = 0
        oprNum = 0
        result = 0
    End Sub

    '눌린 키가 숫자, 점, 백스페이스가 아닌 경우, 연산자인지를 판단하고, 그에 따른 함수를 호출합니다.
    Private Sub TxtCalc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCalc.KeyPress
        If (e.KeyChar < "0" Or "9" < e.KeyChar) And e.KeyChar <> Chr(8) And e.keychar <> "." Then
            Select Case e.KeyChar
                Case "+"
                    e.KeyChar = ""
                    If oprNum = 0 Then
                        Double.TryParse(txtCalc.Text, num1)
                        oprNum = 1
                        txtCalc.Text = ""
                        Return
                    End If
                    Double.TryParse(txtCalc.Text, num2)
                    Calculation()
                    num1 = result
                    oprNum = 1
                    txtCalc.Text = ""
                Case "-"
                    e.KeyChar = ""
                    If oprNum = 0 Then
                        Double.TryParse(txtCalc.Text, num1)
                        oprNum = 2
                        txtCalc.Text = ""
                        Return
                    End If
                    Double.TryParse(txtCalc.Text, num2)
                    Calculation()
                    num1 = result
                    oprNum = 2
                    txtCalc.Text = ""
                Case "*"
                    e.KeyChar = ""
                    If oprNum = 0 Then
                        Double.TryParse(txtCalc.Text, num1)
                        oprNum = 3
                        txtCalc.Text = ""
                        Return
                    End If
                    Double.TryParse(txtCalc.Text, num2)
                    Calculation()
                    num1 = result
                    oprNum = 3
                    txtCalc.Text = ""
                Case "/"
                    e.KeyChar = ""
                    If oprNum = 0 Then
                        Double.TryParse(txtCalc.Text, num1)
                        oprNum = 4
                        txtCalc.Text = ""
                        Return
                    End If
                    Double.TryParse(txtCalc.Text, num2)
                    Calculation()
                    num1 = result
                    oprNum = 4
                    txtCalc.Text = ""
                Case "="
                    e.KeyChar = ""
                    Double.TryParse(txtCalc.Text, num2)
                    Calculation()
                    txtCalc.Text = result
                    num1 = result
                Case Chr(27)
                    e.KeyChar = ""
                    txtCalc.Text = ""
                    num1 = 0
                    num2 = 0
                    oprNum = 0
                    result = 0
                Case Else
                    e.KeyChar = ""
            End Select
        End If
    End Sub

    Private Sub BtnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        txtCalc.Text &= 1
    End Sub

    Private Sub BtnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        txtCalc.Text &= 2
    End Sub

    Private Sub BtnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        txtCalc.Text &= 3
    End Sub

    Private Sub BtnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        txtCalc.Text &= 4
    End Sub

    Private Sub BtnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        txtCalc.Text &= 5
    End Sub

    Private Sub BtnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        txtCalc.Text &= 6
    End Sub

    Private Sub BtnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        txtCalc.Text &= 7
    End Sub

    Private Sub BtnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        txtCalc.Text &= 8
    End Sub

    Private Sub BtnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        txtCalc.Text &= 9
    End Sub

    Private Sub BtnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        txtCalc.Text &= "."
    End Sub

    Private Sub BtnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        txtCalc.Text &= 0
    End Sub

    Private Sub BtnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        Double.TryParse(txtCalc.Text, num2)
        Calculation()
        txtCalc.Text = result
        num1 = result
    End Sub

    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        If oprNum = 0 Then
            Double.TryParse(txtCalc.Text, num1)
            oprNum = 1
            txtCalc.Text = ""
            Return
        End If
        Double.TryParse(txtCalc.Text, num2)
        Calculation()
        num1 = result
        oprNum = 1
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
        Calculation()
        num1 = result
        oprNum = 2
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
        Calculation()
        num1 = result
        oprNum = 3
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
        Calculation()
        num1 = result
        oprNum = 4
        txtCalc.Text = ""
    End Sub

    Private Sub btnSquare_Click(sender As Object, e As EventArgs) Handles btnSquare.Click
        Double.TryParse(txtCalc.Text, num1)
        num1 = Math.Pow(num1, 2)
        txtCalc.Text = num1
    End Sub

    Private Sub frmForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCalc.Focus()
    End Sub

    Private Sub btnCube_Click(sender As Object, e As EventArgs) Handles btnCube.Click
        Double.TryParse(txtCalc.Text, num1)
        num1 = Math.Pow(num1, 3)
        txtCalc.Text = num1
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        Double.TryParse(txtCalc.Text, num1)
        num1 = Math.Sqrt(num1)
        txtCalc.Text = num1
    End Sub
End Class
