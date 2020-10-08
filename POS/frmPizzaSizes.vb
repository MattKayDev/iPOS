Public Class frmPizzaSizes
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        frmPizzaBase.Show()
        frmPizzas.pizzaSize = 10
        frmPizzas.ShowPizza()
        Me.Hide()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmPizzaBase.Show()
        frmPizzas.pizzaSize = 12
        frmPizzas.ShowPizza()
        Me.Hide()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        frmPizzaBase.Show()
        frmPizzas.pizzaSize = 14
        frmPizzas.ShowPizza()
        Me.Hide()
    End Sub
End Class