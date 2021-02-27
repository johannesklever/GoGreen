
﻿Public Class FormMain

﻿Imports System.Windows.Forms
Public Class Form1
    Dim rs As ADODB.Recordset
    Dim rs_Bestellung As ADODB.Recordset
    Dim conn As ADODB.Connection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs = New ADODB.Recordset
        rs_Bestellung = New ADODB.Recordset
        Try
            conn = New ADODB.Connection
            conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;“ & "Data Source=GoGreen.accdb")



            rs.Open("SELECT * FROM Kunde", conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

            'MsgBox("Datensätze gefunden: " & rs.RecordCount)
            If rs.RecordCount > 0 Then
                rs.MoveFirst()

                'Call Datenausgabe()

                'Do While Not rs.EOF
                '    'MsgBox(CStr(rs.Fields("Nachname").Value))
                '    rs.MoveNext()
                'Loop
            Else
                MsgBox("Keine Daten gefunden!")
            End If

            'rs.Close()
            'conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click

        If CStr(rs.Fields("Benutzername").Value) = TextBox_email.Text And CStr(rs.Fields("Passwort").Value) = TextBox_passwort.Text Then
            MsgBox("Angemeldet")
        Else
            MsgBox("Falsche Anmeldedaten")
            TextBox_email.Clear()
            TextBox_passwort.Clear()
        End If
    End Sub

    Private Sub Button_Registrieren_Click(sender As Object, e As EventArgs) Handles Button_Kontoanlegen.Click
        Me.Hide()
        Form2.ShowDialog()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelGeschaefteSubmenu.Visible = False
        panelMeinBereichSubMenu.Visible = False
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
