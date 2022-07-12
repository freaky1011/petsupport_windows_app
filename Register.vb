Imports FireSharp.Config
Imports FireSharp.Interfaces
Public Class Register

    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "6B6I7RZxMS5N8KoyXcGWXiualVrFjzIFyk5ZITqN",
        .BasePath = "https://petregister-442f8-default-rtdb.firebaseio.com/"
        }
    Private Client As IFirebaseClient

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub Rregister2_Click(sender As Object, e As EventArgs) Handles Rregister2.Click
#Region "Condition"

        If (String.IsNullOrWhiteSpace(UserTbox.Text) AndAlso String.IsNullOrWhiteSpace(PassTbox.Text)) Then
            MessageBox.Show("Please fill all fields!")
            Return
        End If
#End Region
        Dim NewUser As New MyUser() With
            {
            .Email = UserTbox.Text,
            .Password = PassTbox.Text
            }

        Dim setter = Client.Set("Users/" + UserTbox.Text, NewUser)
        MessageBox.Show("Registered Successfully")
        Me.Hide()
        Login.Show()


    End Sub

    Private Sub Rregister1_Click(sender As Object, e As EventArgs) Handles Rregister1.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub UserTbox_TextChanged(sender As Object, e As EventArgs) Handles UserTbox.TextChanged

    End Sub
End Class