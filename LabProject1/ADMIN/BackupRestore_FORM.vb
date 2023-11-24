Imports System.Diagnostics
Imports System.Windows.Forms

Public Class BackupRestore_FORM

    ' MySQL database connection information
    Private Const Server As String = "localhost"
    Private Const Database As String = "db_burgeran"
    Private Const User As String = "root"
    Private Const Password As String = "root"

    ' File dialog for selecting backup and restore files
    Private openFileDialog As New OpenFileDialog()
    Private saveFileDialog As New SaveFileDialog()

    ' Path for the MySQL tools (mysqldump, mysql)
    Private mysqlDumpPath As String = "C:\Program Files\MySQL\MySQL Server 5.5\bin\mysqldump.exe"
    Private mysqlPath As String = "C:\Program Files\MySQL\MySQL Server 5.5\bin\mysql.exe"

    ' Perform database backup
    Private Sub BackupDatabase()
        Try
            ' Show the save file dialog to get the backup file path
            saveFileDialog.Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*"
            saveFileDialog.FileName = "backup.sql"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim backupFilePath As String = saveFileDialog.FileName

                ' Build the mysqldump command
                Dim command As String = $"--host={Server} --user={User} --password={Password} --databases {Database} --result-file={backupFilePath}"

                ' Execute the mysqldump command
                Dim processStartInfo As New ProcessStartInfo(mysqlDumpPath, command)
                processStartInfo.CreateNoWindow = True
                processStartInfo.UseShellExecute = False
                processStartInfo.RedirectStandardOutput = True

                Dim process As Process = New Process With {
                    .StartInfo = processStartInfo
                }

                process.Start()
                Dim output As String = process.StandardOutput.ReadToEnd() ' Read standard output
                process.WaitForExit()

                MessageBox.Show("Backup completed successfully.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error during backup: {ex.Message}")
        End Try
    End Sub

    ' Perform database restore
    Private Sub RestoreDatabase()
        Try
            ' Show the open file dialog to get the restore file path
            openFileDialog.Filter = "SQL Files (*.sql)|*.sql|All Files (*.*)|*.*"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim restoreFilePath As String = openFileDialog.FileName

                ' Build the mysql command
                Dim command As String = $"--host={Server} --user={User} --password={Password} --database {Database}"

                ' Execute the mysql command
                Dim processStartInfo As New ProcessStartInfo(mysqlPath, command)
                processStartInfo.CreateNoWindow = True
                processStartInfo.UseShellExecute = False
                processStartInfo.RedirectStandardInput = True

                Dim process As Process = New Process With {
                    .StartInfo = processStartInfo
                }

                process.Start()

                ' Read the SQL file and write it to the process input stream
                Dim sqlFileContent As String = System.IO.File.ReadAllText(restoreFilePath)
                process.StandardInput.WriteLine(sqlFileContent)

                process.StandardInput.Close()
                process.WaitForExit()

                MessageBox.Show("Restore completed successfully.")
            End If
        Catch ex As Exception
            MessageBox.Show($"Error during restore: {ex.Message}")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BackupDatabase()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RestoreDatabase()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        AdminForm.Show()

    End Sub
End Class