Public Class frmPizzaBase
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        frmBasket.dtPublic.Rows.Add("Tomato base")
        'frmPizzaSizes.Show()
        Me.Hide()
        'frmPizzaCalzone.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmBasket.dtPublic.Rows.Add("BBQ base")
        'frmPizzaSizes.Show()
        Me.Hide()
        'frmPizzaCalzone.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        frmBasket.dtPublic.Rows.Add("Chilli base")
        'frmPizzaSizes.Show()
        Me.Hide()
        'frmPizzaCalzone.Show()
    End Sub
End Class