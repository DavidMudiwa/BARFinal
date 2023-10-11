Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions
Public Class Register_Admin

    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles passwordTextBox.TextChanged

    End Sub
    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles surnameTextBox.TextChanged

    End Sub
    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles registerAdminbtn.Click
        Dim firstName As String = nameTextBox.Text
        Dim lastName As String = surnameTextBox.Text
        Dim Uname As String = usernameTextBox.Text
        Dim email As String = emailTextBox.Text
        Dim phone As String = contactTextBox.Text
        Dim pass As String = passwordTextBox.Text
        Dim dept As String = deptComboBox.Text



        Dim accType As String = "admin"
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
        Dim selectedValue As String = deptComboBox.SelectedItem

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
                        MessageBox.Show("Administrator added successfully.")
                        cleartextFields()

                    Else
                        MessageBox.Show("Failed to add Admin.")
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred: " + ex.Message)
                End Try
            End Using
        End Using

    End Sub

    Private Sub contactTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles contactTextBox.KeyPress
        ' Allow only numeric input and control keys
        If (Not Char.IsDigit(e.KeyChar)) AndAlso (Not Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If

        ' Limit the maximum number of digits to 10
        If contactTextBox.TextLength >= 10 AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Public Sub cleartextFields()
        nameTextBox.Text = ""
        surnameTextBox.Text = ""
        usernameTextBox.Text = ""
        emailTextBox.Text = ""
        contactTextBox.Text = ""
        passwordTextBox.Text = ""
        deptComboBox.SelectedIndex = -1
    End Sub
    Private Sub contactTextBox_TextChanged(sender As Object, e As EventArgs) Handles contactTextBox.TextChanged
      
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        cleartextFields()
    End Sub
End Class