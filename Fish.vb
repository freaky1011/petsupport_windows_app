Public Class Fish
    Private Sub BtnBack1_Click(sender As Object, e As EventArgs) Handles BtnBack1.Click
        Me.Hide()
        Kinds.Show()
    End Sub

    Private Sub Fish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnInvi1.FlatStyle = FlatStyle.Flat
        BtnInvi1.FlatAppearance.BorderColor = BackColor
        BtnInvi1.FlatAppearance.MouseOverBackColor = BackColor
        BtnInvi1.FlatAppearance.MouseDownBackColor = BackColor
        BtnInvi1.BackColor = Color.Transparent
    End Sub

    Private Sub BtnInvi1_Click(sender As Object, e As EventArgs) Handles BtnInvi1.Click
        Me.Hide()
        FishTips.Show()
    End Sub

    Private Sub BtnAmmonia_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Though not a disease, ammonia poisoning is a common" & vbCrLf &
                        "problem in fish tanks – especially " & vbCrLf &
                        "new ones. It can cause high levels of stress " & vbCrLf &
                        "in your fish and lead to other health issues " & vbCrLf &
                        "including bacterial disorders.")
    End Sub

    Private Sub BtnCotton_Click(sender As Object, e As EventArgs)
        MessageBox.Show("This bacterial infection can affect cold-water " & vbCrLf &
                        "and tropical fish. It’s sometimes confused with " & vbCrLf &
                        "a fungal infection because of the appearance " & vbCrLf &
                        "of white or greyish white spots on the fish’s " & vbCrLf &
                        "head, though usually this infection starts as a " & vbCrLf &
                        "pale area around the head and mouth. This " & vbCrLf &
                        "may turn yellow/brownish in colour " & vbCrLf &
                        "with red-tinged edges.")
    End Sub

    Private Sub BtnDropsy_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Usually fatal to fish, Dropsy is characterised " & vbCrLf &
                        "by a swelling of your fish’s abdomen, " & vbCrLf &
                        "sometimes causing their scales to stick out. " & vbCrLf &
                        "Your fish will appear listless and lose their " & vbCrLf &
                        "appetite. If you’re unsure if your fish has " & vbCrLf &
                        "Dropsy, quarantine them them immediately and " & vbCrLf &
                        "take them to your local Greencross Vets.")
    End Sub

    Private Sub BtnFin_Click(sender As Object, e As EventArgs)
        MessageBox.Show("If you see that your fish’s fins or tail are frayed  " & vbCrLf &
                        "and the edges appear white, then they may  " & vbCrLf &
                        "be rotting. Your fish may also settle at the  " & vbCrLf &
                        "bottom of the tank and stop eating. This can be  " & vbCrLf &
                        "caused by poor water quality, but it can start  " & vbCrLf &
                        "with bullying from other fish. If your fish is " & vbCrLf &
                        "being bullied, you should move them to the quarantine tank.")
    End Sub

    Private Sub BtnAmmonia_Click_1(sender As Object, e As EventArgs) Handles BtnAmmonia.Click
        MessageBox.Show("Though not a disease, ammonia poisoning is a common" & vbCrLf &
                        "problem in fish tanks – especially " & vbCrLf &
                        "new ones. It can cause high levels of stress " & vbCrLf &
                        "in your fish and lead to other health issues " & vbCrLf &
                        "including bacterial disorders.")
    End Sub

    Private Sub BtnCotton_Click_1(sender As Object, e As EventArgs) Handles BtnCotton.Click
        MessageBox.Show("This bacterial infection can affect cold-water " & vbCrLf &
                       "and tropical fish. It’s sometimes confused with " & vbCrLf &
                       "a fungal infection because of the appearance " & vbCrLf &
                       "of white or greyish white spots on the fish’s " & vbCrLf &
                       "head, though usually this infection starts as a " & vbCrLf &
                       "pale area around the head and mouth. This " & vbCrLf &
                       "may turn yellow/brownish in colour " & vbCrLf &
                       "with red-tinged edges.")
    End Sub

    Private Sub BtnDropsy_Click_1(sender As Object, e As EventArgs) Handles BtnDropsy.Click
        MessageBox.Show("Usually fatal to fish, Dropsy is characterised " & vbCrLf &
                       "by a swelling of your fish’s abdomen, " & vbCrLf &
                       "sometimes causing their scales to stick out. " & vbCrLf &
                       "Your fish will appear listless and lose their " & vbCrLf &
                       "appetite. If you’re unsure if your fish has " & vbCrLf &
                       "Dropsy, quarantine them them immediately and " & vbCrLf &
                       "take them to your local Greencross Vets.")
    End Sub

    Private Sub BtnFin_Click_1(sender As Object, e As EventArgs) Handles BtnFin.Click
        MessageBox.Show("If you see that your fish’s fins or tail are frayed  " & vbCrLf &
                       "and the edges appear white, then they may  " & vbCrLf &
                       "be rotting. Your fish may also settle at the  " & vbCrLf &
                       "bottom of the tank and stop eating. This can be  " & vbCrLf &
                       "caused by poor water quality, but it can start  " & vbCrLf &
                       "with bullying from other fish. If your fish is " & vbCrLf &
                       "being bullied, you should move them to the quarantine tank.")
    End Sub
End Class