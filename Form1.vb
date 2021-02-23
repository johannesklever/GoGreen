Public Class Form1

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
