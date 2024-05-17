Imports System.Data.OleDb
Public Class Filiere
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Godwill OUSSOU\Documents\Visual Studio 2015\Projects\Gestion_etudiant\tp.accdb;Persist Security Info=False"
    Private Sub Filiere_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim code_fi, libel As String
        code_fi = cod_fil.Text
        libel = libelle.Text
        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "insert into Filiere (Code_fil, Libelle) values ('" & code_fi & "', '" & libel & "')"
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
End Class