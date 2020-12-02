<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReservaciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReservaciones))
        Me.pnlReservacion = New System.Windows.Forms.Panel()
        Me.grpEdicion = New System.Windows.Forms.GroupBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnElimar = New System.Windows.Forms.Button()
        Me.grbPosicion = New System.Windows.Forms.GroupBox()
        Me.lblPosicion = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.grbReservacion = New System.Windows.Forms.GroupBox()
        Me.txtTotal = New System.Windows.Forms.Label()
        Me.txtDias = New System.Windows.Forms.Label()
        Me.btnClientes = New System.Windows.Forms.PictureBox()
        Me.btnHabitaciones = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtHabitacion = New System.Windows.Forms.TextBox()
        Me.DateEntrada = New System.Windows.Forms.DateTimePicker()
        Me.DateSalida = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtPrecioDia = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grbMostrar = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.grdHabitaciones = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clien = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emple = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idHabitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estados = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Capacidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pnlReservacion.SuspendLayout()
        Me.grpEdicion.SuspendLayout()
        Me.grbPosicion.SuspendLayout()
        Me.grbReservacion.SuspendLayout()
        CType(Me.btnClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbMostrar.SuspendLayout()
        CType(Me.grdHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlReservacion
        '
        Me.pnlReservacion.BackColor = System.Drawing.Color.White
        Me.pnlReservacion.Controls.Add(Me.grpEdicion)
        Me.pnlReservacion.Controls.Add(Me.grbPosicion)
        Me.pnlReservacion.Controls.Add(Me.grbReservacion)
        Me.pnlReservacion.Controls.Add(Me.grbMostrar)
        Me.pnlReservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReservacion.Location = New System.Drawing.Point(0, 0)
        Me.pnlReservacion.Name = "pnlReservacion"
        Me.pnlReservacion.Size = New System.Drawing.Size(848, 522)
        Me.pnlReservacion.TabIndex = 4
        '
        'grpEdicion
        '
        Me.grpEdicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpEdicion.Controls.Add(Me.btnAgregar)
        Me.grpEdicion.Controls.Add(Me.btnModificar)
        Me.grpEdicion.Controls.Add(Me.btnElimar)
        Me.grpEdicion.Location = New System.Drawing.Point(16, 411)
        Me.grpEdicion.Name = "grpEdicion"
        Me.grpEdicion.Size = New System.Drawing.Size(356, 45)
        Me.grpEdicion.TabIndex = 63
        Me.grpEdicion.TabStop = False
        Me.grpEdicion.Text = "Edicion"
        '
        'btnAgregar
        '
        Me.btnAgregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(67, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(64, 27)
        Me.btnAgregar.TabIndex = 61
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(137, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(79, 27)
        Me.btnModificar.TabIndex = 60
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnElimar
        '
        Me.btnElimar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnElimar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElimar.Location = New System.Drawing.Point(222, 12)
        Me.btnElimar.Name = "btnElimar"
        Me.btnElimar.Size = New System.Drawing.Size(64, 27)
        Me.btnElimar.TabIndex = 59
        Me.btnElimar.Text = "Eliminar"
        Me.btnElimar.UseVisualStyleBackColor = True
        '
        'grbPosicion
        '
        Me.grbPosicion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grbPosicion.Controls.Add(Me.lblPosicion)
        Me.grbPosicion.Controls.Add(Me.btnUltimo)
        Me.grbPosicion.Controls.Add(Me.btnSiguiente)
        Me.grbPosicion.Controls.Add(Me.btnAnterior)
        Me.grbPosicion.Controls.Add(Me.btnPrimero)
        Me.grbPosicion.Location = New System.Drawing.Point(15, 462)
        Me.grbPosicion.Name = "grbPosicion"
        Me.grbPosicion.Size = New System.Drawing.Size(358, 48)
        Me.grbPosicion.TabIndex = 62
        Me.grbPosicion.TabStop = False
        Me.grbPosicion.Text = "Posicion"
        '
        'lblPosicion
        '
        Me.lblPosicion.AutoSize = True
        Me.lblPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosicion.Location = New System.Drawing.Point(164, 18)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(44, 16)
        Me.lblPosicion.TabIndex = 5
        Me.lblPosicion.Text = "1 de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(261, 13)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(43, 28)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(214, 12)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(41, 28)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(118, 12)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(40, 28)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Location = New System.Drawing.Point(62, 12)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(50, 28)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'grbReservacion
        '
        Me.grbReservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grbReservacion.Controls.Add(Me.txtTotal)
        Me.grbReservacion.Controls.Add(Me.txtDias)
        Me.grbReservacion.Controls.Add(Me.btnClientes)
        Me.grbReservacion.Controls.Add(Me.btnHabitaciones)
        Me.grbReservacion.Controls.Add(Me.Panel2)
        Me.grbReservacion.Controls.Add(Me.Label2)
        Me.grbReservacion.Controls.Add(Me.Label4)
        Me.grbReservacion.Controls.Add(Me.Panel3)
        Me.grbReservacion.Controls.Add(Me.txtHabitacion)
        Me.grbReservacion.Controls.Add(Me.DateEntrada)
        Me.grbReservacion.Controls.Add(Me.DateSalida)
        Me.grbReservacion.Controls.Add(Me.Panel1)
        Me.grbReservacion.Controls.Add(Me.Label1)
        Me.grbReservacion.Controls.Add(Me.Panel8)
        Me.grbReservacion.Controls.Add(Me.txtEmpleado)
        Me.grbReservacion.Controls.Add(Me.Label8)
        Me.grbReservacion.Controls.Add(Me.Panel7)
        Me.grbReservacion.Controls.Add(Me.txtCliente)
        Me.grbReservacion.Controls.Add(Me.Label7)
        Me.grbReservacion.Controls.Add(Me.Panel6)
        Me.grbReservacion.Controls.Add(Me.txtPrecioDia)
        Me.grbReservacion.Controls.Add(Me.Panel5)
        Me.grbReservacion.Controls.Add(Me.Panel4)
        Me.grbReservacion.Controls.Add(Me.Label6)
        Me.grbReservacion.Controls.Add(Me.Label5)
        Me.grbReservacion.Controls.Add(Me.Label3)
        Me.grbReservacion.Location = New System.Drawing.Point(15, 12)
        Me.grbReservacion.Name = "grbReservacion"
        Me.grbReservacion.Size = New System.Drawing.Size(358, 393)
        Me.grbReservacion.TabIndex = 2
        Me.grbReservacion.TabStop = False
        Me.grbReservacion.Text = "Datos de reservacion"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(134, 337)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(165, 18)
        Me.txtTotal.TabIndex = 49
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDias
        '
        Me.txtDias.Enabled = False
        Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias.Location = New System.Drawing.Point(134, 248)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(166, 23)
        Me.txtDias.TabIndex = 48
        Me.txtDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClientes
        '
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.Location = New System.Drawing.Point(320, 29)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(25, 25)
        Me.btnClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClientes.TabIndex = 44
        Me.btnClientes.TabStop = False
        '
        'btnHabitaciones
        '
        Me.btnHabitaciones.Image = CType(resources.GetObject("btnHabitaciones.Image"), System.Drawing.Image)
        Me.btnHabitaciones.Location = New System.Drawing.Point(320, 114)
        Me.btnHabitaciones.Name = "btnHabitaciones"
        Me.btnHabitaciones.Size = New System.Drawing.Size(25, 25)
        Me.btnHabitaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnHabitaciones.TabIndex = 43
        Me.btnHabitaciones.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(135, 358)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 1)
        Me.Panel2.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 337)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Habitacion:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(135, 143)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(165, 1)
        Me.Panel3.TabIndex = 33
        '
        'txtHabitacion
        '
        Me.txtHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHabitacion.Enabled = False
        Me.txtHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHabitacion.Location = New System.Drawing.Point(135, 122)
        Me.txtHabitacion.Name = "txtHabitacion"
        Me.txtHabitacion.Size = New System.Drawing.Size(165, 17)
        Me.txtHabitacion.TabIndex = 32
        Me.txtHabitacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateEntrada
        '
        Me.DateEntrada.Enabled = False
        Me.DateEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateEntrada.Location = New System.Drawing.Point(135, 168)
        Me.DateEntrada.Name = "DateEntrada"
        Me.DateEntrada.Size = New System.Drawing.Size(165, 20)
        Me.DateEntrada.TabIndex = 31
        '
        'DateSalida
        '
        Me.DateSalida.Enabled = False
        Me.DateSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateSalida.Location = New System.Drawing.Point(135, 210)
        Me.DateSalida.Name = "DateSalida"
        Me.DateSalida.Size = New System.Drawing.Size(165, 20)
        Me.DateSalida.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(135, 232)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 1)
        Me.Panel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Salida:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(135, 100)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(165, 1)
        Me.Panel8.TabIndex = 28
        '
        'txtEmpleado
        '
        Me.txtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpleado.Location = New System.Drawing.Point(135, 79)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(165, 17)
        Me.txtEmpleado.TabIndex = 27
        Me.txtEmpleado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Empleado:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(134, 53)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(165, 1)
        Me.Panel7.TabIndex = 17
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(134, 32)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(165, 17)
        Me.txtCliente.TabIndex = 16
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cliente:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(135, 316)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(165, 1)
        Me.Panel6.TabIndex = 14
        '
        'txtPrecioDia
        '
        Me.txtPrecioDia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioDia.Enabled = False
        Me.txtPrecioDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioDia.Location = New System.Drawing.Point(135, 295)
        Me.txtPrecioDia.Name = "txtPrecioDia"
        Me.txtPrecioDia.Size = New System.Drawing.Size(165, 17)
        Me.txtPrecioDia.TabIndex = 13
        Me.txtPrecioDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(135, 274)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(165, 1)
        Me.Panel5.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(135, 190)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(165, 1)
        Me.Panel4.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 297)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio por dia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dias:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Entrada:"
        '
        'grbMostrar
        '
        Me.grbMostrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbMostrar.Controls.Add(Me.Button1)
        Me.grbMostrar.Controls.Add(Me.txtBuscar)
        Me.grbMostrar.Controls.Add(Me.grdHabitaciones)
        Me.grbMostrar.Location = New System.Drawing.Point(379, 12)
        Me.grbMostrar.Name = "grbMostrar"
        Me.grbMostrar.Size = New System.Drawing.Size(453, 498)
        Me.grbMostrar.TabIndex = 1
        Me.grbMostrar.TabStop = False
        Me.grbMostrar.Text = "Listado de reservaciones"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(17, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Realizar apago"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(17, 18)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(419, 22)
        Me.txtBuscar.TabIndex = 1
        '
        'grdHabitaciones
        '
        Me.grdHabitaciones.AllowUserToAddRows = False
        Me.grdHabitaciones.AllowUserToDeleteRows = False
        Me.grdHabitaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdHabitaciones.BackgroundColor = System.Drawing.Color.White
        Me.grdHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdHabitaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.clien, Me.emple, Me.idHabitacion, Me.Entrada, Me.Salida, Me.Estados, Me.Tipo, Me.Capacidad, Me.empleado, Me.cliente, Me.estado})
        Me.grdHabitaciones.Location = New System.Drawing.Point(17, 48)
        Me.grdHabitaciones.Name = "grdHabitaciones"
        Me.grdHabitaciones.ReadOnly = True
        Me.grdHabitaciones.RowHeadersVisible = False
        Me.grdHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdHabitaciones.Size = New System.Drawing.Size(419, 396)
        Me.grdHabitaciones.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "idReservaiones"
        Me.Codigo.HeaderText = "N° de Reservacion"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'clien
        '
        Me.clien.DataPropertyName = "Nombre"
        Me.clien.HeaderText = "Cliente"
        Me.clien.Name = "clien"
        Me.clien.ReadOnly = True
        '
        'emple
        '
        Me.emple.DataPropertyName = "nombre1"
        Me.emple.HeaderText = "Empleado"
        Me.emple.Name = "emple"
        Me.emple.ReadOnly = True
        '
        'idHabitacion
        '
        Me.idHabitacion.DataPropertyName = "idHabitaciones"
        Me.idHabitacion.HeaderText = "Habitacion"
        Me.idHabitacion.Name = "idHabitacion"
        Me.idHabitacion.ReadOnly = True
        '
        'Entrada
        '
        Me.Entrada.DataPropertyName = "Entrada"
        Me.Entrada.HeaderText = "Entrada"
        Me.Entrada.Name = "Entrada"
        Me.Entrada.ReadOnly = True
        '
        'Salida
        '
        Me.Salida.DataPropertyName = "Salida"
        Me.Salida.HeaderText = "Salida"
        Me.Salida.Name = "Salida"
        Me.Salida.ReadOnly = True
        '
        'Estados
        '
        Me.Estados.DataPropertyName = "Estadia"
        Me.Estados.HeaderText = "Estadia"
        Me.Estados.Name = "Estados"
        Me.Estados.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "PrecioDia"
        Me.Tipo.HeaderText = "Precio por dia"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Capacidad
        '
        Me.Capacidad.DataPropertyName = "Total"
        Me.Capacidad.HeaderText = "Total"
        Me.Capacidad.Name = "Capacidad"
        Me.Capacidad.ReadOnly = True
        '
        'empleado
        '
        Me.empleado.DataPropertyName = "idUsuario"
        Me.empleado.HeaderText = "idEmpleado"
        Me.empleado.Name = "empleado"
        Me.empleado.ReadOnly = True
        Me.empleado.Visible = False
        '
        'cliente
        '
        Me.cliente.DataPropertyName = "idCliente"
        Me.cliente.HeaderText = "idCliente"
        Me.cliente.Name = "cliente"
        Me.cliente.ReadOnly = True
        Me.cliente.Visible = False
        '
        'estado
        '
        Me.estado.DataPropertyName = "estadoReserva"
        Me.estado.HeaderText = "estado"
        Me.estado.Name = "estado"
        Me.estado.ReadOnly = True
        Me.estado.Visible = False
        '
        'FormReservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 522)
        Me.Controls.Add(Me.pnlReservacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReservaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservaciones"
        Me.pnlReservacion.ResumeLayout(False)
        Me.grpEdicion.ResumeLayout(False)
        Me.grbPosicion.ResumeLayout(False)
        Me.grbPosicion.PerformLayout()
        Me.grbReservacion.ResumeLayout(False)
        Me.grbReservacion.PerformLayout()
        CType(Me.btnClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbMostrar.ResumeLayout(False)
        Me.grbMostrar.PerformLayout()
        CType(Me.grdHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlReservacion As Panel
    Friend WithEvents grbMostrar As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents grdHabitaciones As DataGridView
    Friend WithEvents grbReservacion As GroupBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtHabitacion As TextBox
    Friend WithEvents DateEntrada As DateTimePicker
    Friend WithEvents DateSalida As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtPrecioDia As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnHabitaciones As PictureBox
    Friend WithEvents btnClientes As PictureBox
    Friend WithEvents txtDias As Label
    Friend WithEvents txtTotal As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnElimar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents grbPosicion As GroupBox
    Friend WithEvents lblPosicion As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents grpEdicion As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents clien As DataGridViewTextBoxColumn
    Friend WithEvents emple As DataGridViewTextBoxColumn
    Friend WithEvents idHabitacion As DataGridViewTextBoxColumn
    Friend WithEvents Entrada As DataGridViewTextBoxColumn
    Friend WithEvents Salida As DataGridViewTextBoxColumn
    Friend WithEvents Estados As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Capacidad As DataGridViewTextBoxColumn
    Friend WithEvents empleado As DataGridViewTextBoxColumn
    Friend WithEvents cliente As DataGridViewTextBoxColumn
    Friend WithEvents estado As DataGridViewTextBoxColumn
End Class
