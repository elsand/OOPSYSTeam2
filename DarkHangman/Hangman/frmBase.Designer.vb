<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBase
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
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNewGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnChooseDifficulty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDifficultyEasy = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDifficultyMedium = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDifficultyHard = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExitGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHighscore = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHighscoreShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHighscoreClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAudioToggle = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnClose = New Hangman.HMctlButton()
        Me.mnuMain.SuspendLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.BackgroundImage = Global.Hangman.My.Resources.Resources.Background
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuHighscore, Me.mnuHelp, Me.mnuAudioToggle})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Padding = New System.Windows.Forms.Padding(6, 6, 0, 2)
        Me.mnuMain.Size = New System.Drawing.Size(640, 27)
        Me.mnuMain.TabIndex = 3
        Me.mnuMain.Text = "mnuMain"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNewGame, Me.mnChooseDifficulty, Me.mnuExitGame})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(31, 19)
        Me.mnuFile.Text = "&Fil"
        '
        'mnuNewGame
        '
        Me.mnuNewGame.Name = "mnuNewGame"
        Me.mnuNewGame.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.mnuNewGame.Size = New System.Drawing.Size(196, 22)
        Me.mnuNewGame.Text = "&Nytt spill ..."
        '
        'mnChooseDifficulty
        '
        Me.mnChooseDifficulty.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDifficultyEasy, Me.mnuDifficultyMedium, Me.mnuDifficultyHard})
        Me.mnChooseDifficulty.Name = "mnChooseDifficulty"
        Me.mnChooseDifficulty.Size = New System.Drawing.Size(196, 22)
        Me.mnChooseDifficulty.Text = "&Velg vanskelighetsgrad"
        '
        'mnuDifficultyEasy
        '
        Me.mnuDifficultyEasy.Name = "mnuDifficultyEasy"
        Me.mnuDifficultyEasy.Size = New System.Drawing.Size(125, 22)
        Me.mnuDifficultyEasy.Text = "Lett"
        '
        'mnuDifficultyMedium
        '
        Me.mnuDifficultyMedium.Checked = True
        Me.mnuDifficultyMedium.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuDifficultyMedium.Name = "mnuDifficultyMedium"
        Me.mnuDifficultyMedium.Size = New System.Drawing.Size(125, 22)
        Me.mnuDifficultyMedium.Text = "Middels"
        '
        'mnuDifficultyHard
        '
        Me.mnuDifficultyHard.Name = "mnuDifficultyHard"
        Me.mnuDifficultyHard.Size = New System.Drawing.Size(125, 22)
        Me.mnuDifficultyHard.Text = "Vanskelig"
        '
        'mnuExitGame
        '
        Me.mnuExitGame.Name = "mnuExitGame"
        Me.mnuExitGame.Size = New System.Drawing.Size(196, 22)
        Me.mnuExitGame.Text = "&Avslutt spill"
        '
        'mnuHighscore
        '
        Me.mnuHighscore.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHighscoreShow, Me.mnuHighscoreClear})
        Me.mnuHighscore.Name = "mnuHighscore"
        Me.mnuHighscore.Size = New System.Drawing.Size(73, 19)
        Me.mnuHighscore.Text = "Highscore"
        '
        'mnuHighscoreShow
        '
        Me.mnuHighscoreShow.Name = "mnuHighscoreShow"
        Me.mnuHighscoreShow.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.mnuHighscoreShow.Size = New System.Drawing.Size(208, 22)
        Me.mnuHighscoreShow.Text = "&Vis highscoreliste"
        '
        'mnuHighscoreClear
        '
        Me.mnuHighscoreClear.Name = "mnuHighscoreClear"
        Me.mnuHighscoreClear.Size = New System.Drawing.Size(208, 22)
        Me.mnuHighscoreClear.Text = "&Tøm highscore ..."
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpShow, Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(47, 19)
        Me.mnuHelp.Text = "&Hjelp"
        '
        'mnuHelpShow
        '
        Me.mnuHelpShow.Name = "mnuHelpShow"
        Me.mnuHelpShow.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuHelpShow.Size = New System.Drawing.Size(150, 22)
        Me.mnuHelpShow.Text = "&Hjelp ..."
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(150, 22)
        Me.mnuHelpAbout.Text = "&Om Hangman"
        '
        'mnuAudioToggle
        '
        Me.mnuAudioToggle.Name = "mnuAudioToggle"
        Me.mnuAudioToggle.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuAudioToggle.Size = New System.Drawing.Size(69, 19)
        Me.mnuAudioToggle.Text = "&Slå av lyd"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Global.Hangman.My.Resources.Resources.ButtonClose
        Me.btnClose.Location = New System.Drawing.Point(599, 9)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(0)
        Me.btnClose.MinimumSize = New System.Drawing.Size(32, 32)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(32, 32)
        Me.btnClose.TabIndex = 4
        Me.btnClose.TabStop = False
        '
        'frmBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hangman.My.Resources.Resources.Background
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.mnuMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "frmBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hangman!"
        Me.TransparencyKey = System.Drawing.Color.Aqua
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.btnClose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuNewGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnChooseDifficulty As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDifficultyEasy As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDifficultyMedium As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDifficultyHard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExitGame As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHighscore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHighscoreShow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHighscoreClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClose As Hangman.HMctlButton
    Friend WithEvents mnuAudioToggle As System.Windows.Forms.ToolStripMenuItem

    

End Class
