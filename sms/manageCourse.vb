Public Class manageCourse

    Dim course As New course()

    Private Sub manageCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reloadList()
    End Sub

    Sub reloadList()
        'load all courses into listBox
        listboxCourses.DataSource = course.getAll()
        listboxCourses.ValueMember = "id"
        listboxCourses.DisplayMember = "course_code"
        'Total number of courses Label
        totalCourseLabel.Text = "Total: " & course.courseTotal()
        'Select Nothing on intial Load
        listboxCourses.SelectedItem = Nothing
    End Sub

    Private Sub listboxCourses_Click(sender As Object, e As EventArgs) Handles listboxCourses.Click
        Dim dataRow As DataRowView = listboxCourses.SelectedItem

        txtBoxCourseID.Text = dataRow.Item(0).ToString()
        TextBoxCourseCode.Text = dataRow.Item(1).ToString()
        txtBoxCourseTitle.Text = dataRow.Item(2).ToString()
        upDownCreditHours.Value = dataRow.Item(3)
    End Sub

    Private Sub btnAddCourse_Click(sender As Object, e As EventArgs) Handles btnAddCourse.Click
        'Obtain all the values on the form
        Dim courseCode As String = TextBoxCourseCode.Text.Trim()
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
                    reloadList()
                Else
                    MsgBox("Oops! Could Not Add " & courseCode, MsgBoxStyle.Critical, "Add Course")
                End If
            Else

                MsgBox(courseCode & " already Exists!", MsgBoxStyle.Critical, "Add course")

            End If

        End If

    End Sub

    Private Sub btnEditCourse_Click(sender As Object, e As EventArgs) Handles btnEditCourse.Click

        Dim courseID As Integer = listboxCourses.SelectedValue
        Dim CourseCode As String = TextBoxCourseCode.Text.Trim()
        Dim CourseTitle As String = txtBoxCourseTitle.Text.Trim()
        Dim creditHours As Integer = upDownCreditHours.Value

        If course.validateCourse(CourseCode, Convert.ToInt32(listboxCourses.SelectedValue)) Then
            If course.updateCourse(courseID, CourseCode, CourseTitle, creditHours) Then
                MsgBox(CourseCode & " was updated Successfully", MsgBoxStyle.Information, "Update Course")
                reloadList()
                clearAllFields()
            Else
                MsgBox("Could not Update " & CourseCode, MsgBoxStyle.Critical, "Update Course")

            End If
        Else
            MsgBox(CourseCode & " Already exist!", MsgBoxStyle.Exclamation, "Update Course")
        End If

    End Sub

    Private Sub btnDelCourse_Click(sender As Object, e As EventArgs) Handles btnDelCourse.Click

        Try
            Dim courseID As Integer = listboxCourses.SelectedValue

            If MsgBox("Are you sure, you want to delete?", MsgBoxStyle.YesNo, "Remove Course") = MsgBoxResult.Yes Then
                If course.deleteCourse(courseID) Then
                    MsgBox("Deleted course with ID" & courseID & " Successfully", MsgBoxStyle.Information, "Remove Course")
                    reloadList()
                    clearAllFields()
                Else
                    MsgBox("Oops! Could Not Delete course with ID " & courseID, MsgBoxStyle.Critical, "Remove Course")
                End If
            End If

        Catch ex As Exception
            MsgBox("Enter a Valid Course ID", MsgBoxStyle.Exclamation, "Remove Course")
        End Try


    End Sub

    Sub clearAllFields()
        txtBoxCourseID.Text = ""
        TextBoxCourseCode.Text = ""
        txtBoxCourseTitle.Text = ""
        upDownCreditHours.Value = 1

    End Sub

End Class