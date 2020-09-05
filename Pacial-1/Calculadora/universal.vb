Class universal

    Dim unidad, result, resultado As Integer

    Public Property envio_de_unidad
        Set(valor1)
            unidad = valor1
        End Set
        Get
            Return unidad
        End Get
    End Property
    Public Function cantidad(cap() As String)
        Dim i As SByte
        i = 1
        For Each e In cap
            If i = 1 Then
                result = e

            End If
            If i = 2 Then
                resultado = e
            End If
            i = i + 1
        Next
        Return ((unidad * result) + resultado)
    End Function

End Class
