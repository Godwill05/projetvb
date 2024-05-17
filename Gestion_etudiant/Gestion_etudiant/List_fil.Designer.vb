<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_fil
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
        Me.col_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_lib = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.libelle = New System.Windows.Forms.TextBox()
        Me.code_fil = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.an_code = New System.Windows.Forms.Label()
        CType(Me.tableau, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tableau
        '
        Me.tableau.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tableau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableau.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_code, Me.col_lib})
        Me.tableau.Location = New System.Drawing.Point(1, 0)
        Me.tableau.Name = "tableau"
        Me.tableau.Size = New System.Drawing.Size(243, 207)
        Me.tableau.TabIndex = 0
        '
        'col_code
        '
        Me.col_code.HeaderText = "Code filiere"
        Me.col_code.Name = "col_code"
        '
        'col_lib
        '
        Me.col_lib.HeaderText = "Libellé"
        Me.col_lib.Name = "col_lib"
        '
        'libelle
        '
        Me.libelle.Location = New System.Drawing.Point(331, 87)
        Me.libelle.Name = "libelle"
        Me.libelle.Size = New System.Drawing.Size(198, 20)
        Me.libelle.TabIndex = 31
        '
        'code_fil
        '
        Me.code_fil.Location = New System.Drawing.Point(403, 49)
        Me.code_fil.Name = "code_fil"
        Me.code_fil.Size = New System.Drawing.Size(128, 20)
        Me.code_fil.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Libellé"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(271, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Nouveau code fil"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(367, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 32)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "Supprimer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(275, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(256, 32)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Charger pour modifier"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(273, 175)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(86, 32)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Modifier"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(269, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Code fil"
        '
        'an_code
        '
        Me.an_code.AutoSize = True
        Me.an_code.Location = New System.Drawing.Point(358, 17)
        Me.an_code.Name = "an_code"
        Me.an_code.Size = New System.Drawing.Size(0, 13)
        Me.an_code.TabIndex = 42
        '
        'List_fil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 247)
        Me.Controls.Add(Me.an_code)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.libelle)
        Me.Controls.Add(Me.code_fil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tableau)
        Me.Name = "List_fil"
        Me.Text = "List_fil"
        CType(Me.tableau, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tableau As DataGridView
    Friend WithEvents libelle As TextBox
    Friend WithEvents code_fil As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents col_code As DataGridViewTextBoxColumn
    Friend WithEvents col_lib As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents an_code As Label
End Class
