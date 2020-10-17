<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormHabitaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Habitaciones = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtcodigohabitacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRegistroHabitaciones = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Tipo = New System.Windows.Forms.TabPage()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcapacidad = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosCategoria = New System.Windows.Forms.Label()
        Me.btnUltimoCategoria = New System.Windows.Forms.Button()
        Me.btnSiguienteCategoria = New System.Windows.Forms.Button()
        Me.btnAnteriorCategoria = New System.Windows.Forms.Button()
        Me.btnPrimeroCategoria = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarTipHabitacion = New System.Windows.Forms.Button()
        Me.btnEliminarTipHabitacion = New System.Windows.Forms.Button()
        Me.btnModificarTipHabitacion = New System.Windows.Forms.Button()
        Me.btnAgregarTipHabitacion = New System.Windows.Forms.Button()
        Me.piso = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtcodedificio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtedificio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.btnAgregarEdificios = New System.Windows.Forms.Button()
        Me.nivel = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtnivel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button20 = New System.Windows.Forms.Button()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button21 = New System.Windows.Forms.Button()
        Me.Button22 = New System.Windows.Forms.Button()
        Me.Button23 = New System.Windows.Forms.Button()
        Me.Button24 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Habitaciones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Tipo.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.piso.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.nivel.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Habitaciones)
        Me.TabControl1.Controls.Add(Me.Tipo)
        Me.TabControl1.Controls.Add(Me.piso)
        Me.TabControl1.Controls.Add(Me.nivel)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(573, 298)
        Me.TabControl1.TabIndex = 32
        '
        'Habitaciones
        '
        Me.Habitaciones.BackColor = System.Drawing.Color.Transparent
        Me.Habitaciones.Controls.Add(Me.GroupBox1)
        Me.Habitaciones.Controls.Add(Me.GroupBox2)
        Me.Habitaciones.Controls.Add(Me.GroupBox3)
        Me.Habitaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Habitaciones.Location = New System.Drawing.Point(4, 22)
        Me.Habitaciones.Name = "Habitaciones"
        Me.Habitaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.Habitaciones.Size = New System.Drawing.Size(565, 272)
        Me.Habitaciones.TabIndex = 0
        Me.Habitaciones.Text = "Nueva habitacion"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtcodigohabitacion)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 135)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Habitacion nueva"
        '
        'txtcodigohabitacion
        '
        Me.txtcodigohabitacion.Location = New System.Drawing.Point(89, 62)
        Me.txtcodigohabitacion.Name = "txtcodigohabitacion"
        Me.txtcodigohabitacion.Size = New System.Drawing.Size(410, 20)
        Me.txtcodigohabitacion.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codigo"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(-26, 412)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 18
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRegistroHabitaciones)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 146)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox2.Size = New System.Drawing.Size(237, 68)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Navegacion"
        '
        'lblRegistroHabitaciones
        '
        Me.lblRegistroHabitaciones.AutoSize = True
        Me.lblRegistroHabitaciones.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistroHabitaciones.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistroHabitaciones.Name = "lblRegistroHabitaciones"
        Me.lblRegistroHabitaciones.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroHabitaciones.TabIndex = 4
        Me.lblRegistroHabitaciones.Text = "x de n"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(173, 19)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 39)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = ">|"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(134, 19)
        Me.Button2.Margin = New System.Windows.Forms.Padding(1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(41, 39)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = ">"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(42, 19)
        Me.Button3.Margin = New System.Windows.Forms.Padding(1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(41, 39)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(2, 19)
        Me.Button4.Margin = New System.Windows.Forms.Padding(1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(41, 39)
        Me.Button4.TabIndex = 0
        Me.Button4.Text = "|<"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button8)
        Me.GroupBox3.Location = New System.Drawing.Point(246, 146)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox3.Size = New System.Drawing.Size(315, 68)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Edicion"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(237, 19)
        Me.Button5.Margin = New System.Windows.Forms.Padding(1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 39)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Buscar"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(158, 19)
        Me.Button6.Margin = New System.Windows.Forms.Padding(1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(80, 39)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Eliminar"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(69, 19)
        Me.Button7.Margin = New System.Windows.Forms.Padding(1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(90, 39)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Modificar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(2, 19)
        Me.Button8.Margin = New System.Windows.Forms.Padding(1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(68, 39)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "Nuevo"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Tipo
        '
        Me.Tipo.BackColor = System.Drawing.Color.Transparent
        Me.Tipo.Controls.Add(Me.grbDatos)
        Me.Tipo.Controls.Add(Me.grbNavegacion)
        Me.Tipo.Controls.Add(Me.grbEdicion)
        Me.Tipo.ForeColor = System.Drawing.Color.Black
        Me.Tipo.Location = New System.Drawing.Point(4, 22)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tipo.Size = New System.Drawing.Size(565, 272)
        Me.Tipo.TabIndex = 1
        Me.Tipo.Text = "Tipo de habitaciones"
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtdescripcion)
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Controls.Add(Me.txtcapacidad)
        Me.grbDatos.Controls.Add(Me.TextBox6)
        Me.grbDatos.Controls.Add(Me.Label3)
        Me.grbDatos.Controls.Add(Me.Label7)
        Me.grbDatos.Controls.Add(Me.txtprecio)
        Me.grbDatos.Location = New System.Drawing.Point(6, 6)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(552, 187)
        Me.grbDatos.TabIndex = 28
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos tipos de habitaciones"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(87, 39)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(410, 20)
        Me.txtdescripcion.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Descripcion"
        '
        'txtcapacidad
        '
        Me.txtcapacidad.Location = New System.Drawing.Point(87, 94)
        Me.txtcapacidad.Name = "txtcapacidad"
        Me.txtcapacidad.Size = New System.Drawing.Size(410, 20)
        Me.txtcapacidad.TabIndex = 6
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(-26, 412)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Capacidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(84, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Precio"
        '
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(87, 147)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(410, 20)
        Me.txtprecio.TabIndex = 14
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroCategoria)
        Me.grbNavegacion.Location = New System.Drawing.Point(4, 197)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(237, 68)
        Me.grbNavegacion.TabIndex = 30
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosCategoria
        '
        Me.lblRegistrosCategoria.AutoSize = True
        Me.lblRegistrosCategoria.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosCategoria.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosCategoria.Name = "lblRegistrosCategoria"
        Me.lblRegistrosCategoria.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosCategoria.TabIndex = 4
        Me.lblRegistrosCategoria.Text = "x de n"
        '
        'btnUltimoCategoria
        '
        Me.btnUltimoCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoCategoria.Location = New System.Drawing.Point(173, 19)
        Me.btnUltimoCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoCategoria.Name = "btnUltimoCategoria"
        Me.btnUltimoCategoria.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimoCategoria.TabIndex = 3
        Me.btnUltimoCategoria.Text = ">|"
        Me.btnUltimoCategoria.UseVisualStyleBackColor = True
        '
        'btnSiguienteCategoria
        '
        Me.btnSiguienteCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteCategoria.Location = New System.Drawing.Point(134, 19)
        Me.btnSiguienteCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteCategoria.Name = "btnSiguienteCategoria"
        Me.btnSiguienteCategoria.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguienteCategoria.TabIndex = 2
        Me.btnSiguienteCategoria.Text = ">"
        Me.btnSiguienteCategoria.UseVisualStyleBackColor = True
        '
        'btnAnteriorCategoria
        '
        Me.btnAnteriorCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorCategoria.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorCategoria.Name = "btnAnteriorCategoria"
        Me.btnAnteriorCategoria.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorCategoria.TabIndex = 1
        Me.btnAnteriorCategoria.Text = "<"
        Me.btnAnteriorCategoria.UseVisualStyleBackColor = True
        '
        'btnPrimeroCategoria
        '
        Me.btnPrimeroCategoria.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroCategoria.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimeroCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroCategoria.Name = "btnPrimeroCategoria"
        Me.btnPrimeroCategoria.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimeroCategoria.TabIndex = 0
        Me.btnPrimeroCategoria.Text = "|<"
        Me.btnPrimeroCategoria.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarTipHabitacion)
        Me.grbEdicion.Controls.Add(Me.btnEliminarTipHabitacion)
        Me.grbEdicion.Controls.Add(Me.btnModificarTipHabitacion)
        Me.grbEdicion.Controls.Add(Me.btnAgregarTipHabitacion)
        Me.grbEdicion.Location = New System.Drawing.Point(243, 197)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 29
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarTipHabitacion
        '
        Me.btnBuscarTipHabitacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarTipHabitacion.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarTipHabitacion.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarTipHabitacion.Name = "btnBuscarTipHabitacion"
        Me.btnBuscarTipHabitacion.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscarTipHabitacion.TabIndex = 8
        Me.btnBuscarTipHabitacion.Text = "Buscar"
        Me.btnBuscarTipHabitacion.UseVisualStyleBackColor = True
        '
        'btnEliminarTipHabitacion
        '
        Me.btnEliminarTipHabitacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTipHabitacion.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarTipHabitacion.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarTipHabitacion.Name = "btnEliminarTipHabitacion"
        Me.btnEliminarTipHabitacion.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarTipHabitacion.TabIndex = 7
        Me.btnEliminarTipHabitacion.Text = "Eliminar"
        Me.btnEliminarTipHabitacion.UseVisualStyleBackColor = True
        '
        'btnModificarTipHabitacion
        '
        Me.btnModificarTipHabitacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarTipHabitacion.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarTipHabitacion.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarTipHabitacion.Name = "btnModificarTipHabitacion"
        Me.btnModificarTipHabitacion.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarTipHabitacion.TabIndex = 6
        Me.btnModificarTipHabitacion.Text = "Modificar"
        Me.btnModificarTipHabitacion.UseVisualStyleBackColor = True
        '
        'btnAgregarTipHabitacion
        '
        Me.btnAgregarTipHabitacion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarTipHabitacion.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarTipHabitacion.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarTipHabitacion.Name = "btnAgregarTipHabitacion"
        Me.btnAgregarTipHabitacion.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarTipHabitacion.TabIndex = 5
        Me.btnAgregarTipHabitacion.Text = "Nuevo"
        Me.btnAgregarTipHabitacion.UseVisualStyleBackColor = True
        '
        'piso
        '
        Me.piso.BackColor = System.Drawing.Color.Transparent
        Me.piso.Controls.Add(Me.GroupBox4)
        Me.piso.Controls.Add(Me.GroupBox5)
        Me.piso.Controls.Add(Me.GroupBox6)
        Me.piso.Location = New System.Drawing.Point(4, 22)
        Me.piso.Name = "piso"
        Me.piso.Padding = New System.Windows.Forms.Padding(3)
        Me.piso.Size = New System.Drawing.Size(565, 272)
        Me.piso.TabIndex = 2
        Me.piso.Text = "Edificio"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtcodedificio)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtedificio)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(552, 135)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dato edificio"
        '
        'txtcodedificio
        '
        Me.txtcodedificio.Location = New System.Drawing.Point(73, 38)
        Me.txtcodedificio.Name = "txtcodedificio"
        Me.txtcodedificio.Size = New System.Drawing.Size(410, 20)
        Me.txtcodedificio.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Codigo"
        '
        'txtedificio
        '
        Me.txtedificio.Location = New System.Drawing.Point(73, 93)
        Me.txtedificio.Name = "txtedificio"
        Me.txtedificio.Size = New System.Drawing.Size(410, 20)
        Me.txtedificio.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(70, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Edificio"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Button9)
        Me.GroupBox5.Controls.Add(Me.Button10)
        Me.GroupBox5.Controls.Add(Me.Button11)
        Me.GroupBox5.Controls.Add(Me.Button12)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 142)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox5.Size = New System.Drawing.Size(237, 68)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Navegacion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(86, 34)
        Me.Label9.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(36, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "x de n"
        '
        'Button9
        '
        Me.Button9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(173, 19)
        Me.Button9.Margin = New System.Windows.Forms.Padding(1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(41, 39)
        Me.Button9.TabIndex = 3
        Me.Button9.Text = ">|"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(134, 19)
        Me.Button10.Margin = New System.Windows.Forms.Padding(1)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(41, 39)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = ">"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(42, 19)
        Me.Button11.Margin = New System.Windows.Forms.Padding(1)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(41, 39)
        Me.Button11.TabIndex = 1
        Me.Button11.Text = "<"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(2, 19)
        Me.Button12.Margin = New System.Windows.Forms.Padding(1)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(41, 39)
        Me.Button12.TabIndex = 0
        Me.Button12.Text = "|<"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button13)
        Me.GroupBox6.Controls.Add(Me.Button14)
        Me.GroupBox6.Controls.Add(Me.Button15)
        Me.GroupBox6.Controls.Add(Me.btnAgregarEdificios)
        Me.GroupBox6.Location = New System.Drawing.Point(245, 142)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox6.Size = New System.Drawing.Size(315, 68)
        Me.GroupBox6.TabIndex = 35
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Edicion"
        '
        'Button13
        '
        Me.Button13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(237, 19)
        Me.Button13.Margin = New System.Windows.Forms.Padding(1)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(75, 39)
        Me.Button13.TabIndex = 8
        Me.Button13.Text = "Buscar"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.Location = New System.Drawing.Point(158, 19)
        Me.Button14.Margin = New System.Windows.Forms.Padding(1)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(80, 39)
        Me.Button14.TabIndex = 7
        Me.Button14.Text = "Eliminar"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.Location = New System.Drawing.Point(69, 19)
        Me.Button15.Margin = New System.Windows.Forms.Padding(1)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(90, 39)
        Me.Button15.TabIndex = 6
        Me.Button15.Text = "Modificar"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'btnAgregarEdificios
        '
        Me.btnAgregarEdificios.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEdificios.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarEdificios.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarEdificios.Name = "btnAgregarEdificios"
        Me.btnAgregarEdificios.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarEdificios.TabIndex = 5
        Me.btnAgregarEdificios.Text = "Nuevo"
        Me.btnAgregarEdificios.UseVisualStyleBackColor = True
        '
        'nivel
        '
        Me.nivel.BackColor = System.Drawing.Color.Transparent
        Me.nivel.Controls.Add(Me.GroupBox7)
        Me.nivel.Controls.Add(Me.GroupBox8)
        Me.nivel.Controls.Add(Me.GroupBox9)
        Me.nivel.Location = New System.Drawing.Point(4, 22)
        Me.nivel.Name = "nivel"
        Me.nivel.Size = New System.Drawing.Size(565, 272)
        Me.nivel.TabIndex = 3
        Me.nivel.Text = "Nivel"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.txtnivel)
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.TextBox8)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(552, 135)
        Me.GroupBox7.TabIndex = 37
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Habitacion nueva"
        '
        'txtnivel
        '
        Me.txtnivel.Location = New System.Drawing.Point(67, 63)
        Me.txtnivel.Name = "txtnivel"
        Me.txtnivel.Size = New System.Drawing.Size(410, 20)
        Me.txtnivel.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(63, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Nivel"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(-26, 412)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 18
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.Button17)
        Me.GroupBox8.Controls.Add(Me.Button18)
        Me.GroupBox8.Controls.Add(Me.Button19)
        Me.GroupBox8.Controls.Add(Me.Button20)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 143)
        Me.GroupBox8.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox8.Size = New System.Drawing.Size(226, 68)
        Me.GroupBox8.TabIndex = 39
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Navegacion"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(86, 34)
        Me.Label10.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "x de n"
        '
        'Button17
        '
        Me.Button17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(173, 19)
        Me.Button17.Margin = New System.Windows.Forms.Padding(1)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(41, 39)
        Me.Button17.TabIndex = 3
        Me.Button17.Text = ">|"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(134, 19)
        Me.Button18.Margin = New System.Windows.Forms.Padding(1)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(41, 39)
        Me.Button18.TabIndex = 2
        Me.Button18.Text = ">"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button19
        '
        Me.Button19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(42, 19)
        Me.Button19.Margin = New System.Windows.Forms.Padding(1)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(41, 39)
        Me.Button19.TabIndex = 1
        Me.Button19.Text = "<"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button20
        '
        Me.Button20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Location = New System.Drawing.Point(2, 19)
        Me.Button20.Margin = New System.Windows.Forms.Padding(1)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(41, 39)
        Me.Button20.TabIndex = 0
        Me.Button20.Text = "|<"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button21)
        Me.GroupBox9.Controls.Add(Me.Button22)
        Me.GroupBox9.Controls.Add(Me.Button23)
        Me.GroupBox9.Controls.Add(Me.Button24)
        Me.GroupBox9.Location = New System.Drawing.Point(247, 143)
        Me.GroupBox9.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox9.Size = New System.Drawing.Size(315, 68)
        Me.GroupBox9.TabIndex = 38
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Edicion"
        '
        'Button21
        '
        Me.Button21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Location = New System.Drawing.Point(237, 19)
        Me.Button21.Margin = New System.Windows.Forms.Padding(1)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(75, 39)
        Me.Button21.TabIndex = 8
        Me.Button21.Text = "Buscar"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'Button22
        '
        Me.Button22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.Location = New System.Drawing.Point(158, 19)
        Me.Button22.Margin = New System.Windows.Forms.Padding(1)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(80, 39)
        Me.Button22.TabIndex = 7
        Me.Button22.Text = "Eliminar"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Location = New System.Drawing.Point(69, 19)
        Me.Button23.Margin = New System.Windows.Forms.Padding(1)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(90, 39)
        Me.Button23.TabIndex = 6
        Me.Button23.Text = "Modificar"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.Location = New System.Drawing.Point(2, 19)
        Me.Button24.Margin = New System.Windows.Forms.Padding(1)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(68, 39)
        Me.Button24.TabIndex = 5
        Me.Button24.Text = "Nuevo"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'FormHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 317)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormHabitaciones"
        Me.Text = "FormHabitaciones"
        Me.TabControl1.ResumeLayout(False)
        Me.Habitaciones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Tipo.ResumeLayout(False)
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.piso.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.nivel.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Habitaciones As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtcodigohabitacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblRegistroHabitaciones As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Tipo As TabPage
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcapacidad As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosCategoria As Label
    Friend WithEvents btnUltimoCategoria As Button
    Friend WithEvents btnSiguienteCategoria As Button
    Friend WithEvents btnAnteriorCategoria As Button
    Friend WithEvents btnPrimeroCategoria As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarTipHabitacion As Button
    Friend WithEvents btnEliminarTipHabitacion As Button
    Friend WithEvents btnModificarTipHabitacion As Button
    Friend WithEvents btnAgregarTipHabitacion As Button
    Friend WithEvents piso As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtcodedificio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtedificio As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Button13 As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents Button15 As Button
    Friend WithEvents btnAgregarEdificios As Button
    Friend WithEvents nivel As TabPage
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents txtnivel As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button17 As Button
    Friend WithEvents Button18 As Button
    Friend WithEvents Button19 As Button
    Friend WithEvents Button20 As Button
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Button21 As Button
    Friend WithEvents Button22 As Button
    Friend WithEvents Button23 As Button
    Friend WithEvents Button24 As Button
End Class
