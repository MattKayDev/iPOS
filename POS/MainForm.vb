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

    Private Sub btnDelivery_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        Create_Order_In_Basket()

    End Sub

    Private Sub btnCollection_Click(sender As Object, e As EventArgs) Handles btnCollection.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        lblVersion.Text = versionNumber.ToString()
        timer1.Start()
        lblIPOS.Text = "iPOS - " & Get_CompanyName_From_Database()
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles btnClose.Click
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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmBasket.dtPublic.Clear()
    End Sub


    Private Sub Read_License()
        Dim fileReader As String
        fileReader = My.Computer.FileSystem.ReadAllText("C:\POS\data\lic\POS.wlk")
        My.Settings.license = fileReader
    End Sub

    Function RandomString(r As Random)
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        Dim sb As New StringBuilder
        Dim cnt As Integer = r.Next(15, 33)
        For i As Integer = 1 To cnt
            Dim idx As Integer = r.Next(0, s.Length)
            sb.Append(s.Substring(idx, 1))
        Next
        Return sb.ToString()
    End Function





    'Private Sub Button22_Click(sender As Object, e As EventArgs)


    '    Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
    '    If selectedPostCode Then
    '        txtPostCode.Text = txtPostCode.Text & letter
    '    ElseIf selectedNo Then
    '        txtNo.Text = txtNo.Text & letter
    '    ElseIf selectedAddress Then
    '        txtAddress.Text = txtAddress.Text & letter
    '    End If
    'End Sub


    Private Sub Button2_Click_2(sender As Object, e As EventArgs)
        selectedPostCode = True
        selectedNo = False
        selectedAddress = False
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        selectedPostCode = False
        selectedNo = True
        selectedAddress = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)
        selectedPostCode = False
        selectedNo = False
        selectedAddress = True
    End Sub

End Class
