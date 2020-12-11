<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPago))
        Dim Fecha_vtaLabel As System.Windows.Forms.Label
        Dim IdTipofacturaLabel As System.Windows.Forms.Label
        Dim NfacturaLabel As System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cboFactu = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNumReser = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Fecha_vtaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTipofacturaComboBox = New System.Windows.Forms.ComboBox()
        Me.NfacturaTextBox = New System.Windows.Forms.TextBox()
        Me.grbdVentasProductos = New System.Windows.Forms.GroupBox()
        Me.btnQuitarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblnregistros = New System.Windows.Forms.Label()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblRespuestaTotal = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.lblRespuestaIva = New System.Windows.Forms.Label()
        Me.lbliva = New System.Windows.Forms.Label()
        Me.lblRespuestaSuma = New System.Windows.Forms.Label()
        Me.lblsuma = New System.Windows.Forms.Label()
        Me.lblReservacionTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Fecha_vtaLabel = New System.Windows.Forms.Label()
        IdTipofacturaLabel = New System.Windows.Forms.Label()
        NfacturaLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbdVentasProductos.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 119)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(750, 228)
        Me.DataGridView1.TabIndex = 0
        '
        'cboFactu
        '
        Me.cboFactu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFactu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFactu.FormattingEnabled = True
        Me.cboFactu.Location = New System.Drawing.Point(639, 78)
        Me.cboFactu.Name = "cboFactu"
        Me.cboFactu.Size = New System.Drawing.Size(121, 21)
        Me.cboFactu.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(556, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Forma de pago:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "N° Reservacion:"
        '
        'lblNumReser
        '
        Me.lblNumReser.AutoSize = True
        Me.lblNumReser.Location = New System.Drawing.Point(104, 9)
        Me.lblNumReser.Name = "lblNumReser"
        Me.lblNumReser.Size = New System.Drawing.Size(0, 13)
        Me.lblNumReser.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.grbdVentasProductos)
        Me.Panel1.Controls.Add(Me.grbEdicion)
        Me.Panel1.Controls.Add(NfacturaLabel)
        Me.Panel1.Controls.Add(Me.grbNavegacion)
        Me.Panel1.Controls.Add(IdTipofacturaLabel)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.NfacturaTextBox)
        Me.Panel1.Controls.Add(Me.IdTipofacturaComboBox)
        Me.Panel1.Controls.Add(Fecha_vtaLabel)
        Me.Panel1.Controls.Add(Me.Fecha_vtaDateTimePicker)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cboFactu)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(774, 511)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(772, 31)
        Me.Panel2.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(103, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(209, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 27)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Fecha_vtaLabel
        '
        Fecha_vtaLabel.AutoSize = True
        Fecha_vtaLabel.Location = New System.Drawing.Point(12, 82)
        Fecha_vtaLabel.Name = "Fecha_vtaLabel"
        Fecha_vtaLabel.Size = New System.Drawing.Size(59, 13)
        Fecha_vtaLabel.TabIndex = 7
        Fecha_vtaLabel.Text = "Fecha Vta:"
        '
        'Fecha_vtaDateTimePicker
        '
        Me.Fecha_vtaDateTimePicker.Enabled = False
        Me.Fecha_vtaDateTimePicker.Location = New System.Drawing.Point(75, 79)
        Me.Fecha_vtaDateTimePicker.Name = "Fecha_vtaDateTimePicker"
        Me.Fecha_vtaDateTimePicker.Size = New System.Drawing.Size(213, 20)
        Me.Fecha_vtaDateTimePicker.TabIndex = 8
        '
        'IdTipofacturaLabel
        '
        IdTipofacturaLabel.AutoSize = True
        IdTipofacturaLabel.Location = New System.Drawing.Point(305, 82)
        IdTipofacturaLabel.Name = "IdTipofacturaLabel"
        IdTipofacturaLabel.Size = New System.Drawing.Size(67, 13)
        IdTipofacturaLabel.TabIndex = 11
        IdTipofacturaLabel.Text = "Tipo factura:"
        '
        'IdTipofacturaComboBox
        '
        Me.IdTipofacturaComboBox.DisplayMember = "tipofactura"
        Me.IdTipofacturaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdTipofacturaComboBox.Enabled = False
        Me.IdTipofacturaComboBox.FormattingEnabled = True
        Me.IdTipofacturaComboBox.Location = New System.Drawing.Point(375, 78)
        Me.IdTipofacturaComboBox.Name = "IdTipofacturaComboBox"
        Me.IdTipofacturaComboBox.Size = New System.Drawing.Size(152, 21)
        Me.IdTipofacturaComboBox.TabIndex = 12
        Me.IdTipofacturaComboBox.ValueMember = "idTipofactura"
        '
        'NfacturaLabel
        '
        NfacturaLabel.AutoSize = True
        NfacturaLabel.Location = New System.Drawing.Point(581, 43)
        NfacturaLabel.Name = "NfacturaLabel"
        NfacturaLabel.Size = New System.Drawing.Size(69, 13)
        NfacturaLabel.TabIndex = 6
        NfacturaLabel.Text = "Factura: No.:"
        '
        'NfacturaTextBox
        '
        Me.NfacturaTextBox.Location = New System.Drawing.Point(656, 40)
        Me.NfacturaTextBox.Name = "NfacturaTextBox"
        Me.NfacturaTextBox.ReadOnly = True
        Me.NfacturaTextBox.Size = New System.Drawing.Size(106, 20)
        Me.NfacturaTextBox.TabIndex = 7
        '
        'grbdVentasProductos
        '
        Me.grbdVentasProductos.Controls.Add(Me.btnQuitarProducto)
        Me.grbdVentasProductos.Controls.Add(Me.btnAgregarProducto)
        Me.grbdVentasProductos.Location = New System.Drawing.Point(12, 373)
        Me.grbdVentasProductos.Name = "grbdVentasProductos"
        Me.grbdVentasProductos.Size = New System.Drawing.Size(352, 50)
        Me.grbdVentasProductos.TabIndex = 22
        Me.grbdVentasProductos.TabStop = False
        Me.grbdVentasProductos.Visible = False
        '
        'btnQuitarProducto
        '
        Me.btnQuitarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarProducto.Location = New System.Drawing.Point(177, 13)
        Me.btnQuitarProducto.Name = "btnQuitarProducto"
        Me.btnQuitarProducto.Size = New System.Drawing.Size(165, 31)
        Me.btnQuitarProducto.TabIndex = 10
        Me.btnQuitarProducto.Text = "Quitar Productos"
        Me.btnQuitarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Location = New System.Drawing.Point(6, 13)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(165, 31)
        Me.btnAgregarProducto.TabIndex = 9
        Me.btnAgregarProducto.Text = "Agregar Productos"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnImprimir)
        Me.grbEdicion.Controls.Add(Me.btnBuscar)
        Me.grbEdicion.Controls.Add(Me.btnEliminar)
        Me.grbEdicion.Controls.Add(Me.btnModificar)
        Me.grbEdicion.Controls.Add(Me.btnAgregar)
        Me.grbEdicion.Location = New System.Drawing.Point(218, 452)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(375, 47)
        Me.grbEdicion.TabIndex = 21
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnImprimir
        '
        Me.btnImprimir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.Location = New System.Drawing.Point(299, 12)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 31)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.Location = New System.Drawing.Point(231, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(69, 31)
        Me.btnBuscar.TabIndex = 8
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(157, 12)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 31)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(77, 12)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(81, 31)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(2, 12)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(76, 31)
        Me.btnAgregar.TabIndex = 5
        Me.btnAgregar.Text = "Nuevo"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblnregistros)
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Location = New System.Drawing.Point(12, 452)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(200, 47)
        Me.grbNavegacion.TabIndex = 20
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblnregistros
        '
        Me.lblnregistros.AutoSize = True
        Me.lblnregistros.Location = New System.Drawing.Point(72, 22)
        Me.lblnregistros.Name = "lblnregistros"
        Me.lblnregistros.Size = New System.Drawing.Size(36, 13)
        Me.lblnregistros.TabIndex = 4
        Me.lblnregistros.Text = "x de n"
        '
        'btnUltimo
        '
        Me.btnUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimo.Location = New System.Drawing.Point(160, 13)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(33, 31)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = ">|"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(128, 13)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(33, 31)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = ">"
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnterior.Location = New System.Drawing.Point(37, 13)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(33, 31)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "<"
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnPrimero
        '
        Me.btnPrimero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimero.Location = New System.Drawing.Point(5, 13)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(33, 31)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "|<"
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblRespuestaTotal)
        Me.Panel3.Controls.Add(Me.lbltotal)
        Me.Panel3.Controls.Add(Me.lblRespuestaIva)
        Me.Panel3.Controls.Add(Me.lbliva)
        Me.Panel3.Controls.Add(Me.lblRespuestaSuma)
        Me.Panel3.Controls.Add(Me.lblsuma)
        Me.Panel3.Controls.Add(Me.lblReservacionTotal)
        Me.Panel3.Location = New System.Drawing.Point(603, 356)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(159, 143)
        Me.Panel3.TabIndex = 19
        '
        'lblRespuestaTotal
        '
        Me.lblRespuestaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaTotal.Location = New System.Drawing.Point(77, 115)
        Me.lblRespuestaTotal.Name = "lblRespuestaTotal"
        Me.lblRespuestaTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaTotal.Size = New System.Drawing.Size(79, 22)
        Me.lblRespuestaTotal.TabIndex = 5
        Me.lblRespuestaTotal.Text = "00.00"
        Me.lblRespuestaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(8, 121)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(61, 16)
        Me.lbltotal.TabIndex = 4
        Me.lbltotal.Text = "TOTAL:"
        '
        'lblRespuestaIva
        '
        Me.lblRespuestaIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaIva.Location = New System.Drawing.Point(77, 44)
        Me.lblRespuestaIva.Name = "lblRespuestaIva"
        Me.lblRespuestaIva.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaIva.Size = New System.Drawing.Size(79, 16)
        Me.lblRespuestaIva.TabIndex = 3
        Me.lblRespuestaIva.Text = "00.00"
        Me.lblRespuestaIva.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbliva
        '
        Me.lbliva.AutoSize = True
        Me.lbliva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbliva.Location = New System.Drawing.Point(8, 44)
        Me.lbliva.Name = "lbliva"
        Me.lbliva.Size = New System.Drawing.Size(36, 16)
        Me.lbliva.TabIndex = 2
        Me.lbliva.Text = "IVA:"
        '
        'lblRespuestaSuma
        '
        Me.lblRespuestaSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRespuestaSuma.Location = New System.Drawing.Point(77, 9)
        Me.lblRespuestaSuma.Name = "lblRespuestaSuma"
        Me.lblRespuestaSuma.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRespuestaSuma.Size = New System.Drawing.Size(79, 16)
        Me.lblRespuestaSuma.TabIndex = 1
        Me.lblRespuestaSuma.Text = "00.00"
        Me.lblRespuestaSuma.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblsuma
        '
        Me.lblsuma.AutoSize = True
        Me.lblsuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsuma.Location = New System.Drawing.Point(8, 9)
        Me.lblsuma.Name = "lblsuma"
        Me.lblsuma.Size = New System.Drawing.Size(55, 16)
        Me.lblsuma.TabIndex = 0
        Me.lblsuma.Text = "SUMA:"
        '
        'lblReservacionTotal
        '
        Me.lblReservacionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReservacionTotal.Location = New System.Drawing.Point(80, 76)
        Me.lblReservacionTotal.Name = "lblReservacionTotal"
        Me.lblReservacionTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblReservacionTotal.Size = New System.Drawing.Size(76, 22)
        Me.lblReservacionTotal.TabIndex = 7
        Me.lblReservacionTotal.Text = "00.00"
        Me.lblReservacionTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "RESERV.:"
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(774, 31)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Facturacion"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(727, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(45, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(774, 511)
        Me.Controls.Add(Me.lblNumReser)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormPago"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbdVentasProductos.ResumeLayout(False)
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents cboFactu As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNumReser As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents grbdVentasProductos As GroupBox
    Friend WithEvents btnQuitarProducto As Button
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAgregar As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblnregistros As Label
    Friend WithEvents btnUltimo As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnPrimero As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblReservacionTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRespuestaTotal As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents lblRespuestaIva As Label
    Friend WithEvents lbliva As Label
    Friend WithEvents lblRespuestaSuma As Label
    Friend WithEvents lblsuma As Label
    Friend WithEvents NfacturaTextBox As TextBox
    Friend WithEvents IdTipofacturaComboBox As ComboBox
    Friend WithEvents Fecha_vtaDateTimePicker As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
End Class
