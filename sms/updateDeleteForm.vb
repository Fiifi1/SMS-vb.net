Imports System.IO

Public Class updateDeleteForm
    Dim delStudent As New student()

    'Event to invoke the delete student method
    Private Sub delStdBtn_Click(sender As Object, e As EventArgs) Handles delStdBtn.Click

        Try
            Dim stdID As Integer = Convert.ToInt32(IDTxtBox.Text)

            'Confirm deletion
            If MsgBox("Are you sure", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then
                If delStudent.removeStudent(stdID) Then
                    MsgBox("Successfully Deleted Student", MsgBoxStyle.Information, "Remove Student")
                Else
                    MsgBox("Student cannot be found", MsgBoxStyle.Information, "Remove Student")
                End If
            End If
        Catch ex As Exception
            MsgBox("Invalid Student", MsgBoxStyle.Information, "Delete Student")
        End Try

    End Sub

    Private Sub updateStdBtn_Click(sender As Object, e As EventArgs) Handles updateStdBtn.Click
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

                    IDTxtBox.Text = ""
                    fnameBox.Text = ""
                    surnameBox.Text = ""
                    bdayBox.Value = Date.Now()
                    addrBox.Text = ""
                    phoneBox.Text = ""
                    maleRadBtn.Checked = True
                    PicBox.Image = Nothing

                Else
                    MsgBox("Error! Could Not update student information", MsgBoxStyle.Critical, "Update Student Details")
                End If
            Else

                MsgBox("Cant Submit an Empty Form!", MsgBoxStyle.Critical, "Update Student Details")

            End If
        End If

    End Sub

    'Check that the checkboxes are not empty
    Function verifyEmptyBoxes() As Boolean
        If IDTxtBox.Text.Trim() = "" Or fnameBox.Text.Trim() = "" Or surnameBox.Text.Trim() = "" Or addrBox.Text.Trim() = "" Or
        phoneBox.Text.Trim() = "" Or PicBox.Image Is Nothing Then

            Return False

        Else

            Return True

        End If

    End Function

    Private Sub addImageBbtn_Click(sender As Object, e As EventArgs) Handles addImageBbtn.Click

        Dim imagefile As New OpenFileDialog()
        imagefile.Filter = "Select Image(*.jpg;*.png;)|*.jpg;*.png;"

        If imagefile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            PicBox.Image = Image.FromFile(imagefile.FileName)

        End If

    End Sub
End Class