Public Class home
    Private Sub StudentToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StudentToolStripMenuItem1.Click
        student_record.Show()
    End Sub

    Private Sub CollegeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollegeToolStripMenuItem.Click
        College_rec.Show()
    End Sub

    Private Sub CompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyToolStripMenuItem.Click
        company_rec.Show()
    End Sub

    Private Sub PlacementToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlacementToolStripMenuItem.Click
        Placement_cel.Show()
    End Sub

    Private Sub PanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanelToolStripMenuItem.Click
        panel.Show()
    End Sub

    Private Sub StudentListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentListToolStripMenuItem.Click
        student_report.Show()
    End Sub

    Private Sub ToolStripContainer1_ContentPanel_Load(sender As Object, e As EventArgs) Handles ToolStripContainer1.ContentPanel.Load
        Label2.Text = Form1.Name
    End Sub

    Private Sub ResumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumeToolStripMenuItem.Click
        student_resume.Show()
    End Sub

    Private Sub FToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FToolStripMenuItem.Click

    End Sub

    Private Sub CollegeReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CollegeReportToolStripMenuItem.Click
        college_report.Show()
    End Sub

    Private Sub CompanyReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompanyReportToolStripMenuItem.Click
        company_report.Show()
    End Sub

    Private Sub PlacementStaffListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlacementStaffListToolStripMenuItem.Click
        placement_cell_report.Show()
    End Sub

    Private Sub PlaceInCompanyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlaceInCompanyToolStripMenuItem.Click
        selected_student_report.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub RsumeListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RsumeListToolStripMenuItem.Click
        resume_report.Show()
    End Sub

    Private Sub PanelReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PanelReportToolStripMenuItem.Click
        panel_report.Show()
    End Sub
End Class