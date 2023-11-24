Imports MySql.Data.MySqlClient

Public Class deleteuserFORM
    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Sub DeleteUserRecord()
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()

        If (Not String.IsNullOrWhiteSpace(TB_USERNAME.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_PASSWORD.Text) AndAlso
        Not String.IsNullOrWhiteSpace(CB_USERROLE.Text)) Then

            Try
                Dim connectionString As String = "server=localhost;user=root;password=root;database=db_burgeran;"
                Dim insertSql As String = ""
                Dim userRole As String = CB_USERROLE.Text

                Select Case userRole
                    Case "Cashier"
                        insertSql = "DELETE FROM cashier WHERE Username = @Username;DELETE FROM login WHERE Username = @Username"
                    Case "Manager"
                        insertSql = "DELETE FROM managers WHERE Username = @Username;DELETE FROM login WHERE Username = @Username"
                    Case "Admin"
                        insertSql = "DELETE FROM admins WHERE Username = @Username;DELETE FROM login WHERE Username = @Username"
                    Case Else
                        ' Handle other roles if needed
                End Select

                Using connection As New MySqlConnection(connectionString)
                    connection.Open() ' Open the connection

                    Using cmdInsert As New MySqlCommand()
                        cmdInsert.Connection = connection
                        cmdInsert.Transaction = connection.BeginTransaction()

                        Try
                            ' Check if the username already exists (handled by unique constraint)
                            cmdInsert.CommandText = insertSql
                            cmdInsert.Parameters.AddWithValue("@Username", TB_USERNAME.Text)

                            cmdInsert.ExecuteNonQuery()

                            cmdInsert.Transaction.Commit() ' Commit the transaction if everything is successful
                            MessageBox.Show("User deleted successfully.")
                            LoadLoginCData()
                        Catch ex As MySqlException
                            If ex.Number = 1062 Then ' MySQL error code for duplicate entry
                                cmdInsert.Transaction.Rollback() ' Rollback the transaction if username already exists
                                MessageBox.Show("Error deleting using")
                            Else
                                MessageBox.Show("An error occurred while creating the user: " & ex.Message)
                            End If
                        End Try
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while creating the user: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select user to delete")
        End If
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

            If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
                TB_USERNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
                TB_PASSWORD.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
                CB_USERROLE.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            End If

        Catch ex As Exception
            MessageBox.Show("Cell is Empty")
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub deleteuserFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLoginCData()
    End Sub
    Private Sub LoadLoginCData()
        Try
            Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Username, Password, UserRole FROM login "

                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        AdminForm.Show()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DeleteUserRecord()

        CRUD_USER_FORM.UpdateSURecords(AdminForm.lbl_username.Text, "Deleted User: " + TB_USERNAME.Text)

        TB_USERNAME.Clear()
        TB_PASSWORD.Clear()
        CB_USERROLE.SelectedIndex = -1



    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub TB_CASHIERID_TextChanged(sender As Object, e As EventArgs) Handles TB_CASHIERID.TextChanged

    End Sub

    Private Sub TB_USERNAME_TextChanged(sender As Object, e As EventArgs) Handles TB_USERNAME.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub CB_USERROLE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_USERROLE.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub TB_PASSWORD_TextChanged(sender As Object, e As EventArgs) Handles TB_PASSWORD.TextChanged

    End Sub
End Class