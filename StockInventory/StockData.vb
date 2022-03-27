Imports System.Data.SqlClient
Imports Excel = Microsoft.Office.Interop.Excel
Public Class StockData
    Dim c As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("sqlcon").ConnectionString)
    Dim cmd As New SqlCommand()
    Dim ds As New DataSet()
    Dim da As New SqlDataAdapter()
    Dim APP As New Excel.Application
    Dim worksheet As Excel.Worksheet
    Dim workbook As Excel.Workbook

    Private Sub MediaTypeData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        RefreshData()
    End Sub

    Dim miCustId As Int32

    Private Sub dgvcust_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvcust.CellClick
        If (e.RowIndex >= 0) Then
            miCustId = Convert.ToInt32(dgvcust.Rows(e.RowIndex).Cells(0).Value())
            btnsave.Text = "Update Data"
            txtnum.Text = dgvcust.Rows(e.RowIndex).Cells(1).Value().ToString()
            txtname.Text = dgvcust.Rows(e.RowIndex).Cells(2).Value().ToString()
            txtprice.Text = dgvcust.Rows(e.RowIndex).Cells(3).Value().ToString()
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If btnsave.Text = "Update Data" Then
            If (String.IsNullOrEmpty(txtname.Text.Trim()) Or String.IsNullOrEmpty(txtprice.Text.Trim())) Then
                MsgBox("Please Enter Data in all elements")
            Else
                c.Open()
                cmd = New SqlCommand("update ProductMaster set Number=@num,Name=@cn,Price=@ca where Pid=@id", c)
                cmd.Parameters.AddWithValue("@id", miCustId)
                cmd.Parameters.AddWithValue("@num", txtnum.Text.Trim())
                cmd.Parameters.AddWithValue("@cn", txtname.Text.Trim())
                cmd.Parameters.AddWithValue("@ca", txtprice.Text.Trim())
                cmd.ExecuteNonQuery()
                c.Close()
                btnsave.Text = "Save Data"
                MsgBox("Product Data Updated")
                txtnum.Clear()
                txtname.Clear()
                txtprice.Clear()
                RefreshData()
            End If
        Else
            If (String.IsNullOrEmpty(txtnum.Text.Trim()) Or String.IsNullOrEmpty(txtname.Text.Trim()) Or String.IsNullOrEmpty(txtprice.Text.Trim())) Then
                MsgBox("Please Enter Data in all elements")
            Else
                c.Open()
                cmd = New SqlCommand("Insert into ProductMaster values(@num,@cn,@cc,0)", c)
                cmd.Parameters.AddWithValue("@num", txtnum.Text.Trim())
                cmd.Parameters.AddWithValue("@cn", txtname.Text.Trim())
                cmd.Parameters.AddWithValue("@cc", txtprice.Text.Trim())
                cmd.ExecuteNonQuery()
                c.Close()
                MsgBox("Product Data Saved")
                txtnum.Clear()
                txtname.Clear()
                txtprice.Clear()
                RefreshData()
            End If
        End If
    End Sub
    Public Sub RefreshData()
        c.Open()
        cmd = New SqlCommand("select * from ProductMaster", c)
        da.SelectCommand = cmd
        ds.Clear()
        da.Fill(ds, "temp")
        dgvcust.DataSource = ds
        dgvcust.DataMember = "temp"
        dgvcust.Refresh()
        dgvcust.Columns(0).Visible = False
        c.Close()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Excel.Application()
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("sheet1")


        For i = 0 To dgvcust.RowCount - 2
            For j = 0 To dgvcust.ColumnCount - 1
                For k As Integer = 1 To dgvcust.Columns.Count
                    xlWorkSheet.Cells(1, k) = dgvcust.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dgvcust(j, i).Value.ToString()
                Next
            Next
        Next

        xlWorkSheet.SaveAs("D:\Daily Stock Files\Stock - " + DateTime.Now.ToShortDateString + ".xlsx")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)

        MsgBox("You can find the file excel file in folder D:\Daily Stock Files.")
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
End Class