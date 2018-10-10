Public Class frmForm
    Private Sub hsbTemp_Scroll(sender As Object, e As ScrollEventArgs) Handles hsbTemp.Scroll
        lblCelsius.Text = hsbTemp.Value
        lblFahrenheit.Text = hsbTemp.Value * 9 / 4 + 32
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
