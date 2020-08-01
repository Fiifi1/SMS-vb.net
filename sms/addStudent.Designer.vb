<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addStudent
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
        Me.infoGroup = New System.Windows.Forms.GroupBox()
        Me.addStdDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.surTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fnameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contactGroup = New System.Windows.Forms.GroupBox()
        Me.addressTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mobTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.maleRadBtn = New System.Windows.Forms.RadioButton()
        Me.femaleRadBtn = New System.Windows.Forms.RadioButton()
        Me.uploadImgBtn = New System.Windows.Forms.Button()
        Me.cancelAddStdBtn = New System.Windows.Forms.Button()
        Me.addStdBtn = New System.Windows.Forms.Button()
        Me.stdPicBox = New System.Windows.Forms.PictureBox()
        Me.infoGroup.SuspendLayout()
        Me.contactGroup.SuspendLayout()
        CType(Me.stdPicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'infoGroup
        '
        Me.infoGroup.Controls.Add(Me.addStdDate)
        Me.infoGroup.Controls.Add(Me.Label3)
        Me.infoGroup.Controls.Add(Me.surTxtBox)
        Me.infoGroup.Controls.Add(Me.Label2)
        Me.infoGroup.Controls.Add(Me.fnameTxtBox)
        Me.infoGroup.Controls.Add(Me.Label1)
        Me.infoGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoGroup.Location = New System.Drawing.Point(16, 15)
        Me.infoGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.infoGroup.Name = "infoGroup"
        Me.infoGroup.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.infoGroup.Size = New System.Drawing.Size(613, 214)
        Me.infoGroup.TabIndex = 0
        Me.infoGroup.TabStop = False
        Me.infoGroup.Text = "Info"
        '
        'addStdDate
        '
        Me.addStdDate.CustomFormat = "dd/MM/yyyy"
        Me.addStdDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStdDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.addStdDate.Location = New System.Drawing.Point(229, 159)
        Me.addStdDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addStdDate.Name = "addStdDate"
        Me.addStdDate.Size = New System.Drawing.Size(316, 26)
        Me.addStdDate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 162)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date of Birth :"
        '
        'surTxtBox
        '
        Me.surTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surTxtBox.Location = New System.Drawing.Point(229, 100)
        Me.surTxtBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.surTxtBox.Name = "surTxtBox"
        Me.surTxtBox.Size = New System.Drawing.Size(316, 26)
        Me.surTxtBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 105)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Surname :"
        '
        'fnameTxtBox
        '
        Me.fnameTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnameTxtBox.Location = New System.Drawing.Point(229, 33)
        Me.fnameTxtBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.fnameTxtBox.Name = "fnameTxtBox"
        Me.fnameTxtBox.Size = New System.Drawing.Size(316, 26)
        Me.fnameTxtBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name :"
        '
        'contactGroup
        '
        Me.contactGroup.Controls.Add(Me.addressTxtBox)
        Me.contactGroup.Controls.Add(Me.Label5)
        Me.contactGroup.Controls.Add(Me.mobTxtBox)
        Me.contactGroup.Controls.Add(Me.Label4)
        Me.contactGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactGroup.Location = New System.Drawing.Point(16, 255)
        Me.contactGroup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.contactGroup.Name = "contactGroup"
        Me.contactGroup.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.contactGroup.Size = New System.Drawing.Size(613, 209)
        Me.contactGroup.TabIndex = 1
        Me.contactGroup.TabStop = False
        Me.contactGroup.Text = "Contact"
        '
        'addressTxtBox
        '
        Me.addressTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTxtBox.Location = New System.Drawing.Point(229, 86)
        Me.addressTxtBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addressTxtBox.Multiline = True
        Me.addressTxtBox.Name = "addressTxtBox"
        Me.addressTxtBox.Size = New System.Drawing.Size(316, 91)
        Me.addressTxtBox.TabIndex = 0
        Me.addressTxtBox.Text = "                                 "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(68, 86)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Address :"
        '
        'mobTxtBox
        '
        Me.mobTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobTxtBox.Location = New System.Drawing.Point(229, 28)
        Me.mobTxtBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mobTxtBox.Name = "mobTxtBox"
        Me.mobTxtBox.Size = New System.Drawing.Size(316, 26)
        Me.mobTxtBox.TabIndex = 0
        Me.mobTxtBox.Text = "                                 "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 24)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Mobile :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(89, 468)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 24)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Profile Photo"
        '
        'maleRadBtn
        '
        Me.maleRadBtn.AutoSize = True
        Me.maleRadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maleRadBtn.Location = New System.Drawing.Point(447, 494)
        Me.maleRadBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.maleRadBtn.Name = "maleRadBtn"
        Me.maleRadBtn.Size = New System.Drawing.Size(72, 28)
        Me.maleRadBtn.TabIndex = 6
        Me.maleRadBtn.TabStop = True
        Me.maleRadBtn.Text = "Male"
        Me.maleRadBtn.UseVisualStyleBackColor = True
        '
        'femaleRadBtn
        '
        Me.femaleRadBtn.AutoSize = True
        Me.femaleRadBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femaleRadBtn.Location = New System.Drawing.Point(447, 528)
        Me.femaleRadBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.femaleRadBtn.Name = "femaleRadBtn"
        Me.femaleRadBtn.Size = New System.Drawing.Size(95, 28)
        Me.femaleRadBtn.TabIndex = 7
        Me.femaleRadBtn.TabStop = True
        Me.femaleRadBtn.Text = "Female"
        Me.femaleRadBtn.UseVisualStyleBackColor = True
        '
        'uploadImgBtn
        '
        Me.uploadImgBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uploadImgBtn.Location = New System.Drawing.Point(16, 727)
        Me.uploadImgBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.uploadImgBtn.Name = "uploadImgBtn"
        Me.uploadImgBtn.Size = New System.Drawing.Size(295, 33)
        Me.uploadImgBtn.TabIndex = 8
        Me.uploadImgBtn.Text = "Add Image"
        Me.uploadImgBtn.UseVisualStyleBackColor = True
        '
        'cancelAddStdBtn
        '
        Me.cancelAddStdBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cancelAddStdBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelAddStdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelAddStdBtn.Location = New System.Drawing.Point(447, 699)
        Me.cancelAddStdBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cancelAddStdBtn.Name = "cancelAddStdBtn"
        Me.cancelAddStdBtn.Size = New System.Drawing.Size(157, 62)
        Me.cancelAddStdBtn.TabIndex = 10
        Me.cancelAddStdBtn.Text = "Cancel"
        Me.cancelAddStdBtn.UseVisualStyleBackColor = False
        '
        'addStdBtn
        '
        Me.addStdBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.addStdBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addStdBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStdBtn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.addStdBtn.Location = New System.Drawing.Point(447, 602)
        Me.addStdBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.addStdBtn.Name = "addStdBtn"
        Me.addStdBtn.Size = New System.Drawing.Size(157, 62)
        Me.addStdBtn.TabIndex = 9
        Me.addStdBtn.Text = "Create"
        Me.addStdBtn.UseVisualStyleBackColor = False
        '
        'stdPicBox
        '
        Me.stdPicBox.BackColor = System.Drawing.Color.LightCyan
        Me.stdPicBox.Location = New System.Drawing.Point(16, 494)
        Me.stdPicBox.Margin = New System.Windows.Forms.Padding(4)
        Me.stdPicBox.Name = "stdPicBox"
        Me.stdPicBox.Size = New System.Drawing.Size(295, 226)
        Me.stdPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.stdPicBox.TabIndex = 3
        Me.stdPicBox.TabStop = False
        '
        'addStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(653, 775)
        Me.Controls.Add(Me.cancelAddStdBtn)
        Me.Controls.Add(Me.addStdBtn)
        Me.Controls.Add(Me.uploadImgBtn)
        Me.Controls.Add(Me.femaleRadBtn)
        Me.Controls.Add(Me.maleRadBtn)
        Me.Controls.Add(Me.stdPicBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.contactGroup)
        Me.Controls.Add(Me.infoGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "addStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student"
        Me.infoGroup.ResumeLayout(False)
        Me.infoGroup.PerformLayout()
        Me.contactGroup.ResumeLayout(False)
        Me.contactGroup.PerformLayout()
        CType(Me.stdPicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents infoGroup As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents surTxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fnameTxtBox As TextBox
    Friend WithEvents addStdDate As DateTimePicker
    Friend WithEvents contactGroup As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents mobTxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents stdPicBox As PictureBox
    Friend WithEvents maleRadBtn As RadioButton
    Friend WithEvents femaleRadBtn As RadioButton
    Friend WithEvents uploadImgBtn As Button
    Friend WithEvents cancelAddStdBtn As Button
    Friend WithEvents addStdBtn As Button
    Friend WithEvents addressTxtBox As TextBox
End Class
