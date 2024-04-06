Public Class Form1
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Panel1.Controls.Clear()
        Dim pos As Pos
        pos = New Pos()

        Panel1.Controls.Add(pos)
    End Sub

    Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Controls.Clear()
        Dim AddCustomerpanel As Customers
        AddCustomerpanel = New Customers()

        Panel1.Controls.Add(AddCustomerpanel)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Panel1.Controls.Clear()
        Dim AddProduct As AddProduct
        AddProduct = New AddProduct()

        Panel1.Controls.Add(AddProduct)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Panel1.Controls.Clear()
        Dim AddCustomerpanel As Customers
        AddCustomerpanel = New Customers()

        Panel1.Controls.Add(AddCustomerpanel)
    End Sub
End Class
