Public Class AddProduct
    Dim DBConnection As DBConnection = New DBConnection()
    Dim productI As String = ""
    Dim productImag As String = "none"
    Private Sub productImageSelector_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose Image(*.jpg; *.png; *.jpeg ) | *.jpg; *.png; *.jpeg"
        If (opf.ShowDialog = DialogResult.OK) Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
            productImag = opf.FileName.Replace("\", "##")

        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim DBConnection As DBConnection
        DBConnection = New DBConnection()

        If (productI = "") Then
            Try
                DBConnection.addData("Insert into Products(name, price, productImage, status)VALUES('" + txt_productName.Text + "', '" + txt_price.Text + "', '" + productImag + "', '1')")
                productImag = ""
                txt_productName.Text = ""
                txt_price.Text = ""
                Me.Refresh()
                MsgBox("Product Entered")
            Catch ex As Exception
                MsgBox("Error while entering Product")
            End Try
        End If

    End Sub
End Class
