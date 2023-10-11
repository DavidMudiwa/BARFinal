Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class UserPanel
    Sub childform(ByVal panel As Form)
        Guna2Panel3.Controls.Clear()
        panel.TopLevel = False
        Guna2Panel3.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        ''show home panel
        childform(Home)

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ''show clockin panel
        childform(ClockIn)
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        ''show clockout panel
        childform(ClockOut)
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        

        childform(MyProfile)


    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim logIn As New Form1
        Form1.Show()

        Me.Close()

    End Sub
End Class