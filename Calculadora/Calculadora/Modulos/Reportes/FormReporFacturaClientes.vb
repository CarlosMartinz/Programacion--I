Public Class FormReporFacturaClientes
    Private Sub FormReporFacturaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.InfoFacturas' Puede moverla o quitarla según sea necesario.
        Me.InfoFacturasTableAdapter.FillFacturas(Me.db_HotelDataSet.InfoFacturas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class