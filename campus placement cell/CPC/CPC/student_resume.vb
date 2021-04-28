Imports System.Data.SqlClient
Imports System.Data

Public Class student_resume
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

        cmd = New SqlCommand("INSERT INTO resume values ('" + TextBox1.Text + "','" + TextBox2.Text + "','" +
                              TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" +
                             TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "','" +
                             ComboBox1.Text + "','" + TextBox10.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" +
                             ComboBox2.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','" +
                             RichTextBox1.Text + "','" + RichTextBox2.Text + "','" + DateTimePicker1.Value + "','" + TextBox16.Text + "','" +
                             ComboBox3.Text + "','" + ComboBox4.Text + "','" + ComboBox5.Text + "','" + ComboBox6.Text + "','" +
                             TextBox17.Text + "')", con)
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
        ComboBox1.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        ComboBox2.Text = ""
        TextBox13.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""
        RichTextBox1.Text = ""
        RichTextBox2.Text = ""
        TextBox16.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        TextBox17.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"

        con = New SqlConnection(cs)
        con.Open()
        cmd1 = New SqlCommand("select * from resume where name=@name", con)
        cmd1.Parameters.Add("@name", SqlDbType.VarChar).Value = TextBox1.Text

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
            ComboBox1.Text = table.Rows(0)(9).ToString()
            TextBox10.Text = table.Rows(0)(10).ToString()
            TextBox11.Text = table.Rows(0)(11).ToString()
            TextBox12.Text = table.Rows(0)(12).ToString()
            ComboBox2.Text = table.Rows(0)(13).ToString()
            TextBox13.Text = table.Rows(0)(14).ToString()
            TextBox14.Text = table.Rows(0)(15).ToString()
            TextBox15.Text = table.Rows(0)(16).ToString()
            RichTextBox1.Text = table.Rows(0)(17).ToString()
            RichTextBox2.Text = table.Rows(0)(18).ToString()
            TextBox16.Text = table.Rows(0)(20).ToString()
            ComboBox3.Text = table.Rows(0)(21).ToString()
            ComboBox4.Text = table.Rows(0)(22).ToString()
            ComboBox5.Text = table.Rows(0)(23).ToString()
            ComboBox6.Text = table.Rows(0)(24).ToString()
            TextBox17.Text = table.Rows(0)(25).ToString()

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
            cmd2 = New SqlCommand("Update resume set  email_id='" + TextBox2.Text + "',  mobile_no='" +
                                  TextBox3.Text + "', hspercentage='" + TextBox4.Text + "', hsypass='" +
                                  TextBox5.Text + "', hscname='" + TextBox6.Text + "', ipercentage='" +
                                  TextBox7.Text + "', iypass='" + TextBox8.Text + "', icname='" +
                                  TextBox9.Text + "', graduation='" + ComboBox1.Text + "',gpercentage='" +
                                  TextBox10.Text + "', gypass='" + TextBox11.Text + "', gcname='" +
                                  TextBox12.Text + "', pgraduation='" + ComboBox2.Text + "' , pgpercentage='" +
                                  TextBox13.Text + "', pgypass='" + TextBox14.Text + "', pgcname='" +
                                  TextBox15.Text + "', additional_qualification='" + RichTextBox1.Text + "' , work_experience='" +
                                   RichTextBox2.Text + "' , date_of_birth='" + DateTimePicker1.Value + "' , father_name='" +
                                    TextBox16.Text + "' , nationality='" + ComboBox3.Text + "' , marital_status='" +
                                    ComboBox4.Text + "', language='" + ComboBox5.Text + "' , gender='" +
                                    ComboBox6.Text + "' ,address='" + TextBox17.Text + "' 
                                  where name='" + TextBox1.Text + "'", con)

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






