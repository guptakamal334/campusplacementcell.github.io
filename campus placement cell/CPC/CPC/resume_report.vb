Imports System.Data.SqlClient
Imports System.Data

Public Class resume_report

    Dim con As SqlConnection

    Dim cmd As SqlCommand

    Dim cs As String

    Private Sub resume_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"
        con = New SqlConnection(cs)
        con.Open()
        cmd = New SqlCommand("select * from resume", con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        DataGridView1.DataSource = table

        DataGridView1.ColumnHeadersDefaultCellStyle.Font = New Font("Tahoma", 15, FontStyle.Bold)
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Blue
        DataGridView1.EnableHeadersVisualStyles = False
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class



