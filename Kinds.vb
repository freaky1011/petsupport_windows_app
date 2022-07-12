Public Class Kinds
    Private Sub Kinds_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Cats_Click(sender As Object, e As EventArgs) Handles Cats.Click
        Me.Hide()
        Cat.Show()
    End Sub

    Private Sub Dogs_Click(sender As Object, e As EventArgs) Handles Dogs1.Click
        Me.Hide()
        MyDog.Show()
    End Sub

    Private Sub Rabbit_Click(sender As Object, e As EventArgs) Handles Rabbits.Click
        Me.Hide()
        Rabbit.Show()
    End Sub

    Private Sub Fishs_Click(sender As Object, e As EventArgs) Handles Fishs.Click
        Me.Hide()
        Fish.Show()
    End Sub

    Private Sub KindBack_Click(sender As Object, e As EventArgs) Handles KindBack.Click
        Me.Hide()
        Dashboard.Show()

    End Sub
End Class