Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Form1
    Dim connection As New SqlConnection("Server=DESKTOP-U1P4832\SQLEXPRESS;DATABASE=odc_HMS;Integrated Security=true")
    Dim Sapi
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lastNametxtBox_TextChanged(sender As Object, e As EventArgs) Handles lastNametxtBox.TextChanged

    End Sub

    Private Sub firstNametxtBox_TextChanged(sender As Object, e As EventArgs) Handles firstNametxtBox.TextChanged

    End Sub

    Private Sub genderTextBox_TextChanged(sender As Object, e As EventArgs) Handles genderTextBox.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles emailTextBox.TextChanged

    End Sub

    Private Sub countryTextBox_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SignUpPasswordTXTBox_TextChanged(sender As Object, e As EventArgs) Handles SignUpPasswordTXTBox.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insert As String = "INSERT INTO admin_signup(FNAME, LNAME, GENDER, PHONE_NUMBER, EMAIL, ADDRESS1, PASSWORD1)VALUES('" & firstNametxtBox.Text & "', '" & lastNametxtBox.Text & "', '" & genderTextBox.Text & "', '" & phoneNumber.Text & "', '" & emailTextBox.Text & "', '" & addressTextBox.Text & "', '" & SignUpPasswordTXTBox.Text & "' )"
        executeQuery(insert)
        Dim command As New SqlCommand(insert, connection)
        MessageBox.Show("Data Succesfully Inserted into the database")
    End Sub

    
    Public Sub executeQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Sign_in.Show()
    End Sub
End Class
