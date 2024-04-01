Imports MySqlConnector

Public Class InserirPet
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")
        Try

            Dim idChip As String
            Dim nome As String
            Dim nifDono As String
            Dim especieRaca As String

            idChip = txtIDChip.Text
            nome = txtNome.Text
            nifDono = cbNifDono.Text.Split(" ")(0)
            especieRaca = txtEspecieRaca.Text



            paocomchourico.Open()
            Dim Command As New MySqlCommand("INSERT INTO pets(IDChip,Nome,NIFDono,Especie_Raca) VALUES (" + idChip + ",'" + nome + "','" + nifDono + "','" + especieRaca + "')", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()
            MsgBox("Inserido com sucesso.")
        Catch ex As Exception
            MsgBox("ERRO: Não inserido." + ex.ToString)
        End Try
    End Sub

    Private Sub InserirPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")

        Try

            paocomchourico.Open()
            Dim Command As New MySqlCommand("SELECT * FROM clientes", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()

            cbNifDono.Items.Clear()
            While (reader.Read)
                cbNifDono.Items.Add(reader.GetValue(0).ToString + " " + reader.GetValue(1).ToString)
            End While

        Catch ex As Exception
            MsgBox("ERRO:" + ex.ToString)

        End Try
    End Sub
End Class