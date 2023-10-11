Imports System.Data.OleDb
Imports System.Diagnostics
Public Class ClockIn
    Private dbname As String = "BAR.accdb"
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & GetDataaBasePath()
    Dim conn As New OleDbConnection(connString)
    Public recognizedname As String


    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles usernameTextBox.TextChanged

    End Sub
    Private Function GetDataaBasePath() As String
        Return System.IO.Path.Combine(Application.StartupPath, dbname)
    End Function
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles clockinbtn.Click
        Dim username As String = usernameTextBox.Text
        Dim loggedInuser As String = Form1.usernemu
        Dim currentDate As Date = Date.Today
        Dim currentTime As DateTime = DateTime.Now
        Dim statusIn As String = If(currentTime.TimeOfDay <= New TimeSpan(8, 10, 0), "On time", "Tardy")

        If usernameTextBox.Text = "" Then
            MessageBox.Show("Identify First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If username <> loggedInuser Then
            MessageBox.Show("Identified person does not match logged in user!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        ' Check if the user has already clocked in on the current date
        If Not HasClockedIn(username, currentDate) Then


            Try
                conn.Open()
                Dim insertQuery As String = "INSERT INTO attendance (ID,Username, ClockIn, StatusIn, Date_) VALUES (?,?,?,?,?)"
                Dim cmd As New OleDbCommand(insertQuery, conn)
                cmd.Parameters.AddWithValue("@ID", Form1.useriid)
                cmd.Parameters.AddWithValue("@Username", username)
                cmd.Parameters.AddWithValue("@ClockIn", DateTime.Now.ToString("HH:mm"))
                cmd.Parameters.AddWithValue("@StatusIn", statusIn)
                cmd.Parameters.AddWithValue("@Date_", DateTime.Now.ToString("dd/MM/yyyy"))
                cmd.ExecuteNonQuery()
                MessageBox.Show("Clock in successful!")
                usernameTextBox.Clear()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                conn.Close()
            End Try
        Else
            MessageBox.Show("You have already clocked in today.")
        End If
        ''usernameTextBox.Clear()

    End Sub
    Private Function HasClockedIn(username As String, dateToCheck As Date) As Boolean
        Dim ClockedIn As Boolean = False

        Try
            conn.Open()
            Dim selectQuery As String = "SELECT COUNT(*) FROM attendance WHERE Username = ? AND Date_ = ?"
            Dim cmd As New OleDbCommand(selectQuery, conn)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Date", dateToCheck)
            Dim count As Integer = CInt(cmd.ExecuteScalar())

            If count > 0 Then
                ClockedIn = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return ClockedIn
    End Function

    Private Sub identifyBtn_Click(sender As Object, e As EventArgs) Handles identifyBtn.Click
        Dim proc As Process = New Process
        proc.StartInfo.FileName = "C:\Users\David\AppData\Local\Programs\Python\Python38\python.exe" 'Default Python Installation
        proc.StartInfo.Arguments = "main_video.py"
        proc.StartInfo.UseShellExecute = False 'required for redirect.
        proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden 'don't show commandprompt.
        proc.StartInfo.CreateNoWindow = True
        proc.StartInfo.RedirectStandardOutput = True 'captures output from commandprompt.
        proc.Start()
        AddHandler proc.OutputDataReceived, AddressOf proccess_OutputDataReceived
        proc.BeginOutputReadLine()
        proc.WaitForExit()

        usernameTextBox.Text = recognizedname
    End Sub
    Public Sub proccess_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        On Error Resume Next
        If e.Data = "" Then
        Else
            recognizedname = e.Data
        End If
    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

 
End Class