<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainframe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainframe))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lm = New System.Windows.Forms.Label()
        Me.balarm = New System.Windows.Forms.Button()
        Me.ldate = New System.Windows.Forms.Label()
        Me.ls = New System.Windows.Forms.Label()
        Me.lh = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Tim = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lm)
        Me.Panel1.Controls.Add(Me.balarm)
        Me.Panel1.Controls.Add(Me.ldate)
        Me.Panel1.Controls.Add(Me.ls)
        Me.Panel1.Controls.Add(Me.lh)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Name = "Label1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Name = "Label5"
        '
        'lm
        '
        resources.ApplyResources(Me.lm, "lm")
        Me.lm.BackColor = System.Drawing.Color.Transparent
        Me.lm.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lm.Name = "lm"
        '
        'balarm
        '
        Me.balarm.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.balarm, "balarm")
        Me.balarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.balarm.Name = "balarm"
        Me.balarm.UseVisualStyleBackColor = False
        '
        'ldate
        '
        Me.ldate.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.ldate, "ldate")
        Me.ldate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ldate.Name = "ldate"
        '
        'ls
        '
        resources.ApplyResources(Me.ls, "ls")
        Me.ls.BackColor = System.Drawing.Color.Transparent
        Me.ls.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ls.Name = "ls"
        '
        'lh
        '
        resources.ApplyResources(Me.lh, "lh")
        Me.lh.BackColor = System.Drawing.Color.Transparent
        Me.lh.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lh.Name = "lh"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Name = "Label4"
        '
        'ShapeContainer1
        '
        resources.ApplyResources(Me.ShapeContainer1, "ShapeContainer1")
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape2
        '
        resources.ApplyResources(Me.RectangleShape2, "RectangleShape2")
        Me.RectangleShape2.Name = "RectangleShape2"
        '
        'RectangleShape1
        '
        resources.ApplyResources(Me.RectangleShape1, "RectangleShape1")
        Me.RectangleShape1.Name = "RectangleShape1"
        '
        'Tim
        '
        Me.Tim.Enabled = True
        Me.Tim.Interval = 1000
        '
        'mainframe
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Panel1)
        Me.Name = "mainframe"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lm As System.Windows.Forms.Label
    Friend WithEvents balarm As System.Windows.Forms.Button
    Friend WithEvents ldate As System.Windows.Forms.Label
    Friend WithEvents ls As System.Windows.Forms.Label
    Friend WithEvents lh As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Tim As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
