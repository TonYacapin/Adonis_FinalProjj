Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class ManagerForm

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
    Private Sub btn_CASHIERLOGOUT_Click(sender As Object, e As EventArgs) Handles btn_CASHIERLOGOUT.Click
        UpdateLoginRecords(lbl_managername.Text, "Logged out")

        Form1.Show()

        Me.Close()






    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UserActivity.Stop()
        UserActivity.Start()
        Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM orders"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UserActivity.Stop()
        UserActivity.Start()
        Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "SELECT * FROM combinedViews
LIMIT 1;"
                Dim adapter As New MySqlDataAdapter(query, connection)
                Dim dataTable As New DataTable()
                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading data: " & ex.Message)
        End Try
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub



    Private Sub UserActivity_Tick(sender As Object, e As EventArgs) Handles UserActivity.Tick
        LogoutUser()
    End Sub
    Private Sub CashierForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        UserActivity.Stop()
        UserActivity.Start()
    End Sub
    Private Sub LogoutUser()
        ' Add code here to perform logout actions, such as clearing session data and returning to the login page
        ' For example:

        Me.Close() ' Hide the current form
        Form1.Show()

        ' Show the login form
    End Sub

    Private Sub ManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        UserActivity.Start()


    End Sub
End Class