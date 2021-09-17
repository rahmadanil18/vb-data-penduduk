Public Class Splash

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        RectangleShape2.Width += 10
        If RectangleShape2.Width >= 418 Then
            Timer1.Stop()
            MenuUtama.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Splash_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
