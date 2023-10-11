<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee_Records
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbladmin = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblcloth = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblwood = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lbluser = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblIT = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblDepartmentCounts = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnCSV = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.NamesDataSet = New BAR.namesDataSet()
        Me.TestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestTableAdapter = New BAR.namesDataSetTableAdapters.testTableAdapter()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NamesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.GroupBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.btnCSV)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DataGridView1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(1, 2)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1479, 808)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Employee Records"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lbladmin)
        Me.GroupBox1.Controls.Add(Me.lblcloth)
        Me.GroupBox1.Controls.Add(Me.lblwood)
        Me.GroupBox1.Controls.Add(Me.lbluser)
        Me.GroupBox1.Controls.Add(Me.lblIT)
        Me.GroupBox1.Controls.Add(Me.lblDepartmentCounts)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 344)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totals"
        '
        'lbladmin
        '
        Me.lbladmin.BackColor = System.Drawing.Color.Transparent
        Me.lbladmin.Location = New System.Drawing.Point(16, 109)
        Me.lbladmin.Name = "lbladmin"
        Me.lbladmin.Size = New System.Drawing.Size(133, 22)
        Me.lbladmin.TabIndex = 5
        Me.lbladmin.Text = "Guna2HtmlLabel5"
        '
        'lblcloth
        '
        Me.lblcloth.BackColor = System.Drawing.Color.Transparent
        Me.lblcloth.Location = New System.Drawing.Point(16, 281)
        Me.lblcloth.Name = "lblcloth"
        Me.lblcloth.Size = New System.Drawing.Size(133, 22)
        Me.lblcloth.TabIndex = 3
        Me.lblcloth.Text = "Guna2HtmlLabel3"
        '
        'lblwood
        '
        Me.lblwood.BackColor = System.Drawing.Color.Transparent
        Me.lblwood.Location = New System.Drawing.Point(16, 238)
        Me.lblwood.Name = "lblwood"
        Me.lblwood.Size = New System.Drawing.Size(133, 22)
        Me.lblwood.TabIndex = 2
        Me.lblwood.Text = "Guna2HtmlLabel2"
        '
        'lbluser
        '
        Me.lbluser.BackColor = System.Drawing.Color.Transparent
        Me.lbluser.Location = New System.Drawing.Point(16, 66)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(133, 22)
        Me.lbluser.TabIndex = 4
        Me.lbluser.Text = "Guna2HtmlLabel4"
        '
        'lblIT
        '
        Me.lblIT.BackColor = System.Drawing.Color.Transparent
        Me.lblIT.Location = New System.Drawing.Point(16, 152)
        Me.lblIT.Name = "lblIT"
        Me.lblIT.Size = New System.Drawing.Size(52, 22)
        Me.lblIT.TabIndex = 1
        Me.lblIT.Text = "Guna2"
        '
        'lblDepartmentCounts
        '
        Me.lblDepartmentCounts.BackColor = System.Drawing.Color.Transparent
        Me.lblDepartmentCounts.Location = New System.Drawing.Point(16, 195)
        Me.lblDepartmentCounts.Name = "lblDepartmentCounts"
        Me.lblDepartmentCounts.Size = New System.Drawing.Size(54, 22)
        Me.lblDepartmentCounts.TabIndex = 0
        Me.lblDepartmentCounts.Text = "lLabel1"
        '
        'btnCSV
        '
        Me.btnCSV.BorderRadius = 5
        Me.btnCSV.CheckedState.Parent = Me.btnCSV
        Me.btnCSV.CustomImages.Parent = Me.btnCSV
        Me.btnCSV.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnCSV.ForeColor = System.Drawing.Color.White
        Me.btnCSV.HoverState.Parent = Me.btnCSV
        Me.btnCSV.Location = New System.Drawing.Point(45, 447)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.ShadowDecoration.Parent = Me.btnCSV
        Me.btnCSV.Size = New System.Drawing.Size(180, 55)
        Me.btnCSV.TabIndex = 1
        Me.btnCSV.Text = "Export CSV"
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Guna2DataGridView1.ColumnHeadersHeight = 40
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle9
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(262, 62)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowTemplate.Height = 28
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(1162, 652)
        Me.Guna2DataGridView1.TabIndex = 0
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 40
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'NamesDataSet
        '
        Me.NamesDataSet.DataSetName = "namesDataSet"
        Me.NamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestBindingSource
        '
        Me.TestBindingSource.DataMember = "test"
        Me.TestBindingSource.DataSource = Me.NamesDataSet
        '
        'TestTableAdapter
        '
        Me.TestTableAdapter.ClearBeforeFill = True
        '
        'Employee_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1479, 810)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Employee_Records"
        Me.Text = "Employee_Records"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NamesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCSV As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents NamesDataSet As BAR.namesDataSet
    Friend WithEvents TestBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestTableAdapter As BAR.namesDataSetTableAdapters.testTableAdapter
    Friend WithEvents lblDepartmentCounts As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbladmin As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lbluser As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblcloth As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblwood As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblIT As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
