Imports System.Windows.Forms


Public Class Registrierung



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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
    Private Sub Button_Registrieren_Click(sender As Object, e As EventArgs) Handles Button_Registrieren.Click

        'Call ValidatePassword()

        If TextBox_NeuesPasswort.Text = TextBox_PasswortBestätigen.Text Then
            rs.MoveLast()
            rs.Fields("Benutzername").Value = TextBox_NeuerBenutzername.Text
            rs.Fields("Passwort").Value = TextBox_NeuesPasswort.Text
            rs.Update()
            MsgBox("Account erfolgreich erstellt")
            Me.Hide()
            Landingpage.ShowDialog()
        Else
            MsgBox("Min 8 Zeichen")
            TextBox_NeuesPasswort.Clear()
            TextBox_PasswortBestätigen.Clear()
        End If



    End Sub
    'Public Function isValidPassword(ByVal Pwd As String) As Boolean
    '    <System.Runtime.CompilerServices.Extension>
    '    Return Pwd.Length > 7 AndAlso Pwd Like "[A-Z]*#*"
    'End Function
    Function ValidatePassword() As Boolean

        Dim pwd As String = TextBox_NeuesPasswort.Text
        Dim minLength As Integer = 8
        Dim numUpper As Integer = 2
        Dim numLower As Integer = 2
        Dim numNumbers As Integer = 2
        Dim numSpecial As Integer = 2

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