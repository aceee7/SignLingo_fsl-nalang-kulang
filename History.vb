Imports MySql.Data.MySqlClient
Public Class History
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Public Sub LoadDataHistory()
        Dim dataTable As New DataTable()

        Try
            strcon.Open()

            Dim query As String = "SELECT * FROM " & Form1.historyuname & ""
            'Dim command As New MySqlCommand(query, strcon)

            Using adapter As New MySqlDataAdapter(query, strcon)
                adapter.Fill(dataTable)

            End Using
            dgvHistory.DataSource = dataTable
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.Fill

        Catch ex As Exception
            MessageBox.Show("Error retrieving progress value from database: " & ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Private Sub dgvHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellContentClick
        If e.RowIndex >= 0 AndAlso e.RowIndex < dgvHistory.RowCount - 1 Then
            ' Access the value of the clicked cell in the first column (index 0)
            Dim FirstName As Object = dgvHistory.Rows(e.RowIndex).Cells(0).Value
            Dim LastName As Object = dgvHistory.Rows(e.RowIndex).Cells(1).Value
            Dim Username As Object = dgvHistory.Rows(e.RowIndex).Cells(2).Value
            Dim Password As Object = dgvHistory.Rows(e.RowIndex).Cells(3).Value



        End If
    End Sub

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataHIstory()
    End Sub
End Class