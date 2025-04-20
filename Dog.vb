Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class Dog
    Dim con, con1 As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim s As String
    Dim da As OleDbDataAdapter
    Dim rd As DataRow
    Dim ds As DataSet
    Dim i As Integer
    Dim st As String
    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Dog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.Cat' table. You can move, or remove it, as needed.
        Me.DogTableAdapter.Fill(Me.DbDataSet2.Dog)
        'con = New OleDbConnection
        'con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Animal Adoption\db.mdb"
        's = "select * from Dog"
        'da = New OleDbDataAdapter(s, con)
        'ds = New DataSet
        'da.Fill(ds)

        'i = 0
        'DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'On Error Resume Next
        If ComboBox1.Text = "ANY" Or ComboBox2.Text = "ANY" Or ComboBox3.Text = "ANY" Or ComboBox4.Text = "ANY" Or ComboBox5.Text = "ANY" Then
            MsgBox("Fill all Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        's = "select * from Animal where type='Dog' and (Breed='" & ComboBox1.Text & "' or Age='" & ComboBox3.Text & "'or Colour='" & ComboBox4.Text & "' or size='" & ComboBox5.Text & "') "
        'da = New OleDbDataAdapter(s, con)
        'ds = New DataSet
        'da.Fill(ds, "Animal")
        'DataGridView1.DataSource = ds.Tables(0)

        'Me.Hide()
        'View_Animal_Dogs.Show()

        ''cmd = con.CreateCommand()
        ''cmd.CommandType = CommandType.Text
        ''cmd.CommandText = "select * from Dog"
        ''cmd.ExecuteNonQuery()
        ''Dim dt As New DataTable()
        ''da.Fill(dt)
        ''DataGridView1.DataSource = dt

        Me.Hide()
        View_Animal_Dogs.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Me.DogBindingSource.Filter = "Breed like '%" & ComboBox1.Text & "%'"
    End Sub
End Class