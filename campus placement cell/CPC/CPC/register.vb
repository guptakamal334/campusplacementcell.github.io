Imports System.Data.SqlClient
Imports System.Data
Imports System.ComponentModel

Public Class register
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter


    Dim cs As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

        con = New SqlConnection(cs)
        con.Open()
        cmd = New SqlCommand("INSERT INTO logintable values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + DateTimePicker1.Value + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "')", con)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            clear()
            MessageBox.Show("Record saved successful")
        Else
            MessageBox.Show("Not saved ")
        End If
    End Sub
    Private Sub clear()
        TextBox1.Text = ""
        TextBox2.Text = ""

        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating

        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "first_name Should not Blank")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating

        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Last_name Should not Blank")
        Else
            ErrorProvider1.SetError(TextBox2, "")
        End If
    End Sub

    Private Sub datetimepicker1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If DateTimePicker1.Text = "" Then
            ErrorProvider1.SetError(DateTimePicker1, "Date of Birth Should not Blank")
        Else
            ErrorProvider1.SetError(DateTimePicker1, "")
        End If
    End Sub


    Private Sub TextBox3_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox4, "mobile number Should not Blank")
        Else
            ErrorProvider1.SetError(TextBox4, "")
        End If
    End Sub

    Private Sub TextBox4_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If TextBox5.Text = "" Then
            ErrorProvider1.SetError(TextBox5, "Email_id Should not Blank")
        Else
            ErrorProvider1.SetError(TextBox5, "")
        End If
    End Sub

    Private Sub TextBox5_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If TextBox6.Text = "" Then
            ErrorProvider1.SetError(TextBox6, "Passworrd Should not Blank")
        Else
            ErrorProvider1.SetError(TextBox6, "")
        End If
    End Sub



    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class