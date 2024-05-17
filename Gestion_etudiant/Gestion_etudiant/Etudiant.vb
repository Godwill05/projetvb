Imports System.Data.OleDb
Public Class Etudiant
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Godwill OUSSOU\Documents\Visual Studio 2015\Projects\Gestion_etudiant\tp.accdb;Persist Security Info=False"
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sexe.SelectedIndexChanged

    End Sub
    Private Sub niveau_combo()
        Dim con As New OleDbConnection(Me.Provider)
        con.Open()
        Dim selection As String = "Select * from Niveau"
        Dim command As New OleDbCommand(selection, con)
        Dim retour As OleDbDataReader
        retour = command.ExecuteReader
        Do While retour.Read
            niveau.Items.Add(retour.Item("Code_niv"))
        Loop

    End Sub

    Private Sub filiere_combo()
        Dim con As New OleDbConnection(Me.Provider)
        con.Open()
        Dim sel As String = "Select * from Filiere"
        Dim command As New OleDbCommand(sel, con)
        Dim retou As OleDbDataReader
        retou = command.ExecuteReader
        Do While retou.Read
            filiere.Items.Add(retou.Item("Code_fil"))
        Loop
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim non, pre, sex, niv, sc, fil As String
        non = nom.Text
        pre = prenom.Text
        sex = sexe.Text
        niv = niveau.Text
        sc = scolarite.Text
        fil = filiere.Text

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "insert into Etudiant (Nom, Prenom, Sexe, Niveau, Scolarite, Code_fil) values ('" & non & "', '" & pre & "', '" & sex & "', '" & niv & "', '" & sc & "', '" & fil & "')"
            Dim command As New OleDbCommand(req, con)
            If command.ExecuteNonQuery > 0 Then
                MessageBox.Show("Enregistrement effectué")
            Else
                MessageBox.Show("Enregistrement non effectué")
            End If
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub niveau_SelectedIndexChanged(sender As Object, e As EventArgs) Handles niveau.SelectedIndexChanged

    End Sub

    Private Sub Etudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sexe.Items.Add("Masculin")
        sexe.Items.Add("Feminin")
        niveau_combo()
        filiere_combo()
    End Sub
End Class