Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelresgis.Visible = False
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        panelresgis.Visible = True
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub ActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActualizarToolStripMenuItem.Click
        panelresgis.Visible = False
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        panelresgis.Visible = False
    End Sub

    Private Sub panelresgis_Paint(sender As Object, e As PaintEventArgs) Handles panelresgis.Paint

    End Sub
End Class


