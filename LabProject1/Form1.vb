Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class Form1

    Dim Attempt As Integer = 1

    Public cashierUserID As Integer
    Public cashiername As String


    Private Function IsPasswordComplex(password As String) As Boolean
        ' Check if the password contains at least one uppercase letter, one lowercase letter, one digit, and one special character
        Return RegularExpressions.Regex.IsMatch(password, "(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*\W)")
    End Function

    Function MD5Hash(input As String) As String
        Using md5 As MD5 = md5.Create()
            Dim inputBytes As Byte() = Encoding.UTF8.GetBytes(input)
            Dim hashBytes As Byte() = md5.ComputeHash(inputBytes)

            Dim sb As New StringBuilder()
            For i As Integer = 0 To hashBytes.Length - 1
                sb.Append(hashBytes(i).ToString("x2"))
            Next

            Return sb.ToString()
        End Using
    End Function
    Private Sub UpdateLoginRecords(username As String, status As String)
        Try
            Dim connectionString As String = "server=localhost;user=root;password=root;database=db_burgeran;"
            Dim sql As String = "INSERT INTO loginrecords (Username, LoginTime, Status) VALUES (@Username, @LoginTime, @Status)"

            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Using cmdCheck As New MySqlCommand(sql, connection)

                    cmdCheck.Parameters.AddWithValue("@LoginTime", DateTime.Now)
                    cmdCheck.Parameters.AddWithValue("@Status", status)
                    cmdCheck.Parameters.AddWithValue("@Username", username)
                    cmdCheck.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Tb_Password.UseSystemPasswordChar = True

        tb_admin_password.UseSystemPasswordChar = True

        tb_manager_password.UseSystemPasswordChar = True






    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_login_Cashier.Click



        If Attempt <= 3 Then
            Dim Username As String = Tb_Username.Text
            Dim Password As String = Tb_Password.Text


            If String.IsNullOrEmpty(Username) And String.IsNullOrEmpty(Password) Then
                MessageBox.Show("Please fill out properly!")
                Return
            End If



            Try
                connectDB()

                Dim sql As String = "SELECT * FROM login WHERE username = @Username AND password = @Password And isactive = 1 and  UserRole = 'Cashier'"

                Using myCmd As New MySqlCommand(sql, myConn)
                    myCmd.Parameters.AddWithValue("@Username", Username)


                    Dim hashedPassword As String = MD5Hash(Tb_Password.Text)
                    myCmd.Parameters.AddWithValue("@Password", hashedPassword)

                    Using reader As MySqlDataReader = myCmd.ExecuteReader()

                        If reader.Read() Then
                            UpdateLoginRecords(Username, "Login")


                            MessageBox.Show("Logged in Succesfully.")





                            CashierForm.lbl_user.Text = Username
                            CashierForm.lbl_CashierID.Text = CInt(reader("UserID"))


                            CashierForm.Show()
                            Tb_Password.Clear()
                            Tb_Username.Clear()


                            Me.Close()


                        Else
                            UpdateLoginRecords(Username, "Failed Login")
                            MessageBox.Show("Invalid login remaining attempt:" & 3 - Attempt)

                            Tb_Password.Clear()

                            Attempt += 1


                        End If
                    End Using

                End Using




                'Module1.ConfirmLogin()
                'Me.Close()









            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try



        Else
            MessageBox.Show("Max attempt is already used")

        End If



    End Sub

    Sub CaplslockState()


        If Control.IsKeyLocked(Keys.CapsLock) Then
            lbl_CaplockIndi.Visible = True
            lbl_CaplockIndi.ForeColor = Color.Green
            lbl_capslockindi_admin.Visible = True
            lbl_capslockindi_admin.ForeColor = Color.Green
            lbl_capslockindi_manager.Visible = True
            lbl_capslockindi_manager.ForeColor = Color.Green




            lbl_CaplockIndi.Text = "Capslock Is On"
            lbl_capslockindi_manager.Text = "Capslock Is On"

            lbl_capslockindi_admin.Text = "Capslock Is On"

        Else
            lbl_CaplockIndi.Visible = False
            lbl_capslockindi_admin.Visible = False
            lbl_capslockindi_manager.Visible = False


        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        CaplslockState()
    End Sub

    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp

        CaplslockState()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then


            Tb_Password.UseSystemPasswordChar = False

        Else

            Tb_Password.UseSystemPasswordChar = True
        End If


    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged


        If CheckBox2.Checked = True Then

            tb_admin_password.UseSystemPasswordChar = False

        Else

            tb_admin_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Admin_Panel.Show()
        tb_admin_password.Clear()
        tb_admin_username.Clear()
        Tb_Password.Clear()
        Tb_Username.Clear()
        tb_manager_password.Clear()
        tb_manager_username.Clear()


        Cashier_panel.Hide()
        Manager_panel.Hide()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click




        Cashier_panel.Show()
        tb_admin_password.Clear()
        tb_admin_username.Clear()
        Tb_Password.Clear()
        Tb_Username.Clear()
        tb_manager_password.Clear()
        tb_manager_username.Clear()


        Admin_Panel.Hide()
        Manager_panel.Hide()






    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Manager_panel.Show()

        tb_admin_password.Clear()
        tb_admin_username.Clear()
        Tb_Password.Clear()
        Tb_Username.Clear()
        tb_manager_password.Clear()
        tb_manager_username.Clear()

        Admin_Panel.Hide()
        Cashier_panel.Hide()


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Admin_Panel_Paint(sender As Object, e As PaintEventArgs) Handles Admin_Panel.Paint

    End Sub

    Private Sub btn_login_admin_Click(sender As Object, e As EventArgs) Handles btn_login_admin.Click



        If Attempt <= 3 Then
            Dim Username As String = tb_admin_username.Text
            Dim Password As String = tb_admin_password.Text


            If String.IsNullOrEmpty(Username) And String.IsNullOrEmpty(Password) Then
                MessageBox.Show("Please fill out properly!")
                Return
            End If

            Try
                connectDB()

                Dim sql As String = "SELECT * FROM login WHERE username = @Username AND password = @Password And isactive = 1 And UserRole = 'Admin'"

                Using myCmd As New MySqlCommand(sql, myConn)
                    myCmd.Parameters.AddWithValue("@Username", Username)


                    Dim hashedPassword As String = MD5Hash(tb_admin_password.Text)
                    myCmd.Parameters.AddWithValue("@Password", hashedPassword)


                    Using reader As MySqlDataReader = myCmd.ExecuteReader()
                        If reader.Read() Then
                            ' You are using CInt(reader("UserID")) twice, so let's store it in a variable for clarity.
                            Dim userId As Integer = CInt(reader("UserID"))
                            UpdateLoginRecords(Username, "Login")
                            MessageBox.Show("Logged in Successfully.")


                            AdminForm.lbl_username.Text = Username



                            AdminForm.Show()
                            tb_admin_password.Clear()
                            tb_admin_username.Clear()
                            Me.Hide()
                        Else
                            ' Move the UpdateLoginRecords call inside the Else block since you are using reader("UserID") there.
                            UpdateLoginRecords(Username, "Failed Login") ' Assuming you don't have a valid UserID in case of a failed login.

                            MessageBox.Show("Invalid login remaining attempt:" & 3 - Attempt)
                            Tb_Password.Clear()
                            Attempt += 1
                        End If
                    End Using

                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try



        Else
            MessageBox.Show("Max attempt is already used")

        End If


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Cashier_panel.Paint

    End Sub

    Private Sub btn_login_manager_Click(sender As Object, e As EventArgs) Handles btn_login_manager.Click



        If Attempt <= 3 Then
            Dim Username As String = tb_manager_username.Text
            Dim Password As String = tb_manager_password.Text


            If String.IsNullOrEmpty(Username) And String.IsNullOrEmpty(Password) Then
                MessageBox.Show("Please fill out properly!")
                Return
            End If

            Try
                connectDB()

                Dim sql As String = "SELECT * FROM login WHERE username = @Username AND password = @Password And isactive = 1 And UserRole = 'Manager'"

                Using myCmd As New MySqlCommand(sql, myConn)
                    myCmd.Parameters.AddWithValue("@Username", Username)


                    Dim hashedPassword As String = MD5Hash(tb_manager_password.Text)
                    myCmd.Parameters.AddWithValue("@Password", hashedPassword)



                    Using reader As MySqlDataReader = myCmd.ExecuteReader()
                        If reader.Read() Then
                            UpdateLoginRecords(Username, "Login")
                            MessageBox.Show("Logged in Succesfully.")
                            ManagerForm.Show()
                            tb_manager_password.Clear()
                            tb_manager_username.Clear()
                            Me.Hide()

                            ManagerForm.lbl_managername.Text = Username
                            ManagerForm.lbl_managerid.Text = CInt(reader("UserID"))


                        Else


                            UpdateLoginRecords(Username, "Failed Login")
                            MessageBox.Show("Invalid login remaining attempt:" & 3 - Attempt)

                            tb_manager_password.Clear()

                            Attempt += 1






                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try



        Else
            MessageBox.Show("Max attempt is already used")

        End If



    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged



        If CheckBox3.Checked = True Then

            tb_manager_password.UseSystemPasswordChar = False

        Else

            tb_manager_password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
        MainForm.Show()

    End Sub
End Class
