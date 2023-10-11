<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClockOut
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
        Me.ClockoutButton = New Guna.UI2.WinForms.Guna2Button()
        Me.identifyButton = New Guna.UI2.WinForms.Guna2Button()
        Me.UsernameTextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GroupBox1
        '
        Me.Guna2GroupBox1.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2GroupBox1.Controls.Add(Me.Button1)
        Me.Guna2GroupBox1.Controls.Add(Me.ClockoutButton)
        Me.Guna2GroupBox1.Controls.Add(Me.identifyButton)
        Me.Guna2GroupBox1.Controls.Add(Me.UsernameTextBox1)
        Me.Guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
        Me.Guna2GroupBox1.ShadowDecoration.Parent = Me.Guna2GroupBox1
        Me.Guna2GroupBox1.Size = New System.Drawing.Size(1097, 730)
        Me.Guna2GroupBox1.TabIndex = 0
        Me.Guna2GroupBox1.Text = "Clock Out"
        '
        'ClockoutButton
        '
        Me.ClockoutButton.BorderRadius = 5
        Me.ClockoutButton.CheckedState.Parent = Me.ClockoutButton
        Me.ClockoutButton.CustomImages.Parent = Me.ClockoutButton
        Me.ClockoutButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClockoutButton.ForeColor = System.Drawing.Color.White
        Me.ClockoutButton.HoverState.Parent = Me.ClockoutButton
        Me.ClockoutButton.Location = New System.Drawing.Point(458, 384)
        Me.ClockoutButton.Name = "ClockoutButton"
        Me.ClockoutButton.ShadowDecoration.Parent = Me.ClockoutButton
        Me.ClockoutButton.Size = New System.Drawing.Size(180, 55)
        Me.ClockoutButton.TabIndex = 3
        Me.ClockoutButton.Text = "Clock Out"
        '
        'identifyButton
        '
        Me.identifyButton.BorderRadius = 5
        Me.identifyButton.CheckedState.Parent = Me.identifyButton
        Me.identifyButton.CustomImages.Parent = Me.identifyButton
        Me.identifyButton.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.identifyButton.ForeColor = System.Drawing.Color.White
        Me.identifyButton.HoverState.Parent = Me.identifyButton
        Me.identifyButton.Location = New System.Drawing.Point(458, 297)
        Me.identifyButton.Name = "identifyButton"
        Me.identifyButton.ShadowDecoration.Parent = Me.identifyButton
        Me.identifyButton.Size = New System.Drawing.Size(180, 55)
        Me.identifyButton.TabIndex = 2
        Me.identifyButton.Text = "Identify"
        '
        'UsernameTextBox1
        '
        Me.UsernameTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTextBox1.DefaultText = ""
        Me.UsernameTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTextBox1.DisabledState.Parent = Me.UsernameTextBox1
        Me.UsernameTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTextBox1.FocusedState.Parent = Me.UsernameTextBox1
        Me.UsernameTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTextBox1.HoverState.Parent = Me.UsernameTextBox1
        Me.UsernameTextBox1.Location = New System.Drawing.Point(685, 384)
        Me.UsernameTextBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.UsernameTextBox1.Name = "UsernameTextBox1"
        Me.UsernameTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTextBox1.PlaceholderText = ""
        Me.UsernameTextBox1.SelectedText = ""
        Me.UsernameTextBox1.ShadowDecoration.Parent = Me.UsernameTextBox1
        Me.UsernameTextBox1.Size = New System.Drawing.Size(224, 45)
        Me.UsernameTextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(458, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 57)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(697, 134)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(300, 55)
        Me.Guna2TextBox1.TabIndex = 5
        '
        'ClockOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1097, 730)
        Me.Controls.Add(Me.Guna2GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClockOut"
        Me.Text = "ClockOut"
        Me.Guna2GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents UsernameTextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ClockoutButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents identifyButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
