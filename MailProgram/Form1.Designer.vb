<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.cbSSL = New System.Windows.Forms.CheckBox()
        Me.txtPwd = New System.Windows.Forms.TextBox()
        Me.gvMail = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.gvMail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(12, 12)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(100, 20)
        Me.txtServer.TabIndex = 0
        Me.txtServer.Text = "pop3.live.com"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(12, 38)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(100, 20)
        Me.txtPort.TabIndex = 1
        Me.txtPort.Text = "995"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(12, 64)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(100, 20)
        Me.txtUser.TabIndex = 2
        '
        'cbSSL
        '
        Me.cbSSL.AutoSize = True
        Me.cbSSL.Checked = True
        Me.cbSSL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSSL.Location = New System.Drawing.Point(118, 12)
        Me.cbSSL.Name = "cbSSL"
        Me.cbSSL.Size = New System.Drawing.Size(46, 17)
        Me.cbSSL.TabIndex = 3
        Me.cbSSL.Text = "SSL"
        Me.cbSSL.UseVisualStyleBackColor = True
        '
        'txtPwd
        '
        Me.txtPwd.Location = New System.Drawing.Point(12, 90)
        Me.txtPwd.Name = "txtPwd"
        Me.txtPwd.Size = New System.Drawing.Size(100, 20)
        Me.txtPwd.TabIndex = 4
        '
        'gvMail
        '
        Me.gvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvMail.Location = New System.Drawing.Point(211, 38)
        Me.gvMail.Name = "gvMail"
        Me.gvMail.Size = New System.Drawing.Size(639, 218)
        Me.gvMail.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(208, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Giriş"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Yeni Mail"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gvMail)
        Me.Controls.Add(Me.txtPwd)
        Me.Controls.Add(Me.cbSSL)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtServer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.gvMail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents cbSSL As CheckBox
    Friend WithEvents txtPwd As TextBox
    Friend WithEvents gvMail As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
