Public Class MenuUtama

    Private Sub DataToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataToolStripMenuItem.Click

    End Sub

    Private Sub DataWargaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataWargaToolStripMenuItem.Click
        View_Data_Warga.Show()
        Me.Hide()
    End Sub

    Private Sub DataRtToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DataRtToolStripMenuItem.Click
        View_Data_RT.Show()
        Me.Hide()
    End Sub

    Private Sub AgendaKegiatanToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AgendaKegiatanToolStripMenuItem.Click
        DataAgenda.Show()
        Me.Hide()
    End Sub

    Private Sub TentangToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TentangToolStripMenuItem.Click
        Tentang.Show()
        Me.Hide()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim Pesan As Integer
        Pesan = MsgBox("Apakah mau keluar?", MsgBoxStyle.OkCancel)
        If Pesan = 1 Then
            End
        End If
    End Sub

    Private Sub MenuUtama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class