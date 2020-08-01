Imports System.IO

Public Class addStudent

    Private Sub mobTxtBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mobTxtBox.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub uploadImgBtn_Click(sender As Object, e As EventArgs) Handles uploadImgBtn.Click

        Dim imagefile As New OpenFileDialog()
        imagefile.Filter = "Select Image(*.jpg;*.png;)|*.jpg;*.png;"

        If imagefile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            stdPicBox.Image = Image.FromFile(imagefile.FileName)

        End If

    End Sub

    Private Sub cancelAddStdBtn_Click(sender As Object, e As EventArgs) Handles cancelAddStdBtn.Click
        Me.Close()
    End Sub

    Private Sub addStdBtn_Click(sender As Object, e As EventArgs) Handles addStdBtn.Click

        Dim firstname As String = fnameTxtBox.Text
        Dim surname As String = surTxtBox.Text
        Dim dob As Date = addStdDate.Value
        Dim phone As String = mobTxtBox.Text
        Dim address As String = addressTxtBox.Text
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
        Dim birthYear As Integer = addStdDate.Value.Year
        Dim currentYear As Integer = Date.Now.Year
        Dim ageDiff As Integer = currentYear - birthYear

        If ageDiff < 2 Or ageDiff > 100 Then

            MsgBox("Check Student Age!", MsgBoxStyle.Information, "Add New Student")
        Else

            If verifyEmptyBoxes() Then

                stdPicBox.Image.Save(photo, stdPicBox.Image.RawFormat)

                If student.addStudent(firstname, surname, dob, phone, address, gender, photo) Then
                    MsgBox(firstname & " was Added Successfully", MsgBoxStyle.Information, "Add New Student")

                    fnameTxtBox.Text = ""
                    surTxtBox.Text = ""
                    addressTxtBox.Text = ""
                    addStdDate.Value = Date.Now()
                    mobTxtBox.Text = ""
                    stdPicBox.Image = Nothing

                Else
                    MsgBox("Error! Could Not Add " & firstname, MsgBoxStyle.Critical, "Add New Student")
                End If
            Else

                MsgBox("Cant Submit an Empty Form!", MsgBoxStyle.Critical, "Add New Student")

            End If
        End If


    End Sub

    'Check that the checkboxes are not empty
    Function verifyEmptyBoxes() As Boolean
        If fnameTxtBox.Text.Trim() = "" Or surTxtBox.Text.Trim() = "" Or addressTxtBox.Text.Trim() = "" Or
        mobTxtBox.Text.Trim() = "" Or stdPicBox.Image Is Nothing Then

            Return False

        Else

            Return True

        End If

    End Function

End Class