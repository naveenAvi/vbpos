Public Class Pos
    Dim DBConnection As DBConnection = New DBConnection()
    Dim CartItems As List(Of CartItem) = New List(Of CartItem)
    Dim total As Int32
    Dim CustomerIDs As List(Of String) = New List(Of String)



    Private Sub Pos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim datalist = DBConnection.getData("", "products")
        CustomerIDs = New List(Of String)



        Dim customersList = DBConnection.getData("", "customers")

        Try
            If customersList.HasRows Then
                Do While customersList.Read()

                    Dim id As String = customersList("id")
                    Dim query_result As String = customersList("firstName")
                    Dim secondName As String = customersList("secondName")
                    Dim email As String = customersList("email")
                    customerList.Items.Add(query_result + " " + secondName)
                    CustomerIDs.Add(id)
                Loop
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try


        Try
            If datalist.HasRows Then
                Do While datalist.Read()
                    Dim id As String = datalist("id")
                    Dim name As String = datalist("name")
                    Dim price As String = datalist("price")
                    Dim productImage As String = datalist("productImage")

                    Dim SingleProduct As SingleProduct
                    SingleProduct = New SingleProduct(id, name, price, productImage)
                    AddHandler SingleProduct.AddProduct, AddressOf AddProduct


                    ProductsPanel.Controls.Add(SingleProduct)
                Loop
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub AddProduct(ByVal sender As Object, ByVal e As EventArgs, ByVal idT As String, ByVal nameT As String, ByVal price As String)
        Dim updated As Boolean = False
        For i = 0 To CartItems.Count() - 1
            If (CartItems(i).getItemId() = idT) Then
                CartItems(i).incrementCount()
                updated = True
            End If
        Next

        If (Not updated) Then
            Dim tempCartItem = New CartItem(idT, nameT, 1, price)
            CartItems.Add(tempCartItem)
        End If

        showCartItems()
    End Sub

    Private Sub showCartItems()
        total = 0
        FlowLayoutPanel2.Controls.Clear()
        For Each item In CartItems
            Dim CartItemUserController As CartItemUserController
            CartItemUserController = New CartItemUserController(item.getItemName(), item.getItemCount(), item.getItemId())
            total = total + Integer.Parse(item.getItemPrice()) * Integer.Parse(item.getItemCount())

            AddHandler CartItemUserController.ChangeProductCount, AddressOf changItemCount
            FlowLayoutPanel2.Controls.Add(CartItemUserController)
        Next
        txtbox_subtotal.Text = total.ToString()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Dim DBConnection As DBConnection
        DBConnection = New DBConnection()

        Dim selectedCustomerID = "0"

        Try
            selectedCustomerID = CustomerIDs(customerList.SelectedIndex)
        Catch ex As Exception

        End Try

        Dim invoiceID As String = DBConnection.addData("Insert into invoices(customerid,discount,total,paid)VALUES('" + selectedCustomerID + "', '" + txt_box_discount.Text + "', '" + total.ToString() + "', '" + Guna2TextBox2.Text + "')")

        If (Not invoiceID = "") Then
            For Each item In CartItems
                DBConnection.addData("Insert into purchases(productId, invoiceID, qty, price)VALUES('" + item.getItemId() + "', '" + invoiceID + "', '" + item.getItemCount() + "', '" + item.getItemPrice() + "')")
            Next
            Dim PrintInvoice As New PrintInvoice(invoiceID, CartItems, customerList.SelectedItem)
            PrintInvoice.ShowPrint()

        Else
            MsgBox("Error while saving invoice")
        End If



    End Sub

    Private Sub changItemCount(ByVal sender As Object, ByVal e As EventArgs, ByVal changeType As String, ByVal itemId As String)
        Dim isFound As Boolean = False
        For i = 0 To CartItems.Count() - 1
            If (CartItems(i).getItemId() = itemId And Not isFound) Then
                isFound = True
                If (changeType = "increment") Then
                    CartItems(i).incrementCount()
                Else
                    CartItems(i).decrementCount()
                    If (CartItems(i).getItemCount() < 1) Then
                        CartItems.RemoveAt(i)
                    End If
                End If
            End If
        Next
        showCartItems()
    End Sub

    Private Sub txt_box_discount_TextChanged(sender As Object, e As EventArgs) Handles txt_box_discount.TextChanged
        Try
            txtbox_total.Text = (total - (total * Integer.Parse(txt_box_discount.Text) / 100)).ToString()
        Catch ex As Exception
            txtbox_total.Text = total.ToString()
        End Try

    End Sub

    Private Sub Guna2TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles Guna2TextBox2.TextChanged
        Try
            balance_lbl.Text = (Decimal.Parse(Guna2TextBox2.Text) - Decimal.Parse(txtbox_total.Text)).ToString()
        Catch ex As Exception
        End Try
        Me.Refresh()
    End Sub

    Private Sub customerList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles customerList.SelectedIndexChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
