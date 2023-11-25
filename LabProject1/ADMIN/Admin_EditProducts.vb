Imports LabProject1.CashierForm
Imports MySql.Data.MySqlClient

Public Class Admin_EditProducts
    Private Sub Admin_EditProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM products"
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
        '    tb_price.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        '    tb_stockquantity.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value

        '    lbl_productname.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        'End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        AdminForm.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Define your MySQL connection string
        Dim connectionString As String = "server=localhost;user=root;password=root;database=db_burgeran;"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Update the products table with the new information
                Dim sql As String = "UPDATE products SET StockQuantity = @stockQuantity, Price = @price WHERE Name = @Name;"

                Using cmd As New MySqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@price", tb_price.Text)
                    cmd.Parameters.AddWithValue("@stockQuantity", tb_stockquantity.Text)
                    cmd.Parameters.AddWithValue("@Name", lbl_productname.Text)

                    cmd.ExecuteNonQuery()
                End Using

                ' Refresh the DataGridView with the updated data
                Dim adapter As New MySqlDataAdapter("SELECT * FROM products", connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)
                DataGridView1.DataSource = dataTable

                ' Show a confirmation message to the user
                MessageBox.Show("Product changed successfully.")

                CRUD_USER_FORM.UpdateSURecords(AdminForm.lbl_username.Text, "Changed an Item: " + lbl_productname.Text)



            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while setting product: " & ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        Try



            If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
                tb_price.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
                tb_stockquantity.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value

                lbl_productname.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
            End If


        Catch ex As Exception



            MessageBox.Show("No Cell Clicked")
        End Try
    End Sub
End Class
