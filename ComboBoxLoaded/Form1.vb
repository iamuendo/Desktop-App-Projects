Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cboNames.Items
            .Add("Tel Aviv")
            .Add("Paris")
            .Add("Kabul")
            .Add("Moscow")
            .Add("Nairobi")
            .Add("Kampala")
            .Add("Kigali")

        End With


    End Sub
End Class
