Public Class Menu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inserirCliente = New InserirCliente
        inserirCliente.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim listarClientes = New ListarClientes
        listarClientes.SetDesktopLocation(400, 200)
        listarClientes.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim inserirPet = New InserirPet
        inserirPet.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim listarPets = New ListarPets With {
            .Location = New Point(500, 200)
        }
        listarPets.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim inserirConsulta = New InserirConsulta With {
            .Location = New Point(300, 200)
        }
        inserirConsulta.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim listarConsultas = New ListarConsultas With {
            .Location = New Point(500, 200)
        }
        listarConsultas.Show()
    End Sub
End Class