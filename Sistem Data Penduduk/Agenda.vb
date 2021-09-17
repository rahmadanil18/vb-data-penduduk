Public Class Agenda

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        insertdataAgenda(TextBox1.Text, TextBox2.Text, DateTimePicker1.Value.Date, TextBox3.Text)
        DataAgenda.DataGridView1.DataSource = valueAgenda()
        DataAgenda.Show()
        Me.Hide()
    End Sub
End Class