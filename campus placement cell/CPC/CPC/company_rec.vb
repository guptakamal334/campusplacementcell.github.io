Imports System.Data.SqlClient
Imports System.Data

Public Class company_rec
	Dim con As SqlConnection
	Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Dim cmd2 As SqlCommand


    Dim cs As String

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

            con = New SqlConnection(cs)
            con.Open()
            cmd = New SqlCommand("INSERT INTO company_rec values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" + TextBox10.Text + "')", con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("Record saved successful", "Success", MessageBoxButtons.YesNo)
            Else
                MessageBox.Show("Not saved ")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Close()
	End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

        con = New SqlConnection(cs)
        con.Open()
        cmd1 = New SqlCommand("select * from company_rec where company_code=@company_code", con)
        cmd1.Parameters.Add("@company_code", SqlDbType.VarChar).Value = TextBox1.Text

        Dim adapter As New SqlDataAdapter(cmd1)
        Dim table As New DataTable()
        adapter.Fill(table)

        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""

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
        End If



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

            con = New SqlConnection(cs)
        con.Open()
        cmd2 = New SqlCommand("Update company_rec set  company_name='" + TextBox2.Text + "', rank='" + TextBox3.Text + "', status='" + TextBox4.Text + "', headoffice='" + TextBox5.Text + "', Address='" + TextBox6.Text + "', phone_no1='" + TextBox7.Text + "', phone_no2='" + TextBox8.Text + "', mobile_no='" + TextBox9.Text + "', fax='" + TextBox10.Text + "' where company_code='" + TextBox1.Text + "'", con)
            Dim i As Integer = cmd2.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("Record Update successful", "Success")
                TextBox1.Text = ""
                TextBox2.Text = ""
                TextBox3.Text = ""
                TextBox4.Text = ""
                TextBox5.Text = ""
                TextBox6.Text = ""
                TextBox7.Text = ""
                TextBox8.Text = ""
                TextBox9.Text = ""
                TextBox10.Text = ""

            Else
            MessageBox.Show("Not saved ")
        End If
        Catch ex As Exception
        MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub company_rec_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class