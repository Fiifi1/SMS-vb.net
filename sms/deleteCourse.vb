Public Class deleteCourse
    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        Dim delCourse As New course()


        Try
            Dim courseID As Integer = TxtBoxCourseCode.Text.Trim()

            If MsgBox("Are you sure, you want to delete?", MsgBoxStyle.YesNo, "Remove Course") = MsgBoxResult.Yes Then
                If delCourse.deleteCourse(courseID) Then
                    MsgBox("Deleted course with ID" & courseID & " Successfully", MsgBoxStyle.Information, "Remove Course")
                Else
                    MsgBox("Oops! Could Not Delete course with ID " & courseID, MsgBoxStyle.Critical, "Remove Course")
                End If
            End If

        Catch ex As Exception
            MsgBox("Enter a Valid Course ID", MsgBoxStyle.Exclamation, "Remove Course")
        End Try


    End Sub
End Class