Imports System.Reflection
Public Class frmDrinks

    Dim VERSIONnUMBER As Version
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

    Private Sub frmDrinks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label1.Text = My.Settings.posName
        Me.WindowState = FormWindowState.Maximized
        VERSIONnUMBER = Assembly.GetExecutingAssembly().GetName().Version
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblVersion.Text = versionNumber.ToString()
        Timer1.Start()
        Timer2.Start()


        dgvBasket.DataSource = frmBasket.dtPublic
        Dim column1 As DataGridViewColumn = dgvBasket.Columns(0)
        column1.Width = 300
        Dim column2 As DataGridViewColumn = dgvBasket.Columns(1)
        column2.Width = 30
        Dim column3 As DataGridViewColumn = dgvBasket.Columns(2)
        column3.Width = 50
    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        frmBasket.dtPublic.Rows.Add("Pepsi can", "£", 0.9)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmBasket.dtPublic.Rows.Add("BOTTLE 1.5L PEPSI", "£", 2.4)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmBasket.dtPublic.Rows.Add("BOTTLE 1.5L DIET COKE", "£", 2.4)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmBasket.dtPublic.Rows.Add("BOTTLE 1.5L COKE", "£", 2.4)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        frmBasket.dtPublic.Rows.Add("WATER", "£", 1)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmBasket.dtPublic.Rows.Add("Milkshake Chocolate", "£", 1.4)
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmBasket.dtPublic.Rows.Add("Milkshake Strawberry", "£", 1.4)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmBasket.dtPublic.Rows.Add("Milkshake Banana", "£", 1.4)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        frmBasket.dtPublic.Rows.Add("Vimto can", "£", 0.9)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmBasket.dtPublic.Rows.Add("Diet Coke can", "£", 0.9)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        frmBasket.dtPublic.Rows.Add("Coke can", "£", 0.9)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        frmBasket.dtPublic.Rows.Add("Dr Pepper can", "£", 0.9)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        frmBasket.dtPublic.Rows.Add("Rio can", "£", 0.9)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        frmBasket.dtPublic.Rows.Add("Tango can", "£", 0.9)
    End Sub
End Class