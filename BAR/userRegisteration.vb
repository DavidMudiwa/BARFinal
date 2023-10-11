Imports System.Data.OleDb
Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Structure
Imports Emgu.CV.UI
Imports Emgu.CV.Util
Imports System.IO
Imports System.Text.RegularExpressions

Public Class userRegisteration

    Private capture As VideoCapture ' Initialize camera capture
    'Load the Haar Cascade Classifier
    Dim faceCascade As New CascadeClassifier("haarcascade_frontalface_default.xml")
    Private defaultSavePath As String = "C:\Users\David\Documents\Visual Studio 2013\Projects\BAR\BAR\bin\images" ' Set your desired default directory here

    Private capturedImage As Image(Of Bgr, Byte) ' Store the captured image
    Private imageName As String ' Store the   image nam
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Dim firstName As String = txtName.Text
        Dim lastName As String = txtSurname.Text
        Dim Uname As String = txtxUsername.Text
        Dim email As String = txtEmail.Text
        Dim phone As String = txtNumber.Text
        Dim pass As String = txtPassword.Text
        Dim dept As String = ComboBoxDepartment.Text



        Dim accType As String = "user"
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"
        Dim conn As OleDbConnection = New OleDbConnection(connectionString)
        'pattern for letters only
        Dim lettersOnly As String = "^[a-zA-Z]+$"
        ' Validate email address
        Dim emailPattern As String = "^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$"
        Dim emailMatch As Match = Regex.Match(email, emailPattern)


        ' Validate name and surname address
        If Not Regex.IsMatch(firstName, lettersOnly) Or
            Not Regex.IsMatch(lastName, lettersOnly) Then
            MessageBox.Show("Firstname and Surname must contain letters only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If


        ' Check if the textbox is empty
        If String.IsNullOrEmpty(firstName) Or
            String.IsNullOrEmpty(lastName) Or
            String.IsNullOrEmpty(Uname) Or
            String.IsNullOrEmpty(email) Or
            String.IsNullOrEmpty(phone) Or
            String.IsNullOrEmpty(pass) Then
            ' Show an error message or take any appropriate action
            MessageBox.Show("Textbox cannot be empty. Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        
        
        ' Get the selected item from the ComboBox
        Dim selectedValue As String = ComboBoxDepartment.SelectedItem

        ' Check if the ComboBox is not selected
        If String.IsNullOrEmpty(selectedValue) Then
            ' Show an error message or take any appropriate action
            MessageBox.Show("Please select an option from the ComboBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        
        ' Validate email address
        If Not emailMatch.Success Then
            MessageBox.Show("Invalid email address.")
            Exit Sub
        End If

        ' Validate password length
        If pass.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters long.")
            Exit Sub
        End If

        Dim imageName As String = txtxUsername.Text ' Get the image name from the textbox

        If ImageBox2.Image IsNot Nothing AndAlso Not String.IsNullOrEmpty(imageName) Then
            ' Combine the default path, image name, and extension to create the complete file path
            Dim savePath As String = Path.Combine(defaultSavePath, imageName & ".jpg")

            Try
                ' Convert the displayed image in ImageBox2 to an Emgu.CV.Image(Of Bgr, Byte)
                Dim capturedImage As New Image(Of Bgr, Byte)(ImageBox2.Image.Bitmap)

                ' Save the image to the specified file path
                capturedImage.Save(savePath)
                MessageBox.Show("Image saved successfully")
            Catch ex As Exception
                MessageBox.Show("Error while saving the image: " & ex.Message)
                Exit Sub
            End Try
        ElseIf String.IsNullOrEmpty(imageName) Then
            MessageBox.Show("Please enter an image name in the textbox.")
            Exit Sub
        Else
            MessageBox.Show("No image in ImageBox2 to save.")
            Exit Sub

        End If
        '(Fname, Surname, Username, Password, Type, Email, Dept, Phone )
        Dim query As String = "insert into usersadmins  (Fname, Surname, Username, Pasword, Type, Email, Dept, Phone ) values (?,?,?,?,?,?,?,?)"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Fname", firstName)
                command.Parameters.AddWithValue("@Surname", lastName)
                command.Parameters.AddWithValue("Username", Uname)
                command.Parameters.AddWithValue("Pasword", pass)
                command.Parameters.AddWithValue("@Type", accType)
                command.Parameters.AddWithValue("@Email", email)
                command.Parameters.AddWithValue("@Dept", dept)
                command.Parameters.AddWithValue("@Phone", phone)

                Try
                    connection.Open()


                    Dim rowsAffected As Integer = command.ExecuteNonQuery()


                    If rowsAffected > 0 Then
                        MessageBox.Show("Employee details added successfully.")
                        Me.Hide()
                        Dim login As New Form1()

                        Form1.Show()

                    Else
                        MessageBox.Show("Failed to add employee.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " + ex.Message)
                End Try
            End Using
        End Using



    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' Allow only numeric input and control keys
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If

        ' Limit the maximum number of digits to 10
        If txtNumber.TextLength >= 10 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If

    End Sub

 
   
    Private Sub CaptureButton_Click(sender As Object, e As EventArgs) Handles CaptureButton.Click
        ImageBox2.Image = capture.QueryFrame

    End Sub
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Stop capturing when the form is closing
        If capture IsNot Nothing Then
            capture.Stop()
        End If

    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click

        If Capture Is Nothing Then
            ' Start the Camera
            Capture = New VideoCapture()
            ' Start capturing from the camera
            AddHandler Application.Idle, AddressOf ProcessCameraFrame
            StartButton.Text = "Stop Camera"
        Else
            ' Stop capturing and release the camera
            RemoveHandler Application.Idle, AddressOf ProcessCameraFrame
            Capture.Dispose()
            Capture = Nothing
            StartButton.Text = "Start Camera"
        End If
    End Sub
    Private Sub ProcessCameraFrame(sender As Object, e As EventArgs)
        ' Retrieve and Process Video Frames from the Camera
        Using frame As Mat = capture.QueryFrame()
            If frame IsNot Nothing Then
                ' Convert the frame to Image(Of Bgr, Byte) format
                Dim image As New Image(Of Bgr, Byte)(frame.Bitmap)

                ' Convert the frame to Gray for Face Detection
                Dim grayImage As Image(Of Gray, Byte) = image.Convert(Of Gray, Byte)()

                ' Detect Faces
                Dim faces As Rectangle() = faceCascade.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty)

                ' Process the Detected Faces
                For Each face As Rectangle In faces
                    ' Draw rectangles only on detected faces
                    image.Draw(face, New Bgr(Color.Red), 2)
                Next

                ' Display the Result
                ImageBox1.Image = image ' Assuming you have an Emgu.CV.UI.ImageBox control named "imageBox" on your form to display the processed frames.
            End If
        End Using

    End Sub

   
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        ' Create a new instance of the form you want to open.
        Dim login As New Form1

        ' Show the form.
        Form1.Show()
    End Sub
End Class