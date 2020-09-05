Public Class ResetPassword
    Private Sub btnResetExit_Click(sender As Object, e As EventArgs) Handles btnResetExit.Click
        UserLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click


        UserLogin.Show()
        Me.Hide()
    End Sub
End Class