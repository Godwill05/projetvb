<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_etudiant
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tableau = New System.Windows.Forms.DataGridView()
        Me.col_nom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sexe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_niv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_scol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_fil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.filiere = New System.Windows.Forms.ComboBox()
        Me.niveau = New System.Windows.Forms.ComboBox()
        Me.sexe = New System.Windows.Forms.ComboBox()
        Me.scolarite = New System.Windows.Forms.TextBox()
        Me.prenom = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.num = New System.Windows.Forms.Label()
        CType(Me.tableau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableau
        '
        Me.tableau.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableau.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_nom, Me.col_pre, Me.col_sexe, Me.col_niv, Me.col_scol, Me.col_fil, Me.col_id})
        Me.tableau.Location = New System.Drawing.Point(2, 1)
        Me.tableau.Name = "tableau"
        Me.tableau.Size = New System.Drawing.Size(743, 392)
        Me.tableau.TabIndex = 17
        '
        'col_nom
        '
        Me.col_nom.HeaderText = "Nom"
        Me.col_nom.Name = "col_nom"
        '
        'col_pre
        '
        Me.col_pre.HeaderText = "Prenom"
        Me.col_pre.Name = "col_pre"
        '
        'col_sexe
        '
        Me.col_sexe.HeaderText = "Sexe"
        Me.col_sexe.Name = "col_sexe"
        '
        'col_niv
        '
        Me.col_niv.HeaderText = "Niveau"
        Me.col_niv.Name = "col_niv"
        '
        'col_scol
        '
        Me.col_scol.HeaderText = "Scolarité"
        Me.col_scol.Name = "col_scol"
        '
        'col_fil
        '
        Me.col_fil.HeaderText = "Filiere"
        Me.col_fil.Name = "col_fil"
        '
        'col_id
        '
        Me.col_id.HeaderText = "ID"
        Me.col_id.Name = "col_id"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(790, 335)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 32)
        Me.Button4.TabIndex = 33
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'filiere
        '
        Me.filiere.FormattingEnabled = True
        Me.filiere.Location = New System.Drawing.Point(884, 207)
        Me.filiere.Name = "filiere"
        Me.filiere.Size = New System.Drawing.Size(162, 21)
        Me.filiere.TabIndex = 31
        '
        'niveau
        '
        Me.niveau.FormattingEnabled = True
        Me.niveau.Location = New System.Drawing.Point(884, 170)
        Me.niveau.Name = "niveau"
        Me.niveau.Size = New System.Drawing.Size(162, 21)
        Me.niveau.TabIndex = 30
        '
        'sexe
        '
        Me.sexe.FormattingEnabled = True
        Me.sexe.Location = New System.Drawing.Point(884, 129)
        Me.sexe.Name = "sexe"
        Me.sexe.Size = New System.Drawing.Size(162, 21)
        Me.sexe.TabIndex = 29
        '
        'scolarite
        '
        Me.scolarite.Location = New System.Drawing.Point(884, 247)
        Me.scolarite.Name = "scolarite"
        Me.scolarite.Size = New System.Drawing.Size(162, 20)
        Me.scolarite.TabIndex = 28
        '
        'prenom
        '
        Me.prenom.Location = New System.Drawing.Point(884, 95)
        Me.prenom.Name = "prenom"
        Me.prenom.Size = New System.Drawing.Size(162, 20)
        Me.prenom.TabIndex = 27
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(884, 60)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(162, 20)
        Me.nom.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(786, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Scolarite"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(786, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Filiere"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(786, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Niveau"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(786, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Sexe"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(786, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Prenom"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(786, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Nom"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(786, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 20)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Id"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(790, 282)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(256, 32)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Charger pour modifier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(884, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 32)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'num
        '
        Me.num.AutoSize = True
        Me.num.Location = New System.Drawing.Point(884, 20)
        Me.num.Name = "num"
        Me.num.Size = New System.Drawing.Size(0, 13)
        Me.num.TabIndex = 38
        '
        'List_etudiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 405)
        Me.Controls.Add(Me.num)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
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
        Me.Controls.Add(Me.tableau)
        Me.Name = "List_etudiant"
        Me.Text = "List_etudiant"
        CType(Me.tableau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tableau As DataGridView
    Friend WithEvents col_nom As DataGridViewTextBoxColumn
    Friend WithEvents col_pre As DataGridViewTextBoxColumn
    Friend WithEvents col_sexe As DataGridViewTextBoxColumn
    Friend WithEvents col_niv As DataGridViewTextBoxColumn
    Friend WithEvents col_scol As DataGridViewTextBoxColumn
    Friend WithEvents col_fil As DataGridViewTextBoxColumn
    Friend WithEvents col_id As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents filiere As ComboBox
    Friend WithEvents niveau As ComboBox
    Friend WithEvents sexe As ComboBox
    Friend WithEvents scolarite As TextBox
    Friend WithEvents prenom As TextBox
    Friend WithEvents nom As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents num As Label
End Class
