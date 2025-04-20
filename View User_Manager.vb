Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class View_Uers_Manager
    Dim con, con1 As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim s As String
    Dim da As OleDbDataAdapter
    Dim rd As DataRow
    Dim ds As DataSet
    Dim i As Integer
    Dim st As String
    Private Sub View_Uers_Manager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Animal Adoption\db.mdb"
        s = "select * from ContactUs_Message"
        da = New OleDbDataAdapter(s, con)
        ds = New DataSet
        da.Fill(ds)

        i = 0
        DataGridView1.DataSource = ds.Tables(0)
    End Sub
End Class