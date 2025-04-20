Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class Login
    Dim con, con1 As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim s As String
    Dim da As OleDbDataAdapter
    Dim rd As DataRow
    Dim ds As DataSet
    Dim i As Integer
    Dim st As String
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Hide()
        Signup.Show()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection
        con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Animal Adoption\db.mdb"
        con.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error Resume Next
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Fill all Fields", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        'Dim st As String
        'st = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        'Dim re2 As New Regex(st)
        'If Not re2.IsMatch(TextBox1.Text) Then
        'MsgBox("Invalid email", MsgBoxStyle.Exclamation, "error")
        'TextBox1.Text = String.Empty
        'TextBox1.Focus()
        ' Exit Sub
        'End If
        s = "insert into Admin values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
        ' s = "insert into Animal1 values('" & TextBox1.Text & "')"
        cmd = New OleDbCommand(s, con)
        cmd.ExecuteNonQuery()
        MsgBox("Login Successful")
        TextBox1.Clear()
        TextBox2.Clear()

        Me.Hide()
        Questionnaire.Show()

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            If Not ((Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122) Or (Asc(e.KeyChar) >= 65 And Asc(e.KeyChar) <= 90)) Then
                MsgBox("Enter character only", MsgBoxStyle.Exclamation, "error")
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
