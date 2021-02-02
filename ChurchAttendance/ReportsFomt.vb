Public Class ReportsForm
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handled txtSearch.KeyPress
               
        If Not Asc(e.KeyChar) = 8 And Asc(e.KeyChar) >= 65 Asc(e.KeyChar) <= 90 And Asc(e.KeyChar) = 45 Then
            e.Handles = True
            e.KeyChar = ChrW(0)
        End If
        If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
            e.Handles = True
            e.KeyChar = ChrW
        End If
        If Asc(e.KeyChar) >=33 And Asc(e.KeyChar) <= 44 Or Asc(e.KeyChar) >= 46 And Asc(e.KeyChar) <= 64 Then
            e.Handles = True
            e.KeyChar = ChrW
        End If
    End Sub
    
    
    

End Class
