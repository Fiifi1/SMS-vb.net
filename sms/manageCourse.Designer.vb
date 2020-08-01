<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageCourse
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
        Me.TextBoxCourseCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxCourseTitle = New System.Windows.Forms.TextBox()
        Me.btnEditCourse = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.listboxCourses = New System.Windows.Forms.ListBox()
        Me.btnDelCourse = New System.Windows.Forms.Button()
        Me.btnAddCourse = New System.Windows.Forms.Button()
        Me.totalCourseLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBoxCourseID = New System.Windows.Forms.TextBox()
        Me.upDownCreditHours = New System.Windows.Forms.NumericUpDown()
        CType(Me.upDownCreditHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxCourseCode
        '
        Me.TextBoxCourseCode.Location = New System.Drawing.Point(618, 96)
        Me.TextBoxCourseCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCourseCode.Name = "TextBoxCourseCode"
        Me.TextBoxCourseCode.Size = New System.Drawing.Size(300, 27)
        Me.TextBoxCourseCode.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 96)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Course Code (Edit) :"
        '
        'txtBoxCourseTitle
        '
        Me.txtBoxCourseTitle.Location = New System.Drawing.Point(618, 163)
        Me.txtBoxCourseTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxCourseTitle.Multiline = True
        Me.txtBoxCourseTitle.Name = "txtBoxCourseTitle"
        Me.txtBoxCourseTitle.Size = New System.Drawing.Size(300, 75)
        Me.txtBoxCourseTitle.TabIndex = 28
        '
        'btnEditCourse
        '
        Me.btnEditCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnEditCourse.Location = New System.Drawing.Point(636, 444)
        Me.btnEditCourse.Margin = New System.Windows.Forms.Padding(5)
        Me.btnEditCourse.Name = "btnEditCourse"
        Me.btnEditCourse.Size = New System.Drawing.Size(127, 42)
        Me.btnEditCourse.TabIndex = 27
        Me.btnEditCourse.Text = "Update"
        Me.btnEditCourse.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(471, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Course Title :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(467, 273)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Credit Hours :"
        '
        'listboxCourses
        '
        Me.listboxCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listboxCourses.FormattingEnabled = True
        Me.listboxCourses.ItemHeight = 25
        Me.listboxCourses.Location = New System.Drawing.Point(44, 30)
        Me.listboxCourses.Name = "listboxCourses"
        Me.listboxCourses.Size = New System.Drawing.Size(334, 454)
        Me.listboxCourses.TabIndex = 33
        '
        'btnDelCourse
        '
        Me.btnDelCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnDelCourse.Location = New System.Drawing.Point(796, 444)
        Me.btnDelCourse.Margin = New System.Windows.Forms.Padding(5)
        Me.btnDelCourse.Name = "btnDelCourse"
        Me.btnDelCourse.Size = New System.Drawing.Size(122, 42)
        Me.btnDelCourse.TabIndex = 34
        Me.btnDelCourse.Text = "Delete"
        Me.btnDelCourse.UseVisualStyleBackColor = False
        '
        'btnAddCourse
        '
        Me.btnAddCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAddCourse.Location = New System.Drawing.Point(464, 444)
        Me.btnAddCourse.Margin = New System.Windows.Forms.Padding(5)
        Me.btnAddCourse.Name = "btnAddCourse"
        Me.btnAddCourse.Size = New System.Drawing.Size(128, 42)
        Me.btnAddCourse.TabIndex = 35
        Me.btnAddCourse.Text = "Create"
        Me.btnAddCourse.UseVisualStyleBackColor = False
        '
        'totalCourseLabel
        '
        Me.totalCourseLabel.BackColor = System.Drawing.Color.White
        Me.totalCourseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalCourseLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.totalCourseLabel.Location = New System.Drawing.Point(247, 496)
        Me.totalCourseLabel.Name = "totalCourseLabel"
        Me.totalCourseLabel.Size = New System.Drawing.Size(131, 32)
        Me.totalCourseLabel.TabIndex = 57
        Me.totalCourseLabel.Text = "Total : "
        Me.totalCourseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(489, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Course ID :"
        '
        'txtBoxCourseID
        '
        Me.txtBoxCourseID.Location = New System.Drawing.Point(618, 30)
        Me.txtBoxCourseID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxCourseID.Name = "txtBoxCourseID"
        Me.txtBoxCourseID.Size = New System.Drawing.Size(80, 27)
        Me.txtBoxCourseID.TabIndex = 59
        '
        'upDownCreditHours
        '
        Me.upDownCreditHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.upDownCreditHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upDownCreditHours.Location = New System.Drawing.Point(618, 273)
        Me.upDownCreditHours.Margin = New System.Windows.Forms.Padding(4)
        Me.upDownCreditHours.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.upDownCreditHours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upDownCreditHours.Name = "upDownCreditHours"
        Me.upDownCreditHours.Size = New System.Drawing.Size(300, 30)
        Me.upDownCreditHours.TabIndex = 29
        Me.upDownCreditHours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'manageCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(978, 541)
        Me.Controls.Add(Me.txtBoxCourseID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.totalCourseLabel)
        Me.Controls.Add(Me.btnAddCourse)
        Me.Controls.Add(Me.btnDelCourse)
        Me.Controls.Add(Me.listboxCourses)
        Me.Controls.Add(Me.TextBoxCourseCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.upDownCreditHours)
        Me.Controls.Add(Me.txtBoxCourseTitle)
        Me.Controls.Add(Me.btnEditCourse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "manageCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Courses"
        CType(Me.upDownCreditHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxCourseCode As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxCourseTitle As TextBox
    Friend WithEvents btnEditCourse As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents listboxCourses As ListBox
    Friend WithEvents btnDelCourse As Button
    Friend WithEvents btnAddCourse As Button
    Friend WithEvents totalCourseLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBoxCourseID As TextBox
    Friend WithEvents upDownCreditHours As NumericUpDown
End Class
