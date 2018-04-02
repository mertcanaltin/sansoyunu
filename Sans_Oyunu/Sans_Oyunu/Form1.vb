Public Class Form1

    

    Private Sub ButtonOyna_Click(sender As Object, e As EventArgs) Handles ButtonOyna.Click
        Dim Sans1, Sans2, Sans3 As Integer
        Dim rast As New Random
        Sans1 = rast.Next(0, 3)
        Sans2 = rast.Next(0, 3)
        Sans3 = rast.Next(0, 3)
        Button1.ImageIndex = Sans1
        Button2.ImageIndex = Sans2
        Button3.ImageIndex = Sans3


    End Sub
End Class
