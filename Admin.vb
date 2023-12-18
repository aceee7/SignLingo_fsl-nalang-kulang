
Imports MySql.Data.MySqlClient

Public Class Admin

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles Me.Load
        lbldate.Text = Date.Today
        timer.Enabled = True
        usercount()

    End Sub

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        lbltime.Text = DateTime.Now.ToString("h:mm:ss tt")
    End Sub

    Private Sub usercount()
        Try
            strcon.Open()

            Dim query As String = "SELECT COUNT(id) FROM accounts "
            'Dim command As New MySqlCommand(query, strcon)

            Using command As New MySqlCommand(query, strcon)
                Dim count As Integer = CInt(command.ExecuteScalar())
                lblnum.Text = count
                strcon.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("Error retrieving progress value from database: " & ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        users.Show()
        Me.Hide()

    End Sub




    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

        CrystalReportViewer.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Me.Hide()
        About.Show()

    End Sub


End Class