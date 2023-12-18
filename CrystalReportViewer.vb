Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.MySqlClient

Public Class CrystalReportViewer
    Dim dataTable As New DataTable()


    Private Sub LoadData()

        Try
            strcon.Open()

            Dim query As String = "SELECT *  FROM accounts "
            'Dim command As New MySqlCommand(query, strcon)

            Using adapter As New MySqlDataAdapter(query, strcon)
                adapter.Fill(dataTable)

            End Using

        Catch ex As Exception
            MessageBox.Show("Error retrieving progress value from database: " & ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Private Sub CrystalReportViewer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim report As ReportClass
        report = New CrystalReport1()
        LoadData()
        report.SetDataSource(dataTable)
        'ShowReport(report)
        CrystalReportViewer1.ReportSource = report
    End Sub
End Class