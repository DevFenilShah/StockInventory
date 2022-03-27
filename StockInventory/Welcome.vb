Public Class Welcome
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    Private Sub Welcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
        WelcomeTimer.MdiParent = Me
        WelcomeTimer.Location = New Drawing.Point(0, 0)
        WelcomeTimer.Dock = DockStyle.Fill
        WelcomeTimer.Show()
    End Sub

    Private Sub CustomerDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerDataToolStripMenuItem.Click
        StockData.MdiParent = Me
        StockData.Dock = DockStyle.Fill
        StockData.Show()
    End Sub

    Private Sub SearchBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchBillToolStripMenuItem.Click
        PurchaseEntry.MdiParent = Me
        PurchaseEntry.Dock = DockStyle.Fill
        PurchaseEntry.Show()
    End Sub

    Private Sub NewBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewBillToolStripMenuItem.Click
        NewBill.MdiParent = Me
        NewBill.Dock = DockStyle.Fill
        NewBill.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        TodaySellReport.MdiParent = Me
        TodaySellReport.Dock = DockStyle.Fill
        TodaySellReport.Show()
    End Sub

    Private Sub SearchBillToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchBillToolStripMenuItem1.Click
        SearchBill.MdiParent = Me
        SearchBill.Dock = DockStyle.Fill
        SearchBill.Show()
    End Sub
End Class