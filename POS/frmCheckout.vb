Imports System.ComponentModel
Imports System.Reflection
Imports System.Data.OleDb

Public Class frmCheckout

    Public basketPostCode As String

    Public totalPrice As String 'allows to bring total price to checkout
    Dim versionNumber As Version


    Dim StoreName As String = "Il Padrino"
    Dim StoreAddress As String = "Unit 2 Lovely Ln" & vbCrLf & "Bewsey" & vbCrLf & "Warrington WA5 0NL"
    '    Dim Img As Image = Image.FromFile("c:\logo.jpg")
    'Dim TransNo As String = "TCN10-20191204-001"
    Dim TransDate As String = Format(Now, "yyyy-MM-dd HH:mm:ss")

    'for item sales 
    Dim dtItem As DataTable
    Dim arrWidth() As Integer
    Dim arrFormat() As StringFormat

    'declaring printing format class
    Dim c As New PrintingFormat

    'for subtotal & qty total
    Dim dblSubtotal As Double = 0
    Dim dblQty As Double = 0
    Dim dblPayment As Double = 50000


    Dim dblChange As Double
    Dim totalCost As Double

    Dim delivery As String

    Dim dbProvider As String
    Dim dbSource As String

    Dim dbPathAndFilename As String
    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim sql As String
    Public dr As OleDbDataReader
    Dim cm As OleDbCommand


    Dim selectedPostCode As Boolean
    Dim selectedNo As Boolean
    Dim selectedAddress As Boolean

    Private Sub frmCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        label1.Text = My.Settings.posName
        If My.Settings.delivery = True Then
            delivery = "Delivery"
        Else
            delivery = "Collection"
            txtAddress.Text = ""
            txtPostCode.Text = ""
            txtNo.Text = ""
        End If
        Me.WindowState = FormWindowState.Maximized
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblVersion.Text = versionNumber.ToString()
        dgvBasket.DataSource = frmBasket.dtPublic

        'lblTotal.Text = totalPrice
        'lblTotal.Text = frmBasket.lblTotal.Text
        selectedPostCode = True

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;" ' MDB
        'dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'ACCDB
        dbSource = "Data Source="

        'LoadData()
    End Sub

    Sub Data_Load()
        dtItem = New DataTable
        dtItem = frmBasket.dtPublic
        'With dtItem.Columns
        '    .Add("itemname", Type.GetType("System.String"))
        '    .Add("qty", Type.GetType("System.String"))
        '    .Add("price", Type.GetType("System.String"))
        'End With

        'Dim ItemRow As DataRow

        'ItemRow = dtItem.NewRow()
        'ItemRow("itemname") = "Taro Snack"
        'ItemRow("qty") = "1"
        'ItemRow("price") = "5000"
        'dtItem.Rows.Add(ItemRow)

        'ItemRow = dtItem.NewRow()
        'ItemRow("itemname") = "Kopi Ice"
        'ItemRow("qty") = "2"
        'ItemRow("price") = "7000"
        'dtItem.Rows.Add(ItemRow)

        'ItemRow = dtItem.NewRow()
        'ItemRow("itemname") = "Lolipop"
        'ItemRow("qty") = "5"
        'ItemRow("price") = "1000"
        'dtItem.Rows.Add(ItemRow)

    End Sub

    Private Sub button10_Click(sender As Object, e As EventArgs) Handles button10.Click
        txtCustNumb.Text = txtCustNumb.Text & "1"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtCustNumb.Text = txtCustNumb.Text & "2"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtCustNumb.Text = txtCustNumb.Text & "3"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtCustNumb.Text = txtCustNumb.Text & "4"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txtCustNumb.Text = txtCustNumb.Text & "5"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtCustNumb.Text = txtCustNumb.Text & "6"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txtCustNumb.Text = txtCustNumb.Text & "7"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txtCustNumb.Text = txtCustNumb.Text & "8"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txtCustNumb.Text = txtCustNumb.Text & "9"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txtCustNumb.Text = txtCustNumb.Text & "0"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        txtCustNumb.Text = txtCustNumb.Text.Remove(txtCustNumb.Text.Length - 1)
    End Sub


    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub frmCheckout_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        'Form1.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        If selectedPostCode Then
            If txtPostCode.Text.Length > 0 Then
                txtPostCode.Text = txtPostCode.Text.Remove(txtPostCode.Text.Length - 1)
            End If
        ElseIf selectedNo Then
            If txtNo.Text.Length > 0 Then
                txtNo.Text = txtNo.Text.Remove(txtNo.Text.Length - 1)
            End If
        ElseIf selectedAddress Then
            If txtAddress.Text.Length > 0 Then
                txtAddress.Text = txtAddress.Text.Remove(txtAddress.Text.Length - 1)
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        selectedAddress = False
        selectedNo = False
        selectedPostCode = True
    End Sub

    Private Sub chbNo_CheckedChanged(sender As Object, e As EventArgs)
        selectedAddress = False
        selectedNo = True
        selectedPostCode = False
    End Sub

    Private Sub chbAddress_CheckedChanged(sender As Object, e As EventArgs)
        selectedAddress = True
        selectedNo = False
        selectedPostCode = False
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim l As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & l
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & l
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & l
        End If
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        Dim totalPrice As String
        totalCost = CDbl(lblTotal.Text)

        If totalCost < 20 Then
            dblPayment = 20
            dblChange = dblPayment - totalCost
        ElseIf totalCost > 20 & totalCost < 40 Then
            dblPayment = 40
            dblChange = dblPayment - totalCost
        ElseIf totalCost > 40 & totalCost < 60 Then
            dblPayment = 60
            dblChange = dblPayment - totalCost
        End If
        'Math.Round(totalCost, 2)
        Print_Receipt() 'print 

        frmBasket.dtPublic.Clear()

        txtPostCode.Text = ""
        txtAddress.Text = ""
        txtNo.Text = ""
        txtCustNumb.Text = ""
        'MainForm.txtAddress.Text = ""
        'MainForm.txtNo.Text = ""
        'MainForm.txtPostCode.Text = ""
        'MainForm.gpbPostCode.Visible = False
        My.Settings.delivery = False
        Me.Hide()
        MainForm.Show()
    End Sub

    Private Sub Print_Receipt()
        Data_Load()

        Printer.NewPrint()

        'Printer.Print(Img, 200, 100)

        'Setting Font
        'Printer.SetFont("Courier New", 11, FontStyle.Bold)
        'Printer.Print(StoreName &
        '              vbCrLf &
        '              StoreAddress &
        '              vbCrLf &
        '              TransDate &
        '              vbCrLf &
        '              delivery &
        '              vbCrLf &
        '              txtNo.Text &
        '              vbCrLf &
        '              txtPostCode.Text &
        '              vbCrLf &
        '              txtCustNumb.Text &
        '              vbCrLf) 'Store Name 


        'Setting Font
        Printer.SetFont("Courier New", 8, FontStyle.Regular)
        'Printer.Print(StoreAddress & ";", {280}, 0) 'Store Address
        'spacing
        'Printer.Print(" " & vbCrLf)
        'Printer.Print(TransNo) ' Transaction No 
        Printer.Print(TransDate) ' Trans Date 
        'Delivery
        Printer.SetFont("Courier New", 11, FontStyle.Bold)
        Printer.Print(delivery)
        'Print Address
        Printer.SetFont("Courier New", 10, FontStyle.Bold)
        Printer.Print(txtNo.Text & " " & txtAddress.Text) 'Store Name 
        'Print Postcode
        Printer.SetFont("Courier New", 10, FontStyle.Bold)
        Printer.Print(txtPostCode.Text) 'Store Name 
        'Print Telephone Number
        Printer.SetFont("Courier New", 10, FontStyle.Bold)
        Printer.Print(txtCustNumb.Text) 'Store Name 
        Printer.Print(" ") 'spacing
        Printer.SetFont("Courier New", 8, FontStyle.Bold) 'Setting Font
        arrWidth = {90, 40, 50, 70} 'array for column width 
        arrFormat = {c.MidLeft, c.MidRight, c.MidRight, c.MidRight} 'array alignment 
        'column header split by ;
        Printer.Print("Product; price;", arrWidth, arrFormat)
        Printer.SetFont("Courier New", 8, FontStyle.Regular) 'Setting Font
        Printer.Print("----------------------") 'line
        Printer.SetFont("Courier New", 8, FontStyle.Bold)
        dblSubtotal = 0
        dblQty = 0
        'looping item sales
        For r = 0 To dtItem.Rows.Count - 1
            Printer.Print(dtItem.Rows(r).Item("Product") & " " &
                      dtItem.Rows(r).Item("£/$") & "" &
                      dtItem.Rows(r).Item("Price"))
            '(dtItem.Rows(r).Item("qty") *
            'dtItem.Rows(r).Item("price")), arrWidth, arrFormat)
            'dblQty = dblQty + CSng(dtItem.Rows(r).Item("qty"))
            'dblSubtotal = dblSubtotal + (dtItem.Rows(r).Item("qty") * dtItem.Rows(r).Item("price")

        Next
        Printer.SetFont("Courier New", 8, FontStyle.Regular)
        Printer.Print("----------------------")
        'Printer.SetFont("Courier New", 8, FontStyle.Bold)
        arrWidth = {500, 1000} 'array for column width 
        arrFormat = {c.MidLeft, c.MidRight} 'array alignment 
        'Printer.SetFont("Courier New", 11, FontStyle.Bold)
        Printer.Print("Total     £" & totalCost)
        '& vbCrLf & "Payment     £" & dblPayment & vbCrLf & "------------------------------------" & vbCrLf & "Change    £" & dblChange & vbCrLf & "------------------------------------" & vbCrLf & "Total     £" & totalCost) ', arrWidth, arrFormat)
        Printer.SetFont("Courier New", 8, FontStyle.Bold)
        Printer.Print("Payment     £" & dblPayment) ', arrWidth, arrFormat)
        'Printer.SetFont("Courier New", 8, FontStyle.Regular)
        Printer.Print("----------------------")
        'Printer.SetFont("Courier New", 11, FontStyle.Bold)
        Printer.Print("Change    £" & dblChange) ', arrWidth, arrFormat)
        Printer.Print("Total     £" & totalCost)
        'rinter.Print(" ")
        'Printer.Print("Item Qty;" & dblQty, arrWidth, arrFormat)

        'Release the job for actual printing
        Printer.DoPrint()

    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        Me.Hide()
        frmBasket.Show()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        LoadData()
    End Sub
    Sub LoadData()
        'Connect to db
        'You could store the db path in the Settings of the App.
        'dbPathAndFilename = My.Settings.dbPath
        dbPathAndFilename = My.Settings.dbPath
        con.ConnectionString = dbProvider & dbSource & dbPathAndFilename & "; Jet OLEDB:Database Password=M4ttKayD3v;"

        con.Open()
        'sql = "SELECT address FROM tblAddresses WHERE PostCode=" & txtPostCode.Text & " AND HouseNo = " & txtNo.Text
        'da = New OleDb.OleDbDataAdapter(sql, con)
        ''Give it a name.
        'da.Fill(ds, "TABLE")



        'Populate the DataGridView
        'DataGridView1.DataSource = ds.Tables("TABLE")


        Dim found As Boolean
        Try

            cm = New OleDb.OleDbCommand
            With cm
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = "SELECT Address FROM tblAddresses WHERE (PostCode='" & txtPostCode.Text & "' AND HouseNo = '" & txtNo.Text & "')"
                dr = .ExecuteReader
            End With
            While dr.Read()

                txtAddress.Text = dr("Address").ToString
                If Not txtAddress.Text = "" Or IsDBNull(txtAddress.Text) Then
                    found = True
                End If

            End While
            con.Close()
            'Exit Sub
            If found = False Then
                MsgBox("Address not found. Please add it by filling in address details clicking button ADD ", MsgBoxStyle.Critical, MsgBoxResult.Ok)
                btnAdd.Visible = True
                btnEnter.Visible = False
            End If
            dr.Close()
            'con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            dbPathAndFilename = My.Settings.dbPath
            con.ConnectionString = dbProvider & dbSource & dbPathAndFilename

            con.Open()

            With cm
                .Connection = con
                .CommandType = CommandType.Text
                .CommandText = "INSERT INTO tblAddresses (Address,HouseNo,PostCode) VALUES (@Address,@HouseNo,@PostCode)"
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@Address", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtAddress.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@HouseNo", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtNo.Text))
                .Parameters.Add(New System.Data.OleDb.OleDbParameter("@PostCode", System.Data.OleDb.OleDbType.VarChar, 255, Me.txtPostCode.Text))

                cm.Parameters("@Address").Value = Me.txtAddress.Text
                cm.Parameters("@HouseNo").Value = Me.txtNo.Text
                cm.Parameters("@PostCode").Value = Me.txtPostCode.Text
                cm.ExecuteNonQuery()
                MsgBox("Address has been added", MsgBoxStyle.Information)
                btnAdd.Visible = False
                btnEnter.Visible = True
            End With
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        selectedPostCode = True
        selectedNo = False
        selectedAddress = False
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        selectedPostCode = False
        selectedNo = True
        selectedAddress = False
    End Sub

    Private Sub Button45_Click_1(sender As Object, e As EventArgs) Handles Button45.Click
        selectedPostCode = False
        selectedNo = False
        selectedAddress = True
    End Sub
End Class