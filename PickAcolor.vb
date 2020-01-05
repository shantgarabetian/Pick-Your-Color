Public Class PickAcolor
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles YourFavColr.Click

    End Sub

    Private Sub PickAcolor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Blue.Click
        Picked.ForeColor = Color.Blue
        Picked.Text = " Blue "
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Green.Click
        Picked.ForeColor = Color.Green
        Picked.Text = " Green "
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Red.Click
        Picked.ForeColor = Color.Red
        Picked.Text = " Red "
    End Sub
End Class
