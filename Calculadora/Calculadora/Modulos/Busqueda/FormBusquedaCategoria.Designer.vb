<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBusquedaCategoria
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
        Me.btnSelecionarCategoria = New System.Windows.Forms.Button()
        Me.btnCancelarCategoria = New System.Windows.Forms.Button()
        Me.grdBuscarCategoria = New System.Windows.Forms.DataGridView()
        Me.txtBuscarCategoria = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grdBuscarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelecionarCategoria
        '
        Me.btnSelecionarCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSelecionarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelecionarCategoria.Location = New System.Drawing.Point(53, 369)
        Me.btnSelecionarCategoria.Name = "btnSelecionarCategoria"
        Me.btnSelecionarCategoria.Size = New System.Drawing.Size(127, 33)
        Me.btnSelecionarCategoria.TabIndex = 14
        Me.btnSelecionarCategoria.Text = "Seleccionar"
        Me.btnSelecionarCategoria.UseVisualStyleBackColor = True
        '
        'btnCancelarCategoria
        '
        Me.btnCancelarCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarCategoria.Location = New System.Drawing.Point(186, 369)
        Me.btnCancelarCategoria.Name = "btnCancelarCategoria"
        Me.btnCancelarCategoria.Size = New System.Drawing.Size(105, 33)
        Me.btnCancelarCategoria.TabIndex = 13
        Me.btnCancelarCategoria.Text = "Cancelar"
        Me.btnCancelarCategoria.UseVisualStyleBackColor = True
        '
        'grdBuscarCategoria
        '
        Me.grdBuscarCategoria.AllowUserToAddRows = False
        Me.grdBuscarCategoria.AllowUserToDeleteRows = False
        Me.grdBuscarCategoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarCategoria.Location = New System.Drawing.Point(47, 35)
        Me.grdBuscarCategoria.Name = "grdBuscarCategoria"
        Me.grdBuscarCategoria.ReadOnly = True
        Me.grdBuscarCategoria.Size = New System.Drawing.Size(244, 318)
        Me.grdBuscarCategoria.TabIndex = 12
        '
        'txtBuscarCategoria
        '
        Me.txtBuscarCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarCategoria.Location = New System.Drawing.Point(92, 9)
        Me.txtBuscarCategoria.Name = "txtBuscarCategoria"
        Me.txtBuscarCategoria.Size = New System.Drawing.Size(199, 20)
        Me.txtBuscarCategoria.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Buscar"
        '
        'FormBusquedaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(337, 411)
        Me.Controls.Add(Me.btnSelecionarCategoria)
        Me.Controls.Add(Me.btnCancelarCategoria)
        Me.Controls.Add(Me.grdBuscarCategoria)
        Me.Controls.Add(Me.txtBuscarCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormBusquedaCategoria"
        Me.Text = "FormBusquedaCategoria"
        CType(Me.grdBuscarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelecionarCategoria As Button
    Friend WithEvents btnCancelarCategoria As Button
    Friend WithEvents grdBuscarCategoria As DataGridView
    Friend WithEvents txtBuscarCategoria As TextBox
    Friend WithEvents Label1 As Label
End Class
