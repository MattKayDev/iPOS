Public Class MainMenuView
    Private Sub btnPizza_Click(sender As Object, e As EventArgs) Handles btnPizza.Click
        Dim pizzas As New PizzasView
        MainForm.pMain.Controls.Add(pizzas)
        MainForm.pMain.Controls.Remove(Me)
    End Sub
End Class
