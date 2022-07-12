Public Class MyDog

    Private Sub BtnCanine_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Symptoms: runny eyes, fever, coughing, vomiting, paralysis" & vbCrLf & " 
Canine distemper, sometimes called hardpad disease because it hardens dogs’ noses" & vbCrLf & "and footpads, is an extremely contagious viral disease that’s transmitted through" & vbCrLf &
"airborne exposure or contact like shared food bowls." & vbCrLf &
"While all dogs are at risk of contracting canine distemper," & vbCrLf &
"it predominantly affects puppies and dogs " & vbCrLf &
"that are especially prone to airborne viruses." & vbCrLf &
"If you think your dog has distemper, take her to the vet. " & vbCrLf &
"Although vets try their best to treat dogs with distemper by " & vbCrLf &
"providing supportive care and preventing secondary infection by " & vbCrLf &
"making sure they have plenty of rest and fluids, it’s often fatal." & vbCrLf &
"The best way to prevent your dog from getting it is by " & vbCrLf &
"vaccinating her and keeping her from sick pups.")
    End Sub

    Private Sub BtnParvo_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Symptoms: fever, lethargy, vomiting, diarrhea, dehydration, weight loss
" & vbCrLf &
"Parvo is another highly contagious virus that infects dogs that " & vbCrLf &
"come in contact with the fecal matter of a sick dog. And, sadly," & vbCrLf &
"parvo’s easy to spread but hard to kill, once it attacks a dog’s " & vbCrLf &
"internal organs." & vbCrLf &
"Vets treat dogs with parvo by providing plenty of fluids," & vbCrLf &
"electrolytes and secondary infection prevention, but it’s often " & vbCrLf &
"fatal. The best way to keep your dog safe is by getting him " & vbCrLf &
"vaccinated and keeping him away from all feces, especially " & vbCrLf &
"infected feces.")
    End Sub

    Private Sub BtnHeartworm_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Symptoms: lethargy, coughing, respiratory problems, heart disease, weight loss
" & vbCrLf &
"Heartworms are parasites that live in your dog’s heart, wreaking " & vbCrLf &
"havoc on his heart, blood vessels and lungs if he gets infected. " & vbCrLf &
"Heartworm is spread by mosquitos and has been reported in all " & vbCrLf &
"fifty states, not just places with dry climates. Buying preventative " & vbCrLf &
"medication (like heartworm or flea and tick) is comparable to " & vbCrLf &
"buying insurance — while you may not want to spend money on " & vbCrLf &
"it now, it’s better than not being able to afford a crisis later. Here " & vbCrLf &
"are some more money-saving hacks for pet owners." & vbCrLf &
"If your dog has heartworm, expect a rigorous regimen of " & vbCrLf &
"steroids, antibiotics, and an organic arsenic injection. The easiest " & vbCrLf &
"(and cheapest) way to prevent her from contracting it is by " & vbCrLf &
"taking preventative measures with annual blood tests and " & vbCrLf &
"regular pills, topicals or shots. You can find a variety of " & vbCrLf &
"heartworm medications through sites like .")
    End Sub

    Private Sub BtnRabies_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Symptoms: fever, pain, tingling or burning at the wound, hyperactivity
