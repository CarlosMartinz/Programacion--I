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
        Me.grpReservacion = New System.Windows.Forms.GroupBox()
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
        Me.grpMostrar = New System.Windows.Forms.GroupBox()
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
        Me.pnlReservacion.SuspendLayout()
        Me.grpReservacion.SuspendLayout()
        CType(Me.btnClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpMostrar.SuspendLayout()
        CType(Me.grdHabitaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlReservacion
        '
        Me.pnlReservacion.BackColor = System.Drawing.Color.White
        Me.pnlReservacion.Controls.Add(Me.grpReservacion)
        Me.pnlReservacion.Controls.Add(Me.grpMostrar)
        Me.pnlReservacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlReservacion.Location = New System.Drawing.Point(0, 0)
        Me.pnlReservacion.Name = "pnlReservacion"
        Me.pnlReservacion.Size = New System.Drawing.Size(848, 495)
        Me.pnlReservacion.TabIndex = 4
        '
        'grpReservacion
        '
        Me.grpReservacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpReservacion.Controls.Add(Me.txtTotal)
        Me.grpReservacion.Controls.Add(Me.txtDias)
        Me.grpReservacion.Controls.Add(Me.btnClientes)
        Me.grpReservacion.Controls.Add(Me.btnHabitaciones)
        Me.grpReservacion.Controls.Add(Me.Panel2)
        Me.grpReservacion.Controls.Add(Me.Label2)
        Me.grpReservacion.Controls.Add(Me.Label4)
        Me.grpReservacion.Controls.Add(Me.Panel3)
        Me.grpReservacion.Controls.Add(Me.txtHabitacion)
        Me.grpReservacion.Controls.Add(Me.DateEntrada)
        Me.grpReservacion.Controls.Add(Me.DateSalida)
        Me.grpReservacion.Controls.Add(Me.Panel1)
        Me.grpReservacion.Controls.Add(Me.Label1)
        Me.grpReservacion.Controls.Add(Me.Panel8)
        Me.grpReservacion.Controls.Add(Me.txtEmpleado)
        Me.grpReservacion.Controls.Add(Me.Label8)
        Me.grpReservacion.Controls.Add(Me.Panel7)
        Me.grpReservacion.Controls.Add(Me.txtCliente)
        Me.grpReservacion.Controls.Add(Me.Label7)
        Me.grpReservacion.Controls.Add(Me.Panel6)
        Me.grpReservacion.Controls.Add(Me.txtPrecioDia)
        Me.grpReservacion.Controls.Add(Me.Panel5)
        Me.grpReservacion.Controls.Add(Me.Panel4)
        Me.grpReservacion.Controls.Add(Me.Label6)
        Me.grpReservacion.Controls.Add(Me.Label5)
        Me.grpReservacion.Controls.Add(Me.Label3)
        Me.grpReservacion.Location = New System.Drawing.Point(15, 12)
        Me.grpReservacion.Name = "grpReservacion"
        Me.grpReservacion.Size = New System.Drawing.Size(358, 471)
        Me.grpReservacion.TabIndex = 2
        Me.grpReservacion.TabStop = False
        Me.grpReservacion.Text = "Datos de reservacion"
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(134, 332)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(165, 18)
        Me.txtTotal.TabIndex = 49
        Me.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDias
        '
        Me.txtDias.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDias.Location = New System.Drawing.Point(134, 239)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(166, 23)
        Me.txtDias.TabIndex = 48
        Me.txtDias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClientes
        '
        Me.btnClientes.Image = CType(resources.GetObject("btnClientes.Image"), System.Drawing.Image)
        Me.btnClientes.Location = New System.Drawing.Point(320, 15)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(25, 25)
        Me.btnClientes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnClientes.TabIndex = 44
        Me.btnClientes.TabStop = False
        '
        'btnHabitaciones
        '
        Me.btnHabitaciones.Image = CType(resources.GetObject("btnHabitaciones.Image"), System.Drawing.Image)
        Me.btnHabitaciones.Location = New System.Drawing.Point(320, 105)
        Me.btnHabitaciones.Name = "btnHabitaciones"
        Me.btnHabitaciones.Size = New System.Drawing.Size(25, 25)
        Me.btnHabitaciones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnHabitaciones.TabIndex = 43
        Me.btnHabitaciones.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(135, 353)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(165, 1)
        Me.Panel2.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(74, 332)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Total:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 20)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Habitacion:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(135, 134)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(165, 1)
        Me.Panel3.TabIndex = 33
        '
        'txtHabitacion
        '
        Me.txtHabitacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtHabitacion.Enabled = False
        Me.txtHabitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHabitacion.Location = New System.Drawing.Point(135, 113)
        Me.txtHabitacion.Name = "txtHabitacion"
        Me.txtHabitacion.Size = New System.Drawing.Size(165, 17)
        Me.txtHabitacion.TabIndex = 32
        '
        'DateEntrada
        '
        Me.DateEntrada.Location = New System.Drawing.Point(135, 159)
        Me.DateEntrada.Name = "DateEntrada"
        Me.DateEntrada.Size = New System.Drawing.Size(165, 20)
        Me.DateEntrada.TabIndex = 31
        '
        'DateSalida
        '
        Me.DateSalida.Location = New System.Drawing.Point(135, 201)
        Me.DateSalida.Name = "DateSalida"
        Me.DateSalida.Size = New System.Drawing.Size(165, 20)
        Me.DateSalida.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(135, 223)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(165, 1)
        Me.Panel1.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Salida:"
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Black
        Me.Panel8.Location = New System.Drawing.Point(135, 91)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(165, 1)
        Me.Panel8.TabIndex = 28
        '
        'txtEmpleado
        '
        Me.txtEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmpleado.Enabled = False
        Me.txtEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpleado.Location = New System.Drawing.Point(135, 70)
        Me.txtEmpleado.Name = "txtEmpleado"
        Me.txtEmpleado.Size = New System.Drawing.Size(165, 17)
        Me.txtEmpleado.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Empleado:"
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Black
        Me.Panel7.Location = New System.Drawing.Point(134, 44)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(165, 1)
        Me.Panel7.TabIndex = 17
        '
        'txtCliente
        '
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCliente.Enabled = False
        Me.txtCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.Location = New System.Drawing.Point(134, 23)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(165, 17)
        Me.txtCliente.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Cliente:"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(135, 307)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(165, 1)
        Me.Panel6.TabIndex = 14
        '
        'txtPrecioDia
        '
        Me.txtPrecioDia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPrecioDia.Enabled = False
        Me.txtPrecioDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioDia.Location = New System.Drawing.Point(135, 286)
        Me.txtPrecioDia.Name = "txtPrecioDia"
        Me.txtPrecioDia.Size = New System.Drawing.Size(165, 17)
        Me.txtPrecioDia.TabIndex = 13
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Black
        Me.Panel5.Location = New System.Drawing.Point(135, 265)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(165, 1)
        Me.Panel5.TabIndex = 12
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(135, 181)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(165, 1)
        Me.Panel4.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 288)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Precio por dia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(78, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Dias:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Entrada:"
        '
        'grpMostrar
        '
        Me.grpMostrar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpMostrar.Controls.Add(Me.txtBuscar)
        Me.grpMostrar.Controls.Add(Me.grdHabitaciones)
        Me.grpMostrar.Location = New System.Drawing.Point(379, 12)
        Me.grpMostrar.Name = "grpMostrar"
        Me.grpMostrar.Size = New System.Drawing.Size(453, 471)
        Me.grpMostrar.TabIndex = 1
        Me.grpMostrar.TabStop = False
        Me.grpMostrar.Text = "Listado de reservaciones"
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
        Me.grdHabitaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idHabitacion, Me.Codigo, Me.Entrada, Me.Salida, Me.Estado, Me.Tipo, Me.Capacidad, Me.Precio})
        Me.grdHabitaciones.Location = New System.Drawing.Point(17, 53)
        Me.grdHabitaciones.Name = "grdHabitaciones"
        Me.grdHabitaciones.ReadOnly = True
        Me.grdHabitaciones.RowHeadersVisible = False
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
        Me.grpReservacion.ResumeLayout(False)
        Me.grpReservacion.PerformLayout()
        CType(Me.btnClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpMostrar.ResumeLayout(False)
        Me.grpMostrar.PerformLayout()
        CType(Me.grdHabitaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlReservacion As Panel
    Friend WithEvents grpMostrar As GroupBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents grdHabitaciones As DataGridView
    Friend WithEvents idHabitacion As DataGridViewTextBoxColumn
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Entrada As DataGridViewTextBoxColumn
    Friend WithEvents Salida As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Capacidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents grpReservacion As GroupBox
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
End Class
