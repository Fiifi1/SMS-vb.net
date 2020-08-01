Public Class studentStatistics
    Private Sub btnCloseStat_Click(sender As Object, e As EventArgs) Handles btnCloseStat.Click

        Me.Close()

    End Sub

    Dim panColor As Color

    Private Sub studentStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panColor = stdTotalPanel.BackColor

        'Obtain counts for all panels from the db class
        Dim student As New student()
        Dim studentTotal As Integer = Convert.ToInt32(student.studentTotal())
        Dim femaleTotal As Integer = Convert.ToInt32(student.FemaleTotal())
        Dim maleTotal As Integer = Convert.ToInt32(student.maleTotal())

        'In percentages
        Dim malePer As Double = (maleTotal * 100) / studentTotal
        Dim femalePer As Double = (femaleTotal * 100) / studentTotal

        LabelTotal.Text = "Total : " & studentTotal.ToString()
        LabelMales.Text = "Males : " & malePer.ToString("00") & "%"
        LabelFemale.Text = "Females :   " & femalePer.ToString("00") & "%"

    End Sub

    Private Sub stdTotalPanel_MouseEnter(sender As Object, e As EventArgs) Handles stdTotalPanel.MouseEnter
        stdTotalPanel.BackColor = Color.White
    End Sub

    Private Sub stdTotalPanel_MouseLeave(sender As Object, e As EventArgs) Handles stdTotalPanel.MouseLeave
        stdTotalPanel.BackColor = panColor
    End Sub

    Private Sub FemalePanel_MouseEnter(sender As Object, e As EventArgs) Handles FemalePanel.MouseEnter
        FemalePanel.BackColor = Color.White
    End Sub

    Private Sub FemalePanel_MouseLeave(sender As Object, e As EventArgs) Handles FemalePanel.MouseLeave
        FemalePanel.BackColor = panColor
    End Sub

    Private Sub MalePanel_MouseEnter(sender As Object, e As EventArgs) Handles MalePanel.MouseEnter
        MalePanel.BackColor = Color.White
    End Sub

    Private Sub MalePanel_MouseLeave(sender As Object, e As EventArgs) Handles MalePanel.MouseLeave
        MalePanel.BackColor = panColor
    End Sub
End Class