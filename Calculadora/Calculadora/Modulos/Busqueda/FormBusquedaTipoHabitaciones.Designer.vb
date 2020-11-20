<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBusquedaTipoHabitaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormBusquedaTipoHabitaciones))
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.lblBuscarTipoHabit = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.grdBuscarTipoHabit = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.grdBuscarTipoHabit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(391, 403)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(118, 32)
        Me.btnSeleccionar.TabIndex = 9
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'lblBuscarTipoHabit
        '
        Me.lblBuscarTipoHabit.AutoSize = True
        Me.lblBuscarTipoHabit.Location = New System.Drawing.Point(39, 18)
        Me.lblBuscarTipoHabit.Name = "lblBuscarTipoHabit"
        Me.lblBuscarTipoHabit.Size = New System.Drawing.Size(40, 13)
        Me.lblBuscarTipoHabit.TabIndex = 8
        Me.lblBuscarTipoHabit.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(84, 15)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(532, 20)
        Me.txtBuscar.TabIndex = 7
        '
        'grdBuscarTipoHabit
        '
        Me.grdBuscarTipoHabit.AllowUserToAddRows = False
        Me.grdBuscarTipoHabit.AllowUserToDeleteRows = False
        Me.grdBuscarTipoHabit.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarTipoHabit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarTipoHabit.Location = New System.Drawing.Point(39, 41)
        Me.grdBuscarTipoHabit.Name = "grdBuscarTipoHabit"
        Me.grdBuscarTipoHabit.ReadOnly = True
        Me.grdBuscarTipoHabit.Size = New System.Drawing.Size(577, 345)
        Me.grdBuscarTipoHabit.TabIndex = 6
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(515, 403)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FormBusquedaTipoHabitaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 450)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.lblBuscarTipoHabit)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.grdBuscarTipoHabit)
        Me.Controls.Add(Me.btnCancelar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormBusquedaTipoHabitaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormBusquedaTipoHabitaciones"
        CType(Me.grdBuscarTipoHabit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents lblBuscarTipoHabit As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents grdBuscarTipoHabit As DataGridView
    Friend WithEvents btnCancelar As Button
End Class
