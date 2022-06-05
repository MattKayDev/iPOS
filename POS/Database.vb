Imports System.Data.OleDb
Public Class Database

    Public Shared con As New OleDbConnection
    Public Shared cmd As New OleDbCommand
    'Dim dbProvider As String = "PROVIDER=Microsoft.Jet.OLEDB.4.0;" ' MDB
    Dim dbProvider As String = "PROVIDER=Microsoft.Ace.OLEDB.12.0;" 'ACCDB
    Dim dbSource As String = "Data Source="
    Dim dbFileName As String = "iPOS.ACCDB;"
    Dim strConnection As String



    Public Shared Sub Create_Database_Connection()
        Dim db As New Database()
        Dim strCon As String = db.dbProvider & db.dbSource & db.dbFileName

        con.ConnectionString = strCon

        If con.State = ConnectionState.Closed Then
            con.Open()
        Else
            con.Close() 'closing the old connection
            con.Open() ' opening a new connection
        End If
    End Sub

    Public Shared Function Get_CompanyName_From_Database() As String
        Dim db As New Database()
        Dim strCon = db.dbProvider & db.dbSource & db.dbFileName
        Using con As New OleDbConnection(strCon)
            con.Open()
            Dim sql As String = "SELECT CompanyName FROM tblSetup"
            cmd.CommandText = sql
            cmd.Connection = con
            If Not IsNothing(cmd.ExecuteScalar()) Then
                If Not IsDBNull(cmd.ExecuteScalar()) Then
                    Return cmd.ExecuteScalar()
                End If
            End If
            Return ""
        End Using
    End Function

    Public Shared Sub Create_Order_In_Basket(orderDate As String, orderTime As String, orderType As String, product As String, price As String, qty As String)
        Dim db As New Database()
        Dim strCon As String = db.dbProvider & db.dbSource & db.dbFileName
        Using con As New OleDbConnection(strCon)
            con.Open()
            Dim sql As String = "DELETE * FROM tblBasket"
            cmd.CommandText = sql
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            sql = "INSERT INTO tblBasket VALUES ('" & orderType & "','" & orderDate & "','" & orderTime & "','" & product & "','" & price & "','" & qty & "')"
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()
        End Using
    End Sub


End Class
