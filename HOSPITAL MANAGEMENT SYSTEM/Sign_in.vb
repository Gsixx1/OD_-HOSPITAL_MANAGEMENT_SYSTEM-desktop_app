Imports System.Data.SqlClient
Public Class Sign_in
    Dim Sapi
    Private Sub loginUserName_Click(sender As Object, e As EventArgs) Handles loginUserName.Click

    End Sub

    Private Sub LoginPassword_Click(sender As Object, e As EventArgs) Handles LoginPassword.Click

    End Sub

    Private Sub loginUserNameTxtBOX_TextChanged(sender As Object, e As EventArgs) Handles loginUserNameTxtBOX.TextChanged

    End Sub

    Private Sub loginPasswordTxtBOX_TextChanged(sender As Object, e As EventArgs) Handles loginPasswordTxtBOX.TextChanged

    End Sub

    Private Sub signupLink_Click(sender As Object, e As EventArgs) Handles signupLink.Click

    End Sub

    Private Sub signupLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles signupLink.LinkClicked
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If loginUserNameTxtBOX.Text = "" Then
            Sapi = CreateObject("Sapi.spvoice")
            Sapi.Speak("Please input your username")
        End If

        If loginPasswordTxtBOX.Text = "" Then
            Sapi = CreateObject("Sapi.spvoice")
            Sapi.Speak("Please input your Password")
        End If

        If loginUserNameTxtBOX.Text = "ODC" Then
            Sapi = CreateObject("Sapi.spvoice")
            Sapi.Speak("Your username is correct")
        Else
            Sapi = CreateObject("Sapi.spvoice")
            Sapi.Speak("Your username is not correct")
        End If

        If loginPasswordTxtBOX.Text = "ODC123" Then
            Sapi = CreateObject("Sapi.spvoice")
            Sapi.Speak("Your Password is correct")
        Else
            Sapi = CreateObject("Sapi.spvoice")
            Sapi.Speak("Your Password is not correct")
        End If



        Dim connection As New SqlConnection("Server=DESKTOP-U1P4832\SQLEXPRESS;DATABASE=odc_HMS;Integrated Security=true")
        Dim group1 As Integer = 1
        Dim command As New SqlCommand("select * from admin_login where USERNAME=@USERNAME and ADMIN_PASSWORD=@ADMIN_PASSWORD", connection)
        command.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = loginUserNameTxtBOX.Text
        command.Parameters.Add("@ADMIN_PASSWORD", SqlDbType.VarChar).Value = loginPasswordTxtBOX.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() >= 1 Then
            MessageBox.Show("Login Successfully")
            Dashboard.Show()
        Else
            MessageBox.Show("Username or Password is incorrect you have" & group1 & "chance left")
            group1 = +1

            If group1 = 3 Then
                MessageBox.Show("You have exhausted your three chances")
            ElseIf group1 = 4 Then
                MessageBox.Show("You do not have any chances left")
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class