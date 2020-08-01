Imports MySql.Data.MySqlClient

Public Class addScore

    Dim score As New scores()
    Dim course As New course()
    Dim students As New student()

    Private Sub addScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display courses in comboBox when form loads

        comboBoxCourses.DataSource = course.getAll()

        comboBoxCourses.DisplayMember = "course_code"

        comboBoxCourses.ValueMember = "id"

        Dim comm As New MySqlCommand("SELECT `id`, `firstname`, `surname` FROM `student`")

        DataGridViewStudent.DataSource = students.readAllStudents(comm)

        comboBoxCourses.SelectedItem = Nothing

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

    Private Sub DataGridViewStudent_Click(sender As Object, e As EventArgs) Handles DataGridViewStudent.Click

        TextBoxStudentID.Text = DataGridViewStudent.CurrentRow.Cells(0).Value.ToString()

    End Sub

    Sub emptyFields()
        TextBoxStudentID.Text = ""
        comboBoxCourses.SelectedItem = Nothing
        upDownScore.Value = 0
        txtBoxRemarks.Text = ""
    End Sub

End Class