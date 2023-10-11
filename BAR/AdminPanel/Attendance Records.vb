Imports System.Data.OleDb
Imports System.IO

Public Class Attendance_Records

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub Attendance_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  connection string for the Access database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

        '  SQL query to join the two tables based on the common column (Username)
        Dim query As String = "SELECT ua.ID, ua.Fname, FORMAT(att.ClockIn, 'hh:mm') AS ClockIn, att.StatusIN, FORMAT(att.ClockOut, 'hh:mm') AS ClockOut, att.StatusOUT, att.Total_Time, att.Date_ " &
                      "FROM usersadmins AS ua " &
                      "INNER JOIN attendance AS att ON ua.Username = att.Username"

        Try
            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    connection.Open()

                    Using adapter As New OleDbDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Bind the DataTable to the DataGridView
                        Guna2DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnToday_Click(sender As Object, e As EventArgs) Handles btnToday.Click

        Try
            ' connection string for the Access database
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

            ' Check if there's a user ID entered in the TextBox
            Dim userID As Integer = -1 ' Default value if no user ID is entered

            If Not String.IsNullOrEmpty(txtUserID.Text) AndAlso Integer.TryParse(txtUserID.Text, userID) Then
                ' A valid user ID is entered, so we will filter by user ID in the query
            Else
                ' No user ID or an invalid user ID is entered, so we will not filter by user ID
                userID = -1 ' Set userID to -1 to indicate no filtering by user ID
            End If

            ' Get the current date
            Dim currentDate As Date = Date.Now.Date

            '  SQL query to retrieve login records for the current day
            Dim query As String = "SELECT ua.ID, ua.Fname, FORMAT(att.ClockIn, 'hh:mm') AS ClockIn, att.StatusIN, FORMAT(att.ClockOut, 'hh:mm') AS ClockOut, att.StatusOUT, att.Total_Time, att.Date_ " &
                                  "FROM usersadmins AS ua " &
                                  "INNER JOIN attendance AS att ON ua.Username = att.Username " &
                                  "WHERE (att.Date_ = @CurrentDate) AND (ua.ID = @UserID OR @UserID = -1)"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@CurrentDate", currentDate)
                    command.Parameters.AddWithValue("@UserID", userID)
                    connection.Open()

                    Using adapter As New OleDbDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Bind the DataTable to the DataGridView
                        Guna2DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnWeekly_Click(sender As Object, e As EventArgs) Handles btnWeekly.Click
        Try
            '  connection string for the Access database
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

            ' Check if there's a user ID entered in the TextBox
            Dim userID As Integer = -1 ' Default value if no user ID is entered

            If Not String.IsNullOrEmpty(txtUserID.Text) AndAlso Integer.TryParse(txtUserID.Text, userID) Then
                ' A valid user ID is entered, so we will filter by user ID in the query
            Else
                ' No user ID or an invalid user ID is entered, so we will not filter by user ID
                userID = -1 ' Set userID to -1 to indicate no filtering by user ID
            End If

            ' Get the start and end dates for the current week
            Dim currentDate As Date = Date.Now.Date
            Dim startDate As Date = currentDate.AddDays(-CInt(currentDate.DayOfWeek))
            Dim endDate As Date = startDate.AddDays(6)

            '  SQL query to retrieve login records for the current week
            Dim query As String = "SELECT ua.ID, ua.Fname, FORMAT(att.ClockIn, 'hh:mm') AS ClockIn, att.StatusIN, FORMAT(att.ClockOut, 'hh:mm') AS ClockOut, att.StatusOUT, att.Total_Time, att.Date_ " &
                                  "FROM usersadmins AS ua " &
                                  "INNER JOIN attendance AS att ON ua.Username = att.Username " &
                                  "WHERE (att.Date_ BETWEEN @StartDate AND @EndDate) AND (ua.ID = @UserID OR @UserID = -1)"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@StartDate", startDate)
                    command.Parameters.AddWithValue("@EndDate", endDate)
                    command.Parameters.AddWithValue("@UserID", userID)
                    connection.Open()

                    Using adapter As New OleDbDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Bind the DataTable to the DataGridView
                        Guna2DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnMonthly_Click(sender As Object, e As EventArgs) Handles btnMonthly.Click

        Try
            ' connection string for the Access database
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

            ' Check if there's a user ID entered in the TextBox
            Dim userID As Integer = -1 ' Default value if no user ID is entered

            If Not String.IsNullOrEmpty(txtUserID.Text) AndAlso Integer.TryParse(txtUserID.Text, userID) Then
                ' A valid user ID is entered, so we will filter by user ID in the query
            Else
                ' No user ID or an invalid user ID is entered, so we will not filter by user ID
                userID = -1 ' Set userID to -1 to indicate no filtering by user ID
            End If

            ' Get the start and end dates for the current month
            Dim currentDate As Date = Date.Now.Date
            Dim startDate As Date = currentDate.AddDays(-currentDate.Day + 1)
            Dim endDate As Date = startDate.AddMonths(1).AddDays(-1)

            ' SQL query to retrieve login records for the current month
            Dim query As String = "SELECT ua.ID, ua.Fname, FORMAT(att.ClockIn, 'hh:mm') AS ClockIn, att.StatusIN, FORMAT(att.ClockOut, 'hh:mm') AS ClockOut, att.StatusOUT, att.Total_Time, att.Date_ " &
                                  "FROM usersadmins AS ua " &
                                  "INNER JOIN attendance AS att ON ua.Username = att.Username " &
                                  "WHERE (att.Date_ BETWEEN @StartDate AND @EndDate) AND (ua.ID = @UserID OR @UserID = -1)"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@StartDate", startDate)
                    command.Parameters.AddWithValue("@EndDate", endDate)
                    command.Parameters.AddWithValue("@UserID", userID)
                    connection.Open()

                    Using adapter As New OleDbDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Bind the DataTable to the DataGridView
                        Guna2DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnCSV.Click
        'SaveFileDialog to let the user choose the CSV file location
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "CSV Files (*.csv)|*.csv"
        saveFileDialog.Title = "Save CSV File"

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Get the selected file path
                Dim filePath As String = saveFileDialog.FileName

                '  StreamWriter to write data to the CSV file
                Using writer As New StreamWriter(filePath)
                    ' Write the column headers to the CSV file
                    Dim header As String = String.Join(",", Guna2DataGridView1.Columns.Cast(Of DataGridViewColumn).Select(Function(column) column.HeaderText))
                    writer.WriteLine(header)

                    ' Write the data rows to the CSV file
                    For Each row As DataGridViewRow In Guna2DataGridView1.Rows
                        Dim dataRow As String = String.Join(",", row.Cells.Cast(Of DataGridViewCell).Select(Function(cell) cell.Value))
                        writer.WriteLine(dataRow)
                    Next

                    MessageBox.Show("Data exported to CSV successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End Using
            Catch ex As Exception
                MessageBox.Show("Error exporting data to CSV: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Try
            'connection string for the Access database
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

            ' Get the user ID entered in the TextBox
            Dim userID As Integer
            If Integer.TryParse(txtUserID.Text, userID) Then
                ' SQL query to retrieve login records for the specified user
                Dim query As String = "SELECT ua.ID, ua.Fname, FORMAT(att.ClockIn, 'hh:mm') AS ClockIn, att.StatusIN, FORMAT(att.ClockOut, 'hh:mm') AS ClockOut, att.StatusOUT, att.Total_Time, att.Date_ " &
                                      "FROM usersadmins AS ua " &
                                      "INNER JOIN attendance AS att ON ua.Username = att.Username " &
                                      "WHERE ua.ID = @UserID"

                Using connection As New OleDbConnection(connectionString)
                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@UserID", userID)
                        connection.Open()

                        Using adapter As New OleDbDataAdapter(command)
                            Dim dataTable As New DataTable()
                            adapter.Fill(dataTable)

                            ' Bind the DataTable to the DataGridView
                            Guna2DataGridView1.DataSource = dataTable
                        End Using
                    End Using
                End Using
            Else
                MessageBox.Show("Please enter a valid user ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAll_Click(sender As Object, e As EventArgs) Handles btnAll.Click
        '  connection string for the Access database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

        '  SQL query to join the two tables based on the common column (Username)
        Dim query As String = "SELECT ua.ID, ua.Fname, FORMAT(att.ClockIn, 'hh:mm') AS ClockIn, att.StatusIN, FORMAT(att.ClockOut, 'hh:mm') AS ClockOut, att.StatusOUT, att.Total_Time, att.Date_ " &
                      "FROM usersadmins AS ua " &
                      "INNER JOIN attendance AS att ON ua.Username = att.Username"

        Try
            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    connection.Open()

                    Using adapter As New OleDbDataAdapter(command)
                        Dim dataTable As New DataTable()
                        adapter.Fill(dataTable)

                        ' Bind the DataTable to the DataGridView
                        Guna2DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CalculateMonthly_Click(sender As Object, e As EventArgs) Handles CalculateMonthly.Click

        Try
            ' Your connection string for the Access database
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

            ' Get the start and end dates for the current month
            Dim currentDate As Date = Date.Now.Date
            Dim startDate As Date = currentDate.AddDays(-currentDate.Day + 1)
            Dim endDate As Date = startDate.AddMonths(1).AddDays(-1)

            ' Your SQL query to calculate the total time for each user's records in the current month
            Dim query As String = "SELECT ua.ID, ua.Fname, ua.Surname, SUM(att.Total_Time) AS TotalTime " &
                                  "FROM usersadmins AS ua " &
                                  "INNER JOIN attendance AS att ON ua.Username = att.Username " &
                                  "WHERE (att.Date_ BETWEEN @StartDate AND @EndDate) " &
                                  "GROUP BY ua.ID, ua.Fname, ua.Surname"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@StartDate", startDate)
                    command.Parameters.AddWithValue("@EndDate", endDate)
                    connection.Open()

                    Using reader As OleDbDataReader = command.ExecuteReader()
                        Dim dataTable As New DataTable()
                        dataTable.Load(reader)

                        ' Bind the DataTable to the DataGridView
                        Guna2DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles CalculateWeekly.Click

        Try
            '  connection string for the Access database
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

            ' Get the start and end dates for the current week
            Dim currentDate As Date = Date.Now.Date
            Dim startDate As Date = currentDate.AddDays(-CInt(currentDate.DayOfWeek))
            Dim endDate As Date = startDate.AddDays(6)

            '  SQL query to calculate the total time for each user's records in the current week
            Dim query As String = "SELECT ua.ID, ua.Fname, ua.Surname, SUM(att.Total_Time) AS TotalTime " &
                                  "FROM usersadmins AS ua " &
                                  "INNER JOIN attendance AS att ON ua.Username = att.Username " &
                                  "WHERE (att.Date_ BETWEEN @StartDate AND @EndDate) " &
                                  "GROUP BY ua.ID, ua.Fname, ua.Surname"

            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@StartDate", startDate)
                    command.Parameters.AddWithValue("@EndDate", endDate)
                    connection.Open()

                    Using reader As OleDbDataReader = command.ExecuteReader()
                        Dim dataTable As New DataTable()
                        dataTable.Load(reader)

                        ' Bind the DataTable to the DataGridView
                        Guna2DataGridView1.DataSource = dataTable
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class