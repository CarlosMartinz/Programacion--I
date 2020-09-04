Class universal

    Dim unidad, result, resultado As Integer

    Public Property enviounidad
        Set(valor)
            unidad = valor
        End Set
        Get
            Return unidad
        End Get
    End Property
    Public Function rcantidad(cap() As String)
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
