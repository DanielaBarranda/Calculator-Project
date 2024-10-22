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
        screen = New TextBox()
        clearbtn = New Button()
        sum = New Button()
        subtract = New Button()
        div = New Button()
        times = New Button()
        perbtn = New Button()
        ans = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btn6 = New Button()
        btn5 = New Button()
        btn4 = New Button()
        btn9 = New Button()
        btn8 = New Button()
        btn7 = New Button()
        btn00 = New Button()
        btn0 = New Button()
        btndot = New Button()
        Label1 = New Label()
        Label2 = New Label()
        btnCE = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' screen
        ' 
        screen.BackColor = Color.FromArgb(CByte(255), CByte(221), CByte(215))
        screen.Font = New Font("Consolas", 24.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        screen.Location = New Point(26, 47)
        screen.Multiline = True
        screen.Name = "screen"
        screen.Size = New Size(395, 100)
        screen.TabIndex = 0
        screen.TextAlign = HorizontalAlignment.Right
        ' 
        ' clearbtn
        ' 
        clearbtn.BackColor = Color.FromArgb(CByte(255), CByte(243), CByte(241))
        clearbtn.FlatStyle = FlatStyle.Flat
        clearbtn.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        clearbtn.Location = New Point(26, 179)
        clearbtn.Name = "clearbtn"
        clearbtn.Size = New Size(44, 63)
        clearbtn.TabIndex = 1
        clearbtn.Text = "C"
        clearbtn.UseVisualStyleBackColor = False
        ' 
        ' sum
        ' 
        sum.BackColor = Color.FromArgb(CByte(254), CByte(235), CByte(214))
        sum.FlatStyle = FlatStyle.Flat
        sum.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        sum.Location = New Point(134, 179)
        sum.Name = "sum"
        sum.Size = New Size(86, 63)
        sum.TabIndex = 2
        sum.Text = "+"
        sum.UseVisualStyleBackColor = False
        ' 
        ' subtract
        ' 
        subtract.BackColor = Color.FromArgb(CByte(254), CByte(235), CByte(214))
        subtract.FlatStyle = FlatStyle.Flat
        subtract.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        subtract.Location = New Point(236, 179)
        subtract.Name = "subtract"
        subtract.Size = New Size(86, 63)
        subtract.TabIndex = 3
        subtract.Text = "-"
        subtract.UseVisualStyleBackColor = False
        ' 
        ' div
        ' 
        div.BackColor = Color.FromArgb(CByte(254), CByte(235), CByte(214))
        div.FlatStyle = FlatStyle.Flat
        div.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        div.Location = New Point(335, 179)
        div.Name = "div"
        div.Size = New Size(86, 63)
        div.TabIndex = 4
        div.Text = "/"
        div.UseVisualStyleBackColor = False
        ' 
        ' times
        ' 
        times.BackColor = Color.FromArgb(CByte(254), CByte(235), CByte(214))
        times.FlatStyle = FlatStyle.Flat
        times.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        times.Location = New Point(335, 258)
        times.Name = "times"
        times.Size = New Size(86, 63)
        times.TabIndex = 5
        times.Text = "x"
        times.UseVisualStyleBackColor = False
        ' 
        ' perbtn
        ' 
        perbtn.BackColor = Color.FromArgb(CByte(254), CByte(235), CByte(214))
        perbtn.FlatStyle = FlatStyle.Flat
        perbtn.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        perbtn.Location = New Point(335, 341)
        perbtn.Name = "perbtn"
        perbtn.Size = New Size(86, 63)
        perbtn.TabIndex = 6
        perbtn.Text = "%"
        perbtn.UseVisualStyleBackColor = False
        ' 
        ' ans
        ' 
        ans.BackColor = Color.FromArgb(CByte(195), CByte(204), CByte(180))
        ans.FlatStyle = FlatStyle.Flat
        ans.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        ans.Location = New Point(335, 426)
        ans.Name = "ans"
        ans.Size = New Size(86, 146)
        ans.TabIndex = 7
        ans.Text = "="
        ans.UseVisualStyleBackColor = False
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn1.FlatStyle = FlatStyle.Flat
        btn1.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn1.Location = New Point(24, 258)
        btn1.Name = "btn1"
        btn1.Size = New Size(96, 65)
        btn1.TabIndex = 8
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = False
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn2.FlatStyle = FlatStyle.Flat
        btn2.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn2.Location = New Point(126, 258)
        btn2.Name = "btn2"
        btn2.Size = New Size(98, 65)
        btn2.TabIndex = 9
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = False
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn3.FlatStyle = FlatStyle.Flat
        btn3.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn3.Location = New Point(230, 258)
        btn3.Name = "btn3"
        btn3.Size = New Size(99, 65)
        btn3.TabIndex = 10
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = False
        ' 
        ' btn6
        ' 
        btn6.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn6.FlatStyle = FlatStyle.Flat
        btn6.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn6.Location = New Point(230, 341)
        btn6.Name = "btn6"
        btn6.Size = New Size(99, 65)
        btn6.TabIndex = 13
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = False
        ' 
        ' btn5
        ' 
        btn5.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn5.FlatStyle = FlatStyle.Flat
        btn5.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn5.Location = New Point(126, 341)
        btn5.Name = "btn5"
        btn5.Size = New Size(98, 65)
        btn5.TabIndex = 12
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = False
        ' 
        ' btn4
        ' 
        btn4.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn4.FlatStyle = FlatStyle.Flat
        btn4.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn4.Location = New Point(24, 341)
        btn4.Name = "btn4"
        btn4.Size = New Size(96, 65)
        btn4.TabIndex = 11
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = False
        ' 
        ' btn9
        ' 
        btn9.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn9.FlatStyle = FlatStyle.Flat
        btn9.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn9.Location = New Point(230, 426)
        btn9.Name = "btn9"
        btn9.Size = New Size(99, 65)
        btn9.TabIndex = 16
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = False
        ' 
        ' btn8
        ' 
        btn8.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn8.FlatStyle = FlatStyle.Flat
        btn8.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn8.Location = New Point(126, 426)
        btn8.Name = "btn8"
        btn8.Size = New Size(98, 65)
        btn8.TabIndex = 15
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = False
        ' 
        ' btn7
        ' 
        btn7.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn7.FlatStyle = FlatStyle.Flat
        btn7.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn7.Location = New Point(24, 426)
        btn7.Name = "btn7"
        btn7.Size = New Size(96, 65)
        btn7.TabIndex = 14
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = False
        ' 
        ' btn00
        ' 
        btn00.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn00.FlatStyle = FlatStyle.Flat
        btn00.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn00.Location = New Point(230, 507)
        btn00.Name = "btn00"
        btn00.Size = New Size(99, 65)
        btn00.TabIndex = 19
        btn00.Text = "00"
        btn00.UseVisualStyleBackColor = False
        ' 
        ' btn0
        ' 
        btn0.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btn0.FlatStyle = FlatStyle.Flat
        btn0.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btn0.Location = New Point(126, 507)
        btn0.Name = "btn0"
        btn0.Size = New Size(98, 65)
        btn0.TabIndex = 18
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = False
        ' 
        ' btndot
        ' 
        btndot.BackColor = Color.FromArgb(CByte(232), CByte(190), CByte(193))
        btndot.FlatStyle = FlatStyle.Flat
        btndot.Font = New Font("Consolas", 24.75F, FontStyle.Bold)
        btndot.Location = New Point(24, 507)
        btndot.Name = "btndot"
        btndot.Size = New Size(96, 65)
        btndot.TabIndex = 17
        btndot.Text = "."
        btndot.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ImageAlign = ContentAlignment.BottomCenter
        Label1.Location = New Point(45, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 37)
        Label1.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(279, 113)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.Yes
        Label2.Size = New Size(0, 22)
        Label2.TabIndex = 21
        ' 
        ' btnCE
        ' 
        btnCE.BackColor = Color.FromArgb(CByte(255), CByte(243), CByte(241))
        btnCE.FlatStyle = FlatStyle.Flat
        btnCE.Font = New Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCE.Location = New Point(76, 179)
        btnCE.Name = "btnCE"
        btnCE.Size = New Size(44, 63)
        btnCE.TabIndex = 22
        btnCE.Text = "CE"
        btnCE.UseVisualStyleBackColor = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(39, 86)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 22)
        Label3.TabIndex = 23
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(208), CByte(108), CByte(106))
        ClientSize = New Size(455, 605)
        Controls.Add(Label3)
        Controls.Add(btnCE)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn00)
        Controls.Add(btn0)
        Controls.Add(btndot)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(ans)
        Controls.Add(perbtn)
        Controls.Add(times)
        Controls.Add(div)
        Controls.Add(subtract)
        Controls.Add(sum)
        Controls.Add(clearbtn)
        Controls.Add(screen)
        Name = "Form1"
        Text = "Daniela's Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents screen As TextBox
    Friend WithEvents clearbtn As Button
    Friend WithEvents sum As Button
    Friend WithEvents subtract As Button
    Friend WithEvents div As Button
    Friend WithEvents times As Button
    Friend WithEvents perbtn As Button
    Friend WithEvents ans As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btn00 As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btndot As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCE As Button
    Friend WithEvents Label3 As Label

End Class
