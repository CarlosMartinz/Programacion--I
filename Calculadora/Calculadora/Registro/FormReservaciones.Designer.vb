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
        Me.pnlBucar = New System.Windows.Forms.Panel()
        Me.MenuStrip5 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.grdCliente = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpReservacion = New System.Windows.Forms.GroupBox()
        Me.DateEntrada = New System.Windows.Forms.DateTimePicker()
        Me.DateSalida = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip6 = New System.Windows.Forms.MenuStrip()
        Me.btnEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.txtEmpleado = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.btnBuscarCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttton = New System.Windows.Forms.MenuStrip()
        Me.btnAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpMostrar = New System.Windows.Forms.GroupBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.grdHabitaciones = New System.Windows.Forms.DataGridView()
        Me.idHabitacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Entrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Capacidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.MenuStrip7 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip8 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlReservacion.SuspendLayout()
        Me.pnlBucar.SuspendLayout()
        Me.MenuStrip5.SuspendLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.grpReservacion.SuspendLayout()
        Me.MenuStrip6.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.buttton.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        Me.grpMostrar.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.grdHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip7.SuspendLayout()
        Me.MenuStrip8.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlReservacion
        '
        Me.pnlReservacion.BackColor = System.Drawing.Color.White
        Me.pnlReservacion.Controls.Add(Me.pnlBucar)
        Me.pnlReservacion.Controls.Add(Me.grpReservacion)
        Me.pnlReservacion.Controls.Add(Me.grpMostrar)
        Me.pnlReservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReservacion.Location = New System.Drawing.Point(0, 0)
        Me.pnlReservacion.Name = "pnlReservacion"
        Me.pnlReservacion.Size = New System.Drawing.Size(848, 495)
        Me.pnlReservacion.TabIndex = 4
        '
        'pnlBucar
        '
        Me.pnlBucar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBucar.Controls.Add(Me.MenuStrip5)
        Me.pnlBucar.Controls.Add(Me.TextBox8)
        Me.pnlBucar.Controls.Add(Me.grdCliente)
        Me.pnlBucar.Controls.Add(Me.Panel9)
        Me.pnlBucar.Location = New System.Drawing.Point(379, 12)
        Me.pnlBucar.Name = "pnlBucar"
        Me.pnlBucar.Size = New System.Drawing.Size(453, 432)
        Me.pnlBucar.TabIndex = 3
        '
        'MenuStrip5
        '
        Me.MenuStrip5.AutoSize = False
        Me.MenuStrip5.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip5.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip5.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem3})
        Me.MenuStrip5.Location = New System.Drawing.Point(10, 47)
        Me.MenuStrip5.Name = "MenuStrip5"
        Me.MenuStrip5.Size = New System.Drawing.Size(35, 24)
        Me.MenuStrip5.TabIndex = 29
        Me.MenuStrip5.Text = "MenuStrip5"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.AutoSize = False
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(28, 20)
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(46, 48)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(285, 20)
        Me.TextBox8.TabIndex = 2
        '
        'grdCliente
        '
        Me.grdCliente.AllowUserToAddRows = False
        Me.grdCliente.AllowUserToDeleteRows = False
        Me.grdCliente.BackgroundColor = System.Drawing.Color.White
        Me.grdCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre})
        Me.grdCliente.Location = New System.Drawing.Point(8, 80)
        Me.grdCliente.Name = "grdCliente"
        Me.grdCliente.ReadOnly = True
        Me.grdCliente.Size = New System.Drawing.Size(436, 342)
        Me.grdCliente.TabIndex = 1
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Black
        Me.Panel9.Controls.Add(Me.Button1)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(451, 37)
        Me.Panel9.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(406, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 37)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpReservacion
        '
        Me.grpReservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpReservacion.Controls.Add(Me.Panel2)
        Me.grpReservacion.Controls.Add(Me.TextBox1)
        Me.grpReservacion.Controls.Add(Me.Label2)
        Me.grpReservacion.Controls.Add(Me.MenuStrip8)
        Me.grpReservacion.Controls.Add(Me.MenuStrip7)
        Me.grpReservacion.Controls.Add(Me.Label4)
        Me.grpReservacion.Controls.Add(Me.Panel3)
        Me.grpReservacion.Controls.Add(Me.txtTipo)
        Me.grpReservacion.Controls.Add(Me.DateEntrada)
        Me.grpReservacion.Controls.Add(Me.DateSalida)
        Me.grpReservacion.Controls.Add(Me.Panel1)
        Me.grpReservacion.Controls.Add(Me.MenuStrip6)
        Me.grpReservacion.Controls.Add(Me.Label1)
        Me.grpReservacion.Controls.Add(Me.Panel8)
        Me.grpReservacion.Controls.Add(Me.txtEmpleado)
        Me.grpReservacion.Controls.Add(Me.Label8)
        Me.grpReservacion.Controls.Add(Me.Panel7)
        Me.grpReservacion.Controls.Add(Me.txtCliente)
        Me.grpReservacion.Controls.Add(Me.Label7)
        Me.grpReservacion.Controls.Add(Me.Panel6)
        Me.grpReservacion.Controls.Add(Me.txtPrecio)
        Me.grpReservacion.Controls.Add(Me.Panel5)
        Me.grpReservacion.Controls.Add(Me.txtCapacidad)
        Me.grpReservacion.Controls.Add(Me.Panel4)
        Me.grpReservacion.Controls.Add(Me.Label6)
        Me.grpReservacion.Controls.Add(Me.Label5)
        Me.grpReservacion.Controls.Add(Me.Label3)
        Me.grpReservacion.Controls.Add(Me.MenuStrip3)
        Me.grpReservacion.Controls.Add(Me.buttton)
        Me.grpReservacion.Controls.Add(Me.MenuStrip4)
        Me.grpReservacion.Location = New System.Drawing.Point(15, 12)
        Me.grpReservacion.Name = "grpReservacion"
        Me.grpReservacion.Size = New System.Drawing.Size(358, 471)
        Me.grpReservacion.TabIndex = 2
        Me.grpReservacion.TabStop = False
        Me.grpReservacion.Text = "Datos de reservacion"
        '
        'DateEntrada
        '
        Me.DateEntrada.Location = New System.Drawing.Point(108, 159)
        Me.DateEntrada.Name = "DateEntrada"
        Me.DateEntrada.Size = New System.Drawing.Size(165, 20)
        Me.DateEntrada.TabIndex = 31
        '
        'DateSalida
        '
        Me.DateSalida.Location = New System.Drawing.Point(108, 201)
        Me.DateSalida.Name = "DateSalida"
        Me.DateSalida.Size = New System.Drawing.Size(165, 20)
        Me.DateSalida.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(108, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 1)
        Me.Panel1.TabIndex = 13
        '
        'MenuStrip6
        '
        Me.MenuStrip6.AutoSize = False
        Me.MenuStrip6.BackColor = System.Drawing.Color.Black
        Me.MenuStrip6.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip6.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEditar})
        Me.MenuStrip6.Location = New System.Drawing.Point(130, 413)
        Me.MenuStrip6.Name = "MenuStrip6"
        Me.MenuStrip6.Size = New System.Drawing.Size(78, 28)
        Me.MenuStrip6.TabIndex = 29
        Me.MenuStrip6.Text = "MenuStrip6"
        '
        'btnEditar
        '
        Me.btnEditar.BackColor = System.Drawing.Color.Black
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(72, 24)
        Me.btnEditar.Text = "Editar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Salida:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(108, 91)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(165, 1)
        Me.Panel8.TabIndex = 28
        '
        'txtEmpleado
        '
        Me.txtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpleado.Location = New System.Drawing.Point(108, 70)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(165, 17)
        Me.txtEmpleado.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Empleado:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(107, 44)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(165, 1)
        Me.Panel7.TabIndex = 17
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(107, 23)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(165, 17)
        Me.txtCliente.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cliente:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(108, 307)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(165, 1)
        Me.Panel6.TabIndex = 14
        '
        'txtPrecio
        '
        Me.txtPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(108, 286)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(165, 17)
        Me.txtPrecio.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(108, 181)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(165, 1)
        Me.Panel4.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 285)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "SubTotal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Entrada:"
        '
        'MenuStrip3
        '
        Me.MenuStrip3.AutoSize = False
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarCliente})
        Me.MenuStrip3.Location = New System.Drawing.Point(276, 22)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(38, 24)
        Me.MenuStrip3.TabIndex = 18
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.AutoSize = False
        Me.btnBuscarCliente.Image = CType(resources.GetObject("btnBuscarCliente.Image"), System.Drawing.Image)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(28, 20)
        '
        'buttton
        '
        Me.buttton.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttton.AutoSize = False
        Me.buttton.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.buttton.Dock = System.Windows.Forms.DockStyle.None
        Me.buttton.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttton.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregar})
        Me.buttton.Location = New System.Drawing.Point(15, 413)
        Me.buttton.Name = "buttton"
        Me.buttton.Size = New System.Drawing.Size(91, 28)
        Me.buttton.TabIndex = 22
        Me.buttton.Text = "MenuStrip4"
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.Image = CType(resources.GetObject("btnAgregar.Image"), System.Drawing.Image)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(80, 24)
        Me.btnAgregar.Text = " Nuevo"
        '
        'MenuStrip4
        '
        Me.MenuStrip4.AutoSize = False
        Me.MenuStrip4.BackColor = System.Drawing.Color.Black
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar})
        Me.MenuStrip4.Location = New System.Drawing.Point(231, 413)
        Me.MenuStrip4.Name = "MenuStrip4"
        Me.MenuStrip4.Size = New System.Drawing.Size(100, 28)
        Me.MenuStrip4.TabIndex = 24
        Me.MenuStrip4.Text = "MenuStrip4"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Black
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 24)
        Me.btnCancelar.Text = " Cancelar"
        '
        'grpMostrar
        '
        Me.grpMostrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMostrar.Controls.Add(Me.MenuStrip2)
        Me.grpMostrar.Controls.Add(Me.txtBuscar)
        Me.grpMostrar.Controls.Add(Me.grdHabitaciones)
        Me.grpMostrar.Controls.Add(Me.MenuStrip1)
        Me.grpMostrar.Location = New System.Drawing.Point(379, 12)
        Me.grpMostrar.Name = "grpMostrar"
        Me.grpMostrar.Size = New System.Drawing.Size(453, 471)
        Me.grpMostrar.TabIndex = 1
        Me.grpMostrar.TabStop = False
        Me.grpMostrar.Text = "Listado de reservaciones"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AutoSize = False
        Me.MenuStrip2.BackColor = System.Drawing.Color.White
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Enabled = False
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(8, 13)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(36, 33)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 29)
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(47, 18)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(389, 22)
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
        Me.grdHabitaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idHabitacion, Me.Codigo, Me.Entrada, Me.Salida, Me.Estado, Me.Tipo, Me.Capacidad, Me.Precio})
        Me.grdHabitaciones.Location = New System.Drawing.Point(17, 53)
        Me.grdHabitaciones.Name = "grdHabitaciones"
        Me.grdHabitaciones.ReadOnly = True
        Me.grdHabitaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdHabitaciones.Size = New System.Drawing.Size(419, 379)
        Me.grdHabitaciones.TabIndex = 0
        '
        'idHabitacion
        '
        Me.idHabitacion.DataPropertyName = "idHabitacion"
        Me.idHabitacion.HeaderText = "idHabitacion"
        Me.idHabitacion.Name = "idHabitacion"
        Me.idHabitacion.ReadOnly = True
        Me.idHabitacion.Visible = False
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "Codigo"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Entrada
        '
        Me.Entrada.DataPropertyName = "Entrada"
        Me.Entrada.HeaderText = "Entrada"
        Me.Entrada.Name = "Entrada"
        Me.Entrada.ReadOnly = True
        Me.Entrada.Visible = False
        '
        'Salida
        '
        Me.Salida.DataPropertyName = "Salida"
        Me.Salida.HeaderText = "Salida"
        Me.Salida.Name = "Salida"
        Me.Salida.ReadOnly = True
        Me.Salida.Visible = False
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "TipoHabit"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Capacidad
        '
        Me.Capacidad.DataPropertyName = "Capacidad"
        Me.Capacidad.HeaderText = "Capacidad"
        Me.Capacidad.Name = "Capacidad"
        Me.Capacidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.DataPropertyName = "Precio"
        Me.Precio.HeaderText = "Precio"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(17, 435)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(131, 28)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(123, 24)
        Me.ToolStripMenuItem2.Text = " Realizar pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(-1, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Habitacion:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(108, 134)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(165, 1)
        Me.Panel3.TabIndex = 33
        '
        'txtTipo
        '
        Me.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTipo.Enabled = False
        Me.txtTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(108, 113)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(165, 17)
        Me.txtTipo.TabIndex = 32
        '
        'MenuStrip7
        '
        Me.MenuStrip7.AutoSize = False
        Me.MenuStrip7.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip7.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip7.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4})
        Me.MenuStrip7.Location = New System.Drawing.Point(276, 115)
        Me.MenuStrip7.Name = "MenuStrip7"
        Me.MenuStrip7.Size = New System.Drawing.Size(38, 24)
        Me.MenuStrip7.TabIndex = 35
        Me.MenuStrip7.Text = "MenuStrip7"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.AutoSize = False
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(28, 20)
        '
        'MenuStrip8
        '
        Me.MenuStrip8.AutoSize = False
        Me.MenuStrip8.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip8.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip8.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5})
        Me.MenuStrip8.Location = New System.Drawing.Point(276, 70)
        Me.MenuStrip8.Name = "MenuStrip8"
        Me.MenuStrip8.Size = New System.Drawing.Size(38, 24)
        Me.MenuStrip8.TabIndex = 36
        Me.MenuStrip8.Text = "MenuStrip8"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.AutoSize = False
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(28, 20)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dias:"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCapacidad.Enabled = False
        Me.txtCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidad.Location = New System.Drawing.Point(108, 244)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(165, 17)
        Me.txtCapacidad.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(108, 265)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(165, 1)
        Me.Panel5.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(108, 353)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 1)
        Me.Panel2.TabIndex = 39
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(108, 332)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(165, 17)
        Me.TextBox1.TabIndex = 38
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(45, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Total:"
        '
        'FormReservaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 495)
        Me.Controls.Add(Me.pnlReservacion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReservaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservaciones"
        Me.pnlReservacion.ResumeLayout(False)
        Me.pnlBucar.ResumeLayout(False)
        Me.pnlBucar.PerformLayout()
        Me.MenuStrip5.ResumeLayout(False)
        Me.MenuStrip5.PerformLayout()
        CType(Me.grdCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.grpReservacion.ResumeLayout(False)
        Me.grpReservacion.PerformLayout()
        Me.MenuStrip6.ResumeLayout(False)
        Me.MenuStrip6.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.buttton.ResumeLayout(False)
        Me.buttton.PerformLayout()
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.grpMostrar.ResumeLayout(False)
        Me.grpMostrar.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.grdHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip7.ResumeLayout(False)
        Me.MenuStrip7.PerformLayout()
        Me.MenuStrip8.ResumeLayout(False)
        Me.MenuStrip8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlReservacion As Panel
    Friend WithEvents grpReservacion As GroupBox
    Friend WithEvents Panel8 As Panel
    Friend WithEvents txtEmpleado As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents btnBuscarCliente As ToolStripMenuItem
    Friend WithEvents buttton As MenuStrip
    Friend WithEvents btnAgregar As ToolStripMenuItem
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents btnCancelar As ToolStripMenuItem
    Friend WithEvents grpMostrar As GroupBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents grdHabitaciones As DataGridView
    Friend WithEvents pnlBucar As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents MenuStrip5 As MenuStrip
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents grdCliente As DataGridView
    Friend WithEvents MenuStrip6 As MenuStrip
    Friend WithEvents btnEditar As ToolStripMenuItem
    Friend WithEvents DateEntrada As DateTimePicker
    Friend WithEvents DateSalida As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents idHabitacion As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Entrada As DataGridViewTextBoxColumn
    Friend WithEvents Salida As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Capacidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip8 As MenuStrip
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents MenuStrip7 As MenuStrip
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtTipo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents Label5 As Label
End Class
