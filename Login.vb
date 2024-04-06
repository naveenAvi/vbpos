Public Class Login
    Dim DBConnection As DBConnection = New DBConnection()

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim datalist = DBConnection.getDataSearch(" AND username='" + txtbpx_username.Text + "' AND password='" + txtbox_password.Text + "'", "users")

        Try
            If datalist.HasRows Then
                If datalist.Read() Then
                    Dim Form1 As Form1 = New Form1()
                    Form1.Visible = True
                    Me.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Wrong password")

        End Try
    End Sub
End Class