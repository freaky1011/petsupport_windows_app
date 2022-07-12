Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class Login

    Private fcon As New FirebaseConfig() With
        {
        .AuthSecret = "6B6I7RZxMS5N8KoyXcGWXiualVrFjzIFyk5ZITqN",
        .BasePath = "https://petregister-442f8-default-rtdb.firebaseio.com/"
        }

    Private Client As IFirebaseClient

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
#Region "Condition"
        If (String.IsNullOrWhiteSpace(UserTbox.Text) AndAlso String.IsNullOrWhiteSpace(PassTbox.Text)) Then
            MessageBox.Show("Please fill all fields!")
            Return
        End If
#End Region

        Dim res = Client.Get("Users/" + UserTbox.Text)
        Dim resUser = res.ResultAs(Of MyUser)

        Dim CurUser As New MyUser With
            {
            .Email = UserTbox.Text,
            .Password = PassTbox.Text
            }

        If (MyUser.IsEqual(resUser, CurUser)) Then

            Dim real As New Dashboard
            Dashboard.Fname = resUser.Email
            Me.Hide()
            real.ShowDialog()



        Else
            MyUser.ShowError()

        End If



    End Sub

    Private Sub Register1_Click(sender As Object, e As EventArgs) Handles Register1.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PassTbox_TextChanged(sender As Object, e As EventArgs) Handles PassTbox.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub UserTbox_TextChanged(sender As Object, e As EventArgs) Handles UserTbox.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class