Imports System.IO
Imports System.Data
Imports System.Data.OleDb




Public Class Form2
    Dim myConn As String = "Provider=Microsoft.jet.OLEDB.4.0; Data source = " + Environment.CurrentDirectory + "\RacingDB.mdb"
    Private Sub BtnMain_Click(sender As Object, e As EventArgs) Handles BtnMain.Click
        Me.Hide()
        Form1.Visible = True
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

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

      

        Try
            Me.Validate()
            EventBindingSource.EndEdit()
            Me.EventTableAdapter.Update(Me.RacingDbDataSet)
            MsgBox("Update successful")

        Catch ex As Exception
            MsgBox("Update failed")
        End Try

        Exit Sub

    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        'clearing the form
        If MessageBox.Show("Do you really want to clear?", "Clear Fields", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            With Me

                .TextBoxLaps.Clear()
                .TextBoxRegFee.Clear()
                ComboEvent.ResetText()

                DateTimePicker1.ResetText()
                TextBoxLaps.Clear()
                ComboLoca.ResetText()



            End With
        End If
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim messager As String = "Are you sure you want to Exit " & "?"
        Dim button As DialogResult = MessageBox.Show(messager,
            "Confirm Delete", MessageBoxButtons.YesNo)
        If button = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboEvent.SelectedIndexChanged
        ComboEvent.Items.Add("Truck Racing")
        ComboEvent.Items.Add("Rally Cross")
        ComboEvent.Items.Add("Hot Cross")
        ComboEvent.Items.Add("Demolition Derby")




    End Sub

   
    Private Sub saveListBox_Click(sender As Object, e As EventArgs) Handles saveListBox.Click
        Dim savefile As String
        savefile = ComboEvent.Text & " , " & DateTimePicker1.Text & " , " & TextBoxRegFee.Text & " , " & ComboLoca.Text & " , " & TextBoxLaps.Text
        'ListBox1.Items.Add(savefile)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RacingDbDataSet._Event' table. You can move, or remove it, as needed.
        Me.EventTableAdapter.Fill(Me.RacingDbDataSet._Event)





    End Sub

    Private Sub conn_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        EventBindingSource.AddNew()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        EventBindingSource.MoveNext()
    End Sub

    Private Sub btnRemov_Click(sender As Object, e As EventArgs) Handles btnRemov.Click
        EventBindingSource.RemoveCurrent()

       
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class