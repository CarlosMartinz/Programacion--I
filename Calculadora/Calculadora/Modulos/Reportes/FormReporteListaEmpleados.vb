﻿Public Class FormReporteListaEmpleados
    Private Sub FormReporteListaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.InfoEmpleadoUsuarios' Puede moverla o quitarla según sea necesario.
        Me.InfoEmpleadoUsuariosTableAdapter.FillInfoEmpleados(Me.db_HotelDataSet.InfoEmpleadoUsuarios)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class