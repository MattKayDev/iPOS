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

    'Const String quote = 

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        Me.Hide()
        frmBasket.Show()
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub frmPizzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblVersion.Text = versionNumber.ToString()
        timer1.Start()



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
        frmPizzaSizes.Show()
    End Sub

    Public Sub ShowPizza()
        Dim price As Double = 7.5
        If Margherita Then

            selectedPizza = "MARGHERITA"

        ElseIf hawaiian Then

            selectedPizza = "HAWAIIAN"

        ElseIf napoli Then

            selectedPizza = "NAPOLI"

        ElseIf tuscany Then

            selectedPizza = "TUSCANY"

        ElseIf southern Then

            selectedPizza = "SOUTHERN"

        ElseIf spicyChicken Then

            selectedPizza = "SPICY CHICKEN"

        ElseIf donner Then

            selectedPizza = "DONNER"

        ElseIf donnerHot Then

            selectedPizza = "DONNER HOT"

        ElseIf meatFeast Then

            selectedPizza = "MEAT FEAST"

        ElseIf veg Then

            selectedPizza = "VEG"

        ElseIf seafood Then

            selectedPizza = "SEA FOOD"

        ElseIf italianHot Then

            selectedPizza = "ITALIAN FOOD"

        ElseIf seafood Then

            selectedPizza = "SEA FOOD"

        ElseIf ilPadrino Then
            selectedPizza = "IL PADRINO"
        End If


        selectedPizzaWithSize = selectedPizza & " " & pizzaSize.ToString() & ControlChars.Quote


        'MessageBox.Show(selectedPizzaWithSize)
        dgvBasket.Rows.Add(selectedPizzaWithSize, "£" & price)
        '//DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
        '//dgvBasket.Rows.Add(selectedPizzaWithSize,"£7.50");
        'frmBasket = frmStart.basket;
        'frmBasket.orderTable.Rows.Add(selectedPizzaWithSize, "£7.50");
        'dgvBasket.DataSource = frmBasket.orderTable;
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
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

        frmPizzaSizes.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim index As Integer
        index = dgvBasket.CurrentCell.RowIndex
        dgvBasket.Rows.RemoveAt(index)
    End Sub
End Class