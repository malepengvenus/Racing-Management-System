Public Class Form1

   

    Private Sub BtnEvent_Click(sender As Object, e As EventArgs) Handles BtnEvent.Click
        Me.Hide()
        Form2.Visible = True

    End Sub

    Private Sub BtnReg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        Me.Hide()
        Form3.Visible = True
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TmRace.Enabled = True
    End Sub

    Private Sub TmRace_Tick(sender As Object, e As EventArgs) Handles TmRace.Tick
        Randomize()

        car1.Left += Rnd() * 6
        car2.Left += Rnd() * 6
        If Car1.Left > 480 Then
            TmRace.Enabled = False
            MsgBox("Car 1 wins")

        End If
        If Car2.Left > 480 Then
            TmRace.Enabled = False
            MsgBox("Car 2 wins")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
