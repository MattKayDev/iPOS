Public Class frmBurgerSauce
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        frmBasket.dtPublic.Rows.Add("MAYO")
        Me.Hide()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmBasket.dtPublic.Rows.Add("GARLIC MAYO")
        Me.Hide()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        frmBasket.dtPublic.Rows.Add("KETCHUP")
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmBasket.dtPublic.Rows.Add("BBQ")
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmBasket.dtPublic.Rows.Add("CHILLI")
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmBasket.dtPublic.Rows.Add("SWEET CHILLI")
        Me.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmBasket.dtPublic.Rows.Add("NO SAUCE")
        Me.Hide()
    End Sub
End Class