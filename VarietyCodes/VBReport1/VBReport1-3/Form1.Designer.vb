<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.rdbThird = New System.Windows.Forms.RadioButton()
        Me.rdbSecond = New System.Windows.Forms.RadioButton()
        Me.rdbFirst = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblThird = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSecond = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnRun)
        Me.GroupBox1.Controls.Add(Me.rdbThird)
        Me.GroupBox1.Controls.Add(Me.rdbSecond)
        Me.GroupBox1.Controls.Add(Me.rdbFirst)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 163)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "학생회장 투표하기"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(469, 97)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(469, 40)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 3
        Me.btnRun.Text = "투표하기"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'rdbThird
        '
        Me.rdbThird.AutoSize = True
        Me.rdbThird.Location = New System.Drawing.Point(36, 97)
        Me.rdbThird.Name = "rdbThird"
        Me.rdbThird.Size = New System.Drawing.Size(103, 16)
        Me.rdbThird.TabIndex = 2
        Me.rdbThird.TabStop = True
        Me.rdbThird.Text = "후보3 - 정몽준"
        Me.rdbThird.UseVisualStyleBackColor = True
        '
        'rdbSecond
        '
        Me.rdbSecond.AutoSize = True
        Me.rdbSecond.Location = New System.Drawing.Point(36, 75)
        Me.rdbSecond.Name = "rdbSecond"
        Me.rdbSecond.Size = New System.Drawing.Size(103, 16)
        Me.rdbSecond.TabIndex = 1
        Me.rdbSecond.TabStop = True
        Me.rdbSecond.Text = "후보2 - 노무현"
        Me.rdbSecond.UseVisualStyleBackColor = True
        '
        'rdbFirst
        '
        Me.rdbFirst.AutoSize = True
        Me.rdbFirst.Location = New System.Drawing.Point(36, 53)
        Me.rdbFirst.Name = "rdbFirst"
        Me.rdbFirst.Size = New System.Drawing.Size(103, 16)
        Me.rdbFirst.TabIndex = 0
        Me.rdbFirst.TabStop = True
        Me.rdbFirst.Text = "후보1 - 이회창"
        Me.rdbFirst.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblThird)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblSecond)
        Me.GroupBox2.Controls.Add(Me.lblFirst)
        Me.GroupBox2.Controls.Add(Me.lblTotal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(61, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 193)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "결과 현황판"
        '
        'lblThird
        '
        Me.lblThird.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblThird.Location = New System.Drawing.Point(485, 82)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(59, 30)
        Me.lblThird.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(485, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 12)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "후보3득표"
        '
        'lblSecond
        '
        Me.lblSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSecond.Location = New System.Drawing.Point(335, 82)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(59, 30)
        Me.lblSecond.TabIndex = 5
        '
        'lblFirst
        '
        Me.lblFirst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFirst.Location = New System.Drawing.Point(176, 82)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(59, 30)
        Me.lblFirst.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Location = New System.Drawing.Point(34, 82)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(57, 30)
        Me.lblTotal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(335, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "후보2득표"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "후보1득표"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "투표 현황"
        '
        'frmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmForm"
        Me.Text = "학생회장 선거 프로그램"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbSecond As RadioButton
    Friend WithEvents rdbFirst As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rdbThird As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRun As Button
    Friend WithEvents lblThird As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblFirst As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
