Public Class FormReporteListadoHabitacioens
    Private Sub FormReporteListadoHabitacioens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.HabitacionesInfo' Puede moverla o quitarla según sea necesario.
        Me.HabitacionesInfoTableAdapter.FillHabitaciones(Me.db_HotelDataSet.HabitacionesInfo)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class