<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolbarPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Supplier_DataGridView = New System.Windows.Forms.DataGridView()
        Me.gst_no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.state = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.city = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pay_du = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.b_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RootLayout.SuspendLayout()
        Me.HeaderPanel.SuspendLayout()
        Me.ToolbarPanel.SuspendLayout()
        CType(Me.Supplier_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RootLayout
        '
        Me.RootLayout.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.RootLayout.ColumnCount = 1
        Me.RootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.RootLayout.Controls.Add(Me.HeaderPanel, 0, 0)
        Me.RootLayout.Controls.Add(Me.ToolbarPanel, 0, 1)
        Me.RootLayout.Controls.Add(Me.Supplier_DataGridView, 0, 2)
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
        Me.Label1.Text = "Supplier Master"
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
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(598, 21)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 34)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Supplier Entry"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Supplier_DataGridView
        '
        Me.Supplier_DataGridView.AllowUserToAddRows = False
        Me.Supplier_DataGridView.AllowUserToDeleteRows = False
        Me.Supplier_DataGridView.AllowUserToResizeRows = False
        Me.Supplier_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Supplier_DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Supplier_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Supplier_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Supplier_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Supplier_DataGridView.ColumnHeadersHeight = 44
        Me.Supplier_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Supplier_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.gst_no, Me.s_name, Me.contact, Me.address, Me.brand, Me.state, Me.city, Me.pay_du, Me.b_name})
        Me.Supplier_DataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Supplier_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Supplier_DataGridView.EnableHeadersVisualStyles = False
        Me.Supplier_DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Supplier_DataGridView.Location = New System.Drawing.Point(40, 162)
        Me.Supplier_DataGridView.Margin = New System.Windows.Forms.Padding(40, 18, 40, 22)
        Me.Supplier_DataGridView.MultiSelect = False
        Me.Supplier_DataGridView.Name = "Supplier_DataGridView"
        Me.Supplier_DataGridView.ReadOnly = True
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Supplier_DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.Supplier_DataGridView.RowHeadersVisible = False
        Me.Supplier_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        Me.Supplier_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle12
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.Supplier_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.Supplier_DataGridView.RowTemplate.Height = 32
        Me.Supplier_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Supplier_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Supplier_DataGridView.Size = New System.Drawing.Size(1170, 568)
        Me.Supplier_DataGridView.TabIndex = 2
        '
        'gst_no
        '
        Me.gst_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.gst_no.DataPropertyName = "GST_No"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.gst_no.DefaultCellStyle = DataGridViewCellStyle2
        Me.gst_no.FillWeight = 108.194!
        Me.gst_no.HeaderText = "GST No"
        Me.gst_no.Name = "gst_no"
        Me.gst_no.ReadOnly = True
        '
        's_name
        '
        Me.s_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.s_name.DataPropertyName = "Supplier_Name"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.s_name.DefaultCellStyle = DataGridViewCellStyle3
        Me.s_name.FillWeight = 144.4039!
        Me.s_name.HeaderText = "Supplier Name"
        Me.s_name.Name = "s_name"
        Me.s_name.ReadOnly = True
        '
        'contact
        '
        Me.contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.contact.DataPropertyName = "Contact_no"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.contact.DefaultCellStyle = DataGridViewCellStyle4
        Me.contact.FillWeight = 82.31903!
        Me.contact.HeaderText = "Contact No"
        Me.contact.Name = "contact"
        Me.contact.ReadOnly = True
        '
        'address
        '
        Me.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.address.DataPropertyName = "Address"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.address.DefaultCellStyle = DataGridViewCellStyle5
        Me.address.FillWeight = 133.858!
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'brand
        '
        Me.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.brand.DataPropertyName = "Brand"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.brand.DefaultCellStyle = DataGridViewCellStyle6
        Me.brand.FillWeight = 92.88605!
        Me.brand.HeaderText = "Brand"
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = True
        '
        'state
        '
        Me.state.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.state.DataPropertyName = "State"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.state.DefaultCellStyle = DataGridViewCellStyle7
        Me.state.FillWeight = 102.4727!
        Me.state.HeaderText = "State"
        Me.state.Name = "state"
        Me.state.ReadOnly = True
        '
        'city
        '
        Me.city.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.city.DataPropertyName = "City"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.city.DefaultCellStyle = DataGridViewCellStyle8
        Me.city.FillWeight = 55.95609!
        Me.city.HeaderText = "City"
        Me.city.Name = "city"
        Me.city.ReadOnly = True
        '
        'pay_du
        '
        Me.pay_du.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.pay_du.DataPropertyName = "Payment_Duration"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.pay_du.DefaultCellStyle = DataGridViewCellStyle9
        Me.pay_du.FillWeight = 129.3644!
        Me.pay_du.HeaderText = "Payment Duration"
        Me.pay_du.Name = "pay_du"
        Me.pay_du.ReadOnly = True
        '
        'b_name
        '
        Me.b_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.b_name.DataPropertyName = "Bank_Name"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.b_name.DefaultCellStyle = DataGridViewCellStyle10
        Me.b_name.FillWeight = 100.0!
        Me.b_name.HeaderText = "Bank Name"
        Me.b_name.Name = "b_name"
        Me.b_name.ReadOnly = True
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.RootLayout)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(900, 560)
        Me.Name = "Supplier"
        Me.Text = "Supplier"
        Me.RootLayout.ResumeLayout(False)
        Me.HeaderPanel.ResumeLayout(False)
        Me.ToolbarPanel.ResumeLayout(False)
        Me.ToolbarPanel.PerformLayout()
        CType(Me.Supplier_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RootLayout As TableLayoutPanel
    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents ToolbarPanel As FlowLayoutPanel
    Friend WithEvents Supplier_DataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents gst_no As DataGridViewTextBoxColumn
    Friend WithEvents s_name As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents state As DataGridViewTextBoxColumn
    Friend WithEvents city As DataGridViewTextBoxColumn
    Friend WithEvents pay_du As DataGridViewTextBoxColumn
    Friend WithEvents b_name As DataGridViewTextBoxColumn
End Class
