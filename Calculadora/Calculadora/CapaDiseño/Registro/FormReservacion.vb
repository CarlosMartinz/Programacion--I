Public Class FormReservacion
    Private Sub frmReservacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnAgregar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\nuevo.png")
        btnActualizar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\actualizar.png")
        btnBorrar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\eliminar.png")
        btnBuscar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\buscar.png")

        btnPrimero.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\primero.png")
        btnAnterior.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\anterior.png")
        btnSiguiente.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\siguiente.png")
        btnUltimo.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\ultimo.png")
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "." Then
            btnAgregar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\aceptar.png")
            btnActualizar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\cancelar.png")
            btnAgregar.Text = ","
            btnBuscar.Enabled = False
            btnBorrar.Enabled = False
        Else
            btnAgregar.Text = "."
            btnAgregar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\nuevo.png")
            btnActualizar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\actualizar.png")
            btnBuscar.Enabled = True
            btnBorrar.Enabled = True
        End If
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If btnActualizar.Text = "." Then
            btnAgregar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\aceptar.png")
            btnActualizar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\cancelar.png")
            btnActualizar.Text = ","
            btnBuscar.Enabled = False
            btnBorrar.Enabled = False
        Else
            btnActualizar.Text = "."
            btnAgregar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\nuevo.png")
            btnActualizar.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\recursos\imagenes\actualizar.png")
            btnBuscar.Enabled = True
            btnBorrar.Enabled = True
        End If
    End Sub
End Class