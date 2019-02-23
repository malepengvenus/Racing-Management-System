<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.BtnEvent = New System.Windows.Forms.Button()
        Me.BtnRes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxNameSur = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerBirth = New System.Windows.Forms.DateTimePicker()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.LabelComp = New System.Windows.Forms.Label()
        Me.Race = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextboxPos = New System.Windows.Forms.TextBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Membership = New System.Windows.Forms.TextBox()
        Me.ButnGenerate = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Surn = New System.Windows.Forms.TextBox()
        Me.SaveListB = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Remove = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.removeId = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RacingDbDataSet = New _58145850MotorRacingClub.RacingDbDataSet()
        Me.RacingDbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DriverRegistrationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.RacingDbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RacingDbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriverRegistrationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnMain
        '
        Me.BtnMain.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnMain.Location = New System.Drawing.Point(9, 386)
        Me.BtnMain.Name = "BtnMain"
        Me.BtnMain.Size = New System.Drawing.Size(75, 33)
        Me.BtnMain.TabIndex = 0
        Me.BtnMain.Text = "Main"
        Me.BtnMain.UseVisualStyleBackColor = False
        '
        'BtnEvent
        '
        Me.BtnEvent.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnEvent.Location = New System.Drawing.Point(101, 386)
        Me.BtnEvent.Name = "BtnEvent"
        Me.BtnEvent.Size = New System.Drawing.Size(75, 33)
        Me.BtnEvent.TabIndex = 1
        Me.BtnEvent.Text = "Next Event"
        Me.BtnEvent.UseVisualStyleBackColor = False
        '
        'BtnRes
        '
        Me.BtnRes.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BtnRes.Location = New System.Drawing.Point(182, 386)
        Me.BtnRes.Name = "BtnRes"
        Me.BtnRes.Size = New System.Drawing.Size(75, 33)
        Me.BtnRes.TabIndex = 2
        Me.BtnRes.Text = "Results"
        Me.BtnRes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "DUE FEE:"
        '
        'TextBoxFee
        '
        Me.TextBoxFee.Location = New System.Drawing.Point(147, 240)
        Me.TextBoxFee.Name = "TextBoxFee"
        Me.TextBoxFee.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxFee.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "NAME:"
        '
        'TextBoxNameSur
        '
        Me.TextBoxNameSur.Location = New System.Drawing.Point(147, 65)
        Me.TextBoxNameSur.Name = "TextBoxNameSur"
        Me.TextBoxNameSur.Size = New System.Drawing.Size(200, 20)
        Me.TextBoxNameSur.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "BIRTH DATE:"
        '
        'DateTimePickerBirth
        '
        Me.DateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerBirth.Location = New System.Drawing.Point(147, 126)
        Me.DateTimePickerBirth.Name = "DateTimePickerBirth"
        Me.DateTimePickerBirth.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerBirth.TabIndex = 8
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.BtnExit.Location = New System.Drawing.Point(643, 386)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 33)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "GENDER:"
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Location = New System.Drawing.Point(147, 163)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonMale.TabIndex = 11
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(209, 163)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(59, 17)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Female"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "DATE JOINED:"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(147, 201)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 14
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BtnSave.Location = New System.Drawing.Point(372, 386)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(92, 33)
        Me.BtnSave.TabIndex = 15
        Me.BtnSave.Text = "Save Reg Info"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'LabelComp
        '
        Me.LabelComp.AutoSize = True
        Me.LabelComp.Location = New System.Drawing.Point(6, 290)
        Me.LabelComp.Name = "LabelComp"
        Me.LabelComp.Size = New System.Drawing.Size(115, 13)
        Me.LabelComp.TabIndex = 16
        Me.LabelComp.Text = "RACES COMPLETED:"
        '
        'Race
        '
        Me.Race.FormattingEnabled = True
        Me.Race.Location = New System.Drawing.Point(147, 286)
        Me.Race.Name = "Race"
        Me.Race.Size = New System.Drawing.Size(200, 21)
        Me.Race.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 320)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "POSITION ACHIEVED:"
        '
        'TextboxPos
        '
        Me.TextboxPos.Location = New System.Drawing.Point(147, 313)
        Me.TextboxPos.Name = "TextboxPos"
        Me.TextboxPos.Size = New System.Drawing.Size(200, 20)
        Me.TextboxPos.TabIndex = 20
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnClear.Location = New System.Drawing.Point(562, 386)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 33)
        Me.BtnClear.TabIndex = 21
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Registration"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "MEMEBRSHIP  NUMBER"
        '
        'Membership
        '
        Me.Membership.Location = New System.Drawing.Point(147, 29)
        Me.Membership.Name = "Membership"
        Me.Membership.Size = New System.Drawing.Size(200, 20)
        Me.Membership.TabIndex = 24
        '
        'ButnGenerate
        '
        Me.ButnGenerate.BackColor = System.Drawing.Color.CadetBlue
        Me.ButnGenerate.Location = New System.Drawing.Point(481, 386)
        Me.ButnGenerate.Name = "ButnGenerate"
        Me.ButnGenerate.Size = New System.Drawing.Size(75, 33)
        Me.ButnGenerate.TabIndex = 25
        Me.ButnGenerate.Text = "Generate"
        Me.ButnGenerate.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 13)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "SURNAME"
        '
        'Surn
        '
        Me.Surn.Location = New System.Drawing.Point(147, 99)
        Me.Surn.Name = "Surn"
        Me.Surn.Size = New System.Drawing.Size(200, 20)
        Me.Surn.TabIndex = 27
        '
        'SaveListB
        '
        Me.SaveListB.Location = New System.Drawing.Point(263, 386)
        Me.SaveListB.Name = "SaveListB"
        Me.SaveListB.Size = New System.Drawing.Size(103, 33)
        Me.SaveListB.TabIndex = 29
        Me.SaveListB.Text = "Save to ListBox"
        Me.SaveListB.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Coral
        Me.LinkLabel1.Location = New System.Drawing.Point(318, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(132, 13)
        Me.LinkLabel1.TabIndex = 30
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "DRIVER REGISTRATION"
        '
        'Remove
        '
        Me.Remove.Location = New System.Drawing.Point(437, 290)
        Me.Remove.Name = "Remove"
        Me.Remove.Size = New System.Drawing.Size(113, 23)
        Me.Remove.TabIndex = 31
        Me.Remove.Text = "Remove Member"
        Me.Remove.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(590, 290)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 23)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Edit Member"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'removeId
        '
        Me.removeId.Location = New System.Drawing.Point(437, 256)
        Me.removeId.Name = "removeId"
        Me.removeId.Size = New System.Drawing.Size(100, 20)
        Me.removeId.TabIndex = 33
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(590, 253)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(428, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "REMOVING MEMEBER"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(716, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 13)
        Me.Label11.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(587, 227)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "EDIT MEMBER"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(745, 290)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 38
        Me.BtnAdd.Text = "Add Member"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(740, 243)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "ADD MEMBER"
        '
        'RacingDbDataSet
        '
        Me.RacingDbDataSet.DataSetName = "RacingDbDataSet"
        Me.RacingDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RacingDbDataSetBindingSource
        '
        Me.RacingDbDataSetBindingSource.DataSource = Me.RacingDbDataSet
        Me.RacingDbDataSetBindingSource.Position = 0
        '
        'DriverRegistrationBindingSource1
        '
        Me.DriverRegistrationBindingSource1.DataMember = "DriverRegistration"
        Me.DriverRegistrationBindingSource1.DataSource = Me.RacingDbDataSetBindingSource
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1015, 431)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.removeId)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Remove)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.SaveListB)
        Me.Controls.Add(Me.Surn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ButnGenerate)
        Me.Controls.Add(Me.Membership)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TextboxPos)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Race)
        Me.Controls.Add(Me.LabelComp)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButtonMale)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.DateTimePickerBirth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNameSur)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxFee)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnRes)
        Me.Controls.Add(Me.BtnEvent)
        Me.Controls.Add(Me.BtnMain)
        Me.Name = "Form3"
        Me.Text = "REGISTRATION"
        CType(Me.RacingDbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RacingDbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriverRegistrationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMain As System.Windows.Forms.Button
    Friend WithEvents BtnEvent As System.Windows.Forms.Button
    Friend WithEvents BtnRes As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBoxFee As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBoxNameSur As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerBirth As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButtonMale As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents LabelComp As System.Windows.Forms.Label
    Friend WithEvents Race As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextboxPos As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Membership As System.Windows.Forms.TextBox
    Friend WithEvents ButnGenerate As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Surn As System.Windows.Forms.TextBox
    Friend WithEvents SaveListB As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Remove As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents removeId As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents RacingDbDataSet As _58145850MotorRacingClub.RacingDbDataSet
    Friend WithEvents DriverRegistrationBindingSource As System.Windows.Forms.BindingSource

    Friend WithEvents RacingDbDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DriverRegistrationBindingSource1 As System.Windows.Forms.BindingSource
End Class
