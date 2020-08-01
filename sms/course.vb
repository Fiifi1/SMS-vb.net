Imports MySql.Data.MySqlClient

Public Class course
    'Declare main database
    Dim sms_db As New sms_db()

    Public Function createNewCourse(ByVal courseCode As String, ByVal courseTitle As String, ByVal creditHours As Integer) As Boolean

        Dim comm As New MySqlCommand("INSERT INTO `course`(`course_code`, `course_title`, `credit_hours`) VALUES (@code,@title,@hours)", sms_db.makeConnection)

        comm.Parameters.Add("@code", MySqlDbType.VarChar).Value = courseCode
        comm.Parameters.Add("@title", MySqlDbType.VarChar).Value = courseTitle
        comm.Parameters.Add("@hours", MySqlDbType.Int32).Value = creditHours

        sms_db.startConnection()

        If comm.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function deleteCourse(ByVal courseCode As Integer) As Boolean

        Dim comm As New MySqlCommand("DELETE FROM `course` WHERE `id`=@courseID", sms_db.makeConnection)

        comm.Parameters.Add("@courseID", MySqlDbType.Int32).Value = Convert.ToInt32(courseCode)

        sms_db.startConnection()

        If comm.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Function validateCourse(ByVal courseCode As String, ByVal Optional courseID As Integer = 0) As Boolean

        'Sql command to check the database for a certain course code
        Dim comm As New MySqlCommand("SELECT * FROM `course` WHERE `course_code`=@ccode AND `id` <> @cseID", sms_db.makeConnection)
        comm.Parameters.Add("@ccode", MySqlDbType.VarChar).Value = courseCode
        comm.Parameters.Add("@cseID", MySqlDbType.Int32).Value = courseID
        Dim adapt As New MySqlDataAdapter(comm)
        Dim tab As New DataTable()
        adapt.Fill(tab)

        If tab.Rows.Count > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Function getAll() As DataTable
        'Generate all courses   
        Dim comm As New MySqlCommand("SELECT * FROM course", sms_db.makeConnection)

        Dim adapt As New MySqlDataAdapter(comm)
        Dim tab As New DataTable()
        adapt.Fill(tab)

        Return tab

    End Function

    Public Function getCourseViaID(ByVal id As Integer) As DataTable
        'Generate all courses   
        Dim comm As New MySqlCommand("SELECT * FROM course WHERE `id`=@id", sms_db.makeConnection)
        comm.Parameters.Add("@id", MySqlDbType.Int32).Value = id
        Dim adapt As New MySqlDataAdapter(comm)
        Dim tab As New DataTable()
        adapt.Fill(tab)

        Return tab

    End Function

    Public Function updateCourse(ByVal id As Integer, ByVal courseCode As String, ByVal courseTitle As String, ByVal creditHours As Integer) As Boolean

        Dim comm As New MySqlCommand("UPDATE `course` SET `course_code`=@ccode,`course_title`=@ctitle,`credit_hours`=@chours WHERE `id`=@id", sms_db.makeConnection)

        comm.Parameters.Add("@id", MySqlDbType.Int32).Value = id
        comm.Parameters.Add("@ccode", MySqlDbType.VarChar).Value = courseCode
        comm.Parameters.Add("@ctitle", MySqlDbType.VarChar).Value = courseTitle
        comm.Parameters.Add("@chours", MySqlDbType.Int32).Value = creditHours

        sms_db.startConnection()

        If comm.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    'Execute count query
    Function setCount(ByVal queryString As String) As String
        Dim comm As New MySqlCommand(queryString, sms_db.makeConnection)
        sms_db.startConnection()
        Return comm.ExecuteScalar().ToString()
        sms_db.endConnection()
    End Function

    'Return total number of courses 
    Function courseTotal() As String
        Return setCount("SELECT COUNT(*) FROM `course`")
    End Function

End Class
