Public Class View_Data_Warga

    Private Sub UpdateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        DataWargavb.Show()
        Me.Hide()
    End Sub

    Private Sub Form6_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Data()

    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        EditWarga.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        EditWarga.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        EditWarga.DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(2).Value.ToString
        EditWarga.ComboBox1.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        If DataGridView1.CurrentRow.Cells(3).Value.ToString = "L" Then
            EditWarga.RadioButton1.Checked = True
        Else
            EditWarga.RadioButton2.Checked = True
        End If
        EditWarga.Show()
        Me.Hide()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub KembaliToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KembaliToolStripMenuItem.Click
        Dim ex As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Dim dr As DialogResult = MsgBox("Apakah Anda Yakin Ingin Menghapus Data Ini?", MsgBoxStyle.YesNo)
        If dr = DialogResult.Yes Then
            If deletedata(ex) = True Then
                MsgBox("Delete Data Sukses", MsgBoxStyle.Information)
                DataGridView1.DataSource = Data()
            End If
        End If
    End Sub
End Class