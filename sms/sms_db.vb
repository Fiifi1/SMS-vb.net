Imports MySql.Data.MySqlClient

Public Class sms_db

    'show sql data source
    Private conn As New MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=sms_db")

    'setup new sql connection
    ReadOnly Property makeConnection() As MySqlConnection
        Get
            Return conn
        End Get
    End Property

    'open connection if closed
    Sub startConnection()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Sub endConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

    End Sub
End Class
