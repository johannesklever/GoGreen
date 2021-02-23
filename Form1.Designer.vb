<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Label_email = New System.Windows.Forms.Label()
        Me.Label_passwort = New System.Windows.Forms.Label()
        Me.TextBox_email = New System.Windows.Forms.TextBox()
        Me.TextBox_passwort = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button_Login
        '
        Me.Button_Login.Location = New System.Drawing.Point(660, 300)
        Me.Button_Login.Name = "Button_Login"
        Me.Button_Login.Size = New System.Drawing.Size(98, 52)
        Me.Button_Login.TabIndex = 0
        Me.Button_Login.Text = "Login"
        Me.Button_Login.UseVisualStyleBackColor = True
        '
        'Label_email
        '
        Me.Label_email.AutoSize = True
        Me.Label_email.Location = New System.Drawing.Point(436, 112)
        Me.Label_email.Name = "Label_email"
        Me.Label_email.Size = New System.Drawing.Size(79, 25)
        Me.Label_email.TabIndex = 1
        Me.Label_email.Text = "E-Mail:"
        '
        'Label_passwort
        '
        Me.Label_passwort.AutoSize = True
        Me.Label_passwort.Location = New System.Drawing.Point(436, 212)
        Me.Label_passwort.Name = "Label_passwort"
        Me.Label_passwort.Size = New System.Drawing.Size(100, 25)
        Me.Label_passwort.TabIndex = 2
        Me.Label_passwort.Text = "Passwort"
        '
        'TextBox_email
        '
        Me.TextBox_email.Location = New System.Drawing.Point(566, 112)
        Me.TextBox_email.Name = "TextBox_email"
        Me.TextBox_email.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_email.TabIndex = 3
        '
        'TextBox_passwort
        '
        Me.TextBox_passwort.Location = New System.Drawing.Point(566, 212)
        Me.TextBox_passwort.Name = "TextBox_passwort"
        Me.TextBox_passwort.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_passwort.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox_passwort)
        Me.Controls.Add(Me.TextBox_email)
        Me.Controls.Add(Me.Label_passwort)
        Me.Controls.Add(Me.Label_email)
        Me.Controls.Add(Me.Button_Login)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Login As Button
    Friend WithEvents Label_email As Label
    Friend WithEvents Label_passwort As Label
    Friend WithEvents TextBox_email As TextBox
    Friend WithEvents TextBox_passwort As TextBox
End Class
