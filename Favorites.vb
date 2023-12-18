Imports MySql.Data.MySqlClient

Public Class Favorites
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Form5.Show()

    End Sub

    Public Sub LoadData()
        Dim dataTable As New DataTable()

        Try
            strcon.Open()

            Dim query As String = "SELECT * FROM " & Form1.historyuname & " WHERE isFavorite = ""YES"""
            'Dim command As New MySqlCommand(query, strcon)

            Using adapter As New MySqlDataAdapter(query, strcon)
                adapter.Fill(dataTable)

            End Using
            dgvFavorites.DataSource = dataTable
            dgvFavorites.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error retrieving progress value from database: " & ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Private Sub dgvHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFavorites.CellContentClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvFavorites.RowCount - 1 Then
            ' Access the value of the clicked cell in the first column (index 0)
            Dim FirstName As Object = dgvFavorites.Rows(e.RowIndex).Cells(0).Value
            Dim LastName As Object = dgvFavorites.Rows(e.RowIndex).Cells(1).Value
            Dim Username As Object = dgvFavorites.Rows(e.RowIndex).Cells(2).Value
            Dim Password As Object = dgvFavorites.Rows(e.RowIndex).Cells(3).Value



        End If
    End Sub

    Private Sub Favorites_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadData()
    End Sub
End Class