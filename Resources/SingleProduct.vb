Public Class SingleProduct
    Dim id As String = ""
    Dim Productname As String = ""
    Dim price As String = ""
    Dim productImage As String = ""
    Public Event AddProduct(ByVal sender As Object, ByVal e As EventArgs, ByVal idT As String, ByVal nameT As String, ByVal price As String)


    Private Sub SingleProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_productName.Text = Productname
        lbl_productPrice.Text = price

        Console.WriteLine(productImage)

        If productImage = "none" Then
            PictureBox1.Image = My.Resources.ResourceManager.GetObject("productImg")
        Else
            PictureBox1.Image = Image.FromFile(productImage.Replace("##", "\"))
        End If
    End Sub
    Public Sub New(ByVal idT As String, ByVal nameT As String, ByVal priceT As String, ByVal imageT As String)
        id = idT
        Productname = nameT
        price = priceT
        productImage = imageT

        InitializeComponent()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        RaiseEvent AddProduct(Me, New EventArgs, id, Productname, price)
    End Sub
End Class
