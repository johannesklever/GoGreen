Public Class FormMain

    Dim rsKategorie As ADODB.Recordset
    Dim rsStadtteile As ADODB.Recordset
    Dim conn As ADODB.Connection
    Dim rsGeschaefte As ADODB.Recordset

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim rsGeschäfte As ADODB.Recordset
        panelGeschaefteSubmenu.Visible = False
        panelMeinBereichSubMenu.Visible = False
        rsGeschäfte = New ADODB.Recordset
        rsKategorie = New ADODB.Recordset
        rsStadtteile = New ADODB.Recordset

        'Try

        conn = New ADODB.Connection
        conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;“ & "Data Source=GoGreen.accdb")

        rsKategorie.Open("SELECT * FROM Kategorien",
                    conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

        'Treeview Geschäfte nach Kategorien
        Do While Not rsKategorie.EOF
            Dim ndTop = TreeViewGeschäfteKategorien.Nodes.Add(rsKategorie.Fields("Kat_Bezeichnung").Value)
            rsGeschäfte.Open("SELECT * FROM Geschäfte WHERE Kategorie_ID = " & rsKategorie.Fields("Kategorie_ID").Value,
                        conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

            If rsGeschäfte.RecordCount > 0 Then
                Do While Not rsGeschäfte.EOF
                    ndTop.Nodes.Add(rsGeschäfte.Fields("Bezeichnung").Value)
                    rsGeschäfte.MoveNext()
                Loop
            End If
            rsGeschäfte.Close()
            rsKategorie.MoveNext()
        Loop

        'Treeview Geschäfte nach Stadtteilen

        rsStadtteile.Open("SELECT * FROM Stadtteile",
                    conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

        Do While Not rsStadtteile.EOF
            Dim ndTop = TreeViewGeschäfteStadtteile.Nodes.Add(rsStadtteile.Fields("Bezeichnung").Value)
            rsGeschäfte.Open("SELECT * FROM Geschäfte WHERE Stadtteil_ID = " & rsStadtteile.Fields("ID").Value,
                        conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

            If rsGeschäfte.RecordCount > 0 Then
                Do While Not rsGeschäfte.EOF
                    ndTop.Nodes.Add(rsGeschäfte.Fields("Bezeichnung").Value)
                    rsGeschäfte.MoveNext()
                Loop
            End If
            rsGeschäfte.Close()
            rsStadtteile.MoveNext()
        Loop


        'Catch ex As Exception
        '    MsgBox(ex.Message)

        'End Try

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

    Private Sub btnGeschaefte_Click(sender As Object, e As EventArgs) Handles btnGeschaefte.Click

        Toggle(panelGeschaefteSubmenu)  'das Panel wird aufgedeckt oder versteckt, sodass Untermenü sichtbar ist oder nicht

    End Sub

    Private Sub btnMeinBereich_Click(sender As Object, e As EventArgs) Handles btnMeinBereich.Click

        Toggle(panelMeinBereichSubMenu)

    End Sub

    Private Sub btnSideMenuKategorien_Click(sender As Object, e As EventArgs) Handles btnSideMenuKategorien.Click

        TabControl1.SelectedIndex = 1

    End Sub

    Private Sub btnSideMenuStadtteile_Click(sender As Object, e As EventArgs) Handles btnSideMenuStadtteile.Click

        TabControl1.SelectedIndex = 3

    End Sub

    Private Sub TreeViewGeschäfteKategorien_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewGeschäfteKategorien.AfterSelect

        Dim geschaeftsBezeichnung As String
        rsGeschaefte = New ADODB.Recordset

        conn = New ADODB.Connection
        conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;“ & "Data Source=GoGreen.accdb")

        rsGeschaefte.Open("SELECT * FROM Geschäfte",
                    conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)


        geschaeftsBezeichnung = TreeViewGeschäfteKategorien.SelectedNode.Text

        rsGeschaefte.MoveFirst()
        rsGeschaefte.Find("Bezeichnung = " & "'" & geschaeftsBezeichnung & "'")

        If rsGeschaefte.EOF Then

        Else
            TabControl1.SelectedIndex = 2
            textBoxShopEinzelansichtBezeichnung.Text = geschaeftsBezeichnung
        End If

        'MsgBox(rsGeschaefte.Fields("Bezeichnung").Value)

        'If geschaeftsBezeichnung > 0 Then
        '    rsGeschäfte.MoveFirst()
        '    rsGeschäfte.Find("Geschäfts_ID = " & geschaeftsBezeichnung)

        '    If rsGeschäfte.EOF Then
        '        MsgBox("nichts gefunden")
        '        rsGeschäfte.MoveLast()
        '    End If


    End Sub


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
