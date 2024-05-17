Imports System.Data.OleDb
Public Class List_etudiant
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Godwill OUSSOU\Documents\Visual Studio 2015\Projects\Gestion_etudiant\tp.accdb;Persist Security Info=False"
    Private Sub List_etudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher()
    End Sub

    Private Sub afficher()
        Dim con As New OleDbConnection(Me.Provider)
        con.Open()
        Dim sel As String = "Select * from Etudiant"
        Dim command As New OleDbCommand(sel, con)
        Dim ret As OleDbDataReader
        ret = command.ExecuteReader
        tableau.Rows.Clear()
        Do While ret.Read
            tableau.Rows.Add(ret.Item("Nom"), ret.Item("Prenom"), ret.Item("Sexe"), ret.Item("Niveau"), ret.Item("Scolarite"), ret.Item("Code_fil"), ret.Item("id"))
        Loop

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        nom.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(0).Value
        prenom.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(1).Value
        sexe.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(2).Value
        niveau.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(3).Value
        scolarite.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(4).Value
        filiere.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(5).Value
        num.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(6).Value
    End Sub

    Private Sub tableau_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableau.CellContentClick

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim non, pre, sex, niv, fil, id, sc As String
        non = nom.Text
        pre = prenom.Text
        sex = sexe.Text
        niv = niveau.Text
        sc = scolarite.Text
        fil = filiere.Text
        id = num.Text

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "update Etudiant set Nom = '" & non & "', Prenom = '" & pre & "', Sexe = '" & sex & "', Niveau = '" & niv & "', Scolarite = '" & sc & "', Code_fil = '" & fil & "' where id =" & id
            Dim command As New OleDbCommand(req, con)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Modificaton effectué")
                Call afficher()
            Else
                MessageBox.Show("Modificaton non effectué")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As String
        id = tableau.Rows(tableau.CurrentRow.Index).Cells(6).Value
        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "Delete * from Etudiant where id = " & id
            Dim command As New OleDbCommand(req, con)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Suppression effectué")
                Call afficher()
            Else
                MessageBox.Show("Suppression non effectué")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class