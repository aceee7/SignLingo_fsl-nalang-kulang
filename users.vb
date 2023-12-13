Imports MySql.Data.MySqlClient

Public Class users
    Private Sub LoadData()
        Dim dataTable As New DataTable()

        Try
            strcon.Open()

            Dim query As String = "SELECT firstname, lastname, username, pass  FROM accounts "
            'Dim command As New MySqlCommand(query, strcon)

            Using adapter As New MySqlDataAdapter(query, strcon)
                adapter.Fill(dataTable)

            End Using
            dgvUsers.DataSource = dataTable
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error retrieving progress value from database: " & ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub dgvUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsers.CellClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvUsers.RowCount - 1 Then
            ' Access the value of the clicked cell in the first column (index 0)
            Dim FirstName As Object = dgvUsers.Rows(e.RowIndex).Cells(0).Value
            Dim LastName As Object = dgvUsers.Rows(e.RowIndex).Cells(1).Value
            Dim Username As Object = dgvUsers.Rows(e.RowIndex).Cells(2).Value
            Dim Password As Object = dgvUsers.Rows(e.RowIndex).Cells(3).Value


            txtfirstname.Text = FirstName
            txtlastname.Text = LastName
            txtusername.Text = Username
            txtpassword.Text = Password

        End If
    End Sub
    Public Function insertUser()
        Try
            strcon.Open()
            Dim firstname As String = txtfirstname.Text
            Dim lastname As String = txtlastname.Text
            Dim username As String = txtusername.Text
            Dim password As String = txtpassword.Text
            Dim insertQuery As String = "INSERT INTO accounts (firstname, lastname, username, pass) VALUES (@ID, @Name, @Username, @Password)"
            Dim command As New MySqlCommand(insertQuery, strcon)

            ' Add parameters
            command.Parameters.AddWithValue("@ID", firstname)
            command.Parameters.AddWithValue("@Name", lastname)
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@Password", password)

            ' Execute the query
            command.ExecuteNonQuery()

            MsgBox("Account Created Successfully!", vbOK, "Welcome to SymptoMedic!")
            strcon.Close()
            LoadData()
            Clear()

            ' Connection is successful
        Catch ex As Exception

            MsgBox(ex.Message, vbOK)
        Finally

        End Try
        Return 0
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insertUser()
    End Sub

    Private Sub Clear()
        txtfirstname.Text = ""
        txtlastname.Text = ""
        txtusername.Text = ""
        txtpassword.Text = ""
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        strcon.Open()

        Dim updateQuery As String = "UPDATE accounts SET firstname = @firstname, lastname = @lastname, username = @Username,pass = @Password WHERE username = @Username;"

        Dim command As New MySqlCommand(updateQuery, strcon)
        command.Parameters.AddWithValue("@firstname", txtfirstname.Text)
        command.Parameters.AddWithValue("@lastname", txtlastname.Text)
        command.Parameters.AddWithValue("@Username", txtusername.Text)
        command.Parameters.AddWithValue("@Password", txtpassword.Text)

        ' Execute the update query
        command.ExecuteNonQuery()
        strcon.Close()
        MsgBox("Account updated successfully.", vbOK, "Update Complete!")
        LoadData()
        Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        strcon.Open()
        Dim deleteQuery As String = "DELETE FROM accounts WHERE username = @username;"
        Dim command As New MySqlCommand(deleteQuery, strcon)
        command.Parameters.AddWithValue("@username", txtusername.Text)
        ' Execute the delete query
        command.ExecuteNonQuery()
        MsgBox("User deleted successfully.", vbOK, "Account Deleted")
        strcon.Close()
        LoadData()
        Clear()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Admin.Show()

    End Sub
End Class