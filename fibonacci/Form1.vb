Public Class Form1


    Dim num As Integer



    Private Sub Bstart_Click(sender As Object, e As EventArgs) Handles Bstart.Click
        Bstart.Enabled = False
        Fibonacci()
    End Sub


    Private Sub Fibonacci()

        Txt(F(num))
            num = num + 1
            Bstart.Enabled = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        num = 0
    End Sub

    Private Sub Txt(txt)

        If TextBox1.Text = "" Then
            TextBox1.Text = txt
        Else
            TextBox1.Text = TextBox1.Text & " - " & txt
        End If

    End Sub


    Private Function F(ByVal n As Long) As Long

        Dim res As Long

        Select Case n
            Case 0
                res = 0
            Case 1, 2
                res = 1
            Case > 2
                res = F(n - 1) + F(n - 2)
        End Select

        'If n = 0 Then
        '    res = 0
        'ElseIf n = 1 Or n = 2 Then
        '    res = 1
        'ElseIf n > 2 Then
        '    res = F(n - 1) + F(n - 2)
        'End If

        F = res

    End Function

End Class
