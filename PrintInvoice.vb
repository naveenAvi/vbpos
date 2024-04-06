Imports System.Drawing.Printing
Public Class PrintInvoice
    Dim DBConnection As DBConnection = New DBConnection()
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim invoiceID As String = ""
    Dim CustomerName As String = ""
    Dim CartItems As List(Of CartItem) = New List(Of CartItem)

    Dim dateissued As String
    Dim customerid As Int16
    Dim discount As Int64
    Dim total As Int64
    Dim paid As Int64

    Public Sub New(ByVal id As String, productList As List(Of CartItem), ByVal CustomerN As String)
        invoiceID = id
        CartItems = productList
        CustomerName = CustomerN

        Dim invoice = DBConnection.getData(id, "invoices")
        Try
            If invoice.HasRows Then
                If invoice.Read() Then
                    dateissued = invoice("created_at")
                    customerid = invoice("customerid")
                    discount = invoice("discount")
                    total = invoice("total")
                    paid = invoice("paid")
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ShowPrint()
        PPD.Document = PD
        PPD.ShowDialog()
        'PD.Print()  'Direct Print
    End Sub


    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint

        Dim a As Int64 = 170 + CartItems.Count() * 10

        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, a) 'fixed size
        'pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14 As New Font("Calibri", 14, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        'font alignment
        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        line = "----------------------------------------------------------"
        e.Graphics.DrawString("MC Computers", f14, Brushes.Black, centermargin, 5, center)

        e.Graphics.DrawString("Invoice ID", f8, Brushes.Black, 0, 40)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 40)
        e.Graphics.DrawString("#" + invoiceID, f8, Brushes.Black, 70, 40)

        e.Graphics.DrawString("Customer", f8, Brushes.Black, 0, 50)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 50)
        e.Graphics.DrawString((CustomerName + " (" + customerid.ToString() + ")"), f8, Brushes.Black, 70, 50)


        e.Graphics.DrawString("Date issued", f8, Brushes.Black, 0, 60)
        e.Graphics.DrawString(":", f8, Brushes.Black, 50, 60)
        e.Graphics.DrawString(dateissued, f8, Brushes.Black, 70, 60)


        e.Graphics.DrawString("SKU", f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString("Product Name", f8, Brushes.Black, 40, 90)
        e.Graphics.DrawString("Qty", f8, Brushes.Black, 170, 90)
        e.Graphics.DrawString("total", f8, Brushes.Black, 210, 90)

        Dim a As Int64 = 0
        For i = 0 To CartItems.Count() - 1
            a = (i + 1) * 10
            e.Graphics.DrawString(CartItems(i).getItemId(), f8, Brushes.Black, 0, 95 + a)
            e.Graphics.DrawString(CartItems(i).getItemName(), f8, Brushes.Black, 40, 95 + a)
            e.Graphics.DrawString(CartItems(i).getItemCount(), f8, Brushes.Black, 170, 95 + a)
            e.Graphics.DrawString((CartItems(i).getItemPrice() * CartItems(i).getItemCount()).ToString(), f8, Brushes.Black, 210, 95 + a)

        Next
        a = a + 105

        e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------", f8, Brushes.Black, 0, a)


        a = a + 10
        e.Graphics.DrawString("Sub total", f8, Brushes.Black, 150, a)
        e.Graphics.DrawString(total, f8, Brushes.Black, 210, a)
        a = a + 10

        e.Graphics.DrawString("Discount(%)", f8, Brushes.Black, 150, a)
        e.Graphics.DrawString(discount, f8, Brushes.Black, 210, a)

        a = a + 10




        e.Graphics.DrawString("Total", f8, Brushes.Black, 150, a)
        e.Graphics.DrawString(total - (total * discount / 100), f8, Brushes.Black, 210, a)

        a = a + 10


        e.Graphics.DrawString("-------------", f8, Brushes.Black, 210, a)
        a = a + 10

        e.Graphics.DrawString("Balance", f8, Brushes.Black, 150, a)
        e.Graphics.DrawString(Math.Round(paid - (total - (total * discount / 100)), 2, MidpointRounding.AwayFromZero).ToString(), f8, Brushes.Black, 210, a)
        a = a + 10
        e.Graphics.DrawString("-------------", f8, Brushes.Black, 210, a)
    End Sub
End Class