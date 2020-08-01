<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editCourse
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
        Me.upDownCreditHours = New System.Windows.Forms.NumericUpDown()
        Me.txtBoxCourseTitle = New System.Windows.Forms.TextBox()
        Me.btnUpdateCourse = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comboBoxCourses = New System.Windows.Forms.ComboBox()
        Me.TextBoxCourseCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.upDownCreditHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'upDownCreditHours
        '
        Me.upDownCreditHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.upDownCreditHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upDownCreditHours.Location = New System.Drawing.Point(275, 295)
        Me.upDownCreditHours.Margin = New System.Windows.Forms.Padding(4)
        Me.upDownCreditHours.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.upDownCreditHours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.upDownCreditHours.Name = "upDownCreditHours"
        Me.upDownCreditHours.Size = New System.Drawing.Size(300, 30)
        Me.upDownCreditHours.TabIndex = 20
        Me.upDownCreditHours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtBoxCourseTitle
        '
        Me.txtBoxCourseTitle.Location = New System.Drawing.Point(275, 173)
        Me.txtBoxCourseTitle.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxCourseTitle.Multiline = True
        Me.txtBoxCourseTitle.Name = "txtBoxCourseTitle"
        Me.txtBoxCourseTitle.Size = New System.Drawing.Size(300, 82)
        Me.txtBoxCourseTitle.TabIndex = 19
        '
        'btnUpdateCourse
        '
        Me.btnUpdateCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnUpdateCourse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateCourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateCourse.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnUpdateCourse.Location = New System.Drawing.Point(275, 386)
        Me.btnUpdateCourse.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnUpdateCourse.Name = "btnUpdateCourse"
        Me.btnUpdateCourse.Size = New System.Drawing.Size(300, 46)
        Me.btnUpdateCourse.TabIndex = 17
        Me.btnUpdateCourse.Text = "Update Course"
        Me.btnUpdateCourse.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(68, 173)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 24)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Course Title :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 295)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 24)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Credit Hours :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 24)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Course Code :"
        '
        'comboBoxCourses
        '
        Me.comboBoxCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxCourses.FormattingEnabled = True
        Me.comboBoxCourses.Location = New System.Drawing.Point(275, 33)
        Me.comboBoxCourses.Margin = New System.Windows.Forms.Padding(4)
        Me.comboBoxCourses.Name = "comboBoxCourses"
        Me.comboBoxCourses.Size = New System.Drawing.Size(300, 30)
        Me.comboBoxCourses.TabIndex = 21
        '
        'TextBoxCourseCode
        '
        Me.TextBoxCourseCode.Location = New System.Drawing.Point(275, 95)
        Me.TextBoxCourseCode.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxCourseCode.Name = "TextBoxCourseCode"
        Me.TextBoxCourseCode.Size = New System.Drawing.Size(300, 28)
        Me.TextBoxCourseCode.TabIndex = 23
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 95)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 24)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Course Code (Edit) :"
        '
        'editCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(650, 488)
        Me.Controls.Add(Me.TextBoxCourseCode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.comboBoxCourses)
        Me.Controls.Add(Me.upDownCreditHours)
        Me.Controls.Add(Me.txtBoxCourseTitle)
        Me.Controls.Add(Me.btnUpdateCourse)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "editCourse"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Course"
        CType(Me.upDownCreditHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents upDownCreditHours As NumericUpDown
    Friend WithEvents txtBoxCourseTitle As TextBox
    Friend WithEvents btnUpdateCourse As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents comboBoxCourses As ComboBox
    Friend WithEvents TextBoxCourseCode As TextBox
    Friend WithEvents Label4 As Label
End Class
