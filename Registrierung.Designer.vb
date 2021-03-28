<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registrierung
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.textBoxBenutzername = New System.Windows.Forms.TextBox()
        Me.Label_NeuerBenutzername = New System.Windows.Forms.Label()
        Me.Label_NeuesPasswort = New System.Windows.Forms.Label()
        Me.textBoxNeuesPasswort = New System.Windows.Forms.TextBox()
        Me.Label_PasswortBestätigen = New System.Windows.Forms.Label()
        Me.textBoxPasswortBestätigen = New System.Windows.Forms.TextBox()
        Me.buttonRegistrieren = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'textBoxBenutzername
        '
        Me.textBoxBenutzername.Location = New System.Drawing.Point(355, 67)
        Me.textBoxBenutzername.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxBenutzername.Name = "textBoxBenutzername"
        Me.textBoxBenutzername.Size = New System.Drawing.Size(68, 22)
        Me.textBoxBenutzername.TabIndex = 0
        '
        'Label_NeuerBenutzername
        '
        Me.Label_NeuerBenutzername.AutoSize = True
        Me.Label_NeuerBenutzername.Location = New System.Drawing.Point(190, 71)
        Me.Label_NeuerBenutzername.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_NeuerBenutzername.Name = "Label_NeuerBenutzername"
        Me.Label_NeuerBenutzername.Size = New System.Drawing.Size(147, 17)
        Me.Label_NeuerBenutzername.TabIndex = 1
        Me.Label_NeuerBenutzername.Text = "Neuer Benutzername:"
        '
        'Label_NeuesPasswort
        '
        Me.Label_NeuesPasswort.AutoSize = True
        Me.Label_NeuesPasswort.Location = New System.Drawing.Point(190, 118)
        Me.Label_NeuesPasswort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_NeuesPasswort.Name = "Label_NeuesPasswort"
        Me.Label_NeuesPasswort.Size = New System.Drawing.Size(114, 17)
        Me.Label_NeuesPasswort.TabIndex = 3
        Me.Label_NeuesPasswort.Text = "Neues Passwort:"
        '
        'textBoxNeuesPasswort
        '
        Me.textBoxNeuesPasswort.Location = New System.Drawing.Point(355, 114)
        Me.textBoxNeuesPasswort.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxNeuesPasswort.Name = "textBoxNeuesPasswort"
        Me.textBoxNeuesPasswort.Size = New System.Drawing.Size(68, 22)
        Me.textBoxNeuesPasswort.TabIndex = 2
        '
        'Label_PasswortBestätigen
        '
        Me.Label_PasswortBestätigen.AutoSize = True
        Me.Label_PasswortBestätigen.Location = New System.Drawing.Point(190, 164)
        Me.Label_PasswortBestätigen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label_PasswortBestätigen.Name = "Label_PasswortBestätigen"
        Me.Label_PasswortBestätigen.Size = New System.Drawing.Size(139, 17)
        Me.Label_PasswortBestätigen.TabIndex = 5
        Me.Label_PasswortBestätigen.Text = "Passwort bestätigen:"
        '
        'textBoxPasswortBestätigen
        '
        Me.textBoxPasswortBestätigen.Location = New System.Drawing.Point(355, 164)
        Me.textBoxPasswortBestätigen.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxPasswortBestätigen.Name = "textBoxPasswortBestätigen"
        Me.textBoxPasswortBestätigen.Size = New System.Drawing.Size(68, 22)
        Me.textBoxPasswortBestätigen.TabIndex = 4
        '
        'buttonRegistrieren
        '
        Me.buttonRegistrieren.Location = New System.Drawing.Point(355, 204)
        Me.buttonRegistrieren.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonRegistrieren.Name = "buttonRegistrieren"
        Me.buttonRegistrieren.Size = New System.Drawing.Size(93, 30)
        Me.buttonRegistrieren.TabIndex = 6
        Me.buttonRegistrieren.Text = "Registrieren"
        Me.buttonRegistrieren.UseVisualStyleBackColor = True
        '
        'Registrierung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 288)
        Me.Controls.Add(Me.buttonRegistrieren)
        Me.Controls.Add(Me.Label_PasswortBestätigen)
        Me.Controls.Add(Me.textBoxPasswortBestätigen)
        Me.Controls.Add(Me.Label_NeuesPasswort)
        Me.Controls.Add(Me.textBoxNeuesPasswort)
        Me.Controls.Add(Me.Label_NeuerBenutzername)
        Me.Controls.Add(Me.textBoxBenutzername)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Registrierung"
        Me.Text = "Registrierung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textBoxBenutzername As TextBox
    Friend WithEvents Label_NeuerBenutzername As Label
    Friend WithEvents Label_NeuesPasswort As Label
    Friend WithEvents textBoxNeuesPasswort As TextBox
    Friend WithEvents Label_PasswortBestätigen As Label
    Friend WithEvents textBoxPasswortBestätigen As TextBox
    Friend WithEvents buttonRegistrieren As Button
End Class

