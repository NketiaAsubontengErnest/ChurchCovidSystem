Public Class MemberForm
    Private Sub txtMiddleName_KeyPress(sender As Object, e As KeyPressEventArgs) Handled txtMiddleName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handled txtAge.KeyPress
        If Not Char.IsNumber(e.KeyChar)  Then
            e.KeyChar = ChrW
            e.Handled = True
        End If
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handled txtFirstName.KeyPress
        If (e.KeyChar) <> ControlChars.Back And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("Only Numbers allowed!!", MsgBoxStyle.Exclamation, "Phone Number")
        End If 
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handled txtPhone.KeyPress
        If (e.KeyChar) <> ControlChars.Back And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            e.Handled = True
            MsgBox("Only Numbers allowed!!", MsgBoxStyle.Exclamation, "Phone Number")
        End If
    End Sub

    Private Sub txtAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handled txtAddress.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If  
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handled txtLastName.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If  
    End Sub

    Private Sub txtMembershipID_KeyPress(sender As Object, e As KeyPressEventArgs) Handled txtMembershipID.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class
