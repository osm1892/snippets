Public Class Form1
    Dim candidateCounts(100) As Double
    Dim count As Integer = 0, total As Integer = 0

    Private Sub UpdateLbx(name As String, index As Integer)
        total += 1
        candidateCounts(index + 2) += 1
        LbxStatics.Items.Item(1) = "전체" + vbTab + vbTab + Str(total)
        LbxStatics.Items.Item(index + 2) = name + vbTab + vbTab + Str(candidateCounts(index + 2))
    End Sub

    Private Sub AddCandidate(name As String)
        CbxSelect.Items.Add(name)
        LbxStatics.Items.Add(name + vbTab + vbTab + "0")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LbxStatics.Items.Add("후보" + vbTab + vbTab + "득표수")
        LbxStatics.Items.Add("전체" + vbTab + vbTab + "0" + vbTab + vbTab + "100")
    End Sub

    Private Sub BtnSelect_Click(sender As Object, e As EventArgs) Handles BtnSelect.Click
        Dim buffer As Integer = CbxSelect.SelectedIndex
        If buffer <> -1 Then
            UpdateLbx(CbxSelect.SelectedItem.ToString, buffer)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        AddCandidate(TxtAdd.Text)
        TxtAdd.Text = ""
    End Sub
End Class
