Public Class DataWargavb

    Private Sub ListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub DataWargavb_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            insertdata(TextBox1.Text, TextBox2.Text, DateTimePicker1.Value.Date, RadioButton1.Text, ComboBox1.Text)
            View_Data_Warga.DataGridView1.DataSource = Data()
        Else
            insertdata(TextBox1.Text, TextBox2.Text, DateTimePicker1.Value.Date, RadioButton2.Text, ComboBox1.Text)
            View_Data_Warga.DataGridView1.DataSource = Data()
        End If
        View_Data_Warga.Show()
        Me.Hide()
    End Sub
End Class