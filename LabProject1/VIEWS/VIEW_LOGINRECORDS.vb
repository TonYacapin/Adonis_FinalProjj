Imports MySql.Data.MySqlClient

Public Class VIEW_LOGINRECORDS
    Private Sub VIEW_LOGINRECORDS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLOGINRECORDSSData()


    End Sub

    Private Sub LoadLOGINRECORDSSData()
        Try
            Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM loginrecords"
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
        ManagerForm.UserActivity.Stop()
        ManagerForm.UserActivity.Start()
        Me.Close()
        AdminForm.Show()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
        ManagerForm.UserActivity.Stop()
        ManagerForm.UserActivity.Start()
    End Sub
End Class