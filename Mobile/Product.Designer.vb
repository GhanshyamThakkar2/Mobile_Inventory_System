<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Product
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolbarPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Product_DataGridView = New System.Windows.Forms.DataGridView()
        Me.p_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RootLayout.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.ToolbarPanel.SuspendLayout()
        CType(Me.Product_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RootLayout
        '
        Me.RootLayout.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RootLayout.ColumnCount = 1
        Me.RootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootLayout.Controls.Add(Me.HeaderPanel, 0, 0)
        Me.RootLayout.Controls.Add(Me.ToolbarPanel, 0, 1)
        Me.RootLayout.Controls.Add(Me.Product_DataGridView, 0, 2)
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
        Me.Label1.Text = "Product Master"
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
        Me.ToolbarPanel.Controls.Add(Me.Button2)
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
        Me.Label2.Location = New System.Drawing.Point(37, 26)
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
        Me.TextBox1.Location = New System.Drawing.Point(165, 21)
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
        Me.Button1.Location = New System.Drawing.Point(463, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(595, 21)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(150, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Add Product"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Product_DataGridView
        '
        Me.Product_DataGridView.AllowUserToAddRows = False
        Me.Product_DataGridView.AllowUserToResizeColumns = False
        Me.Product_DataGridView.AllowUserToResizeRows = False
        Me.Product_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Product_DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Product_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Product_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.Product_DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Product_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Product_DataGridView.ColumnHeadersHeight = 40
        Me.Product_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Product_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.p_name, Me.amt, Me.sale})
        Me.Product_DataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Product_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Product_DataGridView.EnableHeadersVisualStyles = False
        Me.Product_DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Product_DataGridView.Location = New System.Drawing.Point(37, 152)
        Me.Product_DataGridView.Margin = New System.Windows.Forms.Padding(40, 18, 40, 22)
        Me.Product_DataGridView.MultiSelect = False
        Me.Product_DataGridView.Name = "Product_DataGridView"
        Me.Product_DataGridView.ReadOnly = True
        Me.Product_DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Product_DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.Product_DataGridView.RowHeadersVisible = False
        Me.Product_DataGridView.RowHeadersWidth = 44
        Me.Product_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.Product_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.Product_DataGridView.RowTemplate.Height = 34
        Me.Product_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Product_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Product_DataGridView.Size = New System.Drawing.Size(1176, 576)
        Me.Product_DataGridView.TabIndex = 2
        '
        'p_name
        '
        Me.p_name.DataPropertyName = "Product_Name"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.p_name.DefaultCellStyle = DataGridViewCellStyle2
        Me.p_name.HeaderText = "Product Name"
        Me.p_name.Name = "p_name"
        Me.p_name.ReadOnly = True
        '
        'amt
        '
        Me.amt.DataPropertyName = "Amount"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.amt.DefaultCellStyle = DataGridViewCellStyle3
        Me.amt.HeaderText = "Amount"
        Me.amt.Name = "amt"
        Me.amt.ReadOnly = True
        '
        'sale
        '
        Me.sale.DataPropertyName = "Sales_Rate"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.sale.DefaultCellStyle = DataGridViewCellStyle4
        Me.sale.HeaderText = "Sales Rate"
        Me.sale.Name = "sale"
        Me.sale.ReadOnly = True
        '
        'Product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.RootLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(900, 560)
        Me.Name = "Product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product"
        Me.RootLayout.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.ToolbarPanel.ResumeLayout(False)
        Me.ToolbarPanel.PerformLayout()
        CType(Me.Product_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RootLayout As TableLayoutPanel
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents ToolbarPanel As FlowLayoutPanel
    Friend WithEvents Product_DataGridView As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents p_name As DataGridViewTextBoxColumn
    Friend WithEvents amt As DataGridViewTextBoxColumn
    Friend WithEvents sale As DataGridViewTextBoxColumn
    Friend WithEvents Button2 As Button
End Class
