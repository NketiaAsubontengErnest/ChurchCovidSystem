Public Class UserDashboard
    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AttendanceToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AttendanceToolStripMenuItem1.Click
        AttendanceForm.Show()
    End Sub

    Private Sub AddMemberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMemberToolStripMenuItem.Click
        MemberForm.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click
        ReportsForm.Show()
    End Sub
End Class