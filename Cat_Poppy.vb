﻿Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Public Class Cat_Poppy
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

    Private Sub Cat_Poppy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Certificate.Label1.Text = Signup.TextBox1.Text
        Certificate.Label2.Text = Label1.Text
        Certificate.Label3.Text = Now
        Certificate.Label4.Text = "15/22 Bang-Na Bangkok"
        Me.Hide()
        Certificate.Show()

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        PictureBox1.Image = PictureBox2.Image
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        PictureBox1.Image = PictureBox4.Image
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        PictureBox1.Image = PictureBox3.Image
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        PictureBox1.Image = PictureBox5.Image
    End Sub
End Class