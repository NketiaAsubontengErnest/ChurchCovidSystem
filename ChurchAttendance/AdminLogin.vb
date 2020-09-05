Public Class adminLoginForm
    Private Sub lbUser_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MemberForm.Show()
    End Sub

    Private Sub btnAdLogout_Click(sender As Object, e As EventArgs) Handles btnAdLogout.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Hide()
        AdminDashboard.Show()

    End Sub
End Class
