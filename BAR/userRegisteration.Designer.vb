<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userRegisteration
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSurname = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtxUsername = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtNumber = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ComboBoxDepartment = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnRegister = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ImageBox1 = New Emgu.CV.UI.ImageBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ImageBox2 = New Emgu.CV.UI.ImageBox()
        Me.StartButton = New Guna.UI2.WinForms.Guna2Button()
        Me.CaptureButton = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ImageBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'txtName
        '
        Me.txtName.BorderRadius = 5
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.Parent = Me.txtName
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.FocusedState.Parent = Me.txtName
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.HoverState.Parent = Me.txtName
        Me.txtName.Location = New System.Drawing.Point(569, 139)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = "Name"
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.Parent = Me.txtName
        Me.txtName.Size = New System.Drawing.Size(305, 63)
        Me.txtName.TabIndex = 5
        '
        'txtSurname
        '
        Me.txtSurname.BorderRadius = 5
        Me.txtSurname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSurname.DefaultText = ""
        Me.txtSurname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSurname.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSurname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSurname.DisabledState.Parent = Me.txtSurname
        Me.txtSurname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSurname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSurname.FocusedState.Parent = Me.txtSurname
        Me.txtSurname.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSurname.HoverState.Parent = Me.txtSurname
        Me.txtSurname.Location = New System.Drawing.Point(906, 139)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSurname.PlaceholderText = "Surname"
        Me.txtSurname.SelectedText = ""
        Me.txtSurname.ShadowDecoration.Parent = Me.txtSurname
        Me.txtSurname.Size = New System.Drawing.Size(300, 63)
        Me.txtSurname.TabIndex = 6
        '
        'txtxUsername
        '
        Me.txtxUsername.BorderRadius = 5
        Me.txtxUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtxUsername.DefaultText = ""
        Me.txtxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtxUsername.DisabledState.Parent = Me.txtxUsername
        Me.txtxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtxUsername.FocusedState.Parent = Me.txtxUsername
        Me.txtxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtxUsername.HoverState.Parent = Me.txtxUsername
        Me.txtxUsername.Location = New System.Drawing.Point(569, 248)
        Me.txtxUsername.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtxUsername.Name = "txtxUsername"
        Me.txtxUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtxUsername.PlaceholderText = "Username"
        Me.txtxUsername.SelectedText = ""
        Me.txtxUsername.ShadowDecoration.Parent = Me.txtxUsername
        Me.txtxUsername.Size = New System.Drawing.Size(305, 63)
        Me.txtxUsername.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.BorderRadius = 5
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.DefaultText = ""
        Me.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.DisabledState.Parent = Me.txtPassword
        Me.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.FocusedState.Parent = Me.txtPassword
        Me.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPassword.HoverState.Parent = Me.txtPassword
        Me.txtPassword.Location = New System.Drawing.Point(906, 248)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.PlaceholderText = "Password"
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.ShadowDecoration.Parent = Me.txtPassword
        Me.txtPassword.Size = New System.Drawing.Size(300, 63)
        Me.txtPassword.TabIndex = 8
        '
        'txtEmail
        '
        Me.txtEmail.BorderRadius = 5
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.Parent = Me.txtEmail
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.FocusedState.Parent = Me.txtEmail
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.HoverState.Parent = Me.txtEmail
        Me.txtEmail.Location = New System.Drawing.Point(569, 357)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = "Email"
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.ShadowDecoration.Parent = Me.txtEmail
        Me.txtEmail.Size = New System.Drawing.Size(637, 63)
        Me.txtEmail.TabIndex = 9
        '
        'txtNumber
        '
        Me.txtNumber.BorderRadius = 5
        Me.txtNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumber.DefaultText = ""
        Me.txtNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumber.DisabledState.Parent = Me.txtNumber
        Me.txtNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumber.FocusedState.Parent = Me.txtNumber
        Me.txtNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNumber.HoverState.Parent = Me.txtNumber
        Me.txtNumber.Location = New System.Drawing.Point(569, 466)
        Me.txtNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNumber.PlaceholderText = "Contact Number"
        Me.txtNumber.SelectedText = ""
        Me.txtNumber.ShadowDecoration.Parent = Me.txtNumber
        Me.txtNumber.Size = New System.Drawing.Size(305, 63)
        Me.txtNumber.TabIndex = 11
        '
        'ComboBoxDepartment
        '
        Me.ComboBoxDepartment.BackColor = System.Drawing.Color.Transparent
        Me.ComboBoxDepartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDepartment.FocusedColor = System.Drawing.Color.Empty
        Me.ComboBoxDepartment.FocusedState.Parent = Me.ComboBoxDepartment
        Me.ComboBoxDepartment.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBoxDepartment.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ComboBoxDepartment.FormattingEnabled = True
        Me.ComboBoxDepartment.HoverState.Parent = Me.ComboBoxDepartment
        Me.ComboBoxDepartment.ItemHeight = 30
        Me.ComboBoxDepartment.Items.AddRange(New Object() {"IT", "CLOTHING", "ELECTRONICS", "WOOD TECH"})
        Me.ComboBoxDepartment.ItemsAppearance.Parent = Me.ComboBoxDepartment
        Me.ComboBoxDepartment.Location = New System.Drawing.Point(918, 466)
        Me.ComboBoxDepartment.Name = "ComboBoxDepartment"
        Me.ComboBoxDepartment.ShadowDecoration.Parent = Me.ComboBoxDepartment
        Me.ComboBoxDepartment.Size = New System.Drawing.Size(288, 36)
        Me.ComboBoxDepartment.TabIndex = 12
        '
        'btnRegister
        '
        Me.btnRegister.BorderRadius = 5
        Me.btnRegister.CheckedState.Parent = Me.btnRegister
        Me.btnRegister.CustomImages.Parent = Me.btnRegister
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.HoverState.Parent = Me.btnRegister
        Me.btnRegister.Location = New System.Drawing.Point(1053, 623)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.ShadowDecoration.Parent = Me.btnRegister
        Me.btnRegister.Size = New System.Drawing.Size(153, 63)
        Me.btnRegister.TabIndex = 13
        Me.btnRegister.Text = "Register"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(783, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 54)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Register!"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(1180, 12)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox1.TabIndex = 15
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(1231, 12)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.Guna2ControlBox2.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ImageBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(67, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 350)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Camera"
        '
        'ImageBox1
        '
        Me.ImageBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageBox1.Location = New System.Drawing.Point(3, 22)
        Me.ImageBox1.Name = "ImageBox1"
        Me.ImageBox1.Size = New System.Drawing.Size(344, 325)
        Me.ImageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ImageBox1.TabIndex = 2
        Me.ImageBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ImageBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(70, 381)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 350)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Captured"
        '
        'ImageBox2
        '
        Me.ImageBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ImageBox2.Location = New System.Drawing.Point(3, 22)
        Me.ImageBox2.Name = "ImageBox2"
        Me.ImageBox2.Size = New System.Drawing.Size(344, 325)
        Me.ImageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ImageBox2.TabIndex = 2
        Me.ImageBox2.TabStop = False
        '
        'StartButton
        '
        Me.StartButton.BorderRadius = 5
        Me.StartButton.CheckedState.Parent = Me.StartButton
        Me.StartButton.CustomImages.Parent = Me.StartButton
        Me.StartButton.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.StartButton.ForeColor = System.Drawing.Color.White
        Me.StartButton.HoverState.Parent = Me.StartButton
        Me.StartButton.Location = New System.Drawing.Point(703, 623)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.ShadowDecoration.Parent = Me.StartButton
        Me.StartButton.Size = New System.Drawing.Size(153, 63)
        Me.StartButton.TabIndex = 19
        Me.StartButton.Text = "Start Camera"
        '
        'CaptureButton
        '
        Me.CaptureButton.BorderRadius = 5
        Me.CaptureButton.CheckedState.Parent = Me.CaptureButton
        Me.CaptureButton.CustomImages.Parent = Me.CaptureButton
        Me.CaptureButton.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CaptureButton.ForeColor = System.Drawing.Color.White
        Me.CaptureButton.HoverState.Parent = Me.CaptureButton
        Me.CaptureButton.Location = New System.Drawing.Point(878, 623)
        Me.CaptureButton.Name = "CaptureButton"
        Me.CaptureButton.ShadowDecoration.Parent = Me.CaptureButton
        Me.CaptureButton.Size = New System.Drawing.Size(153, 63)
        Me.CaptureButton.TabIndex = 21
        Me.CaptureButton.Text = "Capture"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(4, 9)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(60, 60)
        Me.Guna2Button1.TabIndex = 22
        '
        'Guna2Button2
        '
        Me.Guna2Button2.BorderRadius = 5
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(528, 623)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(153, 63)
        Me.Guna2Button2.TabIndex = 23
        Me.Guna2Button2.Text = "Back"
        '
        'userRegisteration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1292, 800)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.CaptureButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Guna2ControlBox2)
        Me.Controls.Add(Me.Guna2ControlBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.ComboBoxDepartment)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtxUsername)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Guna2Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userRegisteration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "userRegisteration"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ImageBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ImageBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents ComboBoxDepartment As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtNumber As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtxUsername As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSurname As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnRegister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageBox2 As Emgu.CV.UI.ImageBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImageBox1 As Emgu.CV.UI.ImageBox
    Friend WithEvents StartButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CaptureButton As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
