Public Class frmMenu
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmHelp.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmConverter.Show()
        Me.Hide()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class
