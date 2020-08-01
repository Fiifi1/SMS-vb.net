<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentStatistics
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
        Me.stdTotalPanel = New System.Windows.Forms.Panel()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.FemalePanel = New System.Windows.Forms.Panel()
        Me.LabelFemale = New System.Windows.Forms.Label()
        Me.MalePanel = New System.Windows.Forms.Panel()
        Me.LabelMales = New System.Windows.Forms.Label()
        Me.btnCloseStat = New System.Windows.Forms.Button()
        Me.stdTotalPanel.SuspendLayout()
        Me.FemalePanel.SuspendLayout()
        Me.MalePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'stdTotalPanel
        '
        Me.stdTotalPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.stdTotalPanel.Controls.Add(Me.LabelTotal)
        Me.stdTotalPanel.Location = New System.Drawing.Point(12, 12)
        Me.stdTotalPanel.Name = "stdTotalPanel"
        Me.stdTotalPanel.Size = New System.Drawing.Size(558, 153)
        Me.stdTotalPanel.TabIndex = 0
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(21, 22)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(249, 29)
        Me.LabelTotal.TabIndex = 0
        Me.LabelTotal.Text = "Total Students - 100%"
        '
        'FemalePanel
        '
        Me.FemalePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FemalePanel.Controls.Add(Me.LabelFemale)
        Me.FemalePanel.Location = New System.Drawing.Point(12, 171)
        Me.FemalePanel.Name = "FemalePanel"
        Me.FemalePanel.Size = New System.Drawing.Size(280, 142)
        Me.FemalePanel.TabIndex = 1
        '
        'LabelFemale
        '
        Me.LabelFemale.AutoSize = True
        Me.LabelFemale.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFemale.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelFemale.Location = New System.Drawing.Point(21, 15)
        Me.LabelFemale.Name = "LabelFemale"
        Me.LabelFemale.Size = New System.Drawing.Size(107, 29)
        Me.LabelFemale.TabIndex = 2
        Me.LabelFemale.Text = "Females"
        '
        'MalePanel
        '
        Me.MalePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MalePanel.Controls.Add(Me.LabelMales)
        Me.MalePanel.Location = New System.Drawing.Point(298, 171)
        Me.MalePanel.Name = "MalePanel"
        Me.MalePanel.Size = New System.Drawing.Size(272, 142)
        Me.MalePanel.TabIndex = 2
        '
        'LabelMales
        '
        Me.LabelMales.AutoSize = True
        Me.LabelMales.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMales.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelMales.Location = New System.Drawing.Point(23, 15)
        Me.LabelMales.Name = "LabelMales"
        Me.LabelMales.Size = New System.Drawing.Size(78, 29)
        Me.LabelMales.TabIndex = 1
        Me.LabelMales.Text = "Males"
        '
        'btnCloseStat
        '
        Me.btnCloseStat.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCloseStat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseStat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseStat.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCloseStat.Location = New System.Drawing.Point(12, 319)
        Me.btnCloseStat.Name = "btnCloseStat"
        Me.btnCloseStat.Size = New System.Drawing.Size(558, 34)
        Me.btnCloseStat.TabIndex = 3
        Me.btnCloseStat.Text = "Close"
        Me.btnCloseStat.UseVisualStyleBackColor = False
        '
        'studentStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(584, 365)
        Me.Controls.Add(Me.btnCloseStat)
        Me.Controls.Add(Me.MalePanel)
        Me.Controls.Add(Me.FemalePanel)
        Me.Controls.Add(Me.stdTotalPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "studentStatistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Students Statistics"
        Me.stdTotalPanel.ResumeLayout(False)
        Me.stdTotalPanel.PerformLayout()
        Me.FemalePanel.ResumeLayout(False)
        Me.FemalePanel.PerformLayout()
        Me.MalePanel.ResumeLayout(False)
        Me.MalePanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents stdTotalPanel As Panel
    Friend WithEvents FemalePanel As Panel
    Friend WithEvents MalePanel As Panel
    Friend WithEvents btnCloseStat As Button
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelFemale As Label
    Friend WithEvents LabelMales As Label
End Class
