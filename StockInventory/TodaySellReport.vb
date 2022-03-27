Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class TodaySellReport
    Dim c As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("sqlcon").ConnectionString)
    Dim da As New SqlDataAdapter()
    Dim cmd As New SqlCommand()
    Dim ds, ds1 As New DataSet()
    Dim CustDs As New DataSet()
    Dim dr, dr1 As SqlDataReader
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.Application()
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To dgvExport.RowCount - 2
            For j = 0 To dgvExport.ColumnCount - 1
                For k As Integer = 1 To dgvExport.Columns.Count
                    xlWorkSheet.Cells(1, k) = dgvExport.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dgvExport(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\Daily Report Files\Report - " + DateTime.Now.ToShortDateString + ".xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can find the file excel file in folder D:\Daily Report Files.")
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub TodaySellReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        c.Open()
        cmd = New SqlCommand("select R.Item,Sum(R.TotalPieces) as Sell,P.Stock from SalesRecords R 
                                join SalesMaster M 
                                on M.BillNo = R.BillNo
                                join ProductMaster P
                                on p.Number = R.Num
                                where M.[Date] = @date
                                group by R.Item,P.Stock", c)
        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToShortDateString())

        da.SelectCommand = cmd

        da.Fill(ds, "temp")
        dgvExport.DataSource = ds
        dgvExport.DataMember = "temp"
        c.Close()
    End Sub
End Class