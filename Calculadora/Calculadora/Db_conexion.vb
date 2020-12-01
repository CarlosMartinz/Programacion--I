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

        'Tabla Habitaciones
        miCommand.Parameters.Add("@idHabitaciones", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@Cod", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@Estado", SqlDbType.VarChar).Value = ""

        'Tabla Producto
        miCommand.Parameters.Add("@idProducto", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@idCateg", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@Categ", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@Codig", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@Descrip", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@Cantidad", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@Costo", SqlDbType.VarChar).Value = ""

        'Tabla Reservaciones
        miCommand.Parameters.Add("@idRes", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@idUsu", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@idCli", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@idHab", SqlDbType.Int).Value = 0
        miCommand.Parameters.Add("@entrada", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@salida", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@estadia", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@precioDia", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@total", SqlDbType.VarChar).Value = ""
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
            select clientes.idCliente, clientes.Nombre, clientes.edad, clientes.documento, contactos.telefono, contactos.email
            from clientes 
                inner join contactos on(contactos.idPersona=clientes.idCliente)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "clientes")

        miCommand.CommandText = "
            select Habitacion.idHabitacion, Habitacion.Estado, Habitacion.TipoHabit, TipoHabit.Capacidad, TipoHabit.Precio
            from Habitacion
                inner join Estado on(Habitacion.Estado=Estado.Estado)
                inner join TipoHabit on(Habitacion.TipoHabit=TipoHabit.idTipo)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Habitacion")

        miCommand.CommandText = "SELECT Reservaciones.idReservaiones, Reservaciones.idCliente, Reservaciones.idUsuario, Reservaciones.idHabitaciones, Reservaciones.Entrada, Reservaciones.Salida, Reservaciones.Estadia, Reservaciones.PrecioDia, Reservaciones.Total
            FROM Reservaciones
               inner join clientes on(Reservaciones.idCliente=clientes.idCliente)
               inner join usuarios on(Reservaciones.idUsuario=usuarios.idUsuario)
               inner join Habitacion on(Reservaciones.idHabitaciones=Habitacion.idHabitacion)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Reservaciones")

        miCommand.CommandText = "SELECT * FROM TipoHabit"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "TipoHabit")

        miCommand.CommandText = "SELECT * FROM Estado"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Estado")

        miCommand.CommandText = "SELECT * FROM Categoria"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Categoria")

        miCommand.CommandText = "select Producto.idProducto, Producto.idCategoria, Producto.Codigo, Producto.Descripcion, Producto.Precio 
                                    from Producto
                                        inner join Categoria on(Producto.idCategoria=Categoria.idCategoria)"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Producto")

        Return ds
    End Function
    Public Function mantenimientoDatosReservaciones(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Reservaciones (idCliente,idUsuario,idHabitaciones,Entrada,Salida,Estadia,PrecioDia,Total) 
                        VALUES (@idCli,@idUsu,@idHab,@entrada,@salida,@estadia,@precioDia,@total)"

                'Case "actualizar"
                '    sql = "UPDATE Reservaciones SET Entrada=,Salida=, Estadia=, PrecioDia=, Total= WHERE idReservaiones="
                'Case "eliminar"
                '    sql = "DELETE FROM Reservaciones WHERE idReservaiones="
        End Select
        miCommand.Parameters("@idRes").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@idCli").Value = datos(1)
            miCommand.Parameters("@idUsu").Value = datos(2)
            miCommand.Parameters("@idHab").Value = datos(3)
            miCommand.Parameters("@entrada").Value = datos(4)
            miCommand.Parameters("@salida").Value = datos(5)
            miCommand.Parameters("@estadia").Value = datos(6)
            miCommand.Parameters("@precioDia").Value = datos(7)
            miCommand.Parameters("@total").Value = datos(8)
        End If
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
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
                sql = "INSERT INTO clientes (Nombre,edad,documento) VALUES (,@nomb,@edad,@docu)"
            Case "modificar"
                sql = "UPDATE clientes SET nombre=@nomb,edad=@edad,documento=@docu WHERE idCliente=@idC"
            Case "eliminar"
                sql = "DELETE FROM clientes WHERE idUsuario=@idC"
        End Select
        miCommand.Parameters("@idC").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@nomb").Value = datos(1)
            miCommand.Parameters("@edad").Value = datos(2)
            miCommand.Parameters("@docu").Value = datos(3)
            miCommand.Parameters("@tele").Value = datos(4)
            miCommand.Parameters("@emai").Value = datos(5)
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
                sql = "INSERT INTO Habitacion (Estado,TipoHabit) VALUES(@Estado,@idTipo)"
            Case "actualizar"
                sql = "UPDATE Habitacion SET Estado=@Estado, TipoHabit=@idTipo WHERE idHabitacion=@idHabitaciones"
            Case "eliminar"
                sql = "DELETE FROM Habitacion WHERE idHabitacion=@idHabitaciones"
        End Select
        miCommand.Parameters("@idHabitaciones").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@Estado").Value = datos(1)
            miCommand.Parameters("@idTipo").Value = datos(2)
        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosProductos(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Producto (idCategoria,Codigo,Descripcion,Precio) VALUES(@idCateg,@Codig,@Descrip,@Costo)"
            Case "actualizar"
                sql = "UPDATE Producto SET idCategoria=@idCateg, Codigo=@Codig, Descripcion=@Descrip, Precio=@Costo WHERE idProducto=@idProducto"
            Case "eliminar"
                sql = "DELETE FROM Producto WHERE idProducto=@idProducto"
        End Select
        miCommand.Parameters("@idProducto").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@idCateg").Value = datos(1)
            miCommand.Parameters("@Codig").Value = datos(2)
            miCommand.Parameters("@Descrip").Value = datos(3)
            miCommand.Parameters("@Costo").Value = datos(4)
        End If
        If executeSql(sql) > 0 Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function

    Public Function mantenimientoDatosCategorias(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Categoria (Categoria) VALUES(@Categ)"
            Case "actualizar"
                sql = "UPDATE Categoria SET Categoria=@Categ WHERE idCategoria=@idCateg"
            Case "eliminar"
                sql = "DELETE FROM Categoria WHERE idCategoria=@idCateg"
        End Select
        miCommand.Parameters("@idCateg").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@Categ").Value = datos(1)
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
