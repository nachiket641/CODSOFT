Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class Contact_Us
    Dim con, con1 As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim s As String
    Dim da As OleDbDataAdapter
    Dim rd As DataRow
    Dim ds As DataSet
    Dim i As Integer
    Dim st As String
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Contact_Us_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Send_message.Show()
    End Sub
End Class