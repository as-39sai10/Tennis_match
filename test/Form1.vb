Public Class Form1

    Private i As UInteger = 0
    Private j As UInteger = 0

    Private gameflg1 As UInteger = 0
    Private gameflg5 As UInteger = 0
    Private gameflg7 As UInteger = 0

    Private DEflg As UInteger = 0
    Private ADflg As UInteger = 0
    Private BRRflg As UInteger = 0
    Private BRLflg As UInteger = 0

    Private wincnt1p As UInteger = 0
    Private wincnt2p As UInteger = 0



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'game select
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        gameflg1 = 1
        gameflg5 = 0
        gameflg7 = 0


        Me.Button2.Enabled = False
        Me.Button20.Enabled = False
        Me.Button13.Enabled = False
        Me.Button27.Enabled = False
        Me.TextBox5.Enabled = False
        Me.TextBox6.Enabled = False


        Me.Button3.Enabled = False
        Me.Button19.Enabled = False
        Me.Button12.Enabled = False
        Me.Button26.Enabled = False
        Me.TextBox7.Enabled = False
        Me.TextBox8.Enabled = False


        Me.Button8.Enabled = False
        Me.Button4.Enabled = False
        Me.Button22.Enabled = False
        Me.Button15.Enabled = False
        Me.TextBox9.Enabled = False
        Me.TextBox10.Enabled = False


        Me.Button9.Enabled = False
        Me.Button6.Enabled = False
        Me.Button23.Enabled = False
        Me.Button16.Enabled = False
        Me.TextBox11.Enabled = False
        Me.TextBox12.Enabled = False


        Me.Button11.Enabled = False
        Me.Button7.Enabled = False
        Me.Button25.Enabled = False
        Me.Button18.Enabled = False
        Me.TextBox13.Enabled = False
        Me.TextBox14.Enabled = False


        'final
        Me.Button5.Enabled = False
        Me.Button17.Enabled = False
        Me.Button10.Enabled = False
        Me.Button24.Enabled = False
        Me.TextBox15.Enabled = False
        Me.TextBox16.Enabled = False


    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        gameflg1 = 0
        gameflg5 = 1
        gameflg7 = 0

        '5game

        Me.Button2.Enabled = True
        Me.Button20.Enabled = True
        Me.Button13.Enabled = True
        Me.Button27.Enabled = True
        Me.TextBox5.Enabled = True
        Me.TextBox6.Enabled = True


        Me.Button3.Enabled = True
        Me.Button19.Enabled = True
        Me.Button12.Enabled = True
        Me.Button26.Enabled = True
        Me.TextBox7.Enabled = True
        Me.TextBox8.Enabled = True


        Me.Button8.Enabled = True
        Me.Button4.Enabled = True
        Me.Button22.Enabled = True
        Me.Button15.Enabled = True
        Me.TextBox9.Enabled = True
        Me.TextBox10.Enabled = True


        Me.Button9.Enabled = False
        Me.Button6.Enabled = False
        Me.Button23.Enabled = False
        Me.Button16.Enabled = False
        Me.TextBox11.Enabled = False
        Me.TextBox12.Enabled = False


        Me.Button11.Enabled = False
        Me.Button7.Enabled = False
        Me.Button25.Enabled = False
        Me.Button18.Enabled = False
        Me.TextBox13.Enabled = False
        Me.TextBox14.Enabled = False


        Me.Button5.Enabled = True
        Me.Button17.Enabled = True
        Me.Button10.Enabled = True
        Me.Button24.Enabled = True
        Me.TextBox15.Enabled = True
        Me.TextBox16.Enabled = True

    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        gameflg1 = 0
        gameflg5 = 0
        gameflg7 = 1

        '7game

        Me.Button2.Enabled = True
        Me.Button20.Enabled = True
        Me.Button13.Enabled = True
        Me.Button27.Enabled = True
        Me.TextBox5.Enabled = True
        Me.TextBox6.Enabled = True


        Me.Button3.Enabled = True
        Me.Button19.Enabled = True
        Me.Button12.Enabled = True
        Me.Button26.Enabled = True
        Me.TextBox7.Enabled = True
        Me.TextBox8.Enabled = True


        Me.Button8.Enabled = True
        Me.Button4.Enabled = True
        Me.Button22.Enabled = True
        Me.Button15.Enabled = True
        Me.TextBox9.Enabled = True
        Me.TextBox10.Enabled = True


        Me.Button9.Enabled = True
        Me.Button6.Enabled = True
        Me.Button23.Enabled = True
        Me.Button16.Enabled = True
        Me.TextBox11.Enabled = True
        Me.TextBox12.Enabled = True


        Me.Button11.Enabled = True
        Me.Button7.Enabled = True
        Me.Button25.Enabled = True
        Me.Button18.Enabled = True
        Me.TextBox13.Enabled = True
        Me.TextBox14.Enabled = True


        Me.Button5.Enabled = True
        Me.Button17.Enabled = True
        Me.Button10.Enabled = True
        Me.Button24.Enabled = True
        Me.TextBox15.Enabled = True
        Me.TextBox16.Enabled = True

    End Sub


    '1line
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Label1.Text = i

        i = i + 1
        TextBox3.Text = i

        If (i > 4) Then
            i = 0
            TextBox3.Text = 0
        End If

        If ((i = 4 And j < 3) Or BRLflg = 1) Then
            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt1p = wincnt1p + 1
            TextBox3.Text = "break"
            Me.Button1.Enabled = False
            Me.Button21.Enabled = False
            Me.Button14.Enabled = False
            Me.Button28.Enabled = False
            Me.TextBox3.Enabled = False
            Me.TextBox4.Enabled = False

            If (gameflg1 = 1) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If

        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRLflg = 0
            BRRflg = 0
            TextBox3.Text = "DE"
            TextBox4.Text = "DE"
        End If

        If (i > j And DEflg = 1) Then
            
            DEflg = 0
            ADflg = 1
            BRRflg = 0
            BRLflg = 1
            TextBox3.Text = "AD"
            TextBox4.Text = "--"

        End If





    End Sub
    Private Sub Button21_Click_1(sender As Object, e As EventArgs) Handles Button21.Click

        If (i > 0) Then
            i = i - 1
            TextBox3.Text = i
        End If

    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click

        Label2.Text = j


        j = j + 1
        TextBox4.Text = j

        If (j > 4) Then
            j = 0
            TextBox4.Text = 0
        End If

        If ((j = 4 And i < 3) Or BRRflg = 1) Then

            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt2p = wincnt2p + 1
            TextBox4.Text = "break"
            Me.Button1.Enabled = False
            Me.Button21.Enabled = False
            Me.Button14.Enabled = False
            Me.Button28.Enabled = False
            Me.TextBox3.Enabled = False
            Me.TextBox4.Enabled = False

            If (gameflg1 = 1) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If

        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox3.Text = "DE"
            TextBox4.Text = "DE"
        End If

        If (j > i And DEflg = 1) Then
            
            DEflg = 0
            ADflg = 1
            BRLflg = 0
            BRRflg = 1
            TextBox3.Text = "--"
            TextBox4.Text = "AD"

        End If





    End Sub
    Private Sub Button28_Click(sender As Object, e As EventArgs) Handles Button28.Click

        If (j > 0) Then
            j = j - 1
            TextBox4.Text = j
        End If

    End Sub

    '2line
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (TextBox3.Text = "break" Or TextBox4.Text = "break") Then
            i = i + 1
            TextBox5.Text = i
        End If


        If (i > 4) Then
            i = 0
            TextBox5.Text = 0
        End If

        If ((i = 4 And j < 3) Or BRLflg = 1) Then
            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt1p = wincnt1p + 1
            TextBox5.Text = "break"
            Me.Button2.Enabled = False
            Me.Button20.Enabled = False
            Me.Button13.Enabled = False
            Me.Button27.Enabled = False
            Me.TextBox5.Enabled = False
            Me.TextBox6.Enabled = False

        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox5.Text = "DE"
            TextBox6.Text = "DE"
        End If

        If (i > j And DEflg = 1) Then
            DEflg = 0
            ADflg = 1
            BRLflg = 1
            TextBox5.Text = "AD"
            TextBox6.Text = "--"

        End If

    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click

        If (TextBox3.Text = "break" Or TextBox4.Text = "break") Then
            If (i > 0) Then
                i = i - 1
                TextBox5.Text = i
            End If
        End If
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        If (TextBox3.Text = "break" Or TextBox4.Text = "break") Then
            j = j + 1
            TextBox6.Text = j
        End If


        If (j > 4) Then
            j = 0
            TextBox6.Text = 0
        End If

        If ((j = 4 And i < 3) Or BRRflg = 1) Then

            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt2p = wincnt2p + 1
            TextBox6.Text = "break"
            Me.Button2.Enabled = False
            Me.Button20.Enabled = False
            Me.Button13.Enabled = False
            Me.Button27.Enabled = False
            Me.TextBox5.Enabled = False
            Me.TextBox6.Enabled = False

        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox5.Text = "DE"
            TextBox6.Text = "DE"
        End If

        If (j > i And DEflg = 1) Then

            DEflg = 0
            ADflg = 1
            BRRflg = 1
            TextBox5.Text = "--"
            TextBox6.Text = "AD"

        End If
    End Sub
    Private Sub Button27_Click(sender As Object, e As EventArgs) Handles Button27.Click
        If (TextBox3.Text = "break" Or TextBox4.Text = "break") Then
            If (j > 0) Then
                j = j - 1
                TextBox6.Text = j
            End If
        End If
    End Sub

    '3line
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        If (TextBox5.Text = "break" Or TextBox6.Text = "break") Then
            i = i + 1
            TextBox7.Text = i
        End If

        If (i > 4) Then
            i = 0
            TextBox7.Text = 0
        End If

        If ((i = 4 And j < 3) Or BRLflg = 1) Then
            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt1p = wincnt1p + 1
            TextBox7.Text = "break"
            Me.Button3.Enabled = False
            Me.Button19.Enabled = False
            Me.Button12.Enabled = False
            Me.Button26.Enabled = False
            Me.TextBox7.Enabled = False
            Me.TextBox8.Enabled = False

            If (gameflg5 = 1 And wincnt1p = 3) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If

        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox7.Text = "DE"
            TextBox8.Text = "DE"
        End If

        If (i > j And DEflg = 1) Then
            DEflg = 0
            ADflg = 1
            BRLflg = 1
            TextBox7.Text = "AD"
            TextBox8.Text = "--"

        End If

    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        If (TextBox5.Text = "break" Or TextBox6.Text = "break") Then
            If (i > 0) Then
                i = i - 1
                TextBox7.Text = i
            End If
        End If

    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        If (TextBox5.Text = "break" Or TextBox6.Text = "break") Then
            j = j + 1
            TextBox8.Text = j
        End If


        If (j > 4) Then
            j = 0
            TextBox8.Text = 0
        End If

        If ((j = 4 And i < 3) Or BRRflg = 1) Then

            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt2p = wincnt2p + 1
            TextBox8.Text = "break"
            Me.Button3.Enabled = False
            Me.Button19.Enabled = False
            Me.Button12.Enabled = False
            Me.Button26.Enabled = False
            Me.TextBox7.Enabled = False
            Me.TextBox8.Enabled = False


            If (gameflg5 = 1 And wincnt2p = 3) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If

        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox7.Text = "DE"
            TextBox8.Text = "DE"
        End If

        If (j > i And DEflg = 1) Then

            DEflg = 0
            ADflg = 1
            BRRflg = 1
            TextBox7.Text = "--"
            TextBox8.Text = "AD"

        End If
    End Sub
    Private Sub Button26_Click(sender As Object, e As EventArgs) Handles Button26.Click
        If (TextBox5.Text = "break" Or TextBox6.Text = "break") Then
            If (j > 0) Then
                j = j - 1
                TextBox8.Text = j
            End If
        End If
    End Sub

    '4line
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (TextBox7.Text = "break" Or TextBox8.Text = "break") Then
            i = i + 1
            TextBox9.Text = i
        End If


        If (i > 4) Then
            i = 0
            TextBox9.Text = 0
        End If

        If ((i = 4 And j < 3) Or BRLflg = 1) Then
            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt1p = wincnt1p + 1
            TextBox9.Text = "break"
            Me.Button8.Enabled = False
            Me.Button4.Enabled = False
            Me.Button22.Enabled = False
            Me.Button15.Enabled = False
            Me.TextBox9.Enabled = False
            Me.TextBox10.Enabled = False

            If ((gameflg5 = 1 And wincnt1p = 3) Or (gameflg7 = 1 And wincnt1p = 4)) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If


        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox9.Text = "DE"
            TextBox10.Text = "DE"
        End If

        If (i > j And DEflg = 1) Then
            DEflg = 0
            ADflg = 1
            BRLflg = 1
            TextBox9.Text = "AD"
            TextBox10.Text = "--"

        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If (TextBox7.Text = "break" Or TextBox8.Text = "break") Then
            If (i > 0) Then
                i = i - 1
                TextBox9.Text = i
            End If
        End If

    End Sub
    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        If (TextBox7.Text = "break" Or TextBox8.Text = "break") Then
            j = j + 1
            TextBox10.Text = j
        End If

        If (j > 4) Then
            j = 0
            TextBox10.Text = 0
        End If

        If ((j = 4 And i < 3) Or BRRflg = 1) Then

            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt2p = wincnt2p + 1
            TextBox10.Text = "break"
            Me.Button8.Enabled = False
            Me.Button4.Enabled = False
            Me.Button22.Enabled = False
            Me.Button15.Enabled = False
            Me.TextBox9.Enabled = False
            Me.TextBox10.Enabled = False

            If ((gameflg5 = 1 And wincnt2p = 3) Or (gameflg7 = 1 And wincnt1p = 4)) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If
        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox9.Text = "DE"
            TextBox10.Text = "DE"
        End If

        If (j > i And DEflg = 1) Then

            DEflg = 0
            ADflg = 1
            BRRflg = 1
            TextBox9.Text = "--"
            TextBox10.Text = "AD"

        End If
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        If (TextBox7.Text = "break" Or TextBox8.Text = "break") Then
            If (j > 0) Then
                j = j - 1
                TextBox10.Text = j
            End If
        End If
    End Sub

    '5line
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (TextBox9.Text = "break" Or TextBox10.Text = "break") Then
            i = i + 1
            TextBox11.Text = i
        End If

        If (i > 4) Then
            i = 0
            TextBox11.Text = 0
        End If

        If ((i = 4 And j < 3) Or BRLflg = 1) Then
            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt1p = wincnt1p + 1
            TextBox11.Text = "break"
            Me.Button9.Enabled = False
            Me.Button6.Enabled = False
            Me.Button23.Enabled = False
            Me.Button16.Enabled = False
            Me.TextBox11.Enabled = False
            Me.TextBox12.Enabled = False

            If ((gameflg5 = 1 And wincnt2p = 3) Or (gameflg7 = 1 And wincnt1p = 4)) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If

        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox11.Text = "DE"
            TextBox12.Text = "DE"
        End If

        If (i > j And DEflg = 1) Then
            DEflg = 0
            ADflg = 1
            BRLflg = 1
            TextBox11.Text = "AD"
            TextBox12.Text = "--"

        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (TextBox9.Text = "break" Or TextBox10.Text = "break") Then
            If (i > 0) Then
                i = i - 1
                TextBox11.Text = i
            End If
        End If
    End Sub
    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        If (TextBox9.Text = "break" Or TextBox10.Text = "break") Then
            j = j + 1
            TextBox12.Text = j
        End If

        If (j > 4) Then
            j = 0
            TextBox12.Text = 0
        End If

        If ((j = 4 And i < 3) Or BRRflg = 1) Then

            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt2p = wincnt2p + 1
            TextBox12.Text = "break"
            Me.Button9.Enabled = False
            Me.Button6.Enabled = False
            Me.Button23.Enabled = False
            Me.Button16.Enabled = False
            Me.TextBox11.Enabled = False
            Me.TextBox12.Enabled = False

            If ((gameflg5 = 1 And wincnt2p = 3) Or (gameflg7 = 1 And wincnt1p = 4)) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If

        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox11.Text = "DE"
            TextBox12.Text = "DE"
        End If

        If (j > i And DEflg = 1) Then

            DEflg = 0
            ADflg = 1
            BRRflg = 1
            TextBox11.Text = "--"
            TextBox12.Text = "AD"

        End If
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        If (TextBox9.Text = "break" Or TextBox10.Text = "break") Then
            If (j > 0) Then
                j = j - 1
                TextBox12.Text = j
            End If
        End If

    End Sub

    '6line
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If (TextBox11.Text = "break" Or TextBox12.Text = "break") Then
            i = i + 1
            TextBox13.Text = i
        End If

        If (i > 4) Then
            i = 0
            TextBox13.Text = 0
        End If

        If ((i = 4 And j < 3) Or BRLflg = 1) Then
            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt1p = wincnt1p + 1
            TextBox13.Text = "break"
            Me.Button11.Enabled = False
            Me.Button7.Enabled = False
            Me.Button25.Enabled = False
            Me.Button18.Enabled = False
            Me.TextBox13.Enabled = False
            Me.TextBox14.Enabled = False

            If ((gameflg5 = 1 And wincnt2p = 3) Or (gameflg7 = 1 And wincnt1p = 4)) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If

        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox13.Text = "DE"
            TextBox14.Text = "DE"
        End If

        If (i > j And DEflg = 1) Then
            DEflg = 0
            ADflg = 1
            BRLflg = 1
            TextBox13.Text = "AD"
            TextBox14.Text = "--"

        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (TextBox11.Text = "break" Or TextBox12.Text = "break") Then
            If (i > 0) Then
                i = i - 1
                TextBox13.Text = i
            End If
        End If

    End Sub
    Private Sub Button25_Click(sender As Object, e As EventArgs) Handles Button25.Click
        If (TextBox11.Text = "break" Or TextBox12.Text = "break") Then
            j = j + 1
            TextBox14.Text = j
        End If

        If (j > 4) Then
            j = 0
            TextBox14.Text = 0
        End If

        If ((j = 4 And i < 3) Or BRRflg = 1) Then

            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt2p = wincnt2p + 1
            TextBox14.Text = "break"
            Me.Button11.Enabled = False
            Me.Button7.Enabled = False
            Me.Button25.Enabled = False
            Me.Button18.Enabled = False
            Me.TextBox13.Enabled = False
            Me.TextBox14.Enabled = False

            If ((gameflg5 = 1 And wincnt2p = 3) Or (gameflg7 = 1 And wincnt1p = 4)) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If

        End If

        If ((i > 2 And j > 2) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox13.Text = "DE"
            TextBox14.Text = "DE"
        End If

        If (j > i And DEflg = 1) Then

            DEflg = 0
            ADflg = 1
            BRRflg = 1
            TextBox13.Text = "--"
            TextBox14.Text = "AD"

        End If
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        If (TextBox11.Text = "break" Or TextBox12.Text = "break") Then
            If (j > 0) Then
                j = j - 1
                TextBox14.Text = j
            End If
        End If

    End Sub


    'finalline
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If ((wincnt1p = wincnt2p) And (TextBox9.Text = "break" Or TextBox10.Text = "break" Or TextBox13.Text = "break" Or TextBox14.Text = "break")) Then
            i = i + 1
            TextBox15.Text = i
        End If


        If (i > 7) Then
            i = 0
            TextBox15.Text = 0
        End If

        If ((i = 7 And j < 6) Or BRLflg = 1) Then
            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt1p = wincnt1p + 1
            TextBox15.Text = "break"
            'Me.Button2.Enabled = False
            'Me.Button20.Enabled = False
            'Me.Button13.Enabled = False
            'Me.Button27.Enabled = False
            'Me.TextBox5.Enabled = False
            'Me.TextBox6.Enabled = False

            If ((gameflg5 = 1 And wincnt1p = 3) Or (gameflg7 = 1 And wincnt1p = 4)) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If
        End If

        If ((i > 5 And j > 5) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox5.Text = "DE"
            TextBox6.Text = "DE"
        End If

        If (i > j And DEflg = 1) Then
            DEflg = 0
            ADflg = 1
            BRLflg = 1
            TextBox5.Text = "AD"
            TextBox6.Text = "--"

        End If
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click

    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click

        If ((wincnt1p = wincnt2p) And (TextBox9.Text = "break" Or TextBox10.Text = "break" Or TextBox13.Text = "break" Or TextBox14.Text = "break")) Then
            j = j + 1
            TextBox16.Text = j
        End If


        If (j > 7) Then
            j = 0
            TextBox16.Text = 0
        End If

        If ((j = 7 And i < 6) Or BRLflg = 1) Then
            i = 0
            j = 0
            DEflg = 0
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            wincnt2p = wincnt2p + 1
            TextBox16.Text = "break"
            'Me.Button2.Enabled = False
            'Me.Button20.Enabled = False
            'Me.Button13.Enabled = False
            'Me.Button27.Enabled = False
            'Me.TextBox5.Enabled = False
            'Me.TextBox6.Enabled = False

            If ((gameflg5 = 1 And wincnt2p = 3) Or (gameflg7 = 1 And wincnt2p = 4)) Then
                Me.RadioButton1.Enabled = False
                Me.RadioButton2.Enabled = False
                Me.RadioButton3.Enabled = False
                MsgBox("GAMESET")
            End If
        End If

        If ((j > 5 And i > 5) Or ADflg = 1) Then
            i = 0
            j = 0
            DEflg = 1
            ADflg = 0
            BRRflg = 0
            BRLflg = 0
            TextBox15.Text = "DE"
            TextBox16.Text = "DE"
        End If

        If (j > i And DEflg = 1) Then
            DEflg = 0
            ADflg = 1
            BRLflg = 1
            TextBox15.Text = "--"
            TextBox16.Text = "AD"
        End If

    End Sub
    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
