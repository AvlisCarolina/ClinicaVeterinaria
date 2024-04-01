Imports System.Data
Imports MySqlConnector

Public Class InserirCliente
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")
        Try

            Dim nif As String
            Dim nome As String
            Dim morada As String
            Dim contacto As String

            nif = txtNif.Text
            nome = txtNome.Text
            morada = txtMorada.Text
            contacto = txtContacto.Text

            paocomchourico.Open()
            Dim Command As New MySqlCommand("INSERT INTO clientes(NIF,Nome,Morada,Contacto) VALUES (" + nif + ",'" + nome + "','" + morada + "','" + contacto + "')", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MsgBox("Inserido com sucesso.")
        Catch ex As Exception
            MsgBox("ERRO: Não inserido." + ex.ToString)
        End Try

    End Sub

End Class
