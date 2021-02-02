Public Class UserLogin

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        adminLoginForm.Show()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        UserDashboard.Show()
        Me.Hide()
    End Sub

    Private Sub lbReset_Click(sender As Object, e As EventArgs) Handles lbReset.Click
        ResetPassword.Show()
        Me.Hide()
    End Sub
End Class