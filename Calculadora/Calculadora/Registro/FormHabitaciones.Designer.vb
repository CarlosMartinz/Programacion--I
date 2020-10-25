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
        Me.brHabitacionNueva = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMostrarTipo = New System.Windows.Forms.Button()
        Me.btnMostrarEdificio = New System.Windows.Forms.Button()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.cboEdificio = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcodigohabitacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRegistroHabitaciones = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Tipo = New System.Windows.Forms.TabPage()
        Me.grbDatosTipoHab = New System.Windows.Forms.GroupBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.grbNavegacionTipoHab = New System.Windows.Forms.GroupBox()
        Me.lblRegistroTipoHab = New System.Windows.Forms.Label()
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
        Me.txtedificio = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnBuscarEdit = New System.Windows.Forms.Button()
        Me.btnEliminarEdit = New System.Windows.Forms.Button()
        Me.btnModificarEdit = New System.Windows.Forms.Button()
        Me.btnAgregarEdificios = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Habitaciones.SuspendLayout()
        Me.brHabitacionNueva.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Tipo.SuspendLayout()
        Me.grbDatosTipoHab.SuspendLayout()
        Me.grbNavegacionTipoHab.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.piso.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Habitaciones)
        Me.TabControl1.Controls.Add(Me.Tipo)
        Me.TabControl1.Controls.Add(Me.piso)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(573, 284)
        Me.TabControl1.TabIndex = 32
        '
        'Habitaciones
        '
        Me.Habitaciones.BackColor = System.Drawing.Color.Transparent
        Me.Habitaciones.Controls.Add(Me.brHabitacionNueva)
        Me.Habitaciones.Controls.Add(Me.GroupBox2)
        Me.Habitaciones.Controls.Add(Me.GroupBox3)
        Me.Habitaciones.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Habitaciones.Location = New System.Drawing.Point(4, 22)
        Me.Habitaciones.Name = "Habitaciones"
        Me.Habitaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.Habitaciones.Size = New System.Drawing.Size(565, 258)
        Me.Habitaciones.TabIndex = 0
        Me.Habitaciones.Text = "Nueva habitacion"
        '
        'brHabitacionNueva
        '
        Me.brHabitacionNueva.Controls.Add(Me.Button2)
        Me.brHabitacionNueva.Controls.Add(Me.Button1)
        Me.brHabitacionNueva.Controls.Add(Me.btnMostrarTipo)
        Me.brHabitacionNueva.Controls.Add(Me.btnMostrarEdificio)
        Me.brHabitacionNueva.Controls.Add(Me.cboTipo)
        Me.brHabitacionNueva.Controls.Add(Me.cboEdificio)
        Me.brHabitacionNueva.Controls.Add(Me.Label5)
        Me.brHabitacionNueva.Controls.Add(Me.Label4)
        Me.brHabitacionNueva.Controls.Add(Me.txtcodigohabitacion)
        Me.brHabitacionNueva.Controls.Add(Me.Label1)
        Me.brHabitacionNueva.Controls.Add(Me.TextBox3)
        Me.brHabitacionNueva.Location = New System.Drawing.Point(7, 7)
        Me.brHabitacionNueva.Name = "brHabitacionNueva"
        Me.brHabitacionNueva.Size = New System.Drawing.Size(552, 169)
        Me.brHabitacionNueva.TabIndex = 31
        Me.brHabitacionNueva.TabStop = False
        Me.brHabitacionNueva.Text = "Habitacion nueva"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(471, 129)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "Detalles"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(471, 86)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Detalles"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMostrarTipo
        '
        Me.btnMostrarTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarTipo.Location = New System.Drawing.Point(388, 129)
        Me.btnMostrarTipo.Name = "btnMostrarTipo"
        Me.btnMostrarTipo.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrarTipo.TabIndex = 26
        Me.btnMostrarTipo.Text = "Buscar"
        Me.btnMostrarTipo.UseVisualStyleBackColor = True
        '
        'btnMostrarEdificio
        '
        Me.btnMostrarEdificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrarEdificio.Location = New System.Drawing.Point(388, 86)
        Me.btnMostrarEdificio.Name = "btnMostrarEdificio"
        Me.btnMostrarEdificio.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrarEdificio.TabIndex = 25
        Me.btnMostrarEdificio.Text = "Buscar"
        Me.btnMostrarEdificio.UseVisualStyleBackColor = True
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.cboTipo.Location = New System.Drawing.Point(7, 132)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(356, 21)
        Me.cboTipo.TabIndex = 24
        '
        'cboEdificio
        '
        Me.cboEdificio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEdificio.FormattingEnabled = True
        Me.cboEdificio.Location = New System.Drawing.Point(7, 89)
        Me.cboEdificio.Name = "cboEdificio"
        Me.cboEdificio.Size = New System.Drawing.Size(356, 21)
        Me.cboEdificio.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Tipo de habitacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Edificio"
        '
        'txtcodigohabitacion
        '
        Me.txtcodigohabitacion.Location = New System.Drawing.Point(6, 40)
        Me.txtcodigohabitacion.Name = "txtcodigohabitacion"
        Me.txtcodigohabitacion.Size = New System.Drawing.Size(357, 20)
        Me.txtcodigohabitacion.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 19)
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
        Me.GroupBox2.Controls.Add(Me.btnUltimo)
        Me.GroupBox2.Controls.Add(Me.btnSiguiente)
        Me.GroupBox2.Controls.Add(Me.btnAnterior)
        Me.GroupBox2.Controls.Add(Me.btnPrimero)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 180)
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
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(173, 19)
        Me.btnUltimo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(134, 19)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(42, 19)
        Me.btnAnterior.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(41, 39)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimero.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnBuscar)
        Me.GroupBox3.Controls.Add(Me.btnEliminar)
        Me.GroupBox3.Controls.Add(Me.btnModificar)
        Me.GroupBox3.Controls.Add(Me.btnNuevo)
        Me.GroupBox3.Location = New System.Drawing.Point(246, 180)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(1)
        Me.GroupBox3.Size = New System.Drawing.Size(315, 68)
        Me.GroupBox3.TabIndex = 32
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Edicion"
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(69, 19)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(90, 39)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(2, 19)
        Me.btnNuevo.Margin = New System.Windows.Forms.Padding(1)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(68, 39)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Tipo
        '
        Me.Tipo.BackColor = System.Drawing.Color.Transparent
        Me.Tipo.Controls.Add(Me.grbDatosTipoHab)
        Me.Tipo.Controls.Add(Me.grbNavegacionTipoHab)
        Me.Tipo.Controls.Add(Me.grbEdicion)
        Me.Tipo.ForeColor = System.Drawing.Color.Black
        Me.Tipo.Location = New System.Drawing.Point(4, 22)
        Me.Tipo.Name = "Tipo"
        Me.Tipo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tipo.Size = New System.Drawing.Size(565, 258)
        Me.Tipo.TabIndex = 1
        Me.Tipo.Text = "Tipo de habitaciones"
        '
        'grbDatosTipoHab
        '
        Me.grbDatosTipoHab.Controls.Add(Me.txtCapacidad)
        Me.grbDatosTipoHab.Controls.Add(Me.txtdescripcion)
        Me.grbDatosTipoHab.Controls.Add(Me.Label2)
        Me.grbDatosTipoHab.Controls.Add(Me.TextBox6)
        Me.grbDatosTipoHab.Controls.Add(Me.Label3)
        Me.grbDatosTipoHab.Controls.Add(Me.Label7)
        Me.grbDatosTipoHab.Controls.Add(Me.txtprecio)
        Me.grbDatosTipoHab.Location = New System.Drawing.Point(6, 6)
        Me.grbDatosTipoHab.Name = "grbDatosTipoHab"
        Me.grbDatosTipoHab.Size = New System.Drawing.Size(552, 187)
        Me.grbDatosTipoHab.TabIndex = 28
        Me.grbDatosTipoHab.TabStop = False
        Me.grbDatosTipoHab.Text = "Datos tipos de habitaciones"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(87, 94)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(410, 20)
        Me.txtCapacidad.TabIndex = 19
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
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo de habitacion"
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
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Capacidad"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 15)
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
        'grbNavegacionTipoHab
        '
        Me.grbNavegacionTipoHab.Controls.Add(Me.lblRegistroTipoHab)
        Me.grbNavegacionTipoHab.Controls.Add(Me.btnUltimoCategoria)
        Me.grbNavegacionTipoHab.Controls.Add(Me.btnSiguienteCategoria)
        Me.grbNavegacionTipoHab.Controls.Add(Me.btnAnteriorCategoria)
        Me.grbNavegacionTipoHab.Controls.Add(Me.btnPrimeroCategoria)
        Me.grbNavegacionTipoHab.Location = New System.Drawing.Point(4, 197)
        Me.grbNavegacionTipoHab.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacionTipoHab.Name = "grbNavegacionTipoHab"
        Me.grbNavegacionTipoHab.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacionTipoHab.Size = New System.Drawing.Size(237, 68)
        Me.grbNavegacionTipoHab.TabIndex = 30
        Me.grbNavegacionTipoHab.TabStop = False
        Me.grbNavegacionTipoHab.Text = "Navegacion"
        '
        'lblRegistroTipoHab
        '
        Me.lblRegistroTipoHab.AutoSize = True
        Me.lblRegistroTipoHab.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistroTipoHab.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistroTipoHab.Name = "lblRegistroTipoHab"
        Me.lblRegistroTipoHab.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistroTipoHab.TabIndex = 4
        Me.lblRegistroTipoHab.Text = "x de n"
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
        Me.piso.Size = New System.Drawing.Size(565, 258)
        Me.piso.TabIndex = 2
        Me.piso.Text = "Edificio"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtedificio)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(552, 129)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Dato edificio"
        '
        'txtedificio
        '
        Me.txtedificio.Location = New System.Drawing.Point(73, 57)
        Me.txtedificio.Name = "txtedificio"
        Me.txtedificio.Size = New System.Drawing.Size(410, 20)
        Me.txtedificio.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(70, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 15)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Nombre del edificio"
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
        Me.GroupBox6.Controls.Add(Me.btnBuscarEdit)
        Me.GroupBox6.Controls.Add(Me.btnEliminarEdit)
        Me.GroupBox6.Controls.Add(Me.btnModificarEdit)
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
        'btnBuscarEdit
        '
        Me.btnBuscarEdit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEdit.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarEdit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarEdit.Name = "btnBuscarEdit"
        Me.btnBuscarEdit.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscarEdit.TabIndex = 8
        Me.btnBuscarEdit.Text = "Buscar"
        Me.btnBuscarEdit.UseVisualStyleBackColor = True
        '
        'btnEliminarEdit
        '
        Me.btnEliminarEdit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEdit.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarEdit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarEdit.Name = "btnEliminarEdit"
        Me.btnEliminarEdit.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarEdit.TabIndex = 7
        Me.btnEliminarEdit.Text = "Eliminar"
        Me.btnEliminarEdit.UseVisualStyleBackColor = True
        '
        'btnModificarEdit
        '
        Me.btnModificarEdit.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarEdit.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarEdit.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarEdit.Name = "btnModificarEdit"
        Me.btnModificarEdit.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarEdit.TabIndex = 6
        Me.btnModificarEdit.Text = "Modificar"
        Me.btnModificarEdit.UseVisualStyleBackColor = True
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
        'FormHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 307)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormHabitaciones"
        Me.Text = "FormHabitaciones"
        Me.TabControl1.ResumeLayout(False)
        Me.Habitaciones.ResumeLayout(False)
        Me.brHabitacionNueva.ResumeLayout(False)
        Me.brHabitacionNueva.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Tipo.ResumeLayout(False)
        Me.grbDatosTipoHab.ResumeLayout(False)
        Me.grbDatosTipoHab.PerformLayout()
        Me.grbNavegacionTipoHab.ResumeLayout(False)
        Me.grbNavegacionTipoHab.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.piso.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Habitaciones As TabPage
    Friend WithEvents brHabitacionNueva As GroupBox
    Friend WithEvents txtcodigohabitacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblRegistroHabitaciones As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Tipo As TabPage
    Friend WithEvents grbDatosTipoHab As GroupBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents grbNavegacionTipoHab As GroupBox
    Friend WithEvents lblRegistroTipoHab As Label
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
    Friend WithEvents txtedificio As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button12 As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnBuscarEdit As Button
    Friend WithEvents btnEliminarEdit As Button
    Friend WithEvents btnModificarEdit As Button
    Friend WithEvents btnAgregarEdificios As Button
    Friend WithEvents cboTipo As ComboBox
    Friend WithEvents cboEdificio As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnMostrarTipo As Button
    Friend WithEvents btnMostrarEdificio As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtCapacidad As TextBox
End Class
