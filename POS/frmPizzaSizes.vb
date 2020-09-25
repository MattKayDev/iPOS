Public Class frmPizzaSizes
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        frmPizzas.pizzaSize = 10
        frmPizzas.showPizza()
        Me.Hide()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmPizzas.pizzaSize = 12
        frmPizzas.ShowPizza()
        Me.Hide()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        frmPizzas.pizzaSize = 14
        frmPizzas.ShowPizza()
        Me.Hide()
    End Sub
End Class