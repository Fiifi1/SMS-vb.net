Public Class meanScore

    Dim avgScore As New scores()

    Private Sub meanScore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridViewStudent.DataSource = avgScore.getAverageScore()

    End Sub

End Class