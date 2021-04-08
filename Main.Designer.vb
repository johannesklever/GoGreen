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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.panelSideMenu = New System.Windows.Forms.Panel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.btnProgrammeinstellungen = New System.Windows.Forms.Button()
        Me.panelMeinBereichSubMenu = New System.Windows.Forms.Panel()
        Me.btnUserSettings = New System.Windows.Forms.Button()
        Me.btnFavorit = New System.Windows.Forms.Button()
        Me.btnMeinBereich = New System.Windows.Forms.Button()
        Me.panelGeschaefteSubmenu = New System.Windows.Forms.Panel()
        Me.btnMap = New System.Windows.Forms.Button()
        Me.buttonSideMenuHinzufuegen = New System.Windows.Forms.Button()
        Me.buttonSideMenuStadtteile = New System.Windows.Forms.Button()
        Me.buttonSideMenuKategorien = New System.Windows.Forms.Button()
        Me.buttonSideMenuGeschaefte = New System.Windows.Forms.Button()
        Me.panelLogo = New System.Windows.Forms.Panel()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPageMap = New System.Windows.Forms.TabPage()
        Me.GMap1 = New GMap.NET.WindowsForms.GMapControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LabelGeschäfteNachKategorien = New System.Windows.Forms.Label()
        Me.TreeViewGeschäfteKategorien = New System.Windows.Forms.TreeView()
        Me.btnbla = New System.Windows.Forms.Button()
        Me.TabPageShopEinzelansicht = New System.Windows.Forms.TabPage()
        Me.textBoxShopEinzelansichtLängengrad = New System.Windows.Forms.TextBox()
        Me.textBoxShopEinzelansichtBreitengrad = New System.Windows.Forms.TextBox()
        Me.labelShopEinzelansichtBreitengrad = New System.Windows.Forms.Label()
        Me.labelShopEinzelansichtLängengrad = New System.Windows.Forms.Label()
        Me.WebView2 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.ButtonFavoritenHinzufügen = New System.Windows.Forms.Button()
        Me.ImageFavoritStern = New System.Windows.Forms.PictureBox()
        Me.labelShopImageErrorBildNachricht = New System.Windows.Forms.Label()
        Me.buttonShopAenderungenSpeichern = New System.Windows.Forms.Button()
        Me.labelShopEinzelansichtStadtteil = New System.Windows.Forms.Label()
        Me.textBoxShopEinzelansichtStadtteil = New System.Windows.Forms.TextBox()
        Me.buttonShopBearbeiten = New System.Windows.Forms.Button()
        Me.textBoxShopImageFileName = New System.Windows.Forms.TextBox()
        Me.comboBoxEinzelansichtStadtteile = New System.Windows.Forms.ComboBox()
        Me.labelShopEinzelansichtOeffnungszeit = New System.Windows.Forms.Label()
        Me.labelShopEinzelansichtTelefonnummer = New System.Windows.Forms.Label()
        Me.labelShopEinzelansichtAdresse = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelShopEinzelansichtKategorie = New System.Windows.Forms.Label()
        Me.buttonShopHinzufuegen = New System.Windows.Forms.Button()
        Me.comboBoxEinzelansichtKategorie = New System.Windows.Forms.ComboBox()
        Me.textBoxShopEinzelansichtOeffnungszeit = New System.Windows.Forms.TextBox()
        Me.textBoxShopEinzelansichtAdresse = New System.Windows.Forms.TextBox()
        Me.textBoxShopEinzelansichtTelefonnummer = New System.Windows.Forms.TextBox()
        Me.textBoxShopEinzelansichtKategorie = New System.Windows.Forms.TextBox()
        Me.textBoxShopEinzelansichtBezeichnung = New System.Windows.Forms.TextBox()
        Me.buttonShopImageHinzufuegen = New System.Windows.Forms.Button()
        Me.pictureBoxGeschaefteEinzelansichtsseite = New System.Windows.Forms.PictureBox()
        Me.TabPageStadtteile = New System.Windows.Forms.TabPage()
        Me.LabelGeschäfteNachStadtteilen = New System.Windows.Forms.Label()
        Me.TreeViewGeschäfteStadtteile = New System.Windows.Forms.TreeView()
        Me.TabPageUser = New System.Windows.Forms.TabPage()
        Me.ButtonUserRelease = New System.Windows.Forms.Button()
        Me.TextBoxUserPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxUserAdress = New System.Windows.Forms.TextBox()
        Me.TextBoxUserBirthdate = New System.Windows.Forms.TextBox()
        Me.TextBoxUserPhone = New System.Windows.Forms.TextBox()
        Me.TextBoxUserUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxUserName = New System.Windows.Forms.TextBox()
        Me.LabelUserAdress = New System.Windows.Forms.Label()
        Me.LabelUserBirthdate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabelUserUsername = New System.Windows.Forms.Label()
        Me.LabelUserName = New System.Windows.Forms.Label()
        Me.ButtonUserSavePhone = New System.Windows.Forms.Button()
        Me.TabPageFavorit = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ListBoxFavoriten = New System.Windows.Forms.ListBox()
        Me.PictureBoxMap = New System.Windows.Forms.PictureBox()
        Me.comboBoxMapSeiteKategorien = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.comboBoxMapSeiteStadtteile = New System.Windows.Forms.ComboBox()
        Me.comboBoxMapSeiteGeschäfte = New System.Windows.Forms.ComboBox()
        Me.buttonMapSeiteZumShop = New System.Windows.Forms.Button()
        Me.panelSideMenu.SuspendLayout()
        Me.panelMeinBereichSubMenu.SuspendLayout()
        Me.panelGeschaefteSubmenu.SuspendLayout()
        Me.panelContent.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.TabPageMap.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPageShopEinzelansicht.SuspendLayout()
        CType(Me.WebView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImageFavoritStern, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pictureBoxGeschaefteEinzelansichtsseite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageStadtteile.SuspendLayout()
        Me.TabPageUser.SuspendLayout()
        Me.TabPageFavorit.SuspendLayout()
        CType(Me.PictureBoxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
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
        Me.panelSideMenu.Size = New System.Drawing.Size(250, 703)
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
        Me.btnHelp.Location = New System.Drawing.Point(0, 534)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnHelp.Size = New System.Drawing.Size(250, 45)
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
        Me.btnAbout.Location = New System.Drawing.Point(0, 489)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnAbout.Size = New System.Drawing.Size(250, 45)
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
        Me.btnProgrammeinstellungen.Location = New System.Drawing.Point(0, 444)
        Me.btnProgrammeinstellungen.Name = "btnProgrammeinstellungen"
        Me.btnProgrammeinstellungen.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.btnProgrammeinstellungen.Size = New System.Drawing.Size(250, 45)
        Me.btnProgrammeinstellungen.TabIndex = 5
        Me.btnProgrammeinstellungen.Text = "Einstellungen"
        Me.btnProgrammeinstellungen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProgrammeinstellungen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnProgrammeinstellungen.UseVisualStyleBackColor = True
        '
        'panelMeinBereichSubMenu
        '
        Me.panelMeinBereichSubMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelMeinBereichSubMenu.Controls.Add(Me.btnUserSettings)
        Me.panelMeinBereichSubMenu.Controls.Add(Me.btnFavorit)
        Me.panelMeinBereichSubMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelMeinBereichSubMenu.Location = New System.Drawing.Point(0, 354)
        Me.panelMeinBereichSubMenu.Name = "panelMeinBereichSubMenu"
        Me.panelMeinBereichSubMenu.Size = New System.Drawing.Size(250, 90)
        Me.panelMeinBereichSubMenu.TabIndex = 4
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
        Me.btnUserSettings.Size = New System.Drawing.Size(250, 40)
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
        Me.btnFavorit.Size = New System.Drawing.Size(250, 40)
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
        Me.btnMeinBereich.Size = New System.Drawing.Size(250, 45)
        Me.btnMeinBereich.TabIndex = 3
        Me.btnMeinBereich.Text = "Mein Bereich"
        Me.btnMeinBereich.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMeinBereich.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnMeinBereich.UseVisualStyleBackColor = True
        '
        'panelGeschaefteSubmenu
        '
        Me.panelGeschaefteSubmenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.panelGeschaefteSubmenu.Controls.Add(Me.btnMap)
        Me.panelGeschaefteSubmenu.Controls.Add(Me.buttonSideMenuHinzufuegen)
        Me.panelGeschaefteSubmenu.Controls.Add(Me.buttonSideMenuStadtteile)
        Me.panelGeschaefteSubmenu.Controls.Add(Me.buttonSideMenuKategorien)
        Me.panelGeschaefteSubmenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelGeschaefteSubmenu.Location = New System.Drawing.Point(0, 145)
        Me.panelGeschaefteSubmenu.Name = "panelGeschaefteSubmenu"
        Me.panelGeschaefteSubmenu.Size = New System.Drawing.Size(250, 164)
        Me.panelGeschaefteSubmenu.TabIndex = 2
        '
        'btnMap
        '
        Me.btnMap.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMap.FlatAppearance.BorderSize = 0
        Me.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMap.ForeColor = System.Drawing.Color.LightGray
        Me.btnMap.Location = New System.Drawing.Point(0, 120)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.btnMap.Size = New System.Drawing.Size(250, 40)
        Me.btnMap.TabIndex = 3
        Me.btnMap.Text = "Map"
        Me.btnMap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMap.UseVisualStyleBackColor = True
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
        Me.buttonSideMenuHinzufuegen.Size = New System.Drawing.Size(250, 40)
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
        Me.buttonSideMenuStadtteile.Size = New System.Drawing.Size(250, 40)
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
        Me.buttonSideMenuKategorien.Size = New System.Drawing.Size(250, 40)
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
        Me.buttonSideMenuGeschaefte.Size = New System.Drawing.Size(250, 45)
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
        Me.panelLogo.Size = New System.Drawing.Size(250, 100)
        Me.panelLogo.TabIndex = 0
        '
        'panelContent
        '
        Me.panelContent.Controls.Add(Me.TabControl)
        Me.panelContent.Controls.Add(Me.PictureBoxMap)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(285, 0)
        Me.panelContent.Margin = New System.Windows.Forms.Padding(0)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(797, 703)
        Me.panelContent.TabIndex = 9
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.TabPageMap)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Controls.Add(Me.TabPageShopEinzelansicht)
        Me.TabControl.Controls.Add(Me.TabPageStadtteile)
        Me.TabControl.Controls.Add(Me.TabPageUser)
        Me.TabControl.Controls.Add(Me.TabPageFavorit)
        Me.TabControl.Location = New System.Drawing.Point(0, 3)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(797, 700)
        Me.TabControl.TabIndex = 5
        Me.TabControl.TabStop = False
        '
        'TabPageMap
        '
        Me.TabPageMap.Controls.Add(Me.buttonMapSeiteZumShop)
        Me.TabPageMap.Controls.Add(Me.comboBoxMapSeiteGeschäfte)
        Me.TabPageMap.Controls.Add(Me.Panel1)
        Me.TabPageMap.Controls.Add(Me.GMap1)
        Me.TabPageMap.Location = New System.Drawing.Point(4, 29)
        Me.TabPageMap.Margin = New System.Windows.Forms.Padding(0)
        Me.TabPageMap.Name = "TabPageMap"
        Me.TabPageMap.Size = New System.Drawing.Size(789, 667)
        Me.TabPageMap.TabIndex = 0
        Me.TabPageMap.Text = "Map"
        Me.TabPageMap.UseVisualStyleBackColor = True
        '
        'GMap1
        '
        Me.GMap1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GMap1.Bearing = 0!
        Me.GMap1.CanDragMap = True
        Me.GMap1.EmptyTileColor = System.Drawing.Color.Navy
        Me.GMap1.GrayScaleMode = False
        Me.GMap1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow
        Me.GMap1.LevelsKeepInMemory = 5
        Me.GMap1.Location = New System.Drawing.Point(17, 113)
        Me.GMap1.MarkersEnabled = True
        Me.GMap1.MaxZoom = 2
        Me.GMap1.MinZoom = 2
        Me.GMap1.MouseWheelZoomEnabled = True
        Me.GMap1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter
        Me.GMap1.Name = "GMap1"
        Me.GMap1.NegativeMode = False
        Me.GMap1.PolygonsEnabled = True
        Me.GMap1.RetryLoadTile = 0
        Me.GMap1.RoutesEnabled = True
        Me.GMap1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.[Integer]
        Me.GMap1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GMap1.ShowTileGridLines = False
        Me.GMap1.Size = New System.Drawing.Size(746, 533)
        Me.GMap1.TabIndex = 6
        Me.GMap1.Zoom = 0R
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LabelGeschäfteNachKategorien)
        Me.TabPage2.Controls.Add(Me.TreeViewGeschäfteKategorien)
        Me.TabPage2.Controls.Add(Me.btnbla)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(789, 667)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Kategorien"
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
        'TabPageShopEinzelansicht
        '
        Me.TabPageShopEinzelansicht.Controls.Add(Me.textBoxShopEinzelansichtLängengrad)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.textBoxShopEinzelansichtBreitengrad)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.labelShopEinzelansichtBreitengrad)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.labelShopEinzelansichtLängengrad)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.WebView2)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.ButtonFavoritenHinzufügen)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.ImageFavoritStern)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.labelShopImageErrorBildNachricht)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.buttonShopAenderungenSpeichern)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.labelShopEinzelansichtStadtteil)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.textBoxShopEinzelansichtStadtteil)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.buttonShopBearbeiten)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.textBoxShopImageFileName)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.comboBoxEinzelansichtStadtteile)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.labelShopEinzelansichtOeffnungszeit)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.labelShopEinzelansichtTelefonnummer)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.labelShopEinzelansichtAdresse)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.Label1)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.labelShopEinzelansichtKategorie)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.buttonShopHinzufuegen)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.comboBoxEinzelansichtKategorie)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.textBoxShopEinzelansichtOeffnungszeit)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.textBoxShopEinzelansichtAdresse)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.textBoxShopEinzelansichtTelefonnummer)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.textBoxShopEinzelansichtKategorie)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.textBoxShopEinzelansichtBezeichnung)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.buttonShopImageHinzufuegen)
        Me.TabPageShopEinzelansicht.Controls.Add(Me.pictureBoxGeschaefteEinzelansichtsseite)
        Me.TabPageShopEinzelansicht.Location = New System.Drawing.Point(4, 29)
        Me.TabPageShopEinzelansicht.Name = "TabPageShopEinzelansicht"
        Me.TabPageShopEinzelansicht.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageShopEinzelansicht.Size = New System.Drawing.Size(789, 667)
        Me.TabPageShopEinzelansicht.TabIndex = 2
        Me.TabPageShopEinzelansicht.Text = "Shop Einzelansicht"
        Me.TabPageShopEinzelansicht.UseVisualStyleBackColor = True
        '
        'textBoxShopEinzelansichtLängengrad
        '
        Me.textBoxShopEinzelansichtLängengrad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxShopEinzelansichtLängengrad.Location = New System.Drawing.Point(283, 585)
        Me.textBoxShopEinzelansichtLängengrad.Name = "textBoxShopEinzelansichtLängengrad"
        Me.textBoxShopEinzelansichtLängengrad.ReadOnly = True
        Me.textBoxShopEinzelansichtLängengrad.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtLängengrad.TabIndex = 28
        '
        'textBoxShopEinzelansichtBreitengrad
        '
        Me.textBoxShopEinzelansichtBreitengrad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxShopEinzelansichtBreitengrad.Location = New System.Drawing.Point(549, 585)
        Me.textBoxShopEinzelansichtBreitengrad.Name = "textBoxShopEinzelansichtBreitengrad"
        Me.textBoxShopEinzelansichtBreitengrad.ReadOnly = True
        Me.textBoxShopEinzelansichtBreitengrad.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtBreitengrad.TabIndex = 27
        '
        'labelShopEinzelansichtBreitengrad
        '
        Me.labelShopEinzelansichtBreitengrad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelShopEinzelansichtBreitengrad.AutoSize = True
        Me.labelShopEinzelansichtBreitengrad.Location = New System.Drawing.Point(545, 563)
        Me.labelShopEinzelansichtBreitengrad.Name = "labelShopEinzelansichtBreitengrad"
        Me.labelShopEinzelansichtBreitengrad.Size = New System.Drawing.Size(96, 20)
        Me.labelShopEinzelansichtBreitengrad.TabIndex = 26
        Me.labelShopEinzelansichtBreitengrad.Text = "Breitengrad"
        '
        'labelShopEinzelansichtLängengrad
        '
        Me.labelShopEinzelansichtLängengrad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelShopEinzelansichtLängengrad.AutoSize = True
        Me.labelShopEinzelansichtLängengrad.Location = New System.Drawing.Point(279, 563)
        Me.labelShopEinzelansichtLängengrad.Name = "labelShopEinzelansichtLängengrad"
        Me.labelShopEinzelansichtLängengrad.Size = New System.Drawing.Size(97, 20)
        Me.labelShopEinzelansichtLängengrad.TabIndex = 25
        Me.labelShopEinzelansichtLängengrad.Text = "Längengrad"
        '
        'WebView2
        '
        Me.WebView2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebView2.CreationProperties = Nothing
        Me.WebView2.Location = New System.Drawing.Point(273, 353)
        Me.WebView2.Name = "WebView2"
        Me.WebView2.Size = New System.Drawing.Size(510, 204)
        Me.WebView2.Source = New System.Uri("https://www.laengengrad-breitengrad.de/", System.UriKind.Absolute)
        Me.WebView2.TabIndex = 24
        Me.WebView2.ZoomFactor = 1.0R
        '
        'ButtonFavoritenHinzufügen
        '
        Me.ButtonFavoritenHinzufügen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFavoritenHinzufügen.Location = New System.Drawing.Point(385, 624)
        Me.ButtonFavoritenHinzufügen.Name = "ButtonFavoritenHinzufügen"
        Me.ButtonFavoritenHinzufügen.Size = New System.Drawing.Size(199, 37)
        Me.ButtonFavoritenHinzufügen.TabIndex = 23
        Me.ButtonFavoritenHinzufügen.Text = "Zu Favoriten hinzufügen"
        Me.ButtonFavoritenHinzufügen.UseVisualStyleBackColor = True
        '
        'ImageFavoritStern
        '
        Me.ImageFavoritStern.Image = CType(resources.GetObject("ImageFavoritStern.Image"), System.Drawing.Image)
        Me.ImageFavoritStern.Location = New System.Drawing.Point(573, 5)
        Me.ImageFavoritStern.Name = "ImageFavoritStern"
        Me.ImageFavoritStern.Size = New System.Drawing.Size(60, 57)
        Me.ImageFavoritStern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ImageFavoritStern.TabIndex = 22
        Me.ImageFavoritStern.TabStop = False
        '
        'labelShopImageErrorBildNachricht
        '
        Me.labelShopImageErrorBildNachricht.AutoSize = True
        Me.labelShopImageErrorBildNachricht.Location = New System.Drawing.Point(35, 327)
        Me.labelShopImageErrorBildNachricht.Name = "labelShopImageErrorBildNachricht"
        Me.labelShopImageErrorBildNachricht.Size = New System.Drawing.Size(0, 20)
        Me.labelShopImageErrorBildNachricht.TabIndex = 21
        Me.labelShopImageErrorBildNachricht.Visible = False
        '
        'buttonShopAenderungenSpeichern
        '
        Me.buttonShopAenderungenSpeichern.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonShopAenderungenSpeichern.Location = New System.Drawing.Point(593, 624)
        Me.buttonShopAenderungenSpeichern.Name = "buttonShopAenderungenSpeichern"
        Me.buttonShopAenderungenSpeichern.Size = New System.Drawing.Size(193, 37)
        Me.buttonShopAenderungenSpeichern.TabIndex = 20
        Me.buttonShopAenderungenSpeichern.Text = "Änderung Speichern"
        Me.buttonShopAenderungenSpeichern.UseVisualStyleBackColor = True
        Me.buttonShopAenderungenSpeichern.Visible = False
        '
        'labelShopEinzelansichtStadtteil
        '
        Me.labelShopEinzelansichtStadtteil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelShopEinzelansichtStadtteil.AutoSize = True
        Me.labelShopEinzelansichtStadtteil.Location = New System.Drawing.Point(36, 511)
        Me.labelShopEinzelansichtStadtteil.Name = "labelShopEinzelansichtStadtteil"
        Me.labelShopEinzelansichtStadtteil.Size = New System.Drawing.Size(70, 20)
        Me.labelShopEinzelansichtStadtteil.TabIndex = 19
        Me.labelShopEinzelansichtStadtteil.Text = "Stadtteil"
        '
        'textBoxShopEinzelansichtStadtteil
        '
        Me.textBoxShopEinzelansichtStadtteil.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textBoxShopEinzelansichtStadtteil.Location = New System.Drawing.Point(39, 531)
        Me.textBoxShopEinzelansichtStadtteil.Name = "textBoxShopEinzelansichtStadtteil"
        Me.textBoxShopEinzelansichtStadtteil.ReadOnly = True
        Me.textBoxShopEinzelansichtStadtteil.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtStadtteil.TabIndex = 18
        '
        'buttonShopBearbeiten
        '
        Me.buttonShopBearbeiten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonShopBearbeiten.Location = New System.Drawing.Point(593, 624)
        Me.buttonShopBearbeiten.Name = "buttonShopBearbeiten"
        Me.buttonShopBearbeiten.Size = New System.Drawing.Size(193, 37)
        Me.buttonShopBearbeiten.TabIndex = 17
        Me.buttonShopBearbeiten.Text = "Bearbeiten"
        Me.buttonShopBearbeiten.UseVisualStyleBackColor = True
        '
        'textBoxShopImageFileName
        '
        Me.textBoxShopImageFileName.Location = New System.Drawing.Point(166, 32)
        Me.textBoxShopImageFileName.Name = "textBoxShopImageFileName"
        Me.textBoxShopImageFileName.ReadOnly = True
        Me.textBoxShopImageFileName.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopImageFileName.TabIndex = 16
        '
        'comboBoxEinzelansichtStadtteile
        '
        Me.comboBoxEinzelansichtStadtteile.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.comboBoxEinzelansichtStadtteile.FormattingEnabled = True
        Me.comboBoxEinzelansichtStadtteile.Location = New System.Drawing.Point(39, 563)
        Me.comboBoxEinzelansichtStadtteile.Name = "comboBoxEinzelansichtStadtteile"
        Me.comboBoxEinzelansichtStadtteile.Size = New System.Drawing.Size(193, 28)
        Me.comboBoxEinzelansichtStadtteile.TabIndex = 14
        '
        'labelShopEinzelansichtOeffnungszeit
        '
        Me.labelShopEinzelansichtOeffnungszeit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelShopEinzelansichtOeffnungszeit.AutoSize = True
        Me.labelShopEinzelansichtOeffnungszeit.Location = New System.Drawing.Point(35, 405)
        Me.labelShopEinzelansichtOeffnungszeit.Name = "labelShopEinzelansichtOeffnungszeit"
        Me.labelShopEinzelansichtOeffnungszeit.Size = New System.Drawing.Size(104, 20)
        Me.labelShopEinzelansichtOeffnungszeit.TabIndex = 13
        Me.labelShopEinzelansichtOeffnungszeit.Text = "Öffnungszeit"
        '
        'labelShopEinzelansichtTelefonnummer
        '
        Me.labelShopEinzelansichtTelefonnummer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelShopEinzelansichtTelefonnummer.AutoSize = True
        Me.labelShopEinzelansichtTelefonnummer.Location = New System.Drawing.Point(35, 456)
        Me.labelShopEinzelansichtTelefonnummer.Name = "labelShopEinzelansichtTelefonnummer"
        Me.labelShopEinzelansichtTelefonnummer.Size = New System.Drawing.Size(125, 20)
        Me.labelShopEinzelansichtTelefonnummer.TabIndex = 12
        Me.labelShopEinzelansichtTelefonnummer.Text = "Telefonnummer"
        '
        'labelShopEinzelansichtAdresse
        '
        Me.labelShopEinzelansichtAdresse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.labelShopEinzelansichtAdresse.AutoSize = True
        Me.labelShopEinzelansichtAdresse.Location = New System.Drawing.Point(35, 353)
        Me.labelShopEinzelansichtAdresse.Name = "labelShopEinzelansichtAdresse"
        Me.labelShopEinzelansichtAdresse.Size = New System.Drawing.Size(71, 20)
        Me.labelShopEinzelansichtAdresse.TabIndex = 11
        Me.labelShopEinzelansichtAdresse.Text = "Adresse"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(390, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Bezeichnung"
        '
        'labelShopEinzelansichtKategorie
        '
        Me.labelShopEinzelansichtKategorie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelShopEinzelansichtKategorie.AutoSize = True
        Me.labelShopEinzelansichtKategorie.Location = New System.Drawing.Point(390, 113)
        Me.labelShopEinzelansichtKategorie.Name = "labelShopEinzelansichtKategorie"
        Me.labelShopEinzelansichtKategorie.Size = New System.Drawing.Size(80, 20)
        Me.labelShopEinzelansichtKategorie.TabIndex = 8
        Me.labelShopEinzelansichtKategorie.Text = "Kategorie"
        '
        'buttonShopHinzufuegen
        '
        Me.buttonShopHinzufuegen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.buttonShopHinzufuegen.Location = New System.Drawing.Point(590, 624)
        Me.buttonShopHinzufuegen.Name = "buttonShopHinzufuegen"
        Me.buttonShopHinzufuegen.Size = New System.Drawing.Size(193, 37)
        Me.buttonShopHinzufuegen.TabIndex = 7
        Me.buttonShopHinzufuegen.Text = "Shop hinzufügen"
        Me.buttonShopHinzufuegen.UseVisualStyleBackColor = True
        '
        'comboBoxEinzelansichtKategorie
        '
        Me.comboBoxEinzelansichtKategorie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboBoxEinzelansichtKategorie.FormattingEnabled = True
        Me.comboBoxEinzelansichtKategorie.Location = New System.Drawing.Point(394, 175)
        Me.comboBoxEinzelansichtKategorie.Name = "comboBoxEinzelansichtKategorie"
        Me.comboBoxEinzelansichtKategorie.Size = New System.Drawing.Size(193, 28)
        Me.comboBoxEinzelansichtKategorie.TabIndex = 6
        '
        'textBoxShopEinzelansichtOeffnungszeit
        '
        Me.textBoxShopEinzelansichtOeffnungszeit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textBoxShopEinzelansichtOeffnungszeit.Location = New System.Drawing.Point(39, 427)
        Me.textBoxShopEinzelansichtOeffnungszeit.Name = "textBoxShopEinzelansichtOeffnungszeit"
        Me.textBoxShopEinzelansichtOeffnungszeit.ReadOnly = True
        Me.textBoxShopEinzelansichtOeffnungszeit.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtOeffnungszeit.TabIndex = 4
        '
        'textBoxShopEinzelansichtAdresse
        '
        Me.textBoxShopEinzelansichtAdresse.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textBoxShopEinzelansichtAdresse.Location = New System.Drawing.Point(39, 376)
        Me.textBoxShopEinzelansichtAdresse.Name = "textBoxShopEinzelansichtAdresse"
        Me.textBoxShopEinzelansichtAdresse.ReadOnly = True
        Me.textBoxShopEinzelansichtAdresse.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtAdresse.TabIndex = 3
        '
        'textBoxShopEinzelansichtTelefonnummer
        '
        Me.textBoxShopEinzelansichtTelefonnummer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.textBoxShopEinzelansichtTelefonnummer.Location = New System.Drawing.Point(39, 479)
        Me.textBoxShopEinzelansichtTelefonnummer.Name = "textBoxShopEinzelansichtTelefonnummer"
        Me.textBoxShopEinzelansichtTelefonnummer.ReadOnly = True
        Me.textBoxShopEinzelansichtTelefonnummer.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtTelefonnummer.TabIndex = 2
        '
        'textBoxShopEinzelansichtKategorie
        '
        Me.textBoxShopEinzelansichtKategorie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxShopEinzelansichtKategorie.Location = New System.Drawing.Point(394, 143)
        Me.textBoxShopEinzelansichtKategorie.Name = "textBoxShopEinzelansichtKategorie"
        Me.textBoxShopEinzelansichtKategorie.ReadOnly = True
        Me.textBoxShopEinzelansichtKategorie.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtKategorie.TabIndex = 1
        '
        'textBoxShopEinzelansichtBezeichnung
        '
        Me.textBoxShopEinzelansichtBezeichnung.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxShopEinzelansichtBezeichnung.Location = New System.Drawing.Point(394, 68)
        Me.textBoxShopEinzelansichtBezeichnung.Name = "textBoxShopEinzelansichtBezeichnung"
        Me.textBoxShopEinzelansichtBezeichnung.ReadOnly = True
        Me.textBoxShopEinzelansichtBezeichnung.Size = New System.Drawing.Size(193, 26)
        Me.textBoxShopEinzelansichtBezeichnung.TabIndex = 0
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
        'pictureBoxGeschaefteEinzelansichtsseite
        '
        Me.pictureBoxGeschaefteEinzelansichtsseite.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pictureBoxGeschaefteEinzelansichtsseite.ErrorImage = Global.GoGreen.My.Resources.Resources.Fehlerbild
        Me.pictureBoxGeschaefteEinzelansichtsseite.Location = New System.Drawing.Point(39, 68)
        Me.pictureBoxGeschaefteEinzelansichtsseite.Name = "pictureBoxGeschaefteEinzelansichtsseite"
        Me.pictureBoxGeschaefteEinzelansichtsseite.Size = New System.Drawing.Size(321, 256)
        Me.pictureBoxGeschaefteEinzelansichtsseite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBoxGeschaefteEinzelansichtsseite.TabIndex = 5
        Me.pictureBoxGeschaefteEinzelansichtsseite.TabStop = False
        '
        'TabPageStadtteile
        '
        Me.TabPageStadtteile.Controls.Add(Me.LabelGeschäfteNachStadtteilen)
        Me.TabPageStadtteile.Controls.Add(Me.TreeViewGeschäfteStadtteile)
        Me.TabPageStadtteile.Location = New System.Drawing.Point(4, 29)
        Me.TabPageStadtteile.Name = "TabPageStadtteile"
        Me.TabPageStadtteile.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageStadtteile.Size = New System.Drawing.Size(789, 667)
        Me.TabPageStadtteile.TabIndex = 3
        Me.TabPageStadtteile.Text = "Stadtteile"
        Me.TabPageStadtteile.UseVisualStyleBackColor = True
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
        'TabPageUser
        '
        Me.TabPageUser.Controls.Add(Me.ButtonUserRelease)
        Me.TabPageUser.Controls.Add(Me.TextBoxUserPassword)
        Me.TabPageUser.Controls.Add(Me.Label3)
        Me.TabPageUser.Controls.Add(Me.TextBoxUserAdress)
        Me.TabPageUser.Controls.Add(Me.TextBoxUserBirthdate)
        Me.TabPageUser.Controls.Add(Me.TextBoxUserPhone)
        Me.TabPageUser.Controls.Add(Me.TextBoxUserUsername)
        Me.TabPageUser.Controls.Add(Me.TextBoxUserName)
        Me.TabPageUser.Controls.Add(Me.LabelUserAdress)
        Me.TabPageUser.Controls.Add(Me.LabelUserBirthdate)
        Me.TabPageUser.Controls.Add(Me.Label2)
        Me.TabPageUser.Controls.Add(Me.LabelUserUsername)
        Me.TabPageUser.Controls.Add(Me.LabelUserName)
        Me.TabPageUser.Controls.Add(Me.ButtonUserSavePhone)
        Me.TabPageUser.Location = New System.Drawing.Point(4, 29)
        Me.TabPageUser.Name = "TabPageUser"
        Me.TabPageUser.Size = New System.Drawing.Size(789, 667)
        Me.TabPageUser.TabIndex = 4
        Me.TabPageUser.Text = "User"
        Me.TabPageUser.UseVisualStyleBackColor = True
        '
        'ButtonUserRelease
        '
        Me.ButtonUserRelease.Location = New System.Drawing.Point(58, 431)
        Me.ButtonUserRelease.Name = "ButtonUserRelease"
        Me.ButtonUserRelease.Size = New System.Drawing.Size(133, 35)
        Me.ButtonUserRelease.TabIndex = 14
        Me.ButtonUserRelease.Text = "freigeben"
        Me.ButtonUserRelease.UseVisualStyleBackColor = True
        '
        'TextBoxUserPassword
        '
        Me.TextBoxUserPassword.Location = New System.Drawing.Point(339, 359)
        Me.TextBoxUserPassword.Name = "TextBoxUserPassword"
        Me.TextBoxUserPassword.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxUserPassword.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Passwort:"
        '
        'TextBoxUserAdress
        '
        Me.TextBoxUserAdress.Location = New System.Drawing.Point(339, 289)
        Me.TextBoxUserAdress.Name = "TextBoxUserAdress"
        Me.TextBoxUserAdress.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxUserAdress.TabIndex = 11
        '
        'TextBoxUserBirthdate
        '
        Me.TextBoxUserBirthdate.Location = New System.Drawing.Point(339, 230)
        Me.TextBoxUserBirthdate.Name = "TextBoxUserBirthdate"
        Me.TextBoxUserBirthdate.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxUserBirthdate.TabIndex = 10
        '
        'TextBoxUserPhone
        '
        Me.TextBoxUserPhone.Location = New System.Drawing.Point(339, 166)
        Me.TextBoxUserPhone.Name = "TextBoxUserPhone"
        Me.TextBoxUserPhone.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxUserPhone.TabIndex = 9
        '
        'TextBoxUserUsername
        '
        Me.TextBoxUserUsername.Location = New System.Drawing.Point(339, 94)
        Me.TextBoxUserUsername.Name = "TextBoxUserUsername"
        Me.TextBoxUserUsername.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxUserUsername.TabIndex = 8
        '
        'TextBoxUserName
        '
        Me.TextBoxUserName.Location = New System.Drawing.Point(339, 33)
        Me.TextBoxUserName.Name = "TextBoxUserName"
        Me.TextBoxUserName.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxUserName.TabIndex = 7
        '
        'LabelUserAdress
        '
        Me.LabelUserAdress.AutoSize = True
        Me.LabelUserAdress.Location = New System.Drawing.Point(54, 296)
        Me.LabelUserAdress.Name = "LabelUserAdress"
        Me.LabelUserAdress.Size = New System.Drawing.Size(76, 20)
        Me.LabelUserAdress.TabIndex = 5
        Me.LabelUserAdress.Text = "Adresse:"
        '
        'LabelUserBirthdate
        '
        Me.LabelUserBirthdate.AutoSize = True
        Me.LabelUserBirthdate.Location = New System.Drawing.Point(54, 230)
        Me.LabelUserBirthdate.Name = "LabelUserBirthdate"
        Me.LabelUserBirthdate.Size = New System.Drawing.Size(120, 20)
        Me.LabelUserBirthdate.TabIndex = 4
        Me.LabelUserBirthdate.Text = "Geburtsdatum:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Telefon:"
        '
        'LabelUserUsername
        '
        Me.LabelUserUsername.AutoSize = True
        Me.LabelUserUsername.Location = New System.Drawing.Point(54, 97)
        Me.LabelUserUsername.Name = "LabelUserUsername"
        Me.LabelUserUsername.Size = New System.Drawing.Size(123, 20)
        Me.LabelUserUsername.TabIndex = 2
        Me.LabelUserUsername.Text = "Benutzername:"
        '
        'LabelUserName
        '
        Me.LabelUserName.AutoSize = True
        Me.LabelUserName.Location = New System.Drawing.Point(54, 33)
        Me.LabelUserName.Name = "LabelUserName"
        Me.LabelUserName.Size = New System.Drawing.Size(58, 20)
        Me.LabelUserName.TabIndex = 1
        Me.LabelUserName.Text = "Name:"
        '
        'ButtonUserSavePhone
        '
        Me.ButtonUserSavePhone.Location = New System.Drawing.Point(307, 431)
        Me.ButtonUserSavePhone.Name = "ButtonUserSavePhone"
        Me.ButtonUserSavePhone.Size = New System.Drawing.Size(132, 35)
        Me.ButtonUserSavePhone.TabIndex = 0
        Me.ButtonUserSavePhone.Text = "Ändern"
        Me.ButtonUserSavePhone.UseVisualStyleBackColor = True
        '
        'TabPageFavorit
        '
        Me.TabPageFavorit.Controls.Add(Me.Label4)
        Me.TabPageFavorit.Controls.Add(Me.ListBoxFavoriten)
        Me.TabPageFavorit.Location = New System.Drawing.Point(4, 29)
        Me.TabPageFavorit.Name = "TabPageFavorit"
        Me.TabPageFavorit.Size = New System.Drawing.Size(789, 667)
        Me.TabPageFavorit.TabIndex = 5
        Me.TabPageFavorit.Text = "Favoriten"
        Me.TabPageFavorit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Hier siehst du deine Lieblingsgeschäfte:"
        '
        'ListBoxFavoriten
        '
        Me.ListBoxFavoriten.FormattingEnabled = True
        Me.ListBoxFavoriten.ItemHeight = 20
        Me.ListBoxFavoriten.Location = New System.Drawing.Point(148, 137)
        Me.ListBoxFavoriten.Name = "ListBoxFavoriten"
        Me.ListBoxFavoriten.Size = New System.Drawing.Size(328, 124)
        Me.ListBoxFavoriten.TabIndex = 0
        '
        'PictureBoxMap
        '
        Me.PictureBoxMap.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBoxMap.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxMap.Name = "PictureBoxMap"
        Me.PictureBoxMap.Size = New System.Drawing.Size(797, 703)
        Me.PictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxMap.TabIndex = 0
        Me.PictureBoxMap.TabStop = False
        '
        'comboBoxMapSeiteKategorien
        '
        Me.comboBoxMapSeiteKategorien.FormattingEnabled = True
        Me.comboBoxMapSeiteKategorien.Location = New System.Drawing.Point(3, 3)
        Me.comboBoxMapSeiteKategorien.Name = "comboBoxMapSeiteKategorien"
        Me.comboBoxMapSeiteKategorien.Size = New System.Drawing.Size(208, 28)
        Me.comboBoxMapSeiteKategorien.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.comboBoxMapSeiteStadtteile)
        Me.Panel1.Controls.Add(Me.comboBoxMapSeiteKategorien)
        Me.Panel1.Location = New System.Drawing.Point(30, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(652, 63)
        Me.Panel1.TabIndex = 8
        '
        'comboBoxMapSeiteStadtteile
        '
        Me.comboBoxMapSeiteStadtteile.FormattingEnabled = True
        Me.comboBoxMapSeiteStadtteile.Location = New System.Drawing.Point(220, 3)
        Me.comboBoxMapSeiteStadtteile.Name = "comboBoxMapSeiteStadtteile"
        Me.comboBoxMapSeiteStadtteile.Size = New System.Drawing.Size(208, 28)
        Me.comboBoxMapSeiteStadtteile.TabIndex = 8
        '
        'comboBoxMapSeiteGeschäfte
        '
        Me.comboBoxMapSeiteGeschäfte.FormattingEnabled = True
        Me.comboBoxMapSeiteGeschäfte.Location = New System.Drawing.Point(464, 27)
        Me.comboBoxMapSeiteGeschäfte.Name = "comboBoxMapSeiteGeschäfte"
        Me.comboBoxMapSeiteGeschäfte.Size = New System.Drawing.Size(208, 28)
        Me.comboBoxMapSeiteGeschäfte.TabIndex = 9
        '
        'buttonMapSeiteZumShop
        '
        Me.buttonMapSeiteZumShop.Location = New System.Drawing.Point(700, 24)
        Me.buttonMapSeiteZumShop.Name = "buttonMapSeiteZumShop"
        Me.buttonMapSeiteZumShop.Size = New System.Drawing.Size(63, 63)
        Me.buttonMapSeiteZumShop.TabIndex = 10
        Me.buttonMapSeiteZumShop.Text = "Zum Shop"
        Me.buttonMapSeiteZumShop.UseVisualStyleBackColor = True
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 703)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelSideMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(1100, 750)
        Me.Name = "FormMain"
        Me.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Text = "FormMain"
        Me.panelSideMenu.ResumeLayout(False)
        Me.panelMeinBereichSubMenu.ResumeLayout(False)
        Me.panelGeschaefteSubmenu.ResumeLayout(False)
        Me.panelContent.ResumeLayout(False)
        Me.TabControl.ResumeLayout(False)
        Me.TabPageMap.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPageShopEinzelansicht.ResumeLayout(False)
        Me.TabPageShopEinzelansicht.PerformLayout()
        CType(Me.WebView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImageFavoritStern, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pictureBoxGeschaefteEinzelansichtsseite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageStadtteile.ResumeLayout(False)
        Me.TabPageStadtteile.PerformLayout()
        Me.TabPageUser.ResumeLayout(False)
        Me.TabPageUser.PerformLayout()
        Me.TabPageFavorit.ResumeLayout(False)
        Me.TabPageFavorit.PerformLayout()
        CType(Me.PictureBoxMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelSideMenu As Panel
    Friend WithEvents panelGeschaefteSubmenu As Panel
    Friend WithEvents buttonSideMenuKategorien As Button
    Friend WithEvents buttonSideMenuGeschaefte As Button
    Friend WithEvents panelLogo As Panel
    Friend WithEvents btnMap As Button
    Friend WithEvents buttonSideMenuHinzufuegen As Button
    Friend WithEvents buttonSideMenuStadtteile As Button

    Friend WithEvents btnHelp As Button
    Friend WithEvents btnAbout As Button
    Friend WithEvents btnProgrammeinstellungen As Button
    Friend WithEvents panelMeinBereichSubMenu As Panel
    Friend WithEvents btnUserSettings As Button
    Friend WithEvents btnFavorit As Button
    Friend WithEvents btnMeinBereich As Button

    Friend WithEvents panelContent As Panel
    Friend WithEvents PictureBoxMap As PictureBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPageMap As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnbla As Button
    Friend WithEvents TreeViewGeschäfteKategorien As TreeView
    Friend WithEvents LabelGeschäfteNachKategorien As Label
    Friend WithEvents TabPageShopEinzelansicht As TabPage
    Friend WithEvents textBoxShopEinzelansichtBezeichnung As TextBox
    Friend WithEvents textBoxShopEinzelansichtAdresse As TextBox
    Friend WithEvents textBoxShopEinzelansichtTelefonnummer As TextBox
    Friend WithEvents textBoxShopEinzelansichtKategorie As TextBox
    Friend WithEvents TabPageStadtteile As TabPage
    Friend WithEvents LabelGeschäfteNachStadtteilen As Label
    Friend WithEvents TreeViewGeschäfteStadtteile As TreeView
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
    Friend WithEvents buttonShopBearbeiten As Button
    Friend WithEvents labelShopEinzelansichtStadtteil As Label
    Friend WithEvents textBoxShopEinzelansichtStadtteil As TextBox
    Friend WithEvents buttonShopAenderungenSpeichern As Button
    Friend WithEvents TabPageUser As TabPage
    Friend WithEvents labelShopImageErrorBildNachricht As Label
    Friend WithEvents TextBoxUserAdress As TextBox
    Friend WithEvents TextBoxUserBirthdate As TextBox
    Friend WithEvents TextBoxUserPhone As TextBox
    Friend WithEvents TextBoxUserUsername As TextBox
    Friend WithEvents TextBoxUserName As TextBox
    Friend WithEvents LabelUserAdress As Label
    Friend WithEvents LabelUserBirthdate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelUserUsername As Label
    Friend WithEvents LabelUserName As Label
    Friend WithEvents ButtonUserSavePhone As Button
    Friend WithEvents TextBoxUserPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ButtonUserRelease As Button
    Friend WithEvents TabPageFavorit As TabPage
    Friend WithEvents Label4 As Label
    Friend WithEvents ListBoxFavoriten As ListBox
    Friend WithEvents ImageFavoritStern As PictureBox
    Friend WithEvents ButtonFavoritenHinzufügen As Button
    Friend WithEvents GMap1 As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents WebView2 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents textBoxShopEinzelansichtLängengrad As TextBox
    Friend WithEvents textBoxShopEinzelansichtBreitengrad As TextBox
    Friend WithEvents labelShopEinzelansichtBreitengrad As Label
    Friend WithEvents labelShopEinzelansichtLängengrad As Label
    Friend WithEvents buttonMapSeiteZumShop As Button
    Friend WithEvents comboBoxMapSeiteGeschäfte As ComboBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents comboBoxMapSeiteStadtteile As ComboBox
    Friend WithEvents comboBoxMapSeiteKategorien As ComboBox
End Class
