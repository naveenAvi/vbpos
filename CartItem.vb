Public Class CartItem
    Dim itemId As String = ""
    Dim ItemName As String = ""
    Dim ItemsCount As String = 0
    Dim itemPrice As String = 0

    Public Sub New(ByVal itID As String, ByVal itName As String, ByVal itCount As Int32, ByVal itPrice As String)
        itemId = itID
        ItemName = itName
        ItemsCount = itCount
        itemPrice = itPrice
    End Sub

    Public Function getItemName()
        Return ItemName
    End Function

    Public Function getItemId()
        Return itemId
    End Function

    Public Function getItemPrice()
        Return itemPrice
    End Function

    Public Function getItemCount()
        Return ItemsCount
    End Function

    Public Function incrementCount()
        ItemsCount = ItemsCount + 1
    End Function
    Public Function decrementCount()
        ItemsCount = ItemsCount - 1
    End Function
End Class
