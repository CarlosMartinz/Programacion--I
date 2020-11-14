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
        miCommand.Parameters.Add("@nom", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@doc", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@tel", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@ema", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@acc", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@usu", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@pas", SqlDbType.VarChar).Value = ""

        'Tabla Clientes
        miCommand.Parameters.Add("@idC", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@code", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@nomb", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@edad", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@docu", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@tele", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@emai", SqlDbType.VarChar).Value = ""

        'Tabla TipoHabit
        miCommand.Parameters.Add("@Tag", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@idTipo", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@Capacidad", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@Precio", SqlDbType.VarChar).Value = ""

        'Tabla Edificio
        miCommand.Parameters.Add("@idEdi", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@Edi", SqlDbType.VarChar).Value = ""

        'Tabla Habitaciones
        miCommand.Parameters.Add("@idHabitaciones", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@Cod", SqlDbType.VarChar).Value = ""
    End Sub
    Public Function FiltroHabitacionLibre()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "
            select Habitacion.idHabitacion, Habitacion.Estado, Habitacion.TipoHabit, TipoHabit.Capacidad, TipoHabit.Precio
            from Habitacion
                inner join TipoHabit on(Habitacion.TipoHabit=TipoHabit.idTipo)
                where Estado = 'Libre'"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Habitacion")

        Return ds
    End Function
    Public Function FiltroNombreCliente()
        ds.Clear()

        miCommand.Connection = miConexion

        miCommand.CommandText = "
            select clientes.idCliente, clientes.Nombre, clientes.edad, clientes.documento, contactos.telefono, contactos.email
            from clientes 
                inner join contactos on(contactos.idPersona=clientes.idCliente)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "clientes")

        Return ds
    End Function
    'traedatos de la tabla usuarios y relacionada
    Public Function obtenerDatosTablas()
        ds.Clear()

        miCommand.Connection = miConexion

        'rellenar combobox
        miCommand.CommandText = "SELECT acceso FROM NivelAcceso"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "NivelAcceso")

        'CRUD con relacion
        miCommand.CommandText = "
            select usuarios.idUsuario, usuarios.nombre, usuarios.documento, usuarios.telefono, usuarios.email, usuarios.acceso, login.usuario, login.password
            from usuarios 
                inner join login on(login.idPersona=usuarios.idUsuario)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "usuarios")

        miCommand.CommandText = "
            select clientes.idCliente, clientes.Codigo, clientes.Nombre, clientes.edad, clientes.documento, contactos.telefono, contactos.email
            from clientes 
                inner join contactos on(contactos.idPersona=clientes.idCliente)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "clientes")

        miCommand.CommandText = "
            select Habitacion.idHabitacion, Habitacion.Codigo, Habitacion.Estado, Habitacion.TipoHabit, TipoHabit.Capacidad, TipoHabit.Precio
            from Habitacion
                inner join TipoHabit on(Habitacion.TipoHabit=TipoHabit.idTipo)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Habitacion")

        miCommand.CommandText = "SELECT * FROM TipoHabit"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "TipoHabit")

        miCommand.CommandText = "SELECT * FROM Edificio"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Edificio")

        Return ds
    End Function
    'CRUD usuario 
    Public Function mantenimientoDatosUsuarios(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO usuarios (nombre,documento,telefono,email,acceso) VALUES (@nom,@doc,@tel,@ema,@acc)"
            Case "modificar"
                sql = "UPDATE usuarios SET nombre=@nom,documento=@doc,telefono=@tel,email=@ema,acceso=@acc WHERE idUsuario=@idU"
            Case "eliminar"
                sql = "DELETE FROM usuarios WHERE idUsuario=@idU"
        End Select
        miCommand.Parameters("@idU").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@nom").Value = datos(1)
            miCommand.Parameters("@doc").Value = datos(2)
            miCommand.Parameters("@tel").Value = datos(3)
            miCommand.Parameters("@ema").Value = datos(4)
            miCommand.Parameters("@acc").Value = datos(5)
            miCommand.Parameters("@usu").Value = datos(6)
            miCommand.Parameters("@pas").Value = datos(7)
        Else 'Accion es eliminar
            mantenimientoDatosLogin(datos, accion)
        End If
        If (executeSql(sql) > 0) Then
            If accion IsNot "eliminar" Then
                mantenimientoDatosLogin(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"
        End If
        Return msg
    End Function
    Private Sub mantenimientoDatosLogin(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                miCommand.Connection = miConexion
                miCommand.CommandText = "select MAX(idUsuario) AS idUsuario from usuarios"
                datos(0) = miCommand.ExecuteScalar().ToString()

                sql = "INSERT INTO login (idPersona,usuario,password) VALUES(@idU,@usu,@pas)"
            Case "modificar"
                sql = "UPDATE login SET usuario=@usu,password=@pas WHERE idPersona=@idU"
            Case "eliminar"
                sql = "DELETE FROM login WHERE idPersona=@idU"
        End Select
        miCommand.Parameters("@idU").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@tel").Value = datos(4)
            miCommand.Parameters("@ema").Value = datos(5)
        End If
        executeSql(sql)
    End Sub
    'CRUD Clientes 
    Public Function mantenimientoDatosClientes(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO clientes (Codigo,Nombre,edad,documento) VALUES (@code,@nomb,@edad,@docu)"
            Case "modificar"
                sql = "UPDATE clientes SET codigo=@code,nombre=@nomb,edad=@edad,documento=@docu WHERE idCliente=@idC"
            Case "eliminar"
                sql = "DELETE FROM clientes WHERE idUsuario=@idC"
        End Select
        miCommand.Parameters("@idC").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@code").Value = datos(1)
            miCommand.Parameters("@nomb").Value = datos(2)
            miCommand.Parameters("@edad").Value = datos(3)
            miCommand.Parameters("@docu").Value = datos(4)
            miCommand.Parameters("@tele").Value = datos(5)
            miCommand.Parameters("@emai").Value = datos(6)
        Else 'Accion es eliminar
            mantenimientoDatosContacto(datos, accion)
        End If
        If (executeSql(sql) > 0) Then
            If accion IsNot "eliminar" Then
                mantenimientoDatosContacto(datos, accion)
            End If
            msg = "exito"
        Else
            msg = "error"
        End If
        Return msg
    End Function
    'CRUD Contactos relacion con  Clientes
    Public Function mantenimientoDatosContacto(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                miCommand.Connection = miConexion
                miCommand.CommandText = "select MAX(idCliente) AS idCliente from Clientes"
                datos(0) = miCommand.ExecuteScalar().ToString()

                sql = "INSERT INTO contactos (idPersona,telefono,email) VALUES(@idC,@tele,@emai)"
            Case "modificar"
                sql = "UPDATE contactos SET telefono=@tele,email=@emai WHERE idPersona=@idC"
            Case "eliminar"
                sql = "DELETE FROM contactos WHERE idPersona=@idC"
        End Select
        miCommand.Parameters("@idC").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@tele").Value = datos(5)
            miCommand.Parameters("@emai").Value = datos(6)
        End If
        executeSql(sql)
    End Function

    Public Function mantenimientoDatosEdificio(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Edificio (Edificio) VALUES(@Edi)"
            Case "actualizar"
                sql = "UPDATE Edificio SET Edificio=@Edi WHERE Edificio=@idEdi"
            Case "eliminar"
                sql = "DELETE FROM Edificio WHERE Edificio=@idEdi"
        End Select
        miCommand.Parameters("@idEdi").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@Edi").Value = datos(1)
        End If
        executeSql(sql)
    End Function

    Public Function mantenimientoDatosTipoHabitacion(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO TipoHabit (idTipo,Capacidad,Precio) VALUES (@idTipo,@Capacidad,@Precio)"
            Case "actualizar"
                sql = "UPDATE TipoHabit SET idTipo=@idTipo,Capacidad=@Capacidad,Precio=@Precio WHERE idTipo=@Tag"
            Case "eliminar"
                sql = "DELETE FROM TipoHabit WHERE idTipo=@Tag"
        End Select
        miCommand.Parameters("@Tag").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@idTipo").Value = datos(1)
            miCommand.Parameters("@Capacidad").Value = datos(2)
            miCommand.Parameters("@Precio").Value = datos(3)
        End If
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function mantenimientoDatosHabitaciones(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Habitaciones (Codigo,Edificio,TipoHabit) VALUES(@Cod,@Edi,@idTipo)"
            Case "actualizar"
                sql = "UPDATE Habitaciones SET Codigo=@Cod,Edificio=@Edi,TipoHabit=@idTipo WHERE idHabitaciones=@idHabitaciones"
            Case "eliminar"
                sql = "DELETE FROM Habitaciones WHERE idHabitaciones=@idHabitaciones"
        End Select
        miCommand.Parameters("@idHabitaciones").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@Cod").Value = datos(1)
            miCommand.Parameters("@Edi").Value = datos(2)
            miCommand.Parameters("@idTipo").Value = datos(3)
        End If
        If executeSql(sql) > 0 Then
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
