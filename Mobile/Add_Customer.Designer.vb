<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Customer
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.HeaderPanel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_clr = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Customer_DataGridView = New System.Windows.Forms.DataGridView()
        Me.Customer_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Customer_Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_add = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_cname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_del = New System.Windows.Forms.Button()
        Me.txt_Cno = New System.Windows.Forms.TextBox()
        Me.HeaderPanel.SuspendLayout()
        CType(Me.Customer_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderPanel
        '
        Me.HeaderPanel.BackColor = System.Drawing.Color.Teal
        Me.HeaderPanel.Controls.Add(Me.Label1)
        Me.HeaderPanel.Controls.Add(Me.Label4)
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
        Me.Label1.Text = "Customer Entry"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Teal
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1190, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 68)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "✕"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn_clr
        '
        Me.btn_clr.BackColor = System.Drawing.Color.White
        Me.btn_clr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_clr.FlatAppearance.BorderColor = System.Drawing.Color.Teal
        Me.btn_clr.FlatAppearance.BorderSize = 1
        Me.btn_clr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_clr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_clr.ForeColor = System.Drawing.Color.Teal
        Me.btn_clr.Location = New System.Drawing.Point(17, 18)
        Me.btn_clr.Name = "btn_clr"
        Me.btn_clr.Size = New System.Drawing.Size(141, 36)
        Me.btn_clr.TabIndex = 57
        Me.btn_clr.Text = "Clear"
        Me.btn_clr.UseVisualStyleBackColor = False
        '
        'btn_add
        '
        Me.btn_add.BackColor = System.Drawing.Color.Teal
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_add.ForeColor = System.Drawing.Color.White
        Me.btn_add.Location = New System.Drawing.Point(17, 80)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(141, 36)
        Me.btn_add.TabIndex = 56
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = False
        '
        'Customer_DataGridView
        '
        Me.Customer_DataGridView.AllowUserToAddRows = False
        Me.Customer_DataGridView.AllowUserToDeleteRows = False
        Me.Customer_DataGridView.AllowUserToResizeRows = False
        Me.Customer_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Customer_DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.Customer_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Customer_DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer_DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Customer_DataGridView.ColumnHeadersHeight = 40
        Me.Customer_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Customer_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Customer_ID, Me.Customer_Name, Me.Address, Me.Contact})
        Me.Customer_DataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Customer_DataGridView.EnableHeadersVisualStyles = False
        Me.Customer_DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.Customer_DataGridView.Location = New System.Drawing.Point(20, 328)
        Me.Customer_DataGridView.MultiSelect = False
        Me.Customer_DataGridView.Name = "Customer_DataGridView"
        Me.Customer_DataGridView.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer_DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.Customer_DataGridView.RowHeadersVisible = False
        Me.Customer_DataGridView.RowHeadersWidth = 45
        Me.Customer_DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Customer_DataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.Customer_DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.Customer_DataGridView.RowTemplate.Height = 34
        Me.Customer_DataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Customer_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Customer_DataGridView.Size = New System.Drawing.Size(1189, 378)
        Me.Customer_DataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Customer_DataGridView.TabIndex = 55
        '
        'Customer_ID
        '
        Me.Customer_ID.DataPropertyName = "Customer_ID"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_ID.DefaultCellStyle = DataGridViewCellStyle2
        Me.Customer_ID.HeaderText = "Customer_ID"
        Me.Customer_ID.Name = "Customer_ID"
        Me.Customer_ID.ReadOnly = True
        '
        'Customer_Name
        '
        Me.Customer_Name.DataPropertyName = "Customer_Name"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer_Name.DefaultCellStyle = DataGridViewCellStyle3
        Me.Customer_Name.HeaderText = "Customer_Name"
        Me.Customer_Name.Name = "Customer_Name"
        Me.Customer_Name.ReadOnly = True
        '
        'Address
        '
        Me.Address.DataPropertyName = "Address"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.DefaultCellStyle = DataGridViewCellStyle4
        Me.Address.HeaderText = "Address"
        Me.Address.Name = "Address"
        Me.Address.ReadOnly = True
        Me.Address.Visible = False
        '
        'Contact
        '
        Me.Contact.DataPropertyName = "Contact"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Contact.DefaultCellStyle = DataGridViewCellStyle5
        Me.Contact.HeaderText = "Contact"
        Me.Contact.Name = "Contact"
        Me.Contact.ReadOnly = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(551, 241)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Contact_no"
        '
        'txt_add
        '
        Me.txt_add.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_add.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_add.Location = New System.Drawing.Point(657, 168)
        Me.txt_add.Name = "txt_add"
        Me.txt_add.Size = New System.Drawing.Size(217, 29)
        Me.txt_add.TabIndex = 52
        Me.txt_add.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(572, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Customer Name"
        '
        'txt_cname
        '
        Me.txt_cname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_cname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cname.Location = New System.Drawing.Point(189, 237)
        Me.txt_cname.Name = "txt_cname"
        Me.txt_cname.Size = New System.Drawing.Size(205, 29)
        Me.txt_cname.TabIndex = 50
        Me.txt_cname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Customer_ID"
        '
        'txt_id
        '
        Me.txt_id.BackColor = System.Drawing.Color.White
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_id.Location = New System.Drawing.Point(189, 168)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.ReadOnly = True
        Me.txt_id.Size = New System.Drawing.Size(205, 29)
        Me.txt_id.TabIndex = 48
        Me.txt_id.TabStop = False
        Me.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.btn_del)
        Me.Panel2.Controls.Add(Me.btn_clr)
        Me.Panel2.Controls.Add(Me.btn_add)
        Me.Panel2.Location = New System.Drawing.Point(1036, 113)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(173, 199)
        Me.Panel2.TabIndex = 58
        '
        'btn_del
        '
        Me.btn_del.BackColor = System.Drawing.Color.White
        Me.btn_del.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_del.FlatAppearance.BorderColor = System.Drawing.Color.Crimson
        Me.btn_del.FlatAppearance.BorderSize = 1
        Me.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_del.ForeColor = System.Drawing.Color.Crimson
        Me.btn_del.Location = New System.Drawing.Point(17, 142)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(141, 36)
        Me.btn_del.TabIndex = 58
        Me.btn_del.Text = "Delete"
        Me.btn_del.UseVisualStyleBackColor = False
        '
        'txt_Cno
        '
        Me.txt_Cno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Cno.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Cno.Location = New System.Drawing.Point(657, 241)
        Me.txt_Cno.Name = "txt_Cno"
        Me.txt_Cno.Size = New System.Drawing.Size(217, 29)
        Me.txt_Cno.TabIndex = 61
        Me.txt_Cno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Add_Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1250, 750)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_Cno)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Customer_DataGridView)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txt_add)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_cname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_id)
        Me.Controls.Add(Me.HeaderPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(900, 560)
        Me.Name = "Add_Customer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Customer"
        Me.HeaderPanel.ResumeLayout(False)
        CType(Me.Customer_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents HeaderPanel As Panel
    Friend WithEvents btn_clr As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents Customer_DataGridView As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_add As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_cname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_id As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_del As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_Cno As TextBox
    Friend WithEvents Customer_ID As DataGridViewTextBoxColumn
    Friend WithEvents Customer_Name As DataGridViewTextBoxColumn
    Friend WithEvents Address As DataGridViewTextBoxColumn
    Friend WithEvents Contact As DataGridViewTextBoxColumn
End Class