" & vbCrLf &
"It’s the disease that took Old Yeller. Rabies caused by the rabies " & vbCrLf &
"virus, spread by a bite or saliva from an infected animal, and " & vbCrLf &
"fatal once an animal gets it and starts showing symptoms. Due to " & vbCrLf &
"its severity and that it’s easily spread to humans, many cities, " & vbCrLf &
"states, parks and groomers require dogs to have the vaccine." & vbCrLf &
"There is no treatment for dogs once they contract rabies, and it is " & vbCrLf &
"fatal. The best way to prevent it is getting her vaccinated and " & vbCrLf &
"keeping her from rabid wildlife.")
    End Sub

    Private Sub BtnInvi1_Click(sender As Object, e As EventArgs) Handles BtnInvi1.Click

        Me.Hide()
        DogTips.Show()

    End Sub

    Private Sub BtnBack1_Click(sender As Object, e As EventArgs) Handles BtnBack1.Click

        Me.Hide()
        Kinds.Show()
    End Sub

    Private Sub MyDog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnInvi1.FlatStyle = FlatStyle.Flat
        BtnInvi1.FlatAppearance.BorderColor = BackColor
        BtnInvi1.FlatAppearance.MouseOverBackColor = BackColor
        BtnInvi1.FlatAppearance.MouseDownBackColor = BackColor
        BtnInvi1.BackColor = Color.Transparent

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub BtnCanine_Click_1(sender As Object, e As EventArgs) Handles BtnCanine.Click
        MessageBox.Show("Symptoms: runny eyes, fever, coughing, vomiting, paralysis" & vbCrLf & " 
Canine distemper, sometimes called hardpad disease because it hardens dogs’ noses" & vbCrLf & "and footpads, is an extremely contagious viral disease that’s transmitted through" & vbCrLf &
"airborne exposure or contact like shared food bowls." & vbCrLf &
"While all dogs are at risk of contracting canine distemper," & vbCrLf &
"it predominantly affects puppies and dogs " & vbCrLf &
"that are especially prone to airborne viruses." & vbCrLf &
"If you think your dog has distemper, take her to the vet. " & vbCrLf &
"Although vets try their best to treat dogs with distemper by " & vbCrLf &
"providing supportive care and preventing secondary infection by " & vbCrLf &
"making sure they have plenty of rest and fluids, it’s often fatal." & vbCrLf &
"The best way to prevent your dog from getting it is by " & vbCrLf &
"vaccinating her and keeping her from sick pups.")
    End Sub

    Private Sub BtnParvo_Click_1(sender As Object, e As EventArgs) Handles BtnParvo.Click
        MessageBox.Show("Symptoms: fever, lethargy, vomiting, diarrhea, dehydration, weight loss
" & vbCrLf &
"Parvo is another highly contagious virus that infects dogs that " & vbCrLf &
"come in contact with the fecal matter of a sick dog. And, sadly," & vbCrLf &
"parvo’s easy to spread but hard to kill, once it attacks a dog’s " & vbCrLf &
"internal organs." & vbCrLf &
"Vets treat dogs with parvo by providing plenty of fluids," & vbCrLf &
"electrolytes and secondary infection prevention, but it’s often " & vbCrLf &
"fatal. The best way to keep your dog safe is by getting him " & vbCrLf &
"vaccinated and keeping him away from all feces, especially " & vbCrLf &
"infected feces.")
    End Sub

    Private Sub BtnHeartworm_Click_1(sender As Object, e As EventArgs) Handles BtnHeartworm.Click
        MessageBox.Show("Symptoms: lethargy, coughing, respiratory problems, heart disease, weight loss
" & vbCrLf &
"Heartworms are parasites that live in your dog’s heart, wreaking " & vbCrLf &
"havoc on his heart, blood vessels and lungs if he gets infected. " & vbCrLf &
"Heartworm is spread by mosquitos and has been reported in all " & vbCrLf &
"fifty states, not just places with dry climates. Buying preventative " & vbCrLf &
"medication (like heartworm or flea and tick) is comparable to " & vbCrLf &
"buying insurance — while you may not want to spend money on " & vbCrLf &
"it now, it’s better than not being able to afford a crisis later. Here " & vbCrLf &
"are some more money-saving hacks for pet owners." & vbCrLf &
"If your dog has heartworm, expect a rigorous regimen of " & vbCrLf &
"steroids, antibiotics, and an organic arsenic injection. The easiest " & vbCrLf &
"(and cheapest) way to prevent her from contracting it is by " & vbCrLf &
"taking preventative measures with annual blood tests and " & vbCrLf &
"regular pills, topicals or shots. You can find a variety of " & vbCrLf &
"heartworm medications through sites like .")
    End Sub

    Private Sub BtnRabies_Click_1(sender As Object, e As EventArgs) Handles BtnRabies.Click
        MessageBox.Show("Symptoms: fever, pain, tingling or burning at the wound, hyperactivity
" & vbCrLf &
"It’s the disease that took Old Yeller. Rabies caused by the rabies " & vbCrLf &
"virus, spread by a bite or saliva from an infected animal, and " & vbCrLf &
"fatal once an animal gets it and starts showing symptoms. Due to " & vbCrLf &
"its severity and that it’s easily spread to humans, many cities, " & vbCrLf &
"states, parks and groomers require dogs to have the vaccine." & vbCrLf &
"There is no treatment for dogs once they contract rabies, and it is " & vbCrLf &
"fatal. The best way to prevent it is getting her vaccinated and " & vbCrLf &
"keeping her from rabid wildlife.")
    End Sub
End Class