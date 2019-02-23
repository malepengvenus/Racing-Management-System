<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.BtnMain = New System.Windows.Forms.Button()
        Me.BtnEvent = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.InfoResult = New System.Windows.Forms.Button()
        Me.Regst = New System.Windows.Forms.Button()
        Me.IdSearch = New System.Windows.Forms.Label()
        Me.TextBoxSear = New System.Windows.Forms.TextBox()
        Me.Drivr = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.driverNam = New System.Windows.Forms.TextBox()
        Me.evnt = New System.Windows.Forms.TextBox()
        Me.postion = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.loadPrev = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMain
        '
        Me.BtnMain.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnMain.Location = New System.Drawing.Point(12, 474)
        Me.BtnMain.Name = "BtnMain"
        Me.BtnMain.Size = New System.Drawing.Size(75, 32)
        Me.BtnMain.TabIndex = 0
        Me.BtnMain.Text = "Main"
        Me.BtnMain.UseVisualStyleBackColor = False
        '
        'BtnEvent
        '
        Me.BtnEvent.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnEvent.Location = New System.Drawing.Point(93, 474)
        Me.BtnEvent.Name = "BtnEvent"
        Me.BtnEvent.Size = New System.Drawing.Size(75, 32)
        Me.BtnEvent.TabIndex = 1
        Me.BtnEvent.Text = "Next Event"
        Me.BtnEvent.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button3.Location = New System.Drawing.Point(174, 474)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 32)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Registration"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.GrayText
        Me.BtnExit.Location = New System.Drawing.Point(676, 474)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 32)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'InfoResult
        '
        Me.InfoResult.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.InfoResult.Location = New System.Drawing.Point(255, 474)
        Me.InfoResult.Name = "InfoResult"
        Me.InfoResult.Size = New System.Drawing.Size(75, 32)
        Me.InfoResult.TabIndex = 8
        Me.InfoResult.Text = "Results"
        Me.InfoResult.UseVisualStyleBackColor = False
        '
        'Regst
        '
        Me.Regst.BackColor = System.Drawing.Color.IndianRed
        Me.Regst.Location = New System.Drawing.Point(336, 474)
        Me.Regst.Name = "Regst"
        Me.Regst.Size = New System.Drawing.Size(101, 32)
        Me.Regst.TabIndex = 10
        Me.Regst.Text = "Save To ListBox"
        Me.Regst.UseVisualStyleBackColor = False
        '
        'IdSearch
        '
        Me.IdSearch.AutoSize = True
        Me.IdSearch.Location = New System.Drawing.Point(9, 305)
        Me.IdSearch.Name = "IdSearch"
        Me.IdSearch.Size = New System.Drawing.Size(71, 13)
        Me.IdSearch.TabIndex = 11
        Me.IdSearch.Text = "MEMBER_ID"
        '
        'TextBoxSear
        '
        Me.TextBoxSear.Location = New System.Drawing.Point(149, 305)
        Me.TextBoxSear.Name = "TextBoxSear"
        Me.TextBoxSear.Size = New System.Drawing.Size(160, 20)
        Me.TextBoxSear.TabIndex = 12
        '
        'Drivr
        '
        Me.Drivr.AutoSize = True
        Me.Drivr.Location = New System.Drawing.Point(12, 342)
        Me.Drivr.Name = "Drivr"
        Me.Drivr.Size = New System.Drawing.Size(85, 13)
        Me.Drivr.TabIndex = 13
        Me.Drivr.Text = "DRIVER_NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 379)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "EVENT_NAME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 414)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "POSITION OBTAINED"
        '
        'driverNam
        '
        Me.driverNam.Location = New System.Drawing.Point(149, 342)
        Me.driverNam.Name = "driverNam"
        Me.driverNam.Size = New System.Drawing.Size(100, 20)
        Me.driverNam.TabIndex = 16
        '
        'evnt
        '
        Me.evnt.Location = New System.Drawing.Point(149, 379)
        Me.evnt.Name = "evnt"
        Me.evnt.Size = New System.Drawing.Size(100, 20)
        Me.evnt.TabIndex = 17
        '
        'postion
        '
        Me.postion.Location = New System.Drawing.Point(149, 411)
        Me.postion.Name = "postion"
        Me.postion.Size = New System.Drawing.Size(100, 20)
        Me.postion.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Location = New System.Drawing.Point(443, 474)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 32)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Save Results info"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'loadPrev
        '
        Me.loadPrev.BackColor = System.Drawing.Color.IndianRed
        Me.loadPrev.Location = New System.Drawing.Point(564, 474)
        Me.loadPrev.Name = "loadPrev"
        Me.loadPrev.Size = New System.Drawing.Size(106, 32)
        Me.loadPrev.TabIndex = 22
        Me.loadPrev.Text = "Load Previous Info"
        Me.loadPrev.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.LimeGreen
        Me.LinkLabel1.Location = New System.Drawing.Point(324, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(85, 13)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "RESULTS INFO"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 55)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(312, 172)
        Me.DataGridView1.TabIndex = 24
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(347, 55)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(545, 172)
        Me.DataGridView2.TabIndex = 25
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 518)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.loadPrev)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.postion)
        Me.Controls.Add(Me.evnt)
        Me.Controls.Add(Me.driverNam)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Drivr)
        Me.Controls.Add(Me.TextBoxSear)
        Me.Controls.Add(Me.IdSearch)
        Me.Controls.Add(Me.Regst)
        Me.Controls.Add(Me.InfoResult)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnEvent)
        Me.Controls.Add(Me.BtnMain)
        Me.Name = "Form4"
        Me.Text = "RESULTS "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMain As System.Windows.Forms.Button
    Friend WithEvents BtnEvent As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents InfoResult As System.Windows.Forms.Button
    Friend WithEvents Regst As System.Windows.Forms.Button
    Friend WithEvents IdSearch As System.Windows.Forms.Label
    Friend WithEvents TextBoxSear As System.Windows.Forms.TextBox
    Friend WithEvents Drivr As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents driverNam As System.Windows.Forms.TextBox
    Friend WithEvents evnt As System.Windows.Forms.TextBox
    Friend WithEvents postion As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents loadPrev As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
