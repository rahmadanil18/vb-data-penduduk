Public Class View_Data_RT

    Private Sub EditToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EditToolStripMenuItem.Click
        MenuUtama.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        DataRT.Show()
        Me.Hide()
    End Sub

    Private Sub View_Data_RT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = valueRT()
    End Sub

    Private Sub KembaliToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KembaliToolStripMenuItem.Click
        Dim ex As String = DataGridView1.CurrentRow.Cells(0).Value.ToString
        Dim dr As DialogResult = MsgBox("Apakah Anda Yakin Ingin Menghapus Data Ini?", MsgBoxStyle.YesNo)
        If dr = DialogResult.Yes Then
            If deletedataRT(ex) = True Then
                MsgBox("Delete Data Sukses", MsgBoxStyle.Information)
                DataGridView1.DataSource = valueRT()
            End If
        End If
    End Sub

    Private Sub HapusToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles HapusToolStripMenuItem.Click
        EditRT.ComboBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        EditRT.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        EditRT.TextBox1.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        EditRT.DateTimePicker1.Value = DataGridView1.CurrentRow.Cells(3).Value.ToString
        If DataGridView1.CurrentRow.Cells(4).Value.ToString = "L" Then
            EditRT.RadioButton1.Checked = True
        Else
            EditRT.RadioButton2.Checked = True
        End If
        EditRT.Show()
        Me.Hide()
    End Sub
End Class