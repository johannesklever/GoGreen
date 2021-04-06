Imports System.Windows.Forms

Public Module Übergabe
    Public LoggedUserID As Integer
End Module

Public Class Landingpage

    Dim rsKunde As ADODB.Recordset
    Dim conn As ADODB.Connection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rsKunde = New ADODB.Recordset

        Try
            conn = New ADODB.Connection
            conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;“ & "Data Source=GoGreen.accdb")


            rsKunde.Open("SELECT * FROM Kunde", conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

            'MsgBox("Datensätze gefunden: " & rs.RecordCount)
            If rsKunde.RecordCount > 0 Then
                rsKunde.MoveFirst()


            Else
                MsgBox("Keine Daten gefunden!")
            End If

            'rs.Close()
            'conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function FindeDatensatzImRecordset(ByVal benutzername As String) As Boolean

        rsKunde.Find("Benutzername = " & "'" & benutzername & "'") 'Prüfung, ob Benutzername in der Datenbank hinterlegt ist

        If rsKunde.EOF Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click

        FindeDatensatzImRecordset(textBoxBenutzername.Text)

        If FindeDatensatzImRecordset(textBoxBenutzername.Text) = True Then  'erst Bedingung: Benutzername wurde in der Datenbank gefunden
            If rsKunde.Fields("Passwort").Value = textBoxPasswort.Text Then 'zweite Bedingung: Passwort des gefundenen Nutzers stimmt
                Me.Hide()
                Übergabe.LoggedUserID = rsKunde.Fields("Kunden_ID").Value

                FormMain.Show()
            Else
                MsgBox("Falsches Passwort!")
                textBoxPasswort.Clear()
            End If
        Else
            MsgBox("Benutzer konnte nicht gefunden werden!")
            textBoxBenutzername.Clear()
        End If

    End Sub

    Private Sub Button_Registrieren_Click(sender As Object, e As EventArgs) Handles buttonKontoanlegen.Click

        textBoxBenutzername.Clear()  'falls Nutzer Daten eingibt und dann auf Registrieren drückt
        textBoxPasswort.Clear()

        Me.Hide()
        Registrierung.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub buttonOhneAnmelden_Click(sender As Object, e As EventArgs) Handles buttonOhneAnmelden.Click
        Me.Hide()
        FormMain.Show()
    End Sub

End Class

