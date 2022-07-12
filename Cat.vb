Public Class Cat
    Private Sub BtnBack1_Click(sender As Object, e As EventArgs) Handles BtnBack1.Click
        Me.Hide()
        Kinds.Show()
    End Sub

    Private Sub Cat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnInvi1.FlatStyle = FlatStyle.Flat
        BtnInvi1.FlatAppearance.BorderColor = BackColor
        BtnInvi1.FlatAppearance.MouseOverBackColor = BackColor
        BtnInvi1.FlatAppearance.MouseDownBackColor = BackColor
        BtnInvi1.BackColor = Color.Transparent

    End Sub

    Private Sub BtnCancer_Click(sender As Object, e As EventArgs) Handles BtnCancer.Click
        MessageBox.Show("Cancer is a ''multifactorial'' disease, which means it has no" & vbCrLf &
                        "known single cause. However, we do know that both " & vbCrLf &
                        "hereditary and environmental factors can lead to the " & vbCrLf &
                        "development of cancer in cats.")
    End Sub

    Private Sub BtnDiabetes_Click(sender As Object, e As EventArgs) Handles BtnDiabetes.Click
        MessageBox.Show("Diabetes in cats is a complex disease caused by either a lack " & vbCrLf &
                        "of the hormone insulin or an inadequate response to insulin. " & vbCrLf &
                        "After a cat eats, her digestive system breaks food into various " & vbCrLf &
                        "components, including glucose—which is carried into her cells " & vbCrLf &
                        "by insulin. When a cat does not produce insulin or cannot " & vbCrLf &
                        "utilize it normally, her blood sugar levels elevate. The result is " & vbCrLf &
                        "hyperglycemia, which, if left untreated, can cause many " & vbCrLf &
                        "complicated health problems for a cat." & vbCrLf &
                        "The following are signs that your cat may be diabetic:" & vbCrLf &
                        "⦁	Change in appetite (either increased or decreased)" & vbCrLf &
                        "⦁	Weight loss" & vbCrLf &
                        "⦁	Excessive thirst/increase in water consumption" & vbCrLf &
                        "⦁	Increased urination" & vbCrLf &
                        "⦁	Urinating in areas other than litter box" & vbCrLf &
                        "⦁	Unusually sweet-smelling breath" & vbCrLf &
                        "⦁	Lethargy" & vbCrLf &
                        "⦁	Dehydration" & vbCrLf &
                        "⦁	Unkempt hair coat" & vbCrLf &
                        "⦁	Urinary tract infection")
    End Sub

    Private Sub BtnFeline_Click(sender As Object, e As EventArgs) Handles BtnFeline.Click
        MessageBox.Show("Cats infected with feline immunodeficiency virus (FIV) may not " & vbCrLf &
                        "show symptoms until years after the initial infection occurred. " & vbCrLf &
                        "Although the virus is slow-acting, a cat’s immune system is " & vbCrLf &
                        "severely weakened once the disease takes hold. This makes " & vbCrLf &
                        "the cat susceptible to various secondary infections. Infected " & vbCrLf &
                        "cats receiving supportive medical care and kept in a stress-free" & vbCrLf &
                        "indoor environment can live relatively comfortable lives " & vbCrLf &
                        "for months to years before the disease reaches its chronic stages." & vbCrLf &
                        "If your cat is demonstrating any of the following symptoms," & vbCrLf &
                        "please have examined by your veterinarian:" & vbCrLf &
                        "⦁	Enlarged lymph nodes" & vbCrLf &
                        "⦁	Fever" & vbCrLf &
                        "⦁	Anemia" & vbCrLf &
                        "⦁	Weight loss" & vbCrLf &
                        "⦁	Disheveled coat" & vbCrLf &
                        "⦁	Poor appetite" & vbCrLf &
                        "⦁	Diarrhea" & vbCrLf &
                        "⦁	Abnormal appearance or inflammation of the eye (conjunctivitis)" & vbCrLf &
                        "⦁	Inflammation of the gums (gingivitis)" & vbCrLf &
                        "⦁	Inflammation of the mouth (stomatitis)" & vbCrLf &
                        "⦁	Dental disease" & vbCrLf &
                        "⦁	Skin redness or hair loss" & vbCrLf &
                        "⦁	Wounds that don’t heal" & vbCrLf &
                        "⦁	Sneezing" & vbCrLf &
                        "⦁	Discharge from eyes or nose" & vbCrLf &
                        "⦁	Frequent urination, straining to urinate or urinating outside of litter box" & vbCrLf &
                        "⦁	Behavior change")
    End Sub

    Private Sub BtnFeline2_Click(sender As Object, e As EventArgs) Handles BtnFeline2.Click
        MessageBox.Show("First discovered in the 1960s, feline leukemia virus is a " & vbCrLf &
                        "transmittable RNA retrovirus that can severely inhibit a cat’s " & vbCrLf &
                        "immune system. It is one of the most commonly diagnosed " & vbCrLf &
                        "causes of disease and death in domestic cats. Because the " & vbCrLf &
                        "virus doesn’t always manifest symptoms right away, any new " & vbCrLf &
                        "cat entering a household—and any sick cat—should be tested " & vbCrLf &
                        "for FeLV." & vbCrLf &
                        "Cats can be infected and show no signs. Others may exhibit:" & vbCrLf &
                        "⦁	Loss of appetite and weight loss" & vbCrLf &
                        "⦁	Pale or inflamed gums" & vbCrLf &
                        "⦁	Poor coat condition" & vbCrLf &
                        "⦁	Abcesses" & vbCrLf &
                        "⦁	Fever" & vbCrLf &
                        "⦁	Upper respiratory infections " & vbCrLf &
                        "⦁	Diarrhea and vomiting" & vbCrLf &
                        "⦁	Seizures" & vbCrLf &
                        "⦁	Changes in behavior" & vbCrLf &
                        "⦁	Vision or other eye problems" & vbCrLf &
                        "⦁	Enlarged lymph nodes" & vbCrLf &
                        "⦁	Reproductive problems (in females)" & vbCrLf &
                        "⦁	Jaundice" & vbCrLf &
                        "⦁	Chronic skin disease" & vbCrLf &
                        "⦁	Respiratory distress" & vbCrLf &
                        "⦁	Lethargy")
    End Sub

    Private Sub BtnInvi1_Click(sender As Object, e As EventArgs) Handles BtnInvi1.Click
        Me.Hide()
        CatTips.Show()
    End Sub
End Class