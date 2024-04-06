Public Class AddCustomer
    Public Event CancelAddCustomer(ByVal sender As Object, ByVal e As EventArgs)
    Dim DBConnection As DBConnection = New DBConnection()
    Dim custID As String = ""

    Public Sub New(ByVal CUstomerID As String)
        custID = CUstomerID
        InitializeComponent()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim DBConnection As DBConnection
        DBConnection = New DBConnection()

        If (custID = "") Then
            Try
                DBConnection.addData("Insert into customers(firstName, secondName, contactNo, email, status)VALUES('" + txt_FirstName.Text + "', '" + txt_lastName.Text + "', '" + txt_contact.Text + "','" + txt_email.Text + "', '1')")
                MsgBox("Customer added ")

            Catch ex As Exception
                MsgBox("Error while adding Customer")

            End Try

        Else
            Try
                DBConnection.addData("UPDATE customers SET firstName='" + txt_FirstName.Text + "', secondName= '" + txt_lastName.Text + "', contactNo= '" + txt_contact.Text + "', email='" + txt_email.Text + "' WHERE id='" + custID + "'")
                MsgBox("Customer Updated ")
            Catch ex As Exception
                MsgBox("Customer update failed ")
            End Try
        End If

        RaiseEvent CancelAddCustomer(Me, New EventArgs)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        RaiseEvent CancelAddCustomer(Me, New EventArgs)
    End Sub

    Private Sub AddCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (Not custID = "") Then
            Dim datalist = DBConnection.getData(custID, "customers")

            Try
                If datalist.HasRows Then
                    If datalist.Read Then
                        Dim id As String = datalist("id")
                        Dim query_result As String = datalist("firstName")
                        Dim secondName As String = datalist("secondName")
                        Dim email As String = datalist("email")
                        Dim contactNo As String = datalist("contactNo")

                        Console.WriteLine(query_result)
                        txt_FirstName.Text = query_result
                        txt_lastName.Text = secondName
                        txt_email.Text = email
                        txt_contact.Text = contactNo

                        lbl_title.Text = "Update Customer ID-" + custID
                    End If

                End If
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        End If
    End Sub
End Class
