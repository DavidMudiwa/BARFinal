Imports System.Data.OleDb
Public Class User_Management

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles idTextBox.TextChanged

    End Sub
    Private Sub Guna2TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles deleteButton2.Click
        ' Get the user ID entered by the admin
        Dim userId As String = idTextBox.Text.Trim()

        ' Check if the user ID is empty
        If String.IsNullOrEmpty(userId) Then
            MessageBox.Show("Please enter a user ID before clicking the 'Delete' button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Your connection string for the Access database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

        ' Perform the database DELETE operation
        Dim query As String = "DELETE FROM usersadmins WHERE ID = @ID"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                ' Add parameters to the query
                command.Parameters.AddWithValue("@ID", userId)

                Try
                    connection.Open()
                    Dim rowsAffected As Integer = command.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Clear the text box after successful deletion
                        idTextBox.Clear()
                        nameTextBox1.Clear()
                        surnameTextBox3.Clear()
                        usernameTextBox4.Clear()
                        passwordTextBox5.Clear()
                        emailTextBox6.Clear()
                        contactTextBox7.Clear()
                        dept2ComboBox.SelectedIndex = -1
                    Else
                        MessageBox.Show("User not found or an error occurred.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles searchButton1.Click
        ' Get the user ID entered by the admin
        Dim userId As String = idTextBox.Text.Trim()

        ' Check if the user ID is empty
        If String.IsNullOrEmpty(userId) Then
            MessageBox.Show("Please enter a user ID before clicking the 'Search' button.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Your connection string for the Access database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

        ' Perform the database query
        Dim query As String = "SELECT Fname, Surname, Username, Pasword, Type, Email, Dept, Phone FROM usersadmins WHERE ID = @ID"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                ' Add parameters to the query
                command.Parameters.AddWithValue("@ID", userId)

                Try
                    connection.Open()
                    Dim reader As OleDbDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        ' Populate the text boxes with the retrieved information
                        nameTextBox1.Text = reader("Fname").ToString()
                        surnameTextBox3.Text = reader("Surname").ToString()
                        usernameTextBox4.Text = reader("Username").ToString()
                        passwordTextBox5.Text = reader("Pasword").ToString
                        emailTextBox6.Text = reader("Email").ToString()
                        contactTextBox7.Text = reader("Phone").ToString()
                        dept2ComboBox.Text = reader("Dept").ToString()
                    Else
                        MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles ClearButton3.Click
        nameTextBox1.Text = ""
        surnameTextBox3.Text = ""
        usernameTextBox4.Text = ""
        passwordTextBox5.Text = ""
        emailTextBox6.Text = ""
        contactTextBox7.Text = ""
        dept2ComboBox.SelectedIndex = -1
    End Sub
End Class