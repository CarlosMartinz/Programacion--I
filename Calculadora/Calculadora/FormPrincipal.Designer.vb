<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeHabitacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnAlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlReservacion = New System.Windows.Forms.Panel()
        Me.grpReservacion = New System.Windows.Forms.GroupBox()
        Me.butttm = New System.Windows.Forms.MenuStrip()
        Me.btnEditar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.btnBuscarCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.buttton = New System.Windows.Forms.MenuStrip()
        Me.btnAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpMostrar = New System.Windows.Forms.GroupBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip4 = New System.Windows.Forms.MenuStrip()
        Me.btnCancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlReservacion.SuspendLayout()
        Me.grpReservacion.SuspendLayout()
        Me.butttm.SuspendLayout()
        Me.MenuStrip3.SuspendLayout()
        Me.buttton.SuspendLayout()
        Me.grpMostrar.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.RegistrosToolStripMenuItem, Me.ToolStripMenuItem2})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(808, 43)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivoToolStripMenuItem.Image = CType(resources.GetObject("ArchivoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ArchivoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(99, 39)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.cerrar_sesion
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaToolStripMenuItem.Image = CType(resources.GetObject("EmpresaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpresaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(106, 39)
        Me.EmpresaToolStripMenuItem.Text = "Reportes"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeUsuariosToolStripMenuItem, Me.RegistrosDeClientesToolStripMenuItem, Me.RegistroDeHabitacionesToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.EnAlmacenToolStripMenuItem})
        Me.RegistrosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegistrosToolStripMenuItem.Image = CType(resources.GetObject("RegistrosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegistrosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RegistrosToolStripMenuItem.Name = "RegistrosToolStripMenuItem"
        Me.RegistrosToolStripMenuItem.Size = New System.Drawing.Size(109, 39)
        Me.RegistrosToolStripMenuItem.Text = "Registros"
        '
        'RegistroDeUsuariosToolStripMenuItem
        '
        Me.RegistroDeUsuariosToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Usuarios
        Me.RegistroDeUsuariosToolStripMenuItem.Name = "RegistroDeUsuariosToolStripMenuItem"
        Me.RegistroDeUsuariosToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.RegistroDeUsuariosToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.RegistroDeUsuariosToolStripMenuItem.Text = "Registro de usuarios"
        '
        'RegistrosDeClientesToolStripMenuItem
        '
        Me.RegistrosDeClientesToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Cliente
        Me.RegistrosDeClientesToolStripMenuItem.Name = "RegistrosDeClientesToolStripMenuItem"
        Me.RegistrosDeClientesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.RegistrosDeClientesToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.RegistrosDeClientesToolStripMenuItem.Text = "Registro de clientes"
        '
        'RegistroDeHabitacionesToolStripMenuItem
        '
        Me.RegistroDeHabitacionesToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Habitaciones
        Me.RegistroDeHabitacionesToolStripMenuItem.Name = "RegistroDeHabitacionesToolStripMenuItem"
        Me.RegistroDeHabitacionesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.RegistroDeHabitacionesToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.RegistroDeHabitacionesToolStripMenuItem.Text = "Registro de habitaciones"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Proveedor
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'EnAlmacenToolStripMenuItem
        '
        Me.EnAlmacenToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Bodega
        Me.EnAlmacenToolStripMenuItem.Name = "EnAlmacenToolStripMenuItem"
        Me.EnAlmacenToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.EnAlmacenToolStripMenuItem.Text = "En almacen"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(139, 39)
        Me.ToolStripMenuItem2.Text = "Reservaciones"
        '
        'pnlReservacion
        '
        Me.pnlReservacion.BackColor = System.Drawing.Color.White
        Me.pnlReservacion.Controls.Add(Me.grpReservacion)
        Me.pnlReservacion.Controls.Add(Me.grpMostrar)
        Me.pnlReservacion.Controls.Add(Me.Panel2)
        Me.pnlReservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReservacion.Location = New System.Drawing.Point(0, 43)
        Me.pnlReservacion.Name = "pnlReservacion"
        Me.pnlReservacion.Size = New System.Drawing.Size(808, 468)
        Me.pnlReservacion.TabIndex = 3
        '
        'grpReservacion
        '
        Me.grpReservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpReservacion.Controls.Add(Me.butttm)
        Me.grpReservacion.Controls.Add(Me.Panel7)
        Me.grpReservacion.Controls.Add(Me.TextBox6)
        Me.grpReservacion.Controls.Add(Me.Label7)
        Me.grpReservacion.Controls.Add(Me.Panel6)
        Me.grpReservacion.Controls.Add(Me.TextBox5)
        Me.grpReservacion.Controls.Add(Me.Panel5)
        Me.grpReservacion.Controls.Add(Me.TextBox4)
        Me.grpReservacion.Controls.Add(Me.Panel4)
        Me.grpReservacion.Controls.Add(Me.TextBox2)
        Me.grpReservacion.Controls.Add(Me.Label6)
        Me.grpReservacion.Controls.Add(Me.Label5)
        Me.grpReservacion.Controls.Add(Me.Label4)
        Me.grpReservacion.Controls.Add(Me.Label3)
        Me.grpReservacion.Controls.Add(Me.Panel3)
        Me.grpReservacion.Controls.Add(Me.TextBox3)
        Me.grpReservacion.Controls.Add(Me.Panel1)
        Me.grpReservacion.Controls.Add(Me.Label2)
        Me.grpReservacion.Controls.Add(Me.txtId)
        Me.grpReservacion.Controls.Add(Me.MenuStrip3)
        Me.grpReservacion.Controls.Add(Me.buttton)
        Me.grpReservacion.Controls.Add(Me.MenuStrip4)
        Me.grpReservacion.Location = New System.Drawing.Point(15, 49)
        Me.grpReservacion.Name = "grpReservacion"
        Me.grpReservacion.Size = New System.Drawing.Size(358, 407)
        Me.grpReservacion.TabIndex = 2
        Me.grpReservacion.TabStop = False
        Me.grpReservacion.Text = "Datos de reservacion"
        '
        'butttm
        '
        Me.butttm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butttm.AutoSize = False
        Me.butttm.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.butttm.Dock = System.Windows.Forms.DockStyle.None
        Me.butttm.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butttm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEditar})
        Me.butttm.Location = New System.Drawing.Point(123, 358)
        Me.butttm.Name = "butttm"
        Me.butttm.Size = New System.Drawing.Size(91, 28)
        Me.butttm.TabIndex = 23
        Me.butttm.Text = "Editar"
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(72, 24)
        Me.btnEditar.Text = "Editar"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(110, 92)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(165, 1)
        Me.Panel7.TabIndex = 17
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(110, 71)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(165, 17)
        Me.TextBox6.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cliente:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(111, 315)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(165, 1)
        Me.Panel6.TabIndex = 14
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(111, 294)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(165, 17)
        Me.TextBox5.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(111, 254)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(165, 1)
        Me.Panel5.TabIndex = 12
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(111, 233)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(165, 17)
        Me.TextBox4.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(111, 138)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(165, 1)
        Me.Panel4.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(111, 117)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(165, 17)
        Me.TextBox2.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(42, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Capacidad:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(58, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Edificio:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(111, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(165, 1)
        Me.Panel3.TabIndex = 4
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(111, 176)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(165, 17)
        Me.TextBox3.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(111, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 1)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(69, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "N°:"
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(111, 27)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(165, 17)
        Me.txtId.TabIndex = 0
        '
        'MenuStrip3
        '
        Me.MenuStrip3.AutoSize = False
        Me.MenuStrip3.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip3.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnBuscarCliente})
        Me.MenuStrip3.Location = New System.Drawing.Point(289, 70)
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
        Me.buttton.Location = New System.Drawing.Point(11, 358)
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
        'grpMostrar
        '
        Me.grpMostrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMostrar.Controls.Add(Me.MenuStrip2)
        Me.grpMostrar.Controls.Add(Me.TextBox1)
        Me.grpMostrar.Controls.Add(Me.DataGridView1)
        Me.grpMostrar.Location = New System.Drawing.Point(379, 49)
        Me.grpMostrar.Name = "grpMostrar"
        Me.grpMostrar.Size = New System.Drawing.Size(413, 407)
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
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(47, 18)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(349, 22)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 53)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(379, 315)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.btnCerrar)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(808, 39)
        Me.Panel2.TabIndex = 0
        '
        'btnCerrar
        '
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.White
        Me.btnCerrar.Location = New System.Drawing.Point(760, 0)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(48, 39)
        Me.btnCerrar.TabIndex = 1
        Me.btnCerrar.Text = "X"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(746, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservaciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip4
        '
        Me.MenuStrip4.AutoSize = False
        Me.MenuStrip4.BackColor = System.Drawing.Color.Black
        Me.MenuStrip4.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCancelar})
        Me.MenuStrip4.Location = New System.Drawing.Point(227, 358)
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
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 511)
        Me.Controls.Add(Me.pnlReservacion)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hotel"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlReservacion.ResumeLayout(False)
        Me.grpReservacion.ResumeLayout(False)
        Me.grpReservacion.PerformLayout()
        Me.butttm.ResumeLayout(False)
        Me.butttm.PerformLayout()
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.buttton.ResumeLayout(False)
        Me.buttton.PerformLayout()
        Me.grpMostrar.ResumeLayout(False)
        Me.grpMostrar.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.MenuStrip4.ResumeLayout(False)
        Me.MenuStrip4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrosDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeHabitacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EnAlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlReservacion As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents grpMostrar As GroupBox
    Friend WithEvents grpReservacion As GroupBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents btnBuscarCliente As ToolStripMenuItem
    Friend WithEvents buttton As MenuStrip
    Friend WithEvents btnAgregar As ToolStripMenuItem
    Friend WithEvents butttm As MenuStrip
    Friend WithEvents btnEditar As ToolStripMenuItem
    Friend WithEvents MenuStrip4 As MenuStrip
    Friend WithEvents btnCancelar As ToolStripMenuItem
End Class
