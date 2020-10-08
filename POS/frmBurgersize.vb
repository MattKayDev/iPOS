Public Class frmBurgersize
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        frmBurger.burgerSize = True
        frmBurger.ShowBurger()
        Me.Hide()
        frmBurgerSides.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmBurger.burgerSize = False
        frmBurger.ShowBurger()
        Me.Hide()
        frmBurgerSides.Show()
    End Sub

    Private Sub frmBurgersize_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not frmBurger.chickenFilletBurger Then
            button1.Visible = True
        Else
            button1.Visible = False
        End If
    End Sub
End Class