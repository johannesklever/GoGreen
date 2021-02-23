<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Label_email = New System.Windows.Forms.Label()
        Me.Label_passwort = New System.Windows.Forms.Label()
        Me.TextBox_email = New System.Windows.Forms.TextBox()
        Me.TextBox_passwort = New System.Windows.Forms.TextBox()
        Me.Button_Kontoanlegen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button_Login
        '
        Me.Button_Login.Location = New System.Drawing.Point(660, 300)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(98, 52)
        Me.Button_Login.TabIndex = 0
        Me.Button_Login.Text = "Login"
        Me.Button_Login.UseVisualStyleBackColor = True
        '
        'Label_email
        '
        Me.Label_email.AutoSize = True
        Me.Label_email.Location = New System.Drawing.Point(436, 112)
        Me.Label_email.Name = "Label_email"
        Me.Label_email.Size = New System.Drawing.Size(79, 25)
        Me.Label_email.TabIndex = 1
        Me.Label_email.Text = "E-Mail:"
        '
        'Label_passwort
        '
        Me.Label_passwort.AutoSize = True
        Me.Label_passwort.Location = New System.Drawing.Point(436, 212)
        Me.Label_passwort.Name = "Label_passwort"
        Me.Label_passwort.Size = New System.Drawing.Size(100, 25)
        Me.Label_passwort.TabIndex = 2
        Me.Label_passwort.Text = "Passwort"
        '
        'TextBox_email
        '
        Me.TextBox_email.Location = New System.Drawing.Point(566, 112)
        Me.TextBox_email.Name = "TextBox_email"
        Me.TextBox_email.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_email.TabIndex = 3
        '
        'TextBox_passwort
        '
        Me.TextBox_passwort.Location = New System.Drawing.Point(566, 212)
        Me.TextBox_passwort.Name = "TextBox_passwort"
        Me.TextBox_passwort.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_passwort.TabIndex = 4
        '
        'Button_Kontoanlegen
        '
        Me.Button_Kontoanlegen.Location = New System.Drawing.Point(460, 300)
        Me.Button_Kontoanlegen.Name = "Button_Kontoanlegen"
        Me.Button_Kontoanlegen.Size = New System.Drawing.Size(163, 52)
        Me.Button_Kontoanlegen.TabIndex = 5
        Me.Button_Kontoanlegen.Text = "Konto anlegen"
        Me.Button_Kontoanlegen.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Kontoanlegen)
        Me.Controls.Add(Me.TextBox_passwort)
        Me.Controls.Add(Me.TextBox_email)
        Me.Controls.Add(Me.Label_passwort)
        Me.Controls.Add(Me.Label_email)
        Me.Controls.Add(Me.Button_Login)
        Me.Name = "Form1"
        Me.Text = "Landingpage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Login As Button
    Friend WithEvents Label_email As Label
    Friend WithEvents Label_passwort As Label
    Friend WithEvents TextBox_email As TextBox
    Friend WithEvents TextBox_passwort As TextBox
    Friend WithEvents Button_Kontoanlegen As Button

        Me.panelSideMenu = New System.Windows.Forms.Panel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnProgrammeinstellungen = New System.Windows.Forms.Button()
        Me.panelMeinBereichSubMenu = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btnUserSettings = New System.Windows.Forms.Button()
        Me.btnFavorit = New System.Windows.Forms.Button()
        Me.btnMeinBereich = New System.Windows.Forms.Button()
        Me.panelGeschaefteSubmenu = New System.Windows.Forms.Panel()
        Me.btnBekleidungslaeden = New System.Windows.Forms.Button()
        Me.btnBauernhoefe = New System.Windows.Forms.Button()
        Me.btnBiolaeden = New System.Windows.Forms.Button()
        Me.btnAlleGeschaefte = New System.Windows.Forms.Button()
        Me.btnGeschaefte = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.btnbla = New System.Windows.Forms.Button()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.PictureBoxMap = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.webView = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.panelSideMenu.SuspendLayout()
        Me.panelMeinBereichSubMenu.SuspendLayout()
        Me.panelGeschaefteSubmenu.SuspendLayout()
        Me.panelContent.SuspendLayout()
        CType(Me.PictureBoxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.webView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panelSideMenu
        '
        Me.panelSideMenu.AutoScroll = True
        Me.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.panelSideMenu.Controls.Add(Me.btnHelp)
        Me.panelSideMenu.Controls.Add(Me.btnAbout)
        Me.panelSideMenu.Controls.Add(Me.btnProgrammeinstellungen)
        Me.panelSideMenu.Controls.Add(Me.panelMeinBereichSubMenu)
        Me.panelSideMenu.Controls.Add(Me.btnMeinBereich)
        Me.panelSideMenu.Controls.Add(Me.panelGeschaefteSubmenu)
        Me.panelSideMenu.Controls.Add(Me.btnGeschaefte)
        Me.panelSideMenu.Controls.Add(Me.panelLogo)
        Me.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelSideMenu.Location = New System.Drawing.Point(35, 0)
        Me.panelSideMenu.Name = "panelSideMenu"
        Me.panelSideMenu.Size = New System.Drawing.Size(250, 553)
        Me.panelSideMenu.TabIndex = 0
        '
        'btnHelp
        '
        Me.btnHelp.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.ForeColor = System.Drawing.Color.LightGray
        Me.btnHelp.Location = New System.Drawing.Point(0, 608)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHelp.Size = New System.Drawing.Size(229, 45)
        Me.btnHelp.TabIndex = 8
        Me.btnHelp.Text = "Help"
        Me.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.ForeColor = System.Drawing.Color.LightGray
        Me.btnAbout.Location = New System.Drawing.Point(0, 563)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAbout.Size = New System.Drawing.Size(229, 45)
        Me.btnAbout.TabIndex = 6
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnProgrammeinstellungen
        '
        Me.btnProgrammeinstellungen.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProgrammeinstellungen.FlatAppearance.BorderSize = 0
        Me.btnProgrammeinstellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgrammeinstellungen.ForeColor = System.Drawing.Color.LightGray
        Me.btnProgrammeinstellungen.Location = New System.Drawing.Point(0, 518)
        Me.btnProgrammeinstellungen.Name = "btnProgrammeinstellungen"
        Me.btnProgrammeinstellungen.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnProgrammeinstellungen.Size = New System.Drawing.Size(229, 45)
        Me.btnProgrammeinstellungen.TabIndex = 5
        Me.btnProgrammeinstellungen.Text = "Programmeinstellungen"
        Me.btnProgrammeinstellungen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgrammeinstellungen.UseVisualStyleBackColor = True
        '
        'panelMeinBereichSubMenu
        '
        Me.panelMeinBereichSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelMeinBereichSubMenu.Controls.Add(Me.Button6)
        Me.panelMeinBereichSubMenu.Controls.Add(Me.Button7)
        Me.panelMeinBereichSubMenu.Controls.Add(Me.btnUserSettings)
        Me.panelMeinBereichSubMenu.Controls.Add(Me.btnFavorit)
        Me.panelMeinBereichSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMeinBereichSubMenu.Location = New System.Drawing.Point(0, 354)
        Me.panelMeinBereichSubMenu.Name = "panelMeinBereichSubMenu"
        Me.panelMeinBereichSubMenu.Size = New System.Drawing.Size(229, 164)
        Me.panelMeinBereichSubMenu.TabIndex = 4
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.ForeColor = System.Drawing.Color.LightGray
        Me.Button6.Location = New System.Drawing.Point(0, 120)
        Me.Button6.Name = "Button6"
        Me.Button6.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button6.Size = New System.Drawing.Size(229, 40)
        Me.Button6.TabIndex = 3
        Me.Button6.Text = "Button6"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.ForeColor = System.Drawing.Color.LightGray
        Me.Button7.Location = New System.Drawing.Point(0, 80)
        Me.Button7.Name = "Button7"
        Me.Button7.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button7.Size = New System.Drawing.Size(229, 40)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Button7"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btnUserSettings
        '
        Me.btnUserSettings.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnUserSettings.FlatAppearance.BorderSize = 0
        Me.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUserSettings.ForeColor = System.Drawing.Color.LightGray
        Me.btnUserSettings.Location = New System.Drawing.Point(0, 40)
        Me.btnUserSettings.Name = "btnUserSettings"
        Me.btnUserSettings.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnUserSettings.Size = New System.Drawing.Size(229, 40)
        Me.btnUserSettings.TabIndex = 1
        Me.btnUserSettings.Text = "User Settings"
        Me.btnUserSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUserSettings.UseVisualStyleBackColor = True
        '
        'btnFavorit
        '
        Me.btnFavorit.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnFavorit.FlatAppearance.BorderSize = 0
        Me.btnFavorit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFavorit.ForeColor = System.Drawing.Color.LightGray
        Me.btnFavorit.Location = New System.Drawing.Point(0, 0)
        Me.btnFavorit.Name = "btnFavorit"
        Me.btnFavorit.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnFavorit.Size = New System.Drawing.Size(229, 40)
        Me.btnFavorit.TabIndex = 0
        Me.btnFavorit.Text = "Favoriten"
        Me.btnFavorit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFavorit.UseVisualStyleBackColor = True
        '
        'btnMeinBereich
        '
        Me.btnMeinBereich.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMeinBereich.FlatAppearance.BorderSize = 0
        Me.btnMeinBereich.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMeinBereich.ForeColor = System.Drawing.Color.LightGray
        Me.btnMeinBereich.Location = New System.Drawing.Point(0, 309)
        Me.btnMeinBereich.Name = "btnMeinBereich"
        Me.btnMeinBereich.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMeinBereich.Size = New System.Drawing.Size(229, 45)
        Me.btnMeinBereich.TabIndex = 3
        Me.btnMeinBereich.Text = "Mein Bereich"
        Me.btnMeinBereich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMeinBereich.UseVisualStyleBackColor = True
        '
        'panelGeschaefteSubmenu
        '
        Me.panelGeschaefteSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelGeschaefteSubmenu.Controls.Add(Me.btnBekleidungslaeden)
        Me.panelGeschaefteSubmenu.Controls.Add(Me.btnBauernhoefe)
        Me.panelGeschaefteSubmenu.Controls.Add(Me.btnBiolaeden)
        Me.panelGeschaefteSubmenu.Controls.Add(Me.btnAlleGeschaefte)
        Me.panelGeschaefteSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelGeschaefteSubmenu.Location = New System.Drawing.Point(0, 145)
        Me.panelGeschaefteSubmenu.Name = "panelGeschaefteSubmenu"
        Me.panelGeschaefteSubmenu.Size = New System.Drawing.Size(229, 164)
        Me.panelGeschaefteSubmenu.TabIndex = 2
        '
        'btnBekleidungslaeden
        '
        Me.btnBekleidungslaeden.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBekleidungslaeden.FlatAppearance.BorderSize = 0
        Me.btnBekleidungslaeden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBekleidungslaeden.ForeColor = System.Drawing.Color.LightGray
        Me.btnBekleidungslaeden.Location = New System.Drawing.Point(0, 120)
        Me.btnBekleidungslaeden.Name = "btnBekleidungslaeden"
        Me.btnBekleidungslaeden.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnBekleidungslaeden.Size = New System.Drawing.Size(229, 40)
        Me.btnBekleidungslaeden.TabIndex = 3
        Me.btnBekleidungslaeden.Text = "Bekleidungsläden"
        Me.btnBekleidungslaeden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBekleidungslaeden.UseVisualStyleBackColor = True
        '
        'btnBauernhoefe
        '
        Me.btnBauernhoefe.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBauernhoefe.FlatAppearance.BorderSize = 0
        Me.btnBauernhoefe.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBauernhoefe.ForeColor = System.Drawing.Color.LightGray
        Me.btnBauernhoefe.Location = New System.Drawing.Point(0, 80)
        Me.btnBauernhoefe.Name = "btnBauernhoefe"
        Me.btnBauernhoefe.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnBauernhoefe.Size = New System.Drawing.Size(229, 40)
        Me.btnBauernhoefe.TabIndex = 2
        Me.btnBauernhoefe.Text = "Bauernhöfe"
        Me.btnBauernhoefe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBauernhoefe.UseVisualStyleBackColor = True
        '
        'btnBiolaeden
        '
        Me.btnBiolaeden.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBiolaeden.FlatAppearance.BorderSize = 0
        Me.btnBiolaeden.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBiolaeden.ForeColor = System.Drawing.Color.LightGray
        Me.btnBiolaeden.Location = New System.Drawing.Point(0, 40)
        Me.btnBiolaeden.Name = "btnBiolaeden"
        Me.btnBiolaeden.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnBiolaeden.Size = New System.Drawing.Size(229, 40)
        Me.btnBiolaeden.TabIndex = 1
        Me.btnBiolaeden.Text = "Bioläden"
        Me.btnBiolaeden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBiolaeden.UseVisualStyleBackColor = True
        '
        'btnAlleGeschaefte
        '
        Me.btnAlleGeschaefte.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAlleGeschaefte.FlatAppearance.BorderSize = 0
        Me.btnAlleGeschaefte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAlleGeschaefte.ForeColor = System.Drawing.Color.LightGray
        Me.btnAlleGeschaefte.Location = New System.Drawing.Point(0, 0)
        Me.btnAlleGeschaefte.Name = "btnAlleGeschaefte"
        Me.btnAlleGeschaefte.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnAlleGeschaefte.Size = New System.Drawing.Size(229, 40)
        Me.btnAlleGeschaefte.TabIndex = 0
        Me.btnAlleGeschaefte.Text = "Zeig alle Geschäfte"
        Me.btnAlleGeschaefte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlleGeschaefte.UseVisualStyleBackColor = True
        '
        'btnGeschaefte
        '
        Me.btnGeschaefte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGeschaefte.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnGeschaefte.FlatAppearance.BorderSize = 0
        Me.btnGeschaefte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGeschaefte.ForeColor = System.Drawing.Color.LightGray
        Me.btnGeschaefte.Location = New System.Drawing.Point(0, 100)
        Me.btnGeschaefte.Name = "btnGeschaefte"
        Me.btnGeschaefte.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnGeschaefte.Size = New System.Drawing.Size(229, 45)
        Me.btnGeschaefte.TabIndex = 1
        Me.btnGeschaefte.Text = "Geschäfte"
        Me.btnGeschaefte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeschaefte.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(229, 100)
        Me.panelLogo.TabIndex = 0
        '
        'btnbla
        '
        Me.btnbla.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnbla.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!)
        Me.btnbla.Location = New System.Drawing.Point(6, 16)
        Me.btnbla.Name = "btnbla"
        Me.btnbla.Size = New System.Drawing.Size(32, 30)
        Me.btnbla.TabIndex = 2
        Me.btnbla.Text = "Bla"
        Me.btnbla.UseVisualStyleBackColor = True
        '
        'panelContent
        '
        Me.panelContent.Controls.Add(Me.webView)
        Me.panelContent.Controls.Add(Me.btnbla)
        Me.panelContent.Controls.Add(Me.PictureBoxMap)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(285, 0)
        Me.panelContent.Margin = New System.Windows.Forms.Padding(0)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(647, 553)
        Me.panelContent.TabIndex = 9
        '
        'PictureBoxMap
        '
        Me.PictureBoxMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxMap.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxMap.Name = "PictureBoxMap"
        Me.PictureBoxMap.Size = New System.Drawing.Size(647, 553)
        Me.PictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMap.TabIndex = 0
        Me.PictureBoxMap.TabStop = False
        '
        'webView
        '
        Me.webView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webView.CreationProperties = Nothing
        Me.webView.Location = New System.Drawing.Point(54, 67)
        Me.webView.Name = "webView"
        Me.webView.Size = New System.Drawing.Size(541, 415)
        Me.webView.Source = New System.Uri("C:\Users\simon\source\repos\GoGreen\GoGreen\Website\index.html", System.UriKind.Absolute)
        Me.webView.TabIndex = 4
        Me.webView.UseWaitCursor = True
        Me.webView.ZoomFactor = 1.0R
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 553)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelSideMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "Form1"
        Me.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Text = "Form1"
        Me.panelSideMenu.ResumeLayout(False)
        Me.panelMeinBereichSubMenu.ResumeLayout(False)
        Me.panelGeschaefteSubmenu.ResumeLayout(False)
        Me.panelContent.ResumeLayout(False)
        CType(Me.PictureBoxMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.webView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSideMenu As Panel
    Friend WithEvents panelGeschaefteSubmenu As Panel
    Friend WithEvents btnAlleGeschaefte As Button
    Friend WithEvents btnGeschaefte As Button
    Friend WithEvents panelLogo As Panel
    Friend WithEvents btnBekleidungslaeden As Button
    Friend WithEvents btnBauernhoefe As Button
    Friend WithEvents btnBiolaeden As Button

    Friend WithEvents btnHelp As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnProgrammeinstellungen As Button
    Friend WithEvents panelMeinBereichSubMenu As Panel
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btnUserSettings As Button
    Friend WithEvents btnFavorit As Button
    Friend WithEvents btnMeinBereich As Button


    Friend WithEvents btnbla As Button
    Friend WithEvents panelContent As Panel
    Friend WithEvents PictureBoxMap As PictureBox
    Friend WithEvents webView As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker

End Class
