
Imports System.Data.SqlClient
Imports System.Data
Imports System.ComponentModel

Public Class Form1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim dt As DataTable

    Dim cs As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

            con = New SqlConnection(cs)
            Dim email_id As String = TextBox1.Text
            Dim password As String = TextBox2.Text


            cmd = New SqlCommand("select email_id,password from logintable where email_id='" + TextBox1.Text + "'and password='" + TextBox2.Text + "'", con)
            da = New SqlDataAdapter(cmd)
            dt = New DataTable()
            da.Fill(dt)
            If (dt.Rows.Count > 0) Then
                Name = TextBox1.Text
                MessageBox.Show("LOGIN SUCCESSFUL", "verified", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                TextBox1.Text = ""
                TextBox2.Text = ""
                home.Show()
                Me.Hide()

            Else
                clear()
                MessageBox.Show("INVALID LOGIN INFORMATION")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub clear()
        TextBox2.Clear()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As DialogResult
        a = MessageBox.Show("Are You Sure ! Do You want to Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Hand)
        If a = Windows.Forms.DialogResult.Yes Then

            Me.Close()

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked

        register.Show()

    End Sub



    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Username Should not Blank")
        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If



    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Password not blank")
        Else
            ErrorProvider1.SetError(TextBox2, "")
        End If
    End Sub
End Class
