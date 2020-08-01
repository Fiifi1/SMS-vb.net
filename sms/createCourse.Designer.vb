<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class createCourse
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.TxtBoxCourseCode = New System.Windows.Forms.TextBox()
        Me.txtBoxCourseTitle = New System.Windows.Forms.TextBox()
        Me.upDownCreditHours = New System.Windows.Forms.NumericUpDown()
        CType(Me.upDownCreditHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Course Code :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Credit Hours :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course Title :"
        '
        'btnAddCourse
        '
        Me.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAddCourse.Location = New System.Drawing.Point(194, 309)
        Me.btnAddCourse.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(155, 55)
        Me.btnAddCourse.TabIndex = 10
        Me.btnAddCourse.Text = "Create Course"
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'TxtBoxCourseCode
        '
        Me.TxtBoxCourseCode.Location = New System.Drawing.Point(194, 37)
        Me.TxtBoxCourseCode.Name = "TxtBoxCourseCode"
        Me.TxtBoxCourseCode.Size = New System.Drawing.Size(117, 30)
        Me.TxtBoxCourseCode.TabIndex = 11
        '
        'txtBoxCourseTitle
        '
        Me.txtBoxCourseTitle.Location = New System.Drawing.Point(194, 174)
        Me.txtBoxCourseTitle.Multiline = True
        Me.txtBoxCourseTitle.Name = "txtBoxCourseTitle"
        Me.txtBoxCourseTitle.Size = New System.Drawing.Size(241, 73)
        Me.txtBoxCourseTitle.TabIndex = 12
        '
        'upDownCreditHours
        '
        Me.upDownCreditHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.upDownCreditHours.Location = New System.Drawing.Point(194, 96)
        Me.upDownCreditHours.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.upDownCreditHours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upDownCreditHours.Name = "upDownCreditHours"
        Me.upDownCreditHours.Size = New System.Drawing.Size(117, 30)
        Me.upDownCreditHours.TabIndex = 13
        Me.upDownCreditHours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'createCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(481, 423)
        Me.Controls.Add(Me.upDownCreditHours)
        Me.Controls.Add(Me.txtBoxCourseTitle)
        Me.Controls.Add(Me.TxtBoxCourseCode)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "createCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Course"
        CType(Me.upDownCreditHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents TxtBoxCourseCode As TextBox
    Friend WithEvents txtBoxCourseTitle As TextBox
    Friend WithEvents upDownCreditHours As NumericUpDown
End Class
