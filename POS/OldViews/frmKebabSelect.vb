Public Class frmKebabSelect
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        frmKebabs.pitaOrNaan = True
        frmKebabs.ShowKebab()
        frmBasket.dtPublic.Rows.Add("Pita")
        Me.Hide()
        'frmKebabs.ShowKebab()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmKebabs.pitaOrNaan = False
        frmKebabs.ShowKebab()
        frmBasket.dtPublic.Rows.Add("Naan")

        Me.Hide()

    End Sub
End Class