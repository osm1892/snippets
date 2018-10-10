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
        Me.gpbSize = New System.Windows.Forms.GroupBox()
        Me.rdbLarge = New System.Windows.Forms.RadioButton()
        Me.rdbSmall = New System.Windows.Forms.RadioButton()
        Me.rdbMedium = New System.Windows.Forms.RadioButton()
        Me.gpbAdd = New System.Windows.Forms.GroupBox()
        Me.chkRice = New System.Windows.Forms.CheckBox()
        Me.chkNoodle = New System.Windows.Forms.CheckBox()
        Me.chkDrink = New System.Windows.Forms.CheckBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.rdbSuperLarge = New System.Windows.Forms.RadioButton()
        Me.gpbSize.SuspendLayout()
        Me.gpbAdd.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbSize
        '
        Me.gpbSize.Controls.Add(Me.rdbSuperLarge)
        Me.gpbSize.Controls.Add(Me.rdbLarge)
        Me.gpbSize.Controls.Add(Me.rdbSmall)
        Me.gpbSize.Controls.Add(Me.rdbMedium)
        Me.gpbSize.Location = New System.Drawing.Point(34, 26)
        Me.gpbSize.Name = "gpbSize"
        Me.gpbSize.Size = New System.Drawing.Size(200, 100)
        Me.gpbSize.TabIndex = 0
        Me.gpbSize.TabStop = False
        Me.gpbSize.Text = "크기"
        '
        'rdbLarge
        '
        Me.rdbLarge.AutoSize = True
        Me.rdbLarge.Location = New System.Drawing.Point(6, 34)
        Me.rdbLarge.Name = "rdbLarge"
        Me.rdbLarge.Size = New System.Drawing.Size(57, 16)
        Me.rdbLarge.TabIndex = 0
        Me.rdbLarge.TabStop = True
        Me.rdbLarge.Text = "대(大)"
        Me.rdbLarge.UseVisualStyleBackColor = True
        '
        'rdbSmall
        '
        Me.rdbSmall.AutoSize = True
        Me.rdbSmall.Location = New System.Drawing.Point(6, 78)
        Me.rdbSmall.Name = "rdbSmall"
        Me.rdbSmall.Size = New System.Drawing.Size(57, 16)
        Me.rdbSmall.TabIndex = 2
        Me.rdbSmall.TabStop = True
        Me.rdbSmall.Text = "소(小)"
        Me.rdbSmall.UseVisualStyleBackColor = True
        '
        'rdbMedium
        '
        Me.rdbMedium.AutoSize = True
        Me.rdbMedium.Location = New System.Drawing.Point(6, 56)
        Me.rdbMedium.Name = "rdbMedium"
        Me.rdbMedium.Size = New System.Drawing.Size(57, 16)
        Me.rdbMedium.TabIndex = 1
        Me.rdbMedium.TabStop = True
        Me.rdbMedium.Text = "중(中)"
        Me.rdbMedium.UseVisualStyleBackColor = True
        '
        'gpbAdd
        '
        Me.gpbAdd.Controls.Add(Me.chkRice)
        Me.gpbAdd.Controls.Add(Me.chkNoodle)
        Me.gpbAdd.Controls.Add(Me.chkDrink)
        Me.gpbAdd.Location = New System.Drawing.Point(528, 26)
        Me.gpbAdd.Name = "gpbAdd"
        Me.gpbAdd.Size = New System.Drawing.Size(200, 100)
        Me.gpbAdd.TabIndex = 0
        Me.gpbAdd.TabStop = False
        Me.gpbAdd.Text = "추가메뉴"
        '
        'chkRice
        '
        Me.chkRice.AutoSize = True
        Me.chkRice.Location = New System.Drawing.Point(6, 20)
        Me.chkRice.Name = "chkRice"
        Me.chkRice.Size = New System.Drawing.Size(60, 16)
        Me.chkRice.TabIndex = 3
        Me.chkRice.Text = "공기밥"
        Me.chkRice.UseVisualStyleBackColor = True
        '
        'chkNoodle
        '
        Me.chkNoodle.AutoSize = True
        Me.chkNoodle.Location = New System.Drawing.Point(6, 42)
        Me.chkNoodle.Name = "chkNoodle"
        Me.chkNoodle.Size = New System.Drawing.Size(60, 16)
        Me.chkNoodle.TabIndex = 4
        Me.chkNoodle.Text = "막국수"
        Me.chkNoodle.UseVisualStyleBackColor = True
        '
        'chkDrink
        '
        Me.chkDrink.AutoSize = True
        Me.chkDrink.Location = New System.Drawing.Point(6, 64)
        Me.chkDrink.Name = "chkDrink"
        Me.chkDrink.Size = New System.Drawing.Size(60, 16)
        Me.chkDrink.TabIndex = 5
        Me.chkDrink.Text = "음료수"
        Me.chkDrink.UseVisualStyleBackColor = True
        '
        'btnRun
        '
        Me.btnRun.Location = New System.Drawing.Point(138, 185)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(96, 38)
        Me.btnRun.TabIndex = 6
        Me.btnRun.Text = "주문하기"
        Me.btnRun.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(528, 185)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 38)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "종료"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResult.Location = New System.Drawing.Point(236, 308)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(285, 56)
        Me.lblResult.TabIndex = 8
        '
        'rdbSuperLarge
        '
        Me.rdbSuperLarge.AutoSize = True
        Me.rdbSuperLarge.Location = New System.Drawing.Point(6, 12)
        Me.rdbSuperLarge.Name = "rdbSuperLarge"
        Me.rdbSuperLarge.Size = New System.Drawing.Size(81, 16)
        Me.rdbSuperLarge.TabIndex = 3
        Me.rdbSuperLarge.TabStop = True
        Me.rdbSuperLarge.Text = "특대(特大)"
        Me.rdbSuperLarge.UseVisualStyleBackColor = True
        '
        'frmForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.gpbAdd)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.gpbSize)
        Me.Name = "frmForm"
        Me.Text = "보쌈 주문 프로그램"
        Me.gpbSize.ResumeLayout(False)
        Me.gpbSize.PerformLayout()
        Me.gpbAdd.ResumeLayout(False)
        Me.gpbAdd.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gpbSize As GroupBox
    Friend WithEvents rdbLarge As RadioButton
    Friend WithEvents rdbSmall As RadioButton
    Friend WithEvents rdbMedium As RadioButton
    Friend WithEvents gpbAdd As GroupBox
    Friend WithEvents chkRice As CheckBox
    Friend WithEvents chkNoodle As CheckBox
    Friend WithEvents chkDrink As CheckBox
    Friend WithEvents btnRun As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents rdbSuperLarge As RadioButton
End Class
