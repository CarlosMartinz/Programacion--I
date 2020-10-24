<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormBusquedaUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grdBuscarUsuario = New System.Windows.Forms.DataGridView()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_HotelDataSet = New Calculadora.db_HotelDataSet()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSeleccionar = New System.Windows.Forms.Button()
        Me.UsuariosTableAdapter = New Calculadora.db_HotelDataSetTableAdapters.UsuariosTableAdapter()
        Me.idUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DUI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Acceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(634, 394)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(101, 32)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grdBuscarUsuario
        '
        Me.grdBuscarUsuario.AllowUserToAddRows = False
        Me.grdBuscarUsuario.AllowUserToDeleteRows = False
        Me.grdBuscarUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idUsuario, Me.Nombre, Me.DUI, Me.Telefono, Me.Email, Me.Acceso, Me.Usuario, Me.Password})
        Me.grdBuscarUsuario.Location = New System.Drawing.Point(12, 32)
        Me.grdBuscarUsuario.Name = "grdBuscarUsuario"
        Me.grdBuscarUsuario.ReadOnly = True
        Me.grdBuscarUsuario.Size = New System.Drawing.Size(723, 345)
        Me.grdBuscarUsuario.TabIndex = 1
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.Db_HotelDataSet
        '
        'Db_HotelDataSet
        '
        Me.Db_HotelDataSet.DataSetName = "db_HotelDataSet"
        Me.Db_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtBuscar
        '
        Me.txtBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscar.Location = New System.Drawing.Point(57, 6)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(678, 20)
        Me.txtBuscar.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar"
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar.Location = New System.Drawing.Point(510, 394)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(118, 32)
        Me.btnSeleccionar.TabIndex = 4
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'idUsuario
        '
        Me.idUsuario.DataPropertyName = "idUsuario"
        Me.idUsuario.HeaderText = "ID"
        Me.idUsuario.Name = "idUsuario"
        Me.idUsuario.ReadOnly = True
        Me.idUsuario.Visible = False
        Me.idUsuario.Width = 50
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "NOMBRE"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 210
        '
        'DUI
        '
        Me.DUI.DataPropertyName = "Documento"
        Me.DUI.HeaderText = "Documento"
        Me.DUI.Name = "DUI"
        Me.DUI.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "TELEFONO"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 125
        '
        'Email
        '
        Me.Email.DataPropertyName = "Email"
        Me.Email.HeaderText = "EMAIL"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 150
        '
        'Acceso
        '
        Me.Acceso.DataPropertyName = "Acceso"
        Me.Acceso.HeaderText = "ACCESO"
        Me.Acceso.Name = "Acceso"
        Me.Acceso.ReadOnly = True
        Me.Acceso.Width = 120
        '
        'Usuario
        '
        Me.Usuario.DataPropertyName = "Usuario"
        Me.Usuario.HeaderText = "USUARIO"
        Me.Usuario.Name = "Usuario"
        Me.Usuario.ReadOnly = True
        '
        'Password
        '
        Me.Password.DataPropertyName = "Password"
        Me.Password.HeaderText = "CONTRASEÑA"
        Me.Password.Name = "Password"
        Me.Password.ReadOnly = True
        '
        'FormBusquedaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 438)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.grdBuscarUsuario)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "FormBusquedaUsuarios"
        Me.Text = "FormBusquedaUsuarios"
        CType(Me.grdBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelar As Button
    Friend WithEvents grdBuscarUsuario As DataGridView
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSeleccionar As Button
    Friend WithEvents Db_HotelDataSet As db_HotelDataSet
    Friend WithEvents UsuariosBindingSource As BindingSource
    Friend WithEvents UsuariosTableAdapter As db_HotelDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents idUsuario As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents DUI As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Email As DataGridViewTextBoxColumn
    Friend WithEvents Acceso As DataGridViewTextBoxColumn
    Friend WithEvents Usuario As DataGridViewTextBoxColumn
    Friend WithEvents Password As DataGridViewTextBoxColumn
End Class
