Public Class frmPizzaToppings
    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA PEPPERONI", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA PEPPERONI", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA PEPPERONI", "£", 2)
        End If
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        ' frmBasket.dtPublic.Rows.Add("CHICKEN")
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA CHICKEN", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA CHICKEN", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA CHICKEN", "£", 2)
        End If
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        'frmBasket.dtPublic.Rows.Add("SPICY CHICKEN")
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA SPICY CHICKEN", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA SPICY CHICKEN", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA SPICY CHICKEN", "£", 2)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'frmBasket.dtPublic.Rows.Add("TURKEY"
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA TURKEY", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA TURKEY", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA TURKEY", "£", 2)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA HAM", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA HAM", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA HAM", "£", 2)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA TURKEY HAM", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA TURKEY HAM", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA TURKEY HAM", "£", 2)
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA SPICY BEEF", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA SPICY BEEF", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA SPICY BEEF", "£", 2)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA MUSHROOMS", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA MUSHROOMS", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA MUSHROOMS", "£", 2)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA ONIONS", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA ONIONS", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA ONIONS", "£", 2)
        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA SWEETCORN", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA SWEETCORN", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA SWEETCORN", "£", 2)
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA JALAPENO", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA JALAPENO", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA JALAPENO", "£", 2)
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA GREEN PEPPERS", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA GREEN PEPPERS", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA GREEN PEPPERS", "£", 2)
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA PINEAPPLE", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA PINEAPPLE", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA PINEAPPLE", "£", 2)
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA BLACK OLIVES", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA BLACK OLIVES", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA BLACK OLIVES", "£", 2)
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA HOT CHILLI", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA HOT CHILLI", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA HOT CHILLI", "£", 2)
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA GARLIC BUTTER", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA GARLIC BUTTER", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA GARLIC BUTTER", "£", 2)
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA CHEESE", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA CHEESE", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA CHEESE", "£", 2)
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA ANCHOVIES", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA ANCHOVIES", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA ANCHOVIES", "£", 2)
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA TUNA", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA TUNA", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA TUNA", "£", 2)
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        If frmPizzas.pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("EXTRA PRAWNS", "£", 0.8)
        ElseIf frmPizzas.pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("EXTRA PRAWNS", "£", 1.5)
        ElseIf frmPizzas.pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("EXTRA PRAWNS", "£", 2)
        End If
    End Sub
End Class