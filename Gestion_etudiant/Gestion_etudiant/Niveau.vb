Imports System.Data.OleDb
Public Class Niveau
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Godwill OUSSOU\Documents\Visual Studio 2015\Projects\Gestion_etudiant\tp.accdb;Persist Security Info=False"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim code_ni, inti As String
        code_ni = cod_niv.Text
        inti = libelle_niv.Text
        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "Insert into Niveau (Code_niv,intitule) values ('" & code_ni & "','" & inti & "')"
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

    Private Sub Niveau_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class