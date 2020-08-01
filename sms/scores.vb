Imports MySql.Data.MySqlClient

Public Class scores

    Dim sms_db As New sms_db()

    Public Function addScore(ByVal studentID As Integer, ByVal courseID As Integer, ByVal mark As Double, ByVal remarks As String) As Boolean

        Dim comm As New MySqlCommand("INSERT INTO `score`(`student_id`, `course_id`, `student_mark`, `remark`) VALUES (@stdID, @crsID, @stdMrk, @rmrk)", sms_db.makeConnection)

        comm.Parameters.Add("@stdID", MySqlDbType.Int32).Value = studentID
        comm.Parameters.Add("@crsID", MySqlDbType.Int32).Value = courseID
        comm.Parameters.Add("@stdMrk", MySqlDbType.Double).Value = mark
        comm.Parameters.Add("@rmrk", MySqlDbType.Text).Value = remarks

        sms_db.startConnection()

        If comm.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function validateScore(ByVal studentID As Integer, ByVal courseID As Integer)
        Dim comm As New MySqlCommand("SELECT * FROM `score` WHERE `student_id`=@stdID AND `course_id`=@crsID", sms_db.makeConnection)

        comm.Parameters.Add("@stdID", MySqlDbType.Int32).Value = studentID
        comm.Parameters.Add("@crsID", MySqlDbType.Int32).Value = courseID

        Dim adapt As New MySqlDataAdapter(comm)
        Dim table As New DataTable()
        adapt.Fill(table)

        If table.Rows.Count = 0 Then
            Return True
        Else
            Return False
        End If

    End Function

    Function getStudentCourseScore() As DataTable

        Dim comm As New MySqlCommand()
        comm.Connection = sms_db.makeConnection()
        comm.CommandText = "SELECT score.student_id, student.firstname, student.surname, score.course_id, course.course_code, score.student_mark FROM student INNER JOIN score on student.id = score.student_id INNER JOIN course on score.course_id = course.id"

        Dim table As New DataTable()
        Dim adapt As New MySqlDataAdapter(comm)
        adapt.Fill(table)

        Return table

    End Function

    Function getAverageScore() As DataTable

        Dim comm As New MySqlCommand()
        comm.Connection = sms_db.makeConnection()
        comm.CommandText = "SELECT course.course_code, AVG(score.student_mark)as 'average_scores' FROM course, score WHERE course.id = score.course_id GROUP BY course.course_code"

        Dim table As New DataTable()
        Dim adapt As New MySqlDataAdapter(comm)
        adapt.Fill(table)

        Return table

    End Function

    Public Function deleteScore(ByVal studentID As Integer, ByVal courseID As Integer) As Boolean

        Dim comm As New MySqlCommand("DELETE FROM `score` WHERE `student_id`=@stdID AND `course_id`=@crsID", sms_db.makeConnection)

        comm.Parameters.Add("@stdID", MySqlDbType.Int32).Value = Convert.ToInt32(studentID)
        comm.Parameters.Add("@crsID", MySqlDbType.Int32).Value = Convert.ToInt32(courseID)

        sms_db.startConnection()

        If comm.ExecuteNonQuery() = 1 Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
