<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockDataSet = New StockInventory.StockDataSet()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ProductMasterTableAdapter = New StockInventory.StockDataSetTableAdapters.ProductMasterTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtproname = New System.Windows.Forms.TextBox()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.btnitemclear = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalPieces = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvMaster = New System.Windows.Forms.DataGridView()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bill No:"
        '
        'txtbillno
        '
        Me.txtbillno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillno.Location = New System.Drawing.Point(110, 21)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.ReadOnly = True
        Me.txtbillno.Size = New System.Drawing.Size(100, 26)
        Me.txtbillno.TabIndex = 1
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(796, 19)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(208, 26)
        Me.dtpDate.TabIndex = 1001
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(733, 22)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 1000
        Me.Label2.Text = "Date :"
        '
        'ProductMasterBindingSource
        '
        Me.ProductMasterBindingSource.DataMember = "ProductMaster"
        Me.ProductMasterBindingSource.DataSource = Me.StockDataSet
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(767, 505)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 45)
        Me.btnSave.TabIndex = 1004
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(888, 505)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 45)
        Me.btnClear.TabIndex = 1005
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ProductMasterTableAdapter
        '
        Me.ProductMasterTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.txtproname)
        Me.GroupBox1.Controls.Add(Me.txtnum)
        Me.GroupBox1.Controls.Add(Me.btnitemclear)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtUPrice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtTotalPieces)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(31, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(973, 141)
        Me.GroupBox1.TabIndex = 1006
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items"
        '
        'txtproname
        '
        Me.txtproname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproname.Location = New System.Drawing.Point(205, 32)
        Me.txtproname.Name = "txtproname"
        Me.txtproname.ReadOnly = True
        Me.txtproname.Size = New System.Drawing.Size(628, 26)
        Me.txtproname.TabIndex = 154
        '
        'txtnum
        '
        Me.txtnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum.Location = New System.Drawing.Point(109, 32)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(70, 26)
        Me.txtnum.TabIndex = 3
        '
        'btnitemclear
        '
        Me.btnitemclear.Location = New System.Drawing.Point(857, 78)
        Me.btnitemclear.Name = "btnitemclear"
        Me.btnitemclear.Size = New System.Drawing.Size(97, 45)
        Me.btnitemclear.TabIndex = 16
        Me.btnitemclear.Text = "Clear"
        Me.btnitemclear.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(857, 23)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(97, 45)
        Me.btnadd.TabIndex = 5
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(538, 87)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 26)
        Me.txtTotal.TabIndex = 150
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(432, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Price:"
        '
        'txtUPrice
        '
        Me.txtUPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPrice.Location = New System.Drawing.Point(116, 87)
        Me.txtUPrice.Name = "txtUPrice"
        Me.txtUPrice.ReadOnly = True
        Me.txtUPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtUPrice.TabIndex = 13
        Me.txtUPrice.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Unit Price :"
        '
        'txtTotalPieces
        '
        Me.txtTotalPieces.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPieces.Location = New System.Drawing.Point(346, 87)
        Me.txtTotalPieces.Name = "txtTotalPieces"
        Me.txtTotalPieces.Size = New System.Drawing.Size(70, 26)
        Me.txtTotalPieces.TabIndex = 4
        Me.txtTotalPieces.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total Pieces:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 20)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Number:"
        '
        'dgvMaster
        '
        Me.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaster.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.Item, Me.TotalPiece, Me.UnitPrice, Me.TotalPrice})
        Me.dgvMaster.Location = New System.Drawing.Point(31, 241)
        Me.dgvMaster.Name = "dgvMaster"
        Me.dgvMaster.RowHeadersWidth = 51
        Me.dgvMaster.RowTemplate.Height = 24
        Me.dgvMaster.Size = New System.Drawing.Size(973, 239)
        Me.dgvMaster.TabIndex = 1012
        '
        'Number
        '
        Me.Number.HeaderText = "Num"
        Me.Number.MinimumWidth = 6
        Me.Number.Name = "Number"
        Me.Number.Width = 80
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.MinimumWidth = 6
        Me.Item.Name = "Item"
        Me.Item.Width = 220
        '
        'TotalPiece
        '
        Me.TotalPiece.HeaderText = "Total Pieces"
        Me.TotalPiece.MinimumWidth = 6
        Me.TotalPiece.Name = "TotalPiece"
        Me.TotalPiece.Width = 125
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.MinimumWidth = 6
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.Width = 125
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "Total Price"
        Me.TotalPrice.MinimumWidth = 6
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.Width = 125
        '
        'PurchaseEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1034, 574)
        Me.Controls.Add(Me.dgvMaster)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbillno)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PurchaseEntry"
        Me.Text = "PurchaseEntry"
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtbillno As TextBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents StockDataSet As StockDataSet
    Friend WithEvents ProductMasterBindingSource As BindingSource
    Friend WithEvents ProductMasterTableAdapter As StockDataSetTableAdapters.ProductMasterTableAdapter
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtproname As TextBox
    Friend WithEvents txtnum As TextBox
    Friend WithEvents txtavailable As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnitemclear As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalPieces As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvMaster As DataGridView
    Friend WithEvents Number As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents TotalPiece As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
End Class
