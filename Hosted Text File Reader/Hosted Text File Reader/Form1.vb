Imports System.IO
Imports System.Net

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TXT As String = ""
        Dim WC As WebClient = New WebClient()
        Dim Read As StreamReader = New StreamReader(WC.OpenRead(TXT))
        Dim STR As String = Read.ReadToEnd
        RichTextBox1.Text = STR
    End Sub

End Class
