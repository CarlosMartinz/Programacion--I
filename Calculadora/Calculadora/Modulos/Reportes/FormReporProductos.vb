Public Class FormReporProductos
    Private Sub FormReporProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.InfoProductos' Puede moverla o quitarla según sea necesario.
        Me.InfoProductosTableAdapter.FillProductos(Me.db_HotelDataSet.InfoProductos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class