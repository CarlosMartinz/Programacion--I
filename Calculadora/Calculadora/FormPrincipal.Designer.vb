<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListaEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListaDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ListaHabitacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReservacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeFacturasPorClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrosDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeHabitacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnAlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
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
        Me.EmpresaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeClientesToolStripMenuItem, Me.ToolStripMenuItem1, Me.ListaEmpleadosToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.ToolStripMenuItem3, Me.ListaDeProductosToolStripMenuItem, Me.ToolStripMenuItem4, Me.ListaHabitacionesToolStripMenuItem, Me.ToolStripMenuItem5, Me.ReservacionesToolStripMenuItem, Me.VentasToolStripMenuItem, Me.TiposDeFacturasPorClientesToolStripMenuItem})
        Me.EmpresaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpresaToolStripMenuItem.Image = CType(resources.GetObject("EmpresaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmpresaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(106, 39)
        Me.EmpresaToolStripMenuItem.Text = "Reportes"
        '
        'ListaDeClientesToolStripMenuItem
        '
        Me.ListaDeClientesToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Cliente
        Me.ListaDeClientesToolStripMenuItem.Name = "ListaDeClientesToolStripMenuItem"
        Me.ListaDeClientesToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ListaDeClientesToolStripMenuItem.Text = "Lista de Clientes"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(259, 6)
        '
        'ListaEmpleadosToolStripMenuItem
        '
        Me.ListaEmpleadosToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Usuarios
        Me.ListaEmpleadosToolStripMenuItem.Name = "ListaEmpleadosToolStripMenuItem"
        Me.ListaEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ListaEmpleadosToolStripMenuItem.Text = "Lista Empleados"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(259, 6)
        '
        'ListaDeProductosToolStripMenuItem
        '
        Me.ListaDeProductosToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Beer_Bottle_icon_icons1
        Me.ListaDeProductosToolStripMenuItem.Name = "ListaDeProductosToolStripMenuItem"
        Me.ListaDeProductosToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ListaDeProductosToolStripMenuItem.Text = "Lista de productos"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(259, 6)
        '
        'ListaHabitacionesToolStripMenuItem
        '
        Me.ListaHabitacionesToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Habitaciones
        Me.ListaHabitacionesToolStripMenuItem.Name = "ListaHabitacionesToolStripMenuItem"
        Me.ListaHabitacionesToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ListaHabitacionesToolStripMenuItem.Text = "Estado habitaciones"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(259, 6)
        '
        'ReservacionesToolStripMenuItem
        '
        Me.ReservacionesToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Reporte
        Me.ReservacionesToolStripMenuItem.Name = "ReservacionesToolStripMenuItem"
        Me.ReservacionesToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.ReservacionesToolStripMenuItem.Text = "Reservaciones"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'TiposDeFacturasPorClientesToolStripMenuItem
        '
        Me.TiposDeFacturasPorClientesToolStripMenuItem.Name = "TiposDeFacturasPorClientesToolStripMenuItem"
        Me.TiposDeFacturasPorClientesToolStripMenuItem.Size = New System.Drawing.Size(262, 22)
        Me.TiposDeFacturasPorClientesToolStripMenuItem.Text = "Tipos de Facturas por Clientes"
        '
        'RegistrosToolStripMenuItem
        '
        Me.RegistrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeUsuariosToolStripMenuItem, Me.RegistrosDeClientesToolStripMenuItem, Me.RegistroDeHabitacionesToolStripMenuItem, Me.EnAlmacenToolStripMenuItem})
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
        'EnAlmacenToolStripMenuItem
        '
        Me.EnAlmacenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem})
        Me.EnAlmacenToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Bodega
        Me.EnAlmacenToolStripMenuItem.Name = "EnAlmacenToolStripMenuItem"
        Me.EnAlmacenToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.EnAlmacenToolStripMenuItem.Text = "En almacen"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = Global.Calculadora.My.Resources.Resources.Beer_Bottle_icon_icons_com_68782
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
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
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(808, 542)
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
    Friend WithEvents EnAlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaHabitacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents ReservacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeFacturasPorClientesToolStripMenuItem As ToolStripMenuItem
End Class
