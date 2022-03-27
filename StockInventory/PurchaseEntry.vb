Imports System.Data.SqlClient
Public Class PurchaseEntry
    Dim c As New SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings("sqlcon").ConnectionString)
    Dim da As New SqlDataAdapter()
    Dim cmd As New SqlCommand()
    Dim ds, ds1 As New DataSet()
    Dim CustDs As New DataSet()
    Dim dr, dr1 As SqlDataReader

    Private Sub PurchaseEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StockDataSet.ProductMaster' table. You can move, or remove it, as needed.
        Me.ProductMasterTableAdapter.Fill(Me.StockDataSet.ProductMaster)
        loadBillNumber()
    End Sub

    Private Sub txtTotalPieces_TextChanged(sender As Object, e As EventArgs) Handles txtTotalPieces.Leave
        If Not (String.IsNullOrEmpty(txtTotalPieces.Text) Or String.IsNullOrEmpty(txtUPrice.Text)) Then
            If Convert.ToInt32(txtUPrice.Text) > 0 And Convert.ToInt32(txtTotalPieces.Text) > 0 Then
                txtTotal.Text = Convert.ToInt32(txtUPrice.Text) * Convert.ToInt32(txtTotalPieces.Text)
            End If
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        c.Open()
        Dim sInsert As String = " Insert into PurchaseMaster values "
        For iCount = 0 To dgvMaster.Rows.Count - 2
            sInsert &= "(" & Convert.ToInt32(txtbillno.Text) & ",'" & dtpDate.Value.ToShortDateString() _
                    & "','" & dgvMaster.Rows(iCount).Cells(0).Value & "','" & dgvMaster.Rows(iCount).Cells(1).Value _
                    & "','" & dgvMaster.Rows(iCount).Cells(2).Value & "','" & dgvMaster.Rows(iCount).Cells(3).Value & "','" & dgvMaster.Rows(iCount).Cells(4).Value & "'),"
        Next

        sInsert = sInsert.Trim(",")
        cmd = New SqlCommand(sInsert, c)
        cmd.ExecuteNonQuery()

        'Update Stock
        For iCount = 0 To dgvMaster.Rows.Count - 2
            cmd = New SqlCommand("update ProductMaster set Stock = Stock + " & dgvMaster.Rows(iCount).Cells(2).Value & " where Number = '" & dgvMaster.Rows(iCount).Cells(0).Value & "'", c)
            cmd.ExecuteNonQuery()
        Next

        'Update next bill number in DB.
        cmd = New SqlCommand("update Sequences set PurchaseBillNumber=" & Convert.ToInt32(txtbillno.Text) + 1, c)
        cmd.ExecuteNonQuery()

        MsgBox("Data Saved.")
        c.Close()

        loadBillNumber()
        dgvMaster.Rows.Clear()
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If Not String.IsNullOrEmpty(txtTotal.Text) Then
            dgvMaster.Rows.Add(txtnum.Text, txtproname.Text, txtTotalPieces.Text, txtUPrice.Text, txtTotal.Text)

            txtnum.Clear()
            txtTotalPieces.Clear()
            txtUPrice.Clear()
            txtTotal.Clear()
            txtproname.Clear()
            txtnum.Focus()
        Else
            MsgBox("Please enter proper data.")
        End If
    End Sub

    Private Sub txtnum_Leave(sender As Object, e As EventArgs) Handles txtnum.Leave
        If Not (String.IsNullOrEmpty(txtnum.Text)) Then
            If StockDataSet.Tables(0).Select("Number = '" & txtnum.Text & "'").Length > 0 Then
                Dim data = StockDataSet.Tables(0).Select("Number = '" & txtnum.Text & "'").FirstOrDefault()
                txtproname.Text = data.ItemArray(2)
                txtUPrice.Text = data.ItemArray(3)
            Else
                MsgBox("Item is not available in stock data.")
            End If
        End If
    End Sub

    Private Sub btnitemclear_Click(sender As Object, e As EventArgs)
        txtnum.Clear()
        txtproname.Clear()
        txtTotalPieces.Text = 0
        txtUPrice.Text = 0
        txtTotal.Text = 0
    End Sub

    Public Sub loadBillNumber()
        c.Open()
        cmd = New SqlCommand("select PurchaseBillNumber from Sequences", c)
        dr = cmd.ExecuteReader()
        If (dr.Read()) Then
            txtbillno.Text = dr(0).ToString
        End If
        c.Close()
    End Sub
End Class