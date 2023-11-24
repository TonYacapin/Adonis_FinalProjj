Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class CRUD_USER_FORM
    Private Function IsPasswordComplex(password As String) As Boolean
        ' Check if the password contains at least one uppercase letter, one lowercase letter, one digit, and one special character
        Return RegularExpressions.Regex.IsMatch(password, "(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W)")
    End Function
    Function MD5Hash(input As String) As String
        Using md5 As MD5 = MD5.Create()
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)

            Dim sb As New StringBuilder()
            For i As Integer = 0 To hashBytes.Length - 1
                sb.Append(hashBytes(i).ToString("x2"))
            Next

            Return sb.ToString()
        End Using
    End Function


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

    Private Sub CRUD_USER_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLoginCData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdminForm.Show()
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)




    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        AdminForm.Show()


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()

        If (Not String.IsNullOrWhiteSpace(TB_USERNAME.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_FIRSTNAME.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_LASTNAME.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_EMAIL.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_PASSWORD.Text) AndAlso
        Not String.IsNullOrWhiteSpace(TB_PHONE.Text) AndAlso
        Not String.IsNullOrWhiteSpace(CB_USERROLE.Text)) Then

            Try
                Dim connectionString As String = "server=localhost;user=root;password=root;database=db_burgeran;"
                Dim insertSql As String = ""
                Dim userRole As String = CB_USERROLE.SelectedItem.ToString()

                Select Case userRole
                    Case "Cashier"
                        insertSql = "INSERT INTO cashier (Username, FirstName, LastName, Email, Phone) VALUES (@Username, @FirstName, @LastName, @Email, @Phone); INSERT INTO login (Username, Password, Userrole, IsActive) VALUES (@Username, @Password, @UserRole, '0')"
                    Case "Manager"
                        insertSql = "INSERT INTO managers (Username, FirstName, LastName, Email, Phone) VALUES (@Username, @FirstName, @LastName, @Email, @Phone); INSERT INTO login (Username, Password, Userrole, IsActive) VALUES (@Username, @Password, @UserRole, '0')"
                    Case "Admin"
                        insertSql = "INSERT INTO admins (Username, FirstName, LastName, Email, Phone) VALUES (@Username, @FirstName, @LastName, @Email, @Phone); INSERT INTO login (Username, Password, Userrole, IsActive) VALUES (@Username, @Password, @UserRole, '0')"
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
                            cmdInsert.Parameters.AddWithValue("@FirstName", TB_FIRSTNAME.Text)
                            cmdInsert.Parameters.AddWithValue("@LastName", TB_LASTNAME.Text)
                            cmdInsert.Parameters.AddWithValue("@Email", TB_EMAIL.Text)
                            cmdInsert.Parameters.AddWithValue("@Phone", TB_PHONE.Text)

                            If Not IsPasswordComplex(TB_PASSWORD.Text) Then
                                MessageBox.Show("Password must have at least one uppercase letter, one lowercase letter, one digit, and one special character.")
                                Return
                            End If

                            Dim hashedPassword As String = MD5Hash(TB_PASSWORD.Text)
                            cmdInsert.Parameters.AddWithValue("@Password", hashedPassword)
                            cmdInsert.Parameters.AddWithValue("@UserRole", CB_USERROLE.Text)

                            cmdInsert.ExecuteNonQuery()

                            cmdInsert.Transaction.Commit() ' Commit the transaction if everything is successful
                            MessageBox.Show("User created successfully.")
                            LoadLoginCData()
                        Catch ex As MySqlException
                            If ex.Number = 1062 Then ' MySQL error code for duplicate entry
                                cmdInsert.Transaction.Rollback() ' Rollback the transaction if username already exists
                                MessageBox.Show("Username already exists. Please choose a different username.")
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
            MessageBox.Show("Please fill in all the required fields.")
        End If
    End Sub


    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
        TB_CASHIERID.Clear()
        TB_FIRSTNAME.Clear()
        TB_LASTNAME.Clear()
        TB_EMAIL.Clear()
        TB_PASSWORD.Clear()
        TB_PHONE.Clear()
        TB_USERNAME.Clear()
        CB_USERROLE.SelectedIndex = -1

    End Sub

    Private Sub TB_FIRSTNAME_TextChanged(sender As Object, e As EventArgs) Handles TB_FIRSTNAME.TextChanged
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub

    Private Sub TB_LASTNAME_TextChanged(sender As Object, e As EventArgs) Handles TB_LASTNAME.TextChanged
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub

    Private Sub TB_USERNAME_TextChanged(sender As Object, e As EventArgs) Handles TB_USERNAME.TextChanged
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub

    Private Sub TB_EMAIL_TextChanged(sender As Object, e As EventArgs) Handles TB_EMAIL.TextChanged
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub

    Private Sub TB_PASSWORD_TextChanged(sender As Object, e As EventArgs) Handles TB_PASSWORD.TextChanged
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub

    Private Sub TB_PHONE_TextChanged(sender As Object, e As EventArgs) Handles TB_PHONE.TextChanged
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub

    Private Sub CB_USERROLE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_USERROLE.SelectedIndexChanged
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
    End Sub

    Private Sub DataGridView1_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        AdminForm.UserActivity.Stop()
        AdminForm.UserActivity.Start()
        'Try

        '    If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
        '        userid_tb.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
        '        username_tb.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        '        userrole_tb.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        '    End If

        'Catch ex As Exception
        '    MessageBox.Show("Cell is Empty")
        'End Try
    End Sub

    Private Sub Panel5_Paint(sender As Object, e As PaintEventArgs) Handles Panel5.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TB_CASHIERID_TextChanged(sender As Object, e As EventArgs) Handles TB_CASHIERID.TextChanged

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class