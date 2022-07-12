Public Class Dashboard

    Public Shared Fname As String
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.Text += Fname + "!"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Vetlist.Show()
    End Sub

    Private Sub vetloc_Click(sender As Object, e As EventArgs) Handles Petcare.Click
        Me.Hide()
        FAQs.Show()
    End Sub

    Private Sub Kinds_of_pet_Click(sender As Object, e As EventArgs) Handles Kinds_of_pet.Click
        Me.Hide()
        Kinds.Show()

    End Sub


    Private Sub URL1_Click(sender As Object, e As EventArgs) Handles URL1.Click


        MessageBox.Show(
            "Risk of people spreading the virus that causes COVID-19 to pets" & vbCrLf &
            "We are still learning about the virus that causes COVID-19," & vbCrLf &
            "but it appears that it can spread from people To animals In some" & vbCrLf &
            "situations. A small number Of pets worldwide, including cats And dogs," & vbCrLf &
            "have been reportedexternal icon To be infected With the virus that" & vbCrLf &
            "causes COVID-19, mostly after close contact with people with COVID-19.")

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub URL2_Click(sender As Object, e As EventArgs) Handles URL2.Click
        MessageBox.Show(" Poaching of endangered species is on the rise." & vbCrLf &
                        "Experts have called for a ban on the trade of wildlife." & vbCrLf &
                        "A tiger has a confirmed case of coronavirus in New York." & vbCrLf &
                         "Wildlife are roaming free, while humans self-isolate." & vbCrLf &
                        "Millions of baby turtles are hatching on India's empty beaches." & vbCrLf &
                        "The coronavirus has upended our way of life – but it's also" & vbCrLf &
                        "having a dramatic impact on animals across the globe, too," & vbCrLf &
                        "from black rhinos being poached in Botswana to a coughing" & vbCrLf &
                        "tiger in New York And emboldened goats on the streets of Wales.")
    End Sub

    Private Sub URL3_Click(sender As Object, e As EventArgs) Handles URL3.Click
        MessageBox.Show("How can I prepare my pet for the COVID-19 pandemic?" & vbCrLf &
                        "Should quarantine be required, prepare your pet just" & vbCrLf &
                        "as you would prepare your family. This includes stocking" & vbCrLf &
                        "up on a 2-4 week supply of food, medications (don’t forget" & vbCrLf &
                        "subscription medications), litter And other supplies. Learn" & vbCrLf &
                        "more about pet safety in emergencies." & vbCrLf &
                        "Make sure your pet’s medical records, vaccines, and " & vbCrLf &
                        "preventative medications (tick, flea, internal parasites)" & vbCrLf &
                        "are up to date in the event you cannot care for them And" & vbCrLf &
                        "need to board your pet." & vbCrLf &
                        "Practice good hygiene during interactions with your pet" & vbCrLf &
                        "(wash hands before And after interacting with your pet;" & vbCrLf &
                        "ensure your pet Is kept well-groomed And Is bathed on" & vbCrLf &
                        "a weekly basis; regularly clean your pet’s food and" & vbCrLf &
                        "water bowls, bedding material, And toys)." & vbCrLf &
                        "If you Then are Not ill With COVID-19, you can interact" & vbCrLf &
                        "With your pet As you normally would, including walking," & vbCrLf &
                        "feeding, And playing." & vbCrLf &
                        "Do Not share dishes, drinking glasses, cups, eating" & vbCrLf &
                        "utensils, towels, or bedding with other people or pets" & vbCrLf &
                        "in your home. Additional guidance on managing pets in" & vbCrLf &
                        "homes where people are sick with COVID-19 is available from the CDC")
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim blank As String = ""
        Me.Hide()
        Login.UserTbox.Text = blank
        Login.PassTbox.Text = blank
        Login.Show()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MessageBox.Show(
            "Risk of people spreading the virus that causes COVID-19 to pets" & vbCrLf &
            "We are still learning about the virus that causes COVID-19," & vbCrLf &
            "but it appears that it can spread from people To animals In some" & vbCrLf &
            "situations. A small number Of pets worldwide, including cats And dogs," & vbCrLf &
            "have been reportedexternal icon To be infected With the virus that" & vbCrLf &
            "causes COVID-19, mostly after close contact with people with COVID-19.")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MessageBox.Show(" Poaching of endangered species is on the rise." & vbCrLf &
                       "Experts have called for a ban on the trade of wildlife." & vbCrLf &
                       "A tiger has a confirmed case of coronavirus in New York." & vbCrLf &
                        "Wildlife are roaming free, while humans self-isolate." & vbCrLf &
                       "Millions of baby turtles are hatching on India's empty beaches." & vbCrLf &
                       "The coronavirus has upended our way of life – but it's also" & vbCrLf &
                       "having a dramatic impact on animals across the globe, too," & vbCrLf &
                       "from black rhinos being poached in Botswana to a coughing" & vbCrLf &
                       "tiger in New York And emboldened goats on the streets of Wales.")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        MessageBox.Show("How can I prepare my pet for the COVID-19 pandemic?" & vbCrLf &
                        "Should quarantine be required, prepare your pet just" & vbCrLf &
                        "as you would prepare your family. This includes stocking" & vbCrLf &
                        "up on a 2-4 week supply of food, medications (don’t forget" & vbCrLf &
                        "subscription medications), litter And other supplies. Learn" & vbCrLf &
                        "more about pet safety in emergencies." & vbCrLf &
                        "Make sure your pet’s medical records, vaccines, and " & vbCrLf &
                        "preventative medications (tick, flea, internal parasites)" & vbCrLf &
                        "are up to date in the event you cannot care for them And" & vbCrLf &
                        "need to board your pet." & vbCrLf &
                        "Practice good hygiene during interactions with your pet" & vbCrLf &
                        "(wash hands before And after interacting with your pet;" & vbCrLf &
                        "ensure your pet Is kept well-groomed And Is bathed on" & vbCrLf &
                        "a weekly basis; regularly clean your pet’s food and" & vbCrLf &
                        "water bowls, bedding material, And toys)." & vbCrLf &
                        "If you Then are Not ill With COVID-19, you can interact" & vbCrLf &
                        "With your pet As you normally would, including walking," & vbCrLf &
                        "feeding, And playing." & vbCrLf &
                        "Do Not share dishes, drinking glasses, cups, eating" & vbCrLf &
                        "utensils, towels, or bedding with other people or pets" & vbCrLf &
                        "in your home. Additional guidance on managing pets in" & vbCrLf &
                        "homes where people are sick with COVID-19 is available from the CDC")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        About.Show()
    End Sub
End Class