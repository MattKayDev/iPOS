Imports System.Reflection

Public Class Form1
    Dim versionNumber As Version
    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        My.Settings.delivery = True
        frmBasket.Show()
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        My.Settings.delivery = False
        frmBasket.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss")
        lblVersion.Text = versionNumber.ToString()
    End Sub
End Class
