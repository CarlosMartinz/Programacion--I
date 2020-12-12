Public Class FormListaClienntes
    Private Sub FormListaClienntes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.InfoCliente' Puede moverla o quitarla según sea necesario.
        Me.InfoClienteTableAdapter.Fill(Me.db_HotelDataSet.InfoCliente)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class