<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_product
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_product))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_pname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_GST = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cgst_sgst = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_rate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_brate = New System.Windows.Forms.TextBox()
        Me.txt_sales_rate = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.p_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CGST_SGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sales_Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.HeaderPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.Teal
        Me.HeaderPanel.Controls.Add(Me.Label1)
        Me.HeaderPanel.Controls.Add(Me.Label9)
        Me.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top
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
        Me.Label1.Text = "Product Entry"
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(81, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "P_ID"
        Me.Label2.Visible = False
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.White
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(204, 149)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(211, 29)
        Me.txt_id.TabIndex = 23
        Me.txt_id.TabStop = False
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_id.Visible = False
        '
        'txt_pname
        '
        Me.txt_pname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pname.Location = New System.Drawing.Point(204, 149)
        Me.txt_pname.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_pname.Name = "txt_pname"
        Me.txt_pname.Size = New System.Drawing.Size(211, 29)
        Me.txt_pname.TabIndex = 24
        Me.txt_pname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Product Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(78, 211)
        Me.Label8.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "GST  (%)"
        '
        'txt_GST
        '
        Me.txt_GST.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_GST.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_GST.Location = New System.Drawing.Point(204, 207)
        Me.txt_GST.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_GST.Name = "txt_GST"
        Me.txt_GST.Size = New System.Drawing.Size(211, 29)
        Me.txt_GST.TabIndex = 29
        Me.txt_GST.Text = "18"
        Me.txt_GST.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(553, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Rate"
        '
        'txt_cgst_sgst
        '
        Me.txt_cgst_sgst.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cgst_sgst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cgst_sgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cgst_sgst.Location = New System.Drawing.Point(204, 264)
        Me.txt_cgst_sgst.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cgst_sgst.Name = "txt_cgst_sgst"
        Me.txt_cgst_sgst.ReadOnly = True
        Me.txt_cgst_sgst.Size = New System.Drawing.Size(211, 29)
        Me.txt_cgst_sgst.TabIndex = 25
        Me.txt_cgst_sgst.Text = "0"
        Me.txt_cgst_sgst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(43, 270)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "CGST/SGST  (%)"
        '
        'txt_rate
        '
        Me.txt_rate.BackColor = System.Drawing.SystemColors.Window
        Me.txt_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rate.Location = New System.Drawing.Point(653, 146)
        Me.txt_rate.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.ReadOnly = True
        Me.txt_rate.Size = New System.Drawing.Size(211, 29)
        Me.txt_rate.TabIndex = 31
        Me.txt_rate.Text = "0"
        Me.txt_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(541, 268)
        Me.Label7.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Sales Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(541, 211)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Buy Rate"
        '
        'txt_brate
        '
        Me.txt_brate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_brate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brate.Location = New System.Drawing.Point(653, 207)
        Me.txt_brate.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_brate.Name = "txt_brate"
        Me.txt_brate.Size = New System.Drawing.Size(211, 29)
        Me.txt_brate.TabIndex = 26
        Me.txt_brate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_sales_rate
        '
        Me.txt_sales_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sales_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sales_rate.Location = New System.Drawing.Point(653, 266)
        Me.txt_sales_rate.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_sales_rate.Name = "txt_sales_rate"
        Me.txt_sales_rate.Size = New System.Drawing.Size(211, 29)
        Me.txt_sales_rate.TabIndex = 27
        Me.txt_sales_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btn_del)
        Me.Panel2.Controls.Add(Me.btn_clr)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Location = New System.Drawing.Point(1021, 124)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 235)
        Me.Panel2.TabIndex = 32
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.White
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.btn_del.FlatAppearance.BorderSize = 1
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.ForeColor = System.Drawing.Color.Crimson
        Me.btn_del.Location = New System.Drawing.Point(19, 142)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(141, 36)
        Me.btn_del.TabIndex = 38
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'btn_clr
        '
        Me.btn_clr.BackColor = System.Drawing.Color.White
        Me.btn_clr.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_clr.FlatAppearance.BorderSize = 1
        Me.btn_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clr.ForeColor = System.Drawing.Color.Teal
        Me.btn_clr.Location = New System.Drawing.Point(19, 16)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(141, 36)
        Me.btn_clr.TabIndex = 37
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Teal
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(19, 80)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(141, 36)
        Me.btn_add.TabIndex = 36
        Me.btn_add.Text = "ADD"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DataGridView1.EnableHeadersVisualStyles = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.p_id, Me.p_name, Me.Rate, Me.GST, Me.CGST_SGST, Me.Amount, Me.Sales_Rate})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.Location = New System.Drawing.Point(20, 383)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle9
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.RowTemplate.Height = 34
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1182, 328)
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.TabIndex = 33
        '
        'p_id
        '
        Me.p_id.DataPropertyName = "Product_id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.p_id.DefaultCellStyle = DataGridViewCellStyle2
        Me.p_id.HeaderText = "Product ID"
        Me.p_id.Name = "p_id"
        Me.p_id.ReadOnly = True
        Me.p_id.Visible = False
        '
        'p_name
        '
        Me.p_name.DataPropertyName = "Product_name"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.p_name.DefaultCellStyle = DataGridViewCellStyle3
        Me.p_name.HeaderText = "Product Name"
        Me.p_name.Name = "p_name"
        Me.p_name.ReadOnly = True
        '
        'Rate
        '
        Me.Rate.DataPropertyName = "Rate"
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle4
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        Me.Rate.Visible = False
        '
        'GST
        '
        Me.GST.DataPropertyName = "GST"
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        Me.GST.DefaultCellStyle = DataGridViewCellStyle5
        Me.GST.HeaderText = "GST"
        Me.GST.Name = "GST"
        Me.GST.ReadOnly = True
        Me.GST.Visible = False
        '
        'CGST_SGST
        '
        Me.CGST_SGST.DataPropertyName = "CGST/SGST"
        Me.CGST_SGST.HeaderText = "CGST SGST"
        Me.CGST_SGST.Name = "CGST_SGST"
        Me.CGST_SGST.ReadOnly = True
        Me.CGST_SGST.Visible = False
        '
        'Amount
        '
        Me.Amount.DataPropertyName = "Amount"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.Amount.DefaultCellStyle = DataGridViewCellStyle6
        Me.Amount.HeaderText = "Amount"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'Sales_Rate
        '
        Me.Sales_Rate.DataPropertyName = "Sales_Rate"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.Sales_Rate.DefaultCellStyle = DataGridViewCellStyle7
        Me.Sales_Rate.HeaderText = "Sales Rate"
        Me.Sales_Rate.Name = "Sales_Rate"
        Me.Sales_Rate.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Location = New System.Drawing.Point(-2, 92)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(1255, 8)
        Me.Label10.TabIndex = 69
        '
        'Add_product
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.HeaderPanel)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.txt_pname)
        Me.Controls.Add(Me.txt_sales_rate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_brate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_GST)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_rate)
        Me.Controls.Add(Me.txt_cgst_sgst)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Add_product"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_product"
        Me.HeaderPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents txt_pname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_GST As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cgst_sgst As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_rate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_brate As TextBox
    Friend WithEvents txt_sales_rate As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_clr As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents p_id As DataGridViewTextBoxColumn
    Friend WithEvents p_name As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents GST As DataGridViewTextBoxColumn
    Friend WithEvents CGST_SGST As DataGridViewTextBoxColumn
    Friend WithEvents Amount As DataGridViewTextBoxColumn
    Friend WithEvents Sales_Rate As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents HeaderPanel As Panel
End Class
