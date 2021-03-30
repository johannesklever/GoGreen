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
        Me.buttonSideMenuHinzufuegen = New System.Windows.Forms.Button()
        Me.buttonSideMenuStadtteile = New System.Windows.Forms.Button()
        Me.buttonSideMenuKategorien = New System.Windows.Forms.Button()
        Me.buttonSideMenuGeschaefte = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.webView = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LabelGeschäfteNachKategorien = New System.Windows.Forms.Label()
        Me.TreeViewGeschäfteKategorien = New System.Windows.Forms.TreeView()
        Me.btnbla = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.buttonShopImageHinzufuegen = New System.Windows.Forms.Button()
        Me.comboBoxEinzelansichtStadtteile = New System.Windows.Forms.ComboBox()
        Me.labelShopEinzelansichtOeffnungszeit = New System.Windows.Forms.Label()
        Me.labelShopEinzelansichtTelefonnummer = New System.Windows.Forms.Label()
        Me.labelShopEinzelansichtAdresse = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelShopEinzelansichtKategorie = New System.Windows.Forms.Label()
        Me.buttonShopHinzufuegen = New System.Windows.Forms.Button()
        Me.comboBoxEinzelansichtKategorie = New System.Windows.Forms.ComboBox()
        Me.pictureBoxGeschaefteEinzelansichtsseite = New System.Windows.Forms.PictureBox()
        Me.textBoxShopEinzelansichtOeffnungszeit = New System.Windows.Forms.TextBox()
        Me.textBoxShopEinzelansichtAdresse = New System.Windows.Forms.TextBox()
        Me.textBoxShopEinzelansichtTelefonnummer = New System.Windows.Forms.TextBox()
        Me.textBoxShopEinzelansichtKategorie = New System.Windows.Forms.TextBox()
        Me.textBoxShopEinzelansichtBezeichnung = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.LabelGeschäfteNachStadtteilen = New System.Windows.Forms.Label()
        Me.TreeViewGeschäfteStadtteile = New System.Windows.Forms.TreeView()
        Me.PictureBoxMap = New System.Windows.Forms.PictureBox()
        Me.textBoxShopImageFileName = New System.Windows.Forms.TextBox()
        Me.panelSideMenu.SuspendLayout()
        Me.panelMeinBereichSubMenu.SuspendLayout()
        Me.panelGeschaefteSubmenu.SuspendLayout()
        Me.panelContent.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.webView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.pictureBoxGeschaefteEinzelansichtsseite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
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
        Me.panelSideMenu.Controls.Add(Me.buttonSideMenuGeschaefte)
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
        Me.btnHelp.Image = Global.GoGreen.My.Resources.Resources.outline_help_center_white_18dp
        Me.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHelp.Location = New System.Drawing.Point(0, 608)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHelp.Size = New System.Drawing.Size(229, 45)
        Me.btnHelp.TabIndex = 8
        Me.btnHelp.Text = "Help"
        Me.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnAbout
        '
        Me.btnAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAbout.FlatAppearance.BorderSize = 0
        Me.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAbout.ForeColor = System.Drawing.Color.LightGray
        Me.btnAbout.Image = Global.GoGreen.My.Resources.Resources.outline_info_white_18dp
        Me.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.Location = New System.Drawing.Point(0, 563)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAbout.Size = New System.Drawing.Size(229, 45)
        Me.btnAbout.TabIndex = 6
        Me.btnAbout.Text = "About"
        Me.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'btnProgrammeinstellungen
        '
        Me.btnProgrammeinstellungen.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProgrammeinstellungen.FlatAppearance.BorderSize = 0
        Me.btnProgrammeinstellungen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProgrammeinstellungen.ForeColor = System.Drawing.Color.LightGray
        Me.btnProgrammeinstellungen.Image = Global.GoGreen.My.Resources.Resources.outline_settings_suggest_white_18dp
        Me.btnProgrammeinstellungen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgrammeinstellungen.Location = New System.Drawing.Point(0, 518)
        Me.btnProgrammeinstellungen.Name = "btnProgrammeinstellungen"
        Me.btnProgrammeinstellungen.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnProgrammeinstellungen.Size = New System.Drawing.Size(229, 45)
        Me.btnProgrammeinstellungen.TabIndex = 5
        Me.btnProgrammeinstellungen.Text = "Einstellungen"
        Me.btnProgrammeinstellungen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgrammeinstellungen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
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
        Me.btnMeinBereich.Image = Global.GoGreen.My.Resources.Resources.outline_person_white_18dp
        Me.btnMeinBereich.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMeinBereich.Location = New System.Drawing.Point(0, 309)
        Me.btnMeinBereich.Name = "btnMeinBereich"
        Me.btnMeinBereich.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnMeinBereich.Size = New System.Drawing.Size(229, 45)
        Me.btnMeinBereich.TabIndex = 3
        Me.btnMeinBereich.Text = "Mein Bereich"
        Me.btnMeinBereich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMeinBereich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMeinBereich.UseVisualStyleBackColor = True
        '
        'panelGeschaefteSubmenu
        '
        Me.panelGeschaefteSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelGeschaefteSubmenu.Controls.Add(Me.btnBekleidungslaeden)
        Me.panelGeschaefteSubmenu.Controls.Add(Me.buttonSideMenuHinzufuegen)
        Me.panelGeschaefteSubmenu.Controls.Add(Me.buttonSideMenuStadtteile)
        Me.panelGeschaefteSubmenu.Controls.Add(Me.buttonSideMenuKategorien)
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
        'buttonSideMenuHinzufuegen
        '
        Me.buttonSideMenuHinzufuegen.Dock = System.Windows.Forms.DockStyle.Top
        Me.buttonSideMenuHinzufuegen.FlatAppearance.BorderSize = 0
        Me.buttonSideMenuHinzufuegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSideMenuHinzufuegen.ForeColor = System.Drawing.Color.LightGray
        Me.buttonSideMenuHinzufuegen.Location = New System.Drawing.Point(0, 80)
        Me.buttonSideMenuHinzufuegen.Name = "buttonSideMenuHinzufuegen"
        Me.buttonSideMenuHinzufuegen.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.buttonSideMenuHinzufuegen.Size = New System.Drawing.Size(229, 40)
        Me.buttonSideMenuHinzufuegen.TabIndex = 2
        Me.buttonSideMenuHinzufuegen.Text = "Hinzufügen"
        Me.buttonSideMenuHinzufuegen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonSideMenuHinzufuegen.UseVisualStyleBackColor = True
        '
        'buttonSideMenuStadtteile
        '
        Me.buttonSideMenuStadtteile.Dock = System.Windows.Forms.DockStyle.Top
        Me.buttonSideMenuStadtteile.FlatAppearance.BorderSize = 0
        Me.buttonSideMenuStadtteile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSideMenuStadtteile.ForeColor = System.Drawing.Color.LightGray
        Me.buttonSideMenuStadtteile.Location = New System.Drawing.Point(0, 40)
        Me.buttonSideMenuStadtteile.Name = "buttonSideMenuStadtteile"
        Me.buttonSideMenuStadtteile.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.buttonSideMenuStadtteile.Size = New System.Drawing.Size(229, 40)
        Me.buttonSideMenuStadtteile.TabIndex = 1
        Me.buttonSideMenuStadtteile.Text = "Stadtteile"
        Me.buttonSideMenuStadtteile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonSideMenuStadtteile.UseVisualStyleBackColor = True
        '
        'buttonSideMenuKategorien
        '
        Me.buttonSideMenuKategorien.Dock = System.Windows.Forms.DockStyle.Top
        Me.buttonSideMenuKategorien.FlatAppearance.BorderSize = 0
        Me.buttonSideMenuKategorien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSideMenuKategorien.ForeColor = System.Drawing.Color.LightGray
        Me.buttonSideMenuKategorien.Location = New System.Drawing.Point(0, 0)
        Me.buttonSideMenuKategorien.Name = "buttonSideMenuKategorien"
        Me.buttonSideMenuKategorien.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.buttonSideMenuKategorien.Size = New System.Drawing.Size(229, 40)
        Me.buttonSideMenuKategorien.TabIndex = 0
        Me.buttonSideMenuKategorien.Text = "Kategorien"
        Me.buttonSideMenuKategorien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonSideMenuKategorien.UseVisualStyleBackColor = True
        '
        'buttonSideMenuGeschaefte
        '
        Me.buttonSideMenuGeschaefte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.buttonSideMenuGeschaefte.Dock = System.Windows.Forms.DockStyle.Top
        Me.buttonSideMenuGeschaefte.FlatAppearance.BorderSize = 0
        Me.buttonSideMenuGeschaefte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSideMenuGeschaefte.ForeColor = System.Drawing.Color.LightGray
        Me.buttonSideMenuGeschaefte.Image = Global.GoGreen.My.Resources.Resources.outline_storefront_white_18dp
        Me.buttonSideMenuGeschaefte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.buttonSideMenuGeschaefte.Location = New System.Drawing.Point(0, 100)
        Me.buttonSideMenuGeschaefte.Name = "buttonSideMenuGeschaefte"
        Me.buttonSideMenuGeschaefte.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.buttonSideMenuGeschaefte.Size = New System.Drawing.Size(229, 45)
        Me.buttonSideMenuGeschaefte.TabIndex = 1
        Me.buttonSideMenuGeschaefte.Text = "Geschäfte"
        Me.buttonSideMenuGeschaefte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.buttonSideMenuGeschaefte.UseVisualStyleBackColor = True
        '
        'panelLogo
        '
        Me.panelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelLogo.Location = New System.Drawing.Point(0, 0)
        Me.panelLogo.Name = "panelLogo"
        Me.panelLogo.Size = New System.Drawing.Size(229, 100)
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
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(0, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(647, 550)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.webView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(639, 517)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(329, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'webView
        '
        Me.webView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.webView.CreationProperties = Nothing
        Me.webView.Location = New System.Drawing.Point(3, 13)
        Me.webView.Name = "webView"
        Me.webView.Size = New System.Drawing.Size(621, 440)
        Me.webView.Source = New System.Uri("C:\Users\simon\source\repos\GoGreen\GoGreen\Website\index.html", System.UriKind.Absolute)
        Me.webView.TabIndex = 4
        Me.webView.UseWaitCursor = True
        Me.webView.ZoomFactor = 1.0R
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LabelGeschäfteNachKategorien)
        Me.TabPage2.Controls.Add(Me.TreeViewGeschäfteKategorien)
        Me.TabPage2.Controls.Add(Me.btnbla)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(639, 517)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LabelGeschäfteNachKategorien
        '
        Me.LabelGeschäfteNachKategorien.AutoSize = True
        Me.LabelGeschäfteNachKategorien.Location = New System.Drawing.Point(49, 25)
        Me.LabelGeschäfteNachKategorien.Name = "LabelGeschäfteNachKategorien"
        Me.LabelGeschäfteNachKategorien.Size = New System.Drawing.Size(212, 20)
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.textBoxShopImageFileName)
        Me.TabPage3.Controls.Add(Me.buttonShopImageHinzufuegen)
        Me.TabPage3.Controls.Add(Me.comboBoxEinzelansichtStadtteile)
        Me.TabPage3.Controls.Add(Me.labelShopEinzelansichtOeffnungszeit)
        Me.TabPage3.Controls.Add(Me.labelShopEinzelansichtTelefonnummer)
        Me.TabPage3.Controls.Add(Me.labelShopEinzelansichtAdresse)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.labelShopEinzelansichtKategorie)
        Me.TabPage3.Controls.Add(Me.buttonShopHinzufuegen)
        Me.TabPage3.Controls.Add(Me.comboBoxEinzelansichtKategorie)
        Me.TabPage3.Controls.Add(Me.pictureBoxGeschaefteEinzelansichtsseite)
        Me.TabPage3.Controls.Add(Me.textBoxShopEinzelansichtOeffnungszeit)
        Me.TabPage3.Controls.Add(Me.textBoxShopEinzelansichtAdresse)
        Me.TabPage3.Controls.Add(Me.textBoxShopEinzelansichtTelefonnummer)
        Me.TabPage3.Controls.Add(Me.textBoxShopEinzelansichtKategorie)
        Me.TabPage3.Controls.Add(Me.textBoxShopEinzelansichtBezeichnung)
        Me.TabPage3.Location = New System.Drawing.Point(4, 29)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(639, 517)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'buttonShopImageHinzufuegen
        '
        Me.buttonShopImageHinzufuegen.BackColor = System.Drawing.Color.Transparent
        Me.buttonShopImageHinzufuegen.FlatAppearance.BorderSize = 0
        Me.buttonShopImageHinzufuegen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.buttonShopImageHinzufuegen.Image = Global.GoGreen.My.Resources.Resources.BildHinzufügen
        Me.buttonShopImageHinzufuegen.Location = New System.Drawing.Point(39, 10)
        Me.buttonShopImageHinzufuegen.Margin = New System.Windows.Forms.Padding(0)
        Me.buttonShopImageHinzufuegen.Name = "buttonShopImageHinzufuegen"
        Me.buttonShopImageHinzufuegen.Size = New System.Drawing.Size(67, 45)
        Me.buttonShopImageHinzufuegen.TabIndex = 15
        Me.buttonShopImageHinzufuegen.UseVisualStyleBackColor = False
        '
        'comboBoxEinzelansichtStadtteile
        '
        Me.comboBoxEinzelansichtStadtteile.FormattingEnabled = True
        Me.comboBoxEinzelansichtStadtteile.Location = New System.Drawing.Point(250, 374)
        Me.comboBoxEinzelansichtStadtteile.Name = "comboBoxEinzelansichtStadtteile"
        Me.comboBoxEinzelansichtStadtteile.Size = New System.Drawing.Size(193, 28)
        Me.comboBoxEinzelansichtStadtteile.TabIndex = 14
        '
        'labelShopEinzelansichtOeffnungszeit
        '
        Me.labelShopEinzelansichtOeffnungszeit.AutoSize = True
        Me.labelShopEinzelansichtOeffnungszeit.Location = New System.Drawing.Point(35, 405)
        Me.labelShopEinzelansichtOeffnungszeit.Name = "labelShopEinzelansichtOeffnungszeit"
        Me.labelShopEinzelansichtOeffnungszeit.Size = New System.Drawing.Size(104, 20)
        Me.labelShopEinzelansichtOeffnungszeit.TabIndex = 13
        Me.labelShopEinzelansichtOeffnungszeit.Text = "Öffnungszeit"
        '
        'labelShopEinzelansichtTelefonnummer
        '
        Me.labelShopEinzelansichtTelefonnummer.AutoSize = True
        Me.labelShopEinzelansichtTelefonnummer.Location = New System.Drawing.Point(35, 456)
        Me.labelShopEinzelansichtTelefonnummer.Name = "labelShopEinzelansichtTelefonnummer"
        Me.labelShopEinzelansichtTelefonnummer.Size = New System.Drawing.Size(125, 20)
        Me.labelShopEinzelansichtTelefonnummer.TabIndex = 12
        Me.labelShopEinzelansichtTelefonnummer.Text = "Telefonnummer"
        '
        'labelShopEinzelansichtAdresse
        '
        Me.labelShopEinzelansichtAdresse.AutoSize = True
        Me.labelShopEinzelansichtAdresse.Location = New System.Drawing.Point(35, 353)
        Me.labelShopEinzelansichtAdresse.Name = "labelShopEinzelansichtAdresse"
        Me.labelShopEinzelansichtAdresse.Size = New System.Drawing.Size(71, 20)
        Me.labelShopEinzelansichtAdresse.TabIndex = 11
        Me.labelShopEinzelansichtAdresse.Text = "Adresse"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(390, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Bezeichnung"
        '
        'labelShopEinzelansichtKategorie
        '
        Me.labelShopEinzelansichtKategorie.AutoSize = True
        Me.labelShopEinzelansichtKategorie.Location = New System.Drawing.Point(390, 113)
        Me.labelShopEinzelansichtKategorie.Name = "labelShopEinzelansichtKategorie"
        Me.labelShopEinzelansichtKategorie.Size = New System.Drawing.Size(80, 20)
        Me.labelShopEinzelansichtKategorie.TabIndex = 8
        Me.labelShopEinzelansichtKategorie.Text = "Kategorie"
        '
        'buttonShopHinzufuegen
        '
        Me.buttonShopHinzufuegen.Location = New System.Drawing.Point(443, 474)
        Me.buttonShopHinzufuegen.Name = "buttonShopHinzufuegen"
        Me.buttonShopHinzufuegen.Size = New System.Drawing.Size(193, 37)
        Me.buttonShopHinzufuegen.TabIndex = 7
        Me.buttonShopHinzufuegen.Text = "Shop hinzufügen"
        Me.buttonShopHinzufuegen.UseVisualStyleBackColor = True
        '
        'comboBoxEinzelansichtKategorie
        '
        Me.comboBoxEinzelansichtKategorie.FormattingEnabled = True
        Me.comboBoxEinzelansichtKategorie.Location = New System.Drawing.Point(394, 175)
        Me.comboBoxEinzelansichtKategorie.Name = "comboBoxEinzelansichtKategorie"
        Me.comboBoxEinzelansichtKategorie.Size = New System.Drawing.Size(193, 28)
        Me.comboBoxEinzelansichtKategorie.TabIndex = 6
        '
        'pictureBoxGeschaefteEinzelansichtsseite
        '
        Me.pictureBoxGeschaefteEinzelansichtsseite.ErrorImage = Global.GoGreen.My.Resources.Resources.Fehlerbild
        Me.pictureBoxGeschaefteEinzelansichtsseite.Location = New System.Drawing.Point(39, 68)
        Me.pictureBoxGeschaefteEinzelansichtsseite.Name = "pictureBoxGeschaefteEinzelansichtsseite"
        Me.pictureBoxGeschaefteEinzelansichtsseite.Size = New System.Drawing.Size(321, 256)
        Me.pictureBoxGeschaefteEinzelansichtsseite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxGeschaefteEinzelansichtsseite.TabIndex = 5
        Me.pictureBoxGeschaefteEinzelansichtsseite.TabStop = False
        '
        'textBoxShopEinzelansichtOeffnungszeit
        '
        Me.textBoxShopEinzelansichtOeffnungszeit.Location = New System.Drawing.Point(39, 427)
        Me.textBoxShopEinzelansichtOeffnungszeit.Name = "textBoxShopEinzelansichtOeffnungszeit"
        Me.textBoxShopEinzelansichtOeffnungszeit.ReadOnly = True
        Me.textBoxShopEinzelansichtOeffnungszeit.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtOeffnungszeit.TabIndex = 4
        '
        'textBoxShopEinzelansichtAdresse
        '
        Me.textBoxShopEinzelansichtAdresse.Location = New System.Drawing.Point(39, 376)
        Me.textBoxShopEinzelansichtAdresse.Name = "textBoxShopEinzelansichtAdresse"
        Me.textBoxShopEinzelansichtAdresse.ReadOnly = True
        Me.textBoxShopEinzelansichtAdresse.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtAdresse.TabIndex = 3
        '
        'textBoxShopEinzelansichtTelefonnummer
        '
        Me.textBoxShopEinzelansichtTelefonnummer.Location = New System.Drawing.Point(39, 479)
        Me.textBoxShopEinzelansichtTelefonnummer.Name = "textBoxShopEinzelansichtTelefonnummer"
        Me.textBoxShopEinzelansichtTelefonnummer.ReadOnly = True
        Me.textBoxShopEinzelansichtTelefonnummer.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtTelefonnummer.TabIndex = 2
        '
        'textBoxShopEinzelansichtKategorie
        '
        Me.textBoxShopEinzelansichtKategorie.Location = New System.Drawing.Point(394, 143)
        Me.textBoxShopEinzelansichtKategorie.Name = "textBoxShopEinzelansichtKategorie"
        Me.textBoxShopEinzelansichtKategorie.ReadOnly = True
        Me.textBoxShopEinzelansichtKategorie.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtKategorie.TabIndex = 1
        '
        'textBoxShopEinzelansichtBezeichnung
        '
        Me.textBoxShopEinzelansichtBezeichnung.Location = New System.Drawing.Point(394, 68)
        Me.textBoxShopEinzelansichtBezeichnung.Name = "textBoxShopEinzelansichtBezeichnung"
        Me.textBoxShopEinzelansichtBezeichnung.ReadOnly = True
        Me.textBoxShopEinzelansichtBezeichnung.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtBezeichnung.TabIndex = 0
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LabelGeschäfteNachStadtteilen)
        Me.TabPage4.Controls.Add(Me.TreeViewGeschäfteStadtteile)
        Me.TabPage4.Location = New System.Drawing.Point(4, 29)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(639, 517)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'LabelGeschäfteNachStadtteilen
        '
        Me.LabelGeschäfteNachStadtteilen.AutoSize = True
        Me.LabelGeschäfteNachStadtteilen.Location = New System.Drawing.Point(49, 25)
        Me.LabelGeschäfteNachStadtteilen.Name = "LabelGeschäfteNachStadtteilen"
        Me.LabelGeschäfteNachStadtteilen.Size = New System.Drawing.Size(211, 20)
        Me.LabelGeschäfteNachStadtteilen.TabIndex = 6
        Me.LabelGeschäfteNachStadtteilen.Text = "Geschäfte nach Stadtteilen"
        '
        'TreeViewGeschäfteStadtteile
        '
        Me.TreeViewGeschäfteStadtteile.Location = New System.Drawing.Point(49, 58)
        Me.TreeViewGeschäfteStadtteile.Name = "TreeViewGeschäfteStadtteile"
        Me.TreeViewGeschäfteStadtteile.Size = New System.Drawing.Size(205, 368)
        Me.TreeViewGeschäfteStadtteile.TabIndex = 5
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
        'textBoxShopImageFileName
        '
        Me.textBoxShopImageFileName.Location = New System.Drawing.Point(166, 32)
        Me.textBoxShopImageFileName.Name = "textBoxShopImageFileName"
        Me.textBoxShopImageFileName.ReadOnly = True
        Me.textBoxShopImageFileName.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopImageFileName.TabIndex = 16
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
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
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.pictureBoxGeschaefteEinzelansichtsseite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.PictureBoxMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSideMenu As Panel
    Friend WithEvents panelGeschaefteSubmenu As Panel
    Friend WithEvents buttonSideMenuKategorien As Button
    Friend WithEvents buttonSideMenuGeschaefte As Button
    Friend WithEvents panelLogo As Panel
    Friend WithEvents btnBekleidungslaeden As Button
    Friend WithEvents buttonSideMenuHinzufuegen As Button
    Friend WithEvents buttonSideMenuStadtteile As Button

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
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnbla As Button
    Friend WithEvents TreeViewGeschäfteKategorien As TreeView
    Friend WithEvents LabelGeschäfteNachKategorien As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents textBoxShopEinzelansichtBezeichnung As TextBox
    Friend WithEvents textBoxShopEinzelansichtAdresse As TextBox
    Friend WithEvents textBoxShopEinzelansichtTelefonnummer As TextBox
    Friend WithEvents textBoxShopEinzelansichtKategorie As TextBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents LabelGeschäfteNachStadtteilen As Label
    Friend WithEvents TreeViewGeschäfteStadtteile As TreeView
    Friend WithEvents Button1 As Button
    Friend WithEvents textBoxShopEinzelansichtOeffnungszeit As TextBox
    Friend WithEvents pictureBoxGeschaefteEinzelansichtsseite As PictureBox
    Friend WithEvents comboBoxEinzelansichtKategorie As ComboBox
    Friend WithEvents buttonShopHinzufuegen As Button
    Friend WithEvents labelShopEinzelansichtKategorie As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents labelShopEinzelansichtOeffnungszeit As Label
    Friend WithEvents labelShopEinzelansichtTelefonnummer As Label
    Friend WithEvents labelShopEinzelansichtAdresse As Label
    Friend WithEvents comboBoxEinzelansichtStadtteile As ComboBox
    Friend WithEvents buttonShopImageHinzufuegen As Button
    Friend WithEvents textBoxShopImageFileName As TextBox
End Class
