Imports System.Drawing.Drawing2D
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form5
    Dim conn As New MySqlConnection("Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95")
    Dim cmd As New MySqlCommand
    Dim query As String
    Dim reader As MySqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnalphabet.Click
        Panel1.Show()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(btnalphabet, 30)
        RoundButton(btnnumbers, 30)
        RoundButton(btnwords, 30)
        RoundButton(btnphrases, 30)
        RoundButton(Button5, 30)
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
        RoundButton(Button31, 30)
        RoundButton(Button32, 30)
        RoundButton(Button33, 30)
        RoundButton(Button34, 30)
        RoundButton(Button37, 30)
        RoundButton(Button38, 30)
        RoundButton(Button39, 30)
        RoundButton(Button40, 30)
        RoundButton(Button41, 30)
        RoundButton(Button42, 30)
        RoundButton(Button43, 30)
        RoundButton(Button44, 30)
        RoundButton(Button45, 30)
        RoundButton(Button46, 30)
        RoundButton(Button47, 30)
        RoundButton(Button48, 30)
        RoundButton(Button49, 30)
        RoundButton(Button50, 30)
        RoundButton(Button51, 30)
        RoundButton(Button52, 30)
        RoundButton(Button53, 30)
        RoundButton(Button54, 30)
        RoundButton(Button55, 30)
        RoundButton(Button56, 30)
        RoundPanel(Panel1, 30)
        RoundPanel(pnlnumbers, 30)
        RoundPanel(pnlwords, 30)
        RoundPanel(pnlword, 30)
        RoundPanel(pnlphrases, 30)
    End Sub

    Private Sub RoundButton(button As Button, cornerRadius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90)
        path.AddArc(button.Width - cornerRadius, 0, cornerRadius, cornerRadius, 270, 90)
        path.AddArc(button.Width - cornerRadius, button.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90)
        path.AddArc(0, button.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90)

        button.Region = New Region(path)
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
        Me.Hide()
        Form4.Show()

    End Sub





    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button56_Click(sender As Object, e As EventArgs) Handles Button56.Click
        pnldescription.Show()

        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "1"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If




        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnwords.Click
        pnlwords.Show()
        Panel1.Hide()
        pnlnumbers.Hide()
        pnldescription.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button32_Click(sender As Object, e As EventArgs) Handles Button32.Click
        pnlword.Show()
        cbowords.show
        cbothings.Hide()
        cbofood.Hide()
        cboplaces.Hide()
        cbofamily.Hide()
        pnlwords.Hide()
        Panel1.Hide()
        pnlnumbers.Hide()

        pnlphrases.Hide()

    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Hide()
        Favorites.LoadData()
        Favorites.Show()


    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnA.Click
        pnldescription.Show()

        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "A"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If

        ' Hide other panels
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub


    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "B"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "C"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "D"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "E"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "F"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "G"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "H"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "I"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "J"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "K"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "L"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "M"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "N"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "O"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "P"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnQ_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "Q"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "R"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "S"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "T"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "U"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "V"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "W"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "X"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "Y"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "ALPHABET"
        lbldesc.Text = "Z"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)
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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If
        Panel1.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Label14_Click_1(sender As Object, e As EventArgs)

        AddButtonToPanel(lbldesc.Text)
        SaveButtonTextToDatabase(lbldesc.Text)

    End Sub
    Private Sub SaveButtonTextToDatabase(buttonText As String)
        Try
            strcon.Open()

            ' Insert the button text into the 'ButtonData' table
            Dim query As String = "INSERT INTO favorites(favorite_desc) Values (@buttonText)"
            Dim command As New MySqlCommand(query, strcon)
            command.Parameters.AddWithValue("@buttonText", buttonText)
            If buttonText = lbldesc.Text Then
                MessageBox.Show("Added to favorites!", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Failed to add", "FAILED", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' Execute the query
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error saving button text to database: " & ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub


    Dim buttonCount As Integer = 0
    Public Sub AddButtonToPanel(text As String)
        ' Create a new button
        Dim newButton As New Button()
        text = lbldesc.Text
        newButton.Text = text
        newButton.Size = New Size(730, 91)
        newButton.Font = New Font("Abril Fatface", 20)
        newButton.BackColor = Color.FromArgb(0, 74, 173)
        newButton.ForeColor = Color.White

        ' Set the location of the new button
        Dim lastButton As Button = FindLastButtonInPanel()
        If lastButton IsNot Nothing Then
            ' If there are existing buttons, place the new button below the last one
            newButton.Top = lastButton.Bottom + 15 ' You can adjust the spacing
            newButton.Left = lastButton.Left + 2
        Else
            ' If it's the first button, place it at the top of the panel
            newButton.Left = 15
            newButton.Top = 10 ' You can adjust the initial position
        End If

        ' Add the new button to the panel
        Favorites.Panel1.Controls.Add(newButton)

        ' Increment the button count
        buttonCount += 1
    End Sub

    Private Function FindLastButtonInPanel() As Button
        ' Iterate through the controls in reverse order to find the last button
        For i As Integer = Favorites.Panel1.Controls.Count - 1 To 0 Step -1
            If TypeOf Favorites.Panel1.Controls(i) Is Button Then
                Return DirectCast(Favorites.Panel1.Controls(i), Button)
            End If
        Next

        ' No button found
        Return Nothing
    End Function
    Private Sub cmbphrases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbphrases.SelectedIndexChanged
        Select Case cmbphrases.SelectedItem.ToString()
            Case "Thank You"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Extend your fingers and thumb. Touch your fingers to your chin and bring your fingers forward. It is almost like you are blowing a kiss out, to thank the person - but the sign is a bit lower."
                'lbldescription.Font = New Font(lbldescription.Font.FontFamily, 13)
            Case "You're Welcome"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "It is signed the same way as Thank you. Take your flat, open, dominant hand, and starting from your chin, take your hand out as it arcs down and away from your face. It is as if you are acknowledging that your baby has thanked you, so you are mirroring the polite gesture back, like thanking them for thanking you!"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 12)
            Case "How much?"
                loadImage("HOW MUCH.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "First by starting with both your closed hands, four fingers touching the thumb on either side of your body, facing up. Then move your hands upward, with palms still facing up and fingers opening wide, and make a questioning face."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Goodbye"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Same as the traditional gesture for the word. Open your palm, folding down your fingers, then open your palm again."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 13)
            Case "Hello"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Make the sign by extending your fingers and cross your thumb in front of your palm. Now take the hand, starting with your hand in front of your ear, and extend it outward and away from your body."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Good Morning"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "You combine the signs for good and morning."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 16)
            Case "Good Night"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Combine the signs for good and night."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 16)
            Case "Excuse me"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "You set up the sign by taking your non-dominant hand palm facing the sky, then brush along your palm with the fingertips of the dominant hand. It is also the sign for pardon me or forgive me."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Please"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Take your dominant hand with fingers extended and held together, and thumb extended and sticking out. Take the hand with palm facing in and rub it in a circle on your chest."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Sorry"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Make your hand into a fist and rub it in a circular motion across your chest. It is like you are rubbing around your heart because you are truly sorry."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "I love you"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Put up your thumb, index finger and pinkie finger, while keeping your ring finger and your middle finger down. Hold the hand out, palm facing away from you and move it back and forth slightly."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "You look beautiful"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Start with your dominant hand open, thumb pointing at your chin and fingers pointing up. You complete the sign by rolling your fingers across the front of your face in clockwise fashion, ending with your fingers and thumb together around your chin area.
