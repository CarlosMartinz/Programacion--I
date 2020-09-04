Public Class Form1
    Dim objcalculos = New universal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butconver.Click
        Dim cap() = txtresult.Text.Split("/")

        If txtunid.Text <> "" Or txtresult.Text <> "" Or txtcant.Text <> "" Then
            If txtcant.Text = "" And txtunid.Text <> "" And txtresult.Text <> "" Then
                objcalculos.enviounidad = txtunid.Text
                txtcant.Text = objcalculos.rcantidad(cap)
            ElseIf txtunid.Text = "" And txtresult.Text = "" Then
                txtresult.Text = (txtcant.Text).ToString + "/" + (0).ToString
            ElseIf txtunid.Text = "" And txtcant.Text <> "" And txtresult.Text <> "" Then
                txtresult.Text = (txtcant.Text \ txtunid.Text).ToString + "/" + (txtcant.Text Mod txtunid.Text).ToString
            ElseIf txtresult.Text <> "" And txtcant.Text = "" And txtunid.Text = "" Then
                Dim cont As Integer
                For Each sum In cap
                    cont = cont + sum
                Next
                txtcant.Text = cont
            End If
        ElseIf txtunid.Text = "" And txtresult.Text = "" And txtcant.Text = "" Then
            MessageBox.Show("Datos incompletos")
        End If
    End Sub
End Class


