Imports System.Data.SqlClient
Public Class NewBill
    Dim c As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("sqlcon").ConnectionString)
    Dim da As New SqlDataAdapter()
    Dim cmd As New SqlCommand()
    Dim ds, ds1 As New DataSet()
    Dim CustDs As New DataSet()
    Dim dr, dr1 As SqlDataReader
    Dim StockData As New Dictionary(Of Int32, Int32)

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If Not String.IsNullOrEmpty(txtTotal.Text) Then
            dgvMaster.Rows.Add(txtnum.Text, txtproname.Text, txtTotalPieces.Text, txtUPrice.Text, txtTotal.Text)

            txtnum.Clear()
            txtTotalPieces.Clear()
            txtUPrice.Clear()
            txtTotal.Clear()
            txtavailable.Clear()
            txtproname.Clear()

            CalculateFinalAmount()
            txtdiscount_Leave(Nothing, Nothing)

            txtnum.Focus()
        Else
            MsgBox("Please enter proper data.")
        End If
    End Sub

    Private Sub btnitemclear_Click(sender As Object, e As EventArgs) Handles btnitemclear.Click
        txtnum.Clear()
        txtproname.Clear()
        txtavailable.Clear()
        txtTotalPieces.Text = 0
        txtUPrice.Text = 0
        txtTotal.Text = 0
    End Sub

    Private Sub NewBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.ProductMaster' table. You can move, or remove it, as needed.
        Me.ProductMasterTableAdapter.Fill(Me.StockDataSet.ProductMaster)
        loadBillNumber()
    End Sub

    Private Sub txtTotalPieces_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPieces.TextChanged
        If Not (String.IsNullOrEmpty(txtTotalPieces.Text) Or String.IsNullOrEmpty(txtUPrice.Text)) Then
            If Convert.ToInt32(txtUPrice.Text) > 0 And Convert.ToInt32(txtTotalPieces.Text) > 0 Then
                txtTotal.Text = Convert.ToInt32(txtUPrice.Text) * Convert.ToInt32(txtTotalPieces.Text)
            End If
        End If
    End Sub

    Private Sub txtTotalPieces_Leave(sender As Object, e As EventArgs) Handles txtTotalPieces.Leave
        If Not (String.IsNullOrEmpty(txtTotalPieces.Text) Or String.IsNullOrEmpty(txtavailable.Text)) Then
            If Convert.ToInt32(txtTotalPieces.Text) > Convert.ToInt32(txtavailable.Text) Then
                MsgBox("Piece should not be more than available stock.")
                txtTotalPieces.Focus()
            End If
        End If
    End Sub

    Private Sub txtdiscount_Leave(sender As Object, e As EventArgs) Handles txtdiscount.Leave
        If Not String.IsNullOrEmpty(txtdiscount.Text) Then
            txtFinalTotal.Text = Convert.ToInt32(CountTotalPrice() - (CountTotalPrice() * Convert.ToInt32(txtdiscount.Text)) / 100).ToString()
        End If
    End Sub

    Public Sub loadBillNumber()
        c.Open()
        cmd = New SqlCommand("select BillNumber from Sequences", c)
        dr = cmd.ExecuteReader()
        If (dr.Read()) Then
            txtbillno.Text = dr(0).ToString
        End If
        c.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If btnSave.Text = "Update" Then
            c.Open()
            'Update Stock
            For Each Item As KeyValuePair(Of Int32, Int32) In StockData
                cmd = New SqlCommand("update ProductMaster set Stock = Stock + " & Item.Value & " where Number = '" & Item.Key & "'", c)
                cmd.ExecuteNonQuery()
            Next

            cmd = New SqlCommand("delete from SalesMaster where BillNo=@bnum;delete from SalesRecords where BillNo=@bnum", c)
            cmd.Parameters.AddWithValue("@bnum", txtbillno.Text)
            cmd.ExecuteNonQuery()
            c.Close()
        End If
        c.Open()
        Dim billno As Int32 = Convert.ToInt32(txtbillno.Text)
        cmd = New SqlCommand("insert into SalesMaster values(@bno,@date,@Name,@SName,@mobno,@totprice,@disc,@ftotal)", c)
        cmd.Parameters.AddWithValue("@bno", txtbillno.Text)
        cmd.Parameters.AddWithValue("@date", dtpDate.Value.ToShortDateString())
        cmd.Parameters.AddWithValue("@Name", txtName.Text)
        cmd.Parameters.AddWithValue("@SName", txtsalesman.Text)
        cmd.Parameters.AddWithValue("@mobno", txtMobNo.Text)
        cmd.Parameters.AddWithValue("@totprice", txtbtmTotal.Text)
        cmd.Parameters.AddWithValue("@disc", txtdiscount.Text)
        cmd.Parameters.AddWithValue("@ftotal", txtFinalTotal.Text)
        cmd.ExecuteNonQuery()

        Dim sInsert As String = " Insert into SalesRecords values "
        For iCount = 0 To dgvMaster.Rows.Count - 2
            sInsert &= "(" & Convert.ToInt32(txtbillno.Text) & ",'" & dgvMaster.Rows(iCount).Cells(0).Value & "','" & dgvMaster.Rows(iCount).Cells(1).Value _
                    & "','" & dgvMaster.Rows(iCount).Cells(2).Value & "','" & dgvMaster.Rows(iCount).Cells(3).Value & "','" & dgvMaster.Rows(iCount).Cells(4).Value & "'),"
        Next
        sInsert = sInsert.Trim(",")
        cmd = New SqlCommand(sInsert, c)
        cmd.ExecuteNonQuery()

        'Update Stock
        For iCount = 0 To dgvMaster.Rows.Count - 2
            cmd = New SqlCommand("update ProductMaster set Stock = Stock - " & dgvMaster.Rows(iCount).Cells(2).Value & " where Number = '" & dgvMaster.Rows(iCount).Cells(0).Value & "'", c)
            cmd.ExecuteNonQuery()
        Next

        'Update next bill number in DB.
        cmd = New SqlCommand("update Sequences set BillNumber=" & Convert.ToInt32(txtbillno.Text) + 1, c)
        cmd.ExecuteNonQuery()

        c.Close()

        MsgBox("Bill Generated")
        ClearDataFields()
        btnitemclear_Click(Nothing, Nothing)
        StockData.Clear()
        chkedit.Checked = False
        txtbillno.ReadOnly = True

        Dim oPrint As New PrintBill(billno)
        oPrint.Show()
    End Sub

    Public Sub ClearDataFields()
        loadBillNumber()
        txtName.Clear()
        txtsalesman.Clear()
        txtMobNo.Clear()
        txtTotalPieces.Text = 0
        txtavailable.Clear()
        txtproname.Clear()
        txtUPrice.Text = 0
        txtTotal.Text = 0
        txtFinalTotal.Clear()
        txtbtmTotal.Clear()
        txtdiscount.Clear()
        dgvMaster.Rows.Clear()
    End Sub

    Private Sub txtnum_Leave(sender As Object, e As EventArgs) Handles txtnum.Leave
        If Not (String.IsNullOrEmpty(txtnum.Text)) Then
            If StockDataSet.Tables(0).Select("Number = '" & txtnum.Text & "'").Length > 0 Then
                Dim data = StockDataSet.Tables(0).Select("Number = '" & txtnum.Text & "'").FirstOrDefault()
                txtproname.Text = data.ItemArray(2)
                txtavailable.Text = data.ItemArray(4)
                txtUPrice.Text = data.ItemArray(3)
            Else
                MsgBox("Item is not available in stock data.")
            End If
        End If
    End Sub

    Private Sub dgvMaster_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvMaster.RowsRemoved
        CalculateFinalAmount()
        txtdiscount_Leave(Nothing, Nothing)
    End Sub

    Private Sub txtMobNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobNo.KeyPress, txtnum.KeyPress, txtTotalPieces.KeyPress, txtdiscount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub chkedit_CheckedChanged(sender As Object, e As EventArgs) Handles chkedit.CheckedChanged
        If chkedit.Checked Then
            txtbillno.Clear()
            txtbillno.ReadOnly = False
            txtbillno.Enabled = True
            btnSave.Text = "Update"
        Else
            loadBillNumber()
            txtbillno.ReadOnly = True
            txtbillno.Enabled = False
            btnSave.Text = "Save"
            ClearDataFields()
        End If
    End Sub

    Private Sub txtbillno_Leave(sender As Object, e As EventArgs) Handles txtbillno.Leave
        c.Open()
        dgvMaster.Rows.Clear()
        CustDs.Clear()
        cmd = New SqlCommand("select * from SalesMaster where BillNo=@bno;select * from SalesRecords where BillNo=@bno", c)
        cmd.Parameters.AddWithValue("@bno", txtbillno.Text)
        da.SelectCommand = cmd
        da.Fill(CustDs)

        If CustDs.Tables(0).Rows.Count > 0 Then
            txtName.Text = CustDs.Tables(0).Rows(0)("Name").ToString()
            txtMobNo.Text = CustDs.Tables(0).Rows(0)("MobNo").ToString()
            txtsalesman.Text = CustDs.Tables(0).Rows(0)("SalesMan").ToString()
            dtpDate.Value = CustDs.Tables(0).Rows(0)("Date").ToString()
            txtbtmTotal.Text = CustDs.Tables(0).Rows(0)("TotalPrice").ToString()
            txtdiscount.Text = CustDs.Tables(0).Rows(0)("Discount").ToString()
            txtFinalTotal.Text = CustDs.Tables(0).Rows(0)("FinalTotal").ToString()
            Dim iCount As Integer

            For iCount = 0 To CustDs.Tables(1).Rows.Count - 1
                dgvMaster.Rows.Add(CustDs.Tables(1).Rows(iCount)("Num").ToString() _
                                   , CustDs.Tables(1).Rows(iCount)("Item").ToString() _
                                   , CustDs.Tables(1).Rows(iCount)("TotalPieces").ToString() _
                                   , CustDs.Tables(1).Rows(iCount)("UnitPrice").ToString() _
                                   , CustDs.Tables(1).Rows(iCount)("TotalPrice").ToString())
            Next

            For iCount = 0 To dgvMaster.Rows.Count - 2
                If (StockData.ContainsKey(dgvMaster.Rows(iCount).Cells(0).Value)) Then
                    Dim total As Int32 = StockData(dgvMaster.Rows(iCount).Cells(0).Value) + Convert.ToInt32(dgvMaster.Rows(iCount).Cells(2).Value)
                    StockData(dgvMaster.Rows(iCount).Cells(0).Value) = total
                Else
                    StockData.Add(Convert.ToInt32(dgvMaster.Rows(iCount).Cells(0).Value), Convert.ToInt32(dgvMaster.Rows(iCount).Cells(2).Value))
                End If
            Next
        Else
            MsgBox("No Records Found")
            txtName.Clear()
            txtsalesman.Clear()
            txtMobNo.Clear()
            txtFinalTotal.Clear()
            txtbtmTotal.Clear()
            txtdiscount.Clear()
            dgvMaster.Rows.Clear()
        End If
        c.Close()
    End Sub

    Private Sub dgvMaster_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMaster.CellClick

    End Sub

    Public Sub CalculateFinalAmount()
        Dim iCount As Integer = 0
        Dim iTotal As Integer = 0
        For iCount = 0 To dgvMaster.Rows.Count - 1
            iTotal += Convert.ToInt32(dgvMaster.Rows(iCount).Cells(4).Value)
        Next
        txtbtmTotal.Text = iTotal.ToString()
    End Sub

    Public Function CountTotalPrice()
        Dim iCount As Integer = 0
        Dim iTotal As Integer = 0
        For iCount = 0 To dgvMaster.Rows.Count - 1
            iTotal += Convert.ToInt32(dgvMaster.Rows(iCount).Cells(4).Value)
        Next
        Return iTotal
    End Function
End Class