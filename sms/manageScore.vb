Imports MySql.Data.MySqlClient

Public Class manageScore

    Dim score As New scores()
    Dim student As New student()
    Dim course As New course()

    Private Sub manageScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridViewStudent.DataSource = score.getStudentCourseScore()

        comboBoxCourses.DataSource = course.getAll()

        comboBoxCourses.DisplayMember = "course_code"

        comboBoxCourses.ValueMember = "id"


    End Sub

    Private Sub addStdBtn_Click(sender As Object, e As EventArgs) Handles addStdBtn.Click

        DataGridViewStudent.DataSource = score.getStudentCourseScore()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim comm As New MySqlCommand("SELECT `id`, `firstname`, `surname`, `dob`, `phone`FROM `student`")
        DataGridViewStudent.DataSource = student.readAllStudents(comm)

    End Sub

    Private Sub btnAddScore_Click(sender As Object, e As EventArgs) Handles btnAddScore.Click

        Try
            Dim studentID As Integer = Convert.ToInt32(TextBoxStudentID.Text)
            Dim courseID As Integer = Convert.ToInt32(comboBoxCourses.SelectedValue)
            Dim mark As Double = Convert.ToDouble(upDownScore.Value)
            Dim remark As String = txtBoxRemarks.Text

            If score.validateScore(studentID, courseID) Then

                If score.addScore(studentID, courseID, mark, remark) Then
                    MsgBox("Added Score to course ID" & courseID & " Successfully", MsgBoxStyle.Information, "Add Score")
                    emptyFields()
                Else
                    MsgBox("Could not Add Score to course ID" & courseID, MsgBoxStyle.Exclamation, "Add Score")
                End If

            Else
                MsgBox("Score already Exists!", MsgBoxStyle.Exclamation, "Add Course")
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, "Add Score")
        End Try


    End Sub

    Private Sub btnDelScore_Click(sender As Object, e As EventArgs) Handles btnDelScore.Click

        Dim studentID As Integer = DataGridViewStudent.CurrentRow.Cells(0).Value
        Dim courseId As Integer = DataGridViewStudent.CurrentRow.Cells(3).Value

        If MsgBox("Do you want to delete Score?", MsgBoxStyle.YesNo, "Delete Score") = MsgBoxResult.Yes Then
            Console.WriteLine("This line is passed")
            If score.deleteScore(studentID, courseId) Then
                Console.WriteLine("This line is passed too")

                MsgBox("Removed Score for student ID" & studentID & " Successfully ", MsgBoxStyle.Information, "Delete Score")
                DataGridViewStudent.DataSource = score.getStudentCourseScore()
                emptyFields()

            Else

                MsgBox("Could not Remove Score for student ID" & studentID, MsgBoxStyle.Information, "Delete Score")

            End If
        End If

    End Sub

    Sub emptyFields()
        TextBoxStudentID.Text = ""
        comboBoxCourses.SelectedItem = Nothing
        upDownScore.Value = 0
        txtBoxRemarks.Text = ""
    End Sub

    Private Sub DataGridViewStudent_Click(sender As Object, e As EventArgs) Handles DataGridViewStudent.Click

        TextBoxStudentID.Text = DataGridViewStudent.CurrentRow.Cells(0).Value.ToString()
        comboBoxCourses.SelectedValue = DataGridViewStudent.CurrentRow.Cells(3).Value

    End Sub

    Private Sub meanScoreBtn_Click(sender As Object, e As EventArgs) Handles meanScoreBtn.Click
        Dim avgScore As New meanScore()
        avgScore.Show(Me)
    End Sub
End Class