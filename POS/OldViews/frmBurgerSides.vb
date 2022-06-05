Public Class frmBurgerSides
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        frmBasket.dtPublic.Rows.Add("Lettuce")
        'dgvBasket.DataSource = frmBasket.dtPublic
        'Me.Hide()
        'frmBurgerSauce.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmBasket.dtPublic.Rows.Add("Tomato")
        'Me.Hide()
        'frmBurgerSauce.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        frmBasket.dtPublic.Rows.Add("Onion")
        'Me.Hide()
        'frmBurgerSauce.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        frmBasket.dtPublic.Rows.Add("Peppers")
        'Me.Hide()
        'frmBurgerSauce.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        frmBasket.dtPublic.Rows.Add("Jalapeeno")
        'Me.Hide()
        'frmBurgerSauce.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmBasket.dtPublic.Rows.Add("No salad")
        'Me.Hide()
        'frmBurgerSauce.Show()
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        frmBasket.dtPublic.Rows.Add("Full Salad")
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        frmBurgerSauce.Show()
    End Sub
End Class