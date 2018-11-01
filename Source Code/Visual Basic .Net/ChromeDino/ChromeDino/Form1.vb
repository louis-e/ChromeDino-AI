Public Class Form1
    'http://www.trex-game.skipser.com/
    Dim count As Integer = 0
    Dim count2 As Integer = 1
    Dim bestscore As Integer

    Private Declare Sub keybd_event Lib "user32" (ByVal bVk As Byte, ByVal bScan As Byte, ByVal dwFlags As Integer, ByVal dwExtraInfo As Integer)
    Private Const KEYEVENTF_EXTENDEDKEY As Integer = &H1
    Private Const KEYEVENTF_KEYUP As Integer = &H2

    Private Sub iKeyDown(ByVal vKey As Keys)
        keybd_event(CByte(vKey), 0, KEYEVENTF_EXTENDEDKEY, 0)
    End Sub

    Private Sub iKeyUp(ByVal vKey As Keys)
        keybd_event(CByte(vKey), 0, KEYEVENTF_EXTENDEDKEY Or KEYEVENTF_KEYUP, 0)
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.Text = "starting..."
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        AskForpixel(512, 387)


        AskForpixel(513, 387)


        AskForpixel(514, 387)


        AskForpixel(515, 387)


        AskForpixel(516, 387)


        AskForpixel(517, 387)


        AskForpixel(518, 387)


        AskForpixel(519, 387)


        AskForpixel(520, 387)


        AskForpixel(521, 387)


        AskForpixel(522, 387)


        AskForpixel(523, 387)


        AskForpixel(513, 380)


        AskForpixel(514, 381)


        AskForpixel(515, 382)


        AskForpixel(516, 383)

    End Sub

    Dim waitForNext As Integer = 20
    Sub AskForpixel(x As Integer, y As Integer)
        Dim b As New Bitmap(1, 1)
        Using g As Graphics = Graphics.FromImage(b)
            g.CopyFromScreen(x, y, 0, 0, New Size(1, 1))
        End Using
        Dim cl As Color = b.GetPixel(0, 0)


        If cl.ToString = "Color [A=255, R=83, G=83, B=83]" Then
            iKeyUp(Keys.Down)
            waitForNext = 20
            RichTextBox1.AppendText(vbNewLine & "recognized obstacle: " & "X:" & x.ToString & " " & "Y:" & y.ToString)
            SendKeys.Send(" ")
            count = count + 1
            Label1.Text = count.ToString
        Else
            If waitForNext > 0 Then
                waitForNext = waitForNext - 1
            Else
                iKeyDown(Keys.Down)
                waitForNext = 20
            End If
        End If

    End Sub

    Sub AskForGameEnd()
        Dim b As New Bitmap(1, 1)
        Using g As Graphics = Graphics.FromImage(b)
            g.CopyFromScreen(701, 360, 0, 0, New Size(1, 1))
        End Using
        Dim cl As Color = b.GetPixel(0, 0)


        If cl.ToString = "Color [A=255, R=83, G=83, B=83]" Then
            If count > bestscore Then
                bestscore = count
                Label5.Text = bestscore.ToString & "A"
            End If

            count = 0
            Label1.Text = "0"

            count2 = count2 + 1
            Label7.Text = count2.ToString

            RichTextBox1.Text = ""
            RichTextBox1.Text = "recognized game end" & vbNewLine & "restarting..."
            SendKeys.Send(" ")
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        AskForGameEnd()
        RichTextBox1.Text = ""
    End Sub
End Class