<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageScore
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
        Me.DataGridViewStudent = New System.Windows.Forms.DataGridView()
        Me.TextBoxStudentID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboBoxCourses = New System.Windows.Forms.ComboBox()
        Me.upDownScore = New System.Windows.Forms.NumericUpDown()
        Me.txtBoxRemarks = New System.Windows.Forms.TextBox()
        Me.btnAddScore = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addStdBtn = New System.Windows.Forms.Button()
        Me.btnDelScore = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.meanScoreBtn = New System.Windows.Forms.Button()
        CType(Me.DataGridViewStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.upDownScore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewStudent
        '
        Me.DataGridViewStudent.AllowUserToAddRows = False
        Me.DataGridViewStudent.AllowUserToDeleteRows = False
        Me.DataGridViewStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewStudent.Location = New System.Drawing.Point(12, 12)
        Me.DataGridViewStudent.Name = "DataGridViewStudent"
        Me.DataGridViewStudent.RowTemplate.Height = 24
        Me.DataGridViewStudent.Size = New System.Drawing.Size(690, 690)
        Me.DataGridViewStudent.TabIndex = 43
        '
        'TextBoxStudentID
        '
        Me.TextBoxStudentID.Location = New System.Drawing.Point(884, 122)
        Me.TextBoxStudentID.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxStudentID.Name = "TextBoxStudentID"
        Me.TextBoxStudentID.ReadOnly = True
        Me.TextBoxStudentID.Size = New System.Drawing.Size(146, 27)
        Me.TextBoxStudentID.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(762, 129)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Student ID :"
        '
        'comboBoxCourses
        '
        Me.comboBoxCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxCourses.FormattingEnabled = True
        Me.comboBoxCourses.Location = New System.Drawing.Point(884, 183)
        Me.comboBoxCourses.Margin = New System.Windows.Forms.Padding(4)
        Me.comboBoxCourses.Name = "comboBoxCourses"
        Me.comboBoxCourses.Size = New System.Drawing.Size(262, 30)
        Me.comboBoxCourses.TabIndex = 40
        '
        'upDownScore
        '
        Me.upDownScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.upDownScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upDownScore.Location = New System.Drawing.Point(884, 232)
        Me.upDownScore.Margin = New System.Windows.Forms.Padding(4)
        Me.upDownScore.Name = "upDownScore"
        Me.upDownScore.Size = New System.Drawing.Size(88, 30)
        Me.upDownScore.TabIndex = 39
        '
        'txtBoxRemarks
        '
        Me.txtBoxRemarks.Location = New System.Drawing.Point(884, 303)
        Me.txtBoxRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxRemarks.Multiline = True
        Me.txtBoxRemarks.Name = "txtBoxRemarks"
        Me.txtBoxRemarks.Size = New System.Drawing.Size(262, 82)
        Me.txtBoxRemarks.TabIndex = 38
        '
        'btnAddScore
        '
        Me.btnAddScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddScore.ForeColor = System.Drawing.SystemColors.Window
        Me.btnAddScore.Location = New System.Drawing.Point(801, 436)
        Me.btnAddScore.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnAddScore.Name = "btnAddScore"
        Me.btnAddScore.Size = New System.Drawing.Size(163, 46)
        Me.btnAddScore.TabIndex = 37
        Me.btnAddScore.Text = "Add Score"
        Me.btnAddScore.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(774, 294)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Remarks :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(797, 238)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Score :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(743, 183)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Course Code :"
        '
        'addStdBtn
        '
        Me.addStdBtn.BackColor = System.Drawing.Color.LightGray
        Me.addStdBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addStdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStdBtn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.addStdBtn.Location = New System.Drawing.Point(974, 15)
        Me.addStdBtn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.addStdBtn.Name = "addStdBtn"
        Me.addStdBtn.Size = New System.Drawing.Size(172, 29)
        Me.addStdBtn.TabIndex = 44
        Me.addStdBtn.Text = "Show Scores"
        Me.addStdBtn.UseVisualStyleBackColor = False
        '
        'btnDelScore
        '
        Me.btnDelScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnDelScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelScore.ForeColor = System.Drawing.SystemColors.Info
        Me.btnDelScore.Location = New System.Drawing.Point(974, 436)
        Me.btnDelScore.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnDelScore.Name = "btnDelScore"
        Me.btnDelScore.Size = New System.Drawing.Size(172, 46)
        Me.btnDelScore.TabIndex = 45
        Me.btnDelScore.Text = "Delete Score"
        Me.btnDelScore.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightGray
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Button2.Location = New System.Drawing.Point(789, 15)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 29)
        Me.Button2.TabIndex = 46
        Me.Button2.Text = "Show Students"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(798, 684)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(329, 18)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Wish to Edit Score? Delete and Go ahead to Add"
        '
        'meanScoreBtn
        '
        Me.meanScoreBtn.BackColor = System.Drawing.Color.DarkGray
        Me.meanScoreBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.meanScoreBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.meanScoreBtn.ForeColor = System.Drawing.SystemColors.Window
        Me.meanScoreBtn.Location = New System.Drawing.Point(884, 620)
        Me.meanScoreBtn.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.meanScoreBtn.Name = "meanScoreBtn"
        Me.meanScoreBtn.Size = New System.Drawing.Size(163, 46)
        Me.meanScoreBtn.TabIndex = 48
        Me.meanScoreBtn.Text = "Mean Score"
        Me.meanScoreBtn.UseVisualStyleBackColor = False
        '
        'manageScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1186, 714)
        Me.Controls.Add(Me.meanScoreBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnDelScore)
        Me.Controls.Add(Me.addStdBtn)
        Me.Controls.Add(Me.DataGridViewStudent)
        Me.Controls.Add(Me.TextBoxStudentID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.comboBoxCourses)
        Me.Controls.Add(Me.upDownScore)
        Me.Controls.Add(Me.txtBoxRemarks)
        Me.Controls.Add(Me.btnAddScore)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "manageScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Score Management"
        CType(Me.DataGridViewStudent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.upDownScore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewStudent As DataGridView
    Friend WithEvents TextBoxStudentID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents comboBoxCourses As ComboBox
    Friend WithEvents upDownScore As NumericUpDown
    Friend WithEvents txtBoxRemarks As TextBox
    Friend WithEvents btnAddScore As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents addStdBtn As Button
    Friend WithEvents btnDelScore As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents meanScoreBtn As Button
End Class
