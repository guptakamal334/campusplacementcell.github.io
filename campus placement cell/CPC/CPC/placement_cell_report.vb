Imports System.Data.SqlClient
Imports System.Data

Public Class placement_cell_report

    Dim con As SqlConnection

    Dim cmd As SqlCommand

    Dim cs As String

    Private Sub placement_cell_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cs = "Data Source=DESKTOP-O6OC1N4\KAMALSQL;Initial Catalog=vbdata;Integrated Security=True"
        con = New SqlConnection(cs)
        con.Open()
        cmd = New SqlCommand("select * from placement_cel", con)
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


End Class




