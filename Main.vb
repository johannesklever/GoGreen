Imports GMap.NET
Imports GMap.NET.MapProviders
Imports GMap.NET.WindowsForms
Imports GMap.Net.WindowsForms.Markers


Public Class FormMain


    Dim rsKategorien As ADODB.Recordset
    Dim rsStadtteile As ADODB.Recordset
    Dim rsBearbeiten As ADODB.Recordset
    Dim conn As ADODB.Connection
    Dim rsGeschaefte As ADODB.Recordset
    Dim rsFavoriten As ADODB.Recordset

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


        'GMap1.MapProvider = GoogleMapProvider.Instance
        'GMaps.Instance.Mode = AccessMode.ServerAndCache
        'GMap1.MapProvider = BingHybridMapProvider.Instance
        'GMap1.Position = New GMap.NET.PointLatLng(textBoxLatitude.Text.Trim(), textBoxLongitude.Text.Trim())
        'GMap1.ShowCenter = False

        'Dim markers As GMapOverlay = New GMapOverlay("markers")
        'Dim marker As GMapMarker = New GMapMarker(New PointLatLng(textBoxLatitude.Text.Trim(), textBoxLongitude.Text.Trim())
        'markers.Markers.Add(marker)
        'GMap1.Overlays.Add(markers)


        'GMap1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        'GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache
        'GMap1.SetPositionByKeywords("Paris, France")
        'GMap1.ShowCenter = False
        'Dim markers As GMap.NET.WindowsForms.GMapOverlay = New GMap.NET.WindowsForms.GMapOverlay("markers")
        'Dim marker As GMap.NET.WindowsForms.GMapMarker = New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New GMap.NET.PointLatLng(48.8617774, 2.349272), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin)
        'markers.Markers.Add(marker)
        'GMap1.Overlays.Add(markers)







        'GMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance
        'GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly
        'GMapControl1.SetPositionByKeywords("Paris, France")


        'GMapControl1.Position = New GMap.NET.PointLatLng(48.8589507, 2.2775175)


        ''marker.ToolTipMode = MarkerTooltipMode.OnMouseOver

        GMap1.MaxZoom = 18
        GMap1.MinZoom = 0
        GMap1.Zoom = 13

        'GMap1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance
        'GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly
        'GMap1.SetPositionByKeywords("Berlin")



        GMap1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance
        GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache
        GMap1.SetPositionByKeywords("Paris, Frankreich")
        GMap1.ShowCenter = False
        Dim markers As GMap.NET.WindowsForms.GMapOverlay = New GMap.NET.WindowsForms.GMapOverlay("markers")
        Dim marker As GMap.NET.WindowsForms.GMapMarker = New GMap.NET.WindowsForms.Markers.GMarkerGoogle(New GMap.NET.PointLatLng(48.8617774, 2.349272), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin)
        markers.Markers.Add(marker)
        GMap1.Overlays.Add(markers)
        GMap1.Position = New GMap.NET.PointLatLng(48.8589507, 2.2775175)

        GMap1.MaxZoom = 18
        GMap1.MinZoom = 0
        GMap1.Zoom = 15




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
            Me.Close()
            FormKeinBenutzer.ShowDialog()
        Else
            Toggle(panelMeinBereichSubMenu)
        End If


    End Sub

    Private Sub buttonSideMenuKategorien_Click(sender As Object, e As EventArgs) Handles buttonSideMenuKategorien.Click

        TabControl1.SelectedIndex = 1

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

        TabControl1.SelectedIndex = 3

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
        TabControl1.SelectedTab = TabPage3
        geschaeftsBezeichnung = treeView.SelectedNode.Text
        Call GeschäfteLaden(geschaeftsBezeichnung)




        'Dim geschaeftsBezeichnung As String
        'Dim rsAktuelleGeschaeftskategorie As New ADODB.Recordset 'Recordset mit allen Geschäftsnamen (Geschäftsbezeichnung) und deren dazugehörigen Geschäfts-IDs
        'Dim rsAktuellerGeschaeftsStadtteil As New ADODB.Recordset

        'textBoxShopEinzelansichtBezeichnung.ReadOnly = True
        'textBoxShopEinzelansichtAdresse.ReadOnly = True
        'textBoxShopEinzelansichtOeffnungszeit.ReadOnly = True
        'textBoxShopEinzelansichtTelefonnummer.ReadOnly = True
        'textBoxShopEinzelansichtKategorie.ReadOnly = True
        'textBoxShopEinzelansichtKategorie.Show()
        'textBoxShopEinzelansichtStadtteil.Show()
        'comboBoxEinzelansichtKategorie.Hide()
        'comboBoxEinzelansichtStadtteile.Hide()
        'textBoxShopImageFileName.Hide()
        'buttonShopImageHinzufuegen.Hide()
        'buttonShopHinzufuegen.Hide()
        'buttonShopBearbeiten.Show()
        'buttonShopAenderungenSpeichern.Hide()

        'Try

        '    geschaeftsBezeichnung = treeView.SelectedNode.Text
        '    rsGeschaefte.MoveFirst()
        '    rsGeschaefte.Find("Bezeichnung = " & "'" & geschaeftsBezeichnung & "'")


        '    If Not rsGeschaefte.EOF Then
        '        TabControl1.SelectedIndex = 2
        '        textBoxShopEinzelansichtBezeichnung.Text = geschaeftsBezeichnung

        '        'Ausgabe der Geschäftskategorie auf der Einzelansichtsseite
        '        rsAktuelleGeschaeftskategorie.Open("SELECT Kat_Bezeichnung FROM Kategorien WHERE Kategorie_ID = " & rsGeschaefte.Fields("Kategorie_ID").Value,
        '                                            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        '        rsAktuellerGeschaeftsStadtteil.Open("SELECT Bezeichnung FROM Stadtteile WHERE ID = " & rsGeschaefte.Fields("Stadtteil_ID").Value,
        '                                            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
        '        textBoxShopEinzelansichtKategorie.Text = rsAktuelleGeschaeftskategorie.Fields("Kat_Bezeichnung").Value
        '        textBoxShopEinzelansichtAdresse.Text = rsGeschaefte.Fields("Adresse").Value
        '        textBoxShopEinzelansichtOeffnungszeit.Text = rsGeschaefte.Fields("Öffnungszeiten").Value
        '        textBoxShopEinzelansichtTelefonnummer.Text = rsGeschaefte.Fields("Telefon").Value
        '        textBoxShopEinzelansichtStadtteil.Text = rsAktuellerGeschaeftsStadtteil.Fields("Bezeichnung").Value

        '        pictureBoxGeschaefteEinzelansichtsseite.Show()
        '        pictureBoxGeschaefteEinzelansichtsseite.ImageLocation = "GeschäfteBilder\" & rsGeschaefte.Fields("Geschäftsbild").Value
        '    Else
        '    End If

        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try

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

        TabControl1.SelectedIndex = 2

        textBoxShopEinzelansichtKategorie.Hide()
        textBoxShopEinzelansichtStadtteil.Hide()
        comboBoxEinzelansichtKategorie.Items.Clear()
        comboBoxEinzelansichtStadtteile.Items.Clear()
        'Textfelder beschreibbar machen
        textBoxShopEinzelansichtBezeichnung.ReadOnly = False
        textBoxShopEinzelansichtAdresse.ReadOnly = False
        textBoxShopEinzelansichtOeffnungszeit.ReadOnly = False
        textBoxShopEinzelansichtTelefonnummer.ReadOnly = False
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
        ShopInformationenDatenbankHochladen()
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
            rsGeschaefte.Update()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub buttonShopImageHinzufuegen_Click(sender As Object, e As EventArgs) Handles buttonShopImageHinzufuegen.Click

        Dim openFileDialogShopImage As New OpenFileDialog()

        openFileDialogShopImage.InitialDirectory = "c:\"
        openFileDialogShopImage.Filter = "jpg files (*.jpg)|*.jpg|jpeg files (*.jpeg)|*.jpeg|png files (*.png)|*.png|All files (*.*)|*.*" 'zugelassene File Typen
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
        buttonShopAenderungenSpeichern.Show()
        textBoxShopImageFileName.Text = rsGeschaefte.Fields("Geschäftsbild").Value
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

    Private Sub btnUserSettings_Click(sender As Object, e As EventArgs) Handles btnUserSettings.Click
        Dim UserIDCONV As String
        UserIDCONV = CStr(Übergabe.LoggedUserID)
        rsBearbeiten.Find("Kunden_ID =" & "'" & UserIDCONV & "'")

        If UserIDCONV = 0 Then
            Me.Close()
            FormKeinBenutzer.ShowDialog()
        Else
            TabControl1.SelectedTab = TabPageUser
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

    Private Sub ButtonUserSavePhone_Click(sender As Object, e As EventArgs) Handles ButtonUserSavePhone.Click
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

        TabControl1.SelectedTab = TabPageFavorit
        Do While Not rsFavoriten.EOF
            ListBoxFavoriten.Items.Add(rsFavoriten.Fields("Bezeichnung").Value)
            rsFavoriten.MoveNext()
        Loop
    End Sub

    Private Sub ListBoxFavoriten_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxFavoriten.Click
        Dim geschaeftsBezeichnung As String
        TabControl1.SelectedTab = TabPage3
        geschaeftsBezeichnung = ListBoxFavoriten.SelectedItem
        Call GeschäfteLaden(geschaeftsBezeichnung)

    End Sub


    Private Sub GeschäfteLaden(ByVal geschaeftsBezeichnung)
        Dim rsAktuelleGeschaeftskategorie As New ADODB.Recordset 'Recordset mit allen Geschäftsnamen (Geschäftsbezeichnung) und deren dazugehörigen Geschäfts-IDs
        Dim rsAktuellerGeschaeftsStadtteil As New ADODB.Recordset

        textBoxShopEinzelansichtBezeichnung.ReadOnly = True
        textBoxShopEinzelansichtAdresse.ReadOnly = True
        textBoxShopEinzelansichtOeffnungszeit.ReadOnly = True
        textBoxShopEinzelansichtTelefonnummer.ReadOnly = True
        textBoxShopEinzelansichtKategorie.ReadOnly = True
        textBoxShopEinzelansichtKategorie.Show()
        textBoxShopEinzelansichtStadtteil.Show()
        comboBoxEinzelansichtKategorie.Hide()
        comboBoxEinzelansichtStadtteile.Hide()
        textBoxShopImageFileName.Hide()
        buttonShopImageHinzufuegen.Hide()
        buttonShopHinzufuegen.Hide()
        buttonShopBearbeiten.Show()
        buttonShopAenderungenSpeichern.Hide()

        Try
            rsGeschaefte.MoveFirst()
            rsGeschaefte.Find("Bezeichnung = " & "'" & geschaeftsBezeichnung & "'")


            If Not rsGeschaefte.EOF Then
                TabControl1.SelectedIndex = 2
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

    'bla


    'Private Sub Form1_ResizeBegin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeBegin
    '    btnbla.Visible = False

    'End Sub

    'Private Sub Form1_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd

    '    Dim x As Integer
    '    Dim y As Integer
    '    Dim z As Integer
    '    Dim actualHeight As Integer

    '    x = PictureBoxMap.ClientSize.Width
    '    y = PictureBoxMap.ClientSize.Width * 467 / 987
    '    btnbla.Visible = True
    '    z = btnbla.Location.Y

    '    MsgBox(x & " " & y & " " & z)

    'End Sub


End Class
