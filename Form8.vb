Imports MySql.Data.MySqlClient

Public Class Form8
    Dim conn As New MySqlConnection("Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95")
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim reader As MySqlDataReader
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Login()

    End Sub
    Private Sub Login()
        query = "SELECT username, pass FROM admin_account WHERE username = @username AND pass = @pass"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", Me.txtadmin_uname.Text)
        cmd.Parameters.AddWithValue("@pass", Me.txtpass_admin.Text)
        conn.Open()
        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        Try
            If reader.HasRows Then
                MsgBox("Login Successful")
                Admin.Show()
                Me.Hide()
            Else
                MsgBox("Invalid username or password")
                Me.Show()

            End If
            reader.Close()

        Catch ex As Exception
            MsgBox("Error:" & ex.Message)
        Finally
            cleardata()
        End Try

        conn.Close()
    End Sub
    Private Sub cleardata()
        txtadmin_uname.Clear()
        txtpass_admin.Clear()

    End Sub
End Class