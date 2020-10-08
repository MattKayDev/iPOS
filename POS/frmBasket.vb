Imports System.Reflection
Public Class frmBasket

    Public pizzaSiza As Integer
    Dim versionNumber As Version
    Public dtPublic As New DataTable

    'ssssPublic dgvBasketTest As DataGridView

    Private Sub frmBasket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblVersion.Text = versionNumber.ToString()
        Timer1.Start()
        Timer2.Start()

        If dtPublic.Rows.Count < 1 Then
            dtPublic.Clear()
            dtPublic.Columns.AddRange(New DataColumn() {New DataColumn("Product", GetType(String)),
                                          New DataColumn("£/$", GetType(String)),
                                         New DataColumn("Price", GetType(Double))})
        End If
        dgvBasket.DataSource = dtPublic
        Dim column1 As DataGridViewColumn = dgvBasket.Columns(0)
        column1.Width = 300
        Dim column2 As DataGridViewColumn = dgvBasket.Columns(1)
        column2.Width = 30
        Dim column3 As DataGridViewColumn = dgvBasket.Columns(2)
        column3.Width = 50

        'dgvBasketTest.DataSource = dgvBasket.DataSource
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmPizzas.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        dgvBasket.DataSource = dtPublic
    End Sub

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If dgvBasket.Rows.Count > 0 Then
            Dim index As Integer
            index = dgvBasket.CurrentCell.RowIndex
            dgvBasket.Rows.RemoveAt(index)
            Dim dtNew As New DataTable
            dtNew = TryCast(dgvBasket.DataSource, DataTable)
            dtPublic = dtNew
        End If

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

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs) Handles lblTotal.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub dgvBasket_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBasket.CellContentClick

    End Sub

    Private Sub lblVersion_Click(sender As Object, e As EventArgs) Handles lblVersion.Click

    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click

    End Sub

    Private Sub lblTime_Click(sender As Object, e As EventArgs) Handles lblTime.Click

    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click

    End Sub

    Private Sub label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        frmCheckout.lblTotal.Text = lblTotal.Text
        'frmCheckout.totalPrice = CStr(lblTotal.Text)
        Me.Hide()
        frmCheckout.Show()
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        Me.Hide()
        frmBurger.Show()
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        frmKebabs.Show()
        Me.Hide()
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Me.Hide()
        frmWraps.Show()
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        Me.Hide()
        frmGarlicBread.Show()
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        Me.Hide()
        frmDrinks.Show()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        dtPublic.Rows.Add("CHIPS", "£", 1)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        dtPublic.Rows.Add("CHIPS & CHEESE", "£", 2)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        dtPublic.Rows.Add("CHIPS & CURRY", "£", 2)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        dtPublic.Rows.Add("CHIPS & GRAVY", "£", 2)
    End Sub

    Private Sub button6_Click(sender As Object, e As EventArgs) Handles button6.Click
        frmFriedChicken.Show()
        Me.Hide()
    End Sub

    Private Sub button8_Click(sender As Object, e As EventArgs) Handles button8.Click
        frmSideOrders.Show()
        Me.Hide()
    End Sub

    Private Sub button7_Click(sender As Object, e As EventArgs) Handles button7.Click
        Me.Hide()
        frmJacketPotatoes.Show()
    End Sub

    Private Sub button9_Click(sender As Object, e As EventArgs) Handles button9.Click
        frmKidsMeals.Show()
        Me.Hide()
    End Sub
End Class