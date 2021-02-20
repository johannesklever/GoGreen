Imports System.Windows.Forms

Public Class Form1
    Dim rs As GoGreen.ADODB.Recordset
    Dim conn As ADODB.Connection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rs = New GoGreen.ADODB.Recordset
        'rs_Bestellung = New ADODB.Recordset
        Try
            conn = New ADODB.Connection
            conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;“ & "Data Source=C:\INFO\GoGreen.accdb")

            'MsgBox("Datensätze gefunden: " & rs.RecordCount)
            ' If rs.RecordCount > 0 Then

            'rs.MoveFirst()

            'Call Datenausgabe()

            'Do While Not rs.EOF
            '    'MsgBox(CStr(rs.Fields("Nachname").Value))
            '    rs.MoveNext()
            'Loop
            '  Else
            'MsgBox("Keine Daten gefunden!")
            ' End If

            'rs.Close()
            'conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class

Namespace ADODB
    Class Connection
        Friend Sub Open(v As String)
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace

Namespace GoGreen.ADODB
    Class Recordset
    End Class

End Namespace
