Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button_Show.Click
        Equation.Text = "E = mc2"

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles Button_Hide.Click
        Equation.Text = ""
    End Sub

    Private Sub Equation_Click(sender As Object, e As EventArgs) Handles Equation.Click

    End Sub
End Class
