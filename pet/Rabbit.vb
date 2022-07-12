Public Class Rabbit
    Private Sub BtnBack1_Click(sender As Object, e As EventArgs) Handles BtnBack1.Click
        Me.Hide()
        Kinds.Show()
    End Sub

    Private Sub BtnInvi1_Click(sender As Object, e As EventArgs) Handles BtnInvi1.Click
        Me.Hide()
        RabbitTips.Show()
    End Sub

    Private Sub Rabbit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnInvi1.FlatStyle = FlatStyle.Flat
        BtnInvi1.FlatAppearance.BorderColor = BackColor
        BtnInvi1.FlatAppearance.MouseOverBackColor = BackColor
        BtnInvi1.FlatAppearance.MouseDownBackColor = BackColor
        BtnInvi1.BackColor = Color.Transparent
    End Sub

    Private Sub BtnTeeth_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Rabbits have 28 teeth that help them grind their food. These teeth, unlike " & vbCrLf &
                        "those of a dog or cat, grow continuously throughout the life of your rabbit." & vbCrLf &
                        "Without proper items to help keep these teeth trimmed (like hay and safe" & vbCrLf &
                        "wood) the teeth can end up becoming overgrown and prevent your rabbit " & vbCrLf &
                        "from being able to eat." & vbCrLf &
                        "Molar teeth (the teeth in the back of the mouth) can grow and create a " & vbCrLf &
                        "bridge over the tongue which can inhibit chewing and swallowing. Teeth " & vbCrLf &
                        "that become this overgrown can cause your rabbit to starve. ")
    End Sub



    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub BtnHairballs_Click(sender As Object, e As EventArgs)
        MessageBox.Show("The technical name for a hairball is a trichobezoar but no matter what you " & vbCrLf &
                        "call it, rabbits can get them. Hairballs cause your rabbit to become " & vbCrLf &
                        "obstructed, meaning food cannot pass through their gastrointestinal " & vbCrLf &
                        "system. Since rabbits cannot vomit, hairballs will sit and grow inside your " & vbCrLf &
                        "rabbit's stomach as they clean themselves and ingest hair and can " & vbCrLf &
                        "potentially cause a blockage.")
    End Sub

    Private Sub BtnTumors_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Rabbits are known for their large ears but these ears aren't always clean. " & vbCrLf &
                        "Ear mites are small arachnids that feed off of the wax and oil that rabbit " & vbCrLf &
                        "ears produce. They are irritating and cause your rabbit to itch, scratch and " & vbCrLf &
                        "shake their heads. Secondary infections from ear mites also occur if the " & vbCrLf &
                        "ear mites are left untreated and include bacterial and fungal infections. " & vbCrLf &
                        "Large amounts of dark, crusty debris are usually seen in rabbit ears that " & vbCrLf &
                        "have ear mites.")
    End Sub

    Private Sub BtnMites_Click(sender As Object, e As EventArgs) Handles BtnTumors.Click
        MessageBox.Show("Rabbits are known for their large ears but these ears aren't always clean. " & vbCrLf &
                        "Ear mites are small arachnids that feed off of the wax and oil that rabbit " & vbCrLf &
                        "ears produce. They are irritating and cause your rabbit to itch, scratch and " & vbCrLf &
                        "shake their heads. Secondary infections from ear mites also occur if the " & vbCrLf &
                        "ear mites are left untreated and include bacterial and fungal infections. " & vbCrLf &
                        "Large amounts of dark, crusty debris are usually seen in rabbit ears that " & vbCrLf &
                        "have ear mites.")
    End Sub

    Private Sub BtnTeeth_Click_1(sender As Object, e As EventArgs) Handles BtnTeeth.Click
        MessageBox.Show("Rabbits have 28 teeth that help them grind their food. These teeth, unlike " & vbCrLf &
                       "those of a dog or cat, grow continuously throughout the life of your rabbit." & vbCrLf &
                       "Without proper items to help keep these teeth trimmed (like hay and safe" & vbCrLf &
                       "wood) the teeth can end up becoming overgrown and prevent your rabbit " & vbCrLf &
                       "from being able to eat." & vbCrLf &
                       "Molar teeth (the teeth in the back of the mouth) can grow and create a " & vbCrLf &
                       "bridge over the tongue which can inhibit chewing and swallowing. Teeth " & vbCrLf &
                       "that become this overgrown can cause your rabbit to starve. ")
    End Sub

    Private Sub BtnHairballs_Click_1(sender As Object, e As EventArgs) Handles BtnHairballs.Click
        MessageBox.Show("The technical name for a hairball is a trichobezoar but no matter what you " & vbCrLf &
                       "call it, rabbits can get them. Hairballs cause your rabbit to become " & vbCrLf &
                       "obstructed, meaning food cannot pass through their gastrointestinal " & vbCrLf &
                       "system. Since rabbits cannot vomit, hairballs will sit and grow inside your " & vbCrLf &
                       "rabbit's stomach as they clean themselves and ingest hair and can " & vbCrLf &
                       "potentially cause a blockage.")
    End Sub

    Private Sub BtnMites_Click_1(sender As Object, e As EventArgs) Handles BtnMites.Click
        MessageBox.Show("Rabbits are known for their large ears but these ears aren't always clean. " & vbCrLf &
                       "Ear mites are small arachnids that feed off of the wax and oil that rabbit " & vbCrLf &
                       "ears produce. They are irritating and cause your rabbit to itch, scratch and " & vbCrLf &
                       "shake their heads. Secondary infections from ear mites also occur if the " & vbCrLf &
                       "ear mites are left untreated and include bacterial and fungal infections. " & vbCrLf &
                       "Large amounts of dark, crusty debris are usually seen in rabbit ears that " & vbCrLf &
                       "have ear mites.")
    End Sub
End Class