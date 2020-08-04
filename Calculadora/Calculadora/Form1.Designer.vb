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
        Me.txtnum1 = New System.Windows.Forms.TextBox()
        Me.txtnum2 = New System.Windows.Forms.TextBox()
        Me.opt = New System.Windows.Forms.ComboBox()
        Me.lblOperacion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.optSuma = New System.Windows.Forms.RadioButton()
        Me.optResta = New System.Windows.Forms.RadioButton()
        Me.optMultiplicaion = New System.Windows.Forms.RadioButton()
        Me.optDividir = New System.Windows.Forms.RadioButton()
        Me.optExponenciacion = New System.Windows.Forms.RadioButton()
        Me.optResiduo = New System.Windows.Forms.RadioButton()
        Me.optPorcentaje = New System.Windows.Forms.RadioButton()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.ButtonCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtnum1
        '
        Me.txtnum1.Location = New System.Drawing.Point(12, 12)
        Me.txtnum1.Name = "txtnum1"
        Me.txtnum1.Size = New System.Drawing.Size(100, 20)
        Me.txtnum1.TabIndex = 0
        '
        'txtnum2
        '
        Me.txtnum2.Location = New System.Drawing.Point(204, 12)
        Me.txtnum2.Name = "txtnum2"
        Me.txtnum2.Size = New System.Drawing.Size(100, 20)
        Me.txtnum2.TabIndex = 1
        '
        'opt
        '
        Me.opt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.opt.FormattingEnabled = True
        Me.opt.Items.AddRange(New Object() {"Seleccione una operacion", "Suma", "Resta", "Multiplicacion", "Division", "Exponenciacion", "Residuo", "Porcentaje"})
        Me.opt.Location = New System.Drawing.Point(183, 60)
        Me.opt.Name = "opt"
        Me.opt.Size = New System.Drawing.Size(157, 21)
        Me.opt.TabIndex = 2
        '
        'lblOperacion
        '
        Me.lblOperacion.AutoSize = True
        Me.lblOperacion.Location = New System.Drawing.Point(138, 19)
        Me.lblOperacion.Name = "lblOperacion"
        Me.lblOperacion.Size = New System.Drawing.Size(0, 13)
        Me.lblOperacion.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(327, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "="
        '
        'optSuma
        '
        Me.optSuma.AutoSize = True
        Me.optSuma.Location = New System.Drawing.Point(12, 60)
        Me.optSuma.Name = "optSuma"
        Me.optSuma.Size = New System.Drawing.Size(52, 17)
        Me.optSuma.TabIndex = 5
        Me.optSuma.TabStop = True
        Me.optSuma.Text = "Suma"
        Me.optSuma.UseVisualStyleBackColor = True
        '
        'optResta
        '
        Me.optResta.AutoSize = True
        Me.optResta.Location = New System.Drawing.Point(12, 98)
        Me.optResta.Name = "optResta"
        Me.optResta.Size = New System.Drawing.Size(53, 17)
        Me.optResta.TabIndex = 6
        Me.optResta.TabStop = True
        Me.optResta.Text = "Resta"
        Me.optResta.UseVisualStyleBackColor = True
        '
        'optMultiplicaion
        '
        Me.optMultiplicaion.AutoSize = True
        Me.optMultiplicaion.Location = New System.Drawing.Point(12, 135)
        Me.optMultiplicaion.Name = "optMultiplicaion"
        Me.optMultiplicaion.Size = New System.Drawing.Size(89, 17)
        Me.optMultiplicaion.TabIndex = 7
        Me.optMultiplicaion.TabStop = True
        Me.optMultiplicaion.Text = "Multiplicacion"
        Me.optMultiplicaion.UseVisualStyleBackColor = True
        '
        'optDividir
        '
        Me.optDividir.AutoSize = True
        Me.optDividir.Location = New System.Drawing.Point(12, 172)
        Me.optDividir.Name = "optDividir"
        Me.optDividir.Size = New System.Drawing.Size(62, 17)
        Me.optDividir.TabIndex = 8
        Me.optDividir.TabStop = True
        Me.optDividir.Text = "Division"
        Me.optDividir.UseVisualStyleBackColor = True
        '
        'optExponenciacion
        '
        Me.optExponenciacion.AutoSize = True
        Me.optExponenciacion.Location = New System.Drawing.Point(12, 212)
        Me.optExponenciacion.Name = "optExponenciacion"
        Me.optExponenciacion.Size = New System.Drawing.Size(101, 17)
        Me.optExponenciacion.TabIndex = 9
        Me.optExponenciacion.TabStop = True
        Me.optExponenciacion.Text = "Exponenciacion"
        Me.optExponenciacion.UseVisualStyleBackColor = True
        '
        'optResiduo
        '
        Me.optResiduo.AutoSize = True
        Me.optResiduo.Location = New System.Drawing.Point(12, 252)
        Me.optResiduo.Name = "optResiduo"
        Me.optResiduo.Size = New System.Drawing.Size(64, 17)
        Me.optResiduo.TabIndex = 10
        Me.optResiduo.TabStop = True
        Me.optResiduo.Text = "Residuo"
        Me.optResiduo.UseVisualStyleBackColor = True
        '
        'optPorcentaje
        '
        Me.optPorcentaje.AutoSize = True
        Me.optPorcentaje.Location = New System.Drawing.Point(12, 290)
        Me.optPorcentaje.Name = "optPorcentaje"
        Me.optPorcentaje.Size = New System.Drawing.Size(76, 17)
        Me.optPorcentaje.TabIndex = 11
        Me.optPorcentaje.TabStop = True
        Me.optPorcentaje.Text = "Porcentaje"
        Me.optPorcentaje.UseVisualStyleBackColor = True
        '
        'lblRespuesta
        '
        Me.lblRespuesta.AutoSize = True
        Me.lblRespuesta.Location = New System.Drawing.Point(356, 19)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(0, 13)
        Me.lblRespuesta.TabIndex = 12
        '
        'ButtonCalcular
        '
        Me.ButtonCalcular.Location = New System.Drawing.Point(361, 278)
        Me.ButtonCalcular.Name = "ButtonCalcular"
        Me.ButtonCalcular.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCalcular.TabIndex = 13
        Me.ButtonCalcular.Text = "Calcular"
        Me.ButtonCalcular.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 313)
        Me.Controls.Add(Me.ButtonCalcular)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.optPorcentaje)
        Me.Controls.Add(Me.optResiduo)
        Me.Controls.Add(Me.optExponenciacion)
        Me.Controls.Add(Me.optDividir)
        Me.Controls.Add(Me.optMultiplicaion)
        Me.Controls.Add(Me.optResta)
        Me.Controls.Add(Me.optSuma)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOperacion)
        Me.Controls.Add(Me.opt)
        Me.Controls.Add(Me.txtnum2)
        Me.Controls.Add(Me.txtnum1)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnum1 As TextBox
    Friend WithEvents txtnum2 As TextBox
    Friend WithEvents opt As ComboBox
    Friend WithEvents lblOperacion As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents optSuma As RadioButton
    Friend WithEvents optResta As RadioButton
    Friend WithEvents optMultiplicaion As RadioButton
    Friend WithEvents optDividir As RadioButton
    Friend WithEvents optExponenciacion As RadioButton
    Friend WithEvents optResiduo As RadioButton
    Friend WithEvents optPorcentaje As RadioButton
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents ButtonCalcular As Button
End Class
