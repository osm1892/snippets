Public Class frmForm
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        If rdbSuperLarge.Checked = True Then
            lblResult.Text = "보쌈주문: 특대 사이즈"
        ElseIf rdbLarge.Checked = True Then
            lblResult.Text = "보쌈주문: 대 사이즈"
        ElseIf rdbMedium.Checked = True Then
            lblResult.Text = "보쌈주문: 중 사이즈"
        ElseIf rdbSmall.Checked = True Then
            lblResult.Text = "보쌈주문: 소 사이즈"
        Else
            lblResult.Text = "보쌈주문: 없음"
        End If

        lblResult.Text &= vbCrLf & "추가주문: "

        If chkRice.Checked = True Then
            lblResult.Text &= "공기밥 "
        End If
        If chkNoodle.Checked = True Then
            lblResult.Text &= "막국수 "
        End If
        If chkDrink.Checked = True Then
            lblResult.Text &= "음료수"
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
