Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Result.Clear()
        Result.AppendText(FirstEntry.Text)
    End Sub
    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Result.Clear()
        Result.AppendText(FirstEntry.Text)
        Label1.Text = 0
        Label3.Text = 1
        createBtn.Enabled = True
        statuslbl.Text = ("Idle")
    End Sub
    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        Timer1.Enabled = True
        Timer1.Start()
        createBtn.Enabled = False
        resetBtn.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Label1.Text + 1
        Result.AppendText(Environment.NewLine + base.Text)
    End Sub
    Private Sub Label1_TextChanged(sender As Object, e As EventArgs) Handles Label1.TextChanged
        If Label1.Text = NumericUpDown1.Value Then
            Timer1.Enabled = False
            statuslbl.Text = "Created"
            Timer2.Enabled = True
        End If
    End Sub

    'I start up a second timer for a sec because stuff breaks otherwise
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label3.Text = Label3.Text - 1
    End Sub
    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Label3.TextChanged 'Test Button
        If Label3.Text < 0 Then
            final()
            Timer2.Enabled = False
        End If
    End Sub
    Private Sub Final()
        Result.AppendText(Environment.NewLine + LastEntry.Text)
        Dim fix As String() = Result.Lines
        fix(fix.Length - 4) = "      }"
        Result.Lines = fix
        saveorcopy()
    End Sub

    Private Sub saveorcopy()
        If RadioButton1.Checked = True And
                ComboBox1.Text = ("Halo 3 (12070)") Then
            IO.File.WriteAllText(("game_set_006.json"), Result.Text)
        ElseIf RadioButton1.Checked = True And
            ComboBox1.Text = ("Halo 3 Alpha (06481)") Then
            IO.File.WriteAllText(("game_set_001.json"), Result.Text)
        ElseIf RadioButton1.Checked = True And
            ComboBox1.Text = ("Halo 3 Beta (09699)") Then
            IO.File.WriteAllText(("game_set_003.json"), Result.Text)
        ElseIf RadioButton1.Checked = True And
        ComboBox1.Text = ("Halo 3 Delta (08172)") Then
            IO.File.WriteAllText(("game_set_002.json"), Result.Text)
        Else
            Clipboard.SetText(Result.Text)
        End If

        If CheckBox1.Checked = True Then
            Application.Exit()
        End If
    End Sub
End Class