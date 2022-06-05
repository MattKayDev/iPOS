Imports System.Reflection
Public Class frmKebabs

    Dim versionNumber As Version

    Dim donnerKebab As Boolean
    Dim chickenKebab As Boolean
    Dim mixKebab As Boolean

    Dim selectedKebab As String

    Public pitaOrNaan As Boolean
    Dim price As Double
    Dim selectedKebabWithBread As String

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        donnerKebab = True
        chickenKebab = False
        mixKebab = False
        frmKebabSelect.Show()
    End Sub

    Public Sub ShowKebab()
        If donnerKebab Then
            selectedKebab = "DONNER KEBAB"
            If pitaOrNaan Then
                price = 4.5
            Else
                price = 5.5
            End If
        ElseIf chickenKebab Then
            selectedKebab = "CHICKEN KEBAB"
            If pitaOrNaan Then
                price = 5.5
            Else
                price = 6.5
            End If
        ElseIf mixKebab Then
            selectedKebab = "MIX KEBAB"
            If pitaOrNaan Then
                price = 6
            Else
                price = 7.5
            End If

        End If
        frmKebabSalad.Show()

        'selectedKebabWithBread = selectedBurger & " " & burgerSizeInch
        frmBasket.dtPublic.Rows.Add(selectedKebab, "£", price)
        dgvBasket.DataSource = frmBasket.dtPublic

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        donnerKebab = False
        chickenKebab = True
        mixKebab = False
        frmKebabSelect.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mixKebab = True
        donnerKebab = False
        chickenKebab = False
        frmKebabSelect.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmBasket.dtPublic.Rows.Add("Cheese", "£", 1)
        'Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmKebabSalad.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmKebabSauce.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        dgvBasket.DataSource = frmBasket.dtPublic
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim totalCost As Double
        If dgvBasket.Rows.Count > 0 Then
            For Each row As DataGridViewRow In dgvBasket.Rows
                If Not IsDBNull(row.Cells(2).Value) Then
                    'If IsDBNull(row.Cells(2).vale)
                    totalCost = totalCost + CDbl(row.Cells(2).Value)
                End If
            Next
            lblTotal.Text = totalCost.ToString()
        ElseIf dgvBasket.Rows.Count = 0 Then
            totalCost = 0.0
            lblTotal.Text = totalCost.ToString()
        End If
    End Sub

    Private Sub frmKebabs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label1.Text = My.Settings.posName
        'Me.WindowState = FormWindowState.Maximized
        Me.WindowState = FormWindowState.Maximized
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblVersion.Text = versionNumber.ToString()
        Timer1.Start()
        Timer2.Start()
        'dtBasket = frmBasket.dtPublic
        dgvBasket.DataSource = frmBasket.dtPublic

        Dim column1 As DataGridViewColumn = dgvBasket.Columns(0)
        column1.Width = 300
        Dim column2 As DataGridViewColumn = dgvBasket.Columns(1)
        column2.Width = 30
        Dim column3 As DataGridViewColumn = dgvBasket.Columns(2)
        column3.Width = 50
    End Sub

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        Me.Hide()
        frmBasket.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        frmBasket.dtPublic.Rows.Add("DONNER BARM MEAL", "£", 5.5)
        frmBasket.dtPublic.Rows.Add("CHIPS")
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim result As DialogResult = MessageBox.Show("Chips with it?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            frmBasket.dtPublic.Rows.Add("TRAY OF DONNER", "£", 4)
        ElseIf result = DialogResult.Yes Then
            frmBasket.dtPublic.Rows.Add("TRAY OF DONNER WITH CHIPS", "£", 5)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim result As DialogResult = MessageBox.Show("Chips with it?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            frmBasket.dtPublic.Rows.Add("TRAY OF CHICKEN", "£", 7)
        ElseIf result = DialogResult.Yes Then
            frmBasket.dtPublic.Rows.Add("TRAY OF CHICKEN WITH CHIPS", "£", 8)
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmBasket.dtPublic.Rows.Add("DONNER BARM", "£", 3.8)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim result As DialogResult = MessageBox.Show("Chips with it?", "", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            frmBasket.dtPublic.Rows.Add("LARGE TRAY OF DONNER", "£", 6)
        ElseIf result = DialogResult.Yes Then
            frmBasket.dtPublic.Rows.Add("LARGE TRAY OF DONNER WITH CHIPS", "£", 7.5)
        End If
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

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        frmBasket.dtPublic.Rows.Add("Meal", "£", 1.7)
        frmBasket.dtPublic.Rows.Add("Chips") '
        frmMealDrink.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs)
        frmBasket.dtPublic.Rows.Add("NO CHEESE") '
    End Sub
End Class