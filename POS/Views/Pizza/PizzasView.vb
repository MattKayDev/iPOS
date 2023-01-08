Public Class PizzasView

    Dim category As String = "Pizza"

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim mainMenu As New MainMenuView
        MainForm.pMain.Controls.Add(mainMenu)
        MainForm.pMain.Controls.Remove(Me)
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        MainForm.order.Add_Item(button1.Text, category, 1, "10")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        MainForm.order.Add_Item(button2.Text, category, 1, "10")

    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        MainForm.order.Add_Item(button3.Text, category, 1, "10")

    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        MainForm.order.Add_Item(button8.Text, category, 1, "10")

    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        MainForm.order.Add_Item(button4.Text, category, 1, "10")

    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        MainForm.order.Add_Item(button5.Text, category, 1, "10")

    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        MainForm.order.Add_Item(button11.Text, category, 1, "10")

    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        MainForm.order.Add_Item(button7.Text, category, 1, "10")

    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        MainForm.order.Add_Item(button10.Text, category, 1, "10")

    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        'MainForm.order.Add_Item(button12.Text, category, 1, "10")
    End Sub

    Private Sub button14_Click(sender As Object, e As EventArgs) Handles button14.Click
        MainForm.order.Add_Item(button14.Text, category, 1, "10")

    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        MainForm.order.Add_Item(button6.Text, category, 1, "10")
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        MainForm.order.Add_Item(button9.Text, category, 1, "10")
    End Sub

    Private Sub button16_Click(sender As Object, e As EventArgs) Handles button16.Click
        MainForm.order.Add_Item(button16.Text, "Topping", 1, "Reg")
    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        MainForm.order.Add_Item(button13.Text, "Topping", 1, "Reg")
    End Sub
End Class
