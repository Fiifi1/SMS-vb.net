Imports System.IO
Imports MySql.Data.MySqlClient

Public Class manageForm

    Dim student As New student()

    Private Sub manageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim commString As String = "SELECT * FROM `student`"

        Dim comm As New MySqlCommand(commString)

        populateTable(comm)

        'Read total number of students in datagrid view
        'totalStudentLabel.Text = totalStudentLabel.Text & " " & stdListView.Rows.Count

    End Sub

    Public Sub populateTable(ByVal comm As MySqlCommand)
        stdListView.ReadOnly = True
        Dim imgCol As New DataGridViewImageColumn()
        stdListView.RowTemplate.Height = 70

        stdListView.DataSource = student.readAllStudents(comm)

        imgCol = stdListView.Columns(7)

        imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        stdListView.AllowUserToAddRows = False

        'Total number of student after search
        totalStudentLabel.Text = "Total :" & stdListView.Rows.Count

    End Sub

    Private Sub stdListView_Click_1(sender As Object, e As EventArgs) Handles stdListView.Click

        IDTxtBox.Text = stdListView.CurrentRow.Cells(0).Value.ToString()
        fnameBox.Text = stdListView.CurrentRow.Cells(1).Value.ToString()
        surnameBox.Text = stdListView.CurrentRow.Cells(2).Value.ToString()
        bdayBox.Value = stdListView.CurrentRow.Cells(3).Value
        phoneBox.Text = stdListView.CurrentRow.Cells(4).Value.ToString()
        addrBox.Text = stdListView.CurrentRow.Cells(5).Value.ToString()

        If stdListView.CurrentRow.Cells(6).Value.ToString = "female" Then
            femaleRadBtn.Checked = True
        Else
            maleRadBtn.Checked = True
        End If

        Dim picbyte As Byte()
        picbyte = stdListView.CurrentRow.Cells(7).Value
        Dim picstream As New MemoryStream(picbyte)
        PicBox.Image = Image.FromStream(picstream)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim commString As String = "SELECT * FROM `student` WHERE CONCAT(`firstname`,`surname`,`address`)LIKE '%" & TxtBoxSearch.Text & "%'"

        Dim comm As New MySqlCommand(commString)

        populateTable(comm)

        'Total number of student after search
        'totalStudentLabel.Text = totalStudentLabel.Text & " " & stdListView.Rows.Count

    End Sub

    Private Sub TxtBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtBoxSearch.TextChanged
        Dim commString As String = "SELECT * FROM `student` WHERE CONCAT(`firstname`,`surname`,`address`)LIKE '%" & TxtBoxSearch.Text & "%'"

        Dim comm As New MySqlCommand(commString)

        populateTable(comm)

        'Total number of student after search
        'totalStudentLabel.Text = totalStudentLabel.Text & " " & stdListView.Rows.Count

    End Sub

    Private Sub addImageBbtn_Click(sender As Object, e As EventArgs) Handles addImageBbtn.Click
        Dim imagefile As New OpenFileDialog()
        imagefile.Filter = "Select Image(*.jpg;*.png;)|*.jpg;*.png;"

        If imagefile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            PicBox.Image = Image.FromFile(imagefile.FileName)

        End If
    End Sub

    Private Sub BtnResetStudent_Click(sender As Object, e As EventArgs) Handles BtnResetStudent.Click
        IDTxtBox.Text = ""
        fnameBox.Text = ""
        surnameBox.Text = ""
        bdayBox.Value = Date.Now()
        addrBox.Text = ""
        phoneBox.Text = ""
        maleRadBtn.Checked = True
        PicBox.Image = Nothing
    End Sub

    'Check that the checkboxes are not empty
    Function verifyEmptyBoxes() As Boolean
        If fnameBox.Text.Trim() = "" Or surnameBox.Text.Trim() = "" Or addrBox.Text.Trim() = "" Or
        phoneBox.Text.Trim() = "" Or PicBox.Image Is Nothing Then

            Return False

        Else

            Return True

        End If

    End Function

    Private Sub btnAddStudent_Click(sender As Object, e As EventArgs) Handles btnAddStudent.Click

        Dim firstname As String = fnameBox.Text
        Dim surname As String = surnameBox.Text
        Dim dob As Date = bdayBox.Value
        Dim phone As String = phoneBox.Text
        Dim address As String = addrBox.Text
        Dim gender As String = "Male"
        Dim photo As New MemoryStream


        If maleRadBtn.Checked Then
            femaleRadBtn.Checked = False
            gender = "Male"
        Else
            femaleRadBtn.Checked = True
            'maleRadBtn.Checked = False
            gender = "Female"

        End If

        Dim student As New student()

        'Verify birthyear
        Dim birthYear As Integer = bdayBox.Value.Year
        Dim currentYear As Integer = Date.Now.Year
        Dim ageDiff As Integer = currentYear - birthYear

        If ageDiff < 2 Or ageDiff > 100 Then

            MsgBox("Check Student Age!", MsgBoxStyle.Information, "Add New Student")
        Else

            If verifyEmptyBoxes() Then

                PicBox.Image.Save(photo, PicBox.Image.RawFormat)

                If student.addStudent(firstname, surname, dob, phone, address, gender, photo) Then
                    MsgBox("Student Added Successfully", MsgBoxStyle.Information, "Add New Student")
                    Dim commString As String = "SELECT * FROM `student`"
                    Dim comm As New MySqlCommand(commString)
                    populateTable(comm)

                    BtnResetStudent.PerformClick()

                Else
                    MsgBox("Error! Could Not Add student", MsgBoxStyle.Critical, "Add New Student")
                End If
            Else

                MsgBox("Cant Submit an Empty Form!", MsgBoxStyle.Critical, "Add New Student")

            End If
        End If

    End Sub

    Private Sub BtnDelStd_Click(sender As Object, e As EventArgs) Handles BtnDelStd.Click
        Try
            Dim stdID As Integer = Convert.ToInt32(IDTxtBox.Text)

            'Confirm deletion
            If MsgBox("Are you sure", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then
                If student.removeStudent(stdID) Then
                    MsgBox("Successfully Deleted Student", MsgBoxStyle.Information, "Remove Student")
                    Dim commString As String = "SELECT * FROM `student`"
                    Dim comm As New MySqlCommand(commString)
                    populateTable(comm)

                    BtnResetStudent.PerformClick()
                Else
                    MsgBox("Student cannot be found", MsgBoxStyle.Information, "Remove Student")
                End If
            End If
        Catch ex As Exception
            MsgBox("Invalid Student", MsgBoxStyle.Information, "Delete Student")
        End Try
    End Sub

    Private Sub BtnUpdateStudent_Click(sender As Object, e As EventArgs) Handles BtnUpdateStudent.Click
        Dim stdID As Integer
        Dim firstname As String = fnameBox.Text
        Dim surname As String = surnameBox.Text
        Dim dob As Date = bdayBox.Value
        Dim phone As String = phoneBox.Text
        Dim address As String = addrBox.Text
        Dim gender As String = "Male"
        Dim photo As New MemoryStream


        If maleRadBtn.Checked Then
            femaleRadBtn.Checked = False
            gender = "Male"
        Else
            femaleRadBtn.Checked = True
            'maleRadBtn.Checked = False
            gender = "Female"

        End If

        Dim student As New student()

        'Verify birthyear
        Dim birthYear As Integer = bdayBox.Value.Year
        Dim currentYear As Integer = Date.Now.Year
        Dim ageDiff As Integer = currentYear - birthYear

        If ageDiff < 2 Or ageDiff > 100 Then

            MsgBox("Check Student Age!", MsgBoxStyle.Information, "Update Student Details")
        Else

            If verifyEmptyBoxes() Then
                Try
                    stdID = Convert.ToInt32(IDTxtBox.Text)
                Catch ex As Exception
                    MsgBox("ID Must Be a Valid Integer From Student", MsgBoxStyle.Exclamation, "Update Student Details")
                End Try
                PicBox.Image.Save(photo, PicBox.Image.RawFormat)

                If student.updateStudentInfo(stdID, firstname, surname, dob, phone, address, gender, photo) Then
                    MsgBox("Information updated succesfully", MsgBoxStyle.Information, "Update Student Details")

                    Dim commString As String = "SELECT * FROM `student`"
                    Dim comm As New MySqlCommand(commString)
                    populateTable(comm)

                    BtnResetStudent.PerformClick()

                Else
                    MsgBox("Error! Could Not update student information", MsgBoxStyle.Critical, "Update Student Details")
                End If
            Else

                MsgBox("Cant Submit an Empty Form!", MsgBoxStyle.Critical, "Update Student Details")

            End If
        End If
    End Sub

End Class