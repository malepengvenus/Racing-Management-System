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
End Class
