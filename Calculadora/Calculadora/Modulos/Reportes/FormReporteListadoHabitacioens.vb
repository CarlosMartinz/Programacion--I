Public Class FormReporteListadoHabitacioens
    Private Sub FormReporteListadoHabitacioens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.InfoHabitaciones' Puede moverla o quitarla según sea necesario.
        Me.InfoHabitacionesTableAdapter.FillInfoHabitaciones(Me.db_HotelDataSet.InfoHabitaciones)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class