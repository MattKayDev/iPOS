Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Order

    Public Type As Boolean = False ' false = collection, true = delivery
    Public BasketItems As List(Of BasketItem) = New List(Of BasketItem)
    Public Time As TimeSpan = Now.TimeOfDay
    Public OrderDate As DateTime = Now.Date
    Public TotalPrice As Double

    Public Sub Get_Total_Price()
        If BasketItems.Count > 0 Then
            For Each item In BasketItems
                TotalPrice += item.Price
            Next
        End If
    End Sub

    Public Sub Clear_Basket()
        BasketItems.Clear()
        MainForm.dgvBasket.Rows.Clear()
        TotalPrice = 0
    End Sub

    Public Sub Add_Item(productName As String, category As String, quantity As Integer, size As String)
        Dim item As New BasketItem
        item.ProductName = productName
        item.Quantity = 1
        item.Price = Database.Get_Price_Of(item.ProductName, category, size)
        MainForm.order.BasketItems.Add(item)
        If IsNumeric(size) Then
            size = size & """"
        End If
        MainForm.dgvBasket.Rows.Add(productName & " " & size, quantity, "£" & item.Price)
    End Sub
End Class
