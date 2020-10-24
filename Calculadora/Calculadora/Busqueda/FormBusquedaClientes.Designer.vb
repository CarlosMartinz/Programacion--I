<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBusquedaClientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.grdBuscarCliente = New System.Windows.Forms.DataGridView()
        Me.btnCancelarCliente = New System.Windows.Forms.Button()
        Me.btnSelecionarCliente = New System.Windows.Forms.Button()
        CType(Me.grdBuscarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar"
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarCliente.Location = New System.Drawing.Point(57, 6)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(662, 20)
        Me.txtBuscarCliente.TabIndex = 1
        '
        'grdBuscarCliente
        '
        Me.grdBuscarCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarCliente.Location = New System.Drawing.Point(12, 32)
        Me.grdBuscarCliente.Name = "grdBuscarCliente"
        Me.grdBuscarCliente.Size = New System.Drawing.Size(707, 357)
        Me.grdBuscarCliente.TabIndex = 2
        '
        'btnCancelarCliente
        '
        Me.btnCancelarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCliente.Location = New System.Drawing.Point(614, 405)
        Me.btnCancelarCliente.Name = "btnCancelarCliente"
        Me.btnCancelarCliente.Size = New System.Drawing.Size(105, 33)
        Me.btnCancelarCliente.TabIndex = 3
        Me.btnCancelarCliente.Text = "Cancelar"
        Me.btnCancelarCliente.UseVisualStyleBackColor = True
        '
        'btnSelecionarCliente
        '
        Me.btnSelecionarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelecionarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelecionarCliente.Location = New System.Drawing.Point(481, 405)
        Me.btnSelecionarCliente.Name = "btnSelecionarCliente"
        Me.btnSelecionarCliente.Size = New System.Drawing.Size(127, 33)
        Me.btnSelecionarCliente.TabIndex = 4
        Me.btnSelecionarCliente.Text = "Seleccionar"
        Me.btnSelecionarCliente.UseVisualStyleBackColor = True
        '
        'FormBusquedaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 450)
        Me.Controls.Add(Me.btnSelecionarCliente)
        Me.Controls.Add(Me.btnCancelarCliente)
        Me.Controls.Add(Me.grdBuscarCliente)
        Me.Controls.Add(Me.txtBuscarCliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBusquedaClientes"
        Me.Text = "Busqueda de clientes"
        CType(Me.grdBuscarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents grdBuscarCliente As DataGridView
    Friend WithEvents btnCancelarCliente As Button
    Friend WithEvents btnSelecionarCliente As Button
End Class
