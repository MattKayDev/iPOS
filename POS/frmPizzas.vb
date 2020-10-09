Imports System.Reflection

Public Class frmPizzas
    Dim versionNumber As Version


    Public pizzaSize As Integer

    Public Margherita As Boolean
    Public hawaiian As Boolean
    Public tuscany As Boolean
    Public napoli As Boolean
    Public southern As Boolean
    Public spicyChicken As Boolean
    Public spicyBeef As Boolean
    Public donner As Boolean
    Public donnerHot As Boolean
    Public meatFeast As Boolean
    Public veg As Boolean
    Public seafood As Boolean
    Public italianHot As Boolean
    Public ilPadrino As Boolean

    Dim selectedPizzaWithSize As String
    Dim selectedPizza As String

    Public calzone As Boolean

    'Const String quote = 

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        Me.Hide()
        frmBasket.Show()
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        dgvBasket.DataSource = frmBasket.dtPublic
    End Sub

    Private Sub frmPizzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label1.Text = My.Settings.posName
        Me.WindowState = FormWindowState.Maximized
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblVersion.Text = versionNumber.ToString()
        timer1.Start()
        Timer2.Start()


        dgvBasket.DataSource = frmBasket.dtPublic
        Dim column1 As DataGridViewColumn = dgvBasket.Columns(0)
        column1.Width = 300
        Dim column2 As DataGridViewColumn = dgvBasket.Columns(1)
        column2.Width = 30
        Dim column3 As DataGridViewColumn = dgvBasket.Columns(2)
        column3.Width = 50
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Margherita = True
        hawaiian = False
        tuscany = False
        napoli = False
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = False
        veg = False
        seafood = False
        italianHot = False
        ilPadrino = False
        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
        'frmPizzaBase.Show()
    End Sub

    Public Sub ShowPizza()
        Dim price As Double = 7.5
        If Margherita Then

            selectedPizza = "MARGHERITA"
            If pizzaSize = 10 Then
                price = 5.0
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 7.0
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 9.0
                If calzone Then
                    price = price + 2
                End If
            End If

        ElseIf hawaiian Then

            selectedPizza = "HAWAIIAN"
            If pizzaSize = 10 Then
                price = 6.5
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 8.5
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 11
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf napoli Then

            selectedPizza = "NAPOLI"
            If pizzaSize = 10 Then
                price = 6.5
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 8.5
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 11
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf tuscany Then

            selectedPizza = "TUSCANY"
            If pizzaSize = 10 Then
                price = 5.0
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 7.0
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 11
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf southern Then

            selectedPizza = "SOUTHERN"
            If pizzaSize = 10 Then
                price = 6.5
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 8.5
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 11
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf spicyChicken Then

            selectedPizza = "SPICY CHICKEN"
            If pizzaSize = 10 Then
                price = 7
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 9.5
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 12.5
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf spicyBeef Then

            selectedPizza = "SPICY BEEF"
            If pizzaSize = 10 Then
                price = 7
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 9.5
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 12.5
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf donner Then

            selectedPizza = "DONNER"
            If pizzaSize = 10 Then
                price = 6.5
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 9
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 11.5
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf donnerHot Then

            selectedPizza = "DONNER HOT"
            If pizzaSize = 10 Then
                price = 7.5
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 9.5
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 13
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf meatFeast Then

            selectedPizza = "MEAT FEAST"
            If pizzaSize = 10 Then
                price = 7.5
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 9.5
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 13
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf veg Then

            selectedPizza = "VEG"
            If pizzaSize = 10 Then
                price = 8.0
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 10.0
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 13.0
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf seafood Then

            selectedPizza = "SEA FOOD"
            If pizzaSize = 10 Then
                price = 5.0
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 7.0
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 9.0
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf italianHot Then

            selectedPizza = "ITALIAN FOOD"
            If pizzaSize = 10 Then
                price = 8.0
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 10.0
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 13.0
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf seafood Then

            selectedPizza = "SEA FOOD"
            If pizzaSize = 10 Then
                price = 9.0
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 10.0
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 13
                If calzone Then
                    price = price + 2
                End If
            End If
        ElseIf ilPadrino Then
            selectedPizza = "IL PADRINO"
            If pizzaSize = 10 Then
                price = 9
                If calzone Then
                    price = price + 1
                End If
            ElseIf pizzaSize = 12 Then
                price = 11
                If calzone Then
                    price = price + 1.5
                End If
            ElseIf pizzaSize = 14 Then
                price = 13.5
                If calzone Then
                    price = price + 2
                End If
            End If
        End If

        If calzone Then
            selectedPizza = selectedPizza & " Calzone"
        End If
        selectedPizzaWithSize = selectedPizza & " " & pizzaSize.ToString() & ControlChars.Quote


        frmBasket.dtPublic.Rows.Add(selectedPizzaWithSize, "£", price)
        dgvBasket.DataSource = frmBasket.dtPublic

    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Margherita = False
        hawaiian = True
        tuscany = False
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = False
        veg = False
        seafood = False
        italianHot = False
        ilPadrino = False
        napoli = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Margherita = False
        hawaiian = False
        tuscany = True
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = False
        veg = False
        seafood = False
        italianHot = False
        ilPadrino = False
        napoli = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        Margherita = False
        hawaiian = False
        tuscany = False
        napoli = True
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = False
        veg = False
        seafood = False
        italianHot = False
        ilPadrino = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Margherita = False
        hawaiian = False
        tuscany = False
        napoli = False
        southern = True
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = False
        veg = False
        seafood = False
        italianHot = False
        ilPadrino = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        Margherita = False
        hawaiian = False
        tuscany = False
        napoli = False
        southern = False
        spicyChicken = True
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = False
        veg = False
        seafood = False
        italianHot = False
        ilPadrino = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Margherita = False
        hawaiian = False
        tuscany = False
        napoli = False
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = True
        donnerHot = False
        meatFeast = False
        veg = False
        seafood = False
        italianHot = False
        ilPadrino = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        Margherita = False
        hawaiian = False
        tuscany = False
        napoli = False
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = True
        meatFeast = False
        veg = False
        seafood = False
        italianHot = False
        ilPadrino = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        Margherita = False
        hawaiian = False
        tuscany = False
        napoli = False
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = False
        veg = True
        seafood = False
        italianHot = False
        ilPadrino = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        Margherita = False
        hawaiian = False
        tuscany = False
        napoli = False
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = False
        veg = False
        seafood = True
        italianHot = False
        ilPadrino = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button11_Click(sender As Object, e As EventArgs) Handles button11.Click
        Margherita = False
        hawaiian = False
        tuscany = False
        napoli = False
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = False
        veg = False
        seafood = False
        italianHot = True
        ilPadrino = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button12_Click(sender As Object, e As EventArgs) Handles button12.Click
        Margherita = False
        hawaiian = False
        tuscany = False
        napoli = False
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = False
        veg = False
        seafood = False
        italianHot = False
        ilPadrino = True

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub button14_Click(sender As Object, e As EventArgs) Handles button14.Click
        Margherita = False
        hawaiian = False
        tuscany = False
        napoli = False
        southern = False
        spicyChicken = False
        spicyBeef = False
        donner = False
        donnerHot = False
        meatFeast = True
        veg = False
        seafood = False
        italianHot = False
        ilPadrino = False

        frmPizzaCalzone.Show()
        'frmPizzaSizes.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If dgvBasket.Rows.Count > 0 Then
            Dim index As Integer
            index = dgvBasket.CurrentCell.RowIndex
            dgvBasket.Rows.RemoveAt(index)
            Dim dtNew As New DataTable
            dtNew = TryCast(dgvBasket.DataSource, DataTable)
            frmBasket.dtPublic = dtNew
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim totalCost As Double
        If dgvBasket.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgvBasket.Rows
                If Not IsDBNull(row.Cells(2).Value) Then
                    'If Not row.Cells(2).Value = "" Or IsDBNull(row.Cells(2).Value) Then
                    totalCost = totalCost + CDbl(row.Cells("Price").Value)
                End If
            Next
            lblTotal.Text = totalCost.ToString()
        ElseIf dgvBasket.Rows.Count = 0 Then
            totalCost = 0.0
            lblTotal.Text = totalCost.ToString()
        End If

    End Sub

    Private Sub button13_Click(sender As Object, e As EventArgs) Handles button13.Click
        frmPizzaToppings.Show()
    End Sub

    Private Sub button16_Click(sender As Object, e As EventArgs) Handles button16.Click
        If pizzaSize = 10 Then
            frmBasket.dtPublic.Rows.Add("DONNER TOPPING", "£", 1.5)
        ElseIf pizzaSize = 12 Then
            frmBasket.dtPublic.Rows.Add("DONNER TOPPING", "£", 2)
        ElseIf pizzaSize = 14 Then
            frmBasket.dtPublic.Rows.Add("DONNER TOPPING", "£", 2.5)
        End If
    End Sub
End Class