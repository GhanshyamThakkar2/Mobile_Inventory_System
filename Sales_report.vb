Public Class Sales_report
    Public Sub load_data()

        Try
            Dim d As New Dao
            Dim ds As New Data.DataSet

            ds = d.loaddata("Select dISTINCT(Customer_Name) from Sales_Summary")

            ComboBox1.DisplayMember = "Customer_Name"
            'cmb_pname.ValueMember = "Stock_id"
            ComboBox1.DataSource = ds.Tables(0)

        Catch ex As Exception



        End Try
    End Sub

    Private Sub Sales_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim d As New Dao
            Dim ds As New Data.DataSet

            If ComboBox1.Text <> "" Then

                'all ledger Purchase between date

                ds = d.loaddata("Select Bill_date,Invoice_No,Customer_Name,Total_Amount from Sales_Summary where Customer_Name = '" & ComboBox1.Text & "'")
            Else

                'all Purchase between date

                ds = d.loaddata("Select Bill_date,Invoice_No,Customer_Name,Total_Amount from Sales_Summary")
            End If

            DataGridView1.DataSource = ds.Tables(0)
            dk = ds
            'count_total1()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If DataGridView1.Rows.Count > 0 Then

            r_type = "Sales_rpt"

            Dim d As New Purchase_Summary_view_rtp

            d.MdiParent = Me.MdiParent

            d.Show()
        End If
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

        Me.Close()
    End Sub

    Private Sub Label10_MouseHover(sender As Object, e As EventArgs) Handles Label10.MouseHover

        Label10.BackColor = Color.Red
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave

        Label10.BackColor = Color.Teal
    End Sub
End Class