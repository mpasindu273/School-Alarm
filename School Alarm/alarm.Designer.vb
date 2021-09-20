<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alarm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.th1 = New System.Windows.Forms.TextBox()
        Me.tm1 = New System.Windows.Forms.TextBox()
        Me.ts1 = New System.Windows.Forms.TextBox()
        Me.th2 = New System.Windows.Forms.TextBox()
        Me.tm2 = New System.Windows.Forms.TextBox()
        Me.ts2 = New System.Windows.Forms.TextBox()
        Me.ts3 = New System.Windows.Forms.TextBox()
        Me.tm3 = New System.Windows.Forms.TextBox()
        Me.th3 = New System.Windows.Forms.TextBox()
        Me.ltime = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bstrt = New System.Windows.Forms.Button()
        Me.strtcan = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.blunch = New System.Windows.Forms.Button()
        Me.lunchcan = New System.Windows.Forms.Button()
        Me.overcan = New System.Windows.Forms.Button()
        Me.bover = New System.Windows.Forms.Button()
        Me.tim2 = New System.Windows.Forms.Timer(Me.components)
        Me.donebtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(3, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(255, 45)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "School start :"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(784, 481)
        Me.ShapeContainer1.TabIndex = 2
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.BorderWidth = 8
        Me.RectangleShape3.Location = New System.Drawing.Point(-11, 359)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(807, 118)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BorderWidth = 5
        Me.RectangleShape2.Location = New System.Drawing.Point(-13, 232)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(807, 118)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.BorderWidth = 8
        Me.RectangleShape1.Location = New System.Drawing.Point(-10, 107)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(807, 118)
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 8
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 608
        Me.LineShape2.X2 = 609
        Me.LineShape2.Y1 = -8
        Me.LineShape2.Y2 = 486
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 8
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 278
        Me.LineShape1.X2 = 278
        Me.LineShape1.Y1 = -10
        Me.LineShape1.Y2 = 490
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(3, 268)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(244, 45)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Lunch Time :"
        '
        'th1
        '
        Me.th1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.th1.Location = New System.Drawing.Point(326, 144)
        Me.th1.MaxLength = 2
        Me.th1.Name = "th1"
        Me.th1.Size = New System.Drawing.Size(53, 47)
        Me.th1.TabIndex = 4
        Me.th1.Text = "00"
        Me.th1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tm1
        '
        Me.tm1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tm1.Location = New System.Drawing.Point(420, 144)
        Me.tm1.MaxLength = 2
        Me.tm1.Name = "tm1"
        Me.tm1.Size = New System.Drawing.Size(53, 47)
        Me.tm1.TabIndex = 5
        Me.tm1.Text = "00"
        Me.tm1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ts1
        '
        Me.ts1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts1.Location = New System.Drawing.Point(515, 144)
        Me.ts1.MaxLength = 2
        Me.ts1.Name = "ts1"
        Me.ts1.Size = New System.Drawing.Size(53, 47)
        Me.ts1.TabIndex = 6
        Me.ts1.Text = "00"
        Me.ts1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'th2
        '
        Me.th2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.th2.Location = New System.Drawing.Point(325, 267)
        Me.th2.MaxLength = 2
        Me.th2.Name = "th2"
        Me.th2.Size = New System.Drawing.Size(53, 47)
        Me.th2.TabIndex = 7
        Me.th2.Text = "00"
        Me.th2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tm2
        '
        Me.tm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tm2.Location = New System.Drawing.Point(420, 267)
        Me.tm2.MaxLength = 2
        Me.tm2.Name = "tm2"
        Me.tm2.Size = New System.Drawing.Size(53, 47)
        Me.tm2.TabIndex = 8
        Me.tm2.Text = "00"
        Me.tm2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ts2
        '
        Me.ts2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts2.Location = New System.Drawing.Point(515, 267)
        Me.ts2.MaxLength = 2
        Me.ts2.Name = "ts2"
        Me.ts2.Size = New System.Drawing.Size(53, 47)
        Me.ts2.TabIndex = 9
        Me.ts2.Text = "00"
        Me.ts2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ts3
        '
        Me.ts3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ts3.Location = New System.Drawing.Point(515, 390)
        Me.ts3.MaxLength = 2
        Me.ts3.Name = "ts3"
        Me.ts3.Size = New System.Drawing.Size(53, 47)
        Me.ts3.TabIndex = 10
        Me.ts3.Text = "00"
        Me.ts3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tm3
        '
        Me.tm3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tm3.Location = New System.Drawing.Point(420, 390)
        Me.tm3.MaxLength = 2
        Me.tm3.Name = "tm3"
        Me.tm3.Size = New System.Drawing.Size(53, 47)
        Me.tm3.TabIndex = 11
        Me.tm3.Text = "00"
        Me.tm3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'th3
        '
        Me.th3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.th3.Location = New System.Drawing.Point(325, 390)
        Me.th3.MaxLength = 2
        Me.th3.Name = "th3"
        Me.th3.Size = New System.Drawing.Size(53, 47)
        Me.th3.TabIndex = 12
        Me.th3.Text = "00"
        Me.th3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ltime
        '
        Me.ltime.AutoSize = True
        Me.ltime.Font = New System.Drawing.Font("Bookman Old Style", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ltime.Location = New System.Drawing.Point(337, 9)
        Me.ltime.Name = "ltime"
        Me.ltime.Size = New System.Drawing.Size(215, 41)
        Me.ltime.TabIndex = 13
        Me.ltime.Text = "Enter time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(319, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 34)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = " hh       mm      ss"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(388, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 39)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(3, 391)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(235, 45)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "School End :"
        '
        'bstrt
        '
        Me.bstrt.BackColor = System.Drawing.SystemColors.ControlText
        Me.bstrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bstrt.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bstrt.Location = New System.Drawing.Point(654, 123)
        Me.bstrt.Name = "bstrt"
        Me.bstrt.Size = New System.Drawing.Size(91, 33)
        Me.bstrt.TabIndex = 18
        Me.bstrt.Text = "Set"
        Me.bstrt.UseVisualStyleBackColor = False
        '
        'strtcan
        '
        Me.strtcan.BackColor = System.Drawing.SystemColors.ControlText
        Me.strtcan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strtcan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.strtcan.Location = New System.Drawing.Point(654, 172)
        Me.strtcan.Name = "strtcan"
        Me.strtcan.Size = New System.Drawing.Size(91, 33)
        Me.strtcan.TabIndex = 19
        Me.strtcan.Text = "Clear"
        Me.strtcan.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(483, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 39)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = ":"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(483, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 39)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(387, 396)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 39)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(388, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 39)
        Me.Label14.TabIndex = 25
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(483, 273)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(26, 39)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = ":"
        '
        'blunch
        '
        Me.blunch.BackColor = System.Drawing.SystemColors.ControlText
        Me.blunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blunch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.blunch.Location = New System.Drawing.Point(654, 249)
        Me.blunch.Name = "blunch"
        Me.blunch.Size = New System.Drawing.Size(91, 33)
        Me.blunch.TabIndex = 18
        Me.blunch.Text = "Set"
        Me.blunch.UseVisualStyleBackColor = False
        '
        'lunchcan
        '
        Me.lunchcan.BackColor = System.Drawing.SystemColors.ControlText
        Me.lunchcan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lunchcan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lunchcan.Location = New System.Drawing.Point(654, 298)
        Me.lunchcan.Name = "lunchcan"
        Me.lunchcan.Size = New System.Drawing.Size(91, 33)
        Me.lunchcan.TabIndex = 19
        Me.lunchcan.Text = "Clear"
        Me.lunchcan.UseVisualStyleBackColor = False
        '
        'overcan
        '
        Me.overcan.BackColor = System.Drawing.SystemColors.ControlText
        Me.overcan.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.overcan.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.overcan.Location = New System.Drawing.Point(654, 426)
        Me.overcan.Name = "overcan"
        Me.overcan.Size = New System.Drawing.Size(91, 33)
        Me.overcan.TabIndex = 19
        Me.overcan.Text = "Clear"
        Me.overcan.UseVisualStyleBackColor = False
        '
        'bover
        '
        Me.bover.BackColor = System.Drawing.SystemColors.ControlText
        Me.bover.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bover.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.bover.Location = New System.Drawing.Point(654, 377)
        Me.bover.Name = "bover"
        Me.bover.Size = New System.Drawing.Size(91, 33)
        Me.bover.TabIndex = 18
        Me.bover.Text = "Set"
        Me.bover.UseVisualStyleBackColor = False
        '
        'tim2
        '
        Me.tim2.Enabled = True
        Me.tim2.Interval = 1000
        '
        'donebtn
        '
        Me.donebtn.BackColor = System.Drawing.Color.MediumOrchid
        Me.donebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.donebtn.Font = New System.Drawing.Font("Bookman Old Style", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.donebtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.donebtn.Location = New System.Drawing.Point(614, -8)
        Me.donebtn.Name = "donebtn"
        Me.donebtn.Size = New System.Drawing.Size(170, 111)
        Me.donebtn.TabIndex = 27
        Me.donebtn.Text = "done !"
        Me.donebtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InfoText
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 63.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(-16, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 96)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alarm"
        '
        'alarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(784, 481)
        Me.Controls.Add(Me.donebtn)
        Me.Controls.Add(Me.bover)
        Me.Controls.Add(Me.overcan)
        Me.Controls.Add(Me.blunch)
        Me.Controls.Add(Me.lunchcan)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.strtcan)
        Me.Controls.Add(Me.bstrt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ltime)
        Me.Controls.Add(Me.th3)
        Me.Controls.Add(Me.tm3)
        Me.Controls.Add(Me.ts3)
        Me.Controls.Add(Me.ts2)
        Me.Controls.Add(Me.tm2)
        Me.Controls.Add(Me.th2)
        Me.Controls.Add(Me.ts1)
        Me.Controls.Add(Me.tm1)
        Me.Controls.Add(Me.th1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "alarm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "alarm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents th1 As System.Windows.Forms.TextBox
    Friend WithEvents tm1 As System.Windows.Forms.TextBox
    Friend WithEvents ts1 As System.Windows.Forms.TextBox
    Friend WithEvents th2 As System.Windows.Forms.TextBox
    Friend WithEvents tm2 As System.Windows.Forms.TextBox
    Friend WithEvents ts2 As System.Windows.Forms.TextBox
    Friend WithEvents ts3 As System.Windows.Forms.TextBox
    Friend WithEvents tm3 As System.Windows.Forms.TextBox
    Friend WithEvents th3 As System.Windows.Forms.TextBox
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents ltime As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents bstrt As System.Windows.Forms.Button
    Friend WithEvents strtcan As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents blunch As System.Windows.Forms.Button
    Friend WithEvents lunchcan As System.Windows.Forms.Button
    Friend WithEvents overcan As System.Windows.Forms.Button
    Friend WithEvents bover As System.Windows.Forms.Button
    Friend WithEvents tim2 As System.Windows.Forms.Timer
    Friend WithEvents donebtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
