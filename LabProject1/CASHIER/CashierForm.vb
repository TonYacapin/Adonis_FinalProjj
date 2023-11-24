

Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class CashierForm


    Dim Selection = 1

    Dim ProductSelection As String
    Public ProductId As Integer
    Public ProductPrize As Integer
    Public ProductStock As Integer


    Structure Order
        Public ProductID As Integer
        Public Quantity As Integer
        Public ProductName
        Public Prize
        Public CashierId
        Public CashierName


    End Structure

    Public orderList As New List(Of Order)


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


        UpdateLoginRecords(lbl_user.Text, "Logged Out")

        Form1.Show()
        Me.Close()










    End Sub

    Private Sub BTN_ALLITEMS_Click(sender As Object, e As EventArgs) Handles BTN_ALLITEMS.Click
        UserActivity.Stop()
        UserActivity.Start()
        Selection = 1
        showitems()

    End Sub

    Private Sub BTN_FOOD_Click(sender As Object, e As EventArgs) Handles BTN_FOOD.Click
        UserActivity.Stop()
        UserActivity.Start()
        Selection = 2
        showitems()
    End Sub

    Private Sub BTN_DRINKS_Click(sender As Object, e As EventArgs) Handles BTN_DRINKS.Click
        UserActivity.Stop()
        UserActivity.Start()
        Selection = 3
        showitems()
    End Sub

    Private Sub BTN_DESERT_Click(sender As Object, e As EventArgs) Handles BTN_DESSERT.Click
        UserActivity.Stop()
        UserActivity.Start()
        Selection = 4
        showitems()
    End Sub

    Private Sub CashierForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start() ' Start a timer to update the date and time periodically
        UserActivity.Start()

        showitems()

    End Sub


    Private Sub showitems()
        Select Case Selection
            Case 1
                ' Open PANEL_ALLITEMS
                Panel_ALLITEMS.Visible = True
                panel_FOOD.Visible = False
                Panel_DRINKS.Visible = False
                panel_DESSERT.Visible = False
            Case 2
                ' Open PANEL_FOOD
                Panel_ALLITEMS.Visible = False
                panel_FOOD.Visible = True
                Panel_DRINKS.Visible = False
                panel_DESSERT.Visible = False
            Case 3
                ' Open PANEL_DRINKS
                Panel_ALLITEMS.Visible = False
                panel_FOOD.Visible = False
                Panel_DRINKS.Visible = True
                panel_DESSERT.Visible = False
            Case 4
                ' Open PANEL_DESERT
                Panel_ALLITEMS.Visible = False
                panel_FOOD.Visible = False
                Panel_DRINKS.Visible = False
                panel_DESSERT.Visible = True
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Update the StatusLabel's text with the current date and time
        ToolStripStatusLabel1.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    End Sub

    Private Sub UserActivity_Tick(sender As Object, e As EventArgs) Handles UserActivity.Tick
        LogoutUser()
    End Sub

    Private Sub CashierForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

    End Sub

    Private Sub LogoutUser()
        ' Add code here to perform logout actions, such as clearing session data and returning to the login page
        ' For example:

        Me.Close() ' Hide the current form
        Form1.Show()

        ' Show the login form
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "Burger"
        SetInfoProduct()





    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "Hotdog"
        SetInfoProduct()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "Fries"
        SetInfoProduct()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "Coke"
        SetInfoProduct()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "IceTea"
        SetInfoProduct()

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "SansRival"
        SetInfoProduct()

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "Halo-Halo"
        SetInfoProduct()

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "ChocolateCake"
        SetInfoProduct()

    End Sub

    Private Sub Button39_Click(sender As Object, e As EventArgs) Handles Button39.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "SansRival"
        SetInfoProduct()
    End Sub

    Private Sub Button38_Click(sender As Object, e As EventArgs) Handles Button38.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "Halo-Halo"
        SetInfoProduct()

    End Sub

    Private Sub Button37_Click(sender As Object, e As EventArgs) Handles Button37.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "ChocolateCake"
        SetInfoProduct()

    End Sub

    Private Sub Button30_Click(sender As Object, e As EventArgs) Handles Button30.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "Coke"
        SetInfoProduct()

    End Sub

    Private Sub Button29_Click(sender As Object, e As EventArgs) Handles Button29.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "IceTea"
        SetInfoProduct()

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        UserActivity.Stop()
        UserActivity.Start()

        ProductSelection = "Burger"
        SetInfoProduct()

    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "Hotdog"
        SetInfoProduct()

    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        UserActivity.Stop()
        UserActivity.Start()
        ProductSelection = "Fries"
        SetInfoProduct()


    End Sub

    Private Sub SetInfoProduct()
        ' Define your connection string for the MySQL database
        Dim connectionString As String = "server=localhost; user=root; password=root; database=db_burgeran;"

        ' Create a MySQL connection
        Dim connection As New MySqlConnection(connectionString)

        Try
            ' Open the database connection
            connection.Open()

            ' Define the SQL query to retrieve product information based on ProductSelection
            Dim query As String = "SELECT ProductID, Price, StockQuantity FROM products WHERE Name = @Name And StockQuantity <> 0"

            ' Create a MySQL command
            Dim command As New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@Name", ProductSelection)

            ' Execute the SQL command and retrieve the product information
            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.Read() Then
                ' Retrieve product details from the database
                ProductId = Convert.ToInt32(reader("ProductID"))
                ProductPrize = Convert.ToDecimal(reader("Price"))
                ProductStock = Convert.ToInt32(reader("StockQuantity"))

                ' Update the UI with the retrieved information
                PlaceOrderForm.lblPRODUCTNAME.Text = ProductSelection
                PlaceOrderForm.OrderPicture.Image = PlaceOrderForm.ImageList1.Images(ProductId - 1)
            Else
                ' Handle the case where the product is not found in the database
                MessageBox.Show("Product not found in the database.")
            End If

            ' Close the data reader
            reader.Close()
        Catch ex As Exception
            ' Handle exceptions
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Close the database connection
            connection.Close()
        End Try

        ' Show the PlaceOrderForm and set the initial value for NumericUpDown
        PlaceOrderForm.Show()
        PlaceOrderForm.NumericUpDown1.Value = 1
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        UserActivity.Stop()
        UserActivity.Start()
        ' Define your MySQL connection string
        Dim connectionString As String = "server=localhost;user=root;password=root;database=db_burgeran;"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Iterate through the order list and insert orders into the "orders" table
                For Each order As Order In orderList
                    Dim sql As String = "INSERT INTO orders (CashierID, OrderDate, TotalAmount, ProductID, Quantity, CashierName) 
                                    VALUES (@CashierID, NOW(), @TotalAmount, @ProductID, @Quantity, @CashierName);
                                    UPDATE products SET StockQuantity = 
                                    CASE 
                                        WHEN StockQuantity - @Quantity < 0 THEN 0 
                                        ELSE StockQuantity - @Quantity 
                                    END
                                    WHERE ProductID = @ProductID;"

                    Using cmd As New MySqlCommand(sql, connection)
                        ' Assuming you have the CashierID (e.g., cashier's user ID) as well
                        cmd.Parameters.AddWithValue("@CashierID", order.CashierId)
                        cmd.Parameters.AddWithValue("@ProductID", order.ProductID)
                        cmd.Parameters.AddWithValue("@Quantity", order.Quantity)
                        cmd.Parameters.AddWithValue("@TotalAmount", order.Prize)
                        cmd.Parameters.AddWithValue("@CashierName", order.CashierName)

                        cmd.ExecuteNonQuery()
                    End Using
                Next

                ' Clear the order list and update the DataGridView
                orderList.Clear()
                ' Assuming you have a function called UpdateOrderDataGridView in the PlaceOrderForm to update the DataGridView
                PlaceOrderForm.UpdateOrderDataGridView()

                ' Show a confirmation message to the cashier
                MessageBox.Show("Order placed successfully.")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while placing the order: " & ex.Message)
        End Try
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        UserActivity.Stop()
        UserActivity.Start()
        ' Define your MySQL connection string
        Dim connectionString As String = "server=localhost;user=root;password=root;database=db_burgeran;"

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Iterate through the order list and insert orders into the "orders" table
                For Each order As Order In orderList
                    Dim sql As String = "INSERT INTO orders (CashierID, OrderDate, TotalAmount, ProductID, Quantity, CashierName) 
                                    VALUES (@CashierID, NOW(), @TotalAmount, @ProductID, @Quantity, @CashierName);
                                    UPDATE products SET StockQuantity = 
                                    CASE 
                                        WHEN StockQuantity - @Quantity < 0 THEN 0 
                                        ELSE StockQuantity - @Quantity 
                                    END
                                    WHERE ProductID = @ProductID;"

                    Using cmd As New MySqlCommand(sql, connection)
                        ' Assuming you have the CashierID (e.g., cashier's user ID) as well
                        cmd.Parameters.AddWithValue("@CashierID", order.CashierId)
                        cmd.Parameters.AddWithValue("@ProductID", order.ProductID)
                        cmd.Parameters.AddWithValue("@Quantity", order.Quantity)
                        cmd.Parameters.AddWithValue("@TotalAmount", order.Prize)
                        cmd.Parameters.AddWithValue("@CashierName", order.CashierName)

                        cmd.ExecuteNonQuery()
                    End Using
                Next

                ' Clear the order list and update the DataGridView
                orderList.Clear()
                ' Assuming you have a function called UpdateOrderDataGridView in the PlaceOrderForm to update the DataGridView
                PlaceOrderForm.UpdateOrderDataGridView()

                ' Show a confirmation message to the cashier
                MessageBox.Show("Order placed successfully.")
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while placing the order: " & ex.Message)
        End Try
    End Sub
End Class