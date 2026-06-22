Imports System.Data.SqlClient
Public Class Product
    Private Sub Product_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Focus()
        loaddata()


    End Sub
    Public Sub loaddata()
        Dim ds As New Data.DataSet
        Dim d As New Dao
        ds = d.loaddata("select Product_Name,Amount,Sales_Rate from Product1 order by Product_Name")
        Product_DataGridView.DataSource = ds.Tables(0)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim query As String = "select Product_Name,Amount,Sales_Rate from Product1 where Product_Name like '%" & TextBox1.Text & "%'"
        Using con As SqlConnection = New SqlConnection(ConnString)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            Product_DataGridView.DataSource = dt

                        Else
                            MessageBox.Show("No Record Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error)

                            TextBox1.Text = ""
                            loaddata()



                        End If

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Product_DataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Product_DataGridView.CellDoubleClick
        Dim d As New Dao
        Dim obj As SqlDataReader
        obj = d.getdata("select Product_Name from Product1 ")
        Pname = obj.ToString
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Close()

    End Sub

    Private Sub Label9_MouseHover(sender As Object, e As EventArgs) Handles Label9.MouseHover

        Label9.BackColor = Color.Red

    End Sub

    Private Sub Label9_MouseLeave(sender As Object, e As EventArgs) Handles Label9.MouseLeave

        Label9.BackColor = Color.Teal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = ""
        loaddata()
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover

        Button1.BackColor = Color.Teal
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave

        Button1.BackColor = Color.White
        Button1.ForeColor = Color.Teal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim parentDashboard As Dashboard = TryCast(Me.MdiParent, Dashboard)
        If parentDashboard IsNot Nothing Then
            parentDashboard.ProductEntryToolStripMenuItem_Click(sender, e)
        End If
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover

        Button2.BackColor = Color.FromArgb(0, 105, 105)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave

        Button2.BackColor = Color.Teal
    End Sub
End Class