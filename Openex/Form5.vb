﻿Public Class FrmOpenex5
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        FrmOpenex4.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs)
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)
        FrmOpenex3.Show()
        Me.Hide()
    End Sub


    Private Sub FrmOpenex5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoScroll = False
        HorizontalScroll.Enabled = False
        AutoScroll = True
        VerticalScroll.Enabled = False
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        FrmOpenex15.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_Click_1(sender As Object, e As EventArgs) Handles Label6.Click
        FrmOpenex3.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles PictureBox27.Click
        FrmOpenex9.Show()
        Me.Hide()
    End Sub

    Private Sub LblForo_Click(sender As Object, e As EventArgs) Handles LblForo.Click
        FrmOpenex9.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox26_Click(sender As Object, e As EventArgs) Handles PictureBox26.Click
        FrmOpenex19.Show()
        Me.Hide()
    End Sub

    Private Sub LblInicio_Click(sender As Object, e As EventArgs) Handles LblInicio.Click
        FrmOpenex19.Show()
        Me.Hide()
    End Sub
End Class