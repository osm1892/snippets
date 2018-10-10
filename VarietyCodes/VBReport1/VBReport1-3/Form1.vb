Public Class frmForm
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        lblTotal.Text = Val(lblTotal.Text) + 1
        If rdbFirst.Checked = True Then
            lblFirst.Text = Val(lblFirst.Text) + 1
        ElseIf rdbSecond.Checked = True Then
            lblSecond.Text = Val(lblSecond.Text) + 1
        ElseIf rdbThird.Checked = True Then
            lblThird.Text = Val(lblThird.Text) + 1
        End If
    End Sub

    Private Sub frmForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTotal.Text = 0
        lblFirst.Text = 0
        lblSecond.Text = 0
        lblThird.Text = 0
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
