<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dasboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.STUDENTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllStudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentStatsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SUBJECTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddSubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedactCourseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageCoursesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MARKToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MangeAllScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AverageScoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STUDENTToolStripMenuItem, Me.SUBJECTToolStripMenuItem, Me.MARKToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1579, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'STUDENTToolStripMenuItem
        '
        Me.STUDENTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStudentToolStripMenuItem, Me.AllStudentsToolStripMenuItem, Me.StudentStatsToolStripMenuItem, Me.UpdateInfoToolStripMenuItem, Me.RemoveStudentToolStripMenuItem, Me.ManageStudentToolStripMenuItem})
        Me.STUDENTToolStripMenuItem.Name = "STUDENTToolStripMenuItem"
        Me.STUDENTToolStripMenuItem.Size = New System.Drawing.Size(85, 24)
        Me.STUDENTToolStripMenuItem.Text = "STUDENT"
        '
        'AddStudentToolStripMenuItem
        '
        Me.AddStudentToolStripMenuItem.Name = "AddStudentToolStripMenuItem"
        Me.AddStudentToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.AddStudentToolStripMenuItem.Text = "Add Student"
        '
        'AllStudentsToolStripMenuItem
        '
        Me.AllStudentsToolStripMenuItem.Name = "AllStudentsToolStripMenuItem"
        Me.AllStudentsToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.AllStudentsToolStripMenuItem.Text = "All Students"
        '
        'StudentStatsToolStripMenuItem
        '
        Me.StudentStatsToolStripMenuItem.Name = "StudentStatsToolStripMenuItem"
        Me.StudentStatsToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.StudentStatsToolStripMenuItem.Text = "Student Stats"
        '
        'UpdateInfoToolStripMenuItem
        '
        Me.UpdateInfoToolStripMenuItem.Name = "UpdateInfoToolStripMenuItem"
        Me.UpdateInfoToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.UpdateInfoToolStripMenuItem.Text = "Update Student Info"
        '
        'RemoveStudentToolStripMenuItem
        '
        Me.RemoveStudentToolStripMenuItem.Name = "RemoveStudentToolStripMenuItem"
        Me.RemoveStudentToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.RemoveStudentToolStripMenuItem.Text = "Remove Student"
        '
        'ManageStudentToolStripMenuItem
        '
        Me.ManageStudentToolStripMenuItem.Name = "ManageStudentToolStripMenuItem"
        Me.ManageStudentToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.ManageStudentToolStripMenuItem.Text = "Manage Student"
        '
        'SUBJECTToolStripMenuItem
        '
        Me.SUBJECTToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddSubjectToolStripMenuItem, Me.DeleteCourseToolStripMenuItem, Me.RedactCourseToolStripMenuItem, Me.ManageCoursesToolStripMenuItem})
        Me.SUBJECTToolStripMenuItem.Name = "SUBJECTToolStripMenuItem"
        Me.SUBJECTToolStripMenuItem.Size = New System.Drawing.Size(139, 24)
        Me.SUBJECTToolStripMenuItem.Text = "COURSE/SUBJECT"
        '
        'AddSubjectToolStripMenuItem
        '
        Me.AddSubjectToolStripMenuItem.Name = "AddSubjectToolStripMenuItem"
        Me.AddSubjectToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.AddSubjectToolStripMenuItem.Text = "Create Course"
        '
        'DeleteCourseToolStripMenuItem
        '
        Me.DeleteCourseToolStripMenuItem.Name = "DeleteCourseToolStripMenuItem"
        Me.DeleteCourseToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.DeleteCourseToolStripMenuItem.Text = "Delete Course"
        '
        'RedactCourseToolStripMenuItem
        '
        Me.RedactCourseToolStripMenuItem.Name = "RedactCourseToolStripMenuItem"
        Me.RedactCourseToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.RedactCourseToolStripMenuItem.Text = "Redact Course"
        '
        'ManageCoursesToolStripMenuItem
        '
        Me.ManageCoursesToolStripMenuItem.Name = "ManageCoursesToolStripMenuItem"
        Me.ManageCoursesToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.ManageCoursesToolStripMenuItem.Text = "Manage Courses"
        '
        'MARKToolStripMenuItem
        '
        Me.MARKToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SetScoreToolStripMenuItem, Me.UndoScoreToolStripMenuItem, Me.MangeAllScoreToolStripMenuItem, Me.AverageScoresToolStripMenuItem})
        Me.MARKToolStripMenuItem.Name = "MARKToolStripMenuItem"
        Me.MARKToolStripMenuItem.Size = New System.Drawing.Size(70, 24)
        Me.MARKToolStripMenuItem.Text = "MARKS"
        '
        'SetScoreToolStripMenuItem
        '
        Me.SetScoreToolStripMenuItem.Name = "SetScoreToolStripMenuItem"
        Me.SetScoreToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.SetScoreToolStripMenuItem.Text = "Set Score"
        '
        'UndoScoreToolStripMenuItem
        '
        Me.UndoScoreToolStripMenuItem.Name = "UndoScoreToolStripMenuItem"
        Me.UndoScoreToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.UndoScoreToolStripMenuItem.Text = "Undo Score"
        '
        'MangeAllScoreToolStripMenuItem
        '
        Me.MangeAllScoreToolStripMenuItem.Name = "MangeAllScoreToolStripMenuItem"
        Me.MangeAllScoreToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.MangeAllScoreToolStripMenuItem.Text = "Mange All Score"
        '
        'AverageScoresToolStripMenuItem
        '
        Me.AverageScoresToolStripMenuItem.Name = "AverageScoresToolStripMenuItem"
        Me.AverageScoresToolStripMenuItem.Size = New System.Drawing.Size(193, 26)
        Me.AverageScoresToolStripMenuItem.Text = "Average Scores"
        '
        'dasboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1579, 838)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1061, 728)
        Me.Name = "dasboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents STUDENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SUBJECTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MARKToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllStudentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StudentStatsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageStudentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddSubjectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedactCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManageCoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SetScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MangeAllScoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AverageScoresToolStripMenuItem As ToolStripMenuItem
End Class
