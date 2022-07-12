Public Class MyUser

    Public Property Email() As String
    Public Property Password() As String

    Private Shared TheError As String = "Email not Found"

    Public Shared Sub ShowError()
        MessageBox.Show(TheError)
    End Sub

    Public Shared Function IsEqual(user1 As MyUser, user2 As MyUser)


        If (user1 Is Nothing Or user2 Is Nothing) Then
            TheError = "Email not Found"
            Return False
        End If

        If (user1.Email <> user2.Email) Then
            TheError = "Email not Found"
            Return False
        ElseIf (user1.Password <> user2.Password) Then
            TheError = "Email and Password does not match"
            Return False

        End If


        Return True




    End Function
End Class
