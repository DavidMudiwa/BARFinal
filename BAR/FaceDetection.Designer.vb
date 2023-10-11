<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FaceDetection
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
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageBoxIdentification = New Emgu.CV.UI.ImageBox()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.IdentifyButton = New System.Windows.Forms.Button()
        CType(Me.ImageBoxIdentification, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'ImageBoxIdentification
        '
        Me.ImageBoxIdentification.Location = New System.Drawing.Point(50, 53)
        Me.ImageBoxIdentification.Name = "ImageBoxIdentification"
        Me.ImageBoxIdentification.Size = New System.Drawing.Size(398, 357)
        Me.ImageBoxIdentification.TabIndex = 2
        Me.ImageBoxIdentification.TabStop = False
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(667, 192)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(88, 38)
        Me.StartButton.TabIndex = 3
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'IdentifyButton
        '
        Me.IdentifyButton.Location = New System.Drawing.Point(667, 263)
        Me.IdentifyButton.Name = "IdentifyButton"
        Me.IdentifyButton.Size = New System.Drawing.Size(88, 33)
        Me.IdentifyButton.TabIndex = 4
        Me.IdentifyButton.Text = "identify"
        Me.IdentifyButton.UseVisualStyleBackColor = True
        '
        'FaceDetection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 595)
        Me.Controls.Add(Me.IdentifyButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.ImageBoxIdentification)
        Me.Name = "FaceDetection"
        Me.Text = "FaceDetection"
        CType(Me.ImageBoxIdentification, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageBoxIdentification As Emgu.CV.UI.ImageBox
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents IdentifyButton As System.Windows.Forms.Button
End Class
