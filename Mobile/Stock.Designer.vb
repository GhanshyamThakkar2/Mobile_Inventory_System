<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stock
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolbarPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Stock_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Invoice_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMEI_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HSN_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RootLayout.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.ToolbarPanel.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RootLayout
        '
        Me.RootLayout.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RootLayout.ColumnCount = 1
        Me.RootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootLayout.Controls.Add(Me.HeaderPanel, 0, 0)
        Me.RootLayout.Controls.Add(Me.ToolbarPanel, 0, 1)
        Me.RootLayout.Controls.Add(Me.DataGridView1, 0, 2)
        Me.RootLayout.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RootLayout.Location = New System.Drawing.Point(0, 0)
        Me.RootLayout.Name = "RootLayout"
        Me.RootLayout.RowCount = 3
        Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootLayout.Size = New System.Drawing.Size(1250, 750)
        Me.RootLayout.TabIndex = 0
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.Teal
        Me.HeaderPanel.Controls.Add(Me.Label1)
        Me.HeaderPanel.Controls.Add(Me.Label9)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HeaderPanel.Location = New System.Drawing.Point(0, 0)
        Me.HeaderPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.HeaderPanel.Name = "HeaderPanel"
        Me.HeaderPanel.Size = New System.Drawing.Size(1250, 68)
        Me.HeaderPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1190, 68)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Master"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Teal
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1190, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 68)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "✕"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolbarPanel
        '
        Me.ToolbarPanel.Controls.Add(Me.Label2)
        Me.ToolbarPanel.Controls.Add(Me.TextBox1)
        Me.ToolbarPanel.Controls.Add(Me.Button1)
        Me.ToolbarPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolbarPanel.Location = New System.Drawing.Point(0, 68)
        Me.ToolbarPanel.Margin = New System.Windows.Forms.Padding(0)
        Me.ToolbarPanel.Name = "ToolbarPanel"
        Me.ToolbarPanel.Padding = New System.Windows.Forms.Padding(40, 21, 20, 0)
        Me.ToolbarPanel.Size = New System.Drawing.Size(1250, 76)
        Me.ToolbarPanel.TabIndex = 1
        Me.ToolbarPanel.WrapContents = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 5, 12, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Search/Filter"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(168, 21)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0, 0, 18, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(280, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.Button1.FlatAppearance.BorderSize = 1
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Teal
        Me.Button1.Location = New System.Drawing.Point(466, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Stock_id, Me.Invoice_No, Me.Product_Name, Me.IMEI_NUMBER, Me.HSN_Code, Me.Quantity})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(40, 162)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(40, 18, 40, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 44
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle12
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.RowTemplate.Height = 34
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1170, 568)
        Me.DataGridView1.TabIndex = 2
        '
        'Stock_id
        '
        Me.Stock_id.DataPropertyName = "Stock_id"
        Me.Stock_id.HeaderText = "Stock Id"
        Me.Stock_id.Name = "Stock_id"
        Me.Stock_id.ReadOnly = True
        Me.Stock_id.Visible = False
        '
        'Invoice_No
        '
        Me.Invoice_No.DataPropertyName = "Invoice_No"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Invoice_No.DefaultCellStyle = DataGridViewCellStyle8
        Me.Invoice_No.HeaderText = "Invoice No"
        Me.Invoice_No.Name = "Invoice_No"
        Me.Invoice_No.ReadOnly = True
        '
        'Product_Name
        '
        Me.Product_Name.DataPropertyName = "Product_Name"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Product_Name.DefaultCellStyle = DataGridViewCellStyle9
        Me.Product_Name.HeaderText = "Product Name"
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.ReadOnly = True
        '
        'IMEI_NUMBER
        '
        Me.IMEI_NUMBER.DataPropertyName = "IMEI_NUMBER"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.IMEI_NUMBER.DefaultCellStyle = DataGridViewCellStyle10
        Me.IMEI_NUMBER.HeaderText = "IMEI Number"
        Me.IMEI_NUMBER.Name = "IMEI_NUMBER"
        Me.IMEI_NUMBER.ReadOnly = True
        '
        'HSN_Code
        '
        Me.HSN_Code.DataPropertyName = "HSN_Code"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.HSN_Code.DefaultCellStyle = DataGridViewCellStyle11
        Me.HSN_Code.HeaderText = "HSN Code"
        Me.HSN_Code.Name = "HSN_Code"
        Me.HSN_Code.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Stock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.RootLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(900, 560)
        Me.Name = "Stock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock"
        Me.RootLayout.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.ToolbarPanel.ResumeLayout(False)
        Me.ToolbarPanel.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootLayout As TableLayoutPanel
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents ToolbarPanel As FlowLayoutPanel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Stock_id As DataGridViewTextBoxColumn
    Friend WithEvents Invoice_No As DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents IMEI_NUMBER As DataGridViewTextBoxColumn
    Friend WithEvents HSN_Code As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
End Class
