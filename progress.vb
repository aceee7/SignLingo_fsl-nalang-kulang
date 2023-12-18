Imports System.Drawing.Drawing2D
Public Class progress
    Private Sub progress_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim username As String = Form1.historyuname



        ' Display the progress value when the user logs in
        Dim progressValue As Integer = GetProgressFromDatabase_alpha(username)

        ' Set the retrieved username and update the progress bar
        progressalphabet_asl.Value = progressValue
        MessageBox.Show($"Welcome, {username}! Your progress value in alphabet is: {progressValue}")


        Dim progressValuenum As Integer = GetProgressFromDatabase_numbers(username)
        progressnumbers_asl.Value = progressValuenum
        MessageBox.Show($"Welcome, {username}! Your progress value in numbers is: {progressValuenum}")

        Dim progressValueword As Integer = GetProgressFromDatabase_words(username)
        progresswords_asl.Value = progressValueword
        MessageBox.Show($"Welcome, {username}! Your progress value in words is: {progressValueword}")

        Dim progressValuephrases As Integer = GetProgressFromDatabase_phrases(username)
        progressphrases_asl.Value = progressValuephrases
        MessageBox.Show($"Welcome, {username}! Your progress value in phrases is: {progressValuephrases}")

        Dim progressValuealphafsl As Integer = GetProgressFromDatabase_alphabet_fsl(username)

        ' Set the retrieved username and update the progress bar
        progressalphabet_fsl.Value = progressValuealphafsl
        MessageBox.Show($"Welcome, {username}! Your progress value in alphabet is: {progressValuealphafsl}")


        Dim progressValuenumfsl As Integer = GetProgressFromDatabase_numbers_fsl(username)
        progressnumbers_fsl.Value = progressValuenumfsl
        MessageBox.Show($"Welcome, {username}! Your progress value in numbers is: {progressValuenumfsl}")

        Dim progressValuewordfsl As Integer = GetProgressFromDatabase_words_fsl(username)
        progresswords_fsl.Value = progressValuewordfsl
        MessageBox.Show($"Welcome, {username}! Your progress value in words is: {progressValuewordfsl}")

        Dim progressValuephrasesfsl As Integer = GetProgressFromDatabase_phrases_fsl(username)
        progressphrases_fsl.Value = progressValuephrasesfsl
        MessageBox.Show($"Welcome, {username}! Your progress value in phrases is: {progressValuephrasesfsl}")


        RoundLabel(Label7, 18)
        RoundLabel(Label8, 18)
        RoundLabel(Label9, 18)
        RoundLabel(Label10, 18)
        RoundLabel(Label11, 18)
        RoundLabel(Label12, 18)
        RoundLabel(Label13, 18)
        RoundLabel(Label14, 18)
        RoundLabel(Label15, 18)
        RoundLabel(Label16, 18)

    End Sub
    Private Sub RoundLabel(label As Label, radius As Integer)
        ' Create a GraphicsPath to define the rounded shape
        Dim roundedRect As New GraphicsPath()

        ' Add rounded rectangle to the GraphicsPath
        roundedRect.AddArc(0, 0, radius * 2, radius * 2, 180, 90) ' Top-left corner
        roundedRect.AddArc(label.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90) ' Top-right corner
        roundedRect.AddArc(label.Width - radius * 2, label.Height - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
        roundedRect.AddArc(0, label.Height - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

        ' Close the path
        roundedRect.CloseFigure()

        ' Set the label's Region property with the rounded shape
        label.Region = New Region(roundedRect)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Form3.Show()

    End Sub

End Class