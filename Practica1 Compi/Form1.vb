﻿Imports System.IO


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text.Equals("")) Then
            MessageBox.Show("No hay nada que analizar", "Error")
        Else
            MyParser.Setup()
            MyParser.Parse(New StringReader(TextBox1.Text))
            TextBox1.Clear()









            Me.Hide()






        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class
