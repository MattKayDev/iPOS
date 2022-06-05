Imports System.Reflection
Public Class frmFriedChicken

    Dim versionNumber As Version

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        frmBasket.dtPublic.Rows.Add("1 Piece Chicken", "£", 1.5)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmBasket.dtPublic.Rows.Add("1 Piece Chicken", "£", 0.6)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBasket.dtPublic.Rows.Add("1 Piece Chicken with Chips", "£", 2.5)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmBasket.dtPublic.Rows.Add("2 Piece Chicken with Chips", "£", 4.0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmBasket.dtPublic.Rows.Add("3 Piece Chicken with Chips", "£", 5.5)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '6Pcs of Chicken, 3 Chips + 2 Cans
        frmBasket.dtPublic.Rows.Add("6Pcs of Chicken, 3 Chips + 2 Cans", "£", 13)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        frmBasket.dtPublic.Rows.Add("10 Chicken Wings", "£", 13)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmBasket.dtPublic.Rows.Add("2pcs of chicken , 2 chicken wings, can & fries", "£", 6)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmBasket.dtPublic.Rows.Add("4pcs of chicken , 2 chicken wings, can & fries", "£", 8)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        frmBasket.dtPublic.Rows.Add("5 Chicken wings, can & fries", "£", 4.5)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        frmBasket.dtPublic.Rows.Add("10 Chicken wings, can & fries", "£", 7.5)
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

    Private Sub frmFriedChicken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
End Class