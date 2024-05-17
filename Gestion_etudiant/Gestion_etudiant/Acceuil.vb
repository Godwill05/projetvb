Public Class acceuil
    Private Sub acceuil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EtudiantsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EtudiantsToolStripMenuItem.Click
        Dim etu As New Etudiant
        etu.MdiParent = Me
        etu.Show()
    End Sub

    Private Sub FilieresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FilieresToolStripMenuItem.Click
        Dim fil As New Filiere
        fil.MdiParent = Me
        fil.Show()
    End Sub

    Private Sub NiveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NiveauToolStripMenuItem.Click
        Dim niv As New Niveau
        niv.MdiParent = Me
        niv.Show()
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click

    End Sub

    Private Sub ListeEtudiantToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeEtudiantToolStripMenuItem.Click
        Dim list_etu As New List_etudiant
        list_etu.MdiParent = Me
        list_etu.Show()
    End Sub

    Private Sub ListeDesFilieresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeDesFilieresToolStripMenuItem.Click
        Dim list_fil As New List_fil
        list_fil.MdiParent = Me
        list_fil.Show()
    End Sub
End Class
