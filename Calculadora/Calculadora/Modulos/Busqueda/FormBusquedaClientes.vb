Public Class FormBusquedaClientes
    Dim objConexion As New db_conexion
    Public _idC As Integer
    Private Sub btnSelecionarCliente_Click(sender As Object, e As EventArgs) Handles btnSelecionarCliente.Click
        SeleccionCliente()
    End Sub
    Private Sub FormBusquedaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarCliente.DataSource = objConexion.insercionDatos().Tables("clientes").DefaultView
    End Sub
    Private Sub txtBuscarCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarCliente.KeyUp
        FiltrarDatosCliente(txtBuscarCliente.Text)
        If e.KeyCode = 13 Then
            SeleccionCliente()
        End If
    End Sub
    Private Sub SeleccionCliente()
        _idC = grdBuscarCliente.CurrentRow.Cells("idCliente").Value.ToString()
        Close()
    End Sub
    Private Sub FiltrarDatosCliente(ByVal Valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarCliente.DataSource
        bs.Filter = "nombre like '%" & Valor & "%' or edad like '%" & Valor &
            "%' or documento like '%" & Valor &
            "%' or telefono like '%" & Valor & "%' or email like'%" & Valor & "%'"
        grdBuscarCliente.DataSource = bs
    End Sub
    Private Sub btnCancelarCliente_Click(sender As Object, e As EventArgs) Handles btnCancelarCliente.Click
        _idC = 0
        Close()
    End Sub

End Class