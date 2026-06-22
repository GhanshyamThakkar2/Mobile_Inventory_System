<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RootLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolbarPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Invoice_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bill_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Due_Date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ledger_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_pgst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Label1.Text = "Purchase Master"
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
        Me.ToolbarPanel.Controls.Add(Me.Label3)
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(40, 26)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 5, 12, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Search/Filter"
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
        Me.Button1.BackColor = System.Drawing.Color.Teal
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(466, 21)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Purchase Entry"
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 40
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Invoice_No, Me.Bill_Date, Me.Due_Date, Me.Ledger_Name, Me.Total_pgst, Me.Total_Amount})
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(40, 162)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(40, 18, 40, 22)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.RowTemplate.Height = 34
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1170, 568)
        Me.DataGridView1.TabIndex = 2
        '
        'Invoice_No
        '
        Me.Invoice_No.DataPropertyName = "Invoice_No"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Invoice_No.DefaultCellStyle = DataGridViewCellStyle2
        Me.Invoice_No.HeaderText = "Invoice No"
        Me.Invoice_No.Name = "Invoice_No"
        Me.Invoice_No.ReadOnly = True
        '
        'Bill_Date
        '
        Me.Bill_Date.DataPropertyName = "Bill_Date"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Bill_Date.DefaultCellStyle = DataGridViewCellStyle3
        Me.Bill_Date.HeaderText = "Bill Date"
        Me.Bill_Date.Name = "Bill_Date"
        Me.Bill_Date.ReadOnly = True
        '
        'Due_Date
        '
        Me.Due_Date.DataPropertyName = "Due_Date"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Due_Date.DefaultCellStyle = DataGridViewCellStyle4
        Me.Due_Date.HeaderText = "Due Date"
        Me.Due_Date.Name = "Due_Date"
        Me.Due_Date.ReadOnly = True
        '
        'Ledger_Name
        '
        Me.Ledger_Name.DataPropertyName = "Ledger_Name"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ledger_Name.DefaultCellStyle = DataGridViewCellStyle5
        Me.Ledger_Name.HeaderText = "Ledger Name"
        Me.Ledger_Name.Name = "Ledger_Name"
        Me.Ledger_Name.ReadOnly = True
        '
        'Total_pgst
        '
        Me.Total_pgst.DataPropertyName = "Total_pgst"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Total_pgst.DefaultCellStyle = DataGridViewCellStyle6
        Me.Total_pgst.HeaderText = "Total GST"
        Me.Total_pgst.Name = "Total_pgst"
        Me.Total_pgst.ReadOnly = True
        '
        'Total_Amount
        '
        Me.Total_Amount.DataPropertyName = "Total_Amount"
        Me.Total_Amount.HeaderText = "Total Amount"
        Me.Total_Amount.Name = "Total_Amount"
        Me.Total_Amount.ReadOnly = True
        '
        'Purchase
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
        Me.Name = "Purchase"
        Me.Text = "Purchase"
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
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Invoice_No As DataGridViewTextBoxColumn
    Friend WithEvents Bill_Date As DataGridViewTextBoxColumn
    Friend WithEvents Due_Date As DataGridViewTextBoxColumn
    Friend WithEvents Ledger_Name As DataGridViewTextBoxColumn
    Friend WithEvents Total_pgst As DataGridViewTextBoxColumn
    Friend WithEvents Total_Amount As DataGridViewTextBoxColumn
End Class
