<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtbxP1 = New System.Windows.Forms.TextBox()
        Me.txtbxP2 = New System.Windows.Forms.TextBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnPlayer1 = New System.Windows.Forms.Button()
        Me.btnPlayer2 = New System.Windows.Forms.Button()
        Me.lblPlayer1 = New System.Windows.Forms.Label()
        Me.lblPlayer2 = New System.Windows.Forms.Label()
        Me.lblFirstTo100 = New System.Windows.Forms.Label()
        Me.lblP1 = New System.Windows.Forms.Label()
        Me.lblP2 = New System.Windows.Forms.Label()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.lblHiScore = New System.Windows.Forms.Label()
        Me.lblRandom1 = New System.Windows.Forms.Label()
        Me.lblRandom2 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblResultPly1 = New System.Windows.Forms.Label()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.lstbxHiScores = New System.Windows.Forms.ListBox()
        Me.txtbxSearch = New System.Windows.Forms.TextBox()
        Me.lstbxHiScores1 = New System.Windows.Forms.ListBox()
        Me.pxbxDice1 = New System.Windows.Forms.PictureBox()
        Me.pxbxDice2 = New System.Windows.Forms.PictureBox()
        Me.pxbxDice3 = New System.Windows.Forms.PictureBox()
        Me.pxbxDice4 = New System.Windows.Forms.PictureBox()
        Me.pxbxDice5 = New System.Windows.Forms.PictureBox()
        Me.pxbxDice6 = New System.Windows.Forms.PictureBox()
        Me.pxbxMain = New System.Windows.Forms.PictureBox()
        Me.lblAttempt2 = New System.Windows.Forms.Label()
        Me.lblAttempt1 = New System.Windows.Forms.Label()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.lblResultPly2 = New System.Windows.Forms.Label()
        CType(Me.pxbxDice1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxbxDice2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxbxDice3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxbxDice4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxbxDice5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxbxDice6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pxbxMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbxP1
        '
        Me.txtbxP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxP1.Location = New System.Drawing.Point(510, 332)
        Me.txtbxP1.Name = "txtbxP1"
        Me.txtbxP1.Size = New System.Drawing.Size(154, 26)
        Me.txtbxP1.TabIndex = 0
        Me.txtbxP1.Text = "sample"
        '
        'txtbxP2
        '
        Me.txtbxP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxP2.Location = New System.Drawing.Point(510, 415)
        Me.txtbxP2.Name = "txtbxP2"
        Me.txtbxP2.Size = New System.Drawing.Size(154, 26)
        Me.txtbxP2.TabIndex = 1
        Me.txtbxP2.Text = "test"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(303, 312)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(160, 42)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start Game!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnPlayer1
        '
        Me.btnPlayer1.Enabled = False
        Me.btnPlayer1.Location = New System.Drawing.Point(103, 114)
        Me.btnPlayer1.Name = "btnPlayer1"
        Me.btnPlayer1.Size = New System.Drawing.Size(160, 140)
        Me.btnPlayer1.TabIndex = 3
        Me.btnPlayer1.Text = "Player 1"
        Me.btnPlayer1.UseVisualStyleBackColor = True
        '
        'btnPlayer2
        '
        Me.btnPlayer2.Enabled = False
        Me.btnPlayer2.Location = New System.Drawing.Point(504, 114)
        Me.btnPlayer2.Name = "btnPlayer2"
        Me.btnPlayer2.Size = New System.Drawing.Size(160, 140)
        Me.btnPlayer2.TabIndex = 4
        Me.btnPlayer2.Text = "Player 2"
        Me.btnPlayer2.UseVisualStyleBackColor = True
        '
        'lblPlayer1
        '
        Me.lblPlayer1.AutoSize = True
        Me.lblPlayer1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1.Location = New System.Drawing.Point(506, 305)
        Me.lblPlayer1.Name = "lblPlayer1"
        Me.lblPlayer1.Size = New System.Drawing.Size(158, 20)
        Me.lblPlayer1.TabIndex = 6
        Me.lblPlayer1.Text = "Enter Player 1 Name:"
        '
        'lblPlayer2
        '
        Me.lblPlayer2.AutoSize = True
        Me.lblPlayer2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2.Location = New System.Drawing.Point(506, 388)
        Me.lblPlayer2.Name = "lblPlayer2"
        Me.lblPlayer2.Size = New System.Drawing.Size(158, 20)
        Me.lblPlayer2.TabIndex = 7
        Me.lblPlayer2.Text = "Enter Player 2 Name:"
        '
        'lblFirstTo100
        '
        Me.lblFirstTo100.AutoSize = True
        Me.lblFirstTo100.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstTo100.Location = New System.Drawing.Point(297, 9)
        Me.lblFirstTo100.Name = "lblFirstTo100"
        Me.lblFirstTo100.Size = New System.Drawing.Size(181, 33)
        Me.lblFirstTo100.TabIndex = 8
        Me.lblFirstTo100.Text = """First to 100"""
        '
        'lblP1
        '
        Me.lblP1.AutoSize = True
        Me.lblP1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1.Location = New System.Drawing.Point(9, 114)
        Me.lblP1.Name = "lblP1"
        Me.lblP1.Size = New System.Drawing.Size(78, 20)
        Me.lblP1.TabIndex = 9
        Me.lblP1.Text = "Player 1 "
        '
        'lblP2
        '
        Me.lblP2.AutoSize = True
        Me.lblP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2.Location = New System.Drawing.Point(692, 114)
        Me.lblP2.Name = "lblP2"
        Me.lblP2.Size = New System.Drawing.Size(73, 20)
        Me.lblP2.TabIndex = 10
        Me.lblP2.Text = "Player 2"
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore1.Location = New System.Drawing.Point(9, 152)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(18, 20)
        Me.lblScore1.TabIndex = 11
        Me.lblScore1.Text = "0"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore2.Location = New System.Drawing.Point(692, 152)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(18, 20)
        Me.lblScore2.TabIndex = 12
        Me.lblScore2.Text = "0"
        '
        'lblHiScore
        '
        Me.lblHiScore.AutoSize = True
        Me.lblHiScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHiScore.Location = New System.Drawing.Point(79, 274)
        Me.lblHiScore.Name = "lblHiScore"
        Me.lblHiScore.Size = New System.Drawing.Size(184, 18)
        Me.lblHiScore.TabIndex = 13
        Me.lblHiScore.Text = "LEAST ATTEMPTS TOP 5"
        '
        'lblRandom1
        '
        Me.lblRandom1.AutoSize = True
        Me.lblRandom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandom1.ForeColor = System.Drawing.Color.Red
        Me.lblRandom1.Location = New System.Drawing.Point(11, 209)
        Me.lblRandom1.Name = "lblRandom1"
        Me.lblRandom1.Size = New System.Drawing.Size(52, 55)
        Me.lblRandom1.TabIndex = 19
        Me.lblRandom1.Text = "0"
        '
        'lblRandom2
        '
        Me.lblRandom2.AutoSize = True
        Me.lblRandom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRandom2.ForeColor = System.Drawing.Color.Red
        Me.lblRandom2.Location = New System.Drawing.Point(692, 209)
        Me.lblRandom2.Name = "lblRandom2"
        Me.lblRandom2.Size = New System.Drawing.Size(52, 55)
        Me.lblRandom2.TabIndex = 20
        Me.lblRandom2.Text = "0"
        '
        'btnClear
        '
        Me.btnClear.Enabled = False
        Me.btnClear.Location = New System.Drawing.Point(303, 408)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(160, 42)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear!"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblResultPly1
        '
        Me.lblResultPly1.AutoSize = True
        Me.lblResultPly1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultPly1.ForeColor = System.Drawing.Color.Red
        Me.lblResultPly1.Location = New System.Drawing.Point(98, 86)
        Me.lblResultPly1.Name = "lblResultPly1"
        Me.lblResultPly1.Size = New System.Drawing.Size(171, 25)
        Me.lblResultPly1.TabIndex = 22
        Me.lblResultPly1.Text = "Player 1 WINS!"
        Me.lblResultPly1.Visible = False
        '
        'btnRestart
        '
        Me.btnRestart.Enabled = False
        Me.btnRestart.Location = New System.Drawing.Point(303, 360)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(160, 42)
        Me.btnRestart.TabIndex = 23
        Me.btnRestart.Text = "Restart Game!"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'lstbxHiScores
        '
        Me.lstbxHiScores.FormattingEnabled = True
        Me.lstbxHiScores.Location = New System.Drawing.Point(103, 312)
        Me.lstbxHiScores.Name = "lstbxHiScores"
        Me.lstbxHiScores.Size = New System.Drawing.Size(151, 108)
        Me.lstbxHiScores.Sorted = True
        Me.lstbxHiScores.TabIndex = 24
        '
        'txtbxSearch
        '
        Me.txtbxSearch.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.txtbxSearch.Location = New System.Drawing.Point(103, 447)
        Me.txtbxSearch.Name = "txtbxSearch"
        Me.txtbxSearch.Size = New System.Drawing.Size(151, 20)
        Me.txtbxSearch.TabIndex = 26
        '
        'lstbxHiScores1
        '
        Me.lstbxHiScores1.FormattingEnabled = True
        Me.lstbxHiScores1.Location = New System.Drawing.Point(103, 312)
        Me.lstbxHiScores1.Name = "lstbxHiScores1"
        Me.lstbxHiScores1.Size = New System.Drawing.Size(151, 108)
        Me.lstbxHiScores1.TabIndex = 27
        '
        'pxbxDice1
        '
        Me.pxbxDice1.Image = CType(resources.GetObject("pxbxDice1.Image"), System.Drawing.Image)
        Me.pxbxDice1.Location = New System.Drawing.Point(284, 92)
        Me.pxbxDice1.Name = "pxbxDice1"
        Me.pxbxDice1.Size = New System.Drawing.Size(200, 200)
        Me.pxbxDice1.TabIndex = 28
        Me.pxbxDice1.TabStop = False
        Me.pxbxDice1.Visible = False
        '
        'pxbxDice2
        '
        Me.pxbxDice2.Image = CType(resources.GetObject("pxbxDice2.Image"), System.Drawing.Image)
        Me.pxbxDice2.Location = New System.Drawing.Point(284, 92)
        Me.pxbxDice2.Name = "pxbxDice2"
        Me.pxbxDice2.Size = New System.Drawing.Size(200, 200)
        Me.pxbxDice2.TabIndex = 29
        Me.pxbxDice2.TabStop = False
        Me.pxbxDice2.Visible = False
        '
        'pxbxDice3
        '
        Me.pxbxDice3.Image = CType(resources.GetObject("pxbxDice3.Image"), System.Drawing.Image)
        Me.pxbxDice3.Location = New System.Drawing.Point(284, 92)
        Me.pxbxDice3.Name = "pxbxDice3"
        Me.pxbxDice3.Size = New System.Drawing.Size(200, 200)
        Me.pxbxDice3.TabIndex = 30
        Me.pxbxDice3.TabStop = False
        Me.pxbxDice3.Visible = False
        '
        'pxbxDice4
        '
        Me.pxbxDice4.Image = CType(resources.GetObject("pxbxDice4.Image"), System.Drawing.Image)
        Me.pxbxDice4.Location = New System.Drawing.Point(284, 92)
        Me.pxbxDice4.Name = "pxbxDice4"
        Me.pxbxDice4.Size = New System.Drawing.Size(200, 200)
        Me.pxbxDice4.TabIndex = 31
        Me.pxbxDice4.TabStop = False
        Me.pxbxDice4.Visible = False
        '
        'pxbxDice5
        '
        Me.pxbxDice5.Image = CType(resources.GetObject("pxbxDice5.Image"), System.Drawing.Image)
        Me.pxbxDice5.Location = New System.Drawing.Point(284, 92)
        Me.pxbxDice5.Name = "pxbxDice5"
        Me.pxbxDice5.Size = New System.Drawing.Size(200, 200)
        Me.pxbxDice5.TabIndex = 32
        Me.pxbxDice5.TabStop = False
        Me.pxbxDice5.Visible = False
        '
        'pxbxDice6
        '
        Me.pxbxDice6.Image = CType(resources.GetObject("pxbxDice6.Image"), System.Drawing.Image)
        Me.pxbxDice6.Location = New System.Drawing.Point(284, 92)
        Me.pxbxDice6.Name = "pxbxDice6"
        Me.pxbxDice6.Size = New System.Drawing.Size(200, 200)
        Me.pxbxDice6.TabIndex = 33
        Me.pxbxDice6.TabStop = False
        Me.pxbxDice6.Visible = False
        '
        'pxbxMain
        '
        Me.pxbxMain.Image = CType(resources.GetObject("pxbxMain.Image"), System.Drawing.Image)
        Me.pxbxMain.Location = New System.Drawing.Point(284, 92)
        Me.pxbxMain.Name = "pxbxMain"
        Me.pxbxMain.Size = New System.Drawing.Size(200, 200)
        Me.pxbxMain.TabIndex = 34
        Me.pxbxMain.TabStop = False
        '
        'lblAttempt2
        '
        Me.lblAttempt2.AutoSize = True
        Me.lblAttempt2.Location = New System.Drawing.Point(693, 181)
        Me.lblAttempt2.Name = "lblAttempt2"
        Me.lblAttempt2.Size = New System.Drawing.Size(48, 13)
        Me.lblAttempt2.TabIndex = 35
        Me.lblAttempt2.Text = "Attempts"
        '
        'lblAttempt1
        '
        Me.lblAttempt1.AutoSize = True
        Me.lblAttempt1.Location = New System.Drawing.Point(10, 181)
        Me.lblAttempt1.Name = "lblAttempt1"
        Me.lblAttempt1.Size = New System.Drawing.Size(48, 13)
        Me.lblAttempt1.TabIndex = 36
        Me.lblAttempt1.Text = "Attempts"
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Location = New System.Drawing.Point(100, 431)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(44, 13)
        Me.lblSearch.TabIndex = 37
        Me.lblSearch.Text = "Search:"
        '
        'lblResultPly2
        '
        Me.lblResultPly2.AutoSize = True
        Me.lblResultPly2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultPly2.ForeColor = System.Drawing.Color.Red
        Me.lblResultPly2.Location = New System.Drawing.Point(499, 86)
        Me.lblResultPly2.Name = "lblResultPly2"
        Me.lblResultPly2.Size = New System.Drawing.Size(171, 25)
        Me.lblResultPly2.TabIndex = 38
        Me.lblResultPly2.Text = "Player 2 WINS!"
        Me.lblResultPly2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(768, 505)
        Me.Controls.Add(Me.lblResultPly2)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblAttempt1)
        Me.Controls.Add(Me.lblAttempt2)
        Me.Controls.Add(Me.pxbxMain)
        Me.Controls.Add(Me.pxbxDice6)
        Me.Controls.Add(Me.pxbxDice5)
        Me.Controls.Add(Me.pxbxDice4)
        Me.Controls.Add(Me.pxbxDice3)
        Me.Controls.Add(Me.pxbxDice2)
        Me.Controls.Add(Me.pxbxDice1)
        Me.Controls.Add(Me.lstbxHiScores1)
        Me.Controls.Add(Me.txtbxSearch)
        Me.Controls.Add(Me.lstbxHiScores)
        Me.Controls.Add(Me.btnRestart)
        Me.Controls.Add(Me.lblResultPly1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblRandom2)
        Me.Controls.Add(Me.lblRandom1)
        Me.Controls.Add(Me.lblHiScore)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.lblP2)
        Me.Controls.Add(Me.lblP1)
        Me.Controls.Add(Me.lblFirstTo100)
        Me.Controls.Add(Me.lblPlayer2)
        Me.Controls.Add(Me.lblPlayer1)
        Me.Controls.Add(Me.btnPlayer2)
        Me.Controls.Add(Me.btnPlayer1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.txtbxP2)
        Me.Controls.Add(Me.txtbxP1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pxbxDice1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxbxDice2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxbxDice3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxbxDice4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxbxDice5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxbxDice6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pxbxMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtbxP1 As System.Windows.Forms.TextBox
    Friend WithEvents txtbxP2 As System.Windows.Forms.TextBox
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnPlayer1 As System.Windows.Forms.Button
    Friend WithEvents btnPlayer2 As System.Windows.Forms.Button
    Friend WithEvents lblPlayer1 As System.Windows.Forms.Label
    Friend WithEvents lblPlayer2 As System.Windows.Forms.Label
    Friend WithEvents lblFirstTo100 As System.Windows.Forms.Label
    Friend WithEvents lblP1 As System.Windows.Forms.Label
    Friend WithEvents lblP2 As System.Windows.Forms.Label
    Friend WithEvents lblScore1 As System.Windows.Forms.Label
    Friend WithEvents lblScore2 As System.Windows.Forms.Label
    Friend WithEvents lblHiScore As System.Windows.Forms.Label
    Friend WithEvents lblRandom1 As System.Windows.Forms.Label
    Friend WithEvents lblRandom2 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblResultPly1 As System.Windows.Forms.Label
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents lstbxHiScores As System.Windows.Forms.ListBox
    Friend WithEvents txtbxSearch As System.Windows.Forms.TextBox
    Friend WithEvents lstbxHiScores1 As System.Windows.Forms.ListBox
    Friend WithEvents pxbxDice1 As System.Windows.Forms.PictureBox
    Friend WithEvents pxbxDice2 As System.Windows.Forms.PictureBox
    Friend WithEvents pxbxDice3 As System.Windows.Forms.PictureBox
    Friend WithEvents pxbxDice4 As System.Windows.Forms.PictureBox
    Friend WithEvents pxbxDice5 As System.Windows.Forms.PictureBox
    Friend WithEvents pxbxDice6 As System.Windows.Forms.PictureBox
    Friend WithEvents pxbxMain As System.Windows.Forms.PictureBox
    Friend WithEvents lblAttempt2 As System.Windows.Forms.Label
    Friend WithEvents lblAttempt1 As System.Windows.Forms.Label
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents lblResultPly2 As System.Windows.Forms.Label

End Class
