<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClockIn
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
        Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.identifyBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.clockinbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.usernameTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.identifyBtn)
        Me.Guna2GroupBox1.Controls.Add(Me.clockinbtn)
        Me.Guna2GroupBox1.Controls.Add(Me.usernameTextBox)
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1097, 730)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Clock In"
        '
        'identifyBtn
        '
        Me.identifyBtn.BorderRadius = 5
        Me.identifyBtn.CheckedState.Parent = Me.identifyBtn
        Me.identifyBtn.CustomImages.Parent = Me.identifyBtn
        Me.identifyBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.identifyBtn.ForeColor = System.Drawing.Color.White
        Me.identifyBtn.HoverState.Parent = Me.identifyBtn
        Me.identifyBtn.Location = New System.Drawing.Point(458, 297)
        Me.identifyBtn.Name = "identifyBtn"
        Me.identifyBtn.ShadowDecoration.Parent = Me.identifyBtn
        Me.identifyBtn.Size = New System.Drawing.Size(180, 55)
        Me.identifyBtn.TabIndex = 3
        Me.identifyBtn.Text = "Identify"
        '
        'clockinbtn
        '
        Me.clockinbtn.BorderRadius = 5
        Me.clockinbtn.CheckedState.Parent = Me.clockinbtn
        Me.clockinbtn.CustomImages.Parent = Me.clockinbtn
        Me.clockinbtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clockinbtn.ForeColor = System.Drawing.Color.White
        Me.clockinbtn.HoverState.Parent = Me.clockinbtn
        Me.clockinbtn.Location = New System.Drawing.Point(458, 384)
        Me.clockinbtn.Name = "clockinbtn"
        Me.clockinbtn.ShadowDecoration.Parent = Me.clockinbtn
        Me.clockinbtn.Size = New System.Drawing.Size(180, 55)
        Me.clockinbtn.TabIndex = 2
        Me.clockinbtn.Text = "Clock In"
        '
        'usernameTextBox
        '
        Me.usernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.usernameTextBox.DefaultText = ""
        Me.usernameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.usernameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.usernameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameTextBox.DisabledState.Parent = Me.usernameTextBox
        Me.usernameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.usernameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameTextBox.FocusedState.Parent = Me.usernameTextBox
        Me.usernameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.usernameTextBox.HoverState.Parent = Me.usernameTextBox
        Me.usernameTextBox.Location = New System.Drawing.Point(685, 384)
        Me.usernameTextBox.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.usernameTextBox.Name = "usernameTextBox"
        Me.usernameTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.usernameTextBox.PlaceholderText = ""
        Me.usernameTextBox.SelectedText = ""
        Me.usernameTextBox.ShadowDecoration.Parent = Me.usernameTextBox
        Me.usernameTextBox.Size = New System.Drawing.Size(224, 55)
        Me.usernameTextBox.TabIndex = 1
        '
        'ClockIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 730)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClockIn"
        Me.Text = "ClockIn"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents usernameTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents clockinbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents identifyBtn As Guna.UI2.WinForms.Guna2Button
End Class
