Public Class UserLogin
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
    
    Private Sub txtUsername(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        if Not (Asc(e.KeyChar) = 8) Then
            if Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar)<90) Then
                e.KeyChar = ChrW(0)
                e.Handles = True
            End if
        End If
       
    End Sub

End Class