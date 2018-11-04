<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.CbxSelect = New System.Windows.Forms.ComboBox()
        Me.LbxStatics = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtAdd = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CbxSelect
        '
        Me.CbxSelect.FormattingEnabled = True
        Me.CbxSelect.Location = New System.Drawing.Point(107, 75)
        Me.CbxSelect.Name = "CbxSelect"
        Me.CbxSelect.Size = New System.Drawing.Size(121, 20)
        Me.CbxSelect.TabIndex = 1
        '
        'LbxStatics
        '
        Me.LbxStatics.FormattingEnabled = True
        Me.LbxStatics.ItemHeight = 12
        Me.LbxStatics.Location = New System.Drawing.Point(451, 38)
        Me.LbxStatics.Name = "LbxStatics"
        Me.LbxStatics.Size = New System.Drawing.Size(305, 376)
        Me.LbxStatics.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "후보 목록"
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(259, 73)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelect.TabIndex = 3
        Me.BtnSelect.Text = "투표"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(449, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "통계"
        '
        'TxtAdd
        '
        Me.TxtAdd.Location = New System.Drawing.Point(107, 38)
        Me.TxtAdd.Name = "TxtAdd"
        Me.TxtAdd.Size = New System.Drawing.Size(121, 21)
        Me.TxtAdd.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "후보 추가"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(259, 36)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 7
        Me.BtnAdd.Text = "추가"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtAdd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbxSelect)
        Me.Controls.Add(Me.LbxStatics)
        Me.Name = "Form1"
        Me.Text = "설문 프로그램"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CbxSelect As ComboBox
    Friend WithEvents LbxStatics As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSelect As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtAdd As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnAdd As Button
End Class