"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "What?"
                loadImage("WHAT.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Turn up your open hands, with fingers spread apart and hands slightly curved and relaxed. Move both hands back and forth simultaneously while furrowing your brow as you question, What?"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "When?"
                loadImage("WHEN.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Close both your hands in fists and sticking only your index fingers out. Your non-dominant index finger stands vertically and doesn't move, while your dominant index finger twists in a small circle above the non-dominant index, until it finally touches the tip of the index finger to rest. It is like you are zeroing in on a more precise date or time, until you finally reach it.
"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 11)
            Case "Where?"
                loadImage("WHERE.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Stick your dominant index finger out and wiggling it sideways. It's also important to furrow your brow - a facial cue that you are asking your baby a question - as you ask and sign, Where Is...?"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Why?"
                loadImage("WHY.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Take your dominant hand and make the ASL sign for the letter 'Y' at the side of your head. A variant of this sign is to wiggle your middle finger up and down with the rest of your fingers spread out, palm facing the side of your head. A third alternative is still to make the letter 'Y', but after pulling your hand a bit further down your dominant side.
"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 11)
            Case "Who?"
                loadImage("WHO.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Form the ASL letter 'L' with your dominant hand, touch your thumb to your chin, and wiggle the longer 'L' leg up and down as you furrow your brow and ask your baby, Who?"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "How?"
                loadImage("HOW.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Close both hands with thumbs extending out and upward. Have both hands meet by touching knuckles and move your dominant hand back and forth as if opening a lock, while keeping your non-dominant fist steady."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Don't know"
                loadImage("DON_T KNOW.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Shrug your shoulders. Alternatively, you can point to your forehead with your dominant hand with fingers together and move your hand away from you, while slightly shaking your head to show negation."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Don't want"
                loadImage("DON_T WANT.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Looks like you don't want something and are pushing it away.  Starting with your hands with palms upward and fingers curved, turn your hands over and push your hands away."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Help"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Place your closed-fist, dominant 'A' hand on top of your non-dominant open palm, and move both hands upwards."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "How are you?"
                loadImage("HOW ARE YOU.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Form curved hands shapes on both hands, palms down and/or slightly back and point towards the person, ASL gesture for You"
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "I'm fine"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Bring your flat right hand up to your chin. Then extend the hand outward. I'm fine."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "My name is..."
                loadImage("MY NAME IS.jpg")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Place your right hand over your heart. Extend the index and middle finger on both hands. Put right fingers on top of left ones. Then  Finger spell your name."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "What is your name?"
                loadImage("WHAT IS YOUR NAME.png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Put open right hand up in front of you, then bring forward.  And then extend the index and middle finger on both hands. Put right fingers on top of left ones. Tap twice. Then place both hands out in front of you, palms up. Shake them and use a questioning expression on your face."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 11)
            Case "Again"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Flatten out your leading hand, bend your second hand at a right angle, then tap it against the middle of the palm of your first hand."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Yes"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Looks a head nodding yes. You take your hand and make it into a fist, holding it at about shoulder height, then make your fist bob back and forth."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "No"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Looks like a mouth saying no. Take your index finger together with your middle finger and tap them together with your thumb."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Later"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Take your dominant hand and start with an 'L'-sign, with your index finger and thumb extend at right angles. Take your non-dominant hand and hold it up flat, facing your 'L' hand, with your 'L' hand's thumb sticking to the palm of your other hand. Hold your non-dominant, open flat hand steady as you pivot your 'L' hand 90 degrees, over and down."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 11)
            Case "Now"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".png")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Form both hands into the ASL letter Y sign, with your thumb and pinkie fingers extended and your three middle fingers curled in on each hand. Starting with your hands up, bring them down to your hip level."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Happy Birthday"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".jpg")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "This is a two-part sign. First start with the sign for happy by brushing a flat hand over your heart a couple of times. Next sign birthday by touching the middle finger of one hand first to your chin, then to your chest."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Congratulations"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".jpg")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Palm-down dominant hand is interlocked with palm-up non-dominant hand, moves down twice."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
            Case "Merry Christmas"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".jpg")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Plan a handshake, thumbs up on your chest twice with upwards movement then draw a ‘C’. You open your index finger curve it and hold it in front of your mouth and swipe it twice for merry. You can also sign language for the word ‘happy’. By showing your hands upwards and rubbing palms together in a way that sounds like a clap."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 11)
            Case "Happy New Year"
                loadImage(cmbphrases.SelectedItem.ToString.ToUpper & ".jpg")
                lbltitle.Text = cmbphrases.SelectedItem.ToString
                lbldescription.Text = "Pick up your hand and rub it upwards on your chest twice. Open both hands and take the left one upwards going parallel as a sign of ‘new’. For ‘year’ make a fist of your hands and tap the fist above another first."
                lbldescription.Font = New Font(lbldescription.Font.FontFamily, 14)
        End Select
    End Sub

    Private Sub btnphrases_Click(sender As Object, e As EventArgs) Handles btnphrases.Click
        pnlphrases.Show()
        pnlword.Hide()
        pnlwords.Hide()
        Panel1.Hide()
        pnlnumbers.Hide()
        pnldescription.Hide()

    End Sub

    Private Sub btnnumbers_Click(sender As Object, e As EventArgs) Handles btnnumbers.Click
        pnlnumbers.Show()

        pnldescription.Hide()
        Panel1.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub
    Private Sub btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click
        Dim username As String = Form1.historyuname

        If lblLetter.Text = "ALPHABET" Then
            IncrementProgressBarAlphabet(1)
            ' Transfer the updated progress value to MySQL Workbench
            TransferProgressToDatabase_alpha(username, progress.progressalphabet_asl.Value)

            ' Display the updated progress value
            MessageBox.Show($"Progress value updated: {progress.progressalphabet_asl.Value}")
        Else
            IncrementProgressBarNumbers(1)
            ' Transfer the updated progress value to MySQL Workbench
            TransferProgressToDatabase_numbers(username, progress.progressnumbers_asl.Value)

            ' Display the updated progress value
            MessageBox.Show($"Progress value updated: {progress.progressnumbers_asl.Value}")
        End If

        strcon.Open()
        Dim isFav As String

        If cbfavorites_alphabet.Checked Then
            isFav = "YES"
        Else
            isFav = "NO"
        End If

        Dim insertTableQuery As String = "INSERT INTO " & Form1.historyuname & " (Category, Word, Date, isFavorite) VALUES ('" & lblLetter.Text & "','" & lbldesc.Text & "', '" & Date.Now.ToString("yyyy-MM-dd") & "','" & isFav & "')"

        Dim command As New MySqlCommand(insertTableQuery, strcon)
        command.ExecuteNonQuery()
        strcon.Close()

    End Sub

    Private Sub IncrementProgressBarAlphabet(incrementValue As Integer)
        ' Ensure the progress value is within the valid range (0 to 100)
        Dim newValue As Integer = 0
        If lblLetter.Text = "ALPHABET" Then
            newValue = progress.progressalphabet_asl.Value + incrementValue
            If newValue > 27 Then newValue = 27
            If newValue < 0 Then newValue = 0
        End If


        ' Update the progress bar
        progress.progressalphabet_asl.Value = newValue
    End Sub
    Private Sub IncrementProgressBarNumbers(incrementValue As Integer)
        ' Ensure the progress value is within the valid range (0 to 100)
        Dim newValue As Integer = 0
        If lblLetter.Text = "NUMBERS" Then
            newValue = progress.progressnumbers_asl.Value + incrementValue
            If newValue > 20 Then newValue = 20
            If newValue < 0 Then newValue = 0
        End If


        ' Update the progress bar
        progress.progressnumbers_asl.Value = newValue
    End Sub

    Private Sub IncrementProgressBarWords(incrementValue As Integer)
        ' Ensure the progress value is within the valid range (0 to 100)
        Dim newValue As Integer = 0
        If lblword_title.Text = "ANIMALS" Or lblword_title.Text = "PLACES" Or lblword_title.Text = "THINGS" Or lblword_title.Text = "FAMILY MEMBER" Or lblword_title.Text = "FOODS" Then
            newValue = progress.progresswords_asl.Value + incrementValue
            If newValue > 150 Then newValue = 150
            If newValue < 0 Then newValue = 0
        End If


        ' Update the progress bar
        progress.progresswords_asl.Value = newValue
    End Sub

    Private Sub IncrementProgressBarPhrases(incrementValue As Integer)
        ' Ensure the progress value is within the valid range (0 to 100)
        Dim newValue As Integer = 0
        If lbltitle.Text = cmbphrases.SelectedItem.ToString() Then
            newValue = progress.progressphrases_asl.Value + incrementValue
            If newValue > 33 Then newValue = 33
            If newValue < 0 Then newValue = 0
        End If


        ' Update the progress bar
        progress.progressphrases_asl.Value = newValue
    End Sub


    Private Sub picture_Click(sender As Object, e As EventArgs) Handles picture.Click

    End Sub

    Private Sub Button55_Click(sender As Object, e As EventArgs) Handles Button55.Click
        pnldescription.Show()

        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "2"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button54_Click(sender As Object, e As EventArgs) Handles Button54.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "3"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button53_Click(sender As Object, e As EventArgs) Handles Button53.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "4"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button52_Click(sender As Object, e As EventArgs) Handles Button52.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "5"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If




        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button51_Click(sender As Object, e As EventArgs) Handles Button51.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "6"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button50_Click(sender As Object, e As EventArgs) Handles Button50.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "7"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button49_Click(sender As Object, e As EventArgs) Handles Button49.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "8"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button48_Click(sender As Object, e As EventArgs) Handles Button48.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "9"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

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
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button47_Click(sender As Object, e As EventArgs) Handles Button47.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "10"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "10.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button46_Click(sender As Object, e As EventArgs) Handles Button46.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "11"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "11.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If




        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button45_Click(sender As Object, e As EventArgs) Handles Button45.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "12"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "12.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button44_Click(sender As Object, e As EventArgs) Handles Button44.Click
        pnldescription.Show()

        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "13"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "13.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If




        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button43_Click(sender As Object, e As EventArgs) Handles Button43.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "14"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "14.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If




        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button42_Click(sender As Object, e As EventArgs) Handles Button42.Click
        pnldescription.Show()

        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "15"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "15.jpg"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If




        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button41_Click(sender As Object, e As EventArgs) Handles Button41.Click
        pnldescription.Show()

        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "16"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "16.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If




        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button40_Click(sender As Object, e As EventArgs) Handles Button40.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "17"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "17.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "18"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "18.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "19"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "19.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        pnldescription.Show()
        Dim fontsize As Single

        lblLetter.Text = "NUMBERS"
        lbldesc.Text = "20"

        fontsize = 28
        lblLetter.Font = New Font(lblLetter.Font.FontFamily, fontsize)

        fontsize = 110
        lbldesc.Font = New Font(lbldesc.Font.FontFamily, fontsize)

        ' Getting an image
        Dim connectionString As String = "Data Source = 127.0.0.1; database = signlingo; username = root; password = kimtaehyung95"
        Dim folderPath As String = "C:\Users\Pugz\Downloads\RESIZED-20231207T050054Z-001\RESIZED" ' Directly use the folder path

        ' Construct the full path to the image file
        Dim imageName As String = "20.png"
        Dim imagePath As String = Path.Combine(folderPath, imageName)

        ' Check if the file exists
        If File.Exists(imagePath) Then
            ' Load and display the image using the file path
            ' Example: PictureBox1.Image = Image.FromFile(imagePath)
            ' Replace PictureBox1 with the name of your PictureBox control
            picture.Image = Image.FromFile(imagePath)

            Console.WriteLine("Image found and loaded.")
        Else
            Console.WriteLine("Image not found.")
        End If



        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlword.Hide()
        pnlphrases.Hide()
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
            pbimage.Image = Image.FromFile(imagePath)
        Else
            Console.WriteLine("Image not found.")
        End If

    End Function
    Private Sub cbowords_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbowords.SelectedIndexChanged
        Select Case cbowords.SelectedItem.ToString()
            Case "Cat"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Pinch your index finger and thumb together in the ASL sign for F, leaving the rest of your fingers spread apart. Touch the center of your cheek with you pinched fingers and stroke toward your ear a few times. (Pretend you’re stroking whiskers on a cat.)"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "ANIMALS"
            Case "Dog"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Tap your leg with an open hand and, after the tap, lift your hand and snap one time."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Fish"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Extend your hand as if you’re about to shake hands, and then wiggle your hand from side to side while moving it forward. (Pretend your wiggling hand is a fish swimming in water.)"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Bird"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make a fist and extend your index finger and thumb, place the back of your hand to your chin, then open and close your index finger and thumb. (Yep, your fingers are representing the beak of a bird.)"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Horse"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make a fist and then extend your first two fingers and thumb, fingertips pointing up, and then place your thumb on your head above your ear and bend your fingers forward a couple of times."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Pig"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make the ASL sign for B (holding all four fingers of one hand straight up, touching, while laying your thumb against your palm), place the top of your letter B hand under your chin, and bend your fingers down once or twice."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Duck"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make a fist your hand and extend your index finger, middle finger, and thumb, then place the back of your hand to your chin, and open and close your fingers and thumb.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Frog"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Place a fist under your chin, and then move your first two fingers out and in several times, with your thumb catching the fingers on the in movement."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Cow"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make your hand into a fist then straighten your pinkie finger and straighten your thumb. The two extended fingers on your hand should like the horns of a cow. Take your thumb and put it by the side of your head and twist your hand around.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Chicken"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Start with the bird sign. Take your thumb and index finger and make an open beak, while making the rest of your hand into a fist. Close the beak and bring it down to peck at the ground as represented by your other outstretched hand, palm facing up.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "ANIMALS"
            Case "Goat"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make a slightly bent or curved 'V' with your dominant hand, then tap your chin with the two fingers, followed by tapping your forehead with the same curved - or now straightened - 'V' hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Rabbit"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make both hands into fists and place them on top of your head, with middle and index fingers extended to make the rabbit ears. Bend and extend the middle and index fingers to the back of your head, as if to make the ears twitch."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Mouse"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Use your dominant index finger to flick back and forth across the tip of your nose. You can remember that this sign is like you are moving your mouse nose back and forth."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Lion"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make your hand into a claw shape with your fingers curved and apart. Take your hand, and with the palm down, run it from above the front of your forehead down toward the back of your head."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Monkey"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Take your arms out and scratch at your armpits with your hands."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 16)
                lblword_title.Text = "ANIMALS"
            Case "Giraffe"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make your dominant hand a 'U' shape, with the palm of your hand facing toward you. Start down a little below your neck and extend the hand up and outward, ending up above your head."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Tiger"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Start with both hands with fingers and thumb extended and spread them out as if they were tiger claws. Start with your hands in front of your face, then pull them apart. The sign looks like a tiger scratching across their face.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Zebra"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Take your strong hand and extend and separate your fingers. Starting with your hand on the opposite side of your body with palm facing you, form a claw shape, and drag the hand across your body."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Elephant"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Start with you open, slightly curved hand at your nose, then trace the path of your imaginary trunk down and away from your body.

"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Snake"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Your dominant hand makes a fang-like figure with your bent index and middle fingers. The sign starts in front of your face and slithers toward your audience with a side-by-side move.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Bear"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make your hands into claws and crossing your arms, with one hand on each shoulder. Now scratch up and down with each hand."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Panda"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Make the sign for bear, then we encircle both eyes with our pointer fingers simultaneously, as if to highlight the round, black fur around a panda's eyes.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
            Case "Alligator"
                loadImage_words(cbowords.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbowords.SelectedItem.ToString
                lblword_desc.Text = "Taking both open hands and chomping them together - opening and closing like the jaws of an alligator. 
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "ANIMALS"
        End Select





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

    Private Sub Button34_Click(sender As Object, e As EventArgs) Handles Button34.Click
        pnlword.Show()
        cboplaces.Show()
        cbofamily.Hide()
        cbofood.Hide()
        cbothings.Hide()
        cbowords.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub cboplaces_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboplaces.SelectedIndexChanged
        Select Case cboplaces.SelectedItem.ToString()
            Case "Playground"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "First sign play, making your hands into fists with thumbs and pinkies extended. Then twist your hands back and forth. Then sign area, taking your dominant hand flat and palm down, making horizontal circles in the air."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblword_title.Text = "PLACES"
            Case "Toilet"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Make a letter 'T' with our dominant hand, and we shake it back and forth in front of us.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "PLACES"
            Case "Bedroom"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "You start by signing bed, bringing your two hands together with palms touching, and placing them by the side of your head as if they were a pillow. Then you sign box or room, by taking your two open hands palms facing each other and a few inches apart, and outlining the four sides of a room."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Kitchen"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Make a letter k with your dominant hand and flip it back and forth over your flat, open, non-dominant hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "PLACES"
            Case "Dining Room"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "First make the sign for eat by bringing your dominant hand to your mouth with all fingers together, and complete the sign using the sign for room, which is made by making a square with both hands directly in front of you."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "House"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Outlining the shape of a simple house. Extend your two hands, then starting at the roof, outline the slanting roof line - then the vertical walls. (We don't usually outline the ground.)
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Garage"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "With your non-dominant hand acting as the garage, palm open and facing the ground, at chest height. Then make your dominant hand the car, with your thumb, index and middle fingers extended out of a fist and then moving back and forth under the non-dominant hand."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Room"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Make a square with both hands directly in front of you. First, hold your flat hands parallel in front of your body, about a foot apart while both palms are facing inward. Then move both hands so that they end up still parallel but with the palms facing each other.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Basement"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Taking your non-dominant hand and laying it flat and horizontal in front of your body, as if making a floor with your hand. Make your dominant hand into a fist with your thumb extended upward, and move your hand in small, horizontal circles under your non-dominant hand."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "PLACES"
            Case "Office"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Form the ASL letter 'O' sign with both hands, then position your forearms parallel in front of your body and then perpendicular to your body, as if forming the sign for box or room, but with your hands forming the letter 'O'."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "PLACES"
            Case "Yard"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Hold your open hand under your chin, with palm facing up and fingers spread out and curved. To sign area, take your dominant hand, with fingers spread out and palm facing down, then make a counter-clockwise circle in front of your body.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Garden"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Your non-dominant arm will form the ground, the forearm lying flat with your fingers curled as if holding a small pot, and it will come up through the non-dominant hand, opening up your fingers as the plant passes the top of your non-dominant fist. Repeat the same sign for plant or grow, but 2-3 times more.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Mall"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Simply finger-spell the ASL letters M - A - L - L."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 16)
                lblword_title.Text = "PLACES"
            Case "Restaurant"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Form the ASL letter R sign with your dominant hand. Then use your 'R' hand to simulate wiping down the far side of the corner of your mouth while not touching your face, then repeating this on the nearer corner of your mouth. "
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Hospital"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Your dominant hand will form the ASL 'H' sign, then you'll make the sign of a cross on your opposite arm, starting vertically, up down, then horizontally, left to right, as if rubbing the opposite upper arm after just having received a shot. 
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "School"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Clapping your flat, open hands together, with the top hand's fingers perpendicularly angled to the bottom's. Lay your non-dominant hand open, palm facing up, then bring down your dominant hand to clap the two together. "
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Church"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Form your non-dominant hand into a fist, and your dominant hand into the ASL letter C sign. Then bounce your 'C' hand off your steady fist a couple of times.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "PLACES"
            Case "Store"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Taking both your hands and touching your fingers to your thumbs on either side of your body. Then, holding your hands just above shoulder level, shake your hands back and fourth - twisting at the wrist.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "PLACES"
            Case "Supermarket"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "First sign eat by placing our dominant hand in front of our mouth and quickly pulling away. The next motion consists of the sign for shop or store. Both hands parallel to your neck with fingers together moving back and forth."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Library"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Make the ASL sign for the letter 'L' with your dominant hand, and move it in a circular motion around shoulder height."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "PLACES"
            Case "Bank"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Finger-spelling B-A-N-K fast, as you hold your dominant hand out in front of you, palm facing outward, as you slide your hand down a small distance and progress from 'B' all the way down to 'K'. For your toddler, the sign is too fast, so they will probably only catch the first 'B' and the last 'K'
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Airport"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Take your outstretched hand, and tuck in your middle and ring fingers. Then move your hand away from your body a short distance, as if flying, and bob it back and forth a couple of times. If you move your hand a bit further up and out, slightly above your head, that's already the sign for fly.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "City"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Take both slightly curved flat hands, then have them touch at the fingertips while facing opposite directions. Switch both hands' positions while twisting them back and forth, releasing and touching the fingertips a couple of times. This is the same sign for village, community, and town.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Beach"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Taking two open hands with fingers facing forward and palms pointing down toward the ground. Then, make wave-like motions with your hands while advancing them forward. The sign should look like waves rolling across the ocean."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
            Case "Farm"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Take your open dominant hand, and start with your thumb touching your non-dominant side. Then trace the jaw all the way around to your dominant side."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "PLACES"
            Case "Zoo"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Outlining the word Z - O - O. First, you outline a 'Z' in the air with your index finger. Then you make an 'O' shape with your index finger and thumb, and move the hand sideways across your body.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "PLACES"
            Case "Museum"
                loadImage_words(cboplaces.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cboplaces.SelectedItem.ToString
                lblword_desc.Text = "Compound sign in the sense that you make the basic ASL sign for house, but you do it with both hands in the shape of the ASL letter M. The letter M is signed by holding up your dominant hand, palm facing out, with all your fingers curled into your palm. Then tuck your thumb between your ring and pinkie fingers. "
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "PLACES"
        End Select

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        pnlword.Show()
        cbofamily.Show()
        cbothings.Hide()
        cboplaces.Hide()
        cbowords.Hide()
        cbofood.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub cbofamily_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofamily.SelectedIndexChanged
        Select Case cbofamily.SelectedItem.ToString()
            Case "Mom/Mother"
                loadImage_words("MOTHER.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Extend and spread your fingers apart on your dominant hand. With your pinkie facing forward, tap your thumb on your chin.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Dad/Father"
                loadImage_words("FATHER.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Make the number '5' in ASL, extending and spreading out the five fingers on your dominant hand. Then tap the thumb end of your '5' hand on your forehead."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Brother"
                loadImage_words("BROTHER.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Make both hands into an 'L' shape with your thumbs and index fingers extended. Hold your non-dominant 'L' hand down by your chest. Take your dominant hand and starting at the forehead, forming the tip of a baseball hat, bring the hand down to rest on your non-dominant hand, transforming it into an 'L'.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Sister"
                loadImage_words("SISTER.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Extend your thumb and index fingers on both hands, like forming horizontal 'L' signs in ASL. Take your dominant hand, and starting with your thumb under your jaw, move and tap it down on top of your non-dominant hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 13)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Baby"
                loadImage_words("BABY.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Cross your arms with hands facing up, one arm resting on the other while touching one elbow with the fingers from the opposite hand, as if you are cradling a baby in your arms. Then gently move your hands from side to side, as if rocking the imaginary baby in your arms.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Grandfather"
                loadImage_words("GRANDFATHER.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "take your hand with fingers outstretched. Start with your thumb on your forehead and move your hand forward in one arc, then a second arc. It is as if your hand follows one small rainbow, then a second small rainbow."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Grandmother"
                loadImage_words("GRANDMOTHER.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Extend your thumb and index fingers on both hands, like forming horizontal 'L' signs in ASL. Take your dominant hand, and starting with your thumb under your jaw, move and tap it down on top of your non-dominant hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Cousin"
                loadImage_words("COUSIN.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Made by making your hand into a C-shape. Place the C-hand by the side of your head and twist it back and forth.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Aunt"
                loadImage_words("AUNT.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Make a fist with your thumb sticking out near your face, at top of the fist. Leading with the thumb, move your hand in a small circle near your cheek (but not touching it).
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Uncle"
                loadImage_words("UNCLE.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Extend your index finger and middle finger to make the ASL sign for 'U'. Take the hand and move it in small circles to the side of your body at the level of your forehead."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Nephew"
                loadImage_words("NEPHEW.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Use your dominant hand and form the ASL letter N sign with your thumb tucked under your index and middle fingers while pointing to your head and  twisting your hand twice. Do it at or above the level of your eyes.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Niece"
                loadImage_words("NIECE.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Form the ASL letter N sign with your dominant hand by the side of your face, and twist it back and forth."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Children"
                loadImage_words("CHILDREN.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Take your dominant hand with palm facing down and bobbing your hand up and down in front of your body. The sign looks like you are patting a child on the head.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Kid"
                loadImage_words("KID.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "Close your dominant hand into a fist, with only the index and pinkie fingers sticking out. Then hold the index side of your hand up to your nose, while pivoting the rest of your hand at the wrist a couple of times.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Family"
                loadImage_words("FAMILY.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "First make the ASL sign for 'F' with both hands, then forming a circle with both hands horizontally, starting near your torso and ending away from your body. Start with the two 'F' hands touching at the index fingers and thumbs, then circle the two hands around horizontally, ending with the pinkie fingers touching, as if you were encircling a group of people in front of you."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Daughter"
                loadImage_words("DAUGHTER.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "First, point to your chin with your dominant index finger, then proceed to make the sign for baby: cradle your imaginary baby in your bent arms, non-dominant arm below, and dominant arm above.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
            Case "Son"
                loadImage_words("SON.png")
                lblanimal.Text = cbofamily.SelectedItem.ToString
                lblword_desc.Text = "First, sign male, then sign baby or infant. To do the male marker sign, use your dominant index finger to touch your forehead, then bring your hand down as you transform it from a pointing hand to an open flat hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FAMILY MEMBER"
        End Select
    End Sub

    Private Sub cbofood_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbofood.SelectedIndexChanged
        Select Case cbofood.SelectedItem.ToString()
            Case "Fruit"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Touch the tips of the index finger and thumb of an F-hand to your cheek. Twist the F-hand on your cheek twice. Maintain contact for the whole sign. (The hand doesn't leave your cheek, nor does it move forward on the cheek.)
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "FOODS"
            Case "Apple"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Form an ASL letter A with one hand by making a fist and placing your thumb against your index finger, then place your thumb on your cheek and twist your hand forward."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Orange"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Place your dominant hand near your chin, and repeatedly squeeze your hand into a fist and relax. It is like you are squeezing an orange."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Banana"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Raise one index finger, with the tip pointing to the sky. Then, with your opposite hand, make the movements of peeling a banana, starting at your fingertip and moving down and out."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Pineapple"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Take your dominant hand and forming the letter 'F' in ASL: hold your index finger and thumb together while the rest of your fingers are splayed out. Then hold the circular space between the two fingers to your dominant eye and pivot it around the eye a couple times, as if to suggest one of the many eyes on a pineapple, while the splayed fingers suggest the spiny leaves sticking out at the top of this tropical fruit."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 10)
                lblword_title.Text = "FOODS"
            Case "Avocado"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Form the ASL letter A sign with your dominant hand. Then curve your non-dominant hand into a tiny bowl or cup and mimic scooping the 'avocado' off it with your dominant 'A' fist.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Melon"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Make a fist with your non-dominant hand and tap it twice using the middle finger and thumb of your dominant hand."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Strawberry"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Point the index finger of your non-dominant hand sideways in front of your body, and move all the fingers of your dominant hand around the tip of the opposite index finger, as if showing a round fruit.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "FOODS"
            Case "Grapes"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "With your hand in a shape of claw, tap your fingers down your other hand, showing clumps of grapes.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Corn"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Pretend you’re holding a cob of corn in your hands then move your hands to your mouth, and turn your hands like you’re turning a corn cob while you eat it."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Carrots"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Make an ASL letter S by forming a fist with your thumb wrapped around the outside of your fingers. Move your fist all the way to your mouth as if you’re eating up a carrot."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Peas"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Extend both index fingers and, with the tip of one index finger, touch the side of the other index finger several times, moving from knuckle to fingertip."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Lettuce"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".jpg")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Touch the heel of your palm to your head a couple of times. With this motion, your hand is representing leaves of lettuce."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Breakfast"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Eat (Food) is signed by taking your dominant hand with thumb touching your four fingers, then bringing the hand to the mouth repeatedly. The sign for morning looks like the sun rising over the horizon.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Soup"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Create a bowl with our non-dominant hand and making a spoon with the index and middle fingers of our dominant hand. We spoon the soup all the way to our mouth.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Cereal"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Take you dominant hand in a fist with your index finger extending and then retracting as you move your hand along across your mouth's horizon."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Egg"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Take your index finger and your middle finger from each hand, holding them together. Hold the opposite fingers together pointing upwards, then pull them down and apart.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Rice"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Form your dominant hand into the ASL letter R sign. Then we create a bowl with our non-dominant hand, while making a spoon with the 'R' formed by the dominant hand. We spoon the rice all the way to our mouth.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Bacon"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Start by forming fists with both hands, extending the middle and index fingers, touching them together. Next, separate the hands while waving them up and down in small undulating motions.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Dessert"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Take your dominant hand and brush your chin with your fingers, going back and forth."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Cake"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Bring one hand chest height, keeping flat and palm up. With your other hand in the C position, touch fingertips to the open palm, and slide from bottom of the palm to the tips of the fingers.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Chocolate"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Make your dominant hand into a C-shape. Take your non-dominant hand and lay it flat with palm down in front of your body. Then move the C-shape in a circle, with the side of your thumb circling on top of the palm of your non-dominant hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "FOODS"
            Case "Ice Cream"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Form your dominant hand into a fist and starting a short distance above your mouth, move it down a little to below your chin, as if you were holding a cone and giving it a good lick."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Snacks"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Place your non-dominant hand as the plate in front of you, palm up. Use your dominant hand's index finger and thumb to pick snacks off the plate and bring them to your mouth, simulating eating."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Popcorn"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Take both hands, palms facing up and fingers closed, then make each hand's index fingers and thumbs touch and then open, as the hands move up and down, simulating the corn kernels popping in the pan.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Sandwich"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Bend both your hands, thumbs sticking out and palms facing you, while one hand is cupping the other. Move your hands toward your mouth, as if you are about to bit into a sandwich."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Hamburger"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Cup both hands and press your palms against each other while interchanging the top and bottom positions of each cupped hand, as if making a hamburger patty.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Bread"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Non-dominant hand open and palm facing your body to make the imaginary loaf of bread. Your dominant hand makes a series of vertical cutting motions in front of the bread, as if it were a knife."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "FOODS"
            Case "Cookie"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Non-dominant hand and lay it out flat with palm facing up in front of your body. Bend your fingers on your dominant hand into an open circle, then place your fingertips on your non-dominant hand and twist them back and forth, as if indicating the shape of your imaginary cookie.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "FOODS"
            Case "Cheese"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Hold your two hands flat with palms touching each other. Rub the hands together. I remember the sign because it looks like you are rolling a ball of mozzarella cheese.

"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Pizza"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Take your dominant hand, curving it into a modified, flat 'O' hand or an open palm with curved fingers, and move it towards your mouth, as if you are feeding yourself a slice of pizza."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "French Fries"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Take your thumb and index finger on your dominant hand and touch them together, forming the letter 'F' in ASL. Then pivoting from your wrist, move your 'F' hand in succeeding dips or nods, first to the left and then the right.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "FOODS"
            Case "Hotdog"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Place your hands in front of you and make a repetitive grasping motion while moving both arms away from each other."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "FOODS"
            Case "Meat"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Pinch the fleshy part between your index and thumb on your non-dominant hand with the index and thumb of your dominant hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
            Case "Peanut butter"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Place the thumb of your dominant hand in front of your mouth and pull it out and down (which is actually the sign for peanut). Follow this motion with the sign for butter, which is a spreading motion over your non-dominant hand using your middle and index fingers.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
            Case "Toast"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Hold up our non-dominant hand straight with fingers pointing up, and we tap it with our dominant hand on both sides using only the index and middle fingers. The sign looks like you are touching both sides of a slice of toast with a fork."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
            Case "Jam"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Make you dominant hand in a fist and stick out your pinkie. This is the ASL symbol for the letter 'J'. Turn your fist to the side and use your pinkie to scoop up the jam/ jelly out of your other hand. Have this hand palm up to act as the bowl.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
            Case "Juice"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Extend your pinkie while curling up your three middle fingers. Then lay your thumb down across the fingernails of the three middle fingers. Now take the hand and start the juice sign by pointing your pinkie at your chin with your palm forward. Then rotate your hand so that your palm is now facing forward.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
            Case "Pasta"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Make both hands into a fist then sticking only the pinkie fingers out. Hold your two hands close to each other in front of your body, then draw them apart as you make small, circling motions with both pinkie fingers, as if you are twirling the pasta noodles as you stretch them apart."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
            Case "Drink"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Make your hand into a 'C' shape, as if holding a cup in your hand. Take your hand up to your mouth as if drinking from the cup."
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
            Case "Water"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Take your dominant hand and extend and separate the three middle fingers while holding the thumb and pinkie finger together. Then tap your index finger on your chin a couple of times.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
            Case "Milk"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "take your dominant hand, make it into a fist, relax, and repeat.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
            Case "Soda"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Form the left hand into O.  Bend the middle finger of the right spread hand at the large knuckle and stick it (the middle finger) into the left O.  Then remove the finger and slap your right palm over the hole.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
            Case "Candy"
                loadImage_words(cbofood.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbofood.SelectedItem.ToString
                lblword_desc.Text = "Taking your index finger and touching it just under the mouth area on one side of your chin. Twist the finger back-and-forth. 
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
        End Select
    End Sub

    Private Sub Button33_Click(sender As Object, e As EventArgs) Handles Button33.Click
        pnlword.Show()
        cbofood.Show()
        cbofamily.Hide()
        cboplaces.Hide()
        cbowords.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        pnlword.Show()
        cbothings.Show()
        cbofood.Hide()
        cbofamily.Hide()
        cboplaces.Hide()
        cbowords.Hide()
        pnlnumbers.Hide()
        pnlwords.Hide()
        pnlphrases.Hide()
    End Sub

    Private Sub cbothings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbothings.SelectedIndexChanged
        Select Case cbothings.SelectedItem.ToString()
            Case "Object"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Form both hands as curved hands with thumbs sticking out, while the rest of the fingers are held together. Then held side by side in front of your body with both hands' fingertips facing each other, move the curved hands apart, gently bouncing sideways as they move further away from each other a couple of times.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Toy"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Form both hands into fists and tuck your thumbs up between your index and middle fingers. Pivot both hands back and forth to make the sign.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Clothes"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take both open number 5 hands and touch your thumbs to your shoulders as you brush your hands down the chest a couple times.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Shoes"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Make your two hands into fists and tap the two together laterally. Imagine your fists are shoes and you are clicking the shoes together.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Socks"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Both index fingers point downwards with palms facing down. Rub both fingers together back and forth.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Toothbrush"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Looks like you are brushing your teeth with your finger. To sign toothbrush, extend your index finger and rub it back and forth in front of your teeth.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Toothpaste"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Use your  index on the non-dominant hand and then mimicking the motion of squirting toothpaste with your dominant hand on your brush.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Shampoo"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Dominant hand mimics holding a bottle of shampoo and squirting some into our non-dominant hand. We then proceed to lather our head with both hands.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Soap"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take your non-dominant hand and holding it flat in front of you, with palm facing up. Then, hold your bent dominant hand above your palm and flick your fingers down a couple of times so they touch the palm of your non-dominant hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "THINGS"

            Case "Towel"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Closing both fists, raising our hands to almost shoulder-height, and moving our arms back and forth, as if we were drying our back with a towel.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Computer"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Making your strong hand into a C-shape. Extend your non-dominant arm, palm facing down, while stroking your C-shaped hand along your arm.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Phone"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take your dominant 'Y' hand (the letter 'Y' in ASL), with the rest of the fingers drawn into a fist while the thumb and pinkie finger are sticking out, and hold this hand up to the side of your face, nearly touching your mouth and ear.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Laptop"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Looks like you are opening up a laptop computer. Starting with your two hands together, with you dominant hand on top. Then move your dominant hand upward and away from your body as if flipping open the laptop screen.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Television"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Utilize the ASL alphabet and spell T and V together..
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Refrigirator"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "First sign cold, then make the form of a tall rectangle with your open, flat hands. Starting from the top of your head, make your flat hands go out sideways, then down on either side.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Car"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Place your hands around an imaginary steering wheel. Then turn the wheel from side-to-side as if you were driving.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Bicycle"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Looks like you are pedaling a bicycle with your feet. Make both hands into fists, then make vertical circles in the air in front of your body.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Train"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take both hands, extending the middle and index fingers. Take your dominant hand and rub the fingers slowly down the same fingers on the non-dominant hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Boat"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Cup your hands together in a boat shape. Then move your hands up and down while extending them forward. It looks like a little boat bobbing along in some gentle waves.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Airplane"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Cup your hands together in a boat shape. Then move your hands up and down while extending them forward. It looks like a little boat bobbing along in some gentle waves.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Helicopter"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Make a horizontal number 3 sign with your non-dominant hand, with palm facing your body, and thumb sticking up. Then cover it with your open, dominant hand creating a movement that mimics blades.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Pot"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take your two curved, open hands, starting with your forearms held parallel at waist level, then move both curved hands up simultaneously, as if tracing the curved sides of a deep pot upward.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Bowl"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Start with both curved hands side by side in front of you, palms facing up. Then separate your hands in unison as they mimic outlining the shape and size of a bowl for eating.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Hairbrush"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Close the fist of your dominant hand with thumb pointing up and make the motion of brushing your hair.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Mirror"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Place your dominant hand in front of you with all fingers together and pointing upward. Move the hand in a twisting motion as if you are checking your reflection.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Camera"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Bend your thumb and index finger on both hands to make the four corners of the camera. Then click the camera by extending and bending the index finger on your dominant hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Paper"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Lay out your non-dominant hand, palm facing up, to act as the base or main book. Then take your flat, dominant hand and mimic pressing some paper by pushing it sideways and in the opposite direction against the 'book'.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Book"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Put your hands together, palm-to-palm. Then keeping your pinkies together, open up your hands as if opening up a book.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Bag"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take your dominant hand in a fist, with the palm facing down in front of your body. Repeatedly bounce the hand up and down in a small motion. The sign closely resembles a hand holding a shopping bag and bobbing it up and down.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "THINGS"

            Case "Money"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Hold your non-dominant hand out as if begging for alms. Then take your dominant hand with your thumb touching your fingers, forming a bent 'O' hand, and tap it against the fingers of your weak hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Eye glasses"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Simply curve your index fingers and thumbs around either eye at the same time, forming the shape of the lenses of the glasses.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Pen"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Hold out your non-dominant hand flat, with your palm facing up, then proceed to pretend writing on it with your dominant hand formed as if grasping a pen and writing.Run your dominant hand once across the other palm, from the base to past your fingertips.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Pencil"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Hold up your non-dominant hand, with the palm facing up. Then take your dominant hand with your index finger bent and touching your thumb to your mouth. Finally, bring your hand down as if to write something in the palm of your non-dominant hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Umbrella"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Start with two fists stacked on top of each other with your dominant hand on top. Raise the top fist. The sign looks like you are opening an umbrella.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Bottle"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Your weak hand should be open, with palm facing up to form the base. With your dominant hand, start down at the base with an open grip or 'C' hand, then move your hand up an imaginary bottle, closing your grip as you go up.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Cup"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take your dominant hand and wrap your fingers round into a 'C' shape, as if you are holding a cup. Take your non-dominant hand and lay it flat, palm facing up, as if it is a table top. Take the dominant hand and place it down on the flat hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Fork"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take your non-dominant hand with your palm facing up to form the plate. Then make a fork with the index and middle fingers on your dominant hand and place it on the plate, touching the plate a couple times with your fingers acting as the tines of the fork.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Spoon"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Make a bowl by cupping your non-dominant hand and a spoon with the index and middle fingers of your dominant hand. Spoon invisible contents up a short distance from the bowl, without bringing your hand to the mouth.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Plate"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take both your hands and form fists, only sticking out your index fingers and thumbs. Then with both hands, mimic the outline of a plate in front of your body.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Napkin"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Simply make the motion of wiping on both sides of your mouth with your dominant, modified letter O hand, starting from one corner of your mouth to the other.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Knife"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Make a knife with the index and middle finger of your dominant hand, and a surface with the same fingers of your non-dominant. Finish the sign by making a back-and-forth cutting movement.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "THINGS"

            Case "Scissors"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Use the index and middle fingers of your dominant hand and move them in a scissor-cutting motion.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Crayon"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "First, sign color, then sign pen. To sign color, take your fingers to your chin and wiggle them in place. To sign pen, simply mimic writing something with a pen on a flat surface. Hold out your non-dominant hand flat, palm facing up, then pretend writing on it with your dominant hand formed as if grasping a pen.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "THINGS"

            Case "Ruler"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Form the ASL letter Y sign with both hands in front of you, their thumbs touching intermittently as you move your hands together and pull them apart a few times, indicating the length or breadth of something.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Glue"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Make your dominant hand into a fist with your thumb out and your non-dominant hand into a flat surface facing up. Make circles on your non-dominant palm with the thumb tip of your dominant hand, as if you are applying glue to paper.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Chair"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "With each hand, take your middle finger and index finger and hold them together. Take the two fingers of your dominant hand and tap them flat on top of the two fingers on your non-dominant hand.

"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Sofa"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Made by pointing the index and middle fingers of your non-dominant hand sideways and placing the same fingers of your dominant hand on top of the former, as if your non-dominant hand is a chair. Complete the sign by pulling your dominant hand away from the other hand, indicating a Long chair.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "THINGS"

            Case "Bed"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Put your two hands together, palm-to-palm. Then place your hands at an angle by the side of your head, and rest your cheek on your hands as if they were a pillow or just rest your cheek on the open palm of your dominant hand.

"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Blanket"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take both hands with your fingers extended and thumbs tucked under. Start with your palms facing your body and down low, then pull your hands up to chest level.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Pillow"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Lean your head slightly towards the direction of your dominant hand, as if you are laying your head down to sleep. Then take your two open palms, facing each other but some distance apart, as if there is an invisible pillow in between both your hands.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "THINGS"

            Case "Lamp"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Simply make the sign using the dominant hand and forearm, excluding the non-dominant hand and forearm, which serves as the table top.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Flashlight"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Your non-dominant hand is the 'holding' arm: you touch your index finger to your thumb to make a circle, then touch it against the wrist of your dominant hand. Your dominant hand starts as a closed fist then quickly opens with all fingers spread out, to signify the beam of light.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "THINGS"

            Case "Table"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Hold both your hands and forearms horizontally in front of your body, the dominant forearm above the non-dominant, and tap them together. The sign is like indicating the surface of a table.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Furniture"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Form your dominant hand into the ASL F, then shake it from side to side.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Drawer"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Start with your two hands in front of your body with closed fists, then pull your closed hands back toward your body. Natural sign and looks like you are opening a drawer.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Necklace"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Simply trace a necklace around your neck with both index fingers starting at the center of your upper torso, then simultaneously moving up and around your neck.

"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Earning"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Holding and releasing your ear between your index and your thumb. The sign looks like you are touching and releasing an imaginary earring on your ear.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Ring"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Take your dominant hand in the form of the ASL letter 'F', then imagine you are holding a ring with your pointer finger and thumb. Slide that invisible ring onto the ring finger of your opposite hand.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Bracelet"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Make your dominant hand simply clasping the wrist of your non-dominant hand. Make a modified ASL letter C hand, where only your index finger and thumb are bent to form a letter 'C', then clasp your opposite wrist.

"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Watch"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Rest your dominant hand on top of the wrist of your non-dominant hand, as if indicating the watch that you are wearing. First, form the letter 'F' and hold down its circular part to the top of your wrist, indicating the face of the watch.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 12)
                lblword_title.Text = "THINGS"

            Case "Gift"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Make both hands into a fist with your index finger extended and curled. Starting with both hands close to your body, move them away from your body, in a gesture of giving.
"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 14)
                lblword_title.Text = "THINGS"

            Case "Wallet"
                loadImage_words(cbothings.SelectedItem.ToString.ToUpper & ".png")
                lblanimal.Text = cbothings.SelectedItem.ToString
                lblword_desc.Text = "Hands flat and facing toward your body, have all fingertips meet in the middle, steepling your fingers but horizontally so that they face outward, not upward. Then open and close both hands a couple of times, as if opening and closing a wallet or billfold.


"
                lblword_desc.Font = New Font(lblword_desc.Font.FontFamily, 11)
                lblword_title.Text = "THINGS"


        End Select
    End Sub

    Private Sub btndone_words_Click(sender As Object, e As EventArgs) Handles btndone_words.Click
        Dim username As String = Form1.historyuname

        If lblword_title.Text = "ANIMALS" Or lblword_title.Text = "PLACES" Or lblword_title.Text = "THINGS" Or lblword_title.Text = "FAMILY MEMBER" Or lblword_title.Text = "FOODS" Then
            IncrementProgressBarWords(1)
            ' Transfer the updated progress value to MySQL Workbench
            TransferProgressToDatabase_words(username, progress.progresswords_asl.Value)

            ' Display the updated progress value
            MessageBox.Show($"Progress value updated: {progress.progresswords_asl.Value}")

        End If

        strcon.Open()
        Dim isFav As String

        If cbfavorites_words.Checked Then
            isFav = "YES"
        Else
            isFav = "NO"
        End If

        Dim insertTableQuery As String = "INSERT INTO " & Form1.historyuname & " (Category, Word, Date, isFavorite) VALUES ('" & lblword_title.Text & "','" & lblanimal.Text & "', '" & Date.Now.ToString("yyyy-MM-dd") & "','" & isFav & "')"

        Dim command As New MySqlCommand(insertTableQuery, strcon)
        command.ExecuteNonQuery()

        strcon.Close()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = Form1.historyuname
        If lbltitle.Text = cmbphrases.SelectedItem.ToString() Then
            IncrementProgressBarPhrases(1)
            ' Transfer the updated progress value to MySQL Workbench
            TransferProgressToDatabase_phrases(username, progress.progressphrases_asl.Value)

            ' Display the updated progress value
            MessageBox.Show($"Progress value updated: {progress.progressphrases_asl.Value}")
        End If

        strcon.Open()
        Dim isFav As String

        If cbfavorites_phrases.Checked Then
            isFav = "YES"
        Else
            isFav = "NO"
        End If

        Dim insertTableQuery As String = "INSERT INTO " & Form1.historyuname & " (Category, Word, Date, isFavorite) VALUES ('" & lblcategory.Text & "','" & lbltitle.Text & "', '" & Date.Now.ToString("yyyy-MM-dd") & "','" & isFav & "')"

        Dim command As New MySqlCommand(insertTableQuery, strcon)
        command.ExecuteNonQuery()

        strcon.Close()


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub


End Class