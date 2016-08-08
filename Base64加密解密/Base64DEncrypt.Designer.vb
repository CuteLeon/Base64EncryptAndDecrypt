<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Base64DEncrypt
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PlainText = New System.Windows.Forms.TextBox()
        Me.CipherText = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(305, 66)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Encrypt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PlainText
        '
        Me.PlainText.Location = New System.Drawing.Point(12, 12)
        Me.PlainText.Name = "PlainText"
        Me.PlainText.Size = New System.Drawing.Size(449, 21)
        Me.PlainText.TabIndex = 0
        '
        'CipherText
        '
        Me.CipherText.Location = New System.Drawing.Point(12, 39)
        Me.CipherText.Name = "CipherText"
        Me.CipherText.Size = New System.Drawing.Size(449, 21)
        Me.CipherText.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(386, 66)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Decrypt"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Base64DEncrypt
        '
        Me.AcceptButton = Me.Button1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button2
        Me.ClientSize = New System.Drawing.Size(473, 96)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.CipherText)
        Me.Controls.Add(Me.PlainText)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Base64DEncrypt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Base64 Encrypt & Decrypt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PlainText As TextBox
    Friend WithEvents CipherText As TextBox
    Friend WithEvents Button2 As Button
End Class
