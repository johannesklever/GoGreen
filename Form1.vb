Imports System.Windows.Forms
Public Class Form1
    Dim rs As ADODB.Recordset
    Dim rs_Bestellung As ADODB.Recordset
    Dim conn As ADODB.Connection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs = New ADODB.Recordset
        rs_Bestellung = New ADODB.Recordset
        Try
            conn = New ADODB.Connection
            conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;“ & "Data Source=C:\Users\johan\source\repos\GoGreen\GoGreen.accdb")

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
        'Dim Benutzer As String
        'Dim Passwort As String

        If rs.Fields("Benutzername").Value = TextBox_email And rs.Fields("Passwort").Value = TextBox_passwort Then
            MsgBox("Angemeldet")
        Else
            MsgBox("Falsche Anmeldedaten")
        End If
    End Sub
End Class
