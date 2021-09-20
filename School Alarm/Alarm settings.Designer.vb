<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alarm_settings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.browsestart = New System.Windows.Forms.Button()
        Me.browselunch = New System.Windows.Forms.Button()
        Me.browseend = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.bdur = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tstartingtheme = New System.Windows.Forms.TextBox()
        Me.tendingtheme = New System.Windows.Forms.TextBox()
        Me.tlunchtheme = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tperiodtheme = New System.Windows.Forms.TextBox()
        Me.browseperiod = New System.Windows.Forms.Button()
        Me.tperiod = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(63, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "School Start Theme"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(63, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(238, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lunch Time Theme"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(63, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(236, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "School End Theme"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(63, 445)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(196, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Period Duration"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(275, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(293, 46)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alarm Settings"
        '
        'browsestart
        '
        Me.browsestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browsestart.Location = New System.Drawing.Point(617, 121)
        Me.browsestart.Name = "browsestart"
        Me.browsestart.Size = New System.Drawing.Size(99, 34)
        Me.browsestart.TabIndex = 5
        Me.browsestart.Text = "Browse"
        Me.browsestart.UseVisualStyleBackColor = True
        '
        'browselunch
        '
        Me.browselunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browselunch.Location = New System.Drawing.Point(617, 180)
        Me.browselunch.Name = "browselunch"
        Me.browselunch.Size = New System.Drawing.Size(99, 34)
        Me.browselunch.TabIndex = 6
        Me.browselunch.Text = "Browse"
        Me.browselunch.UseVisualStyleBackColor = True
        '
        'browseend
        '
        Me.browseend.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browseend.Location = New System.Drawing.Point(617, 243)
        Me.browseend.Name = "browseend"
        Me.browseend.Size = New System.Drawing.Size(99, 34)
        Me.browseend.TabIndex = 7
        Me.browseend.Text = "Browse"
        Me.browseend.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(318, 419)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "min"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(794, 518)
        Me.ShapeContainer1.TabIndex = 13
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape2.BorderWidth = 2
        Me.RectangleShape2.Location = New System.Drawing.Point(-3, 518)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(799, 4)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderColor = System.Drawing.SystemColors.ControlLightLight
        Me.RectangleShape1.BorderWidth = 2
        Me.RectangleShape1.Location = New System.Drawing.Point(-5, 396)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(799, 4)
        '
        'bdur
        '
        Me.bdur.BackColor = System.Drawing.Color.Magenta
        Me.bdur.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bdur.ForeColor = System.Drawing.Color.White
        Me.bdur.Location = New System.Drawing.Point(617, 447)
        Me.bdur.Name = "bdur"
        Me.bdur.Size = New System.Drawing.Size(99, 34)
        Me.bdur.TabIndex = 9
        Me.bdur.Text = "Set"
        Me.bdur.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.School_Alarm.My.Resources.Resources.Question_mark
        Me.PictureBox1.Location = New System.Drawing.Point(12, 441)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tstartingtheme
        '
        Me.tstartingtheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tstartingtheme.Location = New System.Drawing.Point(310, 126)
        Me.tstartingtheme.Name = "tstartingtheme"
        Me.tstartingtheme.ReadOnly = True
        Me.tstartingtheme.Size = New System.Drawing.Size(276, 27)
        Me.tstartingtheme.TabIndex = 28
        Me.tstartingtheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tendingtheme
        '
        Me.tendingtheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tendingtheme.Location = New System.Drawing.Point(310, 243)
        Me.tendingtheme.Name = "tendingtheme"
        Me.tendingtheme.ReadOnly = True
        Me.tendingtheme.Size = New System.Drawing.Size(276, 27)
        Me.tendingtheme.TabIndex = 29
        Me.tendingtheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tlunchtheme
        '
        Me.tlunchtheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tlunchtheme.Location = New System.Drawing.Point(310, 184)
        Me.tlunchtheme.Name = "tlunchtheme"
        Me.tlunchtheme.ReadOnly = True
        Me.tlunchtheme.Size = New System.Drawing.Size(276, 27)
        Me.tlunchtheme.TabIndex = 30
        Me.tlunchtheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(63, 304)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(233, 29)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Period End Theme"
        '
        'tperiodtheme
        '
        Me.tperiodtheme.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tperiodtheme.Location = New System.Drawing.Point(310, 307)
        Me.tperiodtheme.Name = "tperiodtheme"
        Me.tperiodtheme.ReadOnly = True
        Me.tperiodtheme.Size = New System.Drawing.Size(276, 27)
        Me.tperiodtheme.TabIndex = 33
        Me.tperiodtheme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'browseperiod
        '
        Me.browseperiod.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browseperiod.Location = New System.Drawing.Point(617, 303)
        Me.browseperiod.Name = "browseperiod"
        Me.browseperiod.Size = New System.Drawing.Size(99, 34)
        Me.browseperiod.TabIndex = 32
        Me.browseperiod.Text = "Browse"
        Me.browseperiod.UseVisualStyleBackColor = True
        '
        'tperiod
        '
        Me.tperiod.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tperiod.Location = New System.Drawing.Point(310, 447)
        Me.tperiod.MaxLength = 3
        Me.tperiod.Name = "tperiod"
        Me.tperiod.Size = New System.Drawing.Size(63, 39)
        Me.tperiod.TabIndex = 35
        Me.tperiod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(306, 358)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(283, 20)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "*** Please only select .wav files ***"
        '
        'Alarm_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(794, 518)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tperiod)
        Me.Controls.Add(Me.tperiodtheme)
        Me.Controls.Add(Me.browseperiod)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.tlunchtheme)
        Me.Controls.Add(Me.tendingtheme)
        Me.Controls.Add(Me.tstartingtheme)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.bdur)
        Me.Controls.Add(Me.browseend)
        Me.Controls.Add(Me.browselunch)
        Me.Controls.Add(Me.browsestart)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Alarm_settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarm_settings"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents browsestart As System.Windows.Forms.Button
    Friend WithEvents browselunch As System.Windows.Forms.Button
    Friend WithEvents browseend As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents bdur As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tstartingtheme As System.Windows.Forms.TextBox
    Friend WithEvents tendingtheme As System.Windows.Forms.TextBox
    Friend WithEvents tlunchtheme As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tperiodtheme As System.Windows.Forms.TextBox
    Friend WithEvents browseperiod As System.Windows.Forms.Button
    Friend WithEvents tperiod As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
