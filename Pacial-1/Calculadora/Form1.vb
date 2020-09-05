Public Class Form1
    Dim objcalculos = New universal

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles butconver.Click
        Dim cap() = txtresult.Text.Split("/")

        If txtunid.Text <> "" Or txtresult.Text <> "" Or txtcant.Text <> "" Then

            If txtcant.Text = "" And txtunid.Text <> "" And txtresult.Text <> "" Then

                objcalculos.envio_de_unidad = txtunid.Text
                txtcant.Text = objcalculos.cantidad(cap)

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
                txtunid.Text = 1

            End If

        ElseIf txtunid.Text = "" And txtresult.Text = "" And txtcant.Text = "" Then

            MessageBox.Show("Datos incompletos")

        End If
    End Sub

    Private Sub btnConvertir_Click(sender As Object, e As EventArgs) Handles btnConvertir.Click
        Dim Cant = txtCantArea.Text, Valor As Double

        Select Case cboArea1.SelectedIndex
            Case 1 'Pie Cuadrado a
                If cboArea2.SelectedIndex = 1 Then 'Pie Cuadrado
                    Valor = Cant * 1
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 2 Then 'Vara Cuadrada
                    Valor = Cant * 0.13223087609
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 3 Then 'Yarda Cuadrada
                    Valor = Cant * 0.111111
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 4 Then 'Metro Cuadrada
                    Valor = Cant * 0.092903
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 5 Then 'Tarea
                    Valor = Cant * 0.00014774656489
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 6 Then 'Manzana
                    Valor = Cant * 0.000013188960818
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 7 Then 'Hectarea
                    Valor = Cant * 0.0000092903
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If

            Case 2 'Vara Cuadrada a
                If cboArea2.SelectedIndex = 1 Then 'Pie Cuadrado
                    Valor = Cant * 7.5625302466
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 2 Then 'Vara Cuadrada
                    Valor = Cant * 1
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 3 Then 'Yarda Cuadrada
                    Valor = Cant * 0.8428113851
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 4 Then 'Metro Cuadrada
                    Valor = Cant * 0.70258205
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 5 Then 'Tarea
                    Valor = Cant * 0.0011173378658
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 6 Then 'Manzana
                    Valor = Cant * 0.00010850737842
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 7 Then 'Hectarea
                    Valor = Cant * 0.000070258205
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If

            Case 3 'Yarda Cuadrada a
                If cboArea2.SelectedIndex = 1 Then 'Pie Cuadrado
                    Valor = Cant * 9
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 2 Then 'Vara Cuadrada
                    Valor = Cant * 1.1900778849
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 3 Then 'Yarda Cuadrada
                    Valor = Cant * 1
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 4 Then 'Metro Cuadrada
                    Valor = Cant * 0.836127
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 5 Then 'Tarea
                    Valor = Cant * 0.001329719084
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 6 Then 'Manzana
                    Valor = Cant * 0.00011870064736
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 7 Then 'Hectarea
                    Valor = Cant * 0.000083612736
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If

            Case 4 'Metro Cuadrado a
                If cboArea2.SelectedIndex = 1 Then 'Pie Cuadrado
                    Valor = Cant * 10.76391
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 2 Then 'Vara Cuadrada
                    Valor = Cant * 1.4233213046
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 3 Then 'Yarda Cuadrada
                    Valor = Cant * 1.19599
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 4 Then 'Metro Cuadrada
                    Valor = Cant * 1
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 5 Then 'Tarea
                    Valor = Cant * 0.0015903307888
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 6 Then 'Manzana
                    Valor = Cant * 0.00014196479273
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 7 Then 'Hectarea
                    Valor = Cant * 0.0001
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If

            Case 5 'Tarea a
                If cboArea2.SelectedIndex = 1 Then 'Pie Cuadrado
                    Valor = Cant * 6768.34687
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 2 Then 'Vara Cuadrada
                    Valor = Cant * 894.98443634
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 3 Then 'Yarda Cuadrada
                    Valor = Cant * 752.03854111
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 4 Then 'Metro Cuadrada
                    Valor = Cant * 628.8
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 5 Then 'Tarea
                    Valor = Cant * 1
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 6 Then 'Manzana
                    Valor = Cant * 0.08926746167
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 7 Then 'Hectarea
                    Valor = Cant * 0.06288
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If

            Case 6 'Manzana a
                If cboArea2.SelectedIndex = 1 Then 'Pie Cuadrado
                    Valor = Cant * 75820.984975
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 2 Then 'Vara Cuadrada
                    Valor = Cant * 10025.87527
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 3 Then 'Yarda Cuadrada
                    Valor = Cant * 8424.5538861
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 4 Then 'Metro Cuadrada
                    Valor = Cant * 7044
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 5 Then 'Tarea
                    Valor = Cant * 11.202290076
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 6 Then 'Manzana
                    Valor = Cant * 1
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 7 Then 'Hectarea
                    Valor = Cant * 0.7044
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
            Case 7 'Hectarea a
                If cboArea2.SelectedIndex = 1 Then 'Pie Cuadrado
                    Valor = Cant * 107639.1
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 2 Then 'Vara Cuadrada
                    Valor = Cant * 14233.213046
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 3 Then 'Yarda Cuadrada
                    Valor = Cant * 11959.9
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 4 Then 'Metro Cuadrada
                    Valor = Cant * 10000
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 5 Then 'Tarea
                    Valor = Cant * 15.903307888
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 6 Then 'Manzana
                    Valor = Cant * 1.4196479273
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
                If cboArea2.SelectedIndex = 7 Then 'Hectarea
                    Valor = Cant * 1
                    lblRespuesta.Text = Math.Round(Valor, 2)
                End If
        End Select
    End Sub
End Class


