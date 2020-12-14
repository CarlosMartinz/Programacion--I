Public Class FormReporteVentas
    Private Sub FormReporteVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.InfoVentas' Puede moverla o quitarla según sea necesario.
        Me.InfoVentasTableAdapter.FillInfoVentas(Me.db_HotelDataSet.InfoVentas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class