Public Class FormPago
    Dim objConexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub FormPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerDatos()
    End Sub

    Sub obtenerDatos()
        dataTable = objConexion.insercionDatos().Tables("usuarios")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idUsuario")}

        cboFactu.DataSource = objConexion.obtenerDatos().Tables("TipoFactu").DefaultView()
        cboFactu.DisplayMember = "TipoFactura"
        cboFactu.ValueMember = "TipoFactu.TipoFactura"

        'mostrarDatos()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        grbdVentasProductos.Visible = True
    End Sub

    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim objBuscarProductos As New FormBuscarProducto
        objBuscarProductos.ShowDialog()
        If objBuscarProductos._idP > 0 Then
            'DventasProductosBindingSource.AddNew()
            'DventasProductosDataGridView.CurrentRow.Cells("idProducto").Value = objBuscarProductos._idP
            'DventasProductosDataGridView.CurrentRow.Cells("codigo").Value = objBuscarProductos._codigoProducto
            'DventasProductosDataGridView.CurrentRow.Cells("descripcion").Value = objBuscarProductos._nombreProducto
            'DventasProductosDataGridView.CurrentRow.Cells("marca").Value = ""
            'DventasProductosDataGridView.CurrentRow.Cells("medidas").Value = ""

            'DventasProductosDataGridView.CurrentRow.Cells("cantidad").Value = 1
            'DventasProductosDataGridView.CurrentRow.Cells("precio").Value = 0
        End If
    End Sub
    Private Sub totalizar()
        Try
            Dim fila As DataGridViewRow
            Dim nfilas As Integer = dataProductos.Rows.Count - 1
            Dim subtotal, sumas, iva, total As Double

            For i As Integer = 0 To nfilas
                fila = dataProductos.Rows(i)
                subtotal = Double.Parse(fila.Cells("cantidad").Value.ToString()) * Double.Parse(fila.Cells("precio").Value.ToString())

                fila.Cells("subtotal").Value = subtotal.ToString()
                sumas += subtotal
            Next
            iva = If(IdTipofacturaComboBox.SelectedValue = 4, sumas * 0.13, 0)
            total = sumas + iva

            lblRespuestaSuma.Text = "$ " + Math.Round(sumas, 2).ToString()
            lblRespuestaIva.Text = "$ " + Math.Round(iva, 2).ToString()
            lblRespuestaTotal.Text = "$ " + Math.Round(total, 2).ToString()

            'lblnregistros.Text = (VentasBindingSource.Position + 1) & " de " & VentasBindingSource.Count
        Catch ex As Exception
            'MessageBox.Show("Error " + ex.Message)
        End Try
    End Sub

    Private Sub btnQuitarProducto_Click(sender As Object, e As EventArgs) Handles btnQuitarProducto.Click
        Try
            dataProductos.Rows.Remove(dataProductos.CurrentRow)
            totalizar()
        Catch ex As Exception
            MessageBox.Show("Error al intentar quitar la fila: " + ex.Message)
        End Try
    End Sub
End Class