Imports System.Windows.Forms

Public Module Übergabe
    Public LoggedUserID As Integer
End Module

Public Class Landingpage



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

        rs.Find("Benutzername = " & "'" & benutzername & "'") 'Prüfung, ob Benutzername in der Datenbank hinterlegt ist

        If rs.EOF Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click

        FindeDatensatzImRecordset(textBoxBenutzername.Text)

        If FindeDatensatzImRecordset(textBoxBenutzername.Text) = True Then  'erst Bedingung: Benutzername wurde in der Datenbank gefunden
            If rs.Fields("Passwort").Value = textBoxPasswort.Text Then 'zweite Bedingung: Passwort des gefundenen Nutzers stimmt
                Me.Hide()
                Übergabe.LoggedUserID = rs.Fields("Kunden_ID").Value

                FormMain.ShowDialog()
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
        Registrierung.ShowDialog()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub buttonOhneAnmelden_Click(sender As Object, e As EventArgs) Handles buttonOhneAnmelden.Click
        Me.Hide()
        FormMain.ShowDialog()
    End Sub

End Class

