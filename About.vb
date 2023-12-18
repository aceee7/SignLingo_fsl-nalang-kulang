Imports System.Drawing.Drawing2D

Public Class About

    Private Sub About_Load(sender As Object, e As EventArgs) Handles Me.Load
        RoundPanel(Panel1, 30)
        RoundPanel(Panel2, 30)
        RoundPanel(Panel3, 30)
    End Sub

    Private Sub RoundPanel(panel As Panel, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        panel.Region = New Region(path)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        If Admin IsNot ActiveForm Then
            Me.Hide()
            Form3.Show()
        Else
            Me.Hide()
            Admin.Show()
        End If

    End Sub
End Class