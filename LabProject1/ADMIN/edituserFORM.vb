Imports MySql.Data.MySqlClient

Public Class edituserFORM


    Dim optionselected As Integer

    Private Sub ClearTextBoxes()
        TB_FIRSTNAME.Text = ""
        TB_LASTNAME.Text = ""
        TB_EMAIL.Text = ""
        TB_PHONE.Text = ""
        TextBox3.Text = ""

        TB_USERNAME.Text = ""
        TB_PASSWORD.Text = ""
        CB_USERROLE.Text = ""
    End Sub


    Private Sub ClearDataGridView(dataGridView As DataGridView)
        Try
            dataGridView.DataSource = Nothing
            dataGridView.Rows.Clear()
            dataGridView.Columns.Clear()
            dataGridView.Refresh()
        Catch ex As Exception
            MessageBox.Show("An error occurred while clearing the DataGridView: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadLoginCData()
        Try
            Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT UserID, Username, Password, UserRole FROM login "

                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadcashierCData()
        Try
            Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Username,Firstname,Lastname,Email,Phone FROM cashier "

                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadmanagerCData()
        Try
            Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT Username,Firstname,Lastname,Email,Phone FROM managers "

                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub
    Private Sub LoadadminCData()
        Try
            Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT  Username,Firstname,Lastname,Email,Phone FROM admins "

                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub



    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub edituserFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearDataGridView(DataGridView1)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        AdminForm.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ClearTextBoxes()
        ClearDataGridView(DataGridView1)
        personalinfopanel.Show()
        logininfopanel.Hide()

        optionselected = 1

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ClearTextBoxes()
        ClearDataGridView(DataGridView1)
        personalinfopanel.Hide()
        logininfopanel.Show()


        optionselected = 2
        LoadLoginCData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Select Case optionselected
            Case 1
                Try

                    If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
                        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
                        TB_FIRSTNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
                        TB_LASTNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
                        TB_EMAIL.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
                        TB_PHONE.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()

                    End If

                Catch ex As Exception
                    MessageBox.Show("Cell is Empty")
                End Try




            Case 2
                Try

                    If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
                        TB_USERNAME.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
                        TB_PASSWORD.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
                        CB_USERROLE.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
                    End If

                Catch ex As Exception
                    MessageBox.Show("Cell is Empty")
                End Try

            Case Else
                MessageBox.Show("Invalid Action")
        End Select



    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.SelectedItem.ToString()
            Case "Manager"
                LoadmanagerCData()
            Case "Cashier"
                LoadcashierCData()
            Case "Admin"
                LoadadminCData()
            Case Else
                ' Handle other cases if needed
        End Select
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()

        If (Not String.IsNullOrWhiteSpace(TextBox3.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_FIRSTNAME.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_LASTNAME.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_EMAIL.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_PASSWORD.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_PHONE.Text)) Then

            Try
                Dim connectionString As String = "server=localhost;user=root;password=root;database=db_burgeran;"
                Dim updateSql As String = ""
                Dim userRole As String = CB_USERROLE.Text

                Select Case userRole
                    Case "Cashier"
                        updateSql = "UPDATE cashier SET " &
                            "FirstName = @FirstName, " &
                            "LastName = @LastName, " &
                            "Email = @Email, " &
                            "Phone = @Phone " &
                            "WHERE Username = @Username"
                    Case "Manager"
                        updateSql = "UPDATE managers SET " &
                            "FirstName = @FirstName, " &
                            "LastName = @LastName, " &
                            "Email = @Email, " &
                            "Phone = @Phone " &
                            "WHERE Username = @Username"
                    Case "Admin"
                        updateSql = "UPDATE admins SET " &
                            "FirstName = @FirstName, " &
                            "LastName = @LastName, " &
                            "Email = @Email, " &
                            "Phone = @Phone " &
                            "WHERE Username = @Username"
                    Case Else
                        ' Handle other roles if needed
                End Select

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    Using cmdUpdate As New MySqlCommand(updateSql, connection)
                        cmdUpdate.Parameters.AddWithValue("@Username", TextBox3.Text)
                        cmdUpdate.Parameters.AddWithValue("@FirstName", TB_FIRSTNAME.Text)
                        cmdUpdate.Parameters.AddWithValue("@LastName", TB_LASTNAME.Text)
                        cmdUpdate.Parameters.AddWithValue("@Email", TB_EMAIL.Text)
                        cmdUpdate.Parameters.AddWithValue("@Phone", TB_PHONE.Text)

                        Dim transaction = connection.BeginTransaction()

                        Try
                            cmdUpdate.ExecuteNonQuery()
                            transaction.Commit()
                            MessageBox.Show("User updated successfully.")
                            LoadLoginCData()
                        Catch ex As MySqlException
                            If ex.Number = 1062 Then
                                transaction.Rollback()
                                MessageBox.Show("Error updating user. Duplicate entry.")
                            Else
                                transaction.Rollback()
                                MessageBox.Show("An error occurred while updating the user: " & ex.Message)
                            End If
                        End Try
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred while updating the user: " & ex.Message)
            End Try
        Else
            MessageBox.Show("Please select user to delete")
        End If
    End Sub


End Class