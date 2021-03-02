Public Class FormMain

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        panelGeschaefteSubmenu.Visible = False
        panelMeinBereichSubMenu.Visible = False

        Dim rs As ADODB.Recordset
        Dim rsGeschäfte As ADODB.Recordset
        Dim conn As ADODB.Connection

        rs = New ADODB.Recordset
        rsGeschäfte = New ADODB.Recordset
        Try
            conn = New ADODB.Connection
            conn.Open("Provider=Microsoft.ACE.OLEDB.12.0;“ & "Data Source=GoGreen.accdb")


            rsGeschäfte.Open("SELECT * FROM Geschäfte", conn, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)



            'rs.Close()
            'conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim i As Integer

        For i = 0 To 3
            Dim ndTop = TreeView1.Nodes.Add("Topnode " & i)
            For ii = 0 To 2
                Dim ndSub = ndTop.Nodes.Add("Subnode Level 1: " & i & ii)
                For iii = 0 To 4
                    ndSub.Nodes.Add("Subnode Level 2: " & i & ii & iii)
                Next
            Next
        Next

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
