Public Class Request

    Private Sub View_Request_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox12.Text = Questionnaire.ComboBox1.Text
        TextBox13.Text = Questionnaire.ComboBox2.Text
        TextBox4.Text = Questionnaire.ComboBox3.Text
        TextBox5.Text = Questionnaire.ComboBox4.Text
        TextBox6.Text = Questionnaire.ComboBox5.Text
        TextBox7.Text = Questionnaire.ComboBox6.Text
        TextBox8.Text = Questionnaire.ComboBox7.Text
        TextBox9.Text = Questionnaire.ComboBox8.Text
        TextBox10.Text = Questionnaire.TextBox2.Text
        TextBox11.Text = Questionnaire.TextBox3.Text
    End Sub
End Class