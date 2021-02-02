Public Class UserForm
    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
            if Not (Asc(e.KeyChar) = 8) Then
                if Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar)<90) Then
                    e.KeyChar = ChrW(0)
                    e.Handles = True
                End if
            End If
        
    End Sub

    Private Sub txtMemberID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemberID.KeyPress
            if Not (Asc(e.KeyChar) = 8) Then
                if Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar)<90) Then
                    e.KeyChar = ChrW(0)
                    e.Handles = True
                End if
            End If
        
    End Sub

End Class
