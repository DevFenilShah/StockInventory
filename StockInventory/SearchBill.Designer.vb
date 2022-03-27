<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchBill
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
        Me.txtsalesman = New System.Windows.Forms.TextBox()
        Me.StockDataSet = New StockInventory.StockDataSet()
        Me.StockDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductMasterTableAdapter = New StockInventory.StockDataSetTableAdapters.ProductMasterTableAdapter()
        Me.txtFinalTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbtmTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvMaster = New System.Windows.Forms.DataGridView()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtMobNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.btnprint = New System.Windows.Forms.Button()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtsalesman
        '
        Me.txtsalesman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalesman.Location = New System.Drawing.Point(807, 82)
        Me.txtsalesman.Name = "txtsalesman"
        Me.txtsalesman.ReadOnly = True
        Me.txtsalesman.Size = New System.Drawing.Size(208, 26)
        Me.txtsalesman.TabIndex = 1024
        '
        'StockDataSet
        '
        Me.StockDataSet.DataSetName = "StockDataSet"
        Me.StockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockDataSetBindingSource
        '
        Me.StockDataSetBindingSource.DataSource = Me.StockDataSet
        Me.StockDataSetBindingSource.Position = 0
        '
        'ProductMasterTableAdapter
        '
        Me.ProductMasterTableAdapter.ClearBeforeFill = True
        '
        'txtFinalTotal
        '
        Me.txtFinalTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalTotal.Location = New System.Drawing.Point(700, 520)
        Me.txtFinalTotal.Name = "txtFinalTotal"
        Me.txtFinalTotal.ReadOnly = True
        Me.txtFinalTotal.Size = New System.Drawing.Size(315, 26)
        Me.txtFinalTotal.TabIndex = 1040
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(599, 523)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 20)
        Me.Label10.TabIndex = 1039
        Me.Label10.Text = "Final Total:"
        '
        'txtdiscount
        '
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.Location = New System.Drawing.Point(700, 488)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.ReadOnly = True
        Me.txtdiscount.Size = New System.Drawing.Size(315, 26)
        Me.txtdiscount.TabIndex = 1037
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(581, 491)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 20)
        Me.Label9.TabIndex = 1036
        Me.Label9.Text = "Discount (%):"
        '
        'txtbtmTotal
        '
        Me.txtbtmTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbtmTotal.Location = New System.Drawing.Point(700, 456)
        Me.txtbtmTotal.Name = "txtbtmTotal"
        Me.txtbtmTotal.ReadOnly = True
        Me.txtbtmTotal.Size = New System.Drawing.Size(315, 26)
        Me.txtbtmTotal.TabIndex = 1035
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(599, 459)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 1034
        Me.Label8.Text = "Total Price:"
        '
        'ProductMasterBindingSource
        '
        Me.ProductMasterBindingSource.DataMember = "ProductMaster"
        Me.ProductMasterBindingSource.DataSource = Me.StockDataSet
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(696, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 20)
        Me.Label12.TabIndex = 1041
        Me.Label12.Text = "SalesMan :"
        '
        'dgvMaster
        '
        Me.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaster.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.Item, Me.TotalPiece, Me.UnitPrice, Me.TotalPrice})
        Me.dgvMaster.Location = New System.Drawing.Point(42, 187)
        Me.dgvMaster.Name = "dgvMaster"
        Me.dgvMaster.ReadOnly = True
        Me.dgvMaster.RowHeadersWidth = 51
        Me.dgvMaster.RowTemplate.Height = 24
        Me.dgvMaster.Size = New System.Drawing.Size(973, 239)
        Me.dgvMaster.TabIndex = 1032
        '
        'Number
        '
        Me.Number.HeaderText = "Num"
        Me.Number.MinimumWidth = 6
        Me.Number.Name = "Number"
        Me.Number.ReadOnly = True
        Me.Number.Width = 80
        '
        'Item
        '
        Me.Item.HeaderText = "Item"
        Me.Item.MinimumWidth = 6
        Me.Item.Name = "Item"
        Me.Item.ReadOnly = True
        Me.Item.Width = 220
        '
        'TotalPiece
        '
        Me.TotalPiece.HeaderText = "Total Pieces"
        Me.TotalPiece.MinimumWidth = 6
        Me.TotalPiece.Name = "TotalPiece"
        Me.TotalPiece.ReadOnly = True
        Me.TotalPiece.Width = 125
        '
        'UnitPrice
        '
        Me.UnitPrice.HeaderText = "Unit Price"
        Me.UnitPrice.MinimumWidth = 6
        Me.UnitPrice.Name = "UnitPrice"
        Me.UnitPrice.ReadOnly = True
        Me.UnitPrice.Width = 125
        '
        'TotalPrice
        '
        Me.TotalPrice.HeaderText = "Total Price"
        Me.TotalPrice.MinimumWidth = 6
        Me.TotalPrice.Name = "TotalPrice"
        Me.TotalPrice.ReadOnly = True
        Me.TotalPrice.Width = 125
        '
        'txtMobNo
        '
        Me.txtMobNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobNo.Location = New System.Drawing.Point(121, 128)
        Me.txtMobNo.MaxLength = 10
        Me.txtMobNo.Name = "txtMobNo"
        Me.txtMobNo.ReadOnly = True
        Me.txtMobNo.Size = New System.Drawing.Size(315, 26)
        Me.txtMobNo.TabIndex = 1023
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 1031
        Me.Label3.Text = "Mob No:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(121, 79)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(315, 26)
        Me.txtName.TabIndex = 1022
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(38, 82)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(58, 20)
        Me.lblName.TabIndex = 1030
        Me.lblName.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(739, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 1029
        Me.Label2.Text = "Date :"
        '
        'txtbillno
        '
        Me.txtbillno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillno.Location = New System.Drawing.Point(121, 31)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.Size = New System.Drawing.Size(100, 26)
        Me.txtbillno.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 1028
        Me.Label1.Text = "Bill No:"
        '
        'txtdate
        '
        Me.txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.Location = New System.Drawing.Point(807, 34)
        Me.txtdate.Name = "txtdate"
        Me.txtdate.ReadOnly = True
        Me.txtdate.Size = New System.Drawing.Size(208, 26)
        Me.txtdate.TabIndex = 1042
        '
        'btnprint
        '
        Me.btnprint.Enabled = False
        Me.btnprint.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.Location = New System.Drawing.Point(239, 30)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(85, 29)
        Me.btnprint.TabIndex = 1043
        Me.btnprint.Text = "Print"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'SearchBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1051, 571)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.txtdate)
        Me.Controls.Add(Me.txtsalesman)
        Me.Controls.Add(Me.txtFinalTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtbtmTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvMaster)
        Me.Controls.Add(Me.txtMobNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbillno)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchBill"
        Me.Text = "SearchBill"
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtsalesman As TextBox
    Friend WithEvents StockDataSet As StockDataSet
    Friend WithEvents StockDataSetBindingSource As BindingSource
    Friend WithEvents ProductMasterTableAdapter As StockDataSetTableAdapters.ProductMasterTableAdapter
    Friend WithEvents txtFinalTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtbtmTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ProductMasterBindingSource As BindingSource
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvMaster As DataGridView
    Friend WithEvents Number As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents TotalPiece As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents txtMobNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbillno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtdate As TextBox
    Friend WithEvents btnprint As Button
End Class
