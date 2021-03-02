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
        Me.Button_Login = New System.Windows.Forms.Button()
        Me.Label_email = New System.Windows.Forms.Label()
        Me.Label_passwort = New System.Windows.Forms.Label()
        Me.TextBox_email = New System.Windows.Forms.TextBox()
        Me.TextBox_passwort = New System.Windows.Forms.TextBox()
        Me.Button_Kontoanlegen = New System.Windows.Forms.Button()
        Me.PictureBox_LPFn = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox_LPFn, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label_email.BackColor = System.Drawing.Color.Transparent
        Me.Label_email.Location = New System.Drawing.Point(443, 78)
        Me.Label_email.Name = "Label_email"
        Me.Label_email.Size = New System.Drawing.Size(79, 25)
        Me.Label_email.TabIndex = 1
        Me.Label_email.Text = "E-Mail:"
        '
        'Label_passwort
        '
        Me.Label_passwort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_passwort.AutoSize = True
        Me.Label_passwort.BackColor = System.Drawing.Color.Transparent
        Me.Label_passwort.Location = New System.Drawing.Point(443, 178)
        Me.Label_passwort.Name = "Label_passwort"
        Me.Label_passwort.Size = New System.Drawing.Size(100, 25)
        Me.Label_passwort.TabIndex = 2
        Me.Label_passwort.Text = "Passwort"
        '
        'TextBox_email
        '
        Me.TextBox_email.Location = New System.Drawing.Point(573, 78)
        Me.TextBox_email.Name = "TextBox_email"
        Me.TextBox_email.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_email.TabIndex = 3
        '
        'TextBox_passwort
        '
        Me.TextBox_passwort.Location = New System.Drawing.Point(573, 178)
        Me.TextBox_passwort.Name = "TextBox_passwort"
        Me.TextBox_passwort.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_passwort.TabIndex = 4
        '
        'Button_Kontoanlegen
        '
        Me.Button_Kontoanlegen.Location = New System.Drawing.Point(441, 300)
        Me.Button_Kontoanlegen.Name = "Button_Kontoanlegen"
        Me.Button_Kontoanlegen.Size = New System.Drawing.Size(182, 52)
        Me.Button_Kontoanlegen.TabIndex = 5
        Me.Button_Kontoanlegen.Text = "Konto anlegen"
        Me.Button_Kontoanlegen.UseVisualStyleBackColor = True
        '
        'PictureBox_LPFn
        '
        Me.PictureBox_LPFn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_LPFn.BackgroundImage = CType(resources.GetObject("PictureBox_LPFn.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox_LPFn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox_LPFn.InitialImage = Nothing
        Me.PictureBox_LPFn.Location = New System.Drawing.Point(-3, -1)
        Me.PictureBox_LPFn.Name = "PictureBox_LPFn"
        Me.PictureBox_LPFn.Size = New System.Drawing.Size(802, 452)
        Me.PictureBox_LPFn.TabIndex = 6
        Me.PictureBox_LPFn.TabStop = False
        '
        'Landingpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_Kontoanlegen)
        Me.Controls.Add(Me.TextBox_passwort)
        Me.Controls.Add(Me.TextBox_email)
        Me.Controls.Add(Me.Label_passwort)
        Me.Controls.Add(Me.Label_email)
        Me.Controls.Add(Me.Button_Login)
        Me.Controls.Add(Me.PictureBox_LPFn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Landingpage"
        Me.Text = "Landingpage"
        CType(Me.PictureBox_LPFn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Login As Button
    Friend WithEvents Label_email As Label
    Friend WithEvents Label_passwort As Label
    Friend WithEvents TextBox_email As TextBox
    Friend WithEvents TextBox_passwort As TextBox
    Friend WithEvents Button_Kontoanlegen As Button
    Friend WithEvents PictureBox_LPFn As PictureBox
End Class

