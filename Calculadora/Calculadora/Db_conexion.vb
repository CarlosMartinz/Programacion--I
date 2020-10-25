Imports System.Data 'Importar las bibliotecas y clases necesarias para trabajar con ado.net
Imports System.Data.SqlClient 'Biblioteca de clases para SQl server y ado.net
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

    'metodo de parametros (conecta con los campos)
    Private Sub parametrizacion()
        'Tabla Usuarios
        miCommand.Parameters.Add("@idU", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@acceso", SqlDbType.VarChar).Value = ""

        'Tabla datos
        miCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@edad", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@documento", SqlDbType.NChar).Value = ""
        miCommand.Parameters.Add("@telefono", SqlDbType.NChar).Value = ""
        miCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = ""

        'Tabla de tipo de login
        miCommand.Parameters.Add("@idL", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@usuario", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@pass", SqlDbType.VarChar).Value = ""

        'Tabla Cliente
        miCommand.Parameters.Add("@idCliente", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@NombreCliente", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@DuiCliente", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@TelefonoCliente", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@EmailCliente", SqlDbType.VarChar).Value = ""
    End Sub
    'traedatos de la tabla usuarios y relacionada
    Public Function obtenerDatosUsuarios()
        ds.Clear()

        miCommand.Connection = miConexion

        'combobox's
        miCommand.CommandText = "select idTipo from TipoHabit"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "TipoHabit")

        miCommand.CommandText = "select Edificio from Edificio"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Edificio")

        miCommand.CommandText = "select Acceso from NivelAcceso"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "NivelAcceso")

        'mostrar datos de tablas relacionadas
        miCommand.CommandText = "
            select Usuarios.idUsuario, Usuarios.Acceso, Datos.Nombre, Datos.Documento, Datos.Telefono, Datos.Email, Usuarios.Usuario, Usuarios.Password
            from Usuarios
                inner join Datos on(Datos.idPersona=Usuarios.idUsuario)
        "
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Usuarios")

        miCommand.CommandText = "
            select Habitaciones.idHabitaciones, Edificio.Edificio, TipoHabit.idTipo,
            from Habitaciones
                inner join TipoHabit on(Habitaciones.idHabitaciones=TipoHabit.idTipo)
                inner join Edificio on (Habitaciones.Edificio=Edificio.Edificio)
        "
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Habitaciones")

        'Para CRUD
        miCommand.CommandText = "select * from Habitaciones"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Habitaciones")


        miCommand.CommandText = "SELECT * FROM Clientes"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Clientes")

        Return ds
    End Function
    'CRUD usuario extension de la relacion con Datos
    Public Function mantenimientoDatosUsuarios(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Usuarios (Acceso,Usuario,Password) VALUES (@acceso,@usuario,@pass)"
            Case "actualizar"
                sql = "UPDATE Usuarios SET Acceso=@acceso,Usuario=@usuario,Password=@pass WHERE idUsuario=@idU"
            Case "eliminar"
                sql = "DELETE FROM Usuarios WHERE idUsuario=@idU"
        End Select
        miCommand.Parameters("@idU").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@acceso").Value = datos(1)
            miCommand.Parameters("@nombre").Value = datos(2)
            miCommand.Parameters("@documento").Value = datos(3)
            miCommand.Parameters("@telefono").Value = datos(4)
            miCommand.Parameters("@email").Value = datos(5)
            miCommand.Parameters("@usuario").Value = datos(6)
            miCommand.Parameters("@pass").Value = datos(7)
        Else 'Accion es eliminar
            mantenimientoDatos(datos, accion)
        End If
        If (executeSql(sql) > 0) Then
            If accion IsNot "eliminar" Then
                mantenimientoDatos(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"
        End If
        Return msg
    End Function
    'CRUD datos relacion con usuarios y clientes
    Public Function mantenimientoDatos(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                miCommand.Connection = miConexion
                miCommand.CommandText = "select MAX(idUsuario) AS idUsuario from Usuarios"
                datos(0) = miCommand.ExecuteScalar().ToString()

                sql = "INSERT INTO Datos (idPersona,Nombre,Documento,Telefono,Email) VALUES(@idU,@nombre,@documento,@telefono,@email)"
            Case "modificar"
                sql = "UPDATE Datos SET Nombre=@nombre,Documento=@documento,Telefono=@telefono,Email=@email WHERE idPersona=@idU"
            Case "eliminar"
                sql = "DELETE FROM Datos WHERE idPersona=@idU"
        End Select
        miCommand.Parameters("@idU").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@nombre").Value = datos(2)
            miCommand.Parameters("@documento").Value = datos(3)
            miCommand.Parameters("@telefono").Value = datos(4)
            miCommand.Parameters("@email").Value = datos(5)
        End If
        executeSql(sql)
    End Function
    'CRUD edificio relacionada con habitaciones
    Public Function mantenimientoDatosEdificio(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Usuarios (Edificio) VALUES (@edificio)"
            Case "actualizar"
                sql = "UPDATE Usuarios SET Edificio WHERE Edificio=@edificio"
            Case "eliminar"
                sql = "DELETE FROM Usuarios WHERE idUsuario=@idU"
        End Select
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@edificio").Value = datos(0)
        End If
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDatosTipoHabitacion(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO TipoHabitacion (tipo,capacidad,precio) VALUES ('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "')"
            Case "actualizar"
                sql = "UPDATE TipoHabitacion SET tipo='" + datos(1) + "',capacidad='" + datos(2) + "',precio='" + datos(3) + "' WHERE idTipoHabitacion='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM TipoHabitacion WHERE idTipoHabitacion=" + datos(0)
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosCliente(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Clientes (Nombre,DUI,Telefono,Email) VALUES ('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "')"
            Case "actualizar"
                sql = "UPDATE Clientes SET Nombre='" + datos(1) + "',DUI='" + datos(2) + "',Telefono='" + datos(3) + "',Email='" + datos(4) + "' WHERE idCliente='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM Clientes WHERE idCliente='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            If accion IsNot "eliminar" Then
                ' mantenimientoDatosContacto(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"
        End If
        Return msg
    End Function
    Private Function executeSql(ByVal sql As String)
        Try
            miCommand.Connection = miConexion
            miCommand.CommandText = sql
            Return miCommand.ExecuteNonQuery()
        Catch ex As Exception
            Return 0
        End Try
    End Function
End Class
