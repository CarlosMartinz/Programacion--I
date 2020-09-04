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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.univ = New System.Windows.Forms.TabPage()
        Me.butconver = New System.Windows.Forms.Button()
        Me.txtresult = New System.Windows.Forms.TextBox()
        Me.txtcant = New System.Windows.Forms.TextBox()
        Me.txtunid = New System.Windows.Forms.TextBox()
        Me.lblresp = New System.Windows.Forms.Label()
        Me.lblunid = New System.Windows.Forms.Label()
        Me.lblcant = New System.Windows.Forms.Label()
        Me.area = New System.Windows.Forms.TabPage()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.univ.SuspendLayout()
        Me.area.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.univ)
        Me.TabControl1.Controls.Add(Me.area)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(424, 289)
        Me.TabControl1.TabIndex = 0
        '
        'univ
        '
        Me.univ.Controls.Add(Me.butconver)
        Me.univ.Controls.Add(Me.txtresult)
        Me.univ.Controls.Add(Me.txtcant)
        Me.univ.Controls.Add(Me.txtunid)
        Me.univ.Controls.Add(Me.lblresp)
        Me.univ.Controls.Add(Me.lblunid)
        Me.univ.Controls.Add(Me.lblcant)
        Me.univ.Location = New System.Drawing.Point(4, 22)
        Me.univ.Name = "univ"
        Me.univ.Padding = New System.Windows.Forms.Padding(3)
        Me.univ.Size = New System.Drawing.Size(416, 263)
        Me.univ.TabIndex = 0
        Me.univ.Text = "Universal"
        Me.univ.UseVisualStyleBackColor = True
        '
        'butconver
        '
        Me.butconver.Location = New System.Drawing.Point(153, 172)
        Me.butconver.Name = "butconver"
        Me.butconver.Size = New System.Drawing.Size(100, 34)
        Me.butconver.TabIndex = 6
        Me.butconver.Text = "Convertir"
        Me.butconver.UseVisualStyleBackColor = True
        '
        'txtresult
        '
        Me.txtresult.Location = New System.Drawing.Point(97, 92)
        Me.txtresult.Name = "txtresult"
        Me.txtresult.Size = New System.Drawing.Size(100, 20)
        Me.txtresult.TabIndex = 5
        '
        'txtcant
        '
        Me.txtcant.Location = New System.Drawing.Point(88, 31)
        Me.txtcant.Name = "txtcant"
        Me.txtcant.Size = New System.Drawing.Size(100, 20)
        Me.txtcant.TabIndex = 4
        '
        'txtunid
        '
        Me.txtunid.Location = New System.Drawing.Point(277, 34)
        Me.txtunid.Name = "txtunid"
        Me.txtunid.Size = New System.Drawing.Size(100, 20)
        Me.txtunid.TabIndex = 3
        '
        'lblresp
        '
        Me.lblresp.AutoSize = True
        Me.lblresp.Location = New System.Drawing.Point(30, 95)
        Me.lblresp.Name = "lblresp"
        Me.lblresp.Size = New System.Drawing.Size(61, 13)
        Me.lblresp.TabIndex = 2
        Me.lblresp.Text = "Respuesta:"
        '
        'lblunid
        '
        Me.lblunid.AutoSize = True
        Me.lblunid.Location = New System.Drawing.Point(216, 37)
        Me.lblunid.Name = "lblunid"
        Me.lblunid.Size = New System.Drawing.Size(55, 13)
        Me.lblunid.TabIndex = 1
        Me.lblunid.Text = "Unidades:"
        '
        'lblcant
        '
        Me.lblcant.AutoSize = True
        Me.lblcant.Location = New System.Drawing.Point(30, 34)
        Me.lblcant.Name = "lblcant"
        Me.lblcant.Size = New System.Drawing.Size(52, 13)
        Me.lblcant.TabIndex = 0
        Me.lblcant.Text = "Cantidad:"
        '
        'area
        '
        Me.area.Controls.Add(Me.ComboBox2)
        Me.area.Controls.Add(Me.ComboBox1)
        Me.area.Controls.Add(Me.Label7)
        Me.area.Controls.Add(Me.Label6)
        Me.area.Controls.Add(Me.Label5)
        Me.area.Controls.Add(Me.Label4)
        Me.area.Controls.Add(Me.TextBox4)
        Me.area.Controls.Add(Me.Button2)
        Me.area.Location = New System.Drawing.Point(4, 22)
        Me.area.Name = "area"
        Me.area.Padding = New System.Windows.Forms.Padding(3)
        Me.area.Size = New System.Drawing.Size(416, 263)
        Me.area.TabIndex = 1
        Me.area.Text = "Area(Superficie)"
        Me.area.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(251, 84)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 7
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(54, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(203, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "a"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "De"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Cantidad:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(85, 23)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(150, 178)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 45)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Convertir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 313)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Parcial-1"
        Me.TabControl1.ResumeLayout(False)
        Me.univ.ResumeLayout(False)
        Me.univ.PerformLayout()
        Me.area.ResumeLayout(False)
        Me.area.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents univ As TabPage
    Friend WithEvents area As TabPage
    Friend WithEvents butconver As Button
    Friend WithEvents txtresult As TextBox
    Friend WithEvents txtcant As TextBox
    Friend WithEvents txtunid As TextBox
    Friend WithEvents lblresp As Label
    Friend WithEvents lblunid As Label
    Friend WithEvents lblcant As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button2 As Button
End Class
