Public Class FormKeinBenutzer
    Private Sub ButtonYes_Click(sender As Object, e As EventArgs) Handles ButtonYes.Click

        Me.Close()
        Landingpage.Show()
        FormMain.Close()

    End Sub

    Private Sub ButtonNo_Click(sender As Object, e As EventArgs) Handles ButtonNo.Click
        Me.Close()
    End Sub

    Private Sub FormKeinBenutzer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBoxNoUser.ReadOnly = True
    End Sub
End Class