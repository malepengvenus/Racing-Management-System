Imports System.IO
Public Class Form3
    'Declaring 


    Public dat As Date
    Public MemburshipNumber As String
    Public x As Integer = num
    Public num As Integer = 26810

    'Public date2 = String.Format("{0:yymmdd}", DateTime.Now)
    Private Sub BtnMain_Click(sender As Object, e As EventArgs) Handles BtnMain.Click
        Me.Hide()
        Form1.Visible = True
    End Sub

    Private Sub BtnEvent_Click(sender As Object, e As EventArgs) Handles BtnEvent.Click
        Me.Hide()
        Form2.Visible = True
    End Sub


    Private Sub BtnRes_Click(sender As Object, e As EventArgs) Handles BtnRes.Click
        Me.Hide()
        Form4.Visible = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim messager As String = "Are you sure you want to Exit " & "?"
        Dim button As DialogResult = MessageBox.Show(messager,
            "Confirm Delete", MessageBoxButtons.YesNo)
        If button = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        If MessageBox.Show("Do you really want to clear All your fields?", "Clear Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            With Me
                .Membership.Clear()
                .TextBoxNameSur.Clear()
                .TextBoxFee.Clear()
                DateTimePickerBirth.ResetText()
                DateTimePicker2.ResetText()
                Race.ResetText()
                .TextboxPos.Clear()




            End With
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Dim Gender As String
        If RadioButtonMale.Checked Then
            Gender = "Male"

        ElseIf RadioButton2.Checked Then
            Gender = "Female"
        End If



        If TextBoxNameSur.Text = "" Then
            MsgBox("Please your Enter Name ")
        ElseIf Surn.Text = "" Then
            MsgBox("Please Enter your Surname")
        ElseIf DateTimePickerBirth.Text = "" Then
            MsgBox("Please Enter your Born Date")
        ElseIf DateTimePicker2.Text = "" Then
            MsgBox("Enter your Joining Date ")
        ElseIf TextBoxFee.Text = "" Then
            MsgBox("Enter your outstanding Fee")
        ElseIf Race.Text = "" Then
            MsgBox("Enter your Position Achieved")




        ElseIf TextboxPos.Text = "" Then
            MsgBox("Please Enter Position You Achieved")
        Else
            Try
                Throw New Exception("Make Sure Membership Number Is Generated")
            Catch ex As Exception


           
                MessageBox.Show("Now You Are Saving Driver Info", "Caution!!!!", MessageBoxButtons.OK, MessageBoxIcon.Question)

             

                MsgBox("Race Driver Is Succesfully Registered")



            End Try
        End If

    End Sub


    Private Sub ButnGenerate_Click(sender As Object, e As EventArgs) Handles ButnGenerate.Click
        dat = DateTimePickerBirth.Value.Date.ToString
        x += 1
        While (x > 0)
            MemburshipNumber += (x Mod 10)
            x /= 10
        End While

        MemburshipNumber = 10 - (MemburshipNumber Mod 8)
        MemburshipNumber = CInt(num.ToString & MemburshipNumber.ToString)
        num += 1

        MessageBox.Show("Memeber ship number has been generated", "press Ok", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Me.Membership.Text = dat & MemburshipNumber
        Membership.Visible = True







    End Sub

    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.ControlKey = 17 Then
            MsgBox("You saved")


        End If
    End Sub

   

   
    Private Sub SaveListB_Click(sender As Object, e As EventArgs) Handles SaveListB.Click
       
    End Sub

    
    Private Sub Remove_Click(sender As Object, e As EventArgs) Handles Remove.Click
       


      
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        Dim Gender As String
        If RadioButtonMale.Checked Then
            Gender = "Male"

        ElseIf RadioButton2.Checked Then
            Gender = "Female"
        End If



        If TextBoxNameSur.Text = "" Then
            MsgBox("Please your Enter Name ")
        ElseIf Surn.Text = "" Then
            MsgBox("Please Enter your Surname")
        ElseIf DateTimePickerBirth.Text = "" Then
            MsgBox("Please Enter your Born Date")
        ElseIf DateTimePicker2.Text = "" Then
            MsgBox("Enter your Joining Date ")
        ElseIf TextBoxFee.Text = "" Then
            MsgBox("Enter your outstanding Fee")
        ElseIf Race.Text = "" Then
            MsgBox("Enter your Position Achieved")




        ElseIf TextboxPos.Text = "" Then
            MsgBox("Please Enter Position You Achieved")
        Else
            Try
                Throw New Exception("Make Sure Membership Number Is Generated")
            Catch ex As Exception



                MessageBox.Show("Now You Are Saving Driver Info", "Caution!!!!", MessageBoxButtons.OK, MessageBoxIcon.Question)

               


                MsgBox("Race Driver Is Succesfully Registered")



            End Try
        End If
    End Sub

   
End Class