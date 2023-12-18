Imports System.Drawing.Drawing2D
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form6
    Dim fontsize As Integer
    Private Sub IncrementProgressBarAlphabetfsl(incrementValue As Integer)
        ' Ensure the progress value is within the valid range (0 to 100)
        Dim newValue As Integer = 0
        If lblCategory_num_alpha.Text = "ALPHABET" Then
            newValue = progress.progressalphabet_fsl.Value + incrementValue
            If newValue > 27 Then newValue = 27
            If newValue < 0 Then newValue = 0
        End If


        ' Update the progress bar
        progress.progressalphabet_fsl.Value = newValue
    End Sub
    Private Sub IncrementProgressBarNumbersfsl(incrementValue As Integer)
        ' Ensure the progress value is within the valid range (0 to 100)
        Dim newValue As Integer = 0
        If lblCategory_num_alpha.Text = "NUMBERS" Then
            newValue = progress.progressnumbers_fsl.Value + incrementValue
            If newValue > 20 Then newValue = 20
            If newValue < 0 Then newValue = 0
        End If


        ' Update the progress bar
        progress.progressnumbers_fsl.Value = newValue
    End Sub

    Private Sub IncrementProgressBarWordsfsl(incrementValue As Integer)
        ' Ensure the progress value is within the valid range (0 to 100)
        Dim newValue As Integer = 0
        If lblcategory_words.Text = "ANIMALS" Or lblcategory_words.Text = "PLACES" Or lblcategory_words.Text = "THINGS" Or lblcategory_words.Text = "FAMILY MEMBER" Or lblcategory_words.Text = "FOODS" Then
            newValue = progress.progresswords_fsl.Value + incrementValue
            If newValue > 150 Then newValue = 150
            If newValue < 0 Then newValue = 0
        End If


        ' Update the progress bar
        progress.progresswords_fsl.Value = newValue
    End Sub

    Private Sub IncrementProgressBarPhrasesfsl(incrementValue As Integer)
        ' Ensure the progress value is within the valid range (0 to 100)
        Dim newValue As Integer = 0
        If lblcategory_Phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString() Then
            newValue = progress.progressphrases_fsl.Value + incrementValue
            If newValue > 33 Then newValue = 33
            If newValue < 0 Then newValue = 0
        End If


        ' Update the progress bar
        progress.progressphrases_fsl.Value = newValue
    End Sub

    Private Sub RoundPanel(panel As Panel, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(panel.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(panel.Width - cornerRadius, panel.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, panel.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        panel.Region = New Region(path)
    End Sub
    Private Sub RoundButton(button As Button, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        button.Region = New Region(path)
    End Sub
    Public Function loadImage_words(imagename As String)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imagePath As String = Path.Combine(folderPath, imagename)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            pbword.Image = Image.FromFile(imagePath)
        Else
            Console.WriteLine("Image not found.")
        End If

    End Function

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundPanel(pnlAlphabet, 30)
        RoundButton(btnalphabet_fsl, 30)
        RoundButton(btnnumbers_fsl, 30)
        RoundButton(btnwords_fsl, 30)
        RoundButton(btnphrases_fsl, 30)
        RoundButton(btnA, 30)
        RoundButton(btnB, 30)
        RoundButton(btnC, 30)
        RoundButton(btnD, 30)
        RoundButton(btnE, 30)
        RoundButton(btnF, 30)
        RoundButton(btnG, 30)
        RoundButton(btnH, 30)
        RoundButton(btnI, 30)
        RoundButton(btnJ, 30)
        RoundButton(btnK, 30)
        RoundButton(btnL, 30)
        RoundButton(btnM, 30)
        RoundButton(btnN, 30)
        RoundButton(btnO, 30)
        RoundButton(btnP, 30)
        RoundButton(btnQ, 30)
        RoundButton(btnR, 30)
        RoundButton(btnS, 30)
        RoundButton(btnT, 30)
        RoundButton(btnU, 30)
        RoundButton(btnV, 30)
        RoundButton(btnW, 30)
        RoundButton(btnX, 30)
        RoundButton(btnY, 30)
        RoundButton(btnZ, 30)

    End Sub


    Private Sub btnalphabet_fsl_Click(sender As Object, e As EventArgs) Handles btnalphabet_fsl.Click
        pnlAlphabet.Show()

        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
        pnlPhrases.Hide()

    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "A"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "A.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "B"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "B.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "C"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "C.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "D"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "D.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "E"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "E.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "F"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "F.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "G"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "G.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "H"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "H.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "I"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "I.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "J"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "J.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "K"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "K.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "L"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "L.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "M"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "M.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "N"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "N.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "O"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "O.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "P"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "P.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "Q"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "Q.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "R"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "R.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "S"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "S.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "T"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "T.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "U"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "U.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "V"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "V.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "W"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "W.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "X"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "X.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        pnlAlpha_num.Show()
        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "Y"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "Y.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "ALPHABET"
        lbldesc_num_alpha.Text = "Z"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font(lblCategory_num_alpha.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font(lbldesc_num_alpha.Font.FontFamily, fontsize)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "Z.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Hide()
        Form4.Show()

    End Sub

    Private Sub btnnumbers_fsl_Click(sender As Object, e As EventArgs) Handles btnnumbers_fsl.Click
        pnlnumbers_fsl.Show()
        pnlAlphabet.Hide()
        pnlAlpha_num.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "1"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "1.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If

        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "2"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "2.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If

        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()

    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "3"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "3.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If

        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "4"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "4.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If

        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()
        pnlPhrases.Hide()
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "5"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "5.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If

        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "6"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "6.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()

    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "7"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "7.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "8"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "8.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "9"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "9.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "10"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "10.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "11"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "11.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "12"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "12.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "13"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "13.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "14"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "14.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "15"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "15.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "16"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "16.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn17_Click(sender As Object, e As EventArgs) Handles btn17.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "17"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "17.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub
    Private Sub btn18_Click(sender As Object, e As EventArgs)
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "18"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "18.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn19_Click(sender As Object, e As EventArgs) Handles btn19.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "19"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "19.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.Hide()
    End Sub

    Private Sub btn20_Click(sender As Object, e As EventArgs) Handles btn20.Click
        pnlAlpha_num.Show()

        lblCategory_num_alpha.Text = "NUMBERS"
        lbldesc_num_alpha.Text = "20"

        fontsize = 28
        lblCategory_num_alpha.Font = New Font("Abril Fatface", fontsize)

        fontsize = 110
        lbldesc_num_alpha.Font = New Font("Abril Fatface", fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "20.jpeg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture_num_alpha.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        pnlAlphabet.Hide()
        pnlnumbers_fsl.Hide()

        pnlPhrases.hide()
    End Sub

    Private Sub cmbWords_Phrases_fsl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPhrases_fsl.SelectedIndexChanged
        Select Case cmbPhrases_fsl.SelectedItem.ToString()
            Case "Salamat"
                loadImage("THANK YOU.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Pahabain ang iyong mga daliri at hinlalaki. Hawakan ang iyong mga daliri sa iyong baba at dalhin ang iyong mga daliri pasulong. Ito ay halos tulad ng humihip ka ng isang halik, upang pasalamatan ang tao - ngunit ang tanda ay medyo mas mababa."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Walang anuman"
                loadImage("YOU_RE WELCOME.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Ito ay kaparehong paraan ng pag-sign sa Salamat. Kunin ang iyong patag, bukas, nangingibabaw na kamay, at simula sa iyong baba, ilabas ang iyong kamay habang ito ay bumababa at palayo sa iyong mukha. Para bang kinikilala mo na nagpasalamat sa iyo ang iyong sanggol, kaya sinasalamin mo ang magalang na kilos pabalik, tulad ng pagpapasalamat sa kanila sa pasasalamat sa iyo!"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Magkano"
                loadImage("HOW MUCH.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Una sa pamamagitan ng pagsisimula sa iyong magkabilang saradong mga kamay, apat na daliri na hawakan ang hinlalaki sa magkabilang gilid ng iyong katawan, nakaharap sa itaas. Pagkatapos ay igalaw ang iyong mga kamay pataas, na nakaharap pa rin ang mga palad at ang mga daliri ay nakabukas nang malapad, at gumawa ng nagtatanong na mukha."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Paalam"
                loadImage("GOODBYE.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Katulad ng tradisyonal na kilos para sa salita. Buksan ang iyong palad, itiklop ang iyong mga daliri, pagkatapos ay buksan muli ang iyong palad."

                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Hello"
                loadImage("HELLO.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Gawin ang sign sa pamamagitan ng pagpapalawak ng iyong mga daliri at i-cross ang iyong hinlalaki sa harap ng iyong palad. Ngayon kunin ang kamay, simula sa iyong kamay sa harap ng iyong tainga, at iunat ito palabas at palayo sa iyong katawan."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Magandang umaga"
                loadImage("GOOD MORNING.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Pinagsama ang sign para sa magandang at umaga."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Magandang gabi"
                loadImage("GOOD NIGHT.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Pinagsama ang sign para sa magandang at gabi."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Mawalang galang na po"
                loadImage("EXCUSE ME.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "I-set up mo ang sign sa pamamagitan ng paghawak sa iyong palad na hindi nangingibabaw na nakaharap sa langit, pagkatapos ay i-brush ang iyong palad gamit ang mga daliri ng nangingibabaw na kamay. Ito rin ang tanda ng pagpapatawad o patawarin mo ako."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 11)
            Case "Pakiusap"
                loadImage("PLEASE.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Kunin ang iyong nangingibabaw na kamay na naka-extend at nakadikit ang mga daliri, at naka-extend ang thumb at nakalabas. Kunin ang kamay na nakaharap ang palad at kuskusin ito ng bilog sa iyong dibdib."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Patawad"
                loadImage("SORRY.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Gawin ang iyong kamay sa isang kamao at kuskusin ito sa isang pabilog na galaw sa iyong dibdib. Parang kinukurot mo ang puso mo dahil nagsisisi ka talaga."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Mahal kita"
                loadImage("I LOVE YOU.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Ilagay ang iyong hinlalaki, hintuturo at hintuturo, habang nakababa ang iyong singsing na daliri at gitnang daliri. Iunat ang kamay, nakaharap ang palad palayo sa iyo at igalaw ito nang bahagya pabalik-balik."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Ang ganda mo"
                loadImage("YOU LOOK BEAUTIFUL.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Magsimula sa nakabukas ang iyong nangingibabaw na kamay, nakaturo ang hinlalaki sa iyong baba at nakaturo ang mga daliri sa itaas. Kumpletuhin mo ang sign sa pamamagitan ng pag-ikot ng iyong mga daliri sa harap ng iyong mukha nang sunud-sunod, na nagtatapos sa iyong mga daliri at hinlalaki nang magkasama sa paligid ng iyong baba.

"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 11)
            Case "Ano?"
                loadImage("WHAT.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Itaas ang iyong nakabukas na mga kamay, na nakabuka ang mga daliri at bahagyang nakakurba at nakakarelaks ang mga kamay. Sabay-sabay na ilipat ang dalawang kamay pabalik-balik habang nakakunot ang iyong noo habang nagtatanong, Ano?.KAILAN?

"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 11)
            Case "Kailan?"
                loadImage("WHEN.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Isara ang iyong dalawang kamay sa mga kamao at ilabas lamang ang iyong mga hintuturo. Ang iyong hintuturo na hindi nangingibabaw ay nakatayo nang patayo at hindi gumagalaw, habang ang iyong nangingibabaw na hintuturo ay umiikot sa isang maliit na bilog sa itaas ng hindi nangingibabaw na hintuturo, hanggang sa tuluyan nitong mahawakan ang dulo ng hintuturo upang magpahinga. Para kang nakasentro sa isang mas tiyak na petsa o oras, hanggang sa maabot mo ito sa wakas.
"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 11)
            Case "Saan?"
                loadImage("WHERE.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Ilabas ang iyong nangingibabaw na hintuturo at i-wiggling ito patagilid. Mahalaga rin na kumunot ang iyong noo - isang facial cue na tinatanong mo ang iyong sanggol - habang nagtatanong ka at pumipirma ng, Nasaan si...?

"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Bakit?"
                loadImage("WHY.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Kunin ang iyong nangingibabaw na kamay at gawin ang ASL sign para sa letrang 'Y' sa gilid ng iyong ulo. Ang isang variant ng sign na ito ay ang pag-wiggle ng iyong gitnang daliri pataas at pababa nang nakabuka ang natitirang mga daliri mo, nakaharap ang palad sa gilid ng iyong ulo. Ang pangatlong alternatibo ay gawin pa rin ang titik na 'Y', ngunit pagkatapos na hilahin ang iyong kamay nang kaunti pa pababa sa dominanteng bahagi.
"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 10)
            Case "Sino?"
                loadImage("WHY.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Buuin ang ASL letter 'L' gamit ang iyong nangingibabaw na kamay, idikit ang iyong hinlalaki sa iyong baba, at igalaw ang mas mahabang 'L' na binti pataas at pababa habang nakakunot ang iyong noo at tanungin ang iyong sanggol, Sino?"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Paano?"
                loadImage("HOW.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Isara ang dalawang kamay na nakataas ang mga hinlalaki at pataas. Pagharapin ang magkabilang kamay sa pamamagitan ng paghawak sa mga buko at igalaw ang iyong nangingibabaw na kamay pabalik-balik na parang nagbubukas ng kandado, habang pinapanatili ang iyong hindi nangingibabaw na kamao.
"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 11)
            Case "Hindi ko alam"
                loadImage("DON_T KNOW.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Kibit balikat. Bilang kahalili, maaari mong ituro ang iyong noo gamit ang iyong nangingibabaw na kamay na magkakadikit ang mga daliri at ilayo ang iyong kamay sa iyo, habang bahagyang iiling-iling ang iyong ulo upang ipakita ang negasyon."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Ayaw ko"
                loadImage("DON_T WANT.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Parang may ayaw ka at tinataboy mo. Simula sa iyong mga kamay na nakataas ang mga palad at nakakurba ang mga daliri, ibalikwas ang iyong mga kamay at itulak ang iyong mga kamay palayo."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Tulong"
                loadImage("HELP.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Ilagay ang iyong saradong kamao, nangingibabaw na 'A' na kamay sa ibabaw ng iyong hindi nangingibabaw na bukas na palad, at igalaw ang dalawang kamay pataas."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Kumusta ka?"
                loadImage("HOW ARE YOU.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Bumuo ng mga hubog na kamay ng mga hugis sa magkabilang kamay, mga palad pababa at/o bahagyang pabalik at ituro patungo sa tao, ASL na galaw para sa ikaw."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Ang pangalan ko ay..."
                loadImage("MY NAME IS.jpg")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Ilagay ang iyong kanang kamay sa ibabaw ng iyong puso. Palawakin ang hintuturo at gitnang daliri sa magkabilang kamay. Ilagay ang mga kanang daliri sa itaas ng mga kaliwa. Pagkatapos ay baybayin ng daliri ang iyong pangalan.

"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 12)
            Case "Anong pangalan mo?"
                loadImage("WHAT IS YOUR NAME.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Itaas ang kanang kamay sa harap mo, pagkatapos ay iharap. At pagkatapos ay i-extend ang hintuturo at gitnang daliri sa magkabilang kamay. Ilagay ang mga kanang daliri sa itaas ng mga kaliwa. Mag-tap ng dalawang beses. Pagkatapos ay ilagay ang dalawang kamay sa harap mo, itaas ang palad. Iling ang mga ito at gumamit ng nagtatanong na ekspresyon sa iyong mukha."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 11)
            Case "Ulit"
                loadImage("AGAIN.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Patagin ang iyong nangungunang kamay, ibaluktot ang iyong pangalawang kamay sa tamang anggulo, pagkatapos ay i-tap ito sa gitna ng palad ng iyong unang kamay.
"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Oo"
                loadImage("YES.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Mukhang tumatango ang ulo oo. Hawakan mo ang iyong kamay at gawin itong isang kamao, hawak ito sa halos balikat na taas, pagkatapos ay gawing pabalik-balik ang iyong kamao.
"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Hindi"
                loadImage("NO.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Parang bibig na nagsasabing hindi. Isama ang iyong hintuturo gamit ang iyong gitnang daliri at i-tap ang mga ito kasama ng iyong hinlalaki.
"
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Mamaya"
                loadImage("LATER.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Kunin ang iyong nangingibabaw na kamay at magsimula sa isang 'L'-sign, gamit ang iyong hintuturo at hinlalaki i-extend sa tamang mga anggulo. Kunin ang iyong hindi nangingibabaw na kamay at hawakan ito nang patag, nakaharap sa iyong 'L' na kamay, habang ang iyong 'L' na hinlalaki ay dumidikit sa palad ng iyong kabilang kamay. Panatilihin ang iyong hindi nangingibabaw, bukas na patag na kamay habang pini-pivot mo ang iyong 'L' na kamay nang 90 degrees, paulit-ulit."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 11)
            Case "Ngayon"
                loadImage("NOW.png")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Ilagay ang dalawang kamay sa ASL letter Y sign, na naka-extend ang iyong hinlalaki at pinkie fingers at ang iyong tatlong gitnang daliri ay naka-curl sa bawat kamay. Simula sa itaas ng iyong mga kamay, dalhin ang mga ito pababa sa antas ng iyong balakang."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 12)
            Case "Maligayang kaarawan"
                loadImage("HAPPY BIRTHDAY.jpg")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Ito ay isang tanda na may dalawang bahagi. Magsimula muna sa tanda ng masaya sa pamamagitan ng pagsuklay ng patag na kamay sa iyong puso nang ilang beses. Susunod na mag-sign ng kaarawan sa pamamagitan ng paghawak muna ng gitnang daliri ng isang kamay sa iyong baba, pagkatapos ay sa iyong dibdib."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 11)
            Case "Maligayang pagbati"
                loadImage("CONGRATULATIONS.jpg")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Ipalm-down na nangingibabaw na kamay ay nakakabit sa palm-up na hindi nangingibabaw na kamay, gumagalaw pababa nang dalawang beses."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 13)
            Case "Maligayang pasko"
                loadImage("MERRY CHRISTMAS.jpg")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Upang mag-sign ng happy, kunin ang iyong naka-extend na kamay at ihaplos ito pataas sa iyong dibdib nang ilang beses. At para naman i-sign ang Pasko ay buuin ang ASL letter C sign gamit ang iyong dominanteng kamay, i-swoop ito pababa sa harap mo, pagkatapos ay i-scoop ito pabalik hanggang ang iyong nangingibabaw na bisig ay patayo at ang iyong 'C' na kamay ay humawak ng matatag."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 9)
            Case "Manigong bagong taon"
                loadImage("HAPPY NEW YEAR.jpg")
                lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString
                lbldescription_phrases.Text = "Kunin ang iyong kamay at ipahid ito sa iyong dibdib nang dalawang beses. Buksan ang dalawang kamay at iangat ang kaliwa pataas parallel bilang tanda ng 'bago'. Para sa 'taon' gumawa ng isang kamao ng iyong mga kamay at i-tap ang kamao sa itaas ng isa pa."
                lbldescription_phrases.Font = New Font(lbldescription_phrases.Font.FontFamily, 12)
        End Select
    End Sub

    Public Function loadImage(imagename As String)
        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imagePath As String = Path.Combine(folderPath, imagename)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            pbimage_phrases_fsl.Image = Image.FromFile(imagePath)
        Else
            Console.WriteLine("Image not found.")
        End If
    End Function

    Private Sub btnphrases_fsl_Click(sender As Object, e As EventArgs) Handles btnphrases_fsl.Click
        pnlPhrases.Show()
        pnlAlphabet.Hide()
        pnlAlpha_num.Hide()
        pnlnumbers_fsl.Hide()

    End Sub

    Private Sub btnDonePhrases_words_Click(sender As Object, e As EventArgs) Handles btnDonePhrases_words.Click
        Dim username As String = Form1.historyuname
        If lbltitle_phrases_words.Text = cmbPhrases_fsl.SelectedItem.ToString() Then
            IncrementProgressBarPhrasesfsl(1)
            ' Transfer the updated progress value to MySQL Workbench
            TransferProgressToDatabase_phrases_fsl(username, progress.progressphrases_fsl.Value)

            ' Display the updated progress value
            MessageBox.Show($"Progress value updated: {progress.progressphrases_fsl.Value}")
        End If

        strcon.Open()
        Dim isFav As String

        If cbfavorites_phrases_fsl.Checked Then
            isFav = "YES"
        Else
            isFav = "NO"
        End If

        Dim insertTableQuery As String = "INSERT INTO " & Form1.historyuname & " (Category, Word, Date, isFavorite) VALUES ('" & lblcategory_Phrases_words.Text & "','" & lbltitle_phrases_words.Text & "', '" & Date.Now.ToString("yyyy-MM-dd") & "','" & isFav & "')"

        Dim command As New MySqlCommand(insertTableQuery, strcon)
        command.ExecuteNonQuery()

        strcon.Close()



    End Sub

    Private Sub btnDone_num_alpha_Click(sender As Object, e As EventArgs) Handles btnDone_num_alpha.Click
        Dim username As String = Form1.historyuname

        If lblCategory_num_alpha.Text = "ALPHABET" Then
            IncrementProgressBarAlphabetfsl(1)
            ' Transfer the updated progress value to MySQL Workbench
            TransferProgressToDatabase_alphabet_fsl(username, progress.progressalphabet_fsl.Value)

            ' Display the updated progress value
            MessageBox.Show($"Progress value updated: {progress.progressalphabet_fsl.Value}")
        Else
            IncrementProgressBarNumbersfsl(1)
            ' Transfer the updated progress value to MySQL Workbench
            TransferProgressToDatabase_numbers_fsl(username, progress.progressnumbers_fsl.Value)

            ' Display the updated progress value
            MessageBox.Show($"Progress value updated: {progress.progressnumbers_fsl.Value}")
        End If

        strcon.Open()
        Dim isFav As String

        If cbfavorites_num_alpha.Checked Then
            isFav = "YES"
        Else
            isFav = "NO"
        End If

        Dim insertTableQuery As String = "INSERT INTO " & Form1.historyuname & " (Category, Word, Date, isFavorite) VALUES ('" & lblCategory_num_alpha.Text & "','" & lbldesc_num_alpha.Text & "', '" & Date.Now.ToString("yyyy-MM-dd") & "','" & isFav & "')"

        Dim command As New MySqlCommand(insertTableQuery, strcon)
        command.ExecuteNonQuery()
        strcon.Close()

    End Sub

    Private Sub btndone_words_fsl_Click(sender As Object, e As EventArgs) Handles btndone_words_fsl.Click
        Dim username As String = Form1.historyuname

        If lblcategory_words.Text = "ANIMALS" Or lblcategory_words.Text = "PLACES" Or lblcategory_words.Text = "THINGS" Or lblcategory_words.Text = "FAMILY MEMBER" Or lblcategory_words.Text = "FOODS" Then
            IncrementProgressBarWordsfsl(1)
            ' Transfer the updated progress value to MySQL Workbench
            TransferProgressToDatabase_words(username, progress.progresswords_asl.Value)

            ' Display the updated progress value
            MessageBox.Show($"Progress value updated: {progress.progresswords_asl.Value}")

        End If

        strcon.Open()
        Dim isFav As String

        If cbfavorites_words_fsl.Checked Then
            isFav = "YES"
        Else
            isFav = "NO"
        End If

        Dim insertTableQuery As String = "INSERT INTO " & Form1.historyuname & " (Category, Word, Date, isFavorite) VALUES ('" & lblcategory_words.Text & "','" & lblanimal.Text & "', '" & Date.Now.ToString("yyyy-MM-dd") & "','" & isFav & "')"

        Dim command As New MySqlCommand(insertTableQuery, strcon)
        command.ExecuteNonQuery()

        strcon.Close()

    End Sub

    Private Sub btnFslThings_Click(sender As Object, e As EventArgs) Handles btnFslThings.Click
        pnlword.Show()

        cbothings_fsl.Show()
        cboanimals_fsl.Hide()
        cboplaces_fsl.Hide()
        cbofood_fsl.Hide()
        cbofamily_fsl.Hide()
        pnlwords_fsl.Hide()
        pnlAlphabet.Hide()
        pnlAlpha_num.Hide()
        pnlnumbers_fsl.Hide()
        pnlPhrases.Hide()



    End Sub

    Private Sub btnFslFoods_Click(sender As Object, e As EventArgs) Handles btnFslFoods.Click
        pnlword.Show()

        cbothings_fsl.Hide()
        cboanimals_fsl.Hide()
        cboplaces_fsl.Hide()
        cbofood_fsl.Show()
        cbofamily_fsl.Hide()
        pnlwords_fsl.Hide()
        pnlAlphabet.Hide()
        pnlAlpha_num.Hide()
        pnlnumbers_fsl.Hide()
        pnlPhrases.Hide()
    End Sub

    Private Sub btnFslFamily_Click(sender As Object, e As EventArgs) Handles btnFslFamily.Click
        pnlword.Show()

        cbothings_fsl.Hide()
        cboanimals_fsl.Hide()
        cboplaces_fsl.Hide()
        cbofood_fsl.Hide()
        cbofamily_fsl.Show()
        pnlwords_fsl.Hide()
        pnlAlphabet.Hide()
        pnlAlpha_num.Hide()
        pnlnumbers_fsl.Hide()
        pnlPhrases.Hide()
    End Sub

    Private Sub btnFslAnimals_Click(sender As Object, e As EventArgs) Handles btnFslAnimals.Click
        pnlword.Show()

        cbothings_fsl.Hide()
        cboanimals_fsl.Show()
        cboplaces_fsl.Hide()
        cbofood_fsl.Hide()
        cbofamily_fsl.Hide()
        pnlwords_fsl.Hide()
        pnlAlphabet.Hide()
        pnlAlpha_num.Hide()
        pnlnumbers_fsl.Hide()
        pnlPhrases.Hide()
    End Sub

    Private Sub btnFslPlace_Click(sender As Object, e As EventArgs) Handles btnFslPlace.Click
        pnlword.Show()

        cbothings_fsl.Hide()
        cboanimals_fsl.Hide()
        cboplaces_fsl.Show()
        cbofood_fsl.Hide()
        cbofamily_fsl.Hide()
        pnlwords_fsl.Hide()
        pnlAlphabet.Hide()
        pnlAlpha_num.Hide()
        pnlnumbers_fsl.Hide()
        pnlPhrases.Hide()
    End Sub

    Private Sub btnwords_fsl_Click(sender As Object, e As EventArgs) Handles btnwords_fsl.Click
        pnlwords_fsl.Show()
        pnlAlphabet.Hide()
        pnlAlpha_num.Hide()
        pnlnumbers_fsl.Hide()
        pnlPhrases.Hide()
        pnlword.Hide()
    End Sub

    Private Sub cbothings_fsl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbothings_fsl.SelectedIndexChanged
        Select Case cbothings_fsl.SelectedItem.ToString()
            Case "BAGAY"
                loadImage_words("BAGAY.png")
                lblanimal.Text = "BAGAY"
                lblword_desc.Text = "• I-form ang parehong kamay na nakacurved with thumbs sticking out, at ang mga daliri ay nakalabas din. Pagkatapos, itabi ang mga kamay sa harap ng iyong katawan na may mga daliri ng parehong kamay na nakaharap sa isa't isa, at dahan-dahang tumalbog patagilid habang lumalayo ang mga ito sa isa't isa nang ilang beses."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "LARUAN"
                loadImage_words("LARUAN.png")
                lblanimal.Text = "LARUAN"
                lblword_desc.Text = "• gawin ang kamao ang magkabilang kamay at ilagay ang iyong mga hinlalaki sa pagitan ng iyong hintuturo at gitnang mga daliri. I-pivot ang magkabilang kamay pabalik-balik para gawin ang sign."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "LARUAN"

            Case "DAMIT"
                loadImage_words("DAMIT.png")
                lblanimal.Text = "DAMIT"
                lblword_desc.Text = "• kunin ang parehong bukas na numero 5 na mga kamay at idikit ang iyong mga hinlalaki sa iyong mga balikat habang sinisipilyo mo ang iyong mga kamay sa dibdib nang ilang beses."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "DAMIT"

            Case "SAPATOS"
                loadImage_words("SAPATOS.png")
                lblanimal.Text = "SAPATOS"
                lblword_desc.Text = "• gawing kamao ang iyong dalawang kamay at tapikin ang dalawa nang magkasunod. Isipin na ang iyong mga kamao ay sapatos at ito ay clicking together."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "SAPATOS"

            Case "MEDYAS"
                loadImage_words("MEDYAS.png")
                lblanimal.Text = "MEDYAS"
                lblword_desc.Text = "• ang magkabilang hintuturo ay nakaturo pababa na ang mga palad ay nakaharap pababa. Kuskusin ang magkabilang daliri nang pabalik-balik."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "MEDYAS"

            Case "SIPILYO"
                loadImage_words("SIPILYO.png")
                lblanimal.Text = "SIPILYO"
                lblword_desc.Text = "• parang nag toothbrush ka gamit ang daliri mo. I-extend ang iyong hintuturo at kuskusin ito pabalik-balik sa harap ng iyong mga ngipin."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "SIPILYO"

            Case "TOOTHPASTE"
                loadImage_words("TOOTHPASTE.png")
                lblanimal.Text = "TOOTHPASTE"
                lblword_desc.Text = "• gamitin ang iyong index sa hindi nangingibabaw na kamay at pagkatapos ay gayahin ang paggalaw ng squirting toothpaste gamit ang iyong nangingibabaw na kamay sa iyong brush."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "TOOTHPASTE"

            Case "SHAMPOO"
                loadImage_words("SHAMPOO.png")
                lblanimal.Text = "SHAMPOO"
                lblword_desc.Text = "• ang nangingibabaw na kamay ay ginagaya ang paghawak ng isang bote ng shampoo at ang ilan ay pumulandit sa aming hindi nangingibabaw na kamay. Pagkatapos ay ipagpatuloy namin ang pagsasabon ng aming ulo gamit ang dalawang kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "SHAMPOO"

            Case "SABON"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang iyong hindi nangingibabaw na kamay at hawakan ito nang patag sa harap mo, na nakaharap ang palad. Pagkatapos, hawakan ang iyong nakabaluktot na nangingibabaw na kamay sa itaas ng iyong palad at i-flick ang iyong mga daliri pababa nang ilang beses upang mahawakan nila ang palad ng iyong hindi nangingibabaw na kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "TUWALYA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Isara ang magkabilang kamao, itaas ang mga kamay sa halos balikat na taas, at palipat-lipat ang mga braso, na para bang tinutuyo ang likod ng tuwalya."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "COMPUTER"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ginagawang C-shape ang iyong malakas na kamay. Palawakin ang iyong hindi nangingibabaw na braso, palad na nakaharap pababa, habang hinahaplos ang iyong hugis-C na kamay sa iyong braso."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"
            Case "TELEVISION/TV"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gamitin ang alpabeto ng ASL at sabay na gawin ang letrang T at V."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "REFRIGERATOR"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Unang mag-sign malamig, pagkatapos ay gumawa ng anyo ng isang matangkad na parihaba gamit ang iyong bukas, patag na mga kamay. Simula sa tuktok ng iyong ulo, ilabas ang iyong mga patag na kamay nang patagilid, pagkatapos ay pababa sa magkabilang gilid."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "MICROWAVE"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Buksan at isara ang iyong mga kamay nang magkaharap sa harap mo. Ang paggalaw ay nagbibigay-daan sa iyo upang mailarawan ang mga alon na nagpapainit sa iyong pagkain."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"
            Case "KOTSE"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ilagay ang iyong mga kamay sa paligid ng isang haka-haka na manibela. Pagkatapos ay paikutin ang gulong mula sa tabi-tabi na parang nagmamaneho ka."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "BISIKLETA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Para kang nagbibisikleta gamit ang iyong mga paa. Gawing kamao ang dalawang kamay, pagkatapos ay gumawa ng mga patayong bilog sa hangin sa harap ng iyong katawan."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "TREN"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang dalawang kamay, pinalawak ang gitna at hintuturo. Kunin ang iyong nangingibabaw na kamay at dahan-dahang kuskusin ang mga daliri sa parehong mga daliri sa hindi nangingibabaw na kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "BANGKA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Magkadikit ang iyong mga kamay sa hugis ng bangka. Pagkatapos ay ilipat ang iyong mga kamay pataas at pababa habang pinapalawak ang mga ito pasulong. Tila isang maliit na bangka na umuusad sa ilang banayad na alon."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "EROPLANO"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang iyong nakalahad na kamay, at isuksok ang iyong gitna at singsing na mga daliri. Pagkatapos ay ilipat ang iyong kamay palayo sa iyong katawan ng isang maikling distansya, na parang lumilipad, i-bobbing ito pabalik-balik ng ilang beses."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"
            Case "HELICOPTER"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumawa ng horizontal number 3 sign gamit ang iyong hindi nangingibabaw na kamay, na nakaharap ang palad sa iyong katawan, at nakadikit ang hinlalaki. Pagkatapos ay takpan ito ng iyong bukas, nangingibabaw na kamay na lumilikha ng isang paggalaw na ginagaya ang mga blades."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "PALAYOK"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang iyong dalawang hubog, bukas na mga kamay, simula sa iyong mga bisig na nakahawak sa antas ng baywang, pagkatapos ay ilipat ang magkabilang hubog na mga kamay pataas nang sabay-sabay, na parang tinutunton ang mga hubog na gilid ng isang malalim na palayok pataas."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "MANGKOK"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Magsimula sa magkabilang hubog na mga kamay na magkatabi sa harap mo, nakaharap ang mga palad. Pagkatapos ay paghiwalayin ang iyong mga kamay nang sabay-sabay habang ginagaya nila ang pagbalangkas ng hugis at sukat ng isang mangkok para sa pagkain."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "SUKLAY"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Isara ang kamao ng iyong nangingibabaw na kamay gamit ang hinlalaki na nakaturo pataas at gawin ang galaw ng pagsipilyo ng iyong buhok."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "SALAMIN"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ilagay ang iyong nangingibabaw na kamay sa harap mo nang magkasama ang lahat ng mga daliri at nakaturo paitaas. Igalaw ang kamay sa isang paikot-ikot na paggalaw na parang sinusuri mo ang iyong repleksyon."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"
            Case "CAMERA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ibaluktot ang iyong hinlalaki at hintuturo sa magkabilang kamay upang gawin ang apat na sulok ng camera. Pagkatapos ay i-click ang camera sa pamamagitan ng pagpapahaba at pagyuko ng hintuturo sa iyong nangingibabaw na kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "PAPEL"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ilatag ang iyong hindi nangingibabaw na kamay, nakaharap ang palad, upang kumilos bilang base o pangunahing aklat. Pagkatapos ay kunin ang iyong patag, nangingibabaw na kamay at gayahin ang pagpindot sa ilang papel sa pamamagitan ng pagtulak nito patagilid at sa tapat na direksyon laban sa 'libro'."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "LIBRO"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ilagay ang iyong mga kamay nang magkasama, palad-sa-palad. Pagkatapos ay panatilihing magkasama ang iyong mga pinkies, buksan ang iyong mga kamay na parang binubuksan ang isang libro."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "BAG"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang iyong nangingibabaw na kamay sa isang kamao, na ang palad ay nakaharap pababa sa harap ng iyong katawan. Paulit-ulit na i-bounce ang kamay pataas at pababa sa isang maliit na galaw. Ang karatula ay malapit na kahawig ng isang kamay na may hawak na isang shopping bag at itinataas-baba ito."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "PERA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Iabot mo ang iyong kamay na hindi nangingibabaw na parang nanghihingi ng limos. Pagkatapos ay kunin ang iyong nangingibabaw na kamay gamit ang iyong hinlalaki na hawakan ang iyong mga daliri, na bumubuo ng isang baluktot na 'O' na kamay, at i-tap ito sa mga daliri ng iyong mahinang kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"
            Case "SALAMIN SA MATA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-curve lang ang iyong mga hintuturo at hinlalaki sa magkabilang mata nang sabay, na bumubuo ng hugis ng mga lente ng salamin."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "PANULAT"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Iunat ang iyong hindi nangingibabaw na kamay nang patag, na nakaharap ang iyong palad, pagkatapos ay magpatuloy sa pagkukunwaring pagsusulat dito na ang iyong nangingibabaw na kamay ay nabuo na parang humahawak ng panulat at sumusulat. Patakbuhin ang iyong nangingibabaw na kamay nang isang beses sa kabilang palad, mula sa base hanggang sa paglampas ng iyong mga daliri."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "LAPIS"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Itaas ang iyong hindi nangingibabaw na kamay, na nakaharap ang palad. Pagkatapos ay kunin ang iyong nangingibabaw na kamay nang nakabaluktot ang iyong hintuturo at hawakan ang iyong hinlalaki sa iyong bibig. Panghuli, ibaba ang iyong kamay na parang may isusulat sa palad ng iyong hindi nangingibabaw na kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "PAYONG"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Magsimula sa dalawang kamao na nakasalansan sa ibabaw ng bawat isa gamit ang iyong nangingibabaw na kamay sa itaas. Itaas ang tuktok na kamao. Ang tanda ay parang nagbubukas ka ng payong."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "BACKPACK"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang parehong hubog o 'C' na mga kamay at patakbuhin ang iyong mga daliri pataas at pababa sa pagitan ng iyong mga balikat at dibdib. Ang paggalaw ay kahawig mo na pinapatakbo ang iyong mga daliri sa mga strap ng isang backpack."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"
            Case "BOTE"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ang iyong mahinang kamay ay dapat na bukas, na nakaharap ang palad upang mabuo ang base. Gamit ang iyong nangingibabaw na kamay, magsimula pababa sa base na may bukas na grip o 'C' na kamay, pagkatapos ay itaas ang iyong kamay sa isang haka-haka na bote, isara ang iyong grip habang umaakyat ka."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "BASO"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang iyong nangingibabaw na kamay at balutin ang iyong mga daliri sa hugis na 'C', na parang may hawak kang tasa. Kunin ang iyong hindi nangingibabaw na kamay at ihiga ito nang patag, nakaharap ang palad, na parang ito ay isang table top. Kunin ang nangingibabaw na kamay at ilagay ito sa patag na kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "TINIDOR"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang iyong hindi nangingibabaw na kamay nang nakaharap ang iyong palad upang mabuo ang plato. Pagkatapos ay gumawa ng isang tinidor gamit ang hintuturo at gitnang mga daliri sa iyong nangingibabaw na kamay at ilagay ito sa plato, hawakan ang plato ng ilang beses gamit ang iyong mga daliri na kumikilos bilang mga tines ng tinidor."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "KUTSARA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "gumawa ng isang mangkok sa pamamagitan ng pag-cup sa iyong hindi nangingibabaw na kamay at isang kutsara gamit ang hintuturo at gitnang mga daliri ng iyong nangingibabaw na kamay. Sandok ang mga hindi nakikitang nilalaman sa isang maikling distansya mula sa 'mangkok,' nang hindi dinadala ang iyong kamay sa bibig."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "PLATO"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "kunin ang iyong parehong mga kamay at bumuo ng mga kamao, ilabas lamang ang iyong mga hintuturo at hinlalaki. Pagkatapos gamit ang dalawang kamay, gayahin ang balangkas ng isang plato sa harap ng iyong katawan."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"
            Case "NAPKIN"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "gawin lamang ang galaw ng pagpahid sa magkabilang gilid ng iyong bibig gamit ang iyong nangingibabaw, binagong titik O na kamay, simula sa isang sulok ng iyong bibig hanggang sa isa pa."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "KUTSILYO"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "gumawa ng kutsilyo gamit ang hintuturo at gitnang daliri ng iyong nangingibabaw na kamay, at isang ibabaw na may parehong mga daliri ng iyong hindi nangingibabaw. Tapusin ang karatula sa pamamagitan ng paggawa ng pabalik-balik na paggalaw ng pagputol."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "GUNTING"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "gamitin ang hintuturo at gitnang mga daliri ng iyong nangingibabaw na kamay at igalaw ang mga ito sa isang paggalaw ng paggupit."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "KRAYOLA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "una, i-sign ang kulay, pagkatapos ay i-sign ang panulat. Upang mag-sign ng kulay, dalhin ang iyong mga daliri sa iyong baba at igalaw ang mga ito sa lugar. Para pirmahan ang panulat, gayahin lang ang pagsulat ng isang bagay gamit ang panulat sa patag na ibabaw. Iunat ang iyong hindi nangingibabaw na kamay na patag, nakaharap ang palad, pagkatapos ay magkunwaring sumusulat dito na ang iyong nangingibabaw na kamay ay nabuo na parang may hawak na panulat."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "PANUKAT"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Buuin ang ASL letter Y sign na nasa harap mo ang dalawang kamay, ang kanilang mga hinlalaki ay paputol-putol na magkadikit habang pinagagalaw mo ang iyong mga kamay at hinihiwalay ang mga ito ng ilang beses, na nagpapahiwatig ng haba o lapad ng isang bagay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"
            Case "PANDIKIT"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "gawing kamao ang iyong nangingibabaw na kamay habang nakalabas ang iyong hinlalaki at ang iyong hindi nangingibabaw na kamay sa isang patag na ibabaw ay nakaharap pataas. Gumawa ng mga bilog sa iyong palad na hindi nangingibabaw gamit ang dulo ng hinlalaki ng iyong nangingibabaw na kamay, na parang naglalagay ka ng pandikit sa papel."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "UPUAN"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "sa bawat kamay, kunin ang iyong gitnang daliri at hintuturo at hawakan ang mga ito nang magkasama. Kunin ang dalawang daliri ng iyong nangingibabaw na kamay at i-tap ang mga ito nang patag sa ibabaw ng dalawang daliri sa iyong hindi nangingibabaw na kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "SOFA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "ginawa sa pamamagitan ng pagturo ng hintuturo at gitnang mga daliri ng iyong hindi nangingibabaw na kamay nang patagilid at paglalagay ng parehong mga daliri ng iyong nangingibabaw na kamay sa ibabaw ng una, na para bang ang iyong hindi nangingibabaw na kamay ay isang upuan. Kumpletuhin ang sign sa pamamagitan ng paghila ng iyong nangingibabaw na kamay palayo sa kabilang banda, na nagpapahiwatig ng isang 'mahabang' upuan."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "KAMA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Pagdikitin ang iyong dalawang kamay, palad-sa-palad. Pagkatapos ay ilagay ang iyong mga kamay sa isang anggulo sa gilid ng iyong ulo, at ipahinga ang iyong pisngi sa iyong mga kamay na parang isang unan o ipahinga ang iyong pisngi sa nakabukas na palad ng iyong nangingibabaw na kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "KUMOT"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "kunin ang dalawang kamay gamit ang iyong mga daliri na naka-extend at nakasuksok ang mga hinlalaki sa ilalim. Magsimula sa iyong mga palad na nakaharap sa iyong katawan at pababa, pagkatapos ay hilahin ang iyong mga kamay hanggang sa antas ng dibdib."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"
            Case "UNAN"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "ihilig nang bahagya ang iyong ulo patungo sa direksyon ng iyong nangingibabaw na kamay, na parang inihiga mo ang iyong ulo upang matulog. Pagkatapos ay kunin ang iyong dalawang nakabukang palad, magkaharap ngunit medyo distansiya, na parang may hindi nakikitang unan sa pagitan ng iyong magkabilang kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "LAMPARA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "gawin lang ang sign gamit ang nangingibabaw na kamay at bisig, hindi kasama ang hindi nangingibabaw na kamay at bisig, na nagsisilbing table top."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "FLASHLIGHT"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ang iyong hindi nangingibabaw na kamay ay ang 'may hawak' na braso: hinawakan mo ang iyong hintuturo sa iyong hinlalaki upang makagawa ng isang bilog, pagkatapos ay hinawakan ito sa pulso ng iyong nangingibabaw na kamay. Ang iyong nangingibabaw na kamay ay nagsisimula bilang isang saradong kamao pagkatapos ay mabilis na bumubukas na nakabuka ang lahat ng mga daliri, upang ipahiwatig ang sinag ng liwanag."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "LAMESA"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "hawakan nang pahalang ang iyong mga kamay at mga bisig sa harap ng iyong katawan, ang nangingibabaw na bisig sa itaas ng hindi nangingibabaw, at tapikin ang mga ito nang magkasama. Ang tanda ay parang nagsasaad ng ibabaw ng isang mesa."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "MUWEBLES"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "buuin ang iyong nangingibabaw na kamay sa ASL F, pagkatapos ay iling ito mula sa gilid hanggang sa gilid."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "DRAWER"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "Magsimula sa iyong dalawang kamay sa harap ng iyong katawan na may saradong mga kamao, pagkatapos ay hilahin ang iyong nakasarang mga kamay pabalik sa iyong katawan. Natural na tanda at parang nagbubukas ka ng drawer."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "KWINTAS"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-trace lamang ang isang kuwintas sa iyong leeg gamit ang parehong mga hintuturo na nagsisimula sa gitna ng iyong itaas na katawan, pagkatapos ay sabay-sabay na gumagalaw pataas at sa paligid ng iyong leeg."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"

            Case "HIKAW"
                loadImage_words(cbothings_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings_fsl.SelectedItem.ToString
                lblword_desc.Text = "hawak at pinakawalan ang iyong tainga sa pagitan ng iyong hintuturo at iyong hinlalaki. Ang tanda ay parang naglalagay ka ng hikaw."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "BAGAY"
        End Select
    End Sub

    Private Sub cboplaces_fsl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboplaces_fsl.SelectedIndexChanged
        Select Case cboanimals_fsl.SelectedItem.ToString()
            Case "Palaruan"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "Unang sign play, ginagawa ang iyong mga kamay sa mga kamao na may thumbs at pinkies extended. Pagkatapos ay i-twist ang iyong mga kamay pabalik-balik. Pagkatapos ay pirmahan ang lugar, na itinaas ang iyong nangingibabaw na kamay at ibaba ang palad, na gumagawa ng mga pahalang na bilog sa hangin."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "LUGAR"
            Case "Banyo"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumawa ng isang letrang 'T' gamit ang aming nangingibabaw na kamay, at iiling-iling namin ito pabalik-balik sa aming harapan."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "LUGAR"
            Case "Kwarto"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "Magsisimula ka sa pamamagitan ng pagpirma sa kama, pagsasama-sama ng iyong dalawang kamay nang magkadikit ang mga palad, at ilagay ang mga ito sa gilid ng iyong ulo na parang isang unan. Pagkatapos ay pumirma ka sa kahon o silid, sa pamamagitan ng pagkuha ng iyong dalawang nakabukas na mga palad na magkaharap sa isa't isa at ilang pulgada ang pagitan, at binabalangkas ang apat na gilid ng isang silid."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblcategory_words.Text = "LUGAR"
            Case "Kusina"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumawa ng titik na 'k' gamit ang iyong nangingibabaw na kamay at i-flip ito pabalik-balik sa iyong patag, bukas, hindi nangingibabaw na kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "LUGAR"
            Case "Hapag Kainan"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-sign ang pagkain sa pamamagitan ng pagdadala ng iyong nangingibabaw na kamay sa iyong bibig nang magkasama ang lahat ng mga daliri, at kumpletuhin ang karatula gamit ang karatula para sa silid, na ginagawa sa pamamagitan ng paggawa ng isang parisukat na ang dalawang kamay ay direkta sa harap mo."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblcategory_words.Text = "LUGAR"
            Case "Bahay"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "Binabalangkas ang hugis ng isang simpleng bahay. Palawakin ang iyong dalawang kamay, pagkatapos ay simula sa bubong, balangkasin ang pahilig na linya ng bubong - pagkatapos ay ang mga patayong dingding. (Hindi namin karaniwang binabalangkas ang lupa.)"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblcategory_words.Text = "LUGAR"
            Case "Garahe"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "Sa iyong hindi nangingibabaw na kamay na kumikilos bilang garahe, nakabukas ang palad at nakaharap sa lupa, sa taas ng dibdib. Pagkatapos ay gawing 'kotse' ang iyong nangingibabaw na kamay, na nakabuka ang iyong hinlalaki, hintuturo at gitnang mga daliri mula sa isang kamao at pagkatapos ay gumagalaw pabalik-balik sa ilalim ng hindi nangingibabaw na kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblcategory_words.Text = "LUGAR"
            Case "Silid"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumawa ng isang parisukat gamit ang dalawang kamay direkta sa harap mo. Una, hawakan ang iyong mga flat na kamay parallel sa harap ng iyong katawan, humigit-kumulang isang talampakan ang layo habang ang parehong mga palad ay nakaharap sa loob. Pagkatapos ay igalaw ang dalawang kamay upang magkapantay pa rin ang mga ito ngunit magkaharap ang mga palad."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblcategory_words.Text = "LUGAR"
            Case "Basement"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "Sa iyong hindi nangingibabaw na kamay at inihiga ito nang patag at pahalang sa harap ng iyong katawan, na parang gumagawa ng sahig gamit ang iyong kamay. Gawin ang kamao ang iyong nangingibabaw na kamay habang nakataas ang iyong hinlalaki, at igalaw ang iyong kamay sa maliliit at pahalang na bilog sa ilalim ng iyong hindi nangingibabaw na kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblcategory_words.Text = "LUGAR"
            Case "Opisina"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumawa ng isang letrang 'O' gamit ang iyong hindi nangingibabaw na kamay at igalaw ito pabalik-balik sa harap ng iyong mukha, na tila isang umiikot na pinto."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "LUGAR"
            Case "Pamayanan"
                loadImage_words(cboplaces_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces_fsl.SelectedItem.ToString
                lblword_desc.Text = "Sa iyong hinlalaki at hintuturo ng iyong hindi nangingibabaw na kamay, gawin ang letrang 'P' at igalaw ito sa isang pabilog na kilusan sa iyong palad ng ibaba. Pagkatapos ay idagdag ang paggalang para sa lugar sa pamamagitan ng pag-akyat ng iyong hinlalaki at daliri ng gitna."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblcategory_words.Text = "LUGAR"



        End Select
    End Sub

    Private Sub cbofood_fsl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofood_fsl.SelectedIndexChanged
        Select Case cbofood_fsl.SelectedItem.ToString()
            Case "PRUTAS"
                loadImage_words("FRUIT.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gawin ang sign na 'F' at idikit ito sa iyong pisngi. I-twist ang 'F' sa iyong pisngi ng dalawang beses. Panatilihin ang contact para sa buong sign. (Ang kamay ay hindi umaalis sa iyong pisngi, at hindi rin ito umuusad sa pisngi.)"
                lblcategory_words.Text = "Pagkain"

            Case "MANSANAS"
                loadImage_words("APPLE.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Bumuo ng ASL letter A gamit ang isang kamay sa pamamagitan ng paggawa ng isang kamao at paglalagay ng iyong hinlalaki sa iyong hintuturo, pagkatapos ay ilagay ang iyong hinlalaki sa iyong pisngi at i-twist ang iyong kamay pasulong."
                ' Isalin ang kahulugan ng Mansanas sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "ORANGE"
                loadImage_words("ORANGE.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ilagay ang iyong nangingibabaw na kamay malapit sa iyong baba, at paulit-ulit na pisilin ang iyong kamay sa isang kamao at magpahinga. Para kang pumipiga ng orange."
                ' Isalin ang kahulugan ng Orange sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "SAGING"
                loadImage_words("BANANA.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Itaas ang isang hintuturo, na ang dulo ay nakaturo sa langit. Pagkatapos, gamit ang iyong kabaligtaran na kamay, gawin ang mga paggalaw ng pagbabalat ng saging, simula sa dulo ng iyong daliri at gumagalaw pababa at palabas."
                ' Isalin ang kahulugan ng Saging sa pagkain
                lblcategory_words.Text = "Pagkain"

' Continue with the rest of the cases, making the same change

            Case "PINYA"
                loadImage_words("PINEAPPLE.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang iyong nangingibabaw na kamay at buuin ang letrang 'F' sa ASL: hawakan ang iyong hintuturo at hinlalaki nang magkasama habang ang iba pang mga daliri ay nakabukaka. Pagkatapos ay hawakan ang pabilog na espasyo sa pagitan ng dalawang daliri sa iyong nangingibabaw na mata at i-pivot ito sa paligid ng mata ng ilang beses, na para bang isa sa maraming 'mga mata' sa isang pinya, habang ang mga nakatuwad na daliri ay parang mga matinik na dahon na lumalabas sa tuktok ng prutas na ito."
                ' Isalin ang kahulugan ng Pinya sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "PERAS"
                loadImage_words("PEAR.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Nakataas ang isang kamay, gawin ang hugis ng peras sa pamamagitan ng pagsara ng iyong mga daliri sa iyong hinlalaki. Pagkatapos ay takpan ito ng iyong kabilang kamay at i-slide pataas."
                ' Isalin ang kahulugan ng Peras sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "AVOCADO"
                loadImage_words("AVOCADO.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Buuin ang ASL letter A sign gamit ang iyong dominanteng kamay. Pagkatapos ay i-curve ang iyong hindi nangingibabaw na kamay sa isang maliit na mangkok o tasa at gayahin ang pag-scoop ng 'abukado' dito gamit ang iyong nangingibabaw na 'A' na kamao."
                ' Isalin ang kahulugan ng Avocado sa pagkain
                lblcategory_words.Text = "Pagkain"

' Continue with the rest of the cases, making the same change

            Case "CHERRY"
                loadImage_words("CHERRY.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Palawakin ang iyong pinkie mula sa iyong hindi nangingibabaw na kamay, upang maging tangkay ng isang cherry. Pagkatapos ay kunin ang mga daliri mula sa iyong nangingibabaw na kamay at ilagay ang mga ito sa dulo ng hindi nangingibabaw na pinkie, iikot ang mga daliri sa paligid."
                ' Isalin ang kahulugan ng Cherry sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "UBAS"
                loadImage_words("GRAPES.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gamit ang iyong kamay sa hugis ng claw, i-tap ang iyong mga daliri sa iyong kabilang kamay, na nagpapakita ng mga kumpol ng ubas."
                ' Isalin ang kahulugan ng Ubas sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "PEACH"
                loadImage_words("PEACH.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumawa ng nakakarelaks-5 na hugis ng kamay, at pagkatapos ay bahagyang ilapat ang iyong mga daliri sa iyong pisngi nang ilang beses."
                ' Isalin ang kahulugan ng Peach sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "CARROTS"
                loadImage_words("CARROTS.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumawa ng ASL letter S sa pamamagitan ng pagbuo ng kamao gamit ang iyong hinlalaki na nakabalot sa labas ng iyong mga daliri. Ilipat ang iyong kamao hanggang sa iyong bibig na parang kumakain ka ng isang karot."
                ' Isalin ang kahulugan ng Carrots sa pagkain
                lblcategory_words.Text = "Pagkain"

' Continue with the rest of the cases, making the same change

            Case "PEAS"
                loadImage_words("PEAS.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-extend ang parehong hintuturo at, gamit ang dulo ng isang hintuturo, hawakan ang gilid ng isa pang hintuturo nang ilang beses, gumagalaw mula sa knuckle hanggang dulo ng daliri."
                ' Isalin ang kahulugan ng Peas sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "MAIS"
                loadImage_words("CORN.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Magkunwaring may hawak kang isang cob ng mais sa iyong mga kamay pagkatapos ay ilipat ang iyong mga kamay sa iyong bibig, at iikot ang iyong mga kamay na parang pinipihit mo ang isang corn cob habang kinakain mo ito."
                ' Isalin ang kahulugan ng Mais sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "LETTUCE"
                loadImage_words("LETTUCE.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Hawakan ang takong ng iyong palad sa iyong ulo ng ilang beses. Sa paggalaw na ito, ang iyong kamay ay kumakatawan sa mga dahon ng lettuce."
                ' Isalin ang kahulugan ng Lettuce sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "ALMUSAL"
                loadImage_words("BREAKFAST.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ang Eat (Food) ay signed sa pamamagitan ng pagkuha ng iyong nangingibabaw na kamay gamit ang hinlalaki na hinahawakan ang iyong apat na daliri, pagkatapos ay dinadala ang kamay sa bibig nang paulit-ulit. Ang tanda para sa umaga ay parang ang araw na sumisikat sa abot-tanaw."
                ' Isalin ang kahulugan ng Almusal sa pagkain
                lblcategory_words.Text = "Pagkain"

' Continue with the rest of the cases, making the same change

            Case "CEREAL"
                loadImage_words("CEREAL.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang nangingibabaw na kamay sa isang kamao habang nakaunat ang iyong hintuturo at pagkatapos ay binawi habang iginagalaw mo ang iyong kamay sa abot-tanaw ng iyong bibig."
                ' Isalin ang kahulugan ng Cereal sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "ITLOG"
                loadImage_words("EGG.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang iyong hintuturo at ang iyong gitnang daliri mula sa bawat kamay, hawakan ang mga ito nang magkasama. Hawakan ang magkabilang daliri na nakaturo paitaas, pagkatapos ay hilahin ang mga ito pababa at paghiwalayin."
                ' Isalin ang kahulugan ng Itlog sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "BIGAS"
                loadImage_words("RICE.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Buuin ang iyong nangingibabaw na kamay sa ASL letter R sign. Pagkatapos ay lumikha kami ng isang mangkok gamit ang aming hindi nangingibabaw na kamay, habang gumagawa ng isang kutsara na may 'R' na nabuo ng nangingibabaw na kamay. Sandokin ang kanin hanggang sa bibig."
                ' Isalin ang kahulugan ng Bigas sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "BACON"
                loadImage_words("BACON.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Magsimula sa pamamagitan ng pagbuo ng mga kamao gamit ang parehong mga kamay, pagpapalawak ng gitna at hintuturo, pagdikit sa mga ito nang magkasama. Susunod, paghiwalayin ang mga kamay habang iwinawagayway ang mga ito pataas at pababa sa maliliit na galaw na umaalon."
                ' Isalin ang kahulugan ng Bacon sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "PANGHIMAGAS"
                loadImage_words("CONDIMENT.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Kunin ang iyong nangingibabaw na kamay at i-brush ang iyong baba gamit ang iyong mga daliri, pabalik-balik."
                ' Isalin ang kahulugan ng Panghimagas sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "CAKE"
                loadImage_words("CAKE.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Itaas ang isang kamay sa dibdib, panatilihing patag at nakataas ang palad. Sa iyong kabilang kamay sa posisyong 'C', pindutin ang mga dulo ng daliri sa nakabukas na palad, at i-slide mula sa ibaba ng palad hanggang sa mga dulo ng mga daliri."
                ' Isalin ang kahulugan ng Cake sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "CUPCAKE"
                loadImage_words("CUPCAKE.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumamit ng parehong kamay na nakabukas ang palad at ipitin ang mga ito pataas at pababa, parang nagpapasiklab na kandila sa ibabaw ng isang maliit na cupcake."
                ' Isalin ang kahulugan ng Cupcake sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "ICE CREAM"
                loadImage_words("ICECREAM.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Itaas ang isang kamay na parang nagwawagi, pagkatapos ay gamitin ang iyong palad sa pag-paint ng semi-circle sa harap mo na para bang nilalabas mo ang ice cream mula sa cone."
                ' Isalin ang kahulugan ng Ice Cream sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "HOTDOG"
                loadImage_words("HOTDOG.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Mag-extend ng isang kamay, itaas ito, at i-flex ang iyong palad. Gamitin ang iyong daliri sa kabilang kamay na parang nagdidikit-dikit na hotdog sa loob ng tinapay."
                ' Isalin ang kahulugan ng Hotdog sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "HAMBURGER"
                loadImage_words("HAMBURGER.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-extend ang parehong mga kamay na parang nagwawagi, pagkatapos ay ilahad ang iyong mga daliri tulad ng pagbubukas ng isang tinapay ng hamburger. Ilagay ang imaginary na patty at iba't ibang sangkap sa gitna ng dalawang kamay."
                ' Isalin ang kahulugan ng Hamburger sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "NACHOS"
                loadImage_words("NACHOS.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumamit ng parehong kamay na parang nag-aalanganin na hawakan ang isang malaking chip ng nachos, itaas ito sa harap mo, at ilagay ang mga topping gamit ang iyong hindi nangingibabaw na kamay."
                ' Isalin ang kahulugan ng Nachos sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "PIZZA"
                loadImage_words("PIZZA.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Buuin ang parehong kamay sa hugis ng triangle tulad ng paghahati ng isang pizza. I-flex ang iyong mga daliri sa kabilang kamay upang ipakita ang kanyang kakaibang lasa at uri ng pizza."
                ' Isalin ang kahulugan ng Pizza sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "SANDWICH"
                loadImage_words("SANDWICH.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-flex ang iyong mga daliri tulad ng pagbubukas ng isang tinapay, at pagkatapos ay ilagay ang iyong mga imaginary na sangkap sa gitna. Isara ito gamit ang iyong dalawang kamay tulad ng pagbabalot ng isang sandwich."
                ' Isalin ang kahulugan ng Sandwich sa pagkain
                lblcategory_words.Text = "Pagkain"

' Continue with the rest of the cases, making the same changes

            Case "FRIES"
                loadImage_words("FRIES.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-flex ang iyong mga daliri sa hugis ng stick tulad ng pag-curl ng fries. Ilahad ang iyong mga daliri sa kabilang kamay, na parang pagpipiga ng ketsup o dip sa fries."
                ' Isalin ang kahulugan ng Fries sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "COFFEE"
                loadImage_words("COFFEE.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Buuin ang isang maliit na wheel gamit ang iyong parehong kamay, na parang pagmamasahe sa isang tasa ng kape. I-flex ang iyong mga daliri sa pagpapahayag ng init o lamig ng iyong iniinom."
                ' Isalin ang kahulugan ng Coffee sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "TEA"
                loadImage_words("TEA.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Hawakan ang hawak ng kutsara gamit ang iyong nangingibabaw na kamay, at gawin ang maliit na galaw ng pag-scoop na parang iniinom ang tea. I-flex ang iyong daliri para sa 'sip' na pag-inom."
                ' Isalin ang kahulugan ng Tea sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "SALAD"
                loadImage_words("SALAD.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumamit ng parehong kamay, ipitin ang mga daliri at gawin ang maliit na galaw ng pagtutok sa isang salad bowl."
                ' Isalin ang kahulugan ng Salad sa pagkain
                lblcategory_words.Text = "Pagkain"

            Case "SOUP"
                loadImage_words("SOUP.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumamit ng parehong kamay, parang paghawak ng mangkok ng sopas, at gawin ang maliit na galaw ng pag-scoop tulad ng pag-inom ng sabaw."
                ' Isalin ang kahulugan ng Soup sa pagkain
                lblcategory_words.Text = "Pagkain"

' Continue with the rest of the cases, making the same changes

            Case "CHOCOLATE"
                loadImage_words("CHOCOLATE.png")
                lblanimal.Text = cbofood_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumamit ng parehong kamay, itaas ang iyong daliri ng gitna gamit ang iyong nangingibabaw na kamay, at ilapat ang iyong mga daliri sa iyong pisngi, na parang pag-apply ng lipstick. I-flex ang iyong mga daliri bilang expression ng kasiyahan."
                ' Isalin ang kahulugan ng Chocolate sa pagkain
                lblcategory_words.Text = "Pagkain"
        End Select
    End Sub

    Private Sub cbofamily_fsl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofamily_fsl.SelectedIndexChanged
        Select Case cbofamily_fsl.SelectedItem.ToString()
            Case "Mama/Nanay"
                loadImage_words("MOTHER.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ipadama ang iyong kamay sa buong kalahating mukha mula sa gilid ng ulo. Pagkatapos ay hawakan at itaas ang iyong palad."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Papa/Tatay"
                loadImage_words("FATHER.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ilagay ang iyong mga kamay sa itaas ng ulo, i-cross ang iyong mga hinlalaki, at itaas ang iyong mga daliri tulad ng may korona. Pagkatapos ay i-rotate ng bahagya."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Kuya"
                loadImage_words("BROTHER.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gamitin ang iyong dalawang hintuturo, i-tabi ang mga ito, at ipahayag ang salitang 'kuya.'"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Ate"
                loadImage_words("SISTER.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gamitin ang iyong dalawang hintuturo, i-tabi ang mga ito, at ipahayag ang salitang 'ate.'"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Sanggol"
                loadImage_words("BABY.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ilagay ang iyong mga bisig sa hugis Y, ibaba ito mula sa iyong mukha, at itaas ang iyong mga bisig."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Lolo"
                loadImage_words("GRANDFATHER.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-galaw ang iyong kamay sa hugis U mula sa iyong noo pababa sa iyong dibdib."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Lola"
                loadImage_words("GRANDMOTHER.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-galaw ang iyong kamay sa hugis U mula sa iyong noo pataas sa harap ng iyong mukha."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Pamangkin"
                loadImage_words("COUSIN.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-galaw ang iyong daliri sa hugis C mula sa iyong pisngi pataas sa iyong mata, pagkatapos ay gawin itong ulit."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Tita"
                loadImage_words("AUNT.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-galaw ang iyong kamao sa paligid ng iyong pisngi, hindi hawakan ito, at itaas ang iyong palad."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Tito"
                loadImage_words("UNCLE.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-galaw ang iyong daliri sa hugis U mula sa gilid ng iyong ulo pataas sa harap ng iyong mukha."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Pamangkin na Lalaki"
                loadImage_words("NEPHEW.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-galaw ang iyong daliri sa hugis N sa harap ng iyong mukha, pagkatapos ay i-twist ito pabalik-balik."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Pamangkin na Babae"
                loadImage_words("NIECE.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-galaw ang iyong daliri sa hugis N sa harap ng iyong mukha, pagkatapos ay i-twist ito pabalik-balik."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Mga Bata"
                loadImage_words("CHILDREN.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-galaw ang iyong mga palad pataas at pababa sa harap ng iyong katawan, parang tinatapik ang ulo ng bata."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
            Case "Bata"
                loadImage_words("KID.png")
                lblanimal.Text = cbofamily_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-kamao ang iyong palad, i-bukas ang iyong hinlalaki at pinkie fingers, at i-rotate ito pataas at pababa sa harap ng iyong mukha."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "Tao"
        End Select

    End Sub

    Private Sub cboanimals_fsl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboanimals_fsl.SelectedIndexChanged
        Select Case cboanimals_fsl.SelectedItem.ToString()

            Case "Pusa"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "I-pinch ang iyong hintuturo at hinlalaki nang magkasama na parang ASL ng F, na iniwang magkahiwalay ang natitirang bahagi ng iyong mga daliri. Hawakan ang gitna ng iyong pisngi gamit ang iyong mga daliring naipit at i-stroke patungo sa iyong tainga ng ilang beses. (Magpanggap na hinahaplos mo ang mga balbas sa isang pusa.)"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Aso"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Tapikin ang iyong binti gamit ang isang bukas na kamay at, pagkatapos ng tapikin, itaas ang iyong kamay at pumitik nang isang beses."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Isda"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Iunat ang iyong kamay na parang makikipagkamay ka, at pagkatapos ay igalaw ang iyong kamay mula sa gilid patungo sa gilid habang ito ay inilalayo. (Magpanggap na ang iyong nanginginig na kamay ay isang isda na lumalangoy sa tubig.)"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Ibon"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumawa ng isang kamao at i-extend ang iyong hintuturo at hinlalaki, ilagay ang likod ng iyong kamay sa iyong baba, pagkatapos ay buksan at isara ang iyong hintuturo at hinlalaki. (ang iyong mga daliri ay kumakatawan sa tuka ng isang ibon.)"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Kabayo"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gumawa ng isang kamao at pagkatapos ay i-extend ang iyong unang dalawang daliri at hinlalaki, nakaturo ang mga daliri, at pagkatapos ay ilagay ang iyong hinlalaki sa iyong ulo sa itaas ng iyong tainga at ibaluktot ang iyong mga daliri pasulong ng ilang beses."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Tupà"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Iunat ang isang nakabaluktot na braso sa harap mo, gamitin ang unang dalawang daliri ng iyong kabilang kamay upang lumikha ng 'gunting,' at pagkatapos ay ilipat ang iyong 'gunting' pataas at pababa sa kabilang braso. (Ginagaya ng palatandaang ito ang paggugupit ng tupa.)"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Baboy"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gawin ang ASL sign para sa B (hinahawakan ang lahat ng apat na daliri ng isang kamay nang tuwid, hawakan, habang ipinatong ang iyong hinlalaki sa iyong palad), ilagay ang tuktok ng iyong letter B hand sa ilalim ng iyong baba, at bend your fingers down once or twice."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Bibe"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gawing kamao ang iyong kamay at i-extend ang iyong hintuturo, gitnang daliri, at hinlalaki, pagkatapos ay ilagay ang likod ng iyong kamay sa iyong baba, at buksan at isara ang iyong mga daliri at hinlalaki."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Palaka"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ilagay ang isang kamao sa ilalim ng iyong baba, at pagkatapos ay ilipat ang iyong unang dalawang daliri palabas at sa ilang beses, na ang iyong hinlalaki ay sumasalo sa mga daliri sa paggalaw."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Baka"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gawin ang iyong kamay into a fist then straighten your pinkie finger and straighten your thumb. The two extended fingers on your hand should like the horns of a cow. Take your thumb and put it by the side of your head and twist your hand around."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Manok"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Start with the bird sign. Take your thumb and index finger and make an open beak, while making the rest of your hand into a fist. Close the beak and bring it down to peck at the ground as represented by your other outstretched hand, palm facing up."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Kambing"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Make a slightly bent or curved 'V' with your dominant hand, then tap your chin with the two fingers, followed by tapping your forehead with the same curved - or now straightened - 'V' hand."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Kuneho"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Make both hands into fists and place them on top of your head, with middle and index fingers extended to make the rabbit ears. Bend and extend the middle and index fingers to the back of your head, as if to make the ears twitch."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Daga"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Use your dominant index finger to flick back and forth across the tip of your nose. You can remember that this sign is like you are moving your mouse nose back and forth."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Leon"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Make your hand into a claw shape with your fingers curved and apart. Take your hand, and with the palm down, run it from above the front of your forehead down toward the back of your head."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Unggoy"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Take your arms out and scratch at your armpits with your hands."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 16)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Giraffe"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Make your dominant hand a 'U' shape, with the palm of your hand facing toward you. Start down a little below your neck and extend the hand up and outward, ending up above your head."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Tiger"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Start with both hands with fingers and thumb extended and spread them out as if they were tiger claws. Start with your hands in front of your face, then pull them apart. The sign looks like a tiger scratching across their face."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Zebra"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Take your strong hand and extend and separate your fingers. Starting with your hand on the opposite side of your body with palm facing you, form a claw shape, and drag the hand across your body."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Elepante"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Start with your open, slightly curved hand at your nose, then trace the path of your imaginary trunk down and away from your body."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Ahas"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Ang iyong nangingibabaw na kamay ay gumagawa ng parang pangil gamit ang iyong nakabaluktot na hintuturo at gitnang mga daliri. Ang senyales ay nagsisimula sa harap ng iyong mukha at dumudulas patungo sa iyong madla sa isang tabi-tabi na paggalaw."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Oso"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gawin ang iyong mga kamay sa kuko at mag-crossing ng iyong mga braso, may isang kamay sa bawat balikat. Ngayon, mag-scratch up at down gamit ang bawat kamay."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Panda"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gawin ang sign para sa oso, pagkatapos ay balutin ang parehong mata gamit ang aming pointer finger nang sabay-sabay, parang i-highlight ang bilog, itim na balahibo sa paligid ng mga mata ng panda."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
            Case "Buwaya"
                loadImage_words(cboanimals_fsl.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboanimals_fsl.SelectedItem.ToString
                lblword_desc.Text = "Gamitin ang parehong bukas na mga kamay at ichomp ang mga ito magkasama - pagbubukas at pagsasara tulad ng mga panga ng isang buwaya."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblcategory_words.Text = "MGA HAYOP"
        End Select
    End Sub
End Class