Public Class Stock_report
    Public Sub load_product()

        Try
            Dim d As New Dao
            Dim ds As New Data.DataSet

            ds = d.loaddata("Select distinct(Product_Name) from Stock")

            cmb_pname.DisplayMember = "Product_Name"
            'cmb_pname.ValueMember = "Stock_id"
            cmb_pname.DataSource = ds.Tables(0)



        Catch ex As Exception



        End Try
    End Sub
    Private Sub Stock_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_product()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        tot_qty = TextBox1.Text
        If DataGridView1.Rows.Count > 0 Then

            r_type = "Stock_rpt"

            Dim d As New Purchase_Summary_view_rtp

            d.MdiParent = Me.MdiParent

            d.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Dim d As New Dao
            Dim ds As New Data.DataSet

            If cmb_pname.Text <> "" Then

                'all ledger Purchase between date

                ds = d.loaddata("Select Invoice_No,IMEI_NUMBER,Product_Name,HSN_Code,Quantity from Stock where Product_Name = '" & cmb_pname.Text & "'")
            Else

                'all Purchase between date

                ds = d.loaddata("Select Invoice_No,IMEI_NUMBER,Product_Name,HSN_Code,Quantity from Stock")
            End If

            DataGridView1.DataSource = ds.Tables(0)
            dk = ds
            count_total1()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmb_pname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_pname.KeyPress
        If sender.name = cmb_pname.Name Then
            AutoSearch(sender, e, True)
        End If
    End Sub
    Private Sub count_total1()
        Dim d As Integer = DataGridView1.Rows.Count - 1
        Dim q1 As Double = 0
        While d >= 0

            q1 += Val(DataGridView1.Item("Quantity", d).Value)
            'tot_amt += Math.Round(Val(DataGridView1.Item("Total_Amount", d).Value), 2)

            d -= 1
        End While
        TextBox1.Text = q1
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