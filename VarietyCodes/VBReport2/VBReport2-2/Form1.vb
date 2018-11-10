Public Class Form1
    Dim Random As String = ""
    Dim check(9) As Boolean

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub Randomizer()
        Dim source As String = "0123456789"
        Dim n As Integer = 0

        For i = 0 To 3 Step 1
            n = GetRandom(0, 9 - i)
            Random += source.Chars(n)
            source = source.Remove(n, 1)
        Next i
    End Sub

    Private Function NumChecker(ByVal input As String, ByRef isWin As Boolean) As String
        Dim ball As Integer = 0, strike As Integer = 0
        For i = 0 To 3 Step 1
            If input.IndexOf(Random.Chars(i)) <> -1 Then
                If input.IndexOf(Random.Chars(i)) = i Then
                    strike += 1
                Else
                    ball += 1
                End If
            End If
        Next i

        If strike = 4 Then
            isWin = True
        End If

        Return Str(ball) + "b " + Str(strike) + "s"
    End Function

    Private Sub BtnGo_Click(sender As Object, e As EventArgs) Handles BtnGo.Click
        Static count As Integer = 0
        Dim isWin As Boolean = False
        If TxtNumber.TextLength = 4 Then
            Select Case count
                Case 0
                    Lbl1.Text = TxtNumber.Text
                    LblScore1.Text = NumChecker(TxtNumber.Text, isWin)
                Case 1
                    Lbl2.Text = TxtNumber.Text
                    LblScore2.Text = NumChecker(TxtNumber.Text, isWin)
                Case 2
                    Lbl3.Text = TxtNumber.Text
                    LblScore3.Text = NumChecker(TxtNumber.Text, isWin)
                Case 3
                    lbl4.Text = TxtNumber.Text
                    LblScore4.Text = NumChecker(TxtNumber.Text, isWin)
                Case 4
                    Lbl5.Text = TxtNumber.Text
                    LblScore5.Text = NumChecker(TxtNumber.Text, isWin)
                Case 5
                    Lbl6.Text = TxtNumber.Text
                    LblScore6.Text = NumChecker(TxtNumber.Text, isWin)
                Case 6
                    Lbl7.Text = TxtNumber.Text
                    LblScore7.Text = NumChecker(TxtNumber.Text, isWin)
                Case 7
                    Lbl8.Text = TxtNumber.Text
                    LblScore8.Text = NumChecker(TxtNumber.Text, isWin)
                Case 8
                    Lbl9.Text = TxtNumber.Text
                    LblScore9.Text = NumChecker(TxtNumber.Text, isWin)
                Case 9
                    Lbl10.Text = TxtNumber.Text
                    LblScore10.Text = NumChecker(TxtNumber.Text, isWin)
            End Select
            count += 1
        End If

        If isWin Then
            MsgBox("이겼습니다!", MsgBoxStyle.OkOnly, "축하합니다!")
            End
        End If

        If count = 10 Then
            MsgBox("졌습니다.", MsgBoxStyle.OkOnly, "안타깝습니다.")
            End
        End If

        For i = 0 To 9
            check(i) = False
        Next

        TxtNumber.Clear()
        TxtNumber.Select()
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        MsgBox("먼저 네 자리의 숫자가 주어지고, 이 숫자를 10번 안에 맞추면 이기는 게임입니다." + vbCrLf + "입력한 숫자가 주어진 숫자와 일치하지만 자리가 다르면 b(ball), 자리와 숫자가모두 같으면 s(strike) 입니다. 즉 4 strike를 받으면 이긴다고 할 수 있습니다.", 0, "도움말")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomizer()
        TxtNumber.Select()
    End Sub
End Class
