<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFacturas))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.db_HotelDataSet = New Calculadora.db_HotelDataSet()
        Me.InfoVentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InfoVentasTableAdapter = New Calculadora.db_HotelDataSetTableAdapters.InfoVentasTableAdapter()
        Me.InfoFacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InfoFacturasTableAdapter = New Calculadora.db_HotelDataSetTableAdapters.InfoFacturasTableAdapter()
        CType(Me.db_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoVentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InfoFacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Facturas"
        ReportDataSource1.Value = Me.InfoFacturasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Calculadora.ReportListaClientesFactura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 426)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_HotelDataSet
        '
        Me.db_HotelDataSet.DataSetName = "db_HotelDataSet"
        Me.db_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InfoVentasBindingSource
        '
        Me.InfoVentasBindingSource.DataMember = "InfoVentas"
        Me.InfoVentasBindingSource.DataSource = Me.db_HotelDataSet
        '
        'InfoVentasTableAdapter
        '
        Me.InfoVentasTableAdapter.ClearBeforeFill = True
        '
        'InfoFacturasBindingSource
        '
        Me.InfoFacturasBindingSource.DataMember = "InfoFacturas"
        Me.InfoFacturasBindingSource.DataSource = Me.db_HotelDataSet
        '
        'InfoFacturasTableAdapter
        '
        Me.InfoFacturasTableAdapter.ClearBeforeFill = True
        '
        'FormFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte - Facturas"
        CType(Me.db_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoVentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InfoFacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents InfoVentasBindingSource As BindingSource
    Friend WithEvents db_HotelDataSet As db_HotelDataSet
    Friend WithEvents InfoVentasTableAdapter As db_HotelDataSetTableAdapters.InfoVentasTableAdapter
    Friend WithEvents InfoFacturasBindingSource As BindingSource
    Friend WithEvents InfoFacturasTableAdapter As db_HotelDataSetTableAdapters.InfoFacturasTableAdapter
End Class
