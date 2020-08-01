Public Class createCourse

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        'Obtain all the values on the form
        Dim courseCode As String = TxtBoxCourseCode.Text.Trim()
        Dim courseTitle As String = txtBoxCourseTitle.Text.Trim()
        Dim creditHours As Integer = upDownCreditHours.Value

        'Call database method
        Dim newCourse As New course()

        If courseCode.Trim() = "" Or creditHours <= 0 Then
            MsgBox("Make sure course code is not Empty!", MsgBoxStyle.Critical, "Add course")
        Else
            'Check for already existing course code
            If newCourse.validateCourse(courseCode, Nothing) Then
                If newCourse.createNewCourse(courseCode, courseTitle, creditHours) Then
                    MsgBox("Added " & courseCode & " Successfully", MsgBoxStyle.Information, "Add Course")
                Else
                    MsgBox("Oops! Could Not Add " & courseCode, MsgBoxStyle.Critical, "Add Course")
                End If
            Else

                MsgBox(courseCode & " already Exists!", MsgBoxStyle.Critical, "Add course")

            End If

        End If



    End Sub

End Class