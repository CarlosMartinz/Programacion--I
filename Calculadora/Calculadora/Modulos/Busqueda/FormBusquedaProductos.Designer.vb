<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBusquedaProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBusquedaProductos))
        Me.btnSelecionarProducto = New System.Windows.Forms.Button()
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.grdBuscarProducto = New System.Windows.Forms.DataGridView()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grdBuscarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelecionarProducto
        '
        Me.btnSelecionarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelecionarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelecionarProducto.Location = New System.Drawing.Point(244, 408)
        Me.btnSelecionarProducto.Name = "btnSelecionarProducto"
        Me.btnSelecionarProducto.Size = New System.Drawing.Size(127, 33)
        Me.btnSelecionarProducto.TabIndex = 9
        Me.btnSelecionarProducto.Text = "Seleccionar"
        Me.btnSelecionarProducto.UseVisualStyleBackColor = True
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProducto.Location = New System.Drawing.Point(377, 408)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(105, 33)
        Me.btnCancelarProducto.TabIndex = 8
        Me.btnCancelarProducto.Text = "Cancelar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'grdBuscarProducto
        '
        Me.grdBuscarProducto.AllowUserToAddRows = False
        Me.grdBuscarProducto.AllowUserToDeleteRows = False
        Me.grdBuscarProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarProducto.Location = New System.Drawing.Point(47, 35)
        Me.grdBuscarProducto.Name = "grdBuscarProducto"
        Me.grdBuscarProducto.ReadOnly = True
        Me.grdBuscarProducto.Size = New System.Drawing.Size(435, 357)
        Me.grdBuscarProducto.TabIndex = 7
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarProducto.Location = New System.Drawing.Point(92, 9)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(390, 20)
        Me.txtBuscarProducto.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Buscar"
        '
        'FormBusquedaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(528, 450)
        Me.Controls.Add(Me.btnSelecionarProducto)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.grdBuscarProducto)
        Me.Controls.Add(Me.txtBuscarProducto)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBusquedaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBusquedaProductos"
        CType(Me.grdBuscarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelecionarProducto As Button
    Friend WithEvents btnCancelarProducto As Button
    Friend WithEvents grdBuscarProducto As DataGridView
    Friend WithEvents txtBuscarProducto As TextBox
    Friend WithEvents Label1 As Label
End Class
