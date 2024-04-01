Imports MySqlConnector

Public Class ListarConsultas
    Private Sub ListarConsultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paocomchourico As New MySqlConnection("Server=127.0.0.1;User ID=root;Port=3306;Database=clinicaveterinaria")

        Try

            paocomchourico.Open()
            Dim Command As New MySqlCommand("SELECT * FROM consultas", paocomchourico)
            Dim reader As MySqlDataReader
            reader = Command.ExecuteReader()

            'ListBox1.Items.Clear()
            ListBox1.Items.Add("        ID_Consulta             ID_Chip Pet                Sintoma                Tratamento")
            ListBox1.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------")
            While (reader.Read)
                ListBox1.Items.Add(reader.GetValue(0).ToString + "  |  " + reader.GetValue(1).ToString + "  |  " + reader.GetValue(2).ToString + "  |  " + reader.GetValue(3).ToString)
                ListBox1.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------")
            End While

        Catch ex As Exception
            MsgBox("ERRO: " + ex.ToString)

        End Try
    End Sub
End Class