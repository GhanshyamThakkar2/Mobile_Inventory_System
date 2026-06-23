Imports System.Data.SqlClient
Public Class IMEI_store
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Textbox1.TextChanged

        DataGridView1.RowCount = Val(Textbox1.Text)



    End Sub

    ' Quantity must be numeric only
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textbox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    ' When the form opens, show the IMEIs already entered for this line (if any).
    Private Sub IMEI_store_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim d As New Dao
            Dim ds As New Data.DataSet
            ds = d.loaddata("select IMEI_NUMBER from IMEI_NUM")
            Dim n As Integer = ds.Tables(0).Rows.Count
            If n > 0 Then
                Textbox1.Text = n.ToString()
                For i As Integer = 0 To n - 1
                    DataGridView1.Rows(i).Cells("IMEI_NUMBER").Value = ds.Tables(0).Rows(i)("IMEI_NUMBER").ToString()
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Make sure every IMEI box is filled for the entered quantity
        For Each row As DataGridViewRow In DataGridView1.Rows
            If row.IsNewRow Then Continue For
            Dim v As Object = row.Cells("IMEI_NUMBER").Value
            If v Is Nothing OrElse v.ToString().Trim() = "" Then
                MessageBox.Show("Please enter the IMEI number for all " & DataGridView1.RowCount & " item(s) before saving.",
                                "IMEI Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
        Next

        qty = Textbox1.Text

        Try
            ' Refresh the staging table so re-editing the same line doesn't create duplicates
            Dim dd As New Dao
            dd.modifyData("delete from IMEI_NUM")

            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.IsNewRow Then Continue For
                Dim constring As SqlClient.SqlConnection
                constring = New SqlConnection(ConnString)

                Using cmd As New SqlCommand("insert into IMEI_NUM(IMEI_NUMBER) values(@IMEI_NUMBER)", constring)
                    cmd.Parameters.AddWithValue("@IMEI_NUMBER", row.Cells("IMEI_NUMBER").Value.ToString().Trim())
                    constring.Open()
                    cmd.ExecuteNonQuery()
                    constring.Close()
                End Using
            Next
            MessageBox.Show("record saved")

            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub

    Public Sub load_imei()
        Try
            Dim d As New Dao
            Dim ds As New Data.DataSet

            ds = d.loaddata("select * from IMEI_NUM")

            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
    End Sub

    Private Sub Label4_MouseHover(sender As Object, e As EventArgs) Handles Label4.MouseHover
        Label4.BackColor = Color.Red
    End Sub

    Private Sub Label4_MouseLeave(sender As Object, e As EventArgs) Handles Label4.MouseLeave
        Label4.BackColor = Color.Teal
    End Sub
End Class