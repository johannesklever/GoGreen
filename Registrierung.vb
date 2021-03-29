Imports System.Windows.Forms


Public Class Registrierung



    Dim rsKunde As ADODB.Recordset
    Dim conn As ADODB.Connection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rsKunde = New ADODB.Recordset
        Try
            conn = New ADODB.Connection
            conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;“ & "Data Source=GoGreen.accdb")


            rsKunde.Open("SELECT * FROM Kunde", conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

            'MsgBox("Datensätze gefunden: " & rsKunde.RecordCount)
            If rsKunde.RecordCount > 0 Then
                rsKunde.MoveFirst()
            Else
                MsgBox("Keine Daten gefunden!")
            End If

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

    Private Sub Button_Registrieren_Click(sender As Object, e As EventArgs) Handles buttonRegistrieren.Click

        FindeDatensatzImRecordset(textBoxBenutzername.Text)

        If FindeDatensatzImRecordset(textBoxBenutzername.Text) = False Then
            If textBoxNeuesPasswort.Text = textBoxPasswortBestätigen.Text And ValidatePassword() = True Then
                With rsKunde
                    .MoveLast()
                    .AddNew()
                    .Fields("Benutzername").Value = textBoxBenutzername.Text
                    .Fields("Passwort").Value = textBoxNeuesPasswort.Text
                    .Update()
                    MsgBox("Account erfolgreich erstellt")
                    .Close()
                End With
                Me.Hide()
                Landingpage.ShowDialog()
            ElseIf textBoxNeuesPasswort.Text = textBoxPasswortBestätigen.Text And ValidatePassword() = False Then
                MsgBox("Mindestens 5 Zeichen, 1 Kleinbuchstabe, 1 Großbuchstabe, 1 Zahl und ein Sonderzeichen")
                textBoxNeuesPasswort.Clear()
                textBoxPasswortBestätigen.Clear()
                textBoxNeuesPasswort.Clear()
            Else
                MsgBox("Passwort stimmt nicht überein")
                textBoxNeuesPasswort.Clear()
                textBoxPasswortBestätigen.Clear()
                textBoxNeuesPasswort.Clear()
            End If
        Else
            textBoxBenutzername.Clear()
            textBoxNeuesPasswort.Clear()
            textBoxPasswortBestätigen.Clear()
            MsgBox("Benutzer bereits vergeben!")
        End If


    End Sub
    'Public Function isValidPassword(ByVal Pwd As String) As Boolean
    '    <System.Runtime.CompilerServices.Extension>
    '    Return Pwd.Length > 7 AndAlso Pwd Like "[A-Z]*#*"
    'End Function
    Function ValidatePassword() As Boolean

        Dim pwd As String = textBoxNeuesPasswort.Text
        Dim minLength As Integer = 5
        Dim numUpper As Integer = 1
        Dim numLower As Integer = 0
        Dim numNumbers As Integer = 1
        Dim numSpecial As Integer = 1

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters.
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above".
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length.
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences.
        If upper.Matches(pwd).Count < numUpper Then Return False
        If lower.Matches(pwd).Count < numLower Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks.
        Return True
    End Function

End Class