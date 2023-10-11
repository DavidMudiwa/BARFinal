Imports Emgu.CV
Imports Emgu.CV.CvEnum
Imports Emgu.CV.Structure
Imports Emgu.CV.UI
Imports Emgu.CV.Util
Imports System.IO




Public Class userRegistration2

    Private capture As VideoCapture ' Initialize camera capture
    'Load the Haar Cascade Classifier
    Dim faceCascade As New CascadeClassifier("haarcascade_frontalface_default.xml")
    Private defaultSavePath As String = "C:\Users\David\Documents\Visual Studio 2013\Projects\BAR\BAR\bin\images" ' Set your desired default directory here

    Private capturedImage As Image(Of Bgr, Byte) ' Store the captured image
    Private imageName As String ' Store the   image nam


   


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        If capture Is Nothing Then
            ' Start the Camera
            capture = New VideoCapture()
            ' Start capturing from the camera
            AddHandler Application.Idle, AddressOf ProcessCameraFrame
            btnStart.Text = "Stop Camera"
        Else
            ' Stop capturing and release the camera
            RemoveHandler Application.Idle, AddressOf ProcessCameraFrame
            capture.Dispose()
            capture = Nothing
            btnStart.Text = "Start Camera"
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

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ''  Dim imageName As String ' Get the image name from the textbox

        '' If ImageBox2.Image IsNot Nothing AndAlso Not String.IsNullOrEmpty(imageName) Then
        ' Combine the default path, image name, and extension to create the complete file path
        '' Dim savePath As String = Path.Combine(defaultSavePath, imageName & ".jpg")

        Try
            ' Convert the displayed image in ImageBox2 to an Emgu.CV.Image(Of Bgr, Byte)
            Dim capturedImage As New Image(Of Bgr, Byte)(ImageBox2.Image.Bitmap)

            ' Save the image to the specified file path
            ''   capturedImage.Save(savePath)
            MessageBox.Show("Image saved successfully")
        Catch ex As Exception
            MessageBox.Show("Error while saving the image: " & ex.Message)
        End Try
        ''ElseIf String.IsNullOrEmpty(imageName) Then
        MessageBox.Show("Please enter an image name in the textbox.")
        ''  Else
        MessageBox.Show("No image in ImageBox2 to save.")

        ''   End If


    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Stop capturing when the form is closing
        If capture IsNot Nothing Then
            capture.Stop()
        End If

    End Sub

    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        ImageBox2.Image = capture.QueryFrame


    End Sub


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Guna2TextBox1.TextChanged

    End Sub
End Class