<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class deleteCourse
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
        Me.TxtBoxCourseCode = New System.Windows.Forms.TextBox()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtBoxCourseCode
        '
        Me.TxtBoxCourseCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxCourseCode.Location = New System.Drawing.Point(237, 81)
        Me.TxtBoxCourseCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtBoxCourseCode.Name = "TxtBoxCourseCode"
        Me.TxtBoxCourseCode.Size = New System.Drawing.Size(145, 30)
        Me.TxtBoxCourseCode.TabIndex = 14
        '
        'btnAddCourse
        '
        Me.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAddCourse.Location = New System.Drawing.Point(237, 175)
        Me.btnAddCourse.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(145, 44)
        Me.btnAddCourse.TabIndex = 13
        Me.btnAddCourse.Text = "Delete"
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 24)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Course ID :"
        '
        'deleteCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(509, 331)
        Me.Controls.Add(Me.TxtBoxCourseCode)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "deleteCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Course"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtBoxCourseCode As TextBox
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents Label1 As Label
End Class
