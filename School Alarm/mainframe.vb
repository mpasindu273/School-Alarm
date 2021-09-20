Public Class mainframe

    Dim s As Integer
    Dim m As Integer
    Dim h As Integer
    Dim sec As String
    Dim min As String
    Dim hour As String
    Dim tdate As String
    Public soundon As Integer
    Public schooltime, lunchtime As Integer
    Public secondstobell As Integer
    Public customtime As Integer

    Function alarmsound() As Integer


        If My.Settings.strtset Then

            If alarm.th1.Text = hour And alarm.tm1.Text = min And alarm.ts1.Text = sec Then
                secondstobell = 0
                schooltime = 1
                My.Settings.Save()

                Try
                    My.Computer.Audio.Play(My.Settings.starttheme, AudioPlayMode.Background)
                Catch
                    My.Computer.Audio.Play(My.Resources.Better, AudioPlayMode.Background)
                End Try

            End If
        End If


        If My.Settings.lunchset Then
            If alarm.th2.Text = hour And alarm.tm2.Text = min And alarm.ts2.Text = sec Then
                lunchtime = 1

                Try
                    My.Computer.Audio.Play(My.Settings.lunchtheme, AudioPlayMode.Background)
                Catch
                    My.Computer.Audio.Play(My.Resources.Nightwish, AudioPlayMode.Background)
                End Try

            End If
        End If


        If My.Settings.overset Then
            If alarm.th3.Text = hour And alarm.tm3.Text = min And alarm.ts3.Text = sec Then
                schooltime = 0

                Try
                    My.Computer.Audio.Play(My.Settings.endtheme, AudioPlayMode.Background)
                Catch
                    My.Computer.Audio.Play(My.Resources.ring, AudioPlayMode.Background)
                End Try

            End If
        End If
        Return 0
    End Function


    Function periodbell() As Integer

        If schooltime Then
            If lunchtime Then
                If secondstobell = 40 * 60 Then

                    Try
                        My.Computer.Audio.Play(My.Settings.periodtheme, AudioPlayMode.Background)
                    Catch
                        My.Computer.Audio.Play(My.Resources.Nightwish, AudioPlayMode.Background)
                    End Try

                    secondstobell = 0
                    lunchtime = 0
                End If

            ElseIf My.Settings.durationset Then
                If secondstobell = My.Settings.period * 60 Then

                    Try
                        My.Computer.Audio.Play(My.Settings.periodtheme, AudioPlayMode.Background)
                    Catch
                        My.Computer.Audio.Play(My.Resources.Better, AudioPlayMode.Background)
                    End Try

                    secondstobell = 0
                End If
            End If

        End If

        secondstobell += 1
        Return 0
    End Function


    Private Sub Tim_Tick(sender As Object, e As EventArgs) Handles Tim.Tick

        s = DateTime.Now.TimeOfDay.Seconds
        m = DateTime.Now.TimeOfDay.Minutes
        h = DateTime.Now.TimeOfDay.Hours

        tdate = String.Format("{0:dd/MM/yyyy}", DateTime.Now)

        ldate.Text = tdate

        sec = String.Format("{0:0#}", s)
        min = String.Format("{0:0#}", m)
        hour = String.Format("{0:0#}", h)

        ls.Text = sec
        lm.Text = min
        lh.Text = hour

        alarmsound()
        periodbell()
    End Sub



    Private Sub balarm_Click(sender As Object, e As EventArgs) Handles balarm.Click
        alarm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Alarm_settings.Show()
    End Sub

    Private Sub mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class