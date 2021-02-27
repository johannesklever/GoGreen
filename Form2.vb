Imports System.Windows.Forms
Public Class Form2

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
    Private Sub Button_Registrieren_Click(sender As Object, e As EventArgs) Handles Button_Registrieren.Click
        rs.Fields("Benutzername").Value = TextBox_NeuerBenutzername.Text

    End Sub
End Class