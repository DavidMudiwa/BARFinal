<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance_Records
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.CalculateWeekly = New Guna.UI2.WinForms.Guna2Button()
        Me.CalculateMonthly = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAll = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtUserID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCSV = New Guna.UI2.WinForms.Guna2Button()
        Me.btnMonthly = New Guna.UI2.WinForms.Guna2Button()
        Me.btnWeekly = New Guna.UI2.WinForms.Guna2Button()
        Me.btnToday = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2DataGridView1 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox1.SuspendLayout()
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.CalculateWeekly)
        Me.Guna2GroupBox1.Controls.Add(Me.CalculateMonthly)
        Me.Guna2GroupBox1.Controls.Add(Me.btnAll)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.txtUserID)
        Me.Guna2GroupBox1.Controls.Add(Me.btnCSV)
        Me.Guna2GroupBox1.Controls.Add(Me.btnMonthly)
        Me.Guna2GroupBox1.Controls.Add(Me.btnWeekly)
        Me.Guna2GroupBox1.Controls.Add(Me.btnToday)
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2DataGridView1)
        Me.Guna2GroupBox1.CustomBorderColor = System.Drawing.Color.Transparent
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(-2, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1479, 796)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Attendance Records"
        '
        'CalculateWeekly
        '
        Me.CalculateWeekly.BorderRadius = 5
        Me.CalculateWeekly.CheckedState.Parent = Me.CalculateWeekly
        Me.CalculateWeekly.CustomImages.Parent = Me.CalculateWeekly
        Me.CalculateWeekly.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CalculateWeekly.ForeColor = System.Drawing.Color.White
        Me.CalculateWeekly.HoverState.Parent = Me.CalculateWeekly
        Me.CalculateWeekly.Location = New System.Drawing.Point(66, 428)
        Me.CalculateWeekly.Name = "CalculateWeekly"
        Me.CalculateWeekly.ShadowDecoration.Parent = Me.CalculateWeekly
        Me.CalculateWeekly.Size = New System.Drawing.Size(180, 45)
        Me.CalculateWeekly.TabIndex = 9
        Me.CalculateWeekly.Text = "Calculate Weekly"
        '
        'CalculateMonthly
        '
        Me.CalculateMonthly.BorderRadius = 5
        Me.CalculateMonthly.CheckedState.Parent = Me.CalculateMonthly
        Me.CalculateMonthly.CustomImages.Parent = Me.CalculateMonthly
        Me.CalculateMonthly.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CalculateMonthly.ForeColor = System.Drawing.Color.White
        Me.CalculateMonthly.HoverState.Parent = Me.CalculateMonthly
        Me.CalculateMonthly.Location = New System.Drawing.Point(66, 357)
        Me.CalculateMonthly.Name = "CalculateMonthly"
        Me.CalculateMonthly.ShadowDecoration.Parent = Me.CalculateMonthly
        Me.CalculateMonthly.Size = New System.Drawing.Size(180, 45)
        Me.CalculateMonthly.TabIndex = 8
        Me.CalculateMonthly.Text = "Calculate Monthly"
        '
        'btnAll
        '
        Me.btnAll.BorderRadius = 5
        Me.btnAll.CheckedState.Parent = Me.btnAll
        Me.btnAll.CustomImages.Parent = Me.btnAll
        Me.btnAll.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnAll.ForeColor = System.Drawing.Color.White
        Me.btnAll.HoverState.Parent = Me.btnAll
        Me.btnAll.Location = New System.Drawing.Point(1269, 680)
        Me.btnAll.Name = "btnAll"
        Me.btnAll.ShadowDecoration.Parent = Me.btnAll
        Me.btnAll.Size = New System.Drawing.Size(154, 55)
        Me.btnAll.TabIndex = 7
        Me.btnAll.Text = "Show All"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(66, 199)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(154, 44)
        Me.Guna2Button1.TabIndex = 6
        Me.Guna2Button1.Text = "Show Records"
        '
        'txtUserID
        '
        Me.txtUserID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUserID.DefaultText = ""
        Me.txtUserID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtUserID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtUserID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.DisabledState.Parent = Me.txtUserID
        Me.txtUserID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserID.FocusedState.Parent = Me.txtUserID
        Me.txtUserID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUserID.HoverState.Parent = Me.txtUserID
        Me.txtUserID.Location = New System.Drawing.Point(66, 135)
        Me.txtUserID.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUserID.PlaceholderText = "Enter ID"
        Me.txtUserID.SelectedText = ""
        Me.txtUserID.ShadowDecoration.Parent = Me.txtUserID
        Me.txtUserID.Size = New System.Drawing.Size(191, 55)
        Me.txtUserID.TabIndex = 5
        '
        'btnCSV
        '
        Me.btnCSV.BorderRadius = 5
        Me.btnCSV.CheckedState.Parent = Me.btnCSV
        Me.btnCSV.CustomImages.Parent = Me.btnCSV
        Me.btnCSV.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnCSV.ForeColor = System.Drawing.Color.White
        Me.btnCSV.HoverState.Parent = Me.btnCSV
        Me.btnCSV.Location = New System.Drawing.Point(66, 499)
        Me.btnCSV.Name = "btnCSV"
        Me.btnCSV.ShadowDecoration.Parent = Me.btnCSV
        Me.btnCSV.Size = New System.Drawing.Size(180, 45)
        Me.btnCSV.TabIndex = 4
        Me.btnCSV.Text = "Export CSV"
        '
        'btnMonthly
        '
        Me.btnMonthly.BorderRadius = 5
        Me.btnMonthly.CheckedState.Parent = Me.btnMonthly
        Me.btnMonthly.CustomImages.Parent = Me.btnMonthly
        Me.btnMonthly.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnMonthly.ForeColor = System.Drawing.Color.White
        Me.btnMonthly.HoverState.Parent = Me.btnMonthly
        Me.btnMonthly.Location = New System.Drawing.Point(983, 680)
        Me.btnMonthly.Name = "btnMonthly"
        Me.btnMonthly.ShadowDecoration.Parent = Me.btnMonthly
        Me.btnMonthly.Size = New System.Drawing.Size(139, 55)
        Me.btnMonthly.TabIndex = 3
        Me.btnMonthly.Text = "Monthly"
        '
        'btnWeekly
        '
        Me.btnWeekly.BorderRadius = 5
        Me.btnWeekly.CheckedState.Parent = Me.btnWeekly
        Me.btnWeekly.CustomImages.Parent = Me.btnWeekly
        Me.btnWeekly.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnWeekly.ForeColor = System.Drawing.Color.White
        Me.btnWeekly.HoverState.Parent = Me.btnWeekly
        Me.btnWeekly.Location = New System.Drawing.Point(697, 680)
        Me.btnWeekly.Name = "btnWeekly"
        Me.btnWeekly.ShadowDecoration.Parent = Me.btnWeekly
        Me.btnWeekly.Size = New System.Drawing.Size(139, 55)
        Me.btnWeekly.TabIndex = 2
        Me.btnWeekly.Text = "Weekly"
        '
        'btnToday
        '
        Me.btnToday.BorderRadius = 5
        Me.btnToday.CheckedState.Parent = Me.btnToday
        Me.btnToday.CustomImages.Parent = Me.btnToday
        Me.btnToday.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnToday.ForeColor = System.Drawing.Color.White
        Me.btnToday.HoverState.Parent = Me.btnToday
        Me.btnToday.Location = New System.Drawing.Point(411, 680)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.ShadowDecoration.Parent = Me.btnToday
        Me.btnToday.Size = New System.Drawing.Size(139, 55)
        Me.btnToday.TabIndex = 1
        Me.btnToday.Text = "Today"
        '
        'Guna2DataGridView1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Guna2DataGridView1.BackgroundColor = System.Drawing.Color.Snow
        Me.Guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView1.ColumnHeadersHeight = 35
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView1.EnableHeadersVisualStyles = False
        Me.Guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2DataGridView1.Location = New System.Drawing.Point(377, 48)
        Me.Guna2DataGridView1.Name = "Guna2DataGridView1"
        Me.Guna2DataGridView1.RowHeadersVisible = False
        Me.Guna2DataGridView1.RowTemplate.Height = 28
        Me.Guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Guna2DataGridView1.Size = New System.Drawing.Size(1070, 609)
        Me.Guna2DataGridView1.TabIndex = 0
        Me.Guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(189, Byte), Integer), CType(CType(223, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.Snow
        Me.Guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 35
        Me.Guna2DataGridView1.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.Height = 28
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Attendance_Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1479, 791)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Attendance_Records"
        Me.Text = "Attendance_Records"
        Me.Guna2GroupBox1.ResumeLayout(False)
        CType(Me.Guna2DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2DataGridView1 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents btnToday As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnMonthly As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnWeekly As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCSV As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtUserID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnAll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CalculateMonthly As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CalculateWeekly As Guna.UI2.WinForms.Guna2Button
End Class
