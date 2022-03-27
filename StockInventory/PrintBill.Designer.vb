<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PrintBill
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SalesMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet1 = New StockInventory.StockDataSet1()
        Me.SalesRecordsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SalesMasterTableAdapter = New StockInventory.StockDataSet1TableAdapters.SalesMasterTableAdapter()
        Me.SalesRecordsTableAdapter = New StockInventory.StockDataSet1TableAdapters.SalesRecordsTableAdapter()
        CType(Me.SalesMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesRecordsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesMasterBindingSource
        '
        Me.SalesMasterBindingSource.DataMember = "SalesMaster"
        Me.SalesMasterBindingSource.DataSource = Me.StockDataSet1
        '
        'StockDataSet1
        '
        Me.StockDataSet1.DataSetName = "StockDataSet1"
        Me.StockDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesRecordsBindingSource
        '
        Me.SalesRecordsBindingSource.DataMember = "SalesRecords"
        Me.SalesRecordsBindingSource.DataSource = Me.StockDataSet1
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SalesMasterBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.SalesRecordsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "StockInventory.BillPrint.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(16, 15)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(826, 678)
        Me.ReportViewer1.TabIndex = 0
        '
        'SalesMasterTableAdapter
        '
        Me.SalesMasterTableAdapter.ClearBeforeFill = True
        '
        'SalesRecordsTableAdapter
        '
        Me.SalesRecordsTableAdapter.ClearBeforeFill = True
        '
        'PrintBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 708)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PrintBill"
        Me.Text = "PrintBill"
        CType(Me.SalesMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesRecordsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SalesMasterBindingSource As BindingSource
    Friend WithEvents StockDataSet1 As StockDataSet1
    Friend WithEvents SalesRecordsBindingSource As BindingSource
    Friend WithEvents SalesMasterTableAdapter As StockDataSet1TableAdapters.SalesMasterTableAdapter
    Friend WithEvents SalesRecordsTableAdapter As StockDataSet1TableAdapters.SalesRecordsTableAdapter
End Class
