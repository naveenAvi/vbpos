Public Class SIngleCustomer
    Dim DBConnection As DBConnection = New DBConnection()

    Public Event OnNextPage(ByVal sender As Object, ByVal e As EventArgs)
    Public Event EditCustomer(ByVal sender As Object, ByVal e As EventArgs, id As String)
    Public Event DeletedCustomer(ByVal sender As Object, ByVal e As EventArgs)


    Dim var1 As String = ""
    Dim cusID As String = ""
    Dim email As String = ""
    Dim contactNo As String = ""

    Public Sub New(ByVal customerName As String, ByVal customerid As String, em As String, contact As String)
        var1 = customerName
        cusID = customerid
        email = em
        contactNo = contact

        InitializeComponent()
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        RaiseEvent OnNextPage(Me, New EventArgs)
    End Sub

    Private Sub SIngleCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = var1
        lbl_email.Text = email
        lbl_contact.Text = contactNo
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click
        RaiseEvent EditCustomer(Me, New EventArgs, cusID)
    End Sub

    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        DBConnection.delete(cusID)

        RaiseEvent DeletedCustomer(Me, New EventArgs)
    End Sub
End Class
