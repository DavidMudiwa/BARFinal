Imports System.Data.OleDb
Imports System.Diagnostics
Public Class ClockOut
    Private dbname As String = "BAR.accdb"
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & GetDataaBasePath()
    Dim conn As New OleDbConnection(connString)
    Public recognizedname As String
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)
    End Sub
    Private Function GetDataaBasePath() As String
        Return System.IO.Path.Combine(Application.StartupPath, dbname)
    End Function

    Private Sub identifyButton_Click(sender As Object, e As EventArgs) Handles identifyButton.Click
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

        UsernameTextBox1.Text = recognizedname
    End Sub
    Public Sub proccess_OutputDataReceived(ByVal sender As Object, ByVal e As DataReceivedEventArgs)
        On Error Resume Next
        If e.Data = "" Then
        Else
            recognizedname = e.Data
        End If
    End Sub

    Private Sub ClockoutButton_Click(sender As Object, e As EventArgs) Handles ClockoutButton.Click
        Dim username As String = UsernameTextBox1.Text
        Dim currentDate As Date = Date.Today
        Dim currentTime As DateTime = DateTime.Now
        Dim totalHours As Double = (currentTime - GetClockInTime(username, currentDate)).TotalHours

        Dim statusOut As String = If(currentTime.TimeOfDay < New TimeSpan(16, 0, 0), "Early Out", "On Time")

        If UsernameTextBox1.Text = "" Then
            MessageBox.Show("Identify First!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ' Check if the user has already clocked in on the current date
        If HasClockedIn(username, currentDate) Then
            ' Check if the user has already clocked out on the current date
            If Not HasClockedOut(username, currentDate) Then
                Try
                    conn.Open()
                    Dim updateQuery As String = "UPDATE attendance SET ClockOut = ?, StatusOut = ? WHERE Username = ? AND Date_ = ?"
                    Dim cmd As New OleDbCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@ClockOut", DateTime.Now.ToString("HH:mm"))
                    cmd.Parameters.AddWithValue("@StatusOut", statusOut)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Date_", DateTime.Now.ToString("dd/MM/yyyy"))
                    cmd.ExecuteNonQuery()

                    ' Update the "Total Time" field
                    Dim updateTotalTimeQuery As String = "UPDATE attendance SET [Total_Time] = ?  WHERE Username = ? AND Date_ = ?"
                    Dim totalCmd As New OleDbCommand(updateTotalTimeQuery, conn)
                    totalCmd.Parameters.AddWithValue("@TotalTime", totalHours)
                    totalCmd.Parameters.AddWithValue("@Username", username)
                    totalCmd.Parameters.AddWithValue("@Date_", DateTime.Now.ToString("dd/MM/yyyy"))
                    totalCmd.ExecuteNonQuery()


                    MessageBox.Show("Clock out successful!")
                    UsernameTextBox1.Clear()
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            Else
                MessageBox.Show("You have already clocked out today.")
            End If
        Else
            MessageBox.Show("You have not clocked in today.")
        End If


    End Sub

    Private Function HasClockedIn(username As String, dateToCheck As Date) As Boolean
        Dim ClockedIn As Boolean = False

        Try
            conn.Open()
            Dim selectQuery As String = "SELECT COUNT(*) FROM attendance WHERE Username = ? AND Date_ = ? AND ClockIn IS NOT NULL"
            Dim cmd As New OleDbCommand(selectQuery, conn)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Date_", dateToCheck)
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

    Private Function HasClockedOut(username As String, dateToCheck As Date) As Boolean
        Dim ClockedOut As Boolean = False

        Try
            conn.Open()
            Dim selectQuery As String = "SELECT COUNT(*) FROM attendance WHERE Username = ? AND Date_ = ? AND ClockOut IS NOT NULL"
            Dim cmd As New OleDbCommand(selectQuery, conn)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Date", dateToCheck)
            Dim count As Integer = CInt(cmd.ExecuteScalar())

            If count > 0 Then
                ClockedOut = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return ClockedOut
    End Function
    Private Function GetClockInTime(username As String, dateToCheck As Date) As DateTime
        Dim clockInTime As DateTime = DateTime.MinValue

        Try
            conn.Open()
            Dim selectQuery As String = "SELECT ClockIn FROM attendance WHERE Username = ? AND Date_ = ?"
            Dim cmd As New OleDbCommand(selectQuery, conn)
            cmd.Parameters.AddWithValue("@Username", username)
            cmd.Parameters.AddWithValue("@Date_", dateToCheck)
            Dim result As Object = cmd.ExecuteScalar()

            If result IsNot DBNull.Value Then
                clockInTime = DateTime.Parse(result)
            End If
        Catch ex As Exception
            MessageBox.Show("Error Clock: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return clockInTime
    End Function


    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub
    ''below code is for testing getclockin time function its not permanent
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = UsernameTextBox1.Text
        Dim currentDate As Date = Date.Today
        Dim currentTime As DateTime = DateTime.Now
        '' Dim formattedTime As String = currentTime.ToString("HH:mm:ss")
        ''  Dim totalHours As Double = (currentTime - GetClockInTime(username, currentDate)).TotalHours
        ''Guna2TextBox1.Text = GetClockInTime(username, currentDate)
    End Sub
End Class