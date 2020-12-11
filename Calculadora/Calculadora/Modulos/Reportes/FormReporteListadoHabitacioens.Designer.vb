<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormReporteListadoHabitacioens
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormReporteListadoHabitacioens))
        Me.clientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.db_HotelDataSet = New Calculadora.db_HotelDataSet()
        Me.HabitacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionTableAdapter = New Calculadora.db_HotelDataSetTableAdapters.HabitacionTableAdapter()
        Me.clientesTableAdapter = New Calculadora.db_HotelDataSetTableAdapters.clientesTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.HabitacionesInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HabitacionesInfoTableAdapter = New Calculadora.db_HotelDataSetTableAdapters.HabitacionesInfoTableAdapter()
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HabitacionesInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'clientesBindingSource
        '
        Me.clientesBindingSource.DataMember = "clientes"
        Me.clientesBindingSource.DataSource = Me.db_HotelDataSet
        '
        'db_HotelDataSet
        '
        Me.db_HotelDataSet.DataSetName = "db_HotelDataSet"
        Me.db_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HabitacionBindingSource
        '
        Me.HabitacionBindingSource.DataMember = "Habitacion"
        Me.HabitacionBindingSource.DataSource = Me.db_HotelDataSet
        '
        'HabitacionTableAdapter
        '
        Me.HabitacionTableAdapter.ClearBeforeFill = True
        '
        'clientesTableAdapter
        '
        Me.clientesTableAdapter.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.HabitacionesInfoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Calculadora.ReportHabitaciones.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 426)
        Me.ReportViewer1.TabIndex = 0
        '
        'HabitacionesInfoBindingSource
        '
        Me.HabitacionesInfoBindingSource.DataMember = "HabitacionesInfo"
        Me.HabitacionesInfoBindingSource.DataSource = Me.db_HotelDataSet
        '
        'HabitacionesInfoTableAdapter
        '
        Me.HabitacionesInfoTableAdapter.ClearBeforeFill = True
        '
        'FormReporteListadoHabitacioens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormReporteListadoHabitacioens"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte-Habitaciones"
        CType(Me.clientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HabitacionesInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HabitacionBindingSource As BindingSource
    Friend WithEvents db_HotelDataSet As db_HotelDataSet
    Friend WithEvents HabitacionTableAdapter As db_HotelDataSetTableAdapters.HabitacionTableAdapter
    Friend WithEvents clientesBindingSource As BindingSource
    Friend WithEvents clientesTableAdapter As db_HotelDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents HabitacionesInfoBindingSource As BindingSource
    Friend WithEvents HabitacionesInfoTableAdapter As db_HotelDataSetTableAdapters.HabitacionesInfoTableAdapter
End Class
