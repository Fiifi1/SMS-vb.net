<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.linkSignUp = New System.Windows.Forms.LinkLabel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSignIn = New System.Windows.Forms.Button()
        Me.tbxPassword2 = New System.Windows.Forms.TextBox()
        Me.ckbxShow2 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        Me.tbxUsername = New System.Windows.Forms.TextBox()
        Me.ckbxShow = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'linkSignUp
        '
        Me.linkSignUp.AutoSize = True
        Me.linkSignUp.Font = New System.Drawing.Font("Verdana", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkSignUp.Location = New System.Drawing.Point(204, 336)
        Me.linkSignUp.Name = "linkSignUp"
        Me.linkSignUp.Size = New System.Drawing.Size(152, 17)
        Me.linkSignUp.TabIndex = 26
        Me.linkSignUp.TabStop = True
        Me.linkSignUp.Text = "Existing User? Login"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(318, 247)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(113, 35)
        Me.btnClose.TabIndex = 25
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSignIn
        '
        Me.btnSignIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSignIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSignIn.Location = New System.Drawing.Point(135, 247)
        Me.btnSignIn.Name = "btnSignIn"
        Me.btnSignIn.Size = New System.Drawing.Size(106, 35)
        Me.btnSignIn.TabIndex = 24
        Me.btnSignIn.Text = "Register"
        Me.btnSignIn.UseVisualStyleBackColor = False
        '
        'tbxPassword2
        '
        Me.tbxPassword2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPassword2.Location = New System.Drawing.Point(241, 150)
        Me.tbxPassword2.Name = "tbxPassword2"
        Me.tbxPassword2.Size = New System.Drawing.Size(128, 27)
        Me.tbxPassword2.TabIndex = 23
        Me.tbxPassword2.UseSystemPasswordChar = True
        '
        'ckbxShow2
        '
        Me.ckbxShow2.AutoSize = True
        Me.ckbxShow2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbxShow2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ckbxShow2.Location = New System.Drawing.Point(375, 152)
        Me.ckbxShow2.Name = "ckbxShow2"
        Me.ckbxShow2.Size = New System.Drawing.Size(72, 24)
        Me.ckbxShow2.TabIndex = 22
        Me.ckbxShow2.Text = "Show"
        Me.ckbxShow2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(38, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 24)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Re-enter Password :"
        '
        'tbxPassword
        '
        Me.tbxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxPassword.Location = New System.Drawing.Point(241, 105)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.Size = New System.Drawing.Size(128, 27)
        Me.tbxPassword.TabIndex = 20
        Me.tbxPassword.UseSystemPasswordChar = True
        '
        'tbxUsername
        '
        Me.tbxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxUsername.Location = New System.Drawing.Point(241, 44)
        Me.tbxUsername.Name = "tbxUsername"
        Me.tbxUsername.Size = New System.Drawing.Size(192, 27)
        Me.tbxUsername.TabIndex = 19
        '
        'ckbxShow
        '
        Me.ckbxShow.AutoSize = True
        Me.ckbxShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckbxShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ckbxShow.Location = New System.Drawing.Point(375, 107)
        Me.ckbxShow.Name = "ckbxShow"
        Me.ckbxShow.Size = New System.Drawing.Size(72, 24)
        Me.ckbxShow.TabIndex = 18
        Me.ckbxShow.Text = "Show"
        Me.ckbxShow.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(116, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 24)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(116, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Username : "
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(512, 391)
        Me.Controls.Add(Me.linkSignUp)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSignIn)
        Me.Controls.Add(Me.tbxPassword2)
        Me.Controls.Add(Me.ckbxShow2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.tbxUsername)
        Me.Controls.Add(Me.ckbxShow)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents linkSignUp As LinkLabel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSignIn As Button
    Friend WithEvents tbxPassword2 As TextBox
    Friend WithEvents ckbxShow2 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents tbxUsername As TextBox
    Friend WithEvents ckbxShow As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
