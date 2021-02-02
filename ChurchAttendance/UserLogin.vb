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

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        if Not (Asc(e.KeyChar) = 8) And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            if Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar)<90) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End if
        End If
       
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class