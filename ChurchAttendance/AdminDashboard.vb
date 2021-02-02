Public Class AdminDashboard
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MemberForm.Show()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Me.Hide()
        UserForm.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Hide()
        ServiceForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub AddMenberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMenberToolStripMenuItem.Click
        MemberForm.Show()
    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        UserForm.Show()
    End Sub

    Private Sub AddServiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddServiceToolStripMenuItem.Click
        ServiceForm.Show()
    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        ReportsForm.Show()
    End Sub

    Private Sub AdminDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class