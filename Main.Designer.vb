<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
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
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.webView = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LabelGeschäfteNachStadtteilen = New System.Windows.Forms.Label()
        Me.TreeViewGeschäfteStadtteile = New System.Windows.Forms.TreeView()
        Me.LabelGeschäfteNachKategorien = New System.Windows.Forms.Label()
        Me.TreeViewGeschäfteKategorien = New System.Windows.Forms.TreeView()
        Me.btnbla = New System.Windows.Forms.Button()
        Me.PictureBoxMap = New System.Windows.Forms.PictureBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabPageUser = New System.Windows.Forms.TabPage()
        Me.TabPageFavoriten = New System.Windows.Forms.TabPage()
        Me.panelSideMenu.SuspendLayout()
        Me.panelMeinBereichSubMenu.SuspendLayout()
        Me.panelGeschaefteSubmenu.SuspendLayout()
        Me.panelContent.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.webView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBoxMap, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnHelp.Size = New System.Drawing.Size(216, 45)
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
        Me.btnAbout.Size = New System.Drawing.Size(216, 45)
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
        Me.btnProgrammeinstellungen.Size = New System.Drawing.Size(216, 45)
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
        Me.panelMeinBereichSubMenu.Size = New System.Drawing.Size(216, 164)
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
        Me.Button6.Size = New System.Drawing.Size(216, 40)
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
        Me.Button7.Size = New System.Drawing.Size(216, 40)
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
        Me.btnUserSettings.Size = New System.Drawing.Size(216, 40)
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
        Me.btnFavorit.Size = New System.Drawing.Size(216, 40)
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
        Me.btnMeinBereich.Size = New System.Drawing.Size(216, 45)
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
        Me.panelGeschaefteSubmenu.Size = New System.Drawing.Size(216, 164)
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
        Me.btnBekleidungslaeden.Size = New System.Drawing.Size(216, 40)
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
        Me.btnBauernhoefe.Size = New System.Drawing.Size(216, 40)
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
        Me.btnBiolaeden.Size = New System.Drawing.Size(216, 40)
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
        Me.btnAlleGeschaefte.Size = New System.Drawing.Size(216, 40)
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
        Me.btnGeschaefte.Size = New System.Drawing.Size(216, 45)
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
        Me.panelLogo.Size = New System.Drawing.Size(216, 100)
        Me.panelLogo.TabIndex = 0
        '
        'panelContent
        '
        Me.panelContent.Controls.Add(Me.TabControl1)
        Me.panelContent.Controls.Add(Me.PictureBoxMap)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(285, 0)
        Me.panelContent.Margin = New System.Windows.Forms.Padding(0)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(647, 553)
        Me.panelContent.TabIndex = 9
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPageUser)
        Me.TabControl1.Controls.Add(Me.TabPageFavoriten)
        Me.TabControl1.Location = New System.Drawing.Point(0, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(647, 550)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.webView)
        Me.TabPage1.Location = New System.Drawing.Point(8, 45)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(631, 497)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'webView
        '
        Me.webView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webView.CreationProperties = Nothing
        Me.webView.Location = New System.Drawing.Point(3, 13)
        Me.webView.Name = "webView"
        Me.webView.Size = New System.Drawing.Size(621, 456)
        Me.webView.Source = New System.Uri("C:\Users\simon\source\repos\GoGreen\GoGreen\Website\index.html", System.UriKind.Absolute)
        Me.webView.TabIndex = 4
        Me.webView.UseWaitCursor = True
        Me.webView.ZoomFactor = 1.0R
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LabelGeschäfteNachStadtteilen)
        Me.TabPage2.Controls.Add(Me.TreeViewGeschäfteStadtteile)
        Me.TabPage2.Controls.Add(Me.LabelGeschäfteNachKategorien)
        Me.TabPage2.Controls.Add(Me.TreeViewGeschäfteKategorien)
        Me.TabPage2.Controls.Add(Me.btnbla)
        Me.TabPage2.Location = New System.Drawing.Point(8, 45)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(631, 497)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LabelGeschäfteNachStadtteilen
        '
        Me.LabelGeschäfteNachStadtteilen.AutoSize = True
        Me.LabelGeschäfteNachStadtteilen.Location = New System.Drawing.Point(320, 30)
        Me.LabelGeschäfteNachStadtteilen.Name = "LabelGeschäfteNachStadtteilen"
        Me.LabelGeschäfteNachStadtteilen.Size = New System.Drawing.Size(341, 31)
        Me.LabelGeschäfteNachStadtteilen.TabIndex = 4
        Me.LabelGeschäfteNachStadtteilen.Text = "Geschäfte nach Stadtteilen"
        '
        'TreeViewGeschäfteStadtteile
        '
        Me.TreeViewGeschäfteStadtteile.Location = New System.Drawing.Point(320, 58)
        Me.TreeViewGeschäfteStadtteile.Name = "TreeViewGeschäfteStadtteile"
        Me.TreeViewGeschäfteStadtteile.Size = New System.Drawing.Size(205, 368)
        Me.TreeViewGeschäfteStadtteile.TabIndex = 3
        '
        'LabelGeschäfteNachKategorien
        '
        Me.LabelGeschäfteNachKategorien.AutoSize = True
        Me.LabelGeschäfteNachKategorien.Location = New System.Drawing.Point(49, 25)
        Me.LabelGeschäfteNachKategorien.Name = "LabelGeschäfteNachKategorien"
        Me.LabelGeschäfteNachKategorien.Size = New System.Drawing.Size(343, 31)
        Me.LabelGeschäfteNachKategorien.TabIndex = 2
        Me.LabelGeschäfteNachKategorien.Text = "Geschäfte nach Kategorien"
        '
        'TreeViewGeschäfteKategorien
        '
        Me.TreeViewGeschäfteKategorien.Location = New System.Drawing.Point(49, 58)
        Me.TreeViewGeschäfteKategorien.Name = "TreeViewGeschäfteKategorien"
        Me.TreeViewGeschäfteKategorien.Size = New System.Drawing.Size(219, 368)
        Me.TreeViewGeschäfteKategorien.TabIndex = 1
        '
        'btnbla
        '
        Me.btnbla.Location = New System.Drawing.Point(546, 29)
        Me.btnbla.Name = "btnbla"
        Me.btnbla.Size = New System.Drawing.Size(75, 23)
        Me.btnbla.TabIndex = 0
        Me.btnbla.Text = "Button1"
        Me.btnbla.UseVisualStyleBackColor = True
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
        'TabPageUser
        '
        Me.TabPageUser.Location = New System.Drawing.Point(8, 45)
        Me.TabPageUser.Name = "TabPageUser"
        Me.TabPageUser.Size = New System.Drawing.Size(631, 497)
        Me.TabPageUser.TabIndex = 2
        Me.TabPageUser.Text = "User"
        Me.TabPageUser.UseVisualStyleBackColor = True
        '
        'TabPageFavoriten
        '
        Me.TabPageFavoriten.Location = New System.Drawing.Point(8, 45)
        Me.TabPageFavoriten.Name = "TabPageFavoriten"
        Me.TabPageFavoriten.Size = New System.Drawing.Size(631, 497)
        Me.TabPageFavoriten.TabIndex = 3
        Me.TabPageFavoriten.Text = "Favoriten"
        Me.TabPageFavoriten.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(16.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 553)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelSideMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(950, 600)
        Me.Name = "FormMain"
        Me.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Text = "FormMain"
        Me.panelSideMenu.ResumeLayout(False)
        Me.panelMeinBereichSubMenu.ResumeLayout(False)
        Me.panelGeschaefteSubmenu.ResumeLayout(False)
        Me.panelContent.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.webView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBoxMap, System.ComponentModel.ISupportInitialize).EndInit()
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

    Friend WithEvents panelContent As Panel
    Friend WithEvents PictureBoxMap As PictureBox
    Friend WithEvents webView As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnbla As Button
    Friend WithEvents TreeViewGeschäfteKategorien As TreeView
    Friend WithEvents TreeViewGeschäfteStadtteile As TreeView
    Friend WithEvents LabelGeschäfteNachKategorien As Label
    Friend WithEvents LabelGeschäfteNachStadtteilen As Label
    Friend WithEvents TabPageUser As TabPage
    Friend WithEvents TabPageFavoriten As TabPage
End Class
