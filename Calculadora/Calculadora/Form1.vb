Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonCalcular.Click
        Dim num1, num2 As Double 'Declaro las variables en linea separadas por comas del mismo tipo

        num1 = txtnum1.Text 'capturando el dato que ingres el usuario a la caja de texto, asigno dicho valor a la variable num1.
        num2 = txtnum2.Text

        If optSuma.Checked Then 'If -> si de condicion
            lblRespuesta.Text = num1 + num2 'suma
            lblOperacion.Text = "+"
        End If

        If optResta.Checked Then
            lblRespuesta.Text = num1 - num2 'resta
            lblOperacion.Text = "-"
        End If

        If optMultiplicaion.Checked Then
            lblRespuesta.Text = num1 * num2 'multiplicacion
            lblOperacion.Text = "*"
        End If

        If optDividir.Checked Then
            lblRespuesta.Text = num1 / num2 'division
            lblOperacion.Text = "/"
        End If

        If optExponenciacion.Checked Then
            lblRespuesta.Text = num1 ^ num2 'Exponenciacion
            lblOperacion.Text = "^"
        End If

        If optResiduo.Checked Then
            lblRespuesta.Text = num1 Mod num2 'Residuo
            lblOperacion.Text = "mod"
        End If

        If optPorcentaje.Checked Then
            lblRespuesta.Text = (num1 * num2) / 100 'Porcentaje
            lblOperacion.Text = "Porcentaje"
        End If
        '...
        Select Case opt.SelectedIndex
            Case 1 'Suma
                lblRespuesta.Text = num1 + num2
                lblOperacion.Text = "+"

            Case 2 'Resta
                lblRespuesta.Text = num1 - num2
                lblOperacion.Text = "-"

            Case 3 'Multiplicacion
                lblRespuesta.Text = num1 * num2
                lblOperacion.Text = "*"

            Case 4 'Division
                lblRespuesta.Text = num1 / num2
                lblOperacion.Text = "/"

            Case 5 'Exponenciacion
                lblRespuesta.Text = num1 ^ num2
                lblOperacion.Text = "^"

            Case 6 'Residuo
                lblRespuesta.Text = num1 Mod num2
                lblOperacion.Text = "Mod"

            Case 7 'Porcentaje
                lblRespuesta.Text = (num1 * num2) / 100
                lblOperacion.Text = "Porcentaje"
        End Select
    End Sub
End Class
