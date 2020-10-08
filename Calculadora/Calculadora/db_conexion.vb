Imports System.Data.SqlClient

Public Class db_conexion

    Dim miConexion As New SqlConnection 'Conectarse a la BD
    Dim miCommand As New SqlCommand 'Ejecutar consultas o sentencias SQL.
    Dim miAdapter As New SqlDataAdapter 'Es un intermediario entre la fuente de datos y la aplicacion... como un puente 
    Dim ds As New DataSet 'Representa una copia de la arquitectura (tablas, campos, indices, llaves, relaciones, datos, etc) de la BD en memoria

    'conecta con la base de datos
    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_Hotel.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion

        miConexion.Open()
    End Sub

    Public Function obtenerDatos()
        ds.Clear()

        miCommand.Connection = miConexion

        'traedatos de la tabla usuarios y relacionada
        miCommand.CommandText = "select Usuarios.idUsuario, Datos.Nombre, Datos.DUI, Contactos.Email, Contactos.Telefono, Login.Usuario, Login.Password
            from Usuarios 
            inner join Contactos on(Contactos.idContactos=Usuarios.idContacto) 
            inner join Datos on(Datos.idDatos=Usuarios.idDato)
            inner join Login on(Login.idLogin=Usuarios.idLogin)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Usuarios")

        Return ds
    End Function

    'metodo de parametros (conecta con los campos)
    Private Sub parametrizacion()
        miCommand.Parameters.Add("@idU", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@nom", SqlDbType.Int).Value = ""
        miCommand.Parameters.Add("@dui", SqlDbType.Int).Value = ""
        miCommand.Parameters.Add("@idD", SqlDbType.Int).Value = ""
        miCommand.Parameters.Add("@tel", SqlDbType.Int).Value = ""
        miCommand.Parameters.Add("@ema", SqlDbType.Int).Value = ""
        miCommand.Parameters.Add("@idC", SqlDbType.Int).Value = ""
    End Sub

    'CRUD
    Public Function mantenimientoDatosCliente(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Usuarios 
                       (Nombre,DUI,Telefono,Email) VALUES(@nom,@dui,@tel,@ema)"
            Case "modificar"
                sql = "UPDATE Usuarios SET nombreUsuario=@nomU, numDocuemnto=@doc, telefono=@tel, email=@ema"
            Case "eliminar"
                sql = "DELETE FROM Usuarios WHERE idUsuario=@idU"
        End Select
        miCommand.Parameters("@idU").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@nom").Value = datos(1)
            miCommand.Parameters("@dui").Value = datos(2)
            miCommand.Parameters("@tel").Value = datos(3)
            miCommand.Parameters("@ema").Value = datos(4)
            miCommand.Parameters("@idN").Value = datos(5)
        Else 'Accion es eliminar
            mantenimientoDatosContacto(datos, accion)
        End If
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Private Sub mantenimientoDatosContacto(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                miCommand.Connection = miConexion
                miCommand.CommandText = "select MAX(idNivel) AS idNivel from Usuarios"
                datos(0) = miCommand.ExecuteScalar().ToString()

                sql = "INSERT INTO NivelAcceso (idNivel) VALUES(@idN)"
            Case "modificar"
                'sql = "UPDATE NivelAcceso SET telefono=@tel,email=@ema WHERE idPersona=@id"
            Case "eliminar"
                sql = "DELETE FROM contactos WHERE idPersona=@id"
        End Select
        miCommand.Parameters("@id").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@idN").Value = datos(5)
        End If
        executeSql(sql)
    End Sub

    Private Function executeSql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function

End Class
