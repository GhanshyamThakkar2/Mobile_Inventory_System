Imports System.Data.SqlClient

Public Class Reset_pass

    Private Sub Btn_done_Click(sender As Object, e As EventArgs) Handles Btn_done.Click

        Dim dao As Dao = New Dao

        If (txt_confirm.Text.Equals(txt_new.Text)) Then
            dao.modifyData("UPDATE [data_stu16].[Login]
            SET [Password] = '" & txt_confirm.Text & "'
            WHERE [User_name]='" & uname & "'")
            MsgBox("Password reset Successfully", MsgBoxStyle.Information)

            Me.Hide()
            Login.Show()
        Else
            MsgBox("Enter Same as New Password", MsgBoxStyle.Information)
        End If
    End Sub



    Private Sub Reset_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Show()
        txt_confirm.Text = ""

        txt_new.Text = ""
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Login.Show()
        txt_confirm.Text = ""

        txt_new.Text = ""
    End Sub

    Private Sub txt_user_KeyDown(sender As Object, e As KeyEventArgs)
        Dim d As New Dao
        d.press_enter(e)
    End Sub
End Class