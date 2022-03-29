Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Public Class Dashboard
    Dim connection As New SqlConnection("Server=DESKTOP-U1P4832\SQLEXPRESS;DATABASE=odc_HMS;Integrated Security=true")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insert As String = "INSERT INTO DOCTORS(FNAME, LNAME, DEPARTMENT, CONTACT_NUMBER, DOCTORS_ADDRESS, EMAIL)VALUES('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "')"
        executeQuery(insert)
        Dim command As New SqlCommand(insert, connection)
        MessageBox.Show("Data for doctors has been inserted to the database")
    End Sub
    Public Sub executeQuery(query As String)
        Dim command As New SqlCommand(query, connection)
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim k As String = "INSERT INTO NURSES(FNAME, LNAME, DERPARTMENT, CONTACT_NUMBER, NURSES_ADDRESS, EMAIL)VALUES('" & TextBox9.Text & "', '" & TextBox11.Text & "', '" & TextBox12.Text & "', '" & TextBox7.Text & "', '" & TextBox10.Text & "', '" & TextBox8.Text & "')"
        tQuery(k)
        Dim p As New SqlCommand(k, connection)
        MessageBox.Show("Data for nurses has been inserted successfully")
    End Sub
    Public Sub tQuery(query As String)
        Dim p As New SqlCommand(query, connection)
        connection.Open()
        p.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String = "INSERT INTO DEPARTMENT(DNAME, DEPARTMENT_HEAD, DEPARTMENT_MANAGER, BRANCH_NAME, DEPARTMENT_ADDRESS, DEPARTMENT_LOCATION)VALUES('" & TextBox15.Text & "', '" & TextBox17.Text & "', '" & TextBox18.Text & "', '" & TextBox13.Text & "', '" & TextBox16.Text & "', '" & TextBox14.Text & "')"
        hQuery(a)
        Dim b As New SqlCommand(a, connection)
        MessageBox.Show("Department data has been successfully stored")
    End Sub
    Public Sub hQuery(query As String)
        Dim b As New SqlCommand(query, connection)
        connection.Open()
        b.ExecuteNonQuery()
        connection.Close()
    End Sub
    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim s As String = "INSERT INTO SUPPLIER(FNAME, LNAME, PHONE_NUMBER, SUPPLIER_ADDRESS, COMPANY, EMAIL)VALUES('" & TextBox21.Text & "', '" & TextBox23.Text & "', '" & TextBox24.Text & "', '" & TextBox19.Text & "', '" & TextBox22.Text & "', '" & TextBox20.Text & "')"
        uQuery(s)
        Dim t As New SqlCommand(s, connection)
        MessageBox.Show("Successful")
    End Sub
    Public Sub uQuery(query As String)
        Dim t As New SqlCommand(query, connection)
        connection.Open()
        t.ExecuteNonQuery()
        connection.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim drug As String = "INSERT INTO DRUGS(DRNAME, SUPPLIER, PAYMENT_METHOD, DELIVERY, MANUFACTURER, COUNTRY)VALUES( '" & TextBox27.Text & "', '" & TextBox29.Text & "', '" & TextBox30.Text & "', '" & TextBox25.Text & "', '" & TextBox28.Text & "', '" & TextBox26.Text & "')"
        dashQuery(drug)
        Dim board As New SqlCommand(drug, connection)
        MessageBox.Show("Thank you")
    End Sub
    Public Sub dashQuery(Query As String)
        Dim board As New SqlCommand(Query, connection)
        connection.Open()
        board.ExecuteNonQuery()
        connection.Close()
    End Sub

    
End Class