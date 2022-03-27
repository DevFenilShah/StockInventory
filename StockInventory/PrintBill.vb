Public Class PrintBill
    Dim mibillno As Integer = 0
    Private Sub PrintBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.SalesMasterTableAdapter.Fill(Me.StockDataSet1.SalesMaster, mibillno)

        Me.SalesRecordsTableAdapter.Fill(Me.StockDataSet1.SalesRecords, mibillno)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub New(ByVal billno As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        mibillno = billno
        ' Add any initialization after the InitializeComponent() call.

    End Sub
End Class