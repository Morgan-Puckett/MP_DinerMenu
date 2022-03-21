Public Class MP_DinerMenu
    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DinerSpecialtyLabel.Text = "~ Fish ~ 
Tonight's Fish Special is a one pan lemon garlic salmon with 
charred bell peppers on the side"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DinerSpecialtyLabel.Text = "~ Salad ~
Tonights Salad Special is a shredded chicken salad from my 
pantry. Chicken didnt come from a can*



*It totally did."
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DinerSpecialtyLabel.Text = "~ Soup ~
The Soup Special this evening is a true delicacy, made from our
finest ingredients. All the way from the 
dollar tree, progresso soup of your choice 
for only $559.99! We spent all our money on the 
salmon and we aren't sorry!!!"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub MP_DinerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Diner food mmmmmmm yummy"
    End Sub
End Class




