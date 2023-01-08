Imports System.Reflection
Imports System.Text
Imports System.Data.OleDb

Imports POS.Database

Public Class MainForm


    Dim versionNumber As Version
    Dim selectedPostCode As Boolean
    Dim selectedNo As Boolean
    Dim selectedAddress As Boolean

    Dim dbProvider As String
    Dim dbSource As String

    Dim dbPathAndFilename As String
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Public dr As OleDbDataReader
    Dim cm As OleDbCommand

    Dim foundAddress As Boolean

    Public Shared order As New Order
    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        order.Type = True
        HideMainControls()
        Dim mainMenu As New MainMenuView
        pMain.Controls.Add(mainMenu)
    End Sub

    Private Sub btnCollection_Click(sender As Object, e As EventArgs) Handles btnCollection.Click
        order.Type = False
        HideMainControls()
        Dim mainMenu As New MainMenuView
        pMain.Controls.Add(mainMenu)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        lblVersion.Text = versionNumber.ToString()
        timer1.Start()
        lblIPOS.Text = "iPOS" ' - " & Get_CompanyName_From_Database()
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Finished? ", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            Me.Close()
        End If
    End Sub

    Sub HideMainControls()
        picBanner.Visible = False
        btnCollection.Visible = False
        btnDelivery.Visible = False
        btnClose.Visible = False
    End Sub

    Sub ShowMainControls()
        picBanner.Visible = True
        btnCollection.Visible = True
        btnDelivery.Visible = True
        btnClose.Visible = True
    End Sub

    Private Sub dgvBasket_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvBasket.RowsAdded
        btnRemovedVisibiity()
    End Sub

    Private Sub dgvBasket_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvBasket.RowsRemoved
        btnRemovedVisibiity()
    End Sub

    Sub btnRemovedVisibiity()
        If dgvBasket.RowCount > 0 Then
            btnRemoveItem.Visible = True
        ElseIf dgvBasket.RowCount = 0 Then
            btnRemoveItem.Visible = False

        End If
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If dgvBasket.RowCount > 0 Then
            If dgvBasket.CurrentCell.Selected Then
                Dim index As Integer = dgvBasket.CurrentCell.RowIndex
                dgvBasket.Rows.RemoveAt(index)
            End If
        End If
    End Sub
End Class