Public Class DataRT

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            insertdataRT(ComboBox1.Text, TextBox2.Text, TextBox1.Text, DateTimePicker1.Value.Date, RadioButton1.Text)
            View_Data_RT.DataGridView1.DataSource = valueRT()
        Else
            insertdataRT(ComboBox1.Text, TextBox2.Text, TextBox1.Text, DateTimePicker1.Value.Date, RadioButton2.Text)
            View_Data_RT.DataGridView1.DataSource = valueRT()
        End If
        View_Data_RT.Show()
        Me.Hide()
    End Sub

End Class