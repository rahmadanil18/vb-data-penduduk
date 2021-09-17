Public Class editAgenda

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        UpdateAgenda(TextBox1.Text, TextBox2.Text, DateTimePicker1.Value.Date, TextBox3.Text)
        DataAgenda.DataGridView1.DataSource = valueAgenda()
        DataAgenda.Show()
        Me.Hide()
    End Sub
End Class