Imports System.Data.OleDb
Imports System.IO
Public Class Employee_Records

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

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

    Private Sub Employee_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  variables to hold the counts 
        Dim itCount As Integer = 0
        Dim clothingCount As Integer = 0
        Dim woodTechCount As Integer = 0
        Dim electronicsCount As Integer = 0
        Dim admin As Integer = 0
        Dim user As Integer = 0

        ' Create a DataTable with columns and add it to the DataGridView
        ''Dim dataTable As New DataTable()


        'TODO: This line of code loads data into the 'NamesDataSet.test' table. You can move, or remove it, as needed.
        Me.TestTableAdapter.Fill(Me.NamesDataSet.test)
        ' Your connection string for the Access database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

        ' Perform the database query to select records where ID is not '#Deleted'
        Dim query As String = "SELECT ID, Fname, Surname, Type, Email, Dept, Phone FROM usersadmins ORDER BY ID"

        Try
            Using connection As New OleDbConnection(connectionString)
                Using command As New OleDbCommand(query, connection)
                    connection.Open()

                    Using adapter As New OleDbDataAdapter(command)
                        Dim dataTable As New DataTable()

                        adapter.Fill(dataTable)

                        ' Bind the DataTable to the DataGridView
                        Guna2DataGridView1.DataSource = dataTable

                        ' Loop through the rows in the DataTable and count the number of people in each department
                        For Each row As DataRow In dataTable.Rows
                            Dim department As String = row("Dept").ToString()
                            Dim userType As String = row("Type").ToString()

                            Select Case department
                                Case "IT"
                                    itCount += 1
                                Case "CLOTHING"
                                    clothingCount += 1
                                Case "WOOD TECH"
                                    woodTechCount += 1
                                Case "ELECTRONICS"
                                    electronicsCount += 1
                            End Select

                            Select Case userType
                                Case "user"
                                    user += 1
                                Case "admin"
                                    admin += 1
                            End Select
                        Next

                        '' Guna2DataGridView1.DataSource = dataTable
                        ' Display the counts in the label 
                        lblDepartmentCounts.Text = "ELECTRONICS - " & electronicsCount
                        lblIT.Text = "IT - " & itCount
                        lblcloth.Text = "CLOTHING - " & clothingCount
                        lblwood.Text = "WOOD TECH - " & woodTechCount
                        lbladmin.Text = "ADMINS - " & admin
                        lbluser.Text = "USERS - " & user

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

    End Sub
End Class