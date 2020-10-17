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
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtcapacidad = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarTipHabitacion = New System.Windows.Forms.Button()
        Me.btnEliminarTipHabitacion = New System.Windows.Forms.Button()
        Me.btnModificarTipHabitacion = New System.Windows.Forms.Button()
        Me.btnAgregarTipHabitacion = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosCategoria = New System.Windows.Forms.Label()
        Me.btnUltimoCategoria = New System.Windows.Forms.Button()
        Me.btnSiguienteCategoria = New System.Windows.Forms.Button()
        Me.btnAnteriorCategoria = New System.Windows.Forms.Button()
        Me.btnPrimeroCategoria = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grbDatos.Location = New System.Drawing.Point(12, 12)
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
        'txtprecio
        '
        Me.txtprecio.Location = New System.Drawing.Point(87, 147)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(410, 20)
        Me.txtprecio.TabIndex = 14
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
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorCategoria)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroCategoria)
        Me.grbNavegacion.Location = New System.Drawing.Point(10, 203)
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
        'FormHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 282)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "FormHabitaciones"
        Me.Text = "FormHabitaciones"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtcapacidad As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarTipHabitacion As Button
    Friend WithEvents btnEliminarTipHabitacion As Button
    Friend WithEvents btnModificarTipHabitacion As Button
    Friend WithEvents btnAgregarTipHabitacion As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosCategoria As Label
    Friend WithEvents btnUltimoCategoria As Button
    Friend WithEvents btnSiguienteCategoria As Button
    Friend WithEvents btnAnteriorCategoria As Button
    Friend WithEvents btnPrimeroCategoria As Button
End Class
