Public Class Form1
    Dim num1, num2, res As Double
    Dim op As Integer
    Dim ops As Boolean = False
    Dim newNum As Boolean = True

    Private Sub modBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles modBtn.MouseDown
        modBtn.Image = My.Resources.modclkd
    End Sub

    Private Sub modBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles modBtn.MouseUp
        modBtn.Image = My.Resources._mod
    End Sub

    Private Sub clearbtn_MouseDown(sender As Object, e As MouseEventArgs) Handles clearbtn.MouseDown
        clearbtn.Image = My.Resources.cclicked
    End Sub

    Private Sub clearbtn_MouseUp(sender As Object, e As MouseEventArgs) Handles clearbtn.MouseUp
        clearbtn.Image = My.Resources.c
    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        If (TextBox1.Text.Length > 0) Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
        If (TextBox1.Text = "") Then
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub delBtn_MouseDown(sender As Object, e As MouseEventArgs) Handles delBtn.MouseDown
        delBtn.Image = My.Resources.delclicked

    End Sub

    Private Sub delBtn_MouseUp(sender As Object, e As MouseEventArgs) Handles delBtn.MouseUp
        delBtn.Image = My.Resources.del
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If newNum Then
            TextBox1.Text = ""
            newNum = False
        End If
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "1"
        Else
            TextBox1.Text = "1"
        End If
    End Sub

    Private Sub btn1_MouseDown(sender As Object, e As MouseEventArgs) Handles btn1.MouseDown
        btn1.Image = My.Resources._1clicked
    End Sub

    Private Sub btn1_MouseUp(sender As Object, e As MouseEventArgs) Handles btn1.MouseUp
        btn1.Image = My.Resources._1__1_
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If newNum Then
            TextBox1.Text = ""
            newNum = False
        End If
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "2"
        Else
            TextBox1.Text = "2"
        End If
    End Sub

    Private Sub btn2_MouseDown(sender As Object, e As MouseEventArgs) Handles btn2.MouseDown
        btn2.Image = My.Resources.btn2clicked
    End Sub

    Private Sub btn2_MouseUp(sender As Object, e As MouseEventArgs) Handles btn2.MouseUp
        btn2.Image = My.Resources.btn2__1_
    End Sub

    Private Sub bnt3_Click(sender As Object, e As EventArgs) Handles bnt3.Click
        If newNum Then
            TextBox1.Text = ""
            newNum = False
        End If
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "3"
        Else
            TextBox1.Text = "3"
        End If
    End Sub

    Private Sub bnt3_MouseDown(sender As Object, e As MouseEventArgs) Handles bnt3.MouseDown
        bnt3.Image = My.Resources.bnt3clicked
    End Sub

    Private Sub bnt3_MouseUp(sender As Object, e As MouseEventArgs) Handles bnt3.MouseUp
        bnt3.Image = My.Resources.btn3
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If newNum Then
            TextBox1.Text = ""
            newNum = False
        End If
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "4"
        Else
            TextBox1.Text = "4"
        End If
    End Sub

    Private Sub btn4_MouseDown(sender As Object, e As MouseEventArgs) Handles btn4.MouseDown
        btn4.Image = My.Resources.btn4clicked
    End Sub

    Private Sub btn4_MouseUp(sender As Object, e As MouseEventArgs) Handles btn4.MouseUp
        btn4.Image = My.Resources.btn4
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If newNum Then
            TextBox1.Text = ""
            newNum = False
        End If
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "5"
        Else
            TextBox1.Text = "5"
        End If
    End Sub

    Private Sub btn5_MouseDown(sender As Object, e As MouseEventArgs) Handles btn5.MouseDown
        btn5.Image = My.Resources.btn5clicked
    End Sub

    Private Sub btn5_MouseUp(sender As Object, e As MouseEventArgs) Handles btn5.MouseUp
        btn5.Image = My.Resources.btn5
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If newNum Then
            TextBox1.Text = ""
            newNum = False
        End If
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "6"
        Else
            TextBox1.Text = "6"
        End If
    End Sub

    Private Sub btn6_MouseDown(sender As Object, e As MouseEventArgs) Handles btn6.MouseDown
        btn6.Image = My.Resources.btn6clicked
    End Sub

    Private Sub btn6_MouseUp(sender As Object, e As MouseEventArgs) Handles btn6.MouseUp
        btn6.Image = My.Resources.btn6
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If newNum Then
            TextBox1.Text = ""
            newNum = False
        End If
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "7"
        Else
            TextBox1.Text = "7"
        End If
    End Sub

    Private Sub btn7_MouseDown(sender As Object, e As MouseEventArgs) Handles btn7.MouseDown
        btn7.Image = My.Resources.btn7clicked
    End Sub

    Private Sub btn7_MouseUp(sender As Object, e As MouseEventArgs) Handles btn7.MouseUp
        btn7.Image = My.Resources.btn7
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If newNum Then
            TextBox1.Text = ""
            newNum = False
        End If
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "8"
        Else
            TextBox1.Text = "8"
        End If
    End Sub

    Private Sub btn8_MouseDown(sender As Object, e As MouseEventArgs) Handles btn8.MouseDown
        btn8.Image = My.Resources.btn8clicked
    End Sub

    Private Sub btn8_MouseUp(sender As Object, e As MouseEventArgs) Handles btn8.MouseUp
        btn8.Image = My.Resources.btn8
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If newNum Then
            TextBox1.Text = ""
            newNum = False
        End If
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "9"
        Else
            TextBox1.Text = "9"
        End If
    End Sub

    Private Sub btn9_MouseUp(sender As Object, e As MouseEventArgs) Handles btn9.MouseUp
        btn9.Image = My.Resources.btn9
    End Sub

    Private Sub btn9_MouseDown(sender As Object, e As MouseEventArgs) Handles btn9.MouseDown
        btn9.Image = My.Resources.btn9clicked
    End Sub

    Private Sub bnt0_Click(sender As Object, e As EventArgs) Handles bnt0.Click
        If newNum Then
            TextBox1.Text = ""
            newNum = False
        End If
        If TextBox1.Text <> "0" Then
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub bnt0_MouseDown(sender As Object, e As MouseEventArgs) Handles bnt0.MouseDown
        bnt0.Image = My.Resources.btn0clicked
    End Sub

    Private Sub bnt0_MouseUp(sender As Object, e As MouseEventArgs) Handles bnt0.MouseUp
        bnt0.Image = My.Resources.btn0
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        ops = True
        op = 6 '= ^
        newNum = False
    End Sub

    Private Sub btnS_MouseDown(sender As Object, e As MouseEventArgs) Handles btnS.MouseDown
        btnS.Image = My.Resources.btnSclicked
    End Sub

    Private Sub btnS_MouseUp(sender As Object, e As MouseEventArgs) Handles btnS.MouseUp
        btnS.Image = My.Resources.btnS
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        If Not (TextBox1.Text.Contains(".")) Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub btnP_MouseDown(sender As Object, e As MouseEventArgs) Handles btnP.MouseDown
        btnP.Image = My.Resources.btnPclicked
    End Sub

    Private Sub btnP_MouseUp(sender As Object, e As MouseEventArgs) Handles btnP.MouseUp
        btnP.Image = My.Resources.btnP
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        num2 = TextBox1.Text
        If op = 1 Then
            TextBox1.Text = num1 + num2
        ElseIf op = 2 Then
            TextBox1.Text = num1 - num2
        ElseIf op = 3 Then
            TextBox1.Text = num1 * num2
        ElseIf op = 5 Then
            TextBox1.Text = num1 Mod num2
        ElseIf op = 6 Then
            TextBox1.Text = num1 ^ num2
        Else
            If num2 = 0 Then
                TextBox1.Text = "Syntax Error"
            Else
                TextBox1.Text = num1 / num2
            End If
        End If
        ops = False
        newNum = True

    End Sub

    Private Sub btnE_MouseDown(sender As Object, e As MouseEventArgs) Handles btnE.MouseDown
        btnE.Image = My.Resources.btnE
    End Sub

    Private Sub btnE_MouseUp(sender As Object, e As MouseEventArgs) Handles btnE.MouseUp
        btnE.Image = My.Resources.btnEclicked
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        ops = True
        op = 1 '= +
        newNum = False

    End Sub

    Private Sub btnA_MouseDown(sender As Object, e As MouseEventArgs) Handles btnA.MouseDown
        btnA.Image = My.Resources.btnAclicked
    End Sub

    Private Sub btnA_MouseUp(sender As Object, e As MouseEventArgs) Handles btnA.MouseUp
        btnA.Image = My.Resources.btnA
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        ops = True
        op = 2 '= -
        newNum = False
    End Sub

    Private Sub btnM_MouseDown(sender As Object, e As MouseEventArgs) Handles btnM.MouseDown
        btnM.Image = My.Resources.btnMclicked
    End Sub

    Private Sub btnM_MouseUp(sender As Object, e As MouseEventArgs) Handles btnM.MouseUp
        btnM.Image = My.Resources.btnM
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        ops = True
        op = 3 ' = *
        newNum = False
    End Sub

    Private Sub btnX_MouseDown(sender As Object, e As MouseEventArgs) Handles btnX.MouseDown
        btnX.Image = My.Resources.btnXclicked
    End Sub

    Private Sub btnX_MouseUp(sender As Object, e As MouseEventArgs) Handles btnX.MouseUp
        btnX.Image = My.Resources.btnX
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        num1 = TextBox1.Text
        TextBox1.Text = "0"
        ops = True
        op = 4 '= /
        newNum = False
    End Sub

    Private Sub clearbtn_Click(sender As Object, e As EventArgs) Handles clearbtn.Click
        If TextBox1.Text <> "" Then
            TextBox1.Text = "0"
        End If
    End Sub

    Private Sub modBtn_Click(sender As Object, e As EventArgs) Handles modBtn.Click
        If TextBox1.Text <> "" Then
            num1 = TextBox1.Text
            TextBox1.Text = "0"
            ops = True
            op = 5 '= %
            newNum = False
        End If

    End Sub

    Private Sub btnD_MouseDown(sender As Object, e As MouseEventArgs) Handles btnD.MouseDown
        btnD.Image = My.Resources.btnDclicked
    End Sub

    Private Sub btnD_MouseUp(sender As Object, e As MouseEventArgs) Handles btnD.MouseUp
        btnD.Image = My.Resources.btnD
    End Sub
End Class
