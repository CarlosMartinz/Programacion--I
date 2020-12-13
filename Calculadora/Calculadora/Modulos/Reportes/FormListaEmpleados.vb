Public Class FormListaEmpleados
    Private Sub FormListaEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.usuarios' Puede moverla o quitarla según sea necesario.
        Me.usuariosTableAdapter.Fill(Me.db_HotelDataSet.usuarios)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class