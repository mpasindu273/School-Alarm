Public Class alarm
    Dim i As Integer


    Private Sub alarm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.strtset Then
            bstrt.BackColor = ColorTranslator.FromHtml("#ba55d3")
        Else
            bstrt.BackColor = Color.Black
        End If


        If My.Settings.lunchset Then
            blunch.BackColor = ColorTranslator.FromHtml("#ba55d3")
        Else
            blunch.BackColor = Color.Black
        End If


        If My.Settings.overset Then
            bover.BackColor = ColorTranslator.FromHtml("#ba55d3")
        Else
            bover.BackColor = Color.Black
        End If

        th1.Text = My.Settings.h1
        tm1.Text = My.Settings.m1
        ts1.Text = My.Settings.s1

        th2.Text = My.Settings.h2
        tm2.Text = My.Settings.m2
        ts2.Text = My.Settings.s2

        th3.Text = My.Settings.h3
        tm3.Text = My.Settings.m3
        ts3.Text = My.Settings.s3
    End Sub

    Function txtchange(t1 As TextBox, t2 As TextBox, t3 As TextBox, t4 As TextBox, t5 As TextBox, t6 As TextBox, t7 As TextBox, t8 As TextBox, t9 As TextBox) As Integer
        Dim txt As TextBox() = {t1, t2, t3, t4, t5, t6, t7, t8, t9}

        For Me.i = 0 To 8
            t1.Text = ""
            If txt(i).Text = "" Then
                txt(i).Text = "00"
            End If
        Next
        Return 0
    End Function


    Function autofil(th1 As TextBox, tm1 As TextBox, ts1 As TextBox) As Integer

        If th1.Text.Length = 1 Then
            th1.Text = "0" + th1.Text()
        End If

        If tm1.Text.Length = 1 Then
            tm1.Text = "0" + tm1.Text()
        End If

        If ts1.Text.Length = 1 Then
            ts1.Text = "0" + ts1.Text()
        End If

        Return 0
    End Function


    Function clear(t1 As TextBox, t2 As TextBox, t3 As TextBox) As Integer
        t1.Text = "00"
        t2.Text = "00"
        t3.Text = "00"
        Return 0
    End Function


    Function almsetcolor(btnset As Button, btncancl As Button) As Integer
        btnset.BackColor = ColorTranslator.FromHtml("#ba55d3")
        btncancl.BackColor = Color.Black
        Return 0
    End Function


    Function cancl(alarmset As Integer, setbtn As Button, cnclbtn As Button) As Integer
        ' My.Computer.Audio.Stop()
        setbtn.BackColor = Color.Black
        cnclbtn.BackColor = Color.Black
        alarmset = 0        
        Return 0
    End Function



    Private Sub th1_Click(sender As Object, e As EventArgs) Handles th1.Click
        txtchange(th1, tm1, ts1, th2, tm2, ts2, th3, tm3, ts3)
    End Sub

    Private Sub tm1_Click(sender As Object, e As EventArgs) Handles tm1.Click
        txtchange(tm1, th1, ts1, th2, tm2, ts2, th3, tm3, ts3)
    End Sub

    Private Sub ts1_Click(sender As Object, e As EventArgs) Handles ts1.Click
        txtchange(ts1, tm1, th1, th2, tm2, ts2, th3, tm3, ts3)
    End Sub

    Private Sub th2_Click(sender As Object, e As EventArgs) Handles th2.Click
        txtchange(th2, tm1, ts1, th1, tm2, ts2, th3, tm3, ts3)
    End Sub

    Private Sub tm2_Click(sender As Object, e As EventArgs) Handles tm2.Click
        txtchange(tm2, tm1, ts1, th2, th1, ts2, th3, tm3, ts3)
    End Sub

    Private Sub ts2_Click(sender As Object, e As EventArgs) Handles ts2.Click
        txtchange(ts2, tm1, ts1, th2, tm2, th1, th3, tm3, ts3)
    End Sub

    Private Sub th3_Click(sender As Object, e As EventArgs) Handles th3.Click
        txtchange(th3, tm1, ts1, th2, tm2, ts2, th1, tm3, ts3)
    End Sub

    Private Sub tm3_Click(sender As Object, e As EventArgs) Handles tm3.Click
        txtchange(tm3, tm1, ts1, th2, tm2, ts2, th3, th1, ts3)
    End Sub

    Private Sub ts3_Click(sender As Object, e As EventArgs) Handles ts3.Click
        txtchange(ts3, tm1, ts1, th2, tm2, ts2, th3, tm3, th1)
    End Sub



    Private Sub bstrt_Click(sender As Object, e As EventArgs) Handles bstrt.Click
        My.Settings.h1 = th1.Text
        My.Settings.m1 = tm1.Text
        My.Settings.s1 = ts1.Text
        My.Settings.strtset = 1
        My.Settings.Save()
        autofil(th1, tm1, ts1)
        almsetcolor(bstrt, strtcan)
    End Sub

    Private Sub blunch_Click(sender As Object, e As EventArgs) Handles blunch.Click
        My.Settings.h2 = th2.Text
        My.Settings.m2 = tm2.Text
        My.Settings.s2 = ts2.Text
        My.Settings.lunchset = 1
        My.Settings.Save()
        autofil(th2, tm2, ts2)
        almsetcolor(blunch, lunchcan)
    End Sub

    Private Sub bover_Click(sender As Object, e As EventArgs) Handles bover.Click
        My.Settings.h3 = th3.Text
        My.Settings.m3 = tm3.Text
        My.Settings.s3 = ts3.Text
        My.Settings.overset = 1
        My.Settings.Save()
        autofil(th3, tm3, ts3)
        almsetcolor(bover, overcan)
    End Sub


    Private Sub strtcan_Click(sender As Object, e As EventArgs) Handles strtcan.Click
        My.Settings.h1 = "00"
        My.Settings.m1 = "00"
        My.Settings.s1 = "00"
        My.Settings.strtset = 0
        My.Settings.Save()

        clear(th1, tm1, ts1)
        cancl(My.Settings.strtset, bstrt, strtcan)
        mainframe.schooltime = 0

    End Sub

    Private Sub lunchcan_Click(sender As Object, e As EventArgs) Handles lunchcan.Click
        My.Settings.h2 = "00"
        My.Settings.m2 = "00"
        My.Settings.s2 = "00"
        My.Settings.lunchset = 0
        My.Settings.Save()

        clear(th2, tm2, ts2)
        cancl(My.Settings.lunchset, blunch, lunchcan)
    End Sub

    Private Sub overcan_Click(sender As Object, e As EventArgs) Handles overcan.Click
        My.Settings.h3 = "00"
        My.Settings.m3 = "00"
        My.Settings.s3 = "00"
        My.Settings.overset = 0
        My.Settings.Save()

        clear(th3, tm3, ts3)
        cancl(My.Settings.overset, bover, overcan)
        mainframe.schooltime = 1
    End Sub


    Private Sub tim2_Tick(sender As Object, e As EventArgs) Handles tim2.Tick
        Dim time As String = String.Format("{0:HH:mm:ss}", DateTime.Now)
        ltime.Text = time
    End Sub


    Private Sub donebtn_Click(sender As Object, e As EventArgs) Handles donebtn.Click
        Me.Hide()
    End Sub


End Class