Public Class FormReportReservaciones
    Private Sub FormReportReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.InfoReservaciones' Puede moverla o quitarla según sea necesario.
        Me.InfoReservacionesTableAdapter.FillInfoReservaciones(Me.db_HotelDataSet.InfoReservaciones)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class