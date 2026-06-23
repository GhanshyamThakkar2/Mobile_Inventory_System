<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Purchase))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_supname = New System.Windows.Forms.TextBox()
        Me.txt_gst_no = New System.Windows.Forms.TextBox()
        Me.txt_brand = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txt_invoice = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.cmb_pname = New System.Windows.Forms.TextBox()
        Me.txt_tot_amt = New System.Windows.Forms.TextBox()
        Me.txt_amt = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_sgst = New System.Windows.Forms.TextBox()
        Me.txt_cgst = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_rate = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hsn = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txt_sgst_amtper = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_cgst_amtper = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_pgst_tot = New System.Windows.Forms.TextBox()
        Me.txt_tot_gst = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_sgst_amt = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_cgst_amt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_round = New System.Windows.Forms.TextBox()
        Me.txt_grd_tot = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Purchase_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Product_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HSN_Code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_CGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_SGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.P_Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Btn_add_list = New System.Windows.Forms.Button()
        Me.Btn_new = New System.Windows.Forms.Button()
        Me.Btn_delete = New System.Windows.Forms.Button()
        Me.Btn_search = New System.Windows.Forms.Button()
        Me.Btn_save = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1250, 57)
        Me.Panel1.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(1005, 11)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(37, 26)
        Me.TextBox3.TabIndex = 29
        Me.TextBox3.Text = "1"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox3.Visible = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1190, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Purchase Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Teal
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.White
        Me.Label22.Location = New System.Drawing.Point(1190, 0)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 57)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "✕"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Ledger Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ledger GST/PAN No"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(462, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Brand"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 77)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 18)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Bill Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(438, 76)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 18)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Due Date (Payment)"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(500, 77)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 18)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Invoice"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(916, 26)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 26)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Product Name"
        '
        'cmb_supname
        '
        Me.cmb_supname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmb_supname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_supname.Location = New System.Drawing.Point(191, 28)
        Me.cmb_supname.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_supname.Name = "cmb_supname"
        Me.cmb_supname.Size = New System.Drawing.Size(206, 26)
        Me.cmb_supname.TabIndex = 8
        '
        'txt_gst_no
        '
        Me.txt_gst_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_gst_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_gst_no.Location = New System.Drawing.Point(191, 74)
        Me.txt_gst_no.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_gst_no.Name = "txt_gst_no"
        Me.txt_gst_no.Size = New System.Drawing.Size(205, 26)
        Me.txt_gst_no.TabIndex = 9
        Me.txt_gst_no.Visible = False
        '
        'txt_brand
        '
        Me.txt_brand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_brand.Location = New System.Drawing.Point(600, 24)
        Me.txt_brand.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Size = New System.Drawing.Size(205, 26)
        Me.txt_brand.TabIndex = 10
        Me.txt_brand.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(600, 74)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(206, 26)
        Me.DateTimePicker2.TabIndex = 8
        Me.DateTimePicker2.Visible = False
        '
        'txt_invoice
        '
        Me.txt_invoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_invoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_invoice.Location = New System.Drawing.Point(600, 74)
        Me.txt_invoice.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_invoice.Name = "txt_invoice"
        Me.txt_invoice.Size = New System.Drawing.Size(205, 26)
        Me.txt_invoice.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.cmb_pname)
        Me.Panel3.Controls.Add(Me.txt_tot_amt)
        Me.Panel3.Controls.Add(Me.txt_amt)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.txt_sgst)
        Me.Panel3.Controls.Add(Me.txt_cgst)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txt_rate)
        Me.Panel3.Controls.Add(Me.txt_qty)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txt_hsn)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Location = New System.Drawing.Point(8, 206)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1183, 137)
        Me.Panel3.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(188, 107)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(82, 21)
        Me.ComboBox1.TabIndex = 28
        Me.ComboBox1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(309, 102)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(43, 26)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TextBox1.Visible = False
        '
        'cmb_pname
        '
        Me.cmb_pname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cmb_pname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_pname.Location = New System.Drawing.Point(146, 24)
        Me.cmb_pname.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_pname.Name = "cmb_pname"
        Me.cmb_pname.Size = New System.Drawing.Size(206, 26)
        Me.cmb_pname.TabIndex = 13
        '
        'txt_tot_amt
        '
        Me.txt_tot_amt.BackColor = System.Drawing.SystemColors.HotTrack
        Me.txt_tot_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tot_amt.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_tot_amt.Location = New System.Drawing.Point(1005, 66)
        Me.txt_tot_amt.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_tot_amt.Name = "txt_tot_amt"
        Me.txt_tot_amt.Size = New System.Drawing.Size(143, 32)
        Me.txt_tot_amt.TabIndex = 26
        Me.txt_tot_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_amt
        '
        Me.txt_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amt.Location = New System.Drawing.Point(1005, 23)
        Me.txt_amt.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_amt.Name = "txt_amt"
        Me.txt_amt.Size = New System.Drawing.Size(143, 26)
        Me.txt_amt.TabIndex = 25
        Me.txt_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(896, 75)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 18)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "Total Amount"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(356, 75)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 51)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Rate (without tax)"
        '
        'txt_sgst
        '
        Me.txt_sgst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sgst.Location = New System.Drawing.Point(730, 72)
        Me.txt_sgst.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_sgst.Name = "txt_sgst"
        Me.txt_sgst.Size = New System.Drawing.Size(123, 26)
        Me.txt_sgst.TabIndex = 22
        Me.txt_sgst.Text = "9"
        Me.txt_sgst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_cgst
        '
        Me.txt_cgst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cgst.Location = New System.Drawing.Point(730, 23)
        Me.txt_cgst.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cgst.Name = "txt_cgst"
        Me.txt_cgst.Size = New System.Drawing.Size(123, 26)
        Me.txt_cgst.TabIndex = 21
        Me.txt_cgst.Text = "9"
        Me.txt_cgst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(641, 75)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 18)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "SGST(%)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(641, 26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 18)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "CGST(%)"
        '
        'txt_rate
        '
        Me.txt_rate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_rate.Location = New System.Drawing.Point(488, 72)
        Me.txt_rate.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_rate.Name = "txt_rate"
        Me.txt_rate.Size = New System.Drawing.Size(123, 26)
        Me.txt_rate.TabIndex = 18
        Me.txt_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_qty
        '
        Me.txt_qty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qty.Location = New System.Drawing.Point(488, 23)
        Me.txt_qty.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.ReadOnly = True
        Me.txt_qty.Size = New System.Drawing.Size(123, 26)
        Me.txt_qty.TabIndex = 17
        Me.txt_qty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(395, 26)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(31, 18)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Qty"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(43, 75)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 18)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "HSN"
        Me.Label10.Visible = False
        '
        'txt_hsn
        '
        Me.txt_hsn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_hsn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_hsn.Location = New System.Drawing.Point(146, 72)
        Me.txt_hsn.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_hsn.Name = "txt_hsn"
        Me.txt_hsn.Size = New System.Drawing.Size(205, 26)
        Me.txt_hsn.TabIndex = 14
        Me.txt_hsn.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.txt_invoice)
        Me.Panel2.Controls.Add(Me.DateTimePicker2)
        Me.Panel2.Controls.Add(Me.txt_brand)
        Me.Panel2.Controls.Add(Me.txt_gst_no)
        Me.Panel2.Controls.Add(Me.cmb_supname)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Location = New System.Drawing.Point(8, 62)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1183, 137)
        Me.Panel2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(191, 74)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(206, 26)
        Me.DateTimePicker1.TabIndex = 13
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txt_sgst_amtper)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.txt_cgst_amtper)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.txt_pgst_tot)
        Me.Panel4.Controls.Add(Me.txt_tot_gst)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.txt_sgst_amt)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.txt_cgst_amt)
        Me.Panel4.Controls.Add(Me.Label18)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.txt_round)
        Me.Panel4.Controls.Add(Me.txt_grd_tot)
        Me.Panel4.Controls.Add(Me.Label16)
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.Location = New System.Drawing.Point(8, 541)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1034, 100)
        Me.Panel4.TabIndex = 27
        '
        'txt_sgst_amtper
        '
        Me.txt_sgst_amtper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sgst_amtper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sgst_amtper.Location = New System.Drawing.Point(188, 35)
        Me.txt_sgst_amtper.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_sgst_amtper.Name = "txt_sgst_amtper"
        Me.txt_sgst_amtper.Size = New System.Drawing.Size(123, 26)
        Me.txt_sgst_amtper.TabIndex = 44
        Me.txt_sgst_amtper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(23, 41)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(138, 18)
        Me.Label23.TabIndex = 43
        Me.Label23.Text = "SGST (per product)"
        '
        'txt_cgst_amtper
        '
        Me.txt_cgst_amtper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cgst_amtper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cgst_amtper.Location = New System.Drawing.Point(188, 8)
        Me.txt_cgst_amtper.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cgst_amtper.Name = "txt_cgst_amtper"
        Me.txt_cgst_amtper.Size = New System.Drawing.Size(123, 26)
        Me.txt_cgst_amtper.TabIndex = 42
        Me.txt_cgst_amtper.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(22, 10)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(139, 18)
        Me.Label24.TabIndex = 41
        Me.Label24.Text = "CGST (per product)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 67)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(165, 18)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Total GST (per product)"
        '
        'txt_pgst_tot
        '
        Me.txt_pgst_tot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pgst_tot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pgst_tot.Location = New System.Drawing.Point(188, 64)
        Me.txt_pgst_tot.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_pgst_tot.Name = "txt_pgst_tot"
        Me.txt_pgst_tot.Size = New System.Drawing.Size(123, 26)
        Me.txt_pgst_tot.TabIndex = 39
        Me.txt_pgst_tot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_tot_gst
        '
        Me.txt_tot_gst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_tot_gst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tot_gst.Location = New System.Drawing.Point(465, 69)
        Me.txt_tot_gst.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_tot_gst.Name = "txt_tot_gst"
        Me.txt_tot_gst.Size = New System.Drawing.Size(123, 26)
        Me.txt_tot_gst.TabIndex = 38
        Me.txt_tot_gst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(373, 71)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(76, 18)
        Me.Label21.TabIndex = 37
        Me.Label21.Text = "Total GST"
        '
        'txt_sgst_amt
        '
        Me.txt_sgst_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_sgst_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sgst_amt.Location = New System.Drawing.Point(465, 38)
        Me.txt_sgst_amt.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_sgst_amt.Name = "txt_sgst_amt"
        Me.txt_sgst_amt.Size = New System.Drawing.Size(123, 26)
        Me.txt_sgst_amt.TabIndex = 36
        Me.txt_sgst_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(373, 38)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(78, 18)
        Me.Label20.TabIndex = 35
        Me.Label20.Text = "Add SGST"
        '
        'txt_cgst_amt
        '
        Me.txt_cgst_amt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cgst_amt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cgst_amt.Location = New System.Drawing.Point(465, 8)
        Me.txt_cgst_amt.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cgst_amt.Name = "txt_cgst_amt"
        Me.txt_cgst_amt.Size = New System.Drawing.Size(123, 26)
        Me.txt_cgst_amt.TabIndex = 33
        Me.txt_cgst_amt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(373, 8)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 18)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Add CGST"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(693, 41)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(86, 18)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "Grand Total"
        '
        'txt_round
        '
        Me.txt_round.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_round.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_round.Location = New System.Drawing.Point(801, 5)
        Me.txt_round.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_round.Name = "txt_round"
        Me.txt_round.Size = New System.Drawing.Size(123, 26)
        Me.txt_round.TabIndex = 30
        Me.txt_round.Text = "0"
        Me.txt_round.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_grd_tot
        '
        Me.txt_grd_tot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_grd_tot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_grd_tot.Location = New System.Drawing.Point(801, 35)
        Me.txt_grd_tot.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_grd_tot.Name = "txt_grd_tot"
        Me.txt_grd_tot.Size = New System.Drawing.Size(123, 26)
        Me.txt_grd_tot.TabIndex = 29
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(693, 10)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 18)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Round off"
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
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 38
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Purchase_id, Me.Product_Name, Me.HSN_Code, Me.Quantity, Me.Rate, Me.P_CGST, Me.P_SGST, Me.P_Total})
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.Location = New System.Drawing.Point(8, 345)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 30
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1034, 192)
        Me.DataGridView1.TabIndex = 28
        '
        'Purchase_id
        '
        Me.Purchase_id.DataPropertyName = "Purchase_id"
        Me.Purchase_id.HeaderText = "ID"
        Me.Purchase_id.Name = "Purchase_id"
        Me.Purchase_id.ReadOnly = True
        Me.Purchase_id.Visible = False
        '
        'Product_Name
        '
        Me.Product_Name.DataPropertyName = "Product_Name"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.Product_Name.DefaultCellStyle = DataGridViewCellStyle2
        Me.Product_Name.HeaderText = "Product Name"
        Me.Product_Name.Name = "Product_Name"
        Me.Product_Name.ReadOnly = True
        '
        'HSN_Code
        '
        Me.HSN_Code.DataPropertyName = "HSN_Code"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.HSN_Code.DefaultCellStyle = DataGridViewCellStyle3
        Me.HSN_Code.HeaderText = "HSN Code"
        Me.HSN_Code.Name = "HSN_Code"
        Me.HSN_Code.ReadOnly = True
        Me.HSN_Code.Visible = False
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.Quantity.DefaultCellStyle = DataGridViewCellStyle4
        Me.Quantity.HeaderText = "Qty"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Rate
        '
        Me.Rate.DataPropertyName = "Rate"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.Rate.DefaultCellStyle = DataGridViewCellStyle5
        Me.Rate.HeaderText = "Rate"
        Me.Rate.Name = "Rate"
        Me.Rate.ReadOnly = True
        '
        'P_CGST
        '
        Me.P_CGST.DataPropertyName = "P_CGST"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.P_CGST.DefaultCellStyle = DataGridViewCellStyle6
        Me.P_CGST.HeaderText = "CGST"
        Me.P_CGST.Name = "P_CGST"
        Me.P_CGST.ReadOnly = True
        '
        'P_SGST
        '
        Me.P_SGST.DataPropertyName = "P_SGST"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.P_SGST.DefaultCellStyle = DataGridViewCellStyle7
        Me.P_SGST.HeaderText = "SGST"
        Me.P_SGST.Name = "P_SGST"
        Me.P_SGST.ReadOnly = True
        '
        'P_Total
        '
        Me.P_Total.DataPropertyName = "P_Total"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.P_Total.DefaultCellStyle = DataGridViewCellStyle8
        Me.P_Total.HeaderText = "Total"
        Me.P_Total.Name = "P_Total"
        Me.P_Total.ReadOnly = True
        '
        'Btn_add_list
        '
        Me.Btn_add_list.BackColor = System.Drawing.Color.White
        Me.Btn_add_list.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.Btn_add_list.FlatAppearance.BorderSize = 1
        Me.Btn_add_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_add_list.ForeColor = System.Drawing.Color.Teal
        Me.Btn_add_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_add_list.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_add_list.Location = New System.Drawing.Point(1052, 379)
        Me.Btn_add_list.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_add_list.Name = "Btn_add_list"
        Me.Btn_add_list.Size = New System.Drawing.Size(139, 49)
        Me.Btn_add_list.TabIndex = 0
        Me.Btn_add_list.Text = "Add to List"
        Me.Btn_add_list.UseVisualStyleBackColor = False
        '
        'Btn_new
        '
        Me.Btn_new.BackColor = System.Drawing.Color.White
        Me.Btn_new.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.Btn_new.FlatAppearance.BorderSize = 1
        Me.Btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_new.ForeColor = System.Drawing.Color.Teal
        Me.Btn_new.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_new.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_new.Location = New System.Drawing.Point(1052, 432)
        Me.Btn_new.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_new.Name = "Btn_new"
        Me.Btn_new.Size = New System.Drawing.Size(139, 49)
        Me.Btn_new.TabIndex = 29
        Me.Btn_new.Text = "New"
        Me.Btn_new.UseVisualStyleBackColor = False
        '
        'Btn_delete
        '
        Me.Btn_delete.BackColor = System.Drawing.Color.White
        Me.Btn_delete.Enabled = False
        Me.Btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.Btn_delete.FlatAppearance.BorderSize = 1
        Me.Btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_delete.ForeColor = System.Drawing.Color.Crimson
        Me.Btn_delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_delete.Location = New System.Drawing.Point(1052, 591)
        Me.Btn_delete.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_delete.Name = "Btn_delete"
        Me.Btn_delete.Size = New System.Drawing.Size(139, 50)
        Me.Btn_delete.TabIndex = 30
        Me.Btn_delete.Text = "Delete"
        Me.Btn_delete.UseVisualStyleBackColor = False
        '
        'Btn_search
        '
        Me.Btn_search.BackColor = System.Drawing.Color.White
        Me.Btn_search.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.Btn_search.FlatAppearance.BorderSize = 1
        Me.Btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_search.ForeColor = System.Drawing.Color.Teal
        Me.Btn_search.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_search.Location = New System.Drawing.Point(1052, 541)
        Me.Btn_search.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_search.Name = "Btn_search"
        Me.Btn_search.Size = New System.Drawing.Size(139, 43)
        Me.Btn_search.TabIndex = 31
        Me.Btn_search.Text = "Search"
        Me.Btn_search.UseVisualStyleBackColor = False
        '
        'Btn_save
        '
        Me.Btn_save.BackColor = System.Drawing.Color.Teal
        Me.Btn_save.FlatAppearance.BorderSize = 0
        Me.Btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_save.ForeColor = System.Drawing.Color.White
        Me.Btn_save.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_save.Location = New System.Drawing.Point(1052, 485)
        Me.Btn_save.Margin = New System.Windows.Forms.Padding(2)
        Me.Btn_save.Name = "Btn_save"
        Me.Btn_save.Size = New System.Drawing.Size(139, 52)
        Me.Btn_save.TabIndex = 32
        Me.Btn_save.Text = "Save"
        Me.Btn_save.UseVisualStyleBackColor = False
        '
        'Add_Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.AutoScroll = True
        Me.AutoScrollMinSize = New System.Drawing.Size(1221, 673)
        Me.ClientSize = New System.Drawing.Size(1221, 673)
        Me.ControlBox = False
        Me.Controls.Add(Me.Btn_save)
        Me.Controls.Add(Me.Btn_add_list)
        Me.Controls.Add(Me.Btn_search)
        Me.Controls.Add(Me.Btn_delete)
        Me.Controls.Add(Me.Btn_new)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Add_Purchase"
        Me.Text = "Add_Purchase"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_invoice As TextBox
    Friend WithEvents txt_brand As TextBox
    Friend WithEvents txt_gst_no As TextBox
    Friend WithEvents cmb_supname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_qty As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_hsn As TextBox
    Friend WithEvents txt_sgst As TextBox
    Friend WithEvents txt_cgst As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_rate As TextBox
    Friend WithEvents txt_tot_amt As TextBox
    Friend WithEvents txt_amt As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btn_add_list As Button
    Friend WithEvents Btn_new As Button
    Friend WithEvents Btn_delete As Button
    Friend WithEvents Btn_search As Button
    Friend WithEvents Btn_save As Button
    Friend WithEvents txt_cgst_amt As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_round As TextBox
    Friend WithEvents txt_grd_tot As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_tot_gst As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_sgst_amt As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents cmb_pname As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_pgst_tot As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_sgst_amtper As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txt_cgst_amtper As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Purchase_id As DataGridViewTextBoxColumn
    Friend WithEvents Product_Name As DataGridViewTextBoxColumn
    Friend WithEvents HSN_Code As DataGridViewTextBoxColumn
    Friend WithEvents Quantity As DataGridViewTextBoxColumn
    Friend WithEvents Rate As DataGridViewTextBoxColumn
    Friend WithEvents P_CGST As DataGridViewTextBoxColumn
    Friend WithEvents P_SGST As DataGridViewTextBoxColumn
    Friend WithEvents P_Total As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox3 As TextBox
End Class
