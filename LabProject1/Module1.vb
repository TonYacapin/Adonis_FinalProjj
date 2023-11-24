Imports MySql.Data.MySqlClient

Module Module1

    Public _host As String = "localhost"
    Public _uname As String = "root"
    Public _password As String = "root"
    Public _db As String = "db_burgeran"
    Public isConnected As Boolean
    Public myConn As New MySqlConnection
    Public myCmd As New MySqlCommand
    Public myAdap As New MySqlDataAdapter
    Public mytable As New DataTable
    Public remark As String
    'Dim constring As String = "server=localhost; user=root; password=; database=db_lms;"
    'Dim conn As New MySqlConnection(constring)
    'Dim cmd As MySqlCommand

    Public Sub connectDB()
        If myConn.State = ConnectionState.Open Then
            Exit Sub
        Else

            myConn.ConnectionString = "Data source  =" & _host & "; User Id = " & _uname & ";Password = " & _password & "; database=" & _db & ""
            myConn.Open()
            myCmd.Connection = myConn
            isConnected = True

        End If


    End Sub


    'Function getAllFoodRecord() As DataTable
    '    Dim TeamTable As New DataTable
    '    Dim sql As String
    '    sql = "Select * From teams"
    '    myCmd.CommandText = sql
    '    myCmd.Connection = myConn
    '    myAdap.SelectCommand = myCmd
    '    myAdap.Fill(TeamTable)
    '    Return TeamTable
    '    myConn.Close()

    'End Function


    'Sub Disconnect()
    '    conn.Close()
    'End Sub

    'Sub ShowData(grid As Object)
    '    conn.Open()
    '    grid.Rows.Clear()
    '    Dim cmd = New MySqlCommand("Select * from login", conn)
    '    Dim read As MySqlDataReader = cmd.ExecuteReader

    '    While read.Read
    '        grid.Rows.Add(read("UserID"), read("Username"), read("Password"), read("UserRole"), read("IsActive"))
    '    End While
    '    read.Close()
    '    conn.Close()

    'End Sub

    'Sub ConfirmLogin()
    '    conn.Open()
    '    cmd = New MySqlCommand("select * from login where username = @user and password = @pass", conn)
    '    cmd.Parameters.AddWithValue("@user", Form1.Tb_Username.Text)
    '    cmd.Parameters.AddWithValue("@pass", Form1.Tb_Password.Text)
    '    Dim read As MySqlDataReader = cmd.ExecuteReader
    '    If (read.Read) Then
    '        CashierForm.Show()
    '        read.Close()
    '        conn.Close()
    '        Form1.Close()

    '    Else
    '        read.Close()
    '        conn.Close()
    '    End If

    '    read.Close()
    '    conn.Close()

    'End Sub
End Module
