Imports System.Net
Imports System.IO
Imports System.Globalization
Imports System.Data.OleDb

Public Class Form1
    ' MS Access database connection string
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\David\Documents\Visual Studio 2013\Projects\BAR\BAR\bin\Debug\BAR.accdb"
    Public internetTimecheckedEnabled As Boolean = True
    Public useriid As Integer
    Public usernemu As String


    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        ' Create a new instance of the form you want to open.
        Dim userregistration As New userRegisteration

        ' Show the form.
        userregistration.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = TextBoxUsername.Text
        Dim password As String = TextBoxPassword.Text
        useriid = UserID(username, password)
        usernemu = usernameCheck(username, password)

        ' Check if the textbox is empty
        If String.IsNullOrEmpty(username) Or
            String.IsNullOrEmpty(password) Then
            ' Show an error message or take any appropriate action
            MessageBox.Show("Textbox cannot be empty. Please enter a value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Get the user's role
        Dim userType As String = AuthenticateUser(username, password)

        If userType = "admin" Then
            MessageBox.Show("Login successful as Admin!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Code to open the admin panel
            ' Replace "AdminPanelForm" with the actual name of your admin panel form class
            Dim adminPanelForm As New AdminPanel()
            adminPanelForm.Show()
            Me.Hide()
        Else
            ' Check if the user is a regular user
            If userType = "user" Then
                ' Check the system time, internet time, and internet connection
                Dim timeCheckResult As TimeCheckResult = CheckTimeAndInternet()
                If timeCheckResult = timeCheckResult.Success Then
                    ' The system time is correct, there is internet connection, and internet time matches the system time.
                    ' Proceed with authentication.

                    MessageBox.Show("Login successful as User!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Code to open the user panel
                    ' Replace "UserPanelForm" with the actual name of your user panel form class
                    Dim userPanelForm As New UserPanel()
                    userPanelForm.Show()
                    Me.Hide()
                ElseIf timeCheckResult = timeCheckResult.Nointernet Then
                    MessageBox.Show("No internet connection. Please contact the admin to proceed with login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ElseIf timeCheckResult = timeCheckResult.IncorrectTime Then
                    MessageBox.Show("System time is incorrect. Please correct the system time to proceed with login.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

        TextBoxPassword.Clear()
        TextBoxUsername.Clear()

    End Sub
    Private Enum TimeCheckResult
        Success
        Nointernet
        IncorrectTime
    End Enum
    Private Function CheckTimeAndInternet() As TimeCheckResult
        If internetTimecheckedEnabled Then
            ' Get the current system time
            Dim systemTime As DateTime = DateTime.Now

            ' Get the internet time using an NTP (Network Time Protocol) server
            Dim internetTime As DateTime = GetInternetTime()

            ' Check if there is internet connectivity
            If Not IsInternetAvailable() Then
                Return TimeCheckResult.Nointernet
            End If

            ' Compare the system time with the internet time
            If IsTimeCorrect(systemTime, internetTime) Then
                ' The system time is correct, there is internet connection, and internet time matches the system time.
                Return TimeCheckResult.Success
            Else
                ' There is a time discrepancy between the system time and internet time.
                Return TimeCheckResult.IncorrectTime
            End If
        Else
            Return TimeCheckResult.Success
        End If
    End Function

    Private Function IsInternetAvailable() As Boolean
        Try
            Using client As New WebClient()
                Using stream As Stream = client.OpenRead("http://worldtimeapi.org/api/timezone/Etc/UTC")
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function UserID(username As String, password As String) As String
        Dim query As String = "SELECT ID FROM usersadmins WHERE Username = @Username AND Password = @Password"
        Dim useriid As Integer

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                connection.Open()
                Dim reader As OleDbDataReader = command.ExecuteReader()

                If reader.Read() Then
                    useriid = CInt(reader("ID"))
                End If
            End Using
        End Using

        Return useriid

    End Function
    Private Function AuthenticateUser(username As String, password As String) As String

        Dim query As String = "SELECT Type FROM usersadmins WHERE Username = @Username AND Password = @Password"
        Dim userType As String = "user"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                connection.Open()
                Dim reader As OleDbDataReader = command.ExecuteReader()

                If reader.HasRows Then
                    ' A matching user was found in the database.
                    reader.Read()
                    userType = reader("Type").ToString()
                Else
                    ' No matching user found, so you can handle the authentication failure here.
                    MessageBox.Show("No matching user found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return String.Empty

                End If
            End Using
        End Using
        Return userType

    End Function
    Public Function usernameCheck(username As String, password As String) As String
        Dim query As String = "SELECT Username FROM usersadmins WHERE Username = @Username AND Password = @Password"
        Dim usernam As String = ""

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                connection.Open()
                Dim reader As OleDbDataReader = command.ExecuteReader()

                If reader.Read() Then
                    usernam = reader("Username").ToString()

                End If
            End Using
        End Using

        Return usernam
    End Function

    Private Function GetInternetTime() As DateTime
        Try
            ' Create a WebRequest to an NTP server
            Dim request As WebRequest = WebRequest.Create("http://worldtimeapi.org/api/timezone/Etc/UTC")

            ' Get the response from the server
            Using response As WebResponse = request.GetResponse()
                ' Read the response data
                Using dataStream As System.IO.Stream = response.GetResponseStream()
                    Dim reader As New System.IO.StreamReader(dataStream)
                    Dim responseJson As String = reader.ReadToEnd()

                    ' Parse the JSON response to get the internet time
                    Dim timeObject As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.Linq.JObject.Parse(responseJson)
                    Dim unixTime As Double = timeObject.Value(Of Double)("unixtime")
                    Dim internetTime As DateTime = New DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(unixTime)

                    ' Convert the internet time to the local time zone
                    internetTime = internetTime.ToLocalTime()

                    Return internetTime
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while retrieving the internet time." + ex.Message, "Time Check", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DateTime.MinValue
        End Try
    End Function

    Private Function IsTimeCorrect(systemTime As DateTime, internetTime As DateTime) As Boolean
        ' Set the acceptable time difference threshold in seconds
        Dim timeDifferenceThreshold As Integer = 5

        ' Calculate the time difference between the system time and internet time in seconds
        Dim timeDifference As Integer = CInt((systemTime - internetTime).TotalSeconds)

        ' Check if the time difference is within the threshold
        Return Math.Abs(timeDifference) <= timeDifferenceThreshold
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim userPanelForm As New UserPanel()
        UserPanel.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim adminpan As New AdminPanel
        AdminPanel.Show()
        Me.Hide()
    End Sub
End Class
