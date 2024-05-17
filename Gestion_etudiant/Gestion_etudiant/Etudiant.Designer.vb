<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Etudiant
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.prenom = New System.Windows.Forms.TextBox()
        Me.scolarite = New System.Windows.Forms.TextBox()
        Me.sexe = New System.Windows.Forms.ComboBox()
        Me.niveau = New System.Windows.Forms.ComboBox()
        Me.filiere = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Prenom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sexe"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Niveau"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Filiere"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Scolarite"
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(110, 34)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(162, 20)
        Me.nom.TabIndex = 6
        '
        'prenom
        '
        Me.prenom.Location = New System.Drawing.Point(110, 69)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(162, 20)
        Me.prenom.TabIndex = 7
        '
        'scolarite
        '
        Me.scolarite.Location = New System.Drawing.Point(110, 221)
        Me.scolarite.Name = "scolarite"
        Me.scolarite.Size = New System.Drawing.Size(162, 20)
        Me.scolarite.TabIndex = 11
        '
        'sexe
        '
        Me.sexe.FormattingEnabled = True
        Me.sexe.Location = New System.Drawing.Point(110, 103)
        Me.sexe.Name = "sexe"
        Me.sexe.Size = New System.Drawing.Size(162, 21)
        Me.sexe.TabIndex = 12
        '
        'niveau
        '
        Me.niveau.FormattingEnabled = True
        Me.niveau.Location = New System.Drawing.Point(110, 144)
        Me.niveau.Name = "niveau"
        Me.niveau.Size = New System.Drawing.Size(162, 21)
        Me.niveau.TabIndex = 13
        '
        'filiere
        '
        Me.filiere.FormattingEnabled = True
        Me.filiere.Location = New System.Drawing.Point(110, 181)
        Me.filiere.Name = "filiere"
        Me.filiere.Size = New System.Drawing.Size(162, 21)
        Me.filiere.TabIndex = 14
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(16, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 32)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Enregistrer l'étudiant"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Etudiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 337)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.filiere)
        Me.Controls.Add(Me.niveau)
        Me.Controls.Add(Me.sexe)
        Me.Controls.Add(Me.scolarite)
        Me.Controls.Add(Me.prenom)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Etudiant"
        Me.Text = "Ajout d'etudiant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents nom As TextBox
    Friend WithEvents prenom As TextBox
    Friend WithEvents scolarite As TextBox
    Friend WithEvents sexe As ComboBox
    Friend WithEvents niveau As ComboBox
    Friend WithEvents filiere As ComboBox
    Friend WithEvents Button1 As Button
End Class
