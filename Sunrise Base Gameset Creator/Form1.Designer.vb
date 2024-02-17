<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.FirstEntry = New System.Windows.Forms.RichTextBox()
        Me.LastEntry = New System.Windows.Forms.RichTextBox()
        Me.base = New System.Windows.Forms.RichTextBox()
        Me.Result = New System.Windows.Forms.RichTextBox()
        Me.createBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.statuslbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(105, 56)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {300, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(43, 22)
        Me.NumericUpDown1.TabIndex = 0
        Me.NumericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'FirstEntry
        '
        Me.FirstEntry.Location = New System.Drawing.Point(806, 132)
        Me.FirstEntry.Name = "FirstEntry"
        Me.FirstEntry.Size = New System.Drawing.Size(111, 55)
        Me.FirstEntry.TabIndex = 2
        Me.FirstEntry.Text = "{" & Global.Microsoft.VisualBasic.ChrW(10) & "  ""gset"": {" & Global.Microsoft.VisualBasic.ChrW(10) & "    ""gameEntries"": ["
        '
        'LastEntry
        '
        Me.LastEntry.Location = New System.Drawing.Point(923, 132)
        Me.LastEntry.Name = "LastEntry"
        Me.LastEntry.Size = New System.Drawing.Size(111, 55)
        Me.LastEntry.TabIndex = 3
        Me.LastEntry.Text = "    ]" & Global.Microsoft.VisualBasic.ChrW(10) & "  }" & Global.Microsoft.VisualBasic.ChrW(10) & "}"
        '
        'base
        '
        Me.base.Location = New System.Drawing.Point(806, 193)
        Me.base.Name = "base"
        Me.base.Size = New System.Drawing.Size(228, 360)
        Me.base.TabIndex = 4
        Me.base.Text = resources.GetString("base.Text")
        '
        'Result
        '
        Me.Result.Location = New System.Drawing.Point(495, 71)
        Me.Result.Name = "Result"
        Me.Result.Size = New System.Drawing.Size(314, 482)
        Me.Result.TabIndex = 5
        Me.Result.Text = ""
        '
        'createBtn
        '
        Me.createBtn.Location = New System.Drawing.Point(194, 13)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Size = New System.Drawing.Size(75, 23)
        Me.createBtn.TabIndex = 7
        Me.createBtn.Text = "Create"
        Me.createBtn.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "0"
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(819, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 25)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "1"
        '
        'resetBtn
        '
        Me.resetBtn.Enabled = False
        Me.resetBtn.Location = New System.Drawing.Point(280, 13)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(75, 23)
        Me.resetBtn.TabIndex = 11
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Created:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Status:"
        '
        'statuslbl
        '
        Me.statuslbl.AutoSize = True
        Me.statuslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statuslbl.Location = New System.Drawing.Point(66, 126)
        Me.statuslbl.Name = "statuslbl"
        Me.statuslbl.Size = New System.Drawing.Size(30, 16)
        Me.statuslbl.TabIndex = 13
        Me.statuslbl.Text = "Idle"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Gamesets:"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(216, 58)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(115, 20)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Save as JSON"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(215, 91)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(140, 20)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.Text = "Copy To Clipboard"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(215, 126)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(127, 17)
        Me.CheckBox1.TabIndex = 19
        Me.CheckBox1.Text = "Exit Upon Completion"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Halo 3 (12070)", "Halo 3 Alpha (06481)", "Halo 3 Delta (08172)", "Halo 3 Beta (09699)"})
        Me.ComboBox1.Location = New System.Drawing.Point(21, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(127, 21)
        Me.ComboBox1.TabIndex = 20
        Me.ComboBox1.Text = "Halo 3 (12070)"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 167)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.statuslbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.resetBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.createBtn)
        Me.Controls.Add(Me.Result)
        Me.Controls.Add(Me.base)
        Me.Controls.Add(Me.LastEntry)
        Me.Controls.Add(Me.FirstEntry)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Sunrise Base Gameset Creator"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents FirstEntry As RichTextBox
    Friend WithEvents LastEntry As RichTextBox
    Friend WithEvents base As RichTextBox
    Friend WithEvents Result As RichTextBox
    Friend WithEvents createBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents resetBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents statuslbl As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
End Class
