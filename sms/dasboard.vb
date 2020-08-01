Public Class dasboard
    'Add student form
    Private Sub AddStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentToolStripMenuItem.Click

        Dim addStd As New addStudent()
        addStd.ShowDialog()

    End Sub

    'All students table
    Private Sub AllStudentsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllStudentsToolStripMenuItem.Click

        Dim listStudentForm As New studentList()
        listStudentForm.Show(Me)

    End Sub

    'Luanch students statistics
    Private Sub StudentStatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentStatsToolStripMenuItem.Click

        Dim statsForm As New studentStatistics()
        statsForm.Show(Me)

    End Sub

    Private Sub UpdateInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateInfoToolStripMenuItem.Click
        Dim updateDeleteForm As New updateDeleteForm()
        updateDeleteForm.Show(Me)
    End Sub

    Private Sub RemoveStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveStudentToolStripMenuItem.Click
        Dim updateDeleteForm As New updateDeleteForm()
        updateDeleteForm.Show(Me)
    End Sub

    Private Sub ManageStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStudentToolStripMenuItem.Click
        Dim manageStdForm As New manageForm()
        manageStdForm.Show(Me)
    End Sub

    Private Sub AddSubjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddSubjectToolStripMenuItem.Click
        Dim createCourseForm As New createCourse()
        createCourseForm.Show(Me)
    End Sub

    Private Sub DeleteCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteCourseToolStripMenuItem.Click
        Dim deleteCourseForm As New deleteCourse()
        deleteCourseForm.Show(Me)
    End Sub

    Private Sub RedactCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedactCourseToolStripMenuItem.Click
        Dim editCourseForm As New editCourse()
        editCourseForm.Show(Me)
    End Sub

    Private Sub ManageCoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageCoursesToolStripMenuItem.Click
        Dim manageCourseForm As New manageCourse()
        manageCourseForm.Show(Me)
    End Sub

    Private Sub SetScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SetScoreToolStripMenuItem.Click
        Dim addScoreForm As New addScore()
        addScoreForm.Show(Me)
    End Sub

    Private Sub UndoScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoScoreToolStripMenuItem.Click
        Dim undoScoreForm As New deleteScore()
        undoScoreForm.Show(Me)
    End Sub

    Private Sub MangeAllScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MangeAllScoreToolStripMenuItem.Click
        Dim manageScore As New manageScore()
        manageScore.Show(Me)
    End Sub

    Private Sub AverageScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AverageScoresToolStripMenuItem.Click
        Dim meanScore As New meanScore()
        meanScore.Show(Me)
    End Sub
End Class