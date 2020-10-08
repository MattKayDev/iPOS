Imports System.Reflection
Imports System.Text
Imports System.Data.OleDb

Public Class Form1


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

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles btnDelivery.Click
        gpbPostCode.Visible = True
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles btnCollection.Click
        txtPostCode.Text = ""
        txtNo.Text = ""
        txtAddress.Text = ""
        If My.Settings.delivery = True Then
            My.Settings.delivery = False
        Else
            My.Settings.delivery = False
        End If
        frmCheckout.txtAddress.Text = ""
        frmCheckout.txtNo.Text = ""
        frmCheckout.txtPostCode.Text = ""
        frmBasket.Show()
        Me.Hide()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim license As String = My.Settings.license
        If Not My.Settings.licenseEntered Then
            btnCollection.Enabled = False
            btnDelivery.Enabled = False
            txtLicense.Visible = True
            btnLicense.Visible = True
        Else
            btnCollection.Enabled = True
            btnDelivery.Enabled = True
            txtLicense.Visible = False
            btnLicense.Visible = False
        End If
        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;" ' MDB
        'dbProvider = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'ACCDB
        dbSource = "Data Source="

        Me.WindowState = FormWindowState.Maximized
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        'If frmBasket.dtPublic.Rows.Count  0 Then
        '    Button6.Visible = True
        'Else
        '    Button6.Visible = False
        'End If
        lblVersion.Text = versionNumber.ToString()
        timer1.Start()


    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        'If frmBasket.dtPublic.Rows.Count < 0 Then
        '    Button6.Visible = True
        'Else
        '    Button6.Visible = False
        'End If
    End Sub

    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to close?", "Finished? ", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'MessageBox.Show("No pressed")
        ElseIf result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frmBasket.dtPublic.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLicense.Click
        My.Settings.license = "Testing"
        If txtLicense.Text = My.Settings.license Then
            My.Settings.licenseEntered = True
            btnDelivery.Enabled = True
            btnCollection.Enabled = True
            btnLicense.Visible = False
            txtLicense.Visible = False
            Dim r As New Random
            My.Settings.license = RandomString(r)
            btnDelicense.Visible = False 'change in case of license testing
        Else
            My.Settings.licenseEntered = False
            btnDelivery.Enabled = False
            btnCollection.Enabled = False
            btnLicense.Visible = True
            txtLicense.Visible = True
        End If

        My.Computer.FileSystem.WriteAllText("C:\POS\POS.wlk", My.Settings.license, False)
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

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles btnDelicense.Click
        My.Settings.licenseEntered = False
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        LoadData()
        Dim result As DialogResult = MessageBox.Show(txtNo.Text & " " & txtAddress.Text,
                              "Confirm Address?",
                              MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            'Update Data here
            frmCheckout.txtPostCode.Text = txtPostCode.Text
            frmCheckout.basketPostCode = txtPostCode.Text
            frmCheckout.txtAddress.Text = txtAddress.Text
            If My.Settings.delivery = False Then
                My.Settings.delivery = True
            Else
                My.Settings.delivery = True
            End If
            frmBasket.Show()
            If frmBasket.dtPublic.Rows.Count = 0 Then
                frmBasket.dtPublic.Rows.Add("Delivery Charge", "£", 1)
            ElseIf frmBasket.dtPublic.Rows.Count > 0 Then
                Dim blnCheck As Boolean
                For Each row As DataGridViewRow In frmBasket.dgvBasket.Rows
                    Dim check As String = row.Cells(0).Value
                    If Not check = "Delivery Charge" Then
                        blnCheck = False
                    Else
                        blnCheck = True
                        Exit For
                    End If
                Next
                If Not blnCheck Then
                    frmBasket.dtPublic.Rows.Add("Delivery Charge", "£", 1)
                End If

            End If
            Me.Hide()
        Else
            'MessageBox.Show("Please add the address by typing it in and clicking ADD")

        End If





    End Sub

    Private Sub LoadData()
        'Connect to db
        'You could store the db path in the Settings of the App.
        'dbPathAndFilename = My.Settings.dbPath
        dbPathAndFilename = My.Settings.dbPath
        con.ConnectionString = dbProvider & dbSource & dbPathAndFilename

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
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button36_Click(sender As Object, e As EventArgs) Handles Button36.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button35_Click(sender As Object, e As EventArgs) Handles Button35.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs) Handles Button2.Click
        selectedPostCode = True
        selectedNo = False
        selectedAddress = False
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        selectedPostCode = False
        selectedNo = True
        selectedAddress = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        selectedPostCode = False
        selectedNo = False
        selectedAddress = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnAdd.Click
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

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        Dim letter As Char = sender.ToString(sender.ToString.Length - 1)
        If selectedPostCode Then
            txtPostCode.Text = txtPostCode.Text & letter
        ElseIf selectedNo Then
            txtNo.Text = txtNo.Text & letter
        ElseIf selectedAddress Then
            txtAddress.Text = txtAddress.Text & letter
        End If
    End Sub
End Class
