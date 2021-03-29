<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Landingpage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Landingpage))
        Me.buttonLogin = New System.Windows.Forms.Button()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.labelPasswort = New System.Windows.Forms.Label()
        Me.textBoxBenutzername = New System.Windows.Forms.TextBox()
        Me.textBoxPasswort = New System.Windows.Forms.TextBox()
        Me.buttonKontoanlegen = New System.Windows.Forms.Button()
        Me.PictureBox_LPFn = New System.Windows.Forms.PictureBox()
        Me.buttonOhneAnmelden = New System.Windows.Forms.Button()
        CType(Me.PictureBox_LPFn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonLogin
        '
        Me.buttonLogin.Location = New System.Drawing.Point(440, 192)
        Me.buttonLogin.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(65, 33)
        Me.buttonLogin.TabIndex = 0
        Me.buttonLogin.Text = "Login"
        Me.buttonLogin.UseVisualStyleBackColor = True
        '
        'labelEmail
        '
        Me.labelEmail.AutoSize = True
        Me.labelEmail.BackColor = System.Drawing.Color.Transparent
        Me.labelEmail.Location = New System.Drawing.Point(269, 50)
        Me.labelEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelEmail.Name = "labelEmail"
        Me.labelEmail.Size = New System.Drawing.Size(100, 17)
        Me.labelEmail.TabIndex = 1
        Me.labelEmail.Text = "Benutzername"
        '
        'labelPasswort
        '
        Me.labelPasswort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelPasswort.AutoSize = True
        Me.labelPasswort.BackColor = System.Drawing.Color.Transparent
        Me.labelPasswort.Location = New System.Drawing.Point(307, 116)
        Me.labelPasswort.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelPasswort.Name = "labelPasswort"
        Me.labelPasswort.Size = New System.Drawing.Size(65, 17)
        Me.labelPasswort.TabIndex = 2
        Me.labelPasswort.Text = "Passwort"
        '
        'textBoxBenutzername
        '
        Me.textBoxBenutzername.Location = New System.Drawing.Point(382, 50)
        Me.textBoxBenutzername.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxBenutzername.Name = "textBoxBenutzername"
        Me.textBoxBenutzername.Size = New System.Drawing.Size(68, 22)
        Me.textBoxBenutzername.TabIndex = 3
        '
        'textBoxPasswort
        '
        Me.textBoxPasswort.Location = New System.Drawing.Point(382, 114)
        Me.textBoxPasswort.Margin = New System.Windows.Forms.Padding(2)
        Me.textBoxPasswort.Name = "textBoxPasswort"
        Me.textBoxPasswort.Size = New System.Drawing.Size(68, 22)
        Me.textBoxPasswort.TabIndex = 4
        '
        'buttonKontoanlegen
        '
        Me.buttonKontoanlegen.Location = New System.Drawing.Point(294, 192)
        Me.buttonKontoanlegen.Margin = New System.Windows.Forms.Padding(2)
        Me.buttonKontoanlegen.Name = "buttonKontoanlegen"
        Me.buttonKontoanlegen.Size = New System.Drawing.Size(121, 33)
        Me.buttonKontoanlegen.TabIndex = 5
        Me.buttonKontoanlegen.Text = "Konto anlegen"
        Me.buttonKontoanlegen.UseVisualStyleBackColor = True
        '
        'PictureBox_LPFn
        '
        Me.PictureBox_LPFn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_LPFn.BackgroundImage = CType(resources.GetObject("PictureBox_LPFn.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox_LPFn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox_LPFn.InitialImage = Nothing
        Me.PictureBox_LPFn.Location = New System.Drawing.Point(-2, -1)
        Me.PictureBox_LPFn.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox_LPFn.Name = "PictureBox_LPFn"
        Me.PictureBox_LPFn.Size = New System.Drawing.Size(535, 289)
        Me.PictureBox_LPFn.TabIndex = 6
        Me.PictureBox_LPFn.TabStop = False
        '
        'buttonOhneAnmelden
        '
        Me.buttonOhneAnmelden.Location = New System.Drawing.Point(77, 192)
        Me.buttonOhneAnmelden.Name = "buttonOhneAnmelden"
        Me.buttonOhneAnmelden.Size = New System.Drawing.Size(165, 33)
        Me.buttonOhneAnmelden.TabIndex = 7
        Me.buttonOhneAnmelden.Text = "Ohne Anmeldung"
        Me.buttonOhneAnmelden.UseVisualStyleBackColor = True
        '
        'Landingpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(533, 288)
        Me.Controls.Add(Me.buttonOhneAnmelden)
        Me.Controls.Add(Me.buttonKontoanlegen)
        Me.Controls.Add(Me.textBoxPasswort)
        Me.Controls.Add(Me.textBoxBenutzername)
        Me.Controls.Add(Me.labelPasswort)
        Me.Controls.Add(Me.labelEmail)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.PictureBox_LPFn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Landingpage"
        Me.Text = "Landingpage"
        CType(Me.PictureBox_LPFn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonLogin As Button
    Friend WithEvents labelEmail As Label
    Friend WithEvents labelPasswort As Label
    Friend WithEvents textBoxBenutzername As TextBox
    Friend WithEvents textBoxPasswort As TextBox
    Friend WithEvents buttonKontoanlegen As Button
    Friend WithEvents PictureBox_LPFn As PictureBox
    Friend WithEvents buttonOhneAnmelden As Button
End Class

