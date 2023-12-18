<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.pnlchangeable = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbltime = New System.Windows.Forms.Label()
        Me.lbldate = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.lblusers = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.pnlchangeable.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-1, -6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 650)
        Me.Label2.TabIndex = 4
        '
        'timer
        '
        Me.timer.Interval = 1000
        '
        'pnlchangeable
        '
        Me.pnlchangeable.Controls.Add(Me.Label13)
        Me.pnlchangeable.Controls.Add(Me.Label12)
        Me.pnlchangeable.Controls.Add(Me.Label10)
        Me.pnlchangeable.Controls.Add(Me.Panel3)
        Me.pnlchangeable.Controls.Add(Me.Panel2)
        Me.pnlchangeable.Controls.Add(Me.Panel4)
        Me.pnlchangeable.Controls.Add(Me.Label9)
        Me.pnlchangeable.Controls.Add(Me.Label8)
        Me.pnlchangeable.Location = New System.Drawing.Point(109, 3)
        Me.pnlchangeable.Name = "pnlchangeable"
        Me.pnlchangeable.Size = New System.Drawing.Size(953, 609)
        Me.pnlchangeable.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Abril Fatface", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(683, 379)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 28)
        Me.Label13.TabIndex = 27
        Me.Label13.Text = "Time"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Abril Fatface", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(385, 381)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 26)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Users"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Abril Fatface", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(78, 376)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 31)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "System"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbltime)
        Me.Panel3.Controls.Add(Me.lbldate)
        Me.Panel3.Location = New System.Drawing.Point(661, 393)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(232, 135)
        Me.Panel3.TabIndex = 24
        '
        'lbltime
        '
        Me.lbltime.AutoSize = True
        Me.lbltime.Font = New System.Drawing.Font("Arimo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltime.Location = New System.Drawing.Point(146, 67)
        Me.lbltime.Name = "lbltime"
        Me.lbltime.Size = New System.Drawing.Size(80, 18)
        Me.lbltime.TabIndex = 1
        Me.lbltime.Text = "0:00:00 am"
        '
        'lbldate
        '
        Me.lbldate.AutoSize = True
        Me.lbldate.Font = New System.Drawing.Font("Arimo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldate.Location = New System.Drawing.Point(146, 33)
        Me.lbldate.Name = "lbldate"
        Me.lbldate.Size = New System.Drawing.Size(80, 18)
        Me.lbldate.TabIndex = 0
        Me.lbldate.Text = "00/00/0000"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblnum)
        Me.Panel2.Controls.Add(Me.lblusers)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Location = New System.Drawing.Point(364, 393)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 135)
        Me.Panel2.TabIndex = 25
        '
        'lblnum
        '
        Me.lblnum.AutoSize = True
        Me.lblnum.Font = New System.Drawing.Font("Arimo", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnum.Location = New System.Drawing.Point(142, 59)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(30, 32)
        Me.lblnum.TabIndex = 4
        Me.lblnum.Text = "0"
        '
        'lblusers
        '
        Me.lblusers.AutoSize = True
        Me.lblusers.Font = New System.Drawing.Font("Arimo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusers.Location = New System.Drawing.Point(91, 67)
        Me.lblusers.Name = "lblusers"
        Me.lblusers.Size = New System.Drawing.Size(0, 18)
        Me.lblusers.TabIndex = 3
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arimo", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(91, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(126, 18)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Number of users"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(60, 393)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(232, 135)
        Me.Panel4.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Abril Fatface", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(75, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(152, 41)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "SignLingo"
        '
        'Label9
        '
        Me.Label9.Image = Global.SignLingo.My.Resources.Resources.Untitled_design__17_
        Me.Label9.Location = New System.Drawing.Point(387, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 175)
        Me.Label9.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Blueberry Personal Use", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(312, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(367, 71)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Welcome to SignLingo"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label7.Image = Global.SignLingo.My.Resources.Resources.Untitled_design__13_
        Me.Label7.Location = New System.Drawing.Point(29, 542)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 47)
        Me.Label7.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label3.Image = Global.SignLingo.My.Resources.Resources.image___2023_12_08T154402_233
        Me.Label3.Location = New System.Drawing.Point(29, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 53)
        Me.Label3.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label1.Image = Global.SignLingo.My.Resources.Resources.image___2023_12_08T154439_155
        Me.Label1.Location = New System.Drawing.Point(29, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 53)
        Me.Label1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label4.Image = Global.SignLingo.My.Resources.Resources.Untitled_design__10_
        Me.Label4.Location = New System.Drawing.Point(29, 313)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 40)
        Me.Label4.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Abril Fatface", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 49)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "LOGOUT"
        Me.Button1.UseCompatibleTextRendering = True
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(32, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "HOME"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "USERS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(16, 353)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 30)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Progress" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reports"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(173, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(29, 593)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "ABOUT"
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1063, 615)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pnlchangeable)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin"
        Me.pnlchangeable.ResumeLayout(False)
        Me.pnlchangeable.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents timer As Timer
    Friend WithEvents pnlchangeable As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbltime As Label
    Friend WithEvents lbldate As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblnum As Label
    Friend WithEvents lblusers As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
End Class
