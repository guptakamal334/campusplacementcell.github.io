
Imports System.Data.SqlClient
Imports System.Data

Public Class Placement_cel
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Dim cmd2 As SqlCommand
    Dim da As SqlDataAdapter


    Dim cs As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

        con = New SqlConnection(cs)
        con.Open()
        cmd = New SqlCommand("INSERT INTO placement_cel values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" +
                             TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" +
                             TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "')", con)
        Dim i As Integer = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MessageBox.Show("Record saved successful")
            TextBox1.Text = ""
            clear()
        Else
            MessageBox.Show("Not saved ")
        End If
    End Sub
    Private Sub clear()
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

        con = New SqlConnection(cs)
        con.Open()
        cmd1 = New SqlCommand("select * from placement_cel where panel=@panel", con)
        cmd1.Parameters.Add("@panel", SqlDbType.VarChar).Value = TextBox1.Text

        Dim adapter As New SqlDataAdapter(cmd1)
        Dim table As New DataTable()
        adapter.Fill(table)
        clear()

        If table.Rows.Count() > 0 Then
            TextBox2.Text = table.Rows(0)(1).ToString()
            TextBox3.Text = table.Rows(0)(2).ToString()
            TextBox4.Text = table.Rows(0)(3).ToString()
            TextBox5.Text = table.Rows(0)(4).ToString()
            TextBox6.Text = table.Rows(0)(5).ToString()
            TextBox7.Text = table.Rows(0)(6).ToString()
            TextBox8.Text = table.Rows(0)(7).ToString()
            TextBox9.Text = table.Rows(0)(8).ToString()
            TextBox10.Text = table.Rows(0)(9).ToString()
        Else
            MessageBox.Show("NO Data Found")
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

            con = New SqlConnection(cs)
            con.Open()
            cmd2 = New SqlCommand("Update placement_cel set  cell_code='" + TextBox2.Text + "', name='" +
                                  TextBox3.Text + "', staff_code='" + TextBox4.Text + "', department='" +
                                  TextBox5.Text + "', designation='" + TextBox6.Text + "', assign_college='" +
                                  TextBox7.Text + "', college_code='" + TextBox8.Text + "', college_name='" +
                                  TextBox9.Text + "', salary='" + TextBox10.Text + "' where panel='" +
                                   TextBox1.Text + "'", con)

            Dim i As Integer = cmd2.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("Record Update successful", "Success")
                TextBox1.Text = ""
                clear()
            Else
                MessageBox.Show("Not saved ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
End Class