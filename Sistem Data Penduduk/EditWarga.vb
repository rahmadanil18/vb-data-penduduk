Public Class EditWarga

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If RadioButton1.Checked = True Then
            Updatedata(TextBox1.Text, TextBox2.Text, DateTimePicker1.Value.Date, RadioButton1.Text, ComboBox1.Text)
            View_Data_Warga.DataGridView1.DataSource = Data()
        Else
            Updatedata(TextBox1.Text, TextBox2.Text, DateTimePicker1.Value.Date, RadioButton2.Text, ComboBox1.Text)
            View_Data_Warga.DataGridView1.DataSource = Data()
        End If
        View_Data_Warga.Show()
        Me.Hide()
    End Sub

    Private Sub Form7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class