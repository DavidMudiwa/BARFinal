<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class userRegistration2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ImageBox1 = New Emgu.CV.UI.ImageBox()
        Me.Guna2VSeparator1 = New Guna.UI2.WinForms.Guna2VSeparator()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnCapture = New Guna.UI2.WinForms.Guna2Button()
        Me.ImageBox2 = New Emgu.CV.UI.ImageBox()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.BAR.My.Resources.Resources.Computer_login_rafiki__1_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(437, 698)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(840, 483)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(143, 55)
        Me.Guna2Button1.TabIndex = 5
        Me.Guna2Button1.Text = "Submit"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(168, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 54)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Register"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(120, 609)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 45)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Step 2 of 2"
        '
        'btnStart
        '
        Me.btnStart.BorderRadius = 5
        Me.btnStart.CheckedState.Parent = Me.btnStart
        Me.btnStart.CustomImages.Parent = Me.btnStart
        Me.btnStart.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.Color.White
        Me.btnStart.HoverState.Parent = Me.btnStart
        Me.btnStart.Location = New System.Drawing.Point(461, 483)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.ShadowDecoration.Parent = Me.btnStart
        Me.btnStart.Size = New System.Drawing.Size(143, 55)
        Me.btnStart.TabIndex = 8
        Me.btnStart.Text = "Start Camera"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1232, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 10
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Gray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1171, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ImageBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(458, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 366)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Camera"
        '
        'ImageBox1
        '
        Me.ImageBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageBox1.Location = New System.Drawing.Point(3, 22)
        Me.ImageBox1.Name = "ImageBox1"
        Me.ImageBox1.Size = New System.Drawing.Size(522, 341)
        Me.ImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ImageBox1.TabIndex = 4
        Me.ImageBox1.TabStop = False
        '
        'Guna2VSeparator1
        '
        Me.Guna2VSeparator1.Location = New System.Drawing.Point(431, -2)
        Me.Guna2VSeparator1.Name = "Guna2VSeparator1"
        Me.Guna2VSeparator1.Size = New System.Drawing.Size(10, 750)
        Me.Guna2VSeparator1.TabIndex = 13
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
        Me.Guna2TextBox1.Location = New System.Drawing.Point(476, 610)
        Me.Guna2TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(189, 42)
        Me.Guna2TextBox1.TabIndex = 14
        '
        'btnCapture
        '
        Me.btnCapture.BorderRadius = 5
        Me.btnCapture.CheckedState.Parent = Me.btnCapture
        Me.btnCapture.CustomImages.Parent = Me.btnCapture
        Me.btnCapture.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCapture.ForeColor = System.Drawing.Color.White
        Me.btnCapture.HoverState.Parent = Me.btnCapture
        Me.btnCapture.Location = New System.Drawing.Point(650, 483)
        Me.btnCapture.Name = "btnCapture"
        Me.btnCapture.ShadowDecoration.Parent = Me.btnCapture
        Me.btnCapture.Size = New System.Drawing.Size(144, 55)
        Me.btnCapture.TabIndex = 16
        Me.btnCapture.Text = "Capture"
        '
        'ImageBox2
        '
        Me.ImageBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageBox2.Location = New System.Drawing.Point(3, 22)
        Me.ImageBox2.Name = "ImageBox2"
        Me.ImageBox2.Size = New System.Drawing.Size(466, 341)
        Me.ImageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ImageBox2.TabIndex = 17
        Me.ImageBox2.TabStop = False
        '
        'grpBox
        '
        Me.grpBox.Controls.Add(Me.ImageBox2)
        Me.grpBox.Location = New System.Drawing.Point(1001, 94)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(472, 366)
        Me.grpBox.TabIndex = 18
        Me.grpBox.TabStop = False
        Me.grpBox.Text = "Captured Image"
        '
        'userRegistration2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1515, 698)
        Me.Controls.Add(Me.grpBox)
        Me.Controls.Add(Me.btnCapture)
        Me.Controls.Add(Me.Guna2TextBox1)
        Me.Controls.Add(Me.Guna2VSeparator1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userRegistration2"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 100, 0)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userRegistration2"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBox.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnStart As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2VSeparator1 As Guna.UI2.WinForms.Guna2VSeparator
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnCapture As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ImageBox1 As Emgu.CV.UI.ImageBox
    Friend WithEvents ImageBox2 As Emgu.CV.UI.ImageBox
    Friend WithEvents grpBox As System.Windows.Forms.GroupBox
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
End Class
