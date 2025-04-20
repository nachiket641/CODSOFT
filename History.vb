Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class History
    Dim con, con1 As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim s As String
    Dim da As OleDbDataAdapter
    Dim rd As DataRow
    Dim ds As DataSet
    Dim i As Integer
    Dim st As String
    Private Sub History_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet3.History' table. You can move, or remove it, as needed.
        Me.HistoryTableAdapter.Fill(Me.DbDataSet3.History)
        con = New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Animal Adoption\db.mdb"
        s = "select * from History"
        da = New OleDbDataAdapter(s, con)
        ds = New DataSet
        da.Fill(ds)
        i = 0
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class