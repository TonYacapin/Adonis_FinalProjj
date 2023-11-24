Imports MySql.Data.MySqlClient

Public Class RequestForm
    Private Sub RequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRequestData()
    End Sub

    Private Sub LoadRequestData()
        Try
            Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT UserID, Username, UserRole FROM login WHERE IsActive = 0"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable

            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
        '    userid_tb.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        '    username_tb.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        '    userrole_tb.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        'End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
        Try
            Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "UPDATE login SET IsActive = 1 WHERE UserId = @UserId"
                Dim cmd As New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@UserId", userid_tb.Text)
                cmd.ExecuteNonQuery()

                ' After updating, reload the data
                LoadRequestData()

                userid_tb.Clear()
                username_tb.Clear()
                userrole_tb.Clear()



            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating data: " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
        Me.Close()
        AdminForm.Show()


    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

            If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
                userid_tb.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
                username_tb.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
                userrole_tb.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Cell is Empty")
        End Try
    End Sub

    Private Sub userid_tb_TextChanged(sender As Object, e As EventArgs) Handles userid_tb.TextChanged
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub
End Class