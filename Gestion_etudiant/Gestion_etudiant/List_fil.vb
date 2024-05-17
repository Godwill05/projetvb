
Imports System.Data.OleDb
Public Class List_fil
    Private Provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Godwill OUSSOU\Documents\Visual Studio 2015\Projects\Gestion_etudiant\tp.accdb;Persist Security Info=False"
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub afficher()
        Dim con As New OleDbConnection(Me.Provider)
        con.Open()
        Dim sel As String = "Select * from Filiere"
        Dim command As New OleDbCommand(sel, con)
        Dim ret As OleDbDataReader
        ret = command.ExecuteReader
        tableau.Rows.Clear()
        Do While ret.Read
            tableau.Rows.Add(ret.Item("Code_fil"), ret.Item("Libelle"))
        Loop

    End Sub

    Private Sub List_fil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call afficher()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        code_fil.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(0).Value
        an_code.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(0).Value
        libelle.Text = tableau.Rows(tableau.CurrentRow.Index).Cells(1).Value
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim new_code, new_lab, id As String
        new_code = code_fil.Text
        new_lab = libelle.Text
        id = an_code.Text

        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "update Filiere set Code_fil = '" & new_code & "', Libelle = '" & new_lab & "' where Code_fil ='" & id & "'"
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
        id = tableau.Rows(tableau.CurrentRow.Index).Cells(0).Value
        Try
            Dim con As New OleDbConnection(Me.Provider)
            con.Open()
            Dim req As String = "Delete * from Filiere where Code_fil ='" & id & "'"
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

    Private Sub tableau_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableau.CellContentClick

    End Sub
End Class