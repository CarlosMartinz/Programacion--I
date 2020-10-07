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
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrarUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeReservacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TicketToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreditoFiscalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrarUsuarioToolStripMenuItem, Me.RegistroDeReservacionToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'RegistrarUsuarioToolStripMenuItem
        '
        Me.RegistrarUsuarioToolStripMenuItem.Name = "RegistrarUsuarioToolStripMenuItem"
        Me.RegistrarUsuarioToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.RegistrarUsuarioToolStripMenuItem.Size = New System.Drawing.Size(225, 22)
        Me.RegistrarUsuarioToolStripMenuItem.Text = "Registro general usuarios"
        Me.RegistrarUsuarioToolStripMenuItem.ToolTipText = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'RegistroDeReservacionToolStripMenuItem
        '
        Me.RegistroDeReservacionToolStripMenuItem.Name = "RegistroDeReservacionToolStripMenuItem"
        Me.RegistroDeReservacionToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.RegistroDeReservacionToolStripMenuItem.Text = "Registro de reservacion"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CerrarSesionToolStripMenuItem.Text = "Cerrar sesion"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TicketToolStripMenuItem, Me.CreditoFiscalToolStripMenuItem})
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.FacturaciónToolStripMenuItem.Text = "Facturación"
        '
        'TicketToolStripMenuItem
        '
        Me.TicketToolStripMenuItem.Name = "TicketToolStripMenuItem"
        Me.TicketToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.TicketToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.TicketToolStripMenuItem.Text = "Ticket"
        '
        'CreditoFiscalToolStripMenuItem
        '
        Me.CreditoFiscalToolStripMenuItem.Name = "CreditoFiscalToolStripMenuItem"
        Me.CreditoFiscalToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.CreditoFiscalToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.CreditoFiscalToolStripMenuItem.Text = "Credito fiscal"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.FacturaciónToolStripMenuItem, Me.MantenimientoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(881, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(881, 464)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormPrincipal"
        Me.Text = " Principal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistrarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeReservacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TicketToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreditoFiscalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
