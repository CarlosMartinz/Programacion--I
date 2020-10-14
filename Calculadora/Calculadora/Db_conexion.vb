Imports System.Data.SqlClient
Public Class db_conexion
    Dim miConexion As New SqlConnection 'Conectarse a la BD
    Dim miCommand As New SqlCommand 'Ejecutar consultas o sentencias SQL.
    Dim miAdapter As New SqlDataAdapter 'Es un intermediario entre la fuente de datos y la aplicacion... como un puente 
    Dim ds As New DataSet 'Representa una copia de la arquitectura (tablas, campos, indices, llaves, relaciones, datos, etc) de la BD en memoria
    'conecta con la base de datos
    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion =
            "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_Hotel.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion

        miConexion.Open()
        parametrizacion()
    End Sub
    'metodo de parametros (conecta con los campos)
    Private Sub parametrizacion()
        'Tabla Usuarios
        miCommand.Parameters.Add("@idU", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@nombre", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@dui", SqlDbType.Int).Value = ""
        miCommand.Parameters.Add("@acceso", SqlDbType.Char).Value = ""

        'Tabla Contactos
        miCommand.Parameters.Add("@telefono", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@email", SqlDbType.Char).Value = ""

        'Tabla Login
        miCommand.Parameters.Add("@usuario", SqlDbType.Char).Value = ""
        miCommand.Parameters.Add("@contra", SqlDbType.Char).Value = ""
    End Sub
    'traedatos de la tabla usuarios y relacionada
    Public Function obtenerDatosUsuarios()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "select Usuarios.idUsuario, Usuarios.Nombre, Usuarios.DUI, Contactos.Email, 
                                 Contactos.Telefono, Login.Usuario, Login.Password, NivelAcceso.Acceso    
            from Usuarios 
            inner join Contactos on(Contactos.idUsuario=Usuarios.idUsuario)
            inner join Login on(Login.idUsuario=Usuarios.idUsuario)
            inner join NivelAcceso on(Usuarios.Acceso=NivelAcceso.Acceso)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Usuarios")

        miCommand.CommandText = "select Acceso from NivelAcceso"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "NivelAcceso")

        miCommand.CommandText = "select Nacionalidad from Nacionalidad"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Nacionalidad")

        Return ds
    End Function
End Class
