Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class MyProfile

    Private Sub MyProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call your function to populate textboxes
        '' GetProfileDataFromDatabase(Form1.useriid)
    End Sub
    ''
    Public connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"






    Private Sub editButton_Click(sender As Object, e As EventArgs) Handles editButton.Click
        LoadUserProfile(Form1.useriid)
        'Enable textboxes for editing
        nametxt.Enabled = True
        surnameTextBox.Enabled = True
        usernameTextBox.Enabled = True
        emailTextBox.Enabled = True
        contactTextBox.Enabled = True
        passwordTextBox.Enabled = True
        Guna2ComboBox1.Enabled = True
        editButton.Enabled = False
        SaveButton.Enabled = True
        cancelButton1.Enabled = True

    End Sub

    Private Sub Guna2GroupBox1_Click(sender As Object, e As EventArgs) Handles Guna2GroupBox1.Click

    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Dim firstName As String = nametxt.Text
        Dim lastName As String = surnameTextBox.Text
        Dim Uname As String = "reg11"
        Dim email As String = emailTextBox.Text
        Dim phone As String = contactTextBox.Text
        Dim pass As String = passwordTextBox.Text
        Dim dept As String = Guna2ComboBox1.Text

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"


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
        Dim selectedValue As String = Guna2ComboBox1.SelectedItem

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

        Try
            ''If Not AreProfileFieldsEqual(currentProfileData) Then
            Using conn As New OleDbConnection(connectionString)
                conn.Open()
                Dim query As String = "UPDATE  usersadmins SET Fname=@Fname, Surname=@Surname, Username=@Username, Pasword=@Pasword, Email=@Email, Dept=@Dept, Phone=@Phone  WHERE ID=@ID"
                Using command As New OleDbCommand(query, conn)
                    command.Parameters.AddWithValue("@ID", Form1.useriid)
                    command.Parameters.AddWithValue("@Fname", nametxt.Text)
                    command.Parameters.AddWithValue("@Surname", lastName)
                    command.Parameters.AddWithValue("@Username", Uname)
                    command.Parameters.AddWithValue("@Pasword", pass)
                    command.Parameters.AddWithValue("@Email", email)
                    command.Parameters.AddWithValue("@Dept", dept)
                    command.Parameters.AddWithValue("@Phone", phone)
                    command.ExecuteNonQuery()

                End Using

            End Using
            MessageBox.Show("Profile Updated Successfully!")
        Catch ex As Exception
            MessageBox.Show("An error occured: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        


        '' Else
        '' MessageBox.Show("No changes were made to your Profile!")
        '' End If

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

    Private Sub cancelButton1_Click(sender As Object, e As EventArgs) Handles cancelButton1.Click
        Dim userid As Integer = Form1.useriid
       
        LoadUserProfile(userid)
    End Sub
    Public Sub LoadUserProfile(userID As Integer)
        ' Define your database connection string
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

        ' Create a connection to the database
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Define a query to retrieve user profile data based on the user's ID
            Dim query As String = "SELECT Fname, Surname, Username, Pasword, Email, Dept, Phone FROM usersadmins WHERE ID = @ID"

            ' Create a command with parameters
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@ID", userID)

                ' Execute the query and retrieve the data
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Populate the textboxes and combo box with the retrieved data
                        nametxt.Text = reader("Fname").ToString()
                        surnameTextBox.Text = reader("Surname").ToString()
                        usernameTextBox.Text = reader("Username").ToString()
                        passwordTextBox.Text = reader("Pasword").ToString() ' Note: Password should not be displayed in a real application.
                        emailTextBox.Text = reader("Email").ToString()
                        contactTextBox.Text = reader("Phone").ToString()
                        Guna2ComboBox1.Text = reader("Dept").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub
    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        ' Define your database connection string
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= |DataDirectory|\BAR.accdb"

        ' Create a connection to the database
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Define a query to retrieve user profile data based on the user's ID
            Dim query As String = "SELECT Fname, Surname, Username, Pasword, Email, Dept, Phone FROM usersadmins WHERE ID = @ID"

            ' Create a command with parameters
            Using cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@ID", Form1.useriid)

                ' Execute the query and retrieve the data
                Using reader As OleDbDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        ' Populate the textboxes and combo box with the retrieved data
                        nametxt.Text = reader("Fname").ToString()
                        surnameTextBox.Text = reader("Surname").ToString()
                        usernameTextBox.Text = reader("Username").ToString()
                        passwordTextBox.Text = reader("Pasword").ToString() ' Note: Password should not be displayed in a real application.
                        emailTextBox.Text = reader("Email").ToString()
                        contactTextBox.Text = reader("Phone").ToString()
                        Guna2ComboBox1.Text = reader("Dept").ToString()
                    End If
                End Using
            End Using
        End Using
    End Sub

    Private Sub contactTextBox_TextChanged(sender As Object, e As EventArgs) Handles contactTextBox.TextChanged

    End Sub
    Private Sub emailTextBox_TextChanged(sender As Object, e As EventArgs) Handles emailTextBox.TextChanged

    End Sub
    Private Sub passwordTextBox_TextChanged(sender As Object, e As EventArgs) Handles passwordTextBox.TextChanged

    End Sub
    Private Sub usernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles usernameTextBox.TextChanged

    End Sub
    Private Sub surnameTextBox_TextChanged(sender As Object, e As EventArgs) Handles surnameTextBox.TextChanged

    End Sub
    Private Sub nametxt_TextChanged(sender As Object, e As EventArgs) Handles nametxt.TextChanged

    End Sub

   
End Class