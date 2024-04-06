Public Class Customers
    Dim SingleCustomer As SIngleCustomer
    Dim DBConnection As DBConnection = New DBConnection()
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub ucB_OKEvent()
        Debug.Print("OK Event received from UserControl in FormB")
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        FlowLayoutPanel1.Controls.Clear()
        Dim AddCustomerpanel As AddCustomer
        AddCustomerpanel = New AddCustomer("")

        AddHandler AddCustomerpanel.CancelAddCustomer, AddressOf ShowCustomerList
        FlowLayoutPanel1.Controls.Add(AddCustomerpanel)
    End Sub

    Private Sub ShowCustomerList()
        FlowLayoutPanel1.Controls.Clear()
        Dim datalist = DBConnection.getData("", "customers")

        Try
            If datalist.HasRows Then
                Do While datalist.Read()
                    Dim id As String = datalist("id")
                    Dim query_result As String = datalist("firstName")
                    Dim secondName As String = datalist("secondName")
                    Dim email As String = datalist("email")
                    Dim contactNo As String = datalist("contactNo")

                    DisplayACustomer(query_result + " " + secondName, id, email, contactNo)
                Loop
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EditCustomer(ByVal sender As Object, ByVal e As EventArgs, id As String)
        Debug.Print(id)
        FlowLayoutPanel1.Controls.Clear()
        Dim AddCustomerpanel As AddCustomer
        AddCustomerpanel = New AddCustomer(id)

        AddHandler AddCustomerpanel.CancelAddCustomer, AddressOf ShowCustomerList
        FlowLayoutPanel1.Controls.Add(AddCustomerpanel)
    End Sub

    Private Sub DisplayACustomer(CustomerName As String, CustomerID As String, email As String, contactNo As String)
        Dim ContactPanel As Panel
        ContactPanel = New Panel()


        SingleCustomer = New SIngleCustomer(CustomerName, CustomerID, email, contactNo)

        With SingleCustomer
            .BackColor = Color.White
            .Size = New Size(FlowLayoutPanel1.Width - 10, 50)
            .Name = "onload"
        End With

        AddHandler SingleCustomer.DeletedCustomer, AddressOf Customers_Load
        AddHandler SingleCustomer.EditCustomer, AddressOf EditCustomer
        FlowLayoutPanel1.Controls.Add(SingleCustomer)
    End Sub

    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowCustomerList()
    End Sub

End Class
