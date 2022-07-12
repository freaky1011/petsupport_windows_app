Public Class Form2
    Dim image(3) As Bitmap
    Dim pos As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        image(0) = pet.My.Resources.j1
        image(1) = pet.My.Resources.j2
        image(2) = pet.My.Resources.j3
        image(3) = pet.My.Resources.j4

        PictureBox1.Image = image(pos)
    End Sub

    Private Sub Next1_Click(sender As Object, e As EventArgs) Handles Next1.Click
        pos = pos + 1

        If pos < image.Length Then
            PictureBox1.Image = image(pos)
        Else
            pos = image.Length - 1
        End If

    End Sub

    Private Sub Previous1_Click(sender As Object, e As EventArgs) Handles Previous1.Click
        pos = pos - 1
        If pos >= 0 Then
            PictureBox1.Image = image(pos)

        Else
            pos = 0
        End If


    End Sub

    Private Sub Skip1_Click(sender As Object, e As EventArgs) Handles Skip1.Click

        PictureBox1.Image = My.Resources.dog3

    End Sub

    Private Sub Finish1_Click(sender As Object, e As EventArgs) Handles Finish1.Click


        Login.Show()
        Me.Hide()


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class