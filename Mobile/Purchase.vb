Imports System.Data.SqlClient
Public Class Purchase
    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        loaddata()
        '  load()
    End Sub

    Public Sub loaddata()
        Dim ds As New Data.DataSet
        Dim d As New Dao
        Try

            ds = d.loaddata("select Invoice_No,Bill_Date,Due_Date,Ledger_Name,Total_pgst,Total_Amount from Purchase_Summary")

            DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        Dim query As String = "select Invoice_No,Bill_Date,Due_Date,Ledger_Name,Total_pgst,Total_Amount from Purchase_Summary where Ledger_Name like '%" & TextBox1.Text & "%'"
        Using con As SqlConnection = New SqlConnection(ConnString)
            Using cmd As SqlCommand = New SqlCommand(query, con)
                Using da As SqlDataAdapter = New SqlDataAdapter
                    da.SelectCommand = cmd
                    Using dt As New DataTable
                        da.Fill(dt)
                        If dt.Rows.Count > 0 Then

                            DataGridView1.DataSource = dt

                        Else
                            MessageBox.Show("No Record Found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)

                            TextBox1.Text = ""



                        End If

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim parentDashboard As Dashboard = TryCast(Me.MdiParent, Dashboard)
        If parentDashboard IsNot Nothing Then
            parentDashboard.PurchaseEntryToolStripMenuItem_Click(sender, e)
        End If
    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover

        Button1.BackColor = Color.FromArgb(0, 105, 105)

    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave

        Button1.BackColor = Color.Teal

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
End Class