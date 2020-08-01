Imports System.IO
Imports MySql.Data.MySqlClient

Public Class student

    Dim smsDB As New sms_db()

    'Add student method
    Public Function addStudent(ByVal fname As String, ByVal sname As String, ByVal dob As Date, ByVal phone As String, ByVal address As String, ByVal gender As String, ByVal photo As MemoryStream) As Boolean
        Dim comm As New MySqlCommand("INSERT INTO `student`(`firstname`, `surname`, `dob`, `phone`, `address`, `gender`, `photo`) VALUES (@fname,@sname,@dob,@phone,@address, @gender,@photo)", smsDB.makeConnection)

        comm.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname

        comm.Parameters.Add("@sname", MySqlDbType.VarChar).Value = sname

        comm.Parameters.Add("@dob", MySqlDbType.DateTime).Value = dob

        comm.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone

        comm.Parameters.Add("@address", MySqlDbType.VarChar).Value = address

        comm.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender

        comm.Parameters.Add("@photo", MySqlDbType.Blob).Value = photo.ToArray()

        smsDB.startConnection()

        If comm.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        smsDB.endConnection()

    End Function

    'Method to read all students from database

    Function readAllStudents(ByVal Comm As MySqlCommand) As DataTable

        Comm.Connection = smsDB.makeConnection

        Dim readAdapt As New MySqlDataAdapter(Comm)
        Dim readTable As New DataTable()

        readAdapt.Fill(readTable)

        Return readTable

    End Function

    'Delete student from the database
    Public Function removeStudent(ByVal stdID As Integer) As Boolean

        Dim comm As New MySqlCommand("DELETE FROM `student` WHERE `id` = @stdID", smsDB.makeConnection)

        comm.Parameters.Add("@stdID", MySqlDbType.Int32).Value = stdID
        smsDB.startConnection()

        If comm.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        smsDB.endConnection()

    End Function

    'Method to update Student Information
    Public Function updateStudentInfo(ByVal stdID As Integer, ByVal fname As String, ByVal sname As String, ByVal dob As Date, ByVal phone As String, ByVal address As String, ByVal gender As String, ByVal photo As MemoryStream) As Boolean
        Dim comm As New MySqlCommand("UPDATE `student` SET `firstname`=@fname,`surname`=@sname,`dob`=@dob,`phone`=@phone,`address`=@address,`gender`=@gender,`photo`=@photo WHERE `id`=@stdID", smsDB.makeConnection)

        comm.Parameters.Add("@stdID", MySqlDbType.Int32).Value = stdID

        comm.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname

        comm.Parameters.Add("@sname", MySqlDbType.VarChar).Value = sname

        comm.Parameters.Add("@dob", MySqlDbType.DateTime).Value = dob

        comm.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone

        comm.Parameters.Add("@address", MySqlDbType.VarChar).Value = address

        comm.Parameters.Add("@gender", MySqlDbType.VarChar).Value = gender

        comm.Parameters.Add("@photo", MySqlDbType.Blob).Value = photo.ToArray()

        smsDB.startConnection()

        If comm.ExecuteNonQuery() = 1 Then

            Return True
        Else

            Return False
        End If

        smsDB.endConnection()

    End Function

    'Execute count query
    Function setCount(ByVal queryString As String) As String
        Dim comm As New MySqlCommand(queryString, smsDB.makeConnection)
        smsDB.startConnection()
        Return comm.ExecuteScalar().ToString()
        smsDB.endConnection()
    End Function

    'Return total number of students
    Function studentTotal() As String
        Return setCount("SELECT COUNT(*) FROM `student`")
    End Function

    'Return total number Male students
    Function maleTotal() As String
        Return setCount("SELECT COUNT(*) FROM `student` WHERE `gender` = 'Male'")
    End Function

    'Return total number of Female students
    Function FemaleTotal() As String
        Return setCount("SELECT COUNT(*) FROM `student` WHERE `gender` = 'Female'")
    End Function

End Class
