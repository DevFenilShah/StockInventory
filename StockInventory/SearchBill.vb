Imports System.Data.SqlClient
Public Class SearchBill
    Dim c As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("sqlcon").ConnectionString)
    Dim da As New SqlDataAdapter()
    Dim cmd As New SqlCommand()
    Dim ds, ds1 As New DataSet()
    Dim CustDs As New DataSet()
    Dim dr, dr1 As SqlDataReader

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click
        Dim oPrint As New PrintBill(txtbillno.Text)
        oPrint.Show()
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
            txtdate.Text = CustDs.Tables(0).Rows(0)("Date").ToString()
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

            btnprint.Enabled = True
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

    Private Sub SearchBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class