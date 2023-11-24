


Imports LabProject1.CashierForm

Public Class PlaceOrderForm
    Public Property Prize As Object

    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        CashierForm.UserActivity.Stop()
        CashierForm.UserActivity.Start() ' Get the product ID and quantity from user input
        Dim productID As Integer = Integer.Parse(CashierForm.ProductId)
        Dim quantity As Integer = Integer.Parse(NumericUpDown1.Value)
        Dim ProductName = lblPRODUCTNAME.Text
        Dim Prize = CashierForm.ProductPrize * quantity
        Dim CashierName = CashierForm.lbl_user.Text
        Dim CashierId = CashierForm.lbl_CashierID.Text



        ' Dim Cashier =


        'Dim Price

        ' Create an order
        Dim newOrder As New Order()
        newOrder.ProductID = productID
        newOrder.Quantity = quantity
        newOrder.ProductName = ProductName
        newOrder.Prize = Prize
        newOrder.CashierName = CashierName
        newOrder.CashierId = Cashierid

        ' Add the order to the list
        CashierForm.orderList.Add(newOrder)

        ' Update the DataGridView to display the orders
        UpdateOrderDataGridView()

        Me.Close()

    End Sub

    Public Sub UpdateOrderDataGridView()
        ' Clear the DataGridView
        CashierForm.DataGridView1.Rows.Clear()

        ' Iterate through the order list and add orders to the DataGridView
        For Each order As Order In CashierForm.orderList
            CashierForm.DataGridView1.Rows.Add(order.ProductName, order.ProductID, order.Quantity, order.Prize)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CashierForm.UserActivity.Stop()
        CashierForm.UserActivity.Start()
        Me.Close()

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        CashierForm.UserActivity.Stop()
        CashierForm.UserActivity.Start()
    End Sub

    Private Sub PlaceOrderForm_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        CashierForm.UserActivity.Stop()
        CashierForm.UserActivity.Start()
    End Sub
End Class