Public Class FormMain
    Dim rsGeschäfte As ADODB.Recordset
    Dim rsKategorie As ADODB.Recordset
    Dim rsStadtteile As ADODB.Recordset
    Dim conn As ADODB.Connection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TestVar2 As String
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
        TestVar2 = Test123.TestVar
        MsgBox(TestVar2)

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

        Toggle(panelGeschaefteSubmenu)

    End Sub

    Private Sub btnMeinBereich_Click(sender As Object, e As EventArgs) Handles btnMeinBereich.Click

        Toggle(panelMeinBereichSubMenu)

    End Sub


    Private Sub Form1_ResizeBegin(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeBegin

        btnbla.Visible = False

    End Sub

    Private Sub Form1_ResizeEnd(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ResizeEnd

        Dim x As Integer
        Dim y As Integer
        Dim z As Integer
        Dim actualHeight As Integer



        x = PictureBoxMap.ClientSize.Width
        y = PictureBoxMap.ClientSize.Width * 467 / 987
        btnbla.Visible = True
        z = btnbla.Location.Y



        MsgBox(x & " " & y & " " & z)

    End Sub


End Class
