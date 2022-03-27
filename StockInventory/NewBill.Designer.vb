<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewBill
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
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbillno = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtMobNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvMaster = New System.Windows.Forms.DataGridView()
        Me.Number = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Item = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtproname = New System.Windows.Forms.TextBox()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.txtavailable = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnitemclear = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUPrice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTotalPieces = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.StockDataSet = New StockInventory.StockDataSet()
        Me.StockDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductMasterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductMasterTableAdapter = New StockInventory.StockDataSetTableAdapters.ProductMasterTableAdapter()
        Me.txtbtmTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtdiscount = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtFinalTotal = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtsalesman = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkedit = New System.Windows.Forms.CheckBox()
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Location = New System.Drawing.Point(789, 23)
        Me.dtpDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(208, 26)
        Me.dtpDate.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(721, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 20)
        Me.Label2.TabIndex = 1004
        Me.Label2.Text = "Date :"
        '
        'txtbillno
        '
        Me.txtbillno.Enabled = False
        Me.txtbillno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbillno.Location = New System.Drawing.Point(163, 22)
        Me.txtbillno.Name = "txtbillno"
        Me.txtbillno.ReadOnly = True
        Me.txtbillno.Size = New System.Drawing.Size(100, 26)
        Me.txtbillno.TabIndex = 20
        Me.txtbillno.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 1002
        Me.Label1.Text = "Bill No:"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(103, 70)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(315, 26)
        Me.txtName.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(20, 73)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(58, 20)
        Me.lblName.TabIndex = 1006
        Me.lblName.Text = "Name:"
        '
        'txtMobNo
        '
        Me.txtMobNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobNo.Location = New System.Drawing.Point(103, 119)
        Me.txtMobNo.MaxLength = 10
        Me.txtMobNo.Name = "txtMobNo"
        Me.txtMobNo.Size = New System.Drawing.Size(315, 26)
        Me.txtMobNo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 1008
        Me.Label3.Text = "Mob No:"
        '
        'dgvMaster
        '
        Me.dgvMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaster.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Number, Me.Item, Me.TotalPiece, Me.UnitPrice, Me.TotalPrice})
        Me.dgvMaster.Location = New System.Drawing.Point(24, 340)
        Me.dgvMaster.Name = "dgvMaster"
        Me.dgvMaster.ReadOnly = True
        Me.dgvMaster.RowHeadersWidth = 51
        Me.dgvMaster.RowTemplate.Height = 24
        Me.dgvMaster.Size = New System.Drawing.Size(973, 239)
        Me.dgvMaster.TabIndex = 1011
        Me.dgvMaster.TabStop = False
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
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.GroupBox1.Controls.Add(Me.txtproname)
        Me.GroupBox1.Controls.Add(Me.txtnum)
        Me.GroupBox1.Controls.Add(Me.txtavailable)
        Me.GroupBox1.Controls.Add(Me.Label11)
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
        Me.GroupBox1.Location = New System.Drawing.Point(24, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(973, 141)
        Me.GroupBox1.TabIndex = 3
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
        Me.txtproname.TabStop = False
        '
        'txtnum
        '
        Me.txtnum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnum.Location = New System.Drawing.Point(109, 32)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(70, 26)
        Me.txtnum.TabIndex = 4
        '
        'txtavailable
        '
        Me.txtavailable.Enabled = False
        Me.txtavailable.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtavailable.Location = New System.Drawing.Point(109, 87)
        Me.txtavailable.Name = "txtavailable"
        Me.txtavailable.ReadOnly = True
        Me.txtavailable.Size = New System.Drawing.Size(70, 26)
        Me.txtavailable.TabIndex = 151
        Me.txtavailable.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(17, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 20)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "Available:"
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
        Me.btnadd.TabIndex = 6
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(733, 87)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 26)
        Me.txtTotal.TabIndex = 150
        Me.txtTotal.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(627, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Total Price:"
        '
        'txtUPrice
        '
        Me.txtUPrice.Enabled = False
        Me.txtUPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUPrice.Location = New System.Drawing.Point(311, 87)
        Me.txtUPrice.Name = "txtUPrice"
        Me.txtUPrice.ReadOnly = True
        Me.txtUPrice.Size = New System.Drawing.Size(100, 26)
        Me.txtUPrice.TabIndex = 13
        Me.txtUPrice.TabStop = False
        Me.txtUPrice.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(212, 90)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Unit Price :"
        '
        'txtTotalPieces
        '
        Me.txtTotalPieces.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPieces.Location = New System.Drawing.Point(541, 87)
        Me.txtTotalPieces.Name = "txtTotalPieces"
        Me.txtTotalPieces.Size = New System.Drawing.Size(70, 26)
        Me.txtTotalPieces.TabIndex = 5
        Me.txtTotalPieces.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(428, 90)
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
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(900, 710)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(97, 45)
        Me.btnClear.TabIndex = 1013
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(788, 710)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(97, 45)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
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
        'ProductMasterBindingSource
        '
        Me.ProductMasterBindingSource.DataMember = "ProductMaster"
        Me.ProductMasterBindingSource.DataSource = Me.StockDataSet
        '
        'ProductMasterTableAdapter
        '
        Me.ProductMasterTableAdapter.ClearBeforeFill = True
        '
        'txtbtmTotal
        '
        Me.txtbtmTotal.Enabled = False
        Me.txtbtmTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbtmTotal.Location = New System.Drawing.Point(682, 599)
        Me.txtbtmTotal.Name = "txtbtmTotal"
        Me.txtbtmTotal.ReadOnly = True
        Me.txtbtmTotal.Size = New System.Drawing.Size(315, 26)
        Me.txtbtmTotal.TabIndex = 1015
        Me.txtbtmTotal.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(581, 602)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 1014
        Me.Label8.Text = "Total Price:"
        '
        'txtdiscount
        '
        Me.txtdiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiscount.Location = New System.Drawing.Point(682, 631)
        Me.txtdiscount.Name = "txtdiscount"
        Me.txtdiscount.Size = New System.Drawing.Size(315, 26)
        Me.txtdiscount.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(563, 634)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 20)
        Me.Label9.TabIndex = 1016
        Me.Label9.Text = "Discount (%):"
        '
        'txtFinalTotal
        '
        Me.txtFinalTotal.Enabled = False
        Me.txtFinalTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalTotal.Location = New System.Drawing.Point(682, 663)
        Me.txtFinalTotal.Name = "txtFinalTotal"
        Me.txtFinalTotal.ReadOnly = True
        Me.txtFinalTotal.Size = New System.Drawing.Size(315, 26)
        Me.txtFinalTotal.TabIndex = 1019
        Me.txtFinalTotal.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(581, 666)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 20)
        Me.Label10.TabIndex = 1018
        Me.Label10.Text = "Final Total:"
        '
        'txtsalesman
        '
        Me.txtsalesman.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalesman.Location = New System.Drawing.Point(682, 67)
        Me.txtsalesman.Name = "txtsalesman"
        Me.txtsalesman.Size = New System.Drawing.Size(315, 26)
        Me.txtsalesman.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(580, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 20)
        Me.Label12.TabIndex = 1021
        Me.Label12.Text = "SalesMan :"
        '
        'chkedit
        '
        Me.chkedit.AutoSize = True
        Me.chkedit.Location = New System.Drawing.Point(103, 26)
        Me.chkedit.Name = "chkedit"
        Me.chkedit.Size = New System.Drawing.Size(54, 21)
        Me.chkedit.TabIndex = 1022
        Me.chkedit.Text = "Edit"
        Me.chkedit.UseVisualStyleBackColor = True
        '
        'NewBill
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1021, 777)
        Me.Controls.Add(Me.chkedit)
        Me.Controls.Add(Me.txtsalesman)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtFinalTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtdiscount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtbtmTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvMaster)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtMobNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtbillno)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NewBill"
        Me.Text = "NewBill"
        CType(Me.dgvMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.StockDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductMasterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbillno As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents txtMobNo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvMaster As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnitemclear As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUPrice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtTotalPieces As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents StockDataSetBindingSource As BindingSource
    Friend WithEvents StockDataSet As StockDataSet
    Friend WithEvents ProductMasterBindingSource As BindingSource
    Friend WithEvents ProductMasterTableAdapter As StockDataSetTableAdapters.ProductMasterTableAdapter
    Friend WithEvents txtbtmTotal As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtdiscount As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtFinalTotal As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtavailable As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtproname As TextBox
    Friend WithEvents txtnum As TextBox
    Friend WithEvents Number As DataGridViewTextBoxColumn
    Friend WithEvents Item As DataGridViewTextBoxColumn
    Friend WithEvents TotalPiece As DataGridViewTextBoxColumn
    Friend WithEvents UnitPrice As DataGridViewTextBoxColumn
    Friend WithEvents TotalPrice As DataGridViewTextBoxColumn
    Friend WithEvents txtsalesman As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents chkedit As CheckBox
End Class
