<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnEvent = New System.Windows.Forms.Button()
        Me.BtnReg = New System.Windows.Forms.Button()
        Me.BtnRes = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TmRace = New System.Windows.Forms.Timer(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.finish = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Car2 = New System.Windows.Forms.PictureBox()
        Me.Car1 = New System.Windows.Forms.PictureBox()
        Me.label = New System.Windows.Forms.Label()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Car1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnEvent
        '
        Me.BtnEvent.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnEvent.ForeColor = System.Drawing.SystemColors.InfoText
        Me.BtnEvent.Location = New System.Drawing.Point(12, 432)
        Me.BtnEvent.Name = "BtnEvent"
        Me.BtnEvent.Size = New System.Drawing.Size(75, 40)
        Me.BtnEvent.TabIndex = 0
        Me.BtnEvent.Text = "Next Event"
        Me.BtnEvent.UseVisualStyleBackColor = False
        '
        'BtnReg
        '
        Me.BtnReg.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnReg.Location = New System.Drawing.Point(93, 432)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(79, 40)
        Me.BtnReg.TabIndex = 1
        Me.BtnReg.Text = "Registration"
        Me.BtnReg.UseVisualStyleBackColor = False
        '
        'BtnRes
        '
        Me.BtnRes.BackColor = System.Drawing.SystemColors.Highlight
        Me.BtnRes.Location = New System.Drawing.Point(178, 432)
        Me.BtnRes.Name = "BtnRes"
        Me.BtnRes.Size = New System.Drawing.Size(81, 40)
        Me.BtnRes.TabIndex = 2
        Me.BtnRes.Text = "Results"
        Me.BtnRes.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnExit.Location = New System.Drawing.Point(265, 434)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 37)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Location = New System.Drawing.Point(3, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 112)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Click To Start Race"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TmRace
        '
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.finish})
        Me.ShapeContainer1.Size = New System.Drawing.Size(724, 478)
        Me.ShapeContainer1.TabIndex = 7
        Me.ShapeContainer1.TabStop = False
        '
        'finish
        '
        Me.finish.BorderWidth = 20
        Me.finish.Name = "finish"
        Me.finish.X1 = 660
        Me.finish.X2 = 660
        Me.finish.Y1 = 237
        Me.finish.Y2 = 403
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global._58145850MotorRacingClub.My.Resources.Resources.imagesrace
        Me.PictureBox3.Location = New System.Drawing.Point(544, 37)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(177, 191)
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global._58145850MotorRacingClub.My.Resources.Resources.enter
        Me.PictureBox2.Location = New System.Drawing.Point(278, 37)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(260, 191)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._58145850MotorRacingClub.My.Resources.Resources.Racing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 194)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Car2
        '
        Me.Car2.Image = Global._58145850MotorRacingClub.My.Resources.Resources.imagesrc
        Me.Car2.Location = New System.Drawing.Point(98, 325)
        Me.Car2.Name = "Car2"
        Me.Car2.Size = New System.Drawing.Size(167, 88)
        Me.Car2.TabIndex = 5
        Me.Car2.TabStop = False
        '
        'Car1
        '
        Me.Car1.Image = Global._58145850MotorRacingClub.My.Resources.Resources.imagesrc
        Me.Car1.Location = New System.Drawing.Point(98, 237)
        Me.Car1.Name = "Car1"
        Me.Car1.Size = New System.Drawing.Size(167, 82)
        Me.Car1.TabIndex = 4
        Me.Car1.TabStop = False
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Fuchsia
        Me.label.Location = New System.Drawing.Point(262, 9)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(198, 13)
        Me.label.TabIndex = 11
        Me.label.Text = "WELCOME TO MOTOR RACING CLUB"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 478)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Car2)
        Me.Controls.Add(Me.Car1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnRes)
        Me.Controls.Add(Me.BtnReg)
        Me.Controls.Add(Me.BtnEvent)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Main Page"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Car1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnEvent As System.Windows.Forms.Button
    Friend WithEvents BtnReg As System.Windows.Forms.Button
    Friend WithEvents BtnRes As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Car1 As System.Windows.Forms.PictureBox
    Friend WithEvents Car2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TmRace As System.Windows.Forms.Timer
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents finish As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents label As System.Windows.Forms.Label

End Class
