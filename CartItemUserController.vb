Public Class CartItemUserController
    Dim ItemName As String = ""
    Dim itemID As String = ""
    Dim ItemCount As Int16 = 0

    Public Event ChangeProductCount(ByVal sender As Object, ByVal e As EventArgs, ByVal type As String, ByVal itemId As String)


    Public Sub New(ByVal itn As String, ByVal itemc As Int32, ByVal itID As String)
        ItemName = itn
        ItemCount = itemc
        itemID = itID

        InitializeComponent()
    End Sub
    Private Sub btn_plus_Click(sender As Object, e As EventArgs) Handles btn_plus.Click
        RaiseEvent ChangeProductCount(Me, New EventArgs, "increment", itemID)
    End Sub

    Private Sub CartItemUserController_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = ItemName
        btn_ItemsCount.Text = ItemCount.ToString()
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        RaiseEvent ChangeProductCount(Me, New EventArgs, "decrement", itemID)
    End Sub
End Class
