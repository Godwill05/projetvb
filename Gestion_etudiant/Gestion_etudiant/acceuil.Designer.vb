<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class acceuil
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OuvrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EtudiantsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.FilieresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.NiveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeEtudiantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeDesFilieresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OuvrirToolStripMenuItem, Me.ListeEtudiantToolStripMenuItem, Me.ListeDesFilieresToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(309, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OuvrirToolStripMenuItem
        '
        Me.OuvrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EtudiantsToolStripMenuItem, Me.ToolStripMenuItem1, Me.FilieresToolStripMenuItem, Me.ToolStripMenuItem2, Me.NiveauToolStripMenuItem})
        Me.OuvrirToolStripMenuItem.Name = "OuvrirToolStripMenuItem"
        Me.OuvrirToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.OuvrirToolStripMenuItem.Text = "Ouvrir"
        '
        'EtudiantsToolStripMenuItem
        '
        Me.EtudiantsToolStripMenuItem.Name = "EtudiantsToolStripMenuItem"
        Me.EtudiantsToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.EtudiantsToolStripMenuItem.Text = "Etudiants"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'FilieresToolStripMenuItem
        '
        Me.FilieresToolStripMenuItem.Name = "FilieresToolStripMenuItem"
        Me.FilieresToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.FilieresToolStripMenuItem.Text = "Filieres"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(149, 6)
        '
        'NiveauToolStripMenuItem
        '
        Me.NiveauToolStripMenuItem.Name = "NiveauToolStripMenuItem"
        Me.NiveauToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NiveauToolStripMenuItem.Text = "Niveau"
        '
        'ListeEtudiantToolStripMenuItem
        '
        Me.ListeEtudiantToolStripMenuItem.Name = "ListeEtudiantToolStripMenuItem"
        Me.ListeEtudiantToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ListeEtudiantToolStripMenuItem.Text = "Liste etudiant"
        '
        'ListeDesFilieresToolStripMenuItem
        '
        Me.ListeDesFilieresToolStripMenuItem.Name = "ListeDesFilieresToolStripMenuItem"
        Me.ListeDesFilieresToolStripMenuItem.Size = New System.Drawing.Size(101, 20)
        Me.ListeDesFilieresToolStripMenuItem.Text = "Liste des filieres"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(56, 20)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "acceuil"
        Me.Text = "Acceuil"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OuvrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EtudiantsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents FilieresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents NiveauToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeEtudiantToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeDesFilieresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
End Class
