Imports System.Reflection
Public Class frmBasket

    Public pizzaSiza As Integer
    Dim versionNumber As Version

    Private Sub frmBasket_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblVersion.Text = versionNumber.ToString()
        Timer1.Start()
        dgvBasket.ColumnCount = 2

        'dgvBasket.Columns[0].Name = "Product"
        '    dgvBasket.Columns[0].Width = 250
        '    dgvBasket.Columns[1].Name = "Price"
        '    dgvBasket.DataSource = orderTable
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmPizzas.Show()
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class