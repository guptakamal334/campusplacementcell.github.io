Imports System.Data.SqlClient
Imports System.Data

Public Class student_record
	Dim con As SqlConnection
    Dim da As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Dim cmd2 As SqlCommand
    Dim cmd3 As SqlCommand

    Dim cs As String

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

        con = New SqlConnection(cs)
		con.Open()

        cmd = New SqlCommand("INSERT INTO student_rec values ('" + TextBox1.Text + "','" + ComboBox4.Text + "','" +
                             TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + ComboBox1.Text + "','" +
                             DateTimePicker1.Value + "','" + TextBox6.Text + "','" + ComboBox2.Text + "','" +
                             TextBox7.Text + "','" + TextBox8.Text + "','" + ComboBox3.Text + "','" + TextBox9.Text + "','" +
                             DateTimePicker2.Value + "')", con)

        Dim i As Integer = cmd.ExecuteNonQuery()
		If (i > 0) Then
            MessageBox.Show("Record saved successful")
            TextBox1.Text = ""
            clear()
        Else
			MessageBox.Show("Not saved ")
		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

        con = New SqlConnection(cs)
        con.Open()
        cmd1 = New SqlCommand("select * from student_rec where enrollment_no=@enrollment_no", con)
        cmd1.Parameters.Add("@enrollment_no", SqlDbType.VarChar).Value = TextBox1.Text

        Dim adapter As New SqlDataAdapter(cmd1)
        Dim table As New DataTable()
        adapter.Fill(table)
        clear()

        If table.Rows.Count() > 0 Then
            ComboBox4.Text = table.Rows(0)(1).ToString()
            TextBox3.Text = table.Rows(0)(2).ToString()
            TextBox4.Text = table.Rows(0)(3).ToString()
            TextBox5.Text = table.Rows(0)(4).ToString()
            ComboBox1.Text = table.Rows(0)(5).ToString()

            TextBox6.Text = table.Rows(0)(7).ToString()
            ComboBox2.Text = table.Rows(0)(8).ToString()
            TextBox7.Text = table.Rows(0)(9).ToString()
            TextBox8.Text = table.Rows(0)(10).ToString()

            TextBox9.Text = table.Rows(0)(12).ToString()
        Else
            MessageBox.Show("NO Data Found")
            TextBox1.Text = ""
        End If

    End Sub

    Private Sub clear()
        ComboBox4.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""

        TextBox6.Text = ""
        ComboBox2.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        ComboBox3.Text = ""
        TextBox9.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

            con = New SqlConnection(cs)
            con.Open()
            cmd2 = New SqlCommand("Update student_rec set  tittle='" + ComboBox4.Text + "', first_name='" +
                                  TextBox3.Text + "', middle_name='" + TextBox4.Text + "', last_name='" +
                                  TextBox5.Text + "', gender='" + ComboBox1.Text + "', dob='" +
                                  DateTimePicker1.Value + "', place_of_birth='" + TextBox6.Text + "', country='" +
                                  ComboBox2.Text + "', college_code='" + TextBox7.Text + "',college_name='" +
                                  TextBox8.Text + "', tounge='" + ComboBox3.Text + "', fluency='" +
                                  TextBox9.Text + "', date_of_join='" + DateTimePicker2.Value + "' where enrollment_no='" +
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
        Try
            cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"
            con.Open()
            cmd3 = New SqlCommand("delete from student_rec where enrollment_no='" + TextBox1.Text + "'", con)
            cmd3.ExecuteNonQuery()
            If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

                MsgBox("Operation Cancelled")

                Exit Sub

            End If
        Catch ex As Exception
            MessageBox.Show("Error while deleting record on table..." & ex.Message, "Delete Records")
            TextBox1.Text = ""
            clear()

            con.Close()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub student_record_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class