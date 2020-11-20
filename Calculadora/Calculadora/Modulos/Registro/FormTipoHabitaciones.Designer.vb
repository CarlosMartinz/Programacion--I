<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTipoHabitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormTipoHabitaciones))
        Me.btnBuscarTipHabitacion = New System.Windows.Forms.Button()
        Me.btnEliminarTipHabitacion = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.btnModificarTipHabitacion = New System.Windows.Forms.Button()
        Me.lblRegistroTipoHab = New System.Windows.Forms.Label()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.btnPrimeroCategoria = New System.Windows.Forms.Button()
        Me.grbDatosTipoHab = New System.Windows.Forms.GroupBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grbNavegacionTipoHab = New System.Windows.Forms.GroupBox()
        Me.btnUltimoCategoria = New System.Windows.Forms.Button()
        Me.btnSiguienteCategoria = New System.Windows.Forms.Button()
        Me.btnAnteriorCategoria = New System.Windows.Forms.Button()
        Me.btnAgregarTipHabitacion = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.grbDatosTipoHab.SuspendLayout()
        Me.grbNavegacionTipoHab.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
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
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(87, 147)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(410, 20)
        Me.txtprecio.TabIndex = 14
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
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(87, 39)
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(410, 20)
        Me.txtdescripcion.TabIndex = 4
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
        'grbDatosTipoHab
        '
        Me.grbDatosTipoHab.Controls.Add(Me.txtCapacidad)
        Me.grbDatosTipoHab.Controls.Add(Me.txtdescripcion)
        Me.grbDatosTipoHab.Controls.Add(Me.Label2)
        Me.grbDatosTipoHab.Controls.Add(Me.TextBox6)
        Me.grbDatosTipoHab.Controls.Add(Me.Label3)
        Me.grbDatosTipoHab.Controls.Add(Me.Label7)
        Me.grbDatosTipoHab.Controls.Add(Me.txtprecio)
        Me.grbDatosTipoHab.Location = New System.Drawing.Point(12, 12)
        Me.grbDatosTipoHab.Name = "grbDatosTipoHab"
        Me.grbDatosTipoHab.Size = New System.Drawing.Size(552, 187)
        Me.grbDatosTipoHab.TabIndex = 31
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
        'grbNavegacionTipoHab
        '
        Me.grbNavegacionTipoHab.Controls.Add(Me.lblRegistroTipoHab)
        Me.grbNavegacionTipoHab.Controls.Add(Me.btnUltimoCategoria)
        Me.grbNavegacionTipoHab.Controls.Add(Me.btnSiguienteCategoria)
        Me.grbNavegacionTipoHab.Controls.Add(Me.btnAnteriorCategoria)
        Me.grbNavegacionTipoHab.Controls.Add(Me.btnPrimeroCategoria)
        Me.grbNavegacionTipoHab.Location = New System.Drawing.Point(10, 203)
        Me.grbNavegacionTipoHab.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacionTipoHab.Name = "grbNavegacionTipoHab"
        Me.grbNavegacionTipoHab.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacionTipoHab.Size = New System.Drawing.Size(237, 68)
        Me.grbNavegacionTipoHab.TabIndex = 33
        Me.grbNavegacionTipoHab.TabStop = False
        Me.grbNavegacionTipoHab.Text = "Navegacion"
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
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarTipHabitacion)
        Me.grbEdicion.Controls.Add(Me.btnEliminarTipHabitacion)
        Me.grbEdicion.Controls.Add(Me.btnModificarTipHabitacion)
        Me.grbEdicion.Controls.Add(Me.btnAgregarTipHabitacion)
        Me.grbEdicion.Location = New System.Drawing.Point(249, 203)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 32
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'FormTipoHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 278)
        Me.Controls.Add(Me.grbDatosTipoHab)
        Me.Controls.Add(Me.grbNavegacionTipoHab)
        Me.Controls.Add(Me.grbEdicion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FormTipoHabitaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormTipoHabitaciones"
        Me.grbDatosTipoHab.ResumeLayout(False)
        Me.grbDatosTipoHab.PerformLayout()
        Me.grbNavegacionTipoHab.ResumeLayout(False)
        Me.grbNavegacionTipoHab.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBuscarTipHabitacion As Button
    Friend WithEvents btnEliminarTipHabitacion As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents btnModificarTipHabitacion As Button
    Friend WithEvents lblRegistroTipoHab As Label
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents btnPrimeroCategoria As Button
    Friend WithEvents grbDatosTipoHab As GroupBox
    Friend WithEvents txtCapacidad As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents grbNavegacionTipoHab As GroupBox
    Friend WithEvents btnUltimoCategoria As Button
    Friend WithEvents btnSiguienteCategoria As Button
    Friend WithEvents btnAnteriorCategoria As Button
    Friend WithEvents btnAgregarTipHabitacion As Button
    Friend WithEvents grbEdicion As GroupBox
End Class
