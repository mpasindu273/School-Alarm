Public Class Alarm_settings

    Dim showtext As Integer
    Dim exceptstrt As Integer
    Dim exceptdur As Integer

    Private Sub Alarm_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        If My.Settings.durationset Then
            bdur.BackColor = Color.Magenta
            bdur.ForeColor = Color.White
        Else
            bdur.BackColor = DefaultBackColor()
            bdur.ForeColor = Color.Black
        End If


        tstartingtheme.Text = My.Settings.startname
        tlunchtheme.Text = My.Settings.lunchname
        tendingtheme.Text = My.Settings.endname
        tperiodtheme.Text = My.Settings.periodname

        showtext = My.Settings.period
        tperiod.Text = Str(showtext)
    End Sub

    Function autofil(th1 As TextBox) As Integer
        If th1.Text.Length = 1 Then
            th1.Text = "0" + th1.Text()
        End If
        Return 0
    End Function


    Private Sub browsestart_Click(sender As Object, e As EventArgs) Handles browsestart.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.starttheme = OpenFileDialog1.FileName
            My.Settings.startname = OpenFileDialog1.SafeFileName
            tstartingtheme.Text = My.Settings.startname
            My.Settings.Save()

        End If
    End Sub

    Private Sub browselunch_Click(sender As Object, e As EventArgs) Handles browselunch.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.lunchtheme = OpenFileDialog1.FileName
            My.Settings.lunchname = OpenFileDialog1.SafeFileName
            tlunchtheme.Text = My.Settings.lunchname
            My.Settings.Save()
        End If
    End Sub

    Private Sub browseend_Click(sender As Object, e As EventArgs) Handles browseend.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.endtheme = OpenFileDialog1.FileName
            My.Settings.endname = OpenFileDialog1.SafeFileName
            tendingtheme.Text = My.Settings.endname
            My.Settings.Save()
        End If
    End Sub

    Private Sub browseperiod_Click(sender As Object, e As EventArgs) Handles browseperiod.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Settings.periodtheme = OpenFileDialog1.FileName
            My.Settings.periodname = OpenFileDialog1.SafeFileName
            tperiodtheme.Text = My.Settings.periodname
            My.Settings.Save()
        End If
    End Sub



    Private Sub bdur_Click(sender As Object, e As EventArgs) Handles bdur.Click
        Try
            autofil(tperiod)
            My.Settings.period = Integer.Parse(tperiod.Text)
            My.Settings.Save()
            exceptdur = 0
        Catch
            MsgBox("Invalid input!", MessageBoxIcon.Exclamation)
            exceptdur = 1
        End Try

        If exceptdur <> 1 Then
            bdur.BackColor = Color.Magenta
            bdur.ForeColor = Color.White
            My.Settings.durationset = 1
            My.Settings.Save()
        End If
    End Sub


    Private Sub tperiod_Click(sender As Object, e As EventArgs) Handles tperiod.Click
        tperiod.Text = ""
        My.Settings.durationset = 0
        My.Settings.period = 0
        My.Settings.Save()
        bdur.BackColor = DefaultBackColor()
        bdur.ForeColor = Color.Black
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        MsgBox("Enter the length of a period. Period bell will sound at the end of periods." + vbCrLf + "If not set, period bell will sound every 40 minutes")
    End Sub


    Private Sub bck_Click(sender As Object, e As EventArgs)
        Me.Hide()
    End Sub


   
End Class