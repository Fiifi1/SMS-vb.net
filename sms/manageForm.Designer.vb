<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manageForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtBoxSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.totalStudentLabel = New System.Windows.Forms.Label()
        Me.BtnResetStudent = New System.Windows.Forms.Button()
        Me.BtnDelStd = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.femaleRadBtn = New System.Windows.Forms.RadioButton()
        Me.maleRadBtn = New System.Windows.Forms.RadioButton()
        Me.BtnUpdateStudent = New System.Windows.Forms.Button()
        Me.btnAddStudent = New System.Windows.Forms.Button()
        Me.addImageBbtn = New System.Windows.Forms.Button()
        Me.PicBox = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.contactGroup = New System.Windows.Forms.GroupBox()
        Me.addrBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.phoneBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.infoGroup = New System.Windows.Forms.GroupBox()
        Me.IDTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.bdayBox = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.surnameBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fnameBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stdListView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contactGroup.SuspendLayout()
        Me.infoGroup.SuspendLayout()
        CType(Me.stdListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TxtBoxSearch)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.totalStudentLabel)
        Me.GroupBox1.Controls.Add(Me.BtnResetStudent)
        Me.GroupBox1.Controls.Add(Me.BtnDelStd)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.BtnUpdateStudent)
        Me.GroupBox1.Controls.Add(Me.btnAddStudent)
        Me.GroupBox1.Controls.Add(Me.addImageBbtn)
        Me.GroupBox1.Controls.Add(Me.PicBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.contactGroup)
        Me.GroupBox1.Controls.Add(Me.infoGroup)
        Me.GroupBox1.Controls.Add(Me.stdListView)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1782, 840)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Navy
        Me.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.Window
        Me.btnSearch.Location = New System.Drawing.Point(533, 50)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(159, 41)
        Me.btnSearch.TabIndex = 58
        Me.btnSearch.Text = "Find"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1588, 789)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 33)
        Me.Button1.TabIndex = 59
        Me.Button1.Text = "Save Image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TxtBoxSearch
        '
        Me.TxtBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxSearch.Location = New System.Drawing.Point(209, 56)
        Me.TxtBoxSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBoxSearch.Name = "TxtBoxSearch"
        Me.TxtBoxSearch.Size = New System.Drawing.Size(316, 28)
        Me.TxtBoxSearch.TabIndex = 57
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 56)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(165, 24)
        Me.Label9.TabIndex = 56
        Me.Label9.Text = "Enter Search Item:"
        '
        'totalStudentLabel
        '
        Me.totalStudentLabel.BackColor = System.Drawing.Color.DarkGray
        Me.totalStudentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalStudentLabel.ForeColor = System.Drawing.SystemColors.Control
        Me.totalStudentLabel.Location = New System.Drawing.Point(31, 761)
        Me.totalStudentLabel.Name = "totalStudentLabel"
        Me.totalStudentLabel.Size = New System.Drawing.Size(131, 35)
        Me.totalStudentLabel.TabIndex = 55
        Me.totalStudentLabel.Text = "Total : "
        Me.totalStudentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnResetStudent
        '
        Me.BtnResetStudent.BackColor = System.Drawing.Color.DarkGray
        Me.BtnResetStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnResetStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnResetStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResetStudent.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnResetStudent.Location = New System.Drawing.Point(867, 775)
        Me.BtnResetStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnResetStudent.Name = "BtnResetStudent"
        Me.BtnResetStudent.Size = New System.Drawing.Size(138, 47)
        Me.BtnResetStudent.TabIndex = 54
        Me.BtnResetStudent.Text = "Default Form"
        Me.BtnResetStudent.UseVisualStyleBackColor = False
        '
        'BtnDelStd
        '
        Me.BtnDelStd.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDelStd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelStd.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelStd.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnDelStd.Location = New System.Drawing.Point(1047, 775)
        Me.BtnDelStd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelStd.Name = "BtnDelStd"
        Me.BtnDelStd.Size = New System.Drawing.Size(138, 47)
        Me.BtnDelStd.TabIndex = 53
        Me.BtnDelStd.Text = "Delete"
        Me.BtnDelStd.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.femaleRadBtn)
        Me.GroupBox2.Controls.Add(Me.maleRadBtn)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(1229, 555)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(146, 102)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Gender"
        '
        'femaleRadBtn
        '
        Me.femaleRadBtn.AutoSize = True
        Me.femaleRadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femaleRadBtn.Location = New System.Drawing.Point(8, 58)
        Me.femaleRadBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.femaleRadBtn.Name = "femaleRadBtn"
        Me.femaleRadBtn.Size = New System.Drawing.Size(95, 28)
        Me.femaleRadBtn.TabIndex = 16
        Me.femaleRadBtn.TabStop = True
        Me.femaleRadBtn.Text = "Female"
        Me.femaleRadBtn.UseVisualStyleBackColor = True
        '
        'maleRadBtn
        '
        Me.maleRadBtn.AutoSize = True
        Me.maleRadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maleRadBtn.Location = New System.Drawing.Point(7, 22)
        Me.maleRadBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.maleRadBtn.Name = "maleRadBtn"
        Me.maleRadBtn.Size = New System.Drawing.Size(72, 28)
        Me.maleRadBtn.TabIndex = 15
        Me.maleRadBtn.TabStop = True
        Me.maleRadBtn.Text = "Male"
        Me.maleRadBtn.UseVisualStyleBackColor = True
        '
        'BtnUpdateStudent
        '
        Me.BtnUpdateStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnUpdateStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdateStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUpdateStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateStudent.ForeColor = System.Drawing.SystemColors.Control
        Me.BtnUpdateStudent.Location = New System.Drawing.Point(1229, 775)
        Me.BtnUpdateStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdateStudent.Name = "BtnUpdateStudent"
        Me.BtnUpdateStudent.Size = New System.Drawing.Size(138, 47)
        Me.BtnUpdateStudent.TabIndex = 51
        Me.BtnUpdateStudent.Text = "Update Info"
        Me.BtnUpdateStudent.UseVisualStyleBackColor = False
        '
        'btnAddStudent
        '
        Me.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAddStudent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddStudent.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddStudent.ForeColor = System.Drawing.SystemColors.Control
        Me.btnAddStudent.Location = New System.Drawing.Point(1229, 683)
        Me.btnAddStudent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddStudent.Name = "btnAddStudent"
        Me.btnAddStudent.Size = New System.Drawing.Size(138, 47)
        Me.btnAddStudent.TabIndex = 50
        Me.btnAddStudent.Text = "Add student"
        Me.btnAddStudent.UseVisualStyleBackColor = False
        '
        'addImageBbtn
        '
        Me.addImageBbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addImageBbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addImageBbtn.Location = New System.Drawing.Point(1443, 789)
        Me.addImageBbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.addImageBbtn.Name = "addImageBbtn"
        Me.addImageBbtn.Size = New System.Drawing.Size(137, 33)
        Me.addImageBbtn.TabIndex = 49
        Me.addImageBbtn.Text = "Upload Image"
        Me.addImageBbtn.UseVisualStyleBackColor = True
        '
        'PicBox
        '
        Me.PicBox.BackColor = System.Drawing.Color.LightCyan
        Me.PicBox.Location = New System.Drawing.Point(1443, 555)
        Me.PicBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PicBox.Name = "PicBox"
        Me.PicBox.Size = New System.Drawing.Size(274, 226)
        Me.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicBox.TabIndex = 48
        Me.PicBox.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1527, 527)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Profile Photo"
        '
        'contactGroup
        '
        Me.contactGroup.Controls.Add(Me.addrBox)
        Me.contactGroup.Controls.Add(Me.Label5)
        Me.contactGroup.Controls.Add(Me.phoneBox)
        Me.contactGroup.Controls.Add(Me.Label4)
        Me.contactGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactGroup.Location = New System.Drawing.Point(1240, 306)
        Me.contactGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.contactGroup.Name = "contactGroup"
        Me.contactGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.contactGroup.Size = New System.Drawing.Size(477, 209)
        Me.contactGroup.TabIndex = 46
        Me.contactGroup.TabStop = False
        Me.contactGroup.Text = "Contact"
        '
        'addrBox
        '
        Me.addrBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addrBox.Location = New System.Drawing.Point(139, 86)
        Me.addrBox.Margin = New System.Windows.Forms.Padding(4)
        Me.addrBox.Multiline = True
        Me.addrBox.Name = "addrBox"
        Me.addrBox.Size = New System.Drawing.Size(316, 91)
        Me.addrBox.TabIndex = 5
        Me.addrBox.Text = "                                 "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address :"
        '
        'phoneBox
        '
        Me.phoneBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneBox.Location = New System.Drawing.Point(139, 39)
        Me.phoneBox.Margin = New System.Windows.Forms.Padding(4)
        Me.phoneBox.Name = "phoneBox"
        Me.phoneBox.Size = New System.Drawing.Size(316, 26)
        Me.phoneBox.TabIndex = 3
        Me.phoneBox.Text = "                                 "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 41)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Mobile :"
        '
        'infoGroup
        '
        Me.infoGroup.Controls.Add(Me.IDTxtBox)
        Me.infoGroup.Controls.Add(Me.Label7)
        Me.infoGroup.Controls.Add(Me.bdayBox)
        Me.infoGroup.Controls.Add(Me.Label3)
        Me.infoGroup.Controls.Add(Me.surnameBox)
        Me.infoGroup.Controls.Add(Me.Label2)
        Me.infoGroup.Controls.Add(Me.fnameBox)
        Me.infoGroup.Controls.Add(Me.Label1)
        Me.infoGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoGroup.Location = New System.Drawing.Point(1240, 38)
        Me.infoGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.infoGroup.Name = "infoGroup"
        Me.infoGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.infoGroup.Size = New System.Drawing.Size(477, 244)
        Me.infoGroup.TabIndex = 45
        Me.infoGroup.TabStop = False
        Me.infoGroup.Text = "Info"
        '
        'IDTxtBox
        '
        Me.IDTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTxtBox.Location = New System.Drawing.Point(139, 44)
        Me.IDTxtBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IDTxtBox.Name = "IDTxtBox"
        Me.IDTxtBox.Size = New System.Drawing.Size(316, 26)
        Me.IDTxtBox.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 46)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "ID :"
        '
        'bdayBox
        '
        Me.bdayBox.CustomFormat = "dd/MM/yyyy"
        Me.bdayBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdayBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.bdayBox.Location = New System.Drawing.Point(139, 204)
        Me.bdayBox.Margin = New System.Windows.Forms.Padding(4)
        Me.bdayBox.Name = "bdayBox"
        Me.bdayBox.Size = New System.Drawing.Size(316, 26)
        Me.bdayBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 204)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date of Birth :"
        '
        'surnameBox
        '
        Me.surnameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surnameBox.Location = New System.Drawing.Point(139, 149)
        Me.surnameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.surnameBox.Name = "surnameBox"
        Me.surnameBox.Size = New System.Drawing.Size(316, 26)
        Me.surnameBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 149)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surname :"
        '
        'fnameBox
        '
        Me.fnameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnameBox.Location = New System.Drawing.Point(139, 94)
        Me.fnameBox.Margin = New System.Windows.Forms.Padding(4)
        Me.fnameBox.Name = "fnameBox"
        Me.fnameBox.Size = New System.Drawing.Size(316, 26)
        Me.fnameBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name :"
        '
        'stdListView
        '
        Me.stdListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.stdListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stdListView.Location = New System.Drawing.Point(35, 105)
        Me.stdListView.Margin = New System.Windows.Forms.Padding(4)
        Me.stdListView.Name = "stdListView"
        Me.stdListView.Size = New System.Drawing.Size(1150, 652)
        Me.stdListView.TabIndex = 44
        '
        'manageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1782, 840)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimumSize = New System.Drawing.Size(1800, 887)
        Me.Name = "manageForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Students"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contactGroup.ResumeLayout(False)
        Me.contactGroup.PerformLayout()
        Me.infoGroup.ResumeLayout(False)
        Me.infoGroup.PerformLayout()
        CType(Me.stdListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtBoxSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents totalStudentLabel As Label
    Friend WithEvents BtnResetStudent As Button
    Friend WithEvents BtnDelStd As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents femaleRadBtn As RadioButton
    Friend WithEvents maleRadBtn As RadioButton
    Friend WithEvents BtnUpdateStudent As Button
    Friend WithEvents btnAddStudent As Button
    Friend WithEvents addImageBbtn As Button
    Friend WithEvents PicBox As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents contactGroup As GroupBox
    Friend WithEvents addrBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents phoneBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents infoGroup As GroupBox
    Friend WithEvents IDTxtBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents bdayBox As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents surnameBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fnameBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents stdListView As DataGridView
End Class
