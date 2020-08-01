Imports System.IO
Imports MySql.Data.MySqlClient

Public Class addUser

    Dim smsDB As New sms_db()

    Public Function addUser(ByVal uname As String, ByVal pwd As String) As Boolean
        Dim comm As New MySqlCommand("INSERT INTO `user`(`username`, `password`) VALUES (@uname,@pwd)", smsDB.makeConnection)

        comm.Parameters.Add("@uname", MySqlDbType.VarChar).Value = uname

        comm.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = pwd

        smsDB.startConnection()

        If comm.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        smsDB.endConnection()

    End Function

End Class
