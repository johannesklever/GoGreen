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
        Me.TextBox_NeuerBenutzername = New System.Windows.Forms.TextBox()
        Me.Label_NeuerBenutzername = New System.Windows.Forms.Label()
        Me.Label_NeuesPasswort = New System.Windows.Forms.Label()
        Me.TextBox_NeuesPasswort = New System.Windows.Forms.TextBox()
        Me.Label_PasswortBestätigen = New System.Windows.Forms.Label()
        Me.TextBox_PasswortBestätigen = New System.Windows.Forms.TextBox()
        Me.Button_Registrieren = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox_NeuerBenutzername
        '
        Me.TextBox_NeuerBenutzername.Location = New System.Drawing.Point(355, 67)
        Me.TextBox_NeuerBenutzername.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox_NeuerBenutzername.Name = "TextBox_NeuerBenutzername"
        Me.TextBox_NeuerBenutzername.Size = New System.Drawing.Size(68, 22)
        Me.TextBox_NeuerBenutzername.TabIndex = 0
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
        'TextBox_NeuesPasswort
        '
        Me.TextBox_NeuesPasswort.Location = New System.Drawing.Point(355, 114)
        Me.TextBox_NeuesPasswort.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox_NeuesPasswort.Name = "TextBox_NeuesPasswort"
        Me.TextBox_NeuesPasswort.Size = New System.Drawing.Size(68, 22)
        Me.TextBox_NeuesPasswort.TabIndex = 2
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
        'TextBox_PasswortBestätigen
        '
        Me.TextBox_PasswortBestätigen.Location = New System.Drawing.Point(355, 164)
        Me.TextBox_PasswortBestätigen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TextBox_PasswortBestätigen.Name = "TextBox_PasswortBestätigen"
        Me.TextBox_PasswortBestätigen.Size = New System.Drawing.Size(68, 22)
        Me.TextBox_PasswortBestätigen.TabIndex = 4
        '
        'Button_Registrieren
        '
        Me.Button_Registrieren.Location = New System.Drawing.Point(355, 204)
        Me.Button_Registrieren.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button_Registrieren.Name = "Button_Registrieren"
        Me.Button_Registrieren.Size = New System.Drawing.Size(93, 30)
        Me.Button_Registrieren.TabIndex = 6
        Me.Button_Registrieren.Text = "Registrieren"
        Me.Button_Registrieren.UseVisualStyleBackColor = True
        '
        'Registrierung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 288)
        Me.Controls.Add(Me.Button_Registrieren)
        Me.Controls.Add(Me.Label_PasswortBestätigen)
        Me.Controls.Add(Me.TextBox_PasswortBestätigen)
        Me.Controls.Add(Me.Label_NeuesPasswort)
        Me.Controls.Add(Me.TextBox_NeuesPasswort)
        Me.Controls.Add(Me.Label_NeuerBenutzername)
        Me.Controls.Add(Me.TextBox_NeuerBenutzername)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Registrierung"
        Me.Text = "Registrierung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_NeuerBenutzername As TextBox
    Friend WithEvents Label_NeuerBenutzername As Label
    Friend WithEvents Label_NeuesPasswort As Label
    Friend WithEvents TextBox_NeuesPasswort As TextBox
    Friend WithEvents Label_PasswortBestätigen As Label
    Friend WithEvents TextBox_PasswortBestätigen As TextBox
    Friend WithEvents Button_Registrieren As Button
End Class

