Imports MySql.Data.MySqlClient

Public Class VIEW_ORDERRECORDS
    Private Sub VIEW_ORDERRECORDS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadORDERRECORDSData()


    End Sub

    Private Sub LoadORDERRECORDSData()
        Try
            Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM orders"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                DataGridView2.DataSource = dataTable

            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
        Me.Close()
        AdminForm.Show()




    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub
End Class