Imports System.Data.SqlClient

Public Class db_conexion

    Dim miConexion As New SqlConnection 'Conectarse a la BD
    Dim miCommand As New SqlCommand 'Ejecutar consultas o sentencias SQL.
    Dim miAdapter As New SqlDataAdapter 'Es un intermediario entre la fuente de datos y la aplicacion... como un puente 
    Dim ds As New DataSet 'Representa una copia de la arquitectura (tablas, campos, indices, llaves, relaciones, datos, etc) de la BD en memoria
    Dim sql As String

    'conecta con la base de datos
    Public Sub New()
        Dim cadenaConexion As String
        cadenaConexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_Hotel.mdf;Integrated Security=True"
        miConexion.ConnectionString = cadenaConexion

        miConexion.Open()
    End Sub
    'traedatos de la tabla usuarios y relacionada
    Public Function obtenerDatosUsuarios()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "select Usuarios.Nombre, Usuarios.DUI, Contactos.Email, 
                                 Contactos.Telefono, Login.Usuario, Login.Password, NivelAcceso.Acceso    
            from Usuarios 
            inner join Contactos on(Contactos.idContactos=Usuarios.idContacto)
            inner join Login on(Login.idLogin=Usuarios.idLogin)
            inner join NivelAcceso on(Usuarios.Acceso=NivelAcceso.idNivel)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Usuarios")

        Return ds
    End Function
    'traedatos de la tabla usuarios y relacionada
    Public Function obtenerDatosNacionalidad()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "select Clientes.Nombre, Clientes.DUI, Contactos.Telefono, Contactos.Email            
            from Clientes 
            inner join Nacionalidad on(Nacionalidad.idContactos=Clientes.idContacto)"
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
    Public Function mantenimientoDatosLogin(ByVal Datos As String(), ByVal Accion As String)
        Dim sql, msg As String
        Select Case Accion
            Case "Nuveo"
                miCommand.Connection = miConexion
                miCommand.CommandText = "SELECT MAX(idUsuario) AS idUsuario FROM Usuarios"
                Datos(0) = miCommand.ExecuteScalar().ToString()
                sql = "INSERT INTO Login(idLogin, usuario, Password) VALUES(@id, @Usuario, @Contra)"
            Case "Actualizar"
                sql = "UPDATE Login SET usuario=@Usuario, Password=@Contra WHERE idLogin=@id"
            Case "Eliminar"
                sql = "Delete FROM Login WHERE idLogin=@id"
        End Select

        miCommand.Parameters("@id").Value = Datos(0)
        If Accion IsNot "Eliminar" Then
            miCommand.Parameters("@Usuario").Value = Datos(5)
            miCommand.Parameters("@Contra").Value = Datos(6)
        End If
        executeSql(sql)
    End Function
    Public Function mantenimientoDatosUsuario(ByVal Datos As String(), ByVal Accion As String)
        Dim sql, msg As String
        Select Case Accion
            Case "Nuveo"
                sql = "INSERT INTO Usuarios (Nombre, DUI, Acceso) VALUES(@Nombre, @Dui, @Acces)"
            Case "Actualizar"
                sql = "UPDATE Usuarios SET Nombre=@Nombre, DUI=@Dui, Acceso=@Acces WHERE idUsuario=@id"
            Case "Eliminar"
                sql = "Delete FROM Usuarios WHERE idUsuarios=@id"
        End Select

        miCommand.Parameters("@id").Value = Datos(0)
        If Accion IsNot "Eliminar" Then
            miCommand.Parameters("@Nombre").Value = Datos(1)
            miCommand.Parameters("@Dui").Value = Datos(2)
            miCommand.Parameters("@Tel").Value = Datos(3)
            miCommand.Parameters("@Email").Value = Datos(4)
            miCommand.Parameters("@Usuario").Value = Datos(5)
            miCommand.Parameters("@Contra").Value = Datos(6)
            miCommand.Parameters("@Acces").Value = Datos(7)
        Else
            mantenimientoDatosContacto(Datos, Accion)
            mantenimientoDatosLogin(Datos, Accion)
        End If

        If (executeSql(sql) > 0) Then
            If Accion IsNot "Eliminar" Then
                mantenimientoDatosUsuario(Datos, Accion)
                mantenimientoDatosLogin(Datos, Accion)
            End If
            msg = "Exito"
        Else
            msg = "Error"
        End If
    End Function
    Private Sub mantenimientoDatosContacto(ByVal Datos As String(), ByVal Accion As String)
        Dim sql, msg As String
        Select Case Accion
            Case "Nuveo"
                miCommand.Connection = miConexion
                miCommand.CommandText = "SELECT MAX(idUsuario) AS idUsuario FROM Usuarios"
                Datos(0) = miCommand.ExecuteScalar().ToString()
                sql = "INSERT INTO Contactos(idContactos, email, telefono) VALUES(@id, @Email, @Tel)"
            Case "Actualizar"
                sql = "UPDATE Contactos SET email=@Email, telefono=@Tel WHERE idContactos=@id"
            Case "Eliminar"
                sql = "Delete FROM Login WHERE idLogin=@id"
        End Select

        miCommand.Parameters("@id").Value = Datos(0)
        If Accion IsNot "Eliminar" Then
            miCommand.Parameters("@Tel").Value = Datos(3)
            miCommand.Parameters("@Email").Value = Datos(4)
        End If
        executeSql(sql)
    End Sub

    Private Function executeSql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function

End Class
