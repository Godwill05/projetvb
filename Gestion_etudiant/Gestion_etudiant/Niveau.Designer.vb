<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Niveau
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
        Me.cod_niv = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.libelle_niv = New System.Windows.Forms.TextBox()
        Me.intitule = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cod_niv
        '
        Me.cod_niv.Location = New System.Drawing.Point(106, 50)
        Me.cod_niv.Multiline = True
        Me.cod_niv.Name = "cod_niv"
        Me.cod_niv.Size = New System.Drawing.Size(162, 28)
        Me.cod_niv.TabIndex = 22
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(21, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(247, 32)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Enregistrer la filiere"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'libelle_niv
        '
        Me.libelle_niv.Location = New System.Drawing.Point(106, 110)
        Me.libelle_niv.Multiline = True
        Me.libelle_niv.Name = "libelle_niv"
        Me.libelle_niv.Size = New System.Drawing.Size(162, 28)
        Me.libelle_niv.TabIndex = 20
        '
        'intitule
        '
        Me.intitule.AutoSize = True
        Me.intitule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.intitule.Location = New System.Drawing.Point(17, 118)
        Me.intitule.Name = "intitule"
        Me.intitule.Size = New System.Drawing.Size(57, 20)
        Me.intitule.TabIndex = 19
        Me.intitule.Text = "Intitule"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Code"
        '
        'Niveau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.cod_niv)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.libelle_niv)
        Me.Controls.Add(Me.intitule)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Niveau"
        Me.Text = "Niveau"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cod_niv As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents libelle_niv As TextBox
    Friend WithEvents intitule As Label
    Friend WithEvents Label1 As Label
End Class
