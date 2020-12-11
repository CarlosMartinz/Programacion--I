Public Class FormListaClientes
    Private Sub FormListaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.clientesInfo' Puede moverla o quitarla según sea necesario.
        Me.clientesInfoTableAdapter.FillClientesInfo(Me.db_HotelDataSet.clientesInfo)
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.clientes' Puede moverla o quitarla según sea necesario.
        Me.clientesTableAdapter.Fillclientes(Me.db_HotelDataSet.clientes)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class