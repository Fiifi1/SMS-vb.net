<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentList
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
        Me.components = New System.ComponentModel.Container()
        Me.stdListView = New System.Windows.Forms.DataGridView()
        Me.refreshStdListBtn = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        CType(Me.stdListView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stdListView
        '
        Me.stdListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.stdListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stdListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.stdListView.Location = New System.Drawing.Point(0, 0)
        Me.stdListView.Margin = New System.Windows.Forms.Padding(4)
        Me.stdListView.Name = "stdListView"
        Me.stdListView.Size = New System.Drawing.Size(1297, 811)
        Me.stdListView.TabIndex = 0
        '
        'refreshStdListBtn
        '
        Me.refreshStdListBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.refreshStdListBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshStdListBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.refreshStdListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.refreshStdListBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshStdListBtn.ForeColor = System.Drawing.SystemColors.WindowText
        Me.refreshStdListBtn.Location = New System.Drawing.Point(0, 765)
        Me.refreshStdListBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.refreshStdListBtn.Name = "refreshStdListBtn"
        Me.refreshStdListBtn.Size = New System.Drawing.Size(1297, 46)
        Me.refreshStdListBtn.TabIndex = 19
        Me.refreshStdListBtn.Text = "Reload"
        Me.refreshStdListBtn.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'studentList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 811)
        Me.Controls.Add(Me.refreshStdListBtn)
        Me.Controls.Add(Me.stdListView)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "studentList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "All Students"
        CType(Me.stdListView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents stdListView As DataGridView
    Friend WithEvents refreshStdListBtn As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
