<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addScore
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
        Me.TextBoxStudentID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.comboBoxCourses = New System.Windows.Forms.ComboBox()
        Me.upDownScore = New System.Windows.Forms.NumericUpDown()
        Me.txtBoxRemarks = New System.Windows.Forms.TextBox()
        Me.btnAddScore = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewStudent = New System.Windows.Forms.DataGridView()
        CType(Me.upDownScore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBoxStudentID
        '
        Me.TextBoxStudentID.Location = New System.Drawing.Point(538, 13)
        Me.TextBoxStudentID.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxStudentID.Name = "TextBoxStudentID"
        Me.TextBoxStudentID.ReadOnly = True
        Me.TextBoxStudentID.Size = New System.Drawing.Size(300, 27)
        Me.TextBoxStudentID.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 13)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Student ID :"
        '
        'comboBoxCourses
        '
        Me.comboBoxCourses.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comboBoxCourses.FormattingEnabled = True
        Me.comboBoxCourses.Location = New System.Drawing.Point(538, 67)
        Me.comboBoxCourses.Margin = New System.Windows.Forms.Padding(4)
        Me.comboBoxCourses.Name = "comboBoxCourses"
        Me.comboBoxCourses.Size = New System.Drawing.Size(300, 30)
        Me.comboBoxCourses.TabIndex = 30
        '
        'upDownScore
        '
        Me.upDownScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.upDownScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upDownScore.Location = New System.Drawing.Point(538, 116)
        Me.upDownScore.Margin = New System.Windows.Forms.Padding(4)
        Me.upDownScore.Name = "upDownScore"
        Me.upDownScore.Size = New System.Drawing.Size(300, 30)
        Me.upDownScore.TabIndex = 29
        '
        'txtBoxRemarks
        '
        Me.txtBoxRemarks.Location = New System.Drawing.Point(538, 187)
        Me.txtBoxRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBoxRemarks.Multiline = True
        Me.txtBoxRemarks.Name = "txtBoxRemarks"
        Me.txtBoxRemarks.Size = New System.Drawing.Size(300, 82)
        Me.txtBoxRemarks.TabIndex = 28
        '
        'btnAddScore
        '
        Me.btnAddScore.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddScore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddScore.ForeColor = System.Drawing.SystemColors.WindowText
        Me.btnAddScore.Location = New System.Drawing.Point(538, 321)
        Me.btnAddScore.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.btnAddScore.Name = "btnAddScore"
        Me.btnAddScore.Size = New System.Drawing.Size(146, 46)
        Me.btnAddScore.TabIndex = 27
        Me.btnAddScore.Text = "Add Score"
        Me.btnAddScore.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(428, 178)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Remarks :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 122)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Score :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(397, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Course Code :"
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
        Me.DataGridViewStudent.Size = New System.Drawing.Size(378, 470)
        Me.DataGridViewStudent.TabIndex = 33
        '
        'addScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(855, 494)
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
        Me.Name = "addScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Set Score"
        CType(Me.upDownScore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxStudentID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents comboBoxCourses As ComboBox
    Friend WithEvents upDownScore As NumericUpDown
    Friend WithEvents txtBoxRemarks As TextBox
    Friend WithEvents btnAddScore As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridViewStudent As DataGridView
End Class
