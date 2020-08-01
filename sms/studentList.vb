Imports System.IO
Imports MySql.Data.MySqlClient

Public Class studentList
    Dim student As New student()

    'Method to first Load and populate the grid
    Private Sub studentList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comm As New MySqlCommand("SELECT * FROM `student`")

        stdListView.ReadOnly = True
        Dim imgCol As New DataGridViewImageColumn()
        stdListView.RowTemplate.Height = 70

        stdListView.DataSource = student.readAllStudents(comm)

        imgCol = stdListView.Columns(7)

        imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        stdListView.AllowUserToAddRows = False

    End Sub

    Private Sub stdListView_DoubleClick(sender As Object, e As EventArgs) Handles stdListView.DoubleClick

        'Load updateDelete form with double clicked data

        Dim updateDeleteForm As New updateDeleteForm()

        updateDeleteForm.IDTxtBox.Text = stdListView.CurrentRow.Cells(0).Value.ToString()
        updateDeleteForm.fnameBox.Text = stdListView.CurrentRow.Cells(1).Value.ToString()
        updateDeleteForm.surnameBox.Text = stdListView.CurrentRow.Cells(2).Value.ToString()
        updateDeleteForm.bdayBox.Value = stdListView.CurrentRow.Cells(3).Value
        updateDeleteForm.phoneBox.Text = stdListView.CurrentRow.Cells(4).Value.ToString()
        updateDeleteForm.addrBox.Text = stdListView.CurrentRow.Cells(5).Value.ToString()

        If stdListView.CurrentRow.Cells(6).Value.ToString = "Female" Then
            updateDeleteForm.femaleRadBtn.Checked = True
        Else
            updateDeleteForm.maleRadBtn.Checked = True
        End If

        Dim picByte As Byte()
        picByte = stdListView.CurrentRow.Cells(7).Value
        Dim picStream As New MemoryStream(picByte)
        updateDeleteForm.PicBox.Image = Image.FromStream(picStream)

        updateDeleteForm.ShowDialog()

    End Sub

    Private Sub refreshStdListBtn_Click(sender As Object, e As EventArgs) Handles refreshStdListBtn.Click

        Dim comm As New MySqlCommand("SELECT * FROM `student`")
        stdListView.ReadOnly = True
        Dim imgCol As New DataGridViewImageColumn()
        stdListView.RowTemplate.Height = 70

        stdListView.DataSource = student.readAllStudents(comm)

        imgCol = stdListView.Columns(7)

        imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch

        stdListView.AllowUserToAddRows = False

    End Sub

End Class