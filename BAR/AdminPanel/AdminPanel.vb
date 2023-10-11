Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class AdminPanel
    Sub childform(ByVal panel As Form)
        Guna2Panel3.Controls.Clear()
        panel.TopLevel = False
        Guna2Panel3.Controls.Add(panel)
        panel.Show()

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        childform(Register_Admin)
        Guna2Button1.Checked = True
        Guna2Button2.Checked = False
        Guna2Button4.Checked = False
        Guna2Button6.Checked = False
        '' Guna2Button3.Checked = False

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        childform(User_Management)
        Guna2Button2.Checked = True
        Guna2Button1.Checked = False
        Guna2Button4.Checked = False
        Guna2Button6.Checked = False
        '' Guna2Button3.Checked = False
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        childform(Employee_Records)
        Guna2Button4.Checked = True
        Guna2Button2.Checked = False
        Guna2Button1.Checked = False
        Guna2Button6.Checked = False
        ''  Guna2Button3.Checked = False
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        childform(Attendance_Records)
        Guna2Button6.Checked = True
        '' Guna2Button3.Checked = False
        Guna2Button4.Checked = False
        Guna2Button2.Checked = False
        Guna2Button1.Checked = False

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim logIn As New Form1
        Form1.Show()

        Me.Close()

    End Sub

    Private Sub AdminPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub timecheckButton_Click(sender As Object, e As EventArgs) Handles timecheckButton.Click
        'only admins can disable time check feature
        If Form1.internetTimecheckedEnabled = True Then
            Form1.internetTimecheckedEnabled = False
            timecheckButton.Text = "TimeCheck"
            timecheckButton.Checked = False
            MessageBox.Show("Time check turned off", "Off", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Form1.internetTimecheckedEnabled = True
            timecheckButton.Text = "TimeCheck ON"
            timecheckButton.Checked = True
            MessageBox.Show("Time check turned ON", "ON", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub
End Class