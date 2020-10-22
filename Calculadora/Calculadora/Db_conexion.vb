﻿Imports System.Data 'Importar las bibliotecas y clases necesarias para trabajar con ado.net
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
        miCommand.Parameters.Add("@nombre", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@dui", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@telefono", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@email", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@acceso", SqlDbType.VarChar).Value = ""
        miCommand.Parameters.Add("@usuario", SqlDbType.NChar).Value = ""
        miCommand.Parameters.Add("@contra", SqlDbType.NChar).Value = ""

        'Tabla de tipo de habitaciones
        miCommand.Parameters.Add("@codEdi", SqlDbType.NChar).Value = ""
        miCommand.Parameters.Add("@edificio", SqlDbType.NChar).Value = ""

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

        miCommand.CommandText = "select * from Usuarios"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Usuarios")


        miCommand.CommandText = "select * from TipoHabitacion"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "TipoHabitacion")

        miCommand.CommandText = "select Acceso from NivelAcceso"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "NivelAcceso")

        miCommand.CommandText = "SELECT * FROM Clientes"
        miAdapter.SelectCommand = miCommand
        miAdapter.Fill(ds, "Clientes")

        Return ds
    End Function
    'CRUD
    Public Function mantenimientoDatosUsuarios(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Usuarios (Nombre,DUI,Telefono,Email,Acceso,Usuario,Password) VALUES (@nombre,@dui,@telefono,@email,@acceso,@usuario,@contra)"
            Case "actualizar"
                sql = "UPDATE Usuarios SET Nombre=@nombre,DUI=@dui,Telefono=@telefono,Email=@email,Acceso=@acceso,Usuario=@usuario,Password=@contra WHERE idUsuario=@idU"
            Case "eliminar"
                sql = "DELETE FROM Usuarios WHERE idUsuario=@idU"
        End Select
        miCommand.Parameters("@idU").Value = datos(0)
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@nombre").Value = datos(1)
            miCommand.Parameters("@dui").Value = datos(2)
            miCommand.Parameters("@telefono").Value = datos(3)
            miCommand.Parameters("@email").Value = datos(4)
            miCommand.Parameters("@acceso").Value = datos(5)
            miCommand.Parameters("@usuario").Value = datos(6)
            miCommand.Parameters("@contra").Value = datos(7)
        Else 'Accion es eliminar
            ' mantenimientoDatosContacto(datos, accion)
        End If
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
    Public Function mantenimientoDatosEdificio(ByVal datos As String(), ByVal accion As String)
        Dim sql, msg As String
        Select Case accion
            Case "nuevo"
                sql = "INSERT INTO Usuarios (codigo,edificio) VALUES (@codEdi,@edificio,@telefono)"
            Case "actualizar"
                sql = "UPDATE Usuarios SET Nombre=@nombre,DUI=@dui,Telefono=@telefono,Email=@email,Acceso=@acceso,Usuario=@usuario,Password=@contra WHERE idUsuario=@idU"
            Case "eliminar"
                sql = "DELETE FROM Usuarios WHERE idUsuario=@idU"
        End Select
        If accion IsNot "eliminar" Then
            miCommand.Parameters("@codEdi").Value = datos(0)
            miCommand.Parameters("@edificio").Value = datos(1)
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
                sql = "UPDATE Clientes SET Nombre=@NombreCliente,DUI=@DuiCliente,Telefono=@TelefonoCliente,Email=@EmailCliente WHERE idUsuario=@idCliente"
            Case "eliminar"
                sql = "DELETE FROM Cliente WHERE idUsuario=@idCliente"
        End Select
        'miCommand.Parameters("@idCliente").Value = datos(0)
        'If accion IsNot "eliminar" Then
        '    miCommand.Parameters("@NombreCliente").Value = datos(1)
        '    miCommand.Parameters("@DuiCliente").Value = datos(2)
        '    miCommand.Parameters("@TelefonoCliente").Value = datos(3)
        '    miCommand.Parameters("@EmailCliente").Value = datos(4)
        'Else 'Accion es eliminar
        '    ' mantenimientoDatosContacto(datos, accion)
        'End If
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

    'CRUD
    'Public Function mantenimientoDatosUsuarios(ByVal datos As String(), ByVal accion As String)
    '    Dim sql, msg As String
    '    Select Case accion
    '        Case "nuevo"
    '            sql = "INSERT INTO Usuarios (Nombre,DUI,Telefono,Email,Acceso,Usuario,Password) 
    '                                  VALUES(@nombre,@dui,@telefono,@email,@acceso,@usuario,@contra)"
    '        Case "actualizar"
    '            sql = "UPDATE Usuarios SET Nombre=@nombre,DUI=@dui,Telefono=@telefono,Email=@email,Acceso=@acceso,Usuario=@usuario,Password=@contra WHERE idUsuario=@idU"
    '        Case "eliminar"
    '            sql = "DELETE FROM Usuarios WHERE idUsuario=@idU"
    '    End Select
    '    miCommand.Parameters("@idU").Value = datos(0)
    '    If accion IsNot "eliminar" Then
    '        miCommand.Parameters("@nombre").Value = datos(1)
    '        miCommand.Parameters("@dui").Value = datos(2)
    '        miCommand.Parameters("@telefono").Value = datos(3)
    '        miCommand.Parameters("@email").Value = datos(4)
    '        miCommand.Parameters("@acceso").Value = datos(5)
    '        miCommand.Parameters("@usuario").Value = datos(6)
    '        miCommand.Parameters("@contra").Value = datos(7)
    '    End If
    '    If (executeSql(sql) > 0) Then
    '        msg = "exito"
    '    Else
    '        msg = "error"
    '    End If

    '    Return msg
    'End Function
    Private Function executeSql(ByVal sql As String)
        miCommand.Connection = miConexion
        miCommand.CommandText = sql
        Return miCommand.ExecuteNonQuery()
    End Function
End Class
