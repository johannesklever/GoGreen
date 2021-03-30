
Public Class FormMain


    Dim rsKategorien As ADODB.Recordset
    Dim rsStadtteile As ADODB.Recordset
    Dim conn As ADODB.Connection
    Dim rsGeschaefte As ADODB.Recordset

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelGeschaefteSubmenu.Visible = False
        panelMeinBereichSubMenu.Visible = False

        rsKategorien = New ADODB.Recordset
        rsStadtteile = New ADODB.Recordset
        rsGeschaefte = New ADODB.Recordset

        Try

            conn = New ADODB.Connection
            conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;“ & "Data Source=GoGreen.accdb")

            rsKategorien.Open("SELECT * FROM Kategorien",
                            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            rsGeschaefte.Open("SELECT * FROM Geschäfte",
                            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            rsStadtteile.Open("SELECT * FROM Stadtteile",
                            conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

        Catch ex As Exception
            MsgBox(ex.Message)

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

        Toggle(panelMeinBereichSubMenu)

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

            geschaeftsBezeichnung = treeView.SelectedNode.Text
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

    Private Sub btnSideMenuHinzufuegenClick(sender As Object, e As EventArgs) Handles buttonSideMenuHinzufuegen.Click

        'alte Einträge löschen
        textBoxShopEinzelansichtOeffnungszeit.Clear()
        textBoxShopEinzelansichtTelefonnummer.Clear()
        textBoxShopEinzelansichtAdresse.Clear()
        textBoxShopEinzelansichtBezeichnung.Clear()
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

        Dim rsAktuelleKategorieID As New ADODB.Recordset 'zur Ermittlung der KategorienID über die ausgewählte Kategorienbezeichung in der Combobox
        Dim rsAktuellerStadtteilID As New ADODB.Recordset 'zur Ermittlung der StadtteilID über den ausgewählten Stadtteil in der Combobox

        Try
            rsAktuelleKategorieID.Open("SELECT Kategorie_ID FROM Kategorien WHERE Kat_Bezeichnung = " & "'" & comboBoxEinzelansichtKategorie.SelectedItem & "'",
                                        conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            rsAktuellerStadtteilID.Open("SELECT ID FROM Stadtteile WHERE Bezeichnung = " & "'" & comboBoxEinzelansichtStadtteile.SelectedItem & "'",
                                        conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            rsGeschaefte.MoveFirst()
            rsGeschaefte.AddNew()
            rsGeschaefte.Fields("Bezeichnung").Value = textBoxShopEinzelansichtBezeichnung.Text
            rsGeschaefte.Fields("Adresse").Value = textBoxShopEinzelansichtAdresse.Text
            rsGeschaefte.Fields("Öffnungszeiten").Value = textBoxShopEinzelansichtOeffnungszeit.Text
            rsGeschaefte.Fields("Telefon").Value = textBoxShopEinzelansichtTelefonnummer.Text
            rsGeschaefte.Fields("Kategorie_ID").Value = rsAktuelleKategorieID.Fields("Kategorie_ID").Value
            rsGeschaefte.Fields("Stadtteil_ID").Value = rsAktuellerStadtteilID.Fields("ID").Value
            rsGeschaefte.Fields("Geschäftsbild").Value = textBoxShopImageFileName.Text
            rsGeschaefte.Update()
            MsgBox("Geschäft hinzugefügt")

            'Kopieren des Bildes in Programmverzeichnis
            Dim SourceFile, DestinationFile As String
            SourceFile = pictureBoxGeschaefteEinzelansichtsseite.ImageLocation   ' Define source file name.
            DestinationFile = "GeschäfteBilder\" & textBoxShopImageFileName.Text
            FileCopy(SourceFile, DestinationFile)   ' Copy source to target.


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Bild ins Projektverzeichnis verschieben
        'pictureBoxGeschaefteEinzelansichtsseite


        textBoxShopEinzelansichtAdresse.Clear()
        textBoxShopEinzelansichtBezeichnung.Clear()
        textBoxShopEinzelansichtOeffnungszeit.Clear()
        textBoxShopEinzelansichtTelefonnummer.Clear()
        comboBoxEinzelansichtKategorie.ResetText()
        comboBoxEinzelansichtStadtteile.ResetText()

    End Sub

    Private Sub buttonShopImageHinzufuegen_Click(sender As Object, e As EventArgs) Handles buttonShopImageHinzufuegen.Click

        Dim openFileDialogShopImage As New OpenFileDialog()

        openFileDialogShopImage.InitialDirectory = "c:\"
        openFileDialogShopImage.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileDialogShopImage.FilterIndex = 2
        openFileDialogShopImage.RestoreDirectory = True
        openFileDialogShopImage.Title = "Bild auswählen"

        If openFileDialogShopImage.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            pictureBoxGeschaefteEinzelansichtsseite.ImageLocation = openFileDialogShopImage.FileName
            textBoxShopImageFileName.Text = openFileDialogShopImage.SafeFileName
            pictureBoxGeschaefteEinzelansichtsseite.Show() 'zeigt die Picturebox wieder mit einem neuen Foto
        End If

    End Sub

    Private Sub buttonShopBearbeiten_Click(sender As Object, e As EventArgs) Handles buttonShopBearbeiten.Click

        ShopBearbeitenundHinzufügen()
        buttonShopAenderungenSpeichern.Show()
        comboBoxEinzelansichtKategorie.SelectedItem = textBoxShopEinzelansichtKategorie.Text
        comboBoxEinzelansichtStadtteile.SelectedItem = textBoxShopEinzelansichtStadtteil.Text

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
