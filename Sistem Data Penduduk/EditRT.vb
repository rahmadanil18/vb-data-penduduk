Public Class EditRT

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If RadioButton1.Checked = True Then
            UpdatedataRT(ComboBox1.Text, TextBox2.Text, TextBox1.Text, DateTimePicker1.Value.Date, RadioButton1.Text)
            View_Data_RT.DataGridView1.DataSource = valueRT()
        Else
            UpdatedataRT(ComboBox1.Text, TextBox2.Text, TextBox1.Text, DateTimePicker1.Value.Date, RadioButton2.Text)
            View_Data_RT.DataGridView1.DataSource = valueRT()
        End If
        View_Data_RT.Show()
        Me.Hide()
    End Sub


End Class