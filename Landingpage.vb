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
        'rs_Bestellung = New ADODB.Recordset
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

    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim Benutzername As String
        Dim BenutzernameSuche As Boolean

        'MoveFirst
        'RsFind Benutzername 
        'Passwort überprüfen 
        'Wenn benutzer nicht gefunden wird, dann der Variablen
        rs.MoveFirst()
        rs.Find("Benutzername LIKE '" & Textbox_email.Text & "'")
        Benutzername = TextBox_email.Text
        If Not rs.EOF Then
            'MsgBox(Benutzername)
            BenutzernameSuche = True
        Else
            BenutzernameSuche = False
        End If


        If BenutzernameSuche = True And CStr(rs.Fields("Passwort").Value) = TextBox_passwort.Text Then
            Übergabe.LoggedUserID = rs.Fields("Kunden_ID").Value
            Me.Hide()
            FormMain.ShowDialog()
            'CStr(rs.Fields("Benutzername").Value)
        Else
            MsgBox("Falsche Anmeldedaten")
            TextBox_email.Clear()
            TextBox_passwort.Clear()
        End If

    End Sub

    Private Sub Button_Registrieren_Click(sender As Object, e As EventArgs) Handles Button_Kontoanlegen.Click

        Dim rs_KID As ADODB.Recordset
        rs_KID = New ADODB.Recordset
        Dim KID As Integer
        Dim fieldsArray(2) As Object
        Dim valuesArray(2) As Object

        rs_KID.Open("SELECT MAX(Kunden_ID) AS MKID FROM Kunde", conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

        KID = rs_KID.Fields("MKID").Value + 1

        fieldsArray(0) = "Kunden_ID"
        fieldsArray(1) = "Benutzername"
        'fieldsArray(2) = "Geburtsdatum"
        'fieldsArray(3) = "Anschrift"
        'fieldsArray(4) = "Benutzername"
        fieldsArray(2) = "Passwort"

        valuesArray(0) = KID
        valuesArray(1) = ""
        'valuesArray(2) = ""
        'valuesArray(3) = ""
        'valuesArray(4) = ""
        valuesArray(2) = ""

        rs.AddNew(fieldsArray, valuesArray)
        rs.Update()

        Me.Hide()
        Registrierung.ShowDialog()
    End Sub

End Class

