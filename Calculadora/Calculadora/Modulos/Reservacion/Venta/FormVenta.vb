Public Class FormVenta
    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim frm As New FormProductos
        AddOwnedForm(frm)
        frm.ShowDialog()
    End Sub
End Class