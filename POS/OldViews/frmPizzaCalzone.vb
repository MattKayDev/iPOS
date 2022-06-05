Public Class frmPizzaCalzone
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        frmPizzas.calzone = True
        Me.Hide()
        frmPizzaSizes.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmPizzas.calzone = False
        Me.Hide()
        frmPizzaSizes.Show()
    End Sub
End Class