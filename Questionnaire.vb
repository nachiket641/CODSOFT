Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class Questionnaire
    Dim con, con1 As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim s As String
    Dim da As OleDbDataAdapter
    Dim rd As DataRow
    Dim ds As DataSet
    Dim i As Integer
    Dim st As String
    Private Sub Questionnaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Animal Adoption\db.mdb"
        con.Open()

        ''Request.TextBox12.Text = ComboBox1.Text
        'Request.TextBox13.Text = ComboBox2.Text
        'Request.TextBox4.Text = ComboBox3.Text
        'Request.TextBox5.Text = ComboBox4.Text
        'Request.TextBox6.Text = ComboBox5.Text
        'Request.TextBox7.Text = ComboBox6.Text
        'Request.TextBox8.Text = ComboBox7.Text
        'Request.TextBox9.Text = ComboBox8.Text
        'Request.TextBox10.Text = TextBox2.Text
        'Request.TextBox11.Text = TextBox3.Text
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                MsgBox("Enter character only", MsgBoxStyle.Exclamation, "error")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        'If Not (Asc(e.KeyChar) = 8) Then
        '    If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
        '        MsgBox("Enter character only", MsgBoxStyle.Exclamation, "error")
        '        e.Handled = True
        '    End If
        'End If
    End Sub

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class