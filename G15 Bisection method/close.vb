Public Class close

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form1.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button2_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.MouseMove
        PictureBox1.Image = test004.My.Resources.Resources.sad
    End Sub
    Private Sub Button1_MouseMove(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.MouseMove
        PictureBox1.Image = test004.My.Resources.Resources.happy
    End Sub
End Class