Public Class DataAgenda

    Private Sub UpdateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        Agenda.Show()
        Me.Hide()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub DataAgenda_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = valueAgenda()
    End Sub

    Private Sub KembaliToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KembaliToolStripMenuItem.Click
        Dim ex As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Dim dr As DialogResult = MsgBox("Apakah Anda Yakin Ingin Menghapus Data Ini?", MsgBoxStyle.YesNo)
        If dr = DialogResult.Yes Then
            If deleteAgenda(ex) = True Then
                MsgBox("Delete Data Sukses", MsgBoxStyle.Information)
                DataGridView1.DataSource = valueAgenda()
            End If
        End If
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        editAgenda.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        editAgenda.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        editAgenda.DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(2).Value.ToString
        editAgenda.TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        editAgenda.Show()
        Me.Hide()
    End Sub
End Class