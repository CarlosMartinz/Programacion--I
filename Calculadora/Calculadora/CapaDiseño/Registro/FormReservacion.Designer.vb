<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReservacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.txtNumHab = New System.Windows.Forms.TextBox()
        Me.lblNumHab = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPosicion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.btnPrimero = New System.Windows.Forms.Button()
        Me.btnAnterior = New System.Windows.Forms.Button()
        Me.btnUltimo = New System.Windows.Forms.Button()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.grbControles = New System.Windows.Forms.GroupBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.grbInformacion = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.lblEstadia = New System.Windows.Forms.Label()
        Me.txtEstadia = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grbNavegacion.SuspendLayout()
        Me.grbControles.SuspendLayout()
        Me.grbInformacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(92, 181)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(60, 20)
        Me.lblDesde.TabIndex = 8
        Me.lblDesde.Text = "Desde:"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(96, 223)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(56, 20)
        Me.lblHasta.TabIndex = 2
        Me.lblHasta.Text = "Hasta:"
        '
        'txtNumHab
        '
        Me.txtNumHab.Location = New System.Drawing.Point(163, 99)
        Me.txtNumHab.Name = "txtNumHab"
        Me.txtNumHab.Size = New System.Drawing.Size(62, 20)
        Me.txtNumHab.TabIndex = 5
        '
        'lblNumHab
        '
        Me.lblNumHab.AutoSize = True
        Me.lblNumHab.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumHab.Location = New System.Drawing.Point(48, 99)
        Me.lblNumHab.Name = "lblNumHab"
        Me.lblNumHab.Size = New System.Drawing.Size(109, 20)
        Me.lblNumHab.TabIndex = 4
        Me.lblNumHab.Text = "N° Habitacion:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(164, 60)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(179, 20)
        Me.txtNombreCliente.TabIndex = 1
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.Location = New System.Drawing.Point(84, 58)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(69, 20)
        Me.lblNombreCliente.TabIndex = 0
        Me.lblNombreCliente.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reservaciones"
        '
        'lblPosicion
        '
        Me.lblPosicion.AutoSize = True
        Me.lblPosicion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosicion.Location = New System.Drawing.Point(103, 32)
        Me.lblPosicion.Name = "lblPosicion"
        Me.lblPosicion.Size = New System.Drawing.Size(44, 16)
        Me.lblPosicion.TabIndex = 4
        Me.lblPosicion.Text = "1 de n"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblPosicion)
        Me.grbNavegacion.Controls.Add(Me.btnPrimero)
        Me.grbNavegacion.Controls.Add(Me.btnAnterior)
        Me.grbNavegacion.Controls.Add(Me.btnUltimo)
        Me.grbNavegacion.Controls.Add(Me.btnSiguiente)
        Me.grbNavegacion.Location = New System.Drawing.Point(12, 345)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(263, 73)
        Me.grbNavegacion.TabIndex = 4
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'btnPrimero
        '
        Me.btnPrimero.Location = New System.Drawing.Point(4, 19)
        Me.btnPrimero.Name = "btnPrimero"
        Me.btnPrimero.Size = New System.Drawing.Size(51, 42)
        Me.btnPrimero.TabIndex = 0
        Me.btnPrimero.Text = "."
        Me.btnPrimero.UseVisualStyleBackColor = True
        '
        'btnAnterior
        '
        Me.btnAnterior.Location = New System.Drawing.Point(61, 19)
        Me.btnAnterior.Name = "btnAnterior"
        Me.btnAnterior.Size = New System.Drawing.Size(36, 42)
        Me.btnAnterior.TabIndex = 1
        Me.btnAnterior.Text = "."
        Me.btnAnterior.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUltimo.Location = New System.Drawing.Point(206, 19)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(51, 42)
        Me.btnUltimo.TabIndex = 3
        Me.btnUltimo.Text = "."
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(164, 19)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(36, 42)
        Me.btnSiguiente.TabIndex = 2
        Me.btnSiguiente.Text = "."
        Me.btnSiguiente.UseVisualStyleBackColor = True
        '
        'grbControles
        '
        Me.grbControles.Controls.Add(Me.btnBorrar)
        Me.grbControles.Controls.Add(Me.btnBuscar)
        Me.grbControles.Controls.Add(Me.btnAgregar)
        Me.grbControles.Controls.Add(Me.btnActualizar)
        Me.grbControles.Location = New System.Drawing.Point(279, 345)
        Me.grbControles.Name = "grbControles"
        Me.grbControles.Size = New System.Drawing.Size(211, 73)
        Me.grbControles.TabIndex = 5
        Me.grbControles.TabStop = False
        Me.grbControles.Text = "Controles"
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(163, 19)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(42, 42)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "."
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(107, 19)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(50, 42)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "."
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(5, 19)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(46, 42)
        Me.btnAgregar.TabIndex = 0
        Me.btnAgregar.Text = "."
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(57, 19)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(44, 42)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "."
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'grbInformacion
        '
        Me.grbInformacion.Controls.Add(Me.Label3)
        Me.grbInformacion.Controls.Add(Me.DateTimePicker2)
        Me.grbInformacion.Controls.Add(Me.DateTimePicker1)
        Me.grbInformacion.Controls.Add(Me.lblEstadia)
        Me.grbInformacion.Controls.Add(Me.txtEstadia)
        Me.grbInformacion.Controls.Add(Me.Button2)
        Me.grbInformacion.Controls.Add(Me.txtNumHab)
        Me.grbInformacion.Controls.Add(Me.lblDesde)
        Me.grbInformacion.Controls.Add(Me.txtNombreCliente)
        Me.grbInformacion.Controls.Add(Me.lblNombreCliente)
        Me.grbInformacion.Controls.Add(Me.lblHasta)
        Me.grbInformacion.Controls.Add(Me.lblNumHab)
        Me.grbInformacion.Enabled = False
        Me.grbInformacion.Location = New System.Drawing.Point(12, 36)
        Me.grbInformacion.Name = "grbInformacion"
        Me.grbInformacion.Size = New System.Drawing.Size(478, 303)
        Me.grbInformacion.TabIndex = 9
        Me.grbInformacion.TabStop = False
        Me.grbInformacion.Text = "Informacion"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(349, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Numero Reservacion"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(163, 223)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(205, 20)
        Me.DateTimePicker2.TabIndex = 13
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(163, 181)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(205, 20)
        Me.DateTimePicker1.TabIndex = 12
        '
        'lblEstadia
        '
        Me.lblEstadia.AutoSize = True
        Me.lblEstadia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadia.Location = New System.Drawing.Point(44, 141)
        Me.lblEstadia.Name = "lblEstadia"
        Me.lblEstadia.Size = New System.Drawing.Size(113, 20)
        Me.lblEstadia.TabIndex = 11
        Me.lblEstadia.Text = "Estadia (Días):"
        '
        'txtEstadia
        '
        Me.txtEstadia.Location = New System.Drawing.Point(163, 141)
        Me.txtEstadia.Name = "txtEstadia"
        Me.txtEstadia.Size = New System.Drawing.Size(114, 20)
        Me.txtEstadia.TabIndex = 10
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(349, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(91, 21)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Buscar Cliente"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'FormReservacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 450)
        Me.Controls.Add(Me.grbInformacion)
        Me.Controls.Add(Me.grbControles)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormReservacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reservaciones"
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbControles.ResumeLayout(False)
        Me.grbInformacion.ResumeLayout(False)
        Me.grbInformacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents txtNombreCliente As TextBox
    Friend WithEvents txtNumHab As TextBox
    Friend WithEvents lblNumHab As Label
    Friend WithEvents lblHasta As Label
    Friend WithEvents lblDesde As Label
    Friend WithEvents btnPrimero As Button
    Friend WithEvents btnAnterior As Button
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents btnUltimo As Button
    Friend WithEvents lblPosicion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents grbControles As GroupBox
    Friend WithEvents btnBorrar As Button
    Friend WithEvents grbInformacion As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblEstadia As Label
    Friend WithEvents txtEstadia As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label3 As Label
End Class
