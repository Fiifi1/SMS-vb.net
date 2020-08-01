Public Class editCourse
    Dim courseToEdit As New course()

    Private Sub editCourse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display courses in comboBox when form loads

        comboBoxCourses.DataSource = courseToEdit.getAll()

        comboBoxCourses.DisplayMember = "course_code"

        comboBoxCourses.ValueMember = "id"


        comboBoxCourses.SelectedItem = Nothing


    End Sub

    Sub reloadForm(ByVal index As Integer)
        'Reload content of ComboBox and Form

        comboBoxCourses.DataSource = courseToEdit.getAll()

        comboBoxCourses.DisplayMember = "course_code"

        comboBoxCourses.ValueMember = "id"

        comboBoxCourses.SelectedIndex = index

    End Sub

    Private Sub btnUpdateCourse_Click(sender As Object, e As EventArgs) Handles btnUpdateCourse.Click

        Dim courseID As Integer = comboBoxCourses.SelectedValue
        Dim CourseCode As String = TextBoxCourseCode.Text.Trim()
        Dim CourseTitle As String = txtBoxCourseTitle.Text.Trim()
        Dim creditHours As Integer = upDownCreditHours.Value

        If courseToEdit.validateCourse(CourseCode, Convert.ToInt32(comboBoxCourses.SelectedValue)) Then
            If courseToEdit.updateCourse(courseID, CourseCode, CourseTitle, creditHours) Then
                MsgBox(CourseCode & " was updated Successfully", MsgBoxStyle.Information, "Update Course")
                reloadForm(comboBoxCourses.SelectedIndex)
            Else
                MsgBox("Could not Update " & CourseCode, MsgBoxStyle.Critical, "Update Course")

            End If
        Else
            MsgBox(CourseCode & " Already exist!", MsgBoxStyle.Exclamation, "Update Course")
        End If



    End Sub

    Private Sub comboBoxCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxCourses.SelectedIndexChanged
        'Kept in a try catch block to prvent an error when the combo box is set to nothing
        Try

            'Load course when selected
            Dim courseID As Integer = Convert.ToInt32(comboBoxCourses.SelectedValue)
            Dim table As New DataTable()
            table = courseToEdit.getCourseViaID(courseID)

            TextBoxCourseCode.Text = table.Rows(0)(1)
            txtBoxCourseTitle.Text = table.Rows(0)(2)
            upDownCreditHours.Value = table.Rows(0)(3)

        Catch ex As Exception

        End Try


    End Sub
End Class