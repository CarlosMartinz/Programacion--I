Public Class FormPrincipal
    Private Sub RegistroDeUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeUsuariosToolStripMenuItem.Click
        abrirFrmEnPanel2(New FormUsuarios)
    End Sub
    Private Sub abrirFrmEnPanel2(frmHijo As Object)
        'If (pnlAtraeFrom.Controls.Count > 0) Then
        '    pnlAtraeFrom.Controls.RemoveAt(0)
        'Else
        Dim frm As FormUsuarios
            frm = frmHijo
            frm.TopLevel = False
            frm.Dock = DockStyle.None
            pnlAtraeFrom.Controls.Add(frm)
            pnlAtraeFrom.Tag = frm
            frm.Show()
        'End If

    End Sub
    Private Sub RegistrosDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistrosDeClientesToolStripMenuItem.Click
        abrirFrmEnPanel3(New FormClientes)
    End Sub
    Private Sub abrirFrmEnPanel3(frmHijo As Object)
        Dim frm As FormClientes
        frm = frmHijo
        frm.TopLevel = False
        frm.Dock = DockStyle.None
        pnlAtraeFrom.Controls.Add(frm)
        pnlAtraeFrom.Tag = frm
        frm.Show()
    End Sub

    Private Sub RegistroDeHabitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeHabitacionesToolStripMenuItem.Click
        abrirFrmEnPanel4(New FormHabitaciones)
    End Sub

    Private Sub abrirFrmEnPanel4(frmHijo As Object)
        'If (pnlAtraeFrom.Controls.Count > 0) Then
        '    pnlAtraeFrom.Controls.RemoveAt(0)
        'Else
        Dim frm As FormHabitaciones
            frm = frmHijo
            frm.TopLevel = False
            frm.Dock = DockStyle.None
            pnlAtraeFrom.Controls.Add(frm)
            pnlAtraeFrom.Tag = frm
            frm.Show()
        'End If

    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        abrirFrmEnPanel(New FormReservaciones)
    End Sub

    Private Sub abrirFrmEnPanel(frmHijo As Object)
        'If (pnlAtraeFrom.Controls.Count > 0) Then
        '    pnlAtraeFrom.Controls.RemoveAt(0)
        'Else
        Dim frm As FormReservaciones
            frm = frmHijo
            frm.TopLevel = False
            frm.Dock = DockStyle.Fill
            pnlAtraeFrom.Controls.Add(frm)
            pnlAtraeFrom.Tag = frm
            frm.Show()
        'End If

    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs)
        Dim objReservacion As New FormClientes
        objReservacion.MdiParent = Me
        objReservacion.Show()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class