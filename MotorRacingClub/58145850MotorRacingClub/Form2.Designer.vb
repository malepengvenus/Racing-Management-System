<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.BtnMain = New System.Windows.Forms.Button()
        Me.BtnReg = New System.Windows.Forms.Button()
        Me.BtnRes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.EventBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RacingDbDataSet = New _58145850MotorRacingClub.RacingDbDataSet()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxRegFee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxLaps = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LabelEvent = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboEvent = New System.Windows.Forms.ComboBox()
        Me.ComboLoca = New System.Windows.Forms.ComboBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.saveListBox = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.EventTableAdapter = New _58145850MotorRacingClub.RacingDbDataSetTableAdapters.EventTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EventDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RegistrationFeeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocationOfEventDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LapsNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnRemov = New System.Windows.Forms.Button()
        CType(Me.EventBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RacingDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMain
        '
        Me.BtnMain.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnMain.Location = New System.Drawing.Point(12, 320)
        Me.BtnMain.Name = "BtnMain"
        Me.BtnMain.Size = New System.Drawing.Size(75, 35)
        Me.BtnMain.TabIndex = 0
        Me.BtnMain.Text = "Main"
        Me.BtnMain.UseVisualStyleBackColor = False
        '
        'BtnReg
        '
        Me.BtnReg.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnReg.Location = New System.Drawing.Point(103, 324)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(75, 31)
        Me.BtnReg.TabIndex = 1
        Me.BtnReg.Text = "Registration"
        Me.BtnReg.UseVisualStyleBackColor = False
        '
        'BtnRes
        '
        Me.BtnRes.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnRes.Location = New System.Drawing.Point(199, 324)
        Me.BtnRes.Name = "BtnRes"
        Me.BtnRes.Size = New System.Drawing.Size(75, 31)
        Me.BtnRes.TabIndex = 2
        Me.BtnRes.Text = "Results"
        Me.BtnRes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "EVENT TITLE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "DATE OF EVENT"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventBindingSource, "Event Date", True))
        Me.DateTimePicker1.Location = New System.Drawing.Point(136, 108)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'EventBindingSource
        '
        Me.EventBindingSource.DataMember = "Event"
        Me.EventBindingSource.DataSource = Me.RacingDbDataSet
        '
        'RacingDbDataSet
        '
        Me.RacingDbDataSet.DataSetName = "RacingDbDataSet"
        Me.RacingDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "REGISTRATION FEE:"
        '
        'TextBoxRegFee
        '
        Me.TextBoxRegFee.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventBindingSource, "Registration Fee", True))
        Me.TextBoxRegFee.Location = New System.Drawing.Point(136, 154)
        Me.TextBoxRegFee.Name = "TextBoxRegFee"
        Me.TextBoxRegFee.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRegFee.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 209)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "LOCATION OF EVENT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "LAPS NUMBER"
        '
        'TextBoxLaps
        '
        Me.TextBoxLaps.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventBindingSource, "Laps Number", True))
        Me.TextBoxLaps.Location = New System.Drawing.Point(136, 252)
        Me.TextBoxLaps.Name = "TextBoxLaps"
        Me.TextBoxLaps.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxLaps.TabIndex = 12
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnSave.Location = New System.Drawing.Point(406, 324)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(100, 31)
        Me.BtnSave.TabIndex = 13
        Me.BtnSave.Text = "Save info"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnExit.Location = New System.Drawing.Point(512, 324)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 31)
        Me.BtnExit.TabIndex = 14
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'LabelEvent
        '
        Me.LabelEvent.AutoSize = True
        Me.LabelEvent.Location = New System.Drawing.Point(9, 290)
        Me.LabelEvent.Name = "LabelEvent"
        Me.LabelEvent.Size = New System.Drawing.Size(57, 13)
        Me.LabelEvent.TabIndex = 15
        Me.LabelEvent.Text = "ID EVENT"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(946, 24)
        Me.MenuStrip1.TabIndex = 16
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetToolStripMenuItem, Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ResetToolStripMenuItem.Text = "Reset"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem.Text = "Save   CTR+S"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit CTR+X"
        '
        'ComboEvent
        '
        Me.ComboEvent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventBindingSource, "EventTitle", True))
        Me.ComboEvent.FormattingEnabled = True
        Me.ComboEvent.Items.AddRange(New Object() {"Truck Racing", "Rally Cross", "Hot Rods", "Demolition Derby"})
        Me.ComboEvent.Location = New System.Drawing.Point(134, 61)
        Me.ComboEvent.Name = "ComboEvent"
        Me.ComboEvent.Size = New System.Drawing.Size(121, 21)
        Me.ComboEvent.TabIndex = 17
        '
        'ComboLoca
        '
        Me.ComboLoca.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EventBindingSource, "Location Of Event", True))
        Me.ComboLoca.FormattingEnabled = True
        Me.ComboLoca.Items.AddRange(New Object() {"Bochum", "Khapane", "Giyani", "Botlokwa"})
        Me.ComboLoca.Location = New System.Drawing.Point(136, 200)
        Me.ComboLoca.Name = "ComboLoca"
        Me.ComboLoca.Size = New System.Drawing.Size(100, 21)
        Me.ComboLoca.TabIndex = 18
        '
        'saveListBox
        '
        Me.saveListBox.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.saveListBox.Location = New System.Drawing.Point(293, 324)
        Me.saveListBox.Name = "saveListBox"
        Me.saveListBox.Size = New System.Drawing.Size(97, 31)
        Me.saveListBox.TabIndex = 20
        Me.saveListBox.Text = "Save to Listbox"
        Me.saveListBox.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(258, 11)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(159, 13)
        Me.LinkLabel1.TabIndex = 21
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "NEXT EVENT REGISTRATION"
        '
        'EventTableAdapter
        '
        Me.EventTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EventDateDataGridViewTextBoxColumn, Me.RegistrationFeeDataGridViewTextBoxColumn, Me.LocationOfEventDataGridViewTextBoxColumn, Me.LapsNumberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EventBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(277, 61)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(639, 228)
        Me.DataGridView1.TabIndex = 22
        '
        'EventDateDataGridViewTextBoxColumn
        '
        Me.EventDateDataGridViewTextBoxColumn.DataPropertyName = "Event Date"
        Me.EventDateDataGridViewTextBoxColumn.HeaderText = "Event Date"
        Me.EventDateDataGridViewTextBoxColumn.Name = "EventDateDataGridViewTextBoxColumn"
        '
        'RegistrationFeeDataGridViewTextBoxColumn
        '
        Me.RegistrationFeeDataGridViewTextBoxColumn.DataPropertyName = "Registration Fee"
        Me.RegistrationFeeDataGridViewTextBoxColumn.HeaderText = "Registration Fee"
        Me.RegistrationFeeDataGridViewTextBoxColumn.Name = "RegistrationFeeDataGridViewTextBoxColumn"
        '
        'LocationOfEventDataGridViewTextBoxColumn
        '
        Me.LocationOfEventDataGridViewTextBoxColumn.DataPropertyName = "Location Of Event"
        Me.LocationOfEventDataGridViewTextBoxColumn.HeaderText = "Location Of Event"
        Me.LocationOfEventDataGridViewTextBoxColumn.Name = "LocationOfEventDataGridViewTextBoxColumn"
        '
        'LapsNumberDataGridViewTextBoxColumn
        '
        Me.LapsNumberDataGridViewTextBoxColumn.DataPropertyName = "Laps Number"
        Me.LapsNumberDataGridViewTextBoxColumn.HeaderText = "Laps Number"
        Me.LapsNumberDataGridViewTextBoxColumn.Name = "LapsNumberDataGridViewTextBoxColumn"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(430, 374)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 23
        Me.btnAdd.Text = "Add new"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(439, 404)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 24
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnRemov
        '
        Me.btnRemov.Location = New System.Drawing.Point(616, 426)
        Me.btnRemov.Name = "btnRemov"
        Me.btnRemov.Size = New System.Drawing.Size(75, 23)
        Me.btnRemov.TabIndex = 25
        Me.btnRemov.Text = "Remove"
        Me.btnRemov.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 502)
        Me.Controls.Add(Me.btnRemov)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.saveListBox)
        Me.Controls.Add(Me.ComboLoca)
        Me.Controls.Add(Me.ComboEvent)
        Me.Controls.Add(Me.LabelEvent)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TextBoxLaps)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxRegFee)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRes)
        Me.Controls.Add(Me.BtnReg)
        Me.Controls.Add(Me.BtnMain)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "NEXT EVENT"
        CType(Me.EventBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RacingDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMain As System.Windows.Forms.Button
    Friend WithEvents BtnReg As System.Windows.Forms.Button
    Friend WithEvents BtnRes As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBoxRegFee As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBoxLaps As System.Windows.Forms.TextBox
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents LabelEvent As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboEvent As System.Windows.Forms.ComboBox
    Friend WithEvents ComboLoca As System.Windows.Forms.ComboBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents saveListBox As System.Windows.Forms.Button
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents RacingDbDataSet As _58145850MotorRacingClub.RacingDbDataSet
    Friend WithEvents EventBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EventTableAdapter As _58145850MotorRacingClub.RacingDbDataSetTableAdapters.EventTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventTitleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EventDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RegistrationFeeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocationOfEventDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LapsNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnRemov As System.Windows.Forms.Button
End Class
