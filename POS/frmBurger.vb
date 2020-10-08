Imports System.Reflection

Public Class frmBurger

    Dim versionNumber As Version

    Dim dtBasket As DataTable

    Dim beefBurger As Boolean
    Dim cheeseBurger As Boolean
    Public chickenFilletBurger As Boolean
    Dim chickenTikkaBurger As Boolean
    Dim chickenSizzlerBurger As Boolean
    Dim mexicanBurger As Boolean
    Dim hawaiianBurger As Boolean
    Dim chickenFilletBurgerMeal As Boolean
    Dim chickenTikkaBurgerMeal As Boolean
    Dim chickenSizzlerBurgerMeal As Boolean

    Public burgerSize As Boolean
    Dim selectedBurger As String
    Dim price As Double
    Dim selectedBurgerWithSize As String



    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        frmBasket.dtPublic = dtBasket
        Me.Hide()
        frmBasket.Show()
    End Sub

    Private Sub frmBurger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
        Me.WindowState = FormWindowState.Maximized
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblVersion.Text = versionNumber.ToString()
        Timer1.Start()
        Timer2.Start()
        dtBasket = frmBasket.dtPublic
        dgvBasket.DataSource = dtBasket

        Dim column1 As DataGridViewColumn = dgvBasket.Columns(0)
        column1.Width = 300
        Dim column2 As DataGridViewColumn = dgvBasket.Columns(1)
        column2.Width = 30
        Dim column3 As DataGridViewColumn = dgvBasket.Columns(2)
        column3.Width = 50
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

    Public Sub ShowBurger()
        If beefBurger Then
            selectedBurger = "BEEF BURGER"
            If burgerSize Then
                price = 3
            Else
                price = 4.5
            End If
        ElseIf cheeseBurger Then
            selectedBurger = "CHEESE BURGER"
            If burgerSize Then
                price = 4
            Else
                price = 4.8
            End If
        ElseIf chickenFilletBurger Then
            selectedBurger = "CHICKEN FILLET BURGER"
            If burgerSize Then
                price = 3.8
            Else
                'price = 4.5
            End If
        ElseIf chickenTikkaBurger Then
            selectedBurger = "CHICKEN TIKKA BURGER"
            If burgerSize Then
                price = 3
            Else
                price = 4.5
            End If
        ElseIf chickenSizzlerBurger Then
            selectedBurger = "CHICKEN SIZZLER BURGER"
            If burgerSize Then
                price = 3
            Else
                price = 4.5
            End If
        ElseIf mexicanBurger Then
            selectedBurger = "MEXICAN BURGER"
            If burgerSize Then
                price = 3
            Else
                price = 4.5
            End If
        ElseIf hawaiianBurger Then
            selectedBurger = "HAWAIIAN BURGER"
            If burgerSize Then
                price = 3
            Else
                price = 4.5
            End If
        ElseIf chickenFilletBurgerMeal Then
            selectedBurger = "CHICKEN FILLET BURGER MEAL"
            price = 5.5
        ElseIf chickenTikkaBurgerMeal Then
            selectedBurger = "CHICKEN TIKKA BURGER MEAL"
            price = 6
        ElseIf chickenSizzlerBurgerMeal Then
            selectedBurger = "CHICKEN SIZZLER BURGER MEAL"
            price = 6
        End If




        Dim burgerSizeInch As String
        If burgerSize Then
            burgerSizeInch = "1/4"
        Else
            burgerSizeInch = "1/2"
        End If

        selectedBurgerWithSize = selectedBurger & " " & burgerSizeInch
        frmBasket.dtPublic.Rows.Add(selectedBurgerWithSize, "£", price)
        dgvBasket.DataSource = frmBasket.dtPublic
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        beefBurger = True
        cheeseBurger = False
        chickenFilletBurger = False
        chickenTikkaBurger = False
        chickenSizzlerBurger = False
        mexicanBurger = False
        hawaiianBurger = False
        chickenFilletBurgerMeal = False
        chickenTikkaBurgerMeal = False
        chickenSizzlerBurgerMeal = False

        frmBurgersize.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        beefBurger = False
        cheeseBurger = True
        chickenFilletBurger = False
        chickenTikkaBurger = False
        chickenSizzlerBurger = False
        mexicanBurger = False
        hawaiianBurger = False
        chickenFilletBurgerMeal = False
        chickenTikkaBurgerMeal = False
        chickenSizzlerBurgerMeal = False
        frmBurgersize.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        beefBurger = False
        cheeseBurger = False
        chickenFilletBurger = True
        chickenTikkaBurger = False
        chickenSizzlerBurger = False
        mexicanBurger = False
        hawaiianBurger = False
        chickenFilletBurgerMeal = False
        chickenTikkaBurgerMeal = False
        chickenSizzlerBurgerMeal = False
        frmBurgersize.Show()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        beefBurger = False
        cheeseBurger = False
        chickenFilletBurger = False
        chickenTikkaBurger = True
        chickenSizzlerBurger = False
        mexicanBurger = False
        hawaiianBurger = False
        chickenFilletBurgerMeal = False
        chickenTikkaBurgerMeal = False
        chickenSizzlerBurgerMeal = False
        frmBurgersize.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        beefBurger = False
        cheeseBurger = False
        chickenFilletBurger = False
        chickenTikkaBurger = False
        chickenSizzlerBurger = True
        mexicanBurger = False
        hawaiianBurger = False
        chickenFilletBurgerMeal = False
        chickenTikkaBurgerMeal = False
        chickenSizzlerBurgerMeal = False
        frmBurgersize.Show()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        beefBurger = False
        cheeseBurger = False
        chickenFilletBurger = False
        chickenTikkaBurger = False
        chickenSizzlerBurger = False
        mexicanBurger = True
        hawaiianBurger = False
        chickenFilletBurgerMeal = False
        chickenTikkaBurgerMeal = False
        chickenSizzlerBurgerMeal = False
        frmBurgersize.Show()
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        beefBurger = False
        cheeseBurger = False
        chickenFilletBurger = False
        chickenTikkaBurger = False
        chickenSizzlerBurger = False
        mexicanBurger = False
        hawaiianBurger = True
        chickenFilletBurgerMeal = False
        chickenTikkaBurgerMeal = False
        chickenSizzlerBurgerMeal = False
        frmBurgersize.Show()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        beefBurger = False
        cheeseBurger = False
        chickenFilletBurger = False
        chickenTikkaBurger = False
        chickenSizzlerBurger = False
        mexicanBurger = False
        hawaiianBurger = False
        chickenFilletBurgerMeal = True
        chickenTikkaBurgerMeal = False
        chickenSizzlerBurgerMeal = False
        ShowBurger()
        frmBurgerSides.Show()
        'frmBurgersize.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        beefBurger = False
        cheeseBurger = False
        chickenFilletBurger = False
        chickenTikkaBurger = False
        chickenSizzlerBurger = False
        mexicanBurger = False
        hawaiianBurger = False
        chickenFilletBurgerMeal = False
        chickenTikkaBurgerMeal = True
        chickenSizzlerBurgerMeal = False
        ShowBurger()
        frmBurgerSides.Show()
        'frmBurgersize.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        beefBurger = False
        cheeseBurger = False
        chickenFilletBurger = False
        chickenTikkaBurger = False
        chickenSizzlerBurger = False
        mexicanBurger = False
        hawaiianBurger = False
        chickenFilletBurgerMeal = False
        chickenTikkaBurgerMeal = False
        chickenSizzlerBurgerMeal = True
        ShowBurger()
        frmBurgerSides.Show()
        'frmBurgersize.Show()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        frmBasket.dtPublic.Rows.Add("Cheese", "£", "0.50")
        dgvBasket.DataSource = frmBasket.dtPublic
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        frmBurgerSides.Show()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        dgvBasket.DataSource = frmBasket.dtPublic
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        frmBasket.dtPublic.Rows.Add("Meal", "£", 1.7)
        frmBasket.dtPublic.Rows.Add("Chips")
        frmMealDrink.Show()
    End Sub
End Class