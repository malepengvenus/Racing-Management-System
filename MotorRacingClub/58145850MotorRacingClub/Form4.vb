Imports System.IO
Public Class Form4



    Private Sub BtnMain_Click(sender As Object, e As EventArgs) Handles BtnMain.Click
        Me.Hide()
        Form1.Visible = True
    End Sub

    Private Sub BtnEvent_Click(sender As Object, e As EventArgs) Handles BtnEvent.Click
        Me.Hide()
        Form2.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form3.Visible = True
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim messager As String = "Are you sure you want to Exit " & "?"
        Dim button As DialogResult = MessageBox.Show(messager,
            "Confirm Delete", MessageBoxButtons.YesNo)
        If button = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

   




  
   


   
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class


