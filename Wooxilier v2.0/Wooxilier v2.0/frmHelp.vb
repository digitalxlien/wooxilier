Public Class frmHelp

    Private Sub frmHelp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        linkBlog.Links.Add(0, "http://wooxilier.blogspot.mx/".Length, "http://wooxilier.blogspot.mx/")
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.Dispose()
    End Sub

    Private Sub linkBlog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkBlog.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub


End Class