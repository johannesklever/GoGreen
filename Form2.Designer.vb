<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.TextBox_NeuerBenutzername.Location = New System.Drawing.Point(532, 105)
        Me.TextBox_NeuerBenutzername.Name = "TextBox_NeuerBenutzername"
        Me.TextBox_NeuerBenutzername.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_NeuerBenutzername.TabIndex = 0
        '
        'Label_NeuerBenutzername
        '
        Me.Label_NeuerBenutzername.AutoSize = True
        Me.Label_NeuerBenutzername.Location = New System.Drawing.Point(285, 111)
        Me.Label_NeuerBenutzername.Name = "Label_NeuerBenutzername"
        Me.Label_NeuerBenutzername.Size = New System.Drawing.Size(221, 25)
        Me.Label_NeuerBenutzername.TabIndex = 1
        Me.Label_NeuerBenutzername.Text = "Neuer Benutzername:"
        '
        'Label_NeuesPasswort
        '
        Me.Label_NeuesPasswort.AutoSize = True
        Me.Label_NeuesPasswort.Location = New System.Drawing.Point(285, 184)
        Me.Label_NeuesPasswort.Name = "Label_NeuesPasswort"
        Me.Label_NeuesPasswort.Size = New System.Drawing.Size(174, 25)
        Me.Label_NeuesPasswort.TabIndex = 3
        Me.Label_NeuesPasswort.Text = "Neues Passwort:"
        '
        'TextBox_NeuesPasswort
        '
        Me.TextBox_NeuesPasswort.Location = New System.Drawing.Point(532, 178)
        Me.TextBox_NeuesPasswort.Name = "TextBox_NeuesPasswort"
        Me.TextBox_NeuesPasswort.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_NeuesPasswort.TabIndex = 2
        '
        'Label_PasswortBestätigen
        '
        Me.Label_PasswortBestätigen.AutoSize = True
        Me.Label_PasswortBestätigen.Location = New System.Drawing.Point(285, 256)
        Me.Label_PasswortBestätigen.Name = "Label_PasswortBestätigen"
        Me.Label_PasswortBestätigen.Size = New System.Drawing.Size(212, 25)
        Me.Label_PasswortBestätigen.TabIndex = 5
        Me.Label_PasswortBestätigen.Text = "Passwort bestätigen:"
        '
        'TextBox_PasswortBestätigen
        '
        Me.TextBox_PasswortBestätigen.Location = New System.Drawing.Point(532, 256)
        Me.TextBox_PasswortBestätigen.Name = "TextBox_PasswortBestätigen"
        Me.TextBox_PasswortBestätigen.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_PasswortBestätigen.TabIndex = 4
        '
        'Button_Registrieren
        '
        Me.Button_Registrieren.Location = New System.Drawing.Point(532, 319)
        Me.Button_Registrieren.Name = "Button_Registrieren"
        Me.Button_Registrieren.Size = New System.Drawing.Size(139, 47)
        Me.Button_Registrieren.TabIndex = 6
        Me.Button_Registrieren.Text = "Registrieren"
        Me.Button_Registrieren.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Registrieren)
        Me.Controls.Add(Me.Label_PasswortBestätigen)
        Me.Controls.Add(Me.TextBox_PasswortBestätigen)
        Me.Controls.Add(Me.Label_NeuesPasswort)
        Me.Controls.Add(Me.TextBox_NeuesPasswort)
        Me.Controls.Add(Me.Label_NeuerBenutzername)
        Me.Controls.Add(Me.TextBox_NeuerBenutzername)
        Me.Name = "Form2"
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
