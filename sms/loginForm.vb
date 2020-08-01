Imports MySql.Data.MySqlClient

Public Class loginForm

    Private Sub loginCancelBtn_Click(sender As Object, e As EventArgs) Handles loginCancelBtn.Click
        Me.Close()
    End Sub

    Private Sub showPassword_CheckedChanged(sender As Object, e As EventArgs) Handles showPassword.CheckedChanged
        If loginPwdTxtbox.UseSystemPasswordChar Then
            loginPwdTxtbox.UseSystemPasswordChar = False
        Else
            loginPwdTxtbox.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click

        Dim smsDB As New sms_db()
        Dim adapt As New MySqlDataAdapter()
        Dim dtable As New DataTable()
        Dim comm As New MySqlCommand("SELECT * FROM `user` WHERE `username` = @usr AND `password` = @pwd", smsDB.makeConnection)

        comm.Parameters.Add("@usr", MySqlDbType.VarChar).Value = unameTxtBox.Text
        comm.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = loginPwdTxtbox.Text

        adapt.SelectCommand = comm
        adapt.Fill(dtable)

        'Validate form from database
        If dtable.Rows.Count > 0 Then
            Dim dboard As New dasboard()
            dboard.Show()
            Me.Close()
        Else
            MsgBox("Incorrect Credentials!", MsgBoxStyle.Critical, "Login Error")
        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim signUpForm As New SignUp()
        signUpForm.Show()
        Me.Close()
    End Sub
End Class