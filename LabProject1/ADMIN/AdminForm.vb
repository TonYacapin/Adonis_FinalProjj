Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class AdminForm

    Dim Selection = 1

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
    Private Sub btn_ADMINLOGOUT_Click(sender As Object, e As EventArgs) Handles btn_ADMINLOGOUT.Click
        UserActivity.Stop()
        UserActivity.Start()

        UpdateLoginRecords(lbl_username.Text, "Logged Out")


        Form1.Show()
        Me.Close()


    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        showpanel()

        Timer1.Start()
        UserActivity.Start()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserActivity.Stop()
        UserActivity.Start()
        Selection = 1
        showpanel()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        UserActivity.Stop()
        UserActivity.Start()
        Selection = 2
        showpanel()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UserActivity.Stop()
        UserActivity.Start()
        Selection = 3
        showpanel()
    End Sub

    Private Sub showpanel()
        Select Case Selection
            Case 1

                Panel_Items.Visible = True
                Panel_TransactionRecord.Visible = False
                Panel_User.Visible = False

            Case 2
                Panel_Items.Visible = False
                Panel_TransactionRecord.Visible = False
                Panel_User.Visible = True

            Case 3

                Panel_Items.Visible = False
                Panel_TransactionRecord.Visible = True
                Panel_User.Visible = False



        End Select
    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        UserActivity.Stop()
        UserActivity.Start()
        RequestForm.Show()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        UserActivity.Stop()
        UserActivity.Start()
        CRUD_USER_FORM.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        UserActivity.Stop()
        UserActivity.Start()
        Me.Hide()
        Admin_EditProducts.Show()



    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UserActivity.Stop()
        UserActivity.Start()
        Me.Hide()
        Admin_EditProducts.Show()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UserActivity.Stop()
        UserActivity.Start()
        Me.Hide()
        VIEW_ORDERRECORDS.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UserActivity.Stop()
        UserActivity.Start()
        Me.Hide()
        VIEW_LOGINRECORDS.Show()

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub



    Private Sub LogoutUser()
        ' Add code here to perform logout actions, such as clearing session data and returning to the login page
        ' For example:

        Me.Close() ' Hide the current form
        Form1.Show()

        ' Show the login form
    End Sub

    Private Sub UserActivity_Tick(sender As Object, e As EventArgs) Handles UserActivity.Tick
        LogoutUser()
    End Sub

    Private Sub CashierForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        UserActivity.Stop()
        UserActivity.Start()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        UserActivity.Stop()
        UserActivity.Start()
        BackupRestore_FORM.Show()


    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Me.Hide()
        deleteuserFORM.Show()


    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Me.Hide()
        edituserFORM.Show()
    End Sub
End Class