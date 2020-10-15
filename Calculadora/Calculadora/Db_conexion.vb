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
        parametrizacion()
    End Sub
    'traedatos de la tabla usuarios y relacionada
    Public Function obtenerDatosUsuarios()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "select Usuarios.idUsuario, Usuarios.Nombre, Usuarios.DUI, Contactos.Email, 
                                 Contactos.Telefono, Usuarios.Usuario, Usuarios.Password, NivelAcceso.Acceso    
            from Usuarios 
            inner join Contactos on(Contactos.idUsuario=Usuarios.idUsuario)
            inner join NivelAcceso on(Usuarios.Acceso=NivelAcceso.Acceso)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Usuarios")

        miCommand.CommandText = "select Acceso from NivelAcceso"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "NivelAcceso")

        Return ds
    End Function
    'metodo de parametros (conecta con los campos)
    Private Sub parametrizacion()
        'Tabla Usuarios
        miCommand.Parameters.Add("@idU", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@dui", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@acceso", SqlDbType.VarChar).Value = ""

        'Tabla Contactos
        miCommand.Parameters.Add("@telefono", SqlDbType.VarChar).Value = 0
        miCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = ""

        'Tabla Login
        miCommand.Parameters.Add("@usuario", SqlDbType.NChar).Value = ""
        miCommand.Parameters.Add("@contra", SqlDbType.NChar).Value = ""
    End Sub

    'CRUD
    Public Function mantenimientoDatosUsuarios(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Usuarios (Nombre,DUI,Telefono,Email,Acceso,Usuario,Password) VALUES(@nombre,@dui,@acceso)"
            Case "modificar"
                sql = "UPDATE Usuarios SET Nombre=@nombre, DUI=@dui, Acceso=@acceso"
            Case "eliminar"
                sql = "DELETE FROM Usuarios WHERE idUsuario=@idU"
        End Select
        miCommand.Parameters("@idU").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@nombre").Value = datos(1)
            miCommand.Parameters("@dui").Value = datos(2)
            miCommand.Parameters("@acceso").Value = datos(3)
            miCommand.Parameters("@telefono").Value = datos(4)
            miCommand.Parameters("@email").Value = datos(5)
            miCommand.Parameters("@usuario").Value = datos(6)
            miCommand.Parameters("@contra").Value = datos(7)
        Else 'Accion es eliminar
            'mantenimientoDatosContactos(datos, accion)
        End If
        If (executeSql(sql) > 0) Then
            'If accion IsNot "eliminar" Then
            '    'mantenimientoDatosContactos(datos, accion)
            'End If
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Private Function executeSql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function
End Class
