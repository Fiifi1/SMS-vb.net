Public Class deleteScore

    Dim score As New scores()

    Private Sub deleteScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the data grid view with courses

        DataGridViewStudent.DataSource = score.getStudentCourseScore()
    End Sub

    Private Sub btnAddScore_Click(sender As Object, e As EventArgs) Handles btnAddScore.Click
        Dim studentID As Integer = DataGridViewStudent.CurrentRow.Cells(0).Value
        Dim courseId As Integer = DataGridViewStudent.CurrentRow.Cells(3).Value

        If MsgBox("Do you want to delete Score?", MsgBoxStyle.YesNo, "Delete Score") = MsgBoxResult.Yes Then
            Console.WriteLine("This line is passed")
            If score.deleteScore(studentID, courseId) Then
                Console.WriteLine("This line is passed too")

                MsgBox("Removed Score for student ID" & studentID & " Successfully ", MsgBoxStyle.Information, "Delete Score")
                DataGridViewStudent.DataSource = score.getStudentCourseScore()

            Else

                MsgBox("Could not Remove Score for student ID" & studentID, MsgBoxStyle.Information, "Delete Score")

            End If
        End If
    End Sub
End Class