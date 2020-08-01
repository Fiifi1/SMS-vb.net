<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.loginPictureBox = New System.Windows.Forms.PictureBox()
        Me.usrnameLbl = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.unameTxtBox = New System.Windows.Forms.TextBox()
        Me.loginPwdTxtbox = New System.Windows.Forms.TextBox()
        Me.showPassword = New System.Windows.Forms.CheckBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.loginCancelBtn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.loginPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loginPictureBox
        '
        Me.loginPictureBox.Image = Global.sms.My.Resources.Resources.profile
        Me.loginPictureBox.Location = New System.Drawing.Point(153, 13)
        Me.loginPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.loginPictureBox.Name = "loginPictureBox"
        Me.loginPictureBox.Size = New System.Drawing.Size(308, 281)
        Me.loginPictureBox.TabIndex = 0
        Me.loginPictureBox.TabStop = False
        '
        'usrnameLbl
        '
        Me.usrnameLbl.AutoSize = True
        Me.usrnameLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usrnameLbl.Location = New System.Drawing.Point(76, 316)
        Me.usrnameLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.usrnameLbl.Name = "usrnameLbl"
        Me.usrnameLbl.Size = New System.Drawing.Size(107, 24)
        Me.usrnameLbl.TabIndex = 1
        Me.usrnameLbl.Text = "Username :"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(76, 365)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(102, 24)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "Password :"
        '
        'unameTxtBox
        '
        Me.unameTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unameTxtBox.Location = New System.Drawing.Point(191, 314)
        Me.unameTxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.unameTxtBox.Name = "unameTxtBox"
        Me.unameTxtBox.Size = New System.Drawing.Size(328, 26)
        Me.unameTxtBox.TabIndex = 3
        Me.unameTxtBox.Text = "Admin"
        '
        'loginPwdTxtbox
        '
        Me.loginPwdTxtbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginPwdTxtbox.Location = New System.Drawing.Point(191, 365)
        Me.loginPwdTxtbox.Margin = New System.Windows.Forms.Padding(4)
        Me.loginPwdTxtbox.Name = "loginPwdTxtbox"
        Me.loginPwdTxtbox.Size = New System.Drawing.Size(240, 26)
        Me.loginPwdTxtbox.TabIndex = 4
        Me.loginPwdTxtbox.Text = "11111"
        Me.loginPwdTxtbox.UseSystemPasswordChar = True
        '
        'showPassword
        '
        Me.showPassword.AutoSize = True
        Me.showPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showPassword.Location = New System.Drawing.Point(447, 367)
        Me.showPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.showPassword.Name = "showPassword"
        Me.showPassword.Size = New System.Drawing.Size(72, 24)
        Me.showPassword.TabIndex = 5
        Me.showPassword.Text = "Show"
        Me.showPassword.UseVisualStyleBackColor = True
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.loginBtn.Location = New System.Drawing.Point(80, 428)
        Me.loginBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(157, 43)
        Me.loginBtn.TabIndex = 6
        Me.loginBtn.Text = "Login"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'loginCancelBtn
        '
        Me.loginCancelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.loginCancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginCancelBtn.Location = New System.Drawing.Point(364, 428)
        Me.loginCancelBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.loginCancelBtn.Name = "loginCancelBtn"
        Me.loginCancelBtn.Size = New System.Drawing.Size(155, 43)
        Me.loginCancelBtn.TabIndex = 7
        Me.loginCancelBtn.Text = "Cancel"
        Me.loginCancelBtn.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(245, 496)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(185, 17)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "No account Yet? Sign Up"
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(614, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.loginCancelBtn)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.showPassword)
        Me.Controls.Add(Me.loginPwdTxtbox)
        Me.Controls.Add(Me.unameTxtBox)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.usrnameLbl)
        Me.Controls.Add(Me.loginPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login - SMS"
        CType(Me.loginPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loginPictureBox As PictureBox
    Friend WithEvents usrnameLbl As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents unameTxtBox As TextBox
    Friend WithEvents loginPwdTxtbox As TextBox
    Friend WithEvents showPassword As CheckBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents loginCancelBtn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
