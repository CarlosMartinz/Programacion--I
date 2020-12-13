Public Class FormListaReservaciones
    Private Sub FormListaReservaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'db_HotelDataSet.InfoInformacion' Puede moverla o quitarla según sea necesario.
        Me.InfoInformacionTableAdapter.FillInfoReservacion(Me.db_HotelDataSet.InfoInformacion)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class