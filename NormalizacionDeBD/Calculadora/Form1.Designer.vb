<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTitu = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.panelresgis = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.ID = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActualizarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelresgis.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.lblTitu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(741, 41)
        Me.Panel1.TabIndex = 0
        '
        'lblTitu
        '
        Me.lblTitu.AutoSize = True
        Me.lblTitu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitu.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblTitu.Location = New System.Drawing.Point(302, 9)
        Me.lblTitu.Name = "lblTitu"
        Me.lblTitu.Size = New System.Drawing.Size(137, 24)
        Me.lblTitu.TabIndex = 0
        Me.lblTitu.Text = "PRODUCTOS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Panel3.Controls.Add(Me.MenuStrip2)
        Me.Panel3.Controls.Add(Me.txtbuscar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(741, 44)
        Me.Panel3.TabIndex = 1
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(9, 10)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(36, 24)
        Me.MenuStrip2.TabIndex = 2
        Me.MenuStrip2.Text = "Eliminar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(28, 20)
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(48, 14)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(415, 20)
        Me.txtbuscar.TabIndex = 0
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.AllowUserToResizeRows = False
        Me.datalistado.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datalistado.Location = New System.Drawing.Point(0, 0)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(639, 437)
        Me.datalistado.TabIndex = 2
        '
        'panelresgis
        '
        Me.panelresgis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelresgis.Controls.Add(Me.TextBox3)
        Me.panelresgis.Controls.Add(Me.Label3)
        Me.panelresgis.Controls.Add(Me.TextBox2)
        Me.panelresgis.Controls.Add(Me.TextBox1)
        Me.panelresgis.Controls.Add(Me.Label2)
        Me.panelresgis.Controls.Add(Me.Label1)
        Me.panelresgis.Controls.Add(Me.txtid)
        Me.panelresgis.Controls.Add(Me.ID)
        Me.panelresgis.Controls.Add(Me.MenuStrip1)
        Me.panelresgis.Location = New System.Drawing.Point(350, 106)
        Me.panelresgis.Name = "panelresgis"
        Me.panelresgis.Size = New System.Drawing.Size(260, 192)
        Me.panelresgis.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(104, 120)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(149, 20)
        Me.TextBox3.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(104, 85)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(149, 20)
        Me.TextBox2.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(104, 51)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descuento"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Producto"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(104, 12)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(149, 20)
        Me.txtid.TabIndex = 1
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(6, 13)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(23, 16)
        Me.ID.TabIndex = 0
        Me.ID.Text = "ID"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GuardarToolStripMenuItem, Me.ActualizarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 161)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(258, 29)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(83, 25)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ActualizarToolStripMenuItem
        '
        Me.ActualizarToolStripMenuItem.Name = "ActualizarToolStripMenuItem"
        Me.ActualizarToolStripMenuItem.Size = New System.Drawing.Size(99, 25)
        Me.ActualizarToolStripMenuItem.Text = "Actualizar"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.datalistado)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(741, 437)
        Me.Panel5.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.panelresgis)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(639, 437)
        Me.Panel4.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(639, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(102, 437)
        Me.Panel2.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(16, 352)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 73)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 437)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelresgis.ResumeLayout(False)
        Me.panelresgis.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitu As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents panelresgis As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents ID As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActualizarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
End Class
