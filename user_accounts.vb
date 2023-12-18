Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class user_accounts
    Private Sub LoadData()

        If strcon.State <> ConnectionState.Open Then
            strcon.Open()
        End If






        Dim query2 As String = "SELECT * FROM accounts WHERE username = @Username"
        Dim command As New MySqlCommand(query2, strcon)
        command.Parameters.AddWithValue("@Username", Form1.historyuname)

        Using reader As MySqlDataReader = command.ExecuteReader()
            While reader.Read()
                ' Access values using column names or indices
                lblid.Text = reader("id").ToString()
                lbluname.Text = reader("username").ToString()
                lbldate_entered.Text = reader("date_entered").ToString()
                lblf_name.Text = reader("firstname").ToString()
                lbll_name.Text = reader("lastname").ToString()
                lblgender.Text = reader("gender").ToString()
                lblalphabet_prog.Text = reader("progress_data_alphabet").ToString
                lblnumbers_prog.Text = reader("progress_data_numbers").ToString
                lblwords_prog.Text = reader("progress_data_words").ToString
                lblphrases_prog.Text = reader("progress_data_phrases").ToString
                fsl_prog_alpha.Text = reader("alphabet_fsl").ToString
                fsl_prog_numbers.Text = reader("numbers_fsl").ToString
                fsl_prog_words.Text = reader("words_fsl").ToString
                fsl_prog_phrases.Text = reader("phrases_fsl").ToString
            End While
        End Using
    End Sub

    Private Sub user_accounts_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Form3.Show()

    End Sub
End Class