Imports MySqlConnector

Public Class InserirConsulta
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")
        Try

            Dim idChip As String
            Dim sintomas As String
            Dim tratamento As String

            idChip = cbChipPet.Text.Split(" ")(0)
            sintomas = rtbSintomas.Text
            tratamento = rtbTratamento.Text



            paocomchourico.Open()
            Dim Command As New MySqlCommand("INSERT INTO consultas(IDChipPets,Sintomas,Tratamento) VALUES (" + idChip + ",'" + sintomas + "','" + tratamento + "')", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MsgBox("Inserido com sucesso.")
        Catch ex As Exception
            MsgBox("ERRO: Não inserido." + ex.ToString)
        End Try
    End Sub

    Private Sub InserirConsulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")

        Try

            paocomchourico.Open()
            Dim Command As New MySqlCommand("SELECT * FROM pets", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()

            cbChipPet.Items.Clear()
            While (reader.Read)
                cbChipPet.Items.Add(reader.GetValue(0).ToString + " " + reader.GetValue(1).ToString)
            End While

        Catch ex As Exception
            MsgBox("ERRO: " + ex.ToString)

        End Try
    End Sub
End Class