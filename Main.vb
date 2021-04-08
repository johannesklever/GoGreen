Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.NET.WindowsForms.Markers

Public Class FormMain


    Dim rsKategorien As ADODB.Recordset
    Dim rsStadtteile As ADODB.Recordset
    Dim rsBearbeiten As ADODB.Recordset
    Dim conn As ADODB.Connection
    Dim rsGeschaefte As ADODB.Recordset
    Dim rsFavoriten As ADODB.Recordset
    Dim rsFavoritenID As ADODB.Recordset
    Dim TestID As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelGeschaefteSubmenu.Visible = False
        panelMeinBereichSubMenu.Visible = False

        rsKategorien = New ADODB.Recordset
        rsStadtteile = New ADODB.Recordset
        rsGeschaefte = New ADODB.Recordset
        rsBearbeiten = New ADODB.Recordset
        rsFavoriten = New ADODB.Recordset


        Try

            conn = New ADODB.Connection
            conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;“ & "Data Source=GoGreen.accdb")

            rsKategorien.Open("SELECT * FROM Kategorien",
                            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            rsGeschaefte.Open("SELECT * FROM Geschäfte",
                            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            rsStadtteile.Open("SELECT * FROM Stadtteile",
                            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            rsBearbeiten.Open("SELECT * FROM Kunde",
                            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            rsFavoriten.Open("SELECT Bezeichnung FROM Geschäfte, Lieblingsgeschäfte WHERE Geschäfte.Geschäfts_ID = Lieblingsgeschäfte.Geschäfts_ID AND Kunden_ID=" & Übergabe.LoggedUserID,
                           conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        GMap1.Position = New GMap.NET.PointLatLng(47.6618, 9.48)

        GMap1.MaxZoom = 18
        GMap1.MinZoom = 0
        GMap1.Zoom = 12

        comboBoxMapSeiteKategorien.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxMapSeiteStadtteile.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxMapSeiteGeschäfte.DropDownStyle = ComboBoxStyle.DropDownList

        rsKategorien.MoveFirst()
        rsStadtteile.MoveFirst()
        rsGeschaefte.MoveFirst()
        comboBoxMapSeiteKategorien.Items.Add("")
        Do While Not rsKategorien.EOF
            comboBoxMapSeiteKategorien.Items.Add(rsKategorien.Fields("Kat_Bezeichnung").Value)
            rsKategorien.MoveNext()
        Loop

        comboBoxMapSeiteStadtteile.Items.Add("")
        Do While Not rsStadtteile.EOF
            comboBoxMapSeiteStadtteile.Items.Add(rsStadtteile.Fields("Bezeichnung").Value)
            rsStadtteile.MoveNext()
        Loop

        Do While Not rsGeschaefte.EOF
            comboBoxMapSeiteGeschäfte.Items.Add(rsGeschaefte.Fields("Bezeichnung").Value)
            rsGeschaefte.MoveNext()
        Loop

        LadeMap(rsGeschaefte)

    End Sub


    Sub LadeMap(ByVal rsGeschäfte As ADODB.Recordset)


        GMap1.ReloadMap()

        GMap1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.CacheOnly
        'GMap1.SetPositionByKeywords("Friedrichsafen, Deutschland")
        GMap1.ShowCenter = False
        Dim markers As GMap.NET.WindowsForms.GMapOverlay = New GMap.NET.WindowsForms.GMapOverlay("markers")
        Try
            rsGeschäfte.MoveFirst()


            For i = 1 To rsGeschäfte.RecordCount
                If IsDBNull(rsGeschäfte.Fields("Längengrad").Value) And IsDBNull(rsGeschäfte.Fields("Breitengrad").Value) Then 'wenn Längen und Breitengrad vorhanden, dann Marker erzeugen

                Else
                    Dim laengengrad As Double = CDbl(Val(rsGeschäfte.Fields("Längengrad").Value))
                    Dim breitengrad As Double = CDbl(Val(rsGeschäfte.Fields("Breitengrad").Value))

                    Dim marker As GMap.NET.WindowsForms.GMapMarker = New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New GMap.NET.PointLatLng(laengengrad, breitengrad), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin)
                    marker.ToolTipText = rsGeschäfte.Fields("Bezeichnung").Value
                    marker.Tag = rsGeschäfte.Fields("Geschäfts_ID").Value
                    markers.Markers.Add(marker)
                End If
                rsGeschäfte.MoveNext()
            Next
            GMap1.Overlays.Add(markers)
            GMap1.Zoom = 13

        Catch

        End Try



    End Sub




    Private Sub Toggle(ByVal panel As Panel) 'Übergabe des Panels
        With panel
            If .Visible = False Then
                .Visible = True
            Else
                .Visible = False
            End If
        End With
    End Sub

    Private Sub btnGeschaefte_Click(sender As Object, e As EventArgs) Handles buttonSideMenuGeschaefte.Click

        Toggle(panelGeschaefteSubmenu)  'das Panel wird aufgedeckt oder versteckt, sodass Untermenü sichtbar ist oder nicht

    End Sub

    Private Sub btnMeinBereich_Click(sender As Object, e As EventArgs) Handles btnMeinBereich.Click

        Dim UserIDCONV As String
        UserIDCONV = CStr(Übergabe.LoggedUserID)
        rsBearbeiten.Find("Kunden_ID =" & "'" & UserIDCONV & "'")

        If UserIDCONV = 0 Then
            FormKeinBenutzer.Show()
        Else
            Toggle(panelMeinBereichSubMenu)
        End If


    End Sub

    Private Sub buttonSideMenuKategorien_Click(sender As Object, e As EventArgs) Handles buttonSideMenuKategorien.Click

        TabControl.SelectedIndex = 1

        Dim rsGeschaefteNachKategorie = New ADODB.Recordset
        'Dim rsGeschaefte As New ADODB.Recordset

        TreeViewGeschäfteKategorien.Nodes.Clear() 'verhindert, dass sich TreeView nach jedem Click verlängert
        rsKategorien.MoveFirst()
        Do While Not rsKategorien.EOF
            Dim ndTop = TreeViewGeschäfteKategorien.Nodes.Add(rsKategorien.Fields("Kat_Bezeichnung").Value)
            rsGeschaefteNachKategorie.Open("SELECT * FROM Geschäfte WHERE Kategorie_ID = " & rsKategorien.Fields("Kategorie_ID").Value,
                        conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

            If rsGeschaefteNachKategorie.RecordCount > 0 Then
                Do While Not rsGeschaefteNachKategorie.EOF
                    ndTop.Nodes.Add(rsGeschaefteNachKategorie.Fields("Bezeichnung").Value)
                    rsGeschaefteNachKategorie.MoveNext()
                Loop
            End If
            rsGeschaefteNachKategorie.Close()
            rsKategorien.MoveNext()
        Loop

    End Sub

    Private Sub btnSideMenuStadtteile_Click(sender As Object, e As EventArgs) Handles buttonSideMenuStadtteile.Click

        Dim rsGeschaefteNachStadtteilen = New ADODB.Recordset

        TabControl.SelectedIndex = 3

        'Treeview Geschäfte nach Stadtteilen
        TreeViewGeschäfteStadtteile.Nodes.Clear() 'verhindert, dass sich TreeView nach jedem Click verlängert
        rsStadtteile.MoveFirst()
        Do While Not rsStadtteile.EOF
            Dim ndTop = TreeViewGeschäfteStadtteile.Nodes.Add(rsStadtteile.Fields("Bezeichnung").Value)
            rsGeschaefteNachStadtteilen.Open("SELECT * FROM Geschäfte WHERE Stadtteil_ID = " & rsStadtteile.Fields("ID").Value,
                        conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

            If rsGeschaefteNachStadtteilen.RecordCount > 0 Then '´nur ausführen, wenn Datenbankeinträge gibt
                Do While Not rsGeschaefteNachStadtteilen.EOF
                    ndTop.Nodes.Add(rsGeschaefteNachStadtteilen.Fields("Bezeichnung").Value)
                    rsGeschaefteNachStadtteilen.MoveNext()
                Loop
            End If
            rsGeschaefteNachStadtteilen.Close()
            rsStadtteile.MoveNext()
        Loop

    End Sub

    Private Sub TreeViewGeschäfteKategorien_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewGeschäfteKategorien.AfterSelect

        TreeViewZuGeschaeftseinzelansichtsseite(TreeViewGeschäfteKategorien)

    End Sub

    Private Sub TreeViewGeschäfteStadtteile_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewGeschäfteStadtteile.AfterSelect

        TreeViewZuGeschaeftseinzelansichtsseite(TreeViewGeschäfteStadtteile)

    End Sub

    Private Sub TreeViewZuGeschaeftseinzelansichtsseite(ByVal treeView As TreeView)

        Dim geschaeftsBezeichnung As String
        TabControl.SelectedTab = TabPageShopEinzelansicht
        geschaeftsBezeichnung = treeView.SelectedNode.Text 'der angeklickte Shop wird an die Einzelansichtsseite übergeben
        Call GeschäfteLaden(geschaeftsBezeichnung)
        TestID = geschaeftsBezeichnung


    End Sub

    Private Sub btnSideMenuHinzufuegenClick(sender As Object, e As EventArgs) Handles buttonSideMenuHinzufuegen.Click

        'alte Einträge löschen
        textBoxShopEinzelansichtOeffnungszeit.Clear()
        textBoxShopEinzelansichtTelefonnummer.Clear()
        textBoxShopEinzelansichtAdresse.Clear()
        textBoxShopEinzelansichtBezeichnung.Clear()
        textBoxShopImageFileName.Clear()
        buttonShopHinzufuegen.Show()
        buttonShopAenderungenSpeichern.Hide()
        pictureBoxGeschaefteEinzelansichtsseite.Hide() 'verhindert, dass Bild beim Wechsel von der Einzelansichtsseite bestehen bleibt

        ShopBearbeitenundHinzufügen()

    End Sub

    Private Sub ShopBearbeitenundHinzufügen() 'Diese Sub wird angewendet um die Einzelansichtsseite zum Bearbeiten oder Hinzufügen eines Shops vorzubereiten

        TabControl.SelectedIndex = 2

        textBoxShopEinzelansichtKategorie.Hide()
        textBoxShopEinzelansichtStadtteil.Hide()
        comboBoxEinzelansichtKategorie.Items.Clear()
        comboBoxEinzelansichtStadtteile.Items.Clear()
        WebView2.Show()
        labelShopEinzelansichtBreitengrad.Show()
        labelShopEinzelansichtLängengrad.Show()
        textBoxShopEinzelansichtLängengrad.Show()
        textBoxShopEinzelansichtBreitengrad.Show()
        'Textfelder beschreibbar machen
        textBoxShopEinzelansichtBezeichnung.ReadOnly = False
        textBoxShopEinzelansichtAdresse.ReadOnly = False
        textBoxShopEinzelansichtOeffnungszeit.ReadOnly = False
        textBoxShopEinzelansichtTelefonnummer.ReadOnly = False
        textBoxShopEinzelansichtLängengrad.ReadOnly = False
        textBoxShopEinzelansichtBreitengrad.ReadOnly = False
        'pictureBoxGeschaefteEinzelansichtsseite.ImageLocation = "GeschäfteBilder\BildHinzufügen.png"

        comboBoxEinzelansichtKategorie.Show()
        comboBoxEinzelansichtStadtteile.Show()
        textBoxShopImageFileName.Show()
        buttonShopImageHinzufuegen.Show()

        buttonShopBearbeiten.Hide()


        'Dropdownlist nicht beschreibbar machen
        comboBoxEinzelansichtKategorie.DropDownStyle = ComboBoxStyle.DropDownList
        comboBoxEinzelansichtStadtteile.DropDownStyle = ComboBoxStyle.DropDownList

        rsKategorien.MoveFirst()
        rsStadtteile.MoveFirst()
        Do While Not rsKategorien.EOF
            comboBoxEinzelansichtKategorie.Items.Add(rsKategorien.Fields("Kat_Bezeichnung").Value)
            rsKategorien.MoveNext()
        Loop

        Do While Not rsStadtteile.EOF
            comboBoxEinzelansichtStadtteile.Items.Add(rsStadtteile.Fields("Bezeichnung").Value)
            rsStadtteile.MoveNext()
        Loop
    End Sub

    Private Sub buttonShopHinzufuegen_Click(sender As Object, e As EventArgs) Handles buttonShopHinzufuegen.Click


        rsGeschaefte.MoveFirst()
        rsGeschaefte.AddNew()
        ShopInformationenDatenbankHochladen() 'wird beim Ändern und Hinzufügen eines Shops ausgeführt
        MsgBox("Geschäft hinzugefügt")



        textBoxShopEinzelansichtAdresse.Clear()
        textBoxShopEinzelansichtBezeichnung.Clear()
        textBoxShopEinzelansichtOeffnungszeit.Clear()
        textBoxShopEinzelansichtTelefonnummer.Clear()
        comboBoxEinzelansichtKategorie.ResetText()
        comboBoxEinzelansichtStadtteile.ResetText()

    End Sub

    Sub ShopInformationenDatenbankHochladen() 'wird ausgeführt, wenn ein Geschäft angelegt wurde oder bearbeitet wurde

        'löschen des vorherigen Bildes aus dem Projektverzeichnis
        Try
            My.Computer.FileSystem.DeleteFile("GeschäfteBilder\" & rsGeschaefte.Fields("Geschäftsbild").Value)
        Catch ex As Exception

        End Try

        'Kopieren des Bildes in Programmverzeichnis
        Dim SourceFile, DestinationFile As String
        SourceFile = pictureBoxGeschaefteEinzelansichtsseite.ImageLocation   ' Define source file name.
        DestinationFile = "GeschäfteBilder\" & textBoxShopImageFileName.Text
        Try
            FileCopy(SourceFile, DestinationFile)   ' Copy source to target.
        Catch ex As Exception

        End Try
        Dim rsAktuelleKategorieID As New ADODB.Recordset 'zur Ermittlung der KategorienID über die ausgewählte Kategorienbezeichung in der Combobox
        Dim rsAktuellerStadtteilID As New ADODB.Recordset 'zur Ermittlung der StadtteilID über den ausgewählten Stadtteil in der Combobox

        Try
            rsAktuelleKategorieID.Open("SELECT Kategorie_ID FROM Kategorien WHERE Kat_Bezeichnung = " & "'" & comboBoxEinzelansichtKategorie.SelectedItem & "'",
                                        conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            rsAktuellerStadtteilID.Open("SELECT ID FROM Stadtteile WHERE Bezeichnung = " & "'" & comboBoxEinzelansichtStadtteile.SelectedItem & "'",
                                        conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            rsGeschaefte.Fields("Bezeichnung").Value = textBoxShopEinzelansichtBezeichnung.Text
            rsGeschaefte.Fields("Adresse").Value = textBoxShopEinzelansichtAdresse.Text
            rsGeschaefte.Fields("Öffnungszeiten").Value = textBoxShopEinzelansichtOeffnungszeit.Text
            rsGeschaefte.Fields("Telefon").Value = textBoxShopEinzelansichtTelefonnummer.Text
            rsGeschaefte.Fields("Kategorie_ID").Value = rsAktuelleKategorieID.Fields("Kategorie_ID").Value
            rsGeschaefte.Fields("Stadtteil_ID").Value = rsAktuellerStadtteilID.Fields("ID").Value
            rsGeschaefte.Fields("Geschäftsbild").Value = textBoxShopImageFileName.Text
            rsGeschaefte.Fields("Längengrad").Value = textBoxShopEinzelansichtLängengrad.Text
            rsGeschaefte.Fields("Breitengrad").Value = textBoxShopEinzelansichtBreitengrad.Text

            rsGeschaefte.Update()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        textBoxShopEinzelansichtBreitengrad.Hide()
        textBoxShopEinzelansichtLängengrad.Hide()
        labelShopEinzelansichtLängengrad.Hide()
        labelShopEinzelansichtBreitengrad.Hide()
        WebView2.Hide()
        WebView2.Reload()
        textBoxShopEinzelansichtAdresse.ReadOnly = True
        textBoxShopEinzelansichtBezeichnung.ReadOnly = True
        textBoxShopEinzelansichtOeffnungszeit.ReadOnly = True
        textBoxShopEinzelansichtTelefonnummer.ReadOnly = True

    End Sub

    Private Sub buttonShopImageHinzufuegen_Click(sender As Object, e As EventArgs) Handles buttonShopImageHinzufuegen.Click

        Dim openFileDialogShopImage As New OpenFileDialog() 'öffnet Dateiexplorer

        openFileDialogShopImage.InitialDirectory = "c\"
        openFileDialogShopImage.Filter = "All files (*.*)|*.*|jpeg files (*.jpeg)|*.jpeg|png files (*.png)|*.png|jpg files (*.jpg)|*.jpg" 'zugelassene File Typen
        openFileDialogShopImage.FilterIndex = 2
        openFileDialogShopImage.RestoreDirectory = True
        openFileDialogShopImage.Title = "Bild auswählen"

        If openFileDialogShopImage.ShowDialog() = System.Windows.Forms.DialogResult.OK Then  'wenn Bild ausgewählt wurde
            pictureBoxGeschaefteEinzelansichtsseite.ImageLocation = openFileDialogShopImage.FileName '
            textBoxShopImageFileName.Text = openFileDialogShopImage.SafeFileName 'zeigt den Filename des aktuellen Fotos an
            pictureBoxGeschaefteEinzelansichtsseite.Show() 'zeigt die Picturebox wieder mit einem neuen Foto
        End If

    End Sub

    Private Sub buttonShopBearbeiten_Click(sender As Object, e As EventArgs) Handles buttonShopBearbeiten.Click

        ShopBearbeitenundHinzufügen()
        Try
            textBoxShopEinzelansichtLängengrad.Text = rsGeschaefte.Fields("Längengrad").Value
            textBoxShopEinzelansichtBreitengrad.Text = rsGeschaefte.Fields("Breitengrad").Value
        Catch
        End Try
        buttonShopAenderungenSpeichern.Show()
        Try
            textBoxShopImageFileName.Text = rsGeschaefte.Fields("Geschäftsbild").Value
        Catch
        End Try
        comboBoxEinzelansichtKategorie.SelectedItem = textBoxShopEinzelansichtKategorie.Text
        comboBoxEinzelansichtStadtteile.SelectedItem = textBoxShopEinzelansichtStadtteil.Text

    End Sub

    Private Sub buttonShopAenderungenSpeichern_Click(sender As Object, e As EventArgs) Handles buttonShopAenderungenSpeichern.Click


        'Update der Datenbank nachdem Änderung gespeichert wurde
        ShopInformationenDatenbankHochladen()


        buttonShopAenderungenSpeichern.Hide()
        buttonShopBearbeiten.Show()
        buttonShopImageHinzufuegen.Hide()
        comboBoxEinzelansichtKategorie.Hide()
        comboBoxEinzelansichtStadtteile.Hide()
        textBoxShopEinzelansichtKategorie.Show()
        textBoxShopEinzelansichtStadtteil.Show()
        textBoxShopImageFileName.Hide()

    End Sub

    Private Sub btnUserSettings_Click(sender As Object, e As EventArgs) Handles btnUserSettings.Click 'Lädt die Daten des eingeloggten Users
        Dim UserIDCONV As String
        UserIDCONV = CStr(Übergabe.LoggedUserID)
        rsBearbeiten.Find("Kunden_ID =" & "'" & UserIDCONV & "'")

        If UserIDCONV = 0 Then
            Me.Close()
            FormKeinBenutzer.Show()
        Else
            TabControl.SelectedTab = TabPageUser
            TextBoxUserAdress.Text = rsBearbeiten.Fields("Anschrift").Value
            TextBoxUserPhone.Text = rsBearbeiten.Fields("Telefon").Value
            TextBoxUserBirthdate.Text = rsBearbeiten.Fields("Geburtsdatum").Value
            TextBoxUserName.Text = rsBearbeiten.Fields("Name").Value
            TextBoxUserUsername.Text = rsBearbeiten.Fields("Benutzername").Value
            TextBoxUserPassword.Text = rsBearbeiten.Fields("Passwort").Value

            TextBoxUserPhone.ReadOnly = True
            TextBoxUserAdress.ReadOnly = True
            TextBoxUserBirthdate.ReadOnly = True
            TextBoxUserName.ReadOnly = True
            TextBoxUserPassword.ReadOnly = True
            TextBoxUserUsername.ReadOnly = True
        End If




    End Sub

    Private Sub pictureBoxGeschaefteEinzelansichtsseite_MouseHover(sender As Object, e As EventArgs) Handles pictureBoxGeschaefteEinzelansichtsseite.MouseHover
        labelShopImageErrorBildNachricht.Show()
        If pictureBoxGeschaefteEinzelansichtsseite.ImageLocation = "GeschäfteBilder\" Then
            labelShopImageErrorBildNachricht.Text = "Fehler beim Laden des Bildes oder kein Bild hinterlegt in der Datenbank!"
        End If
    End Sub

    Private Sub pictureBoxGeschaefteEinzelansichtsseite_MouseLeave(sender As Object, e As EventArgs) Handles pictureBoxGeschaefteEinzelansichtsseite.MouseLeave
        labelShopImageErrorBildNachricht.Hide()
    End Sub

    Private Sub ButtonUserSavePhone_Click(sender As Object, e As EventArgs) Handles ButtonUserSavePhone.Click 'wenn Daten des eingeloggten Users bearbeitet wurden
        Dim UserIDCONV As String
        UserIDCONV = CStr(Übergabe.LoggedUserID)
        rsBearbeiten.Find("Kunden_ID =" & "'" & UserIDCONV & "'")
        rsBearbeiten.Fields("Telefon").Value = TextBoxUserPhone.Text
        rsBearbeiten.Fields("Anschrift").Value = TextBoxUserAdress.Text
        rsBearbeiten.Fields("Name").Value = TextBoxUserName.Text
        rsBearbeiten.Fields("Benutzername").Value = TextBoxUserPassword.Text
        rsBearbeiten.Fields("Passwort").Value = TextBoxUserPassword.Text
        rsBearbeiten.Fields("Geburtsdatum").Value = TextBoxUserBirthdate.Text
        rsBearbeiten.Update()


    End Sub

    Private Sub ButtonUserRelease_Click(sender As Object, e As EventArgs) Handles ButtonUserRelease.Click
        TextBoxUserPhone.ReadOnly = False
        TextBoxUserAdress.ReadOnly = False
        TextBoxUserBirthdate.ReadOnly = False
        TextBoxUserName.ReadOnly = False
        TextBoxUserPassword.ReadOnly = False
        TextBoxUserUsername.ReadOnly = False
    End Sub

    Private Sub btnFavorit_Click(sender As Object, e As EventArgs) Handles btnFavorit.Click

        ListBoxFavoriten.Items.Clear()
        TabControl.SelectedTab = TabPageFavorit
        rsFavoriten.MoveFirst()
        Do While Not rsFavoriten.EOF
            ListBoxFavoriten.Items.Add(rsFavoriten.Fields("Bezeichnung").Value)
            rsFavoriten.MoveNext()
        Loop
    End Sub

    Private Sub ListBoxFavoriten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFavoriten.Click 'leitet zur Einzelansicht, nachdem ein Favorit angeklickt wurde
        Dim geschaeftsBezeichnung As String
        TabControl.SelectedTab = TabPageShopEinzelansicht
        geschaeftsBezeichnung = ListBoxFavoriten.SelectedItem
        Call GeschäfteLaden(geschaeftsBezeichnung)

    End Sub


    Private Sub GeschäfteLaden(ByVal geschaeftsBezeichnung) 'wird immer ausgeführt, wenn man zur Einzelansicht eines Shops geleitet wird
        Dim rsAktuelleGeschaeftskategorie As New ADODB.Recordset 'Recordset mit allen Geschäftsnamen (Geschäftsbezeichnung) und deren dazugehörigen Geschäfts-IDs
        Dim rsAktuellerGeschaeftsStadtteil As New ADODB.Recordset
        rsFavoritenID = New ADODB.Recordset


        rsFavoritenID.Open("SELECT Geschäfte.Geschäfts_ID FROM Geschäfte, Lieblingsgeschäfte WHERE Geschäfte.Geschäfts_ID = Lieblingsgeschäfte.Geschäfts_ID AND Kunden_ID=" & Übergabe.LoggedUserID,
                           conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

        'Anzeige des Sterns

        textBoxShopEinzelansichtBezeichnung.ReadOnly = True
        textBoxShopEinzelansichtAdresse.ReadOnly = True
        textBoxShopEinzelansichtOeffnungszeit.ReadOnly = True
        textBoxShopEinzelansichtTelefonnummer.ReadOnly = True
        textBoxShopEinzelansichtKategorie.ReadOnly = True
        labelShopEinzelansichtLängengrad.Hide()
        labelShopEinzelansichtBreitengrad.Hide()
        textBoxShopEinzelansichtLängengrad.Hide()
        textBoxShopEinzelansichtBreitengrad.Hide()
        WebView2.Hide()
        textBoxShopEinzelansichtKategorie.Show()
        textBoxShopEinzelansichtStadtteil.Show()
        comboBoxEinzelansichtKategorie.Hide()
        comboBoxEinzelansichtStadtteile.Hide()
        textBoxShopImageFileName.Hide()
        buttonShopImageHinzufuegen.Hide()
        buttonShopHinzufuegen.Hide()
        buttonShopBearbeiten.Show()
        buttonShopAenderungenSpeichern.Hide()
        ImageFavoritStern.Hide()
        textBoxShopEinzelansichtLängengrad.Clear()
        textBoxShopEinzelansichtBreitengrad.Clear()

        Try
            rsGeschaefte.MoveFirst()
            rsGeschaefte.Find("Bezeichnung = " & "'" & geschaeftsBezeichnung & "'")


            If Not rsGeschaefte.EOF Then
                TabControl.SelectedIndex = 2
                textBoxShopEinzelansichtBezeichnung.Text = geschaeftsBezeichnung

                'Ausgabe der Geschäftskategorie auf der Einzelansichtsseite
                rsAktuelleGeschaeftskategorie.Open("SELECT Kat_Bezeichnung FROM Kategorien WHERE Kategorie_ID = " & rsGeschaefte.Fields("Kategorie_ID").Value,
                                                    conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
                rsAktuellerGeschaeftsStadtteil.Open("SELECT Bezeichnung FROM Stadtteile WHERE ID = " & rsGeschaefte.Fields("Stadtteil_ID").Value,
                                                    conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
                textBoxShopEinzelansichtKategorie.Text = rsAktuelleGeschaeftskategorie.Fields("Kat_Bezeichnung").Value
                textBoxShopEinzelansichtAdresse.Text = rsGeschaefte.Fields("Adresse").Value
                textBoxShopEinzelansichtOeffnungszeit.Text = rsGeschaefte.Fields("Öffnungszeiten").Value
                textBoxShopEinzelansichtTelefonnummer.Text = rsGeschaefte.Fields("Telefon").Value
                textBoxShopEinzelansichtStadtteil.Text = rsAktuellerGeschaeftsStadtteil.Fields("Bezeichnung").Value

                pictureBoxGeschaefteEinzelansichtsseite.Show()
                pictureBoxGeschaefteEinzelansichtsseite.ImageLocation = "GeschäfteBilder\" & rsGeschaefte.Fields("Geschäftsbild").Value
            Else
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ButtonFavoritenHinzufügen_Click(sender As Object, e As EventArgs) Handles ButtonFavoritenHinzufügen.Click

        Dim rsFavoritAdd As ADODB.Recordset
        Dim rsFavorit As ADODB.Recordset
        Dim rsGeschaeftID As ADODB.Recordset
        rsFavorit = New ADODB.Recordset
        rsFavoritAdd = New ADODB.Recordset
        rsGeschaeftID = New ADODB.Recordset
        Dim LID As Integer
        Dim GeschäftsID As Integer
        Dim KundenID As Integer

        rsGeschaefte.MoveFirst()
        rsGeschaefte.Find("Bezeichnung = " & "'" & TestID & "'")
        GeschäftsID = rsGeschaefte.Fields("Geschäfts_ID").Value
        rsFavoritAdd.Open("SELECT MAX(LID) AS L FROM Lieblingsgeschäfte", conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        rsFavorit.Open("SELECT * FROM Lieblingsgeschäfte", conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

        KundenID = Übergabe.LoggedUserID
        LID = rsFavoritAdd.Fields("L").Value + 1

        If KundenID = 0 Then
            MsgBox("Bitte melden Sie sich an, um auf die Favoriten zugreifen zu können")
        Else
            If FindeFavoriten(GeschäftsID) = False Then
                rsGeschaefte.MoveFirst()
                rsGeschaefte.Find("Bezeichnung = " & "'" & TestID & "'")
                GeschäftsID = rsGeschaefte.Fields("Geschäfts_ID").Value
                With rsFavorit
                    .MoveLast()
                    .AddNew()
                    .Fields("LID").Value = LID
                    .Fields("Geschäfts_ID").Value = GeschäftsID
                    .Fields("Kunden_ID").Value = KundenID
                    .Update()
                    MsgBox("Favorit hinzugefügt")
                End With
            Else
                MsgBox("Dieser Laden ist schon auf Ihrer Favoritenliste")
            End If


        End If
    End Sub

    Public Function FindeFavoriten(ByVal GeschäftsID) As Boolean
        Dim rsFavorit As ADODB.Recordset
        rsFavorit = New ADODB.Recordset
        rsFavorit.Open("SELECT Geschäfts_ID FROM Lieblingsgeschäfte WHERE Kunden_ID =" & Übergabe.LoggedUserID, conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        'rsFavoritAdd.Open("SELECT Kunden_ID FROM Lieblingsgeschäfte", conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        ' rsFavoritAdd.MoveFirst()
        rsFavorit.MoveFirst()

        rsFavorit.Find("Geschäfts_ID =" & "'" & GeschäftsID & "'")
        If rsFavorit.EOF Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub btnMap_Click(sender As Object, e As EventArgs) Handles btnMap.Click
        TabControl.SelectedIndex = 0
        GMap1.Refresh()
        LadeMap(rsGeschaefte)
    End Sub

    Private Sub comboBoxMapSeiteKategorien_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxMapSeiteKategorien.SelectedIndexChanged
        GeschäftefilternComboBox()
    End Sub

    Private Sub comboBoxMapSeiteStadtteile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboBoxMapSeiteStadtteile.SelectedIndexChanged
        GeschäftefilternComboBox()
    End Sub

    Private Sub buttonMapSeiteFiltern_Click(sender As Object, e As EventArgs) Handles buttonMapSeiteZumShop.Click
        If comboBoxMapSeiteGeschäfte.SelectedItem IsNot "" Then
            GeschäfteLaden(comboBoxMapSeiteGeschäfte.SelectedItem)
        End If
    End Sub

    Sub GeschäftefilternComboBox()
        Dim rsaktuelleGeschaefte As ADODB.Recordset
        rsaktuelleGeschaefte = New ADODB.Recordset
        Dim rsaktuelleKategorieID As ADODB.Recordset
        rsaktuelleKategorieID = New ADODB.Recordset
        Dim rsaktuelleStadtteilID As ADODB.Recordset
        rsaktuelleStadtteilID = New ADODB.Recordset
        Dim aktuelleKategorieID As Integer
        Dim aktuelleStadtteilID As Integer



        If comboBoxMapSeiteStadtteile.SelectedItem = "" And comboBoxMapSeiteKategorien.SelectedItem = "" Then
            rsaktuelleGeschaefte.Open("SELECT * FROM Geschäfte",
                      conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

        ElseIf comboBoxMapSeiteStadtteile.SelectedItem = "" And comboBoxMapSeiteKategorien.SelectedItem IsNot "" Then
            rsaktuelleKategorieID.Open("SELECT Kategorie_ID FROM Kategorien WHERE Kat_Bezeichnung =" & "'" & comboBoxMapSeiteKategorien.SelectedItem & "'",
                                   conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            aktuelleKategorieID = rsaktuelleKategorieID.Fields("Kategorie_ID").Value
            rsaktuelleGeschaefte.Open("SELECT DISTINCT * FROM Geschäfte, Kategorien WHERE Geschäfte.Kategorie_ID=" & aktuelleKategorieID,
            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        ElseIf comboBoxMapSeiteStadtteile.SelectedItem IsNot "" And comboBoxMapSeiteKategorien.SelectedItem = "" Then
            rsaktuelleStadtteilID.Open("SELECT ID FROM Stadtteile WHERE Bezeichnung =" & "'" & comboBoxMapSeiteStadtteile.SelectedItem & "'",
                                   conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            aktuelleStadtteilID = rsaktuelleStadtteilID.Fields("ID").Value
            rsaktuelleGeschaefte.Open("SELECT DISTINCT * FROM Geschäfte WHERE Geschäfte.Stadtteil_ID = " & aktuelleStadtteilID,
            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        Else
            rsaktuelleKategorieID.Open("SELECT Kategorie_ID FROM Kategorien WHERE Kat_Bezeichnung =" & "'" & comboBoxMapSeiteKategorien.SelectedItem & "'",
                                   conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            aktuelleKategorieID = rsaktuelleKategorieID.Fields("Kategorie_ID").Value
            rsaktuelleStadtteilID.Open("SELECT ID FROM Stadtteile WHERE Bezeichnung =" & "'" & comboBoxMapSeiteStadtteile.SelectedItem & "'",
                                   conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            aktuelleStadtteilID = rsaktuelleStadtteilID.Fields("ID").Value
            rsaktuelleGeschaefte.Open("SELECT DISTINCT * FROM Geschäfte WHERE Geschäfte.Stadtteil_ID =" & aktuelleStadtteilID & "AND Geschäfte.Kategorie_ID =" & aktuelleKategorieID,
            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        End If

        comboBoxMapSeiteGeschäfte.Items.Clear()
        Try
            rsaktuelleGeschaefte.MoveFirst()


            Do While Not rsaktuelleGeschaefte.EOF
                comboBoxMapSeiteGeschäfte.Items.Add(rsaktuelleGeschaefte.Fields("Bezeichnung").Value)
                rsaktuelleGeschaefte.MoveNext()
            Loop
        Catch

        End Try

        'LadeMap(rsaktuelleGeschaefte)

    End Sub
End Class
