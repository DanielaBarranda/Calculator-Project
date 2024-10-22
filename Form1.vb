Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        screen.Text = ""
        Label2.Text = ""
    End Sub

    Private Sub ans_Click_1(sender As Object, e As EventArgs) Handles ans.Click
        If Label1.Text = "+" Then
            screen.Text = Val(Label2.Text) + Val(screen.Text)
            Label2.Text = ""
            Label1.Text = "="
        End If

        If Label1.Text = "-" Then
            screen.Text = Val(Label2.Text) - Val(screen.Text)
            Label2.Text = ""
            Label1.Text = "="
        End If

        If Label1.Text = "/" Then
            screen.Text = Val(Label2.Text) / Val(screen.Text)
            Label2.Text = ""
            Label1.Text = "="
        End If

        If Label1.Text = "x" Then
            screen.Text = Val(Label2.Text) * Val(screen.Text)
            Label2.Text = ""
            Label1.Text = "="
        End If

        If Label1.Text = "%" Then
            screen.Text = Val(Label2.Text) Mod Val(screen.Text)
            Label2.Text = ""
            Label1.Text = "="
        End If
    End Sub


    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        screen.Text = screen.Text + "1"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        screen.Text = screen.Text + "2"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        screen.Text = screen.Text + "3"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        screen.Text = screen.Text + "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        screen.Text = screen.Text + "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        screen.Text = screen.Text + "6"
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        screen.Text = screen.Text + "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        screen.Text = screen.Text + "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        screen.Text = screen.Text + "9"
    End Sub

    Private Sub btndot_Click(sender As Object, e As EventArgs) Handles btndot.Click
        screen.Text = screen.Text + "."
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        screen.Text = screen.Text + "0"
    End Sub

    Private Sub btn00_Click(sender As Object, e As EventArgs) Handles btn00.Click
        screen.Text = screen.Text + "00"
    End Sub

    Private Sub screen_TextChanged(sender As Object, e As EventArgs) Handles screen.TextChanged

    End Sub

    Private Sub sum_Click(sender As Object, e As EventArgs) Handles sum.Click
        Label2.Text = screen.Text
        Label1.Text = "+"
        screen.Text = ""
    End Sub

    Private Sub subtract_Click(sender As Object, e As EventArgs) Handles subtract.Click
        Label2.Text = screen.Text
        Label1.Text = "-"
        screen.Text = ""
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        Label2.Text = screen.Text
        Label1.Text = "/"
        screen.Text = ""
    End Sub

    Private Sub times_Click(sender As Object, e As EventArgs) Handles times.Click
        Label2.Text = screen.Text
        Label1.Text = "x"
        screen.Text = ""
    End Sub

    Private Sub perbtn_Click(sender As Object, e As EventArgs) Handles perbtn.Click
        Label2.Text = screen.Text
        Label1.Text = "%"
        screen.Text = ""
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        screen.Text = ""
        Label2.Text = ""
        Label1.Text = ""
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
