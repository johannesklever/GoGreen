<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKeinBenutzer
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.RichTextBoxNoUser = New System.Windows.Forms.RichTextBox()
        Me.ButtonYes = New System.Windows.Forms.Button()
        Me.ButtonNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBoxNoUser
        '
        Me.RichTextBoxNoUser.Location = New System.Drawing.Point(209, 117)
        Me.RichTextBoxNoUser.Name = "RichTextBoxNoUser"
        Me.RichTextBoxNoUser.Size = New System.Drawing.Size(339, 117)
        Me.RichTextBoxNoUser.TabIndex = 0
        Me.RichTextBoxNoUser.Text = "Es ist kein Benutzer angemeldet, wollen sie sich anmelden, um auf Ihre Daten zugr" &
    "eifen zu können?"
        '
        'ButtonYes
        '
        Me.ButtonYes.Location = New System.Drawing.Point(209, 321)
        Me.ButtonYes.Name = "ButtonYes"
        Me.ButtonYes.Size = New System.Drawing.Size(110, 54)
        Me.ButtonYes.TabIndex = 1
        Me.ButtonYes.Text = "Ja"
        Me.ButtonYes.UseVisualStyleBackColor = True
        '
        'ButtonNo
        '
        Me.ButtonNo.Location = New System.Drawing.Point(433, 321)
        Me.ButtonNo.Name = "ButtonNo"
        Me.ButtonNo.Size = New System.Drawing.Size(115, 54)
        Me.ButtonNo.TabIndex = 2
        Me.ButtonNo.Text = "Nein"
        Me.ButtonNo.UseVisualStyleBackColor = True
        '
        'FormKeinBenutzer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonNo)
        Me.Controls.Add(Me.ButtonYes)
        Me.Controls.Add(Me.RichTextBoxNoUser)
        Me.Name = "FormKeinBenutzer"
        Me.Text = "Kein Benutzer angemeldet"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBoxNoUser As RichTextBox
    Friend WithEvents ButtonYes As Button
    Friend WithEvents ButtonNo As Button
End Class
