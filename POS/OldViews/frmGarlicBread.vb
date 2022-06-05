Imports System.Reflection
Public Class frmGarlicBread
    Dim versionNumber As Version
    Private Sub frmGarlicBread_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        dgvBasket.DataSource = frmBasket.dtPublic
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD 10" & ControlChars.Quote, "£", 4)
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD  WITH CHEESE 10" & ControlChars.Quote, "£", 4.5)
    End Sub

    Private Sub button3_Click(sender As Object, e As EventArgs) Handles button3.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD CHEESE & MUSHROOMS 10" & ControlChars.Quote, "£", 5)
    End Sub

    Private Sub button4_Click(sender As Object, e As EventArgs) Handles button4.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD WITH CHEESE & PEPPERONI 10" & ControlChars.Quote, "£", 5)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD 12" & ControlChars.Quote, "£", 5.5)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD WITH CHEESE 12" & ControlChars.Quote, "£", 6.5)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD WITH CHEESE & MUSHROOM 12" & ControlChars.Quote, "£", 7)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD WITH CHEESE & PEPPERONI 12" & ControlChars.Quote, "£", 7)
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD 14" & ControlChars.Quote, "£", 7.5)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD WITH CHEESE 14" & ControlChars.Quote, "£", 8.5)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD WITH CHEESE & MUSHROOM 14" & ControlChars.Quote, "£", 9.5)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        frmBasket.dtPublic.Rows.Add("GARLIC BREAD WITH CHEESE & PEPPERONI 14" & ControlChars.Quote, "£", 9.5)
    End Sub

    Private Sub button15_Click(sender As Object, e As EventArgs) Handles button15.Click
        Me.Hide()
        frmBasket.Show()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        frmBasket.dtPublic.Rows.Add("FREE GARLIC BREAD 10" & ControlChars.Quote)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        frmBasket.dtPublic.Rows.Add("CHEESE")
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