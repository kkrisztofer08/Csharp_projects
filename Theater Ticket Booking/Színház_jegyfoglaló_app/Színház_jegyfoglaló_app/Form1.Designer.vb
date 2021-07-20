Namespace Színház_jegyfoglaló_app
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
            label1 = New Windows.Forms.Label()
            radioButton1 = New Windows.Forms.RadioButton()
            radioButton2 = New Windows.Forms.RadioButton()
            menuStrip1 = New Windows.Forms.MenuStrip()
            fileToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            kilépésToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            helpToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            infoToolStripMenuItem = New Windows.Forms.ToolStripMenuItem()
            label2 = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            textBox1 = New Windows.Forms.TextBox()
            textBox2 = New Windows.Forms.TextBox()
            button1 = New Windows.Forms.Button()
            button2 = New Windows.Forms.Button()
            menuStrip1.SuspendLayout()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.BackColor = Drawing.SystemColors.ActiveCaptionText
            label1.Font = New Drawing.Font("Ink Free", 48F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.SystemColors.ButtonFace
            label1.Location = New Drawing.Point(196, 24)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(422, 79)
            label1.TabIndex = 0
            label1.Text = "Bejelentkezés"
            ' 
            ' radioButton1
            ' 
            radioButton1.AutoSize = True
            radioButton1.BackColor = Drawing.SystemColors.ActiveCaptionText
            radioButton1.Font = New Drawing.Font("Ink Free", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            radioButton1.ForeColor = Drawing.SystemColors.Control
            radioButton1.Location = New Drawing.Point(224, 122)
            radioButton1.Name = "radioButton1"
            radioButton1.Size = New Drawing.Size(179, 30)
            radioButton1.TabIndex = 1
            radioButton1.Text = "Rendszergazda"
            radioButton1.UseVisualStyleBackColor = False
            ' 
            ' radioButton2
            ' 
            radioButton2.AutoSize = True
            radioButton2.BackColor = Drawing.SystemColors.ActiveCaptionText
            radioButton2.Font = New Drawing.Font("Ink Free", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            radioButton2.ForeColor = Drawing.SystemColors.Control
            radioButton2.Location = New Drawing.Point(411, 122)
            radioButton2.Name = "radioButton2"
            radioButton2.Size = New Drawing.Size(144, 30)
            radioButton2.TabIndex = 2
            radioButton2.Text = "Felhasználó"
            radioButton2.UseVisualStyleBackColor = False
            ' 
            ' menuStrip1
            ' 
            menuStrip1.Items.AddRange(New Windows.Forms.ToolStripItem() {fileToolStripMenuItem, helpToolStripMenuItem})
            menuStrip1.Location = New Drawing.Point(0, 0)
            menuStrip1.Name = "menuStrip1"
            menuStrip1.Size = New Drawing.Size(815, 24)
            menuStrip1.TabIndex = 3
            menuStrip1.Text = "menuStrip1"
            ' 
            ' fileToolStripMenuItem
            ' 
            fileToolStripMenuItem.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {kilépésToolStripMenuItem})
            fileToolStripMenuItem.Name = "fileToolStripMenuItem"
            fileToolStripMenuItem.Size = New Drawing.Size(37, 20)
            fileToolStripMenuItem.Text = "File"
            ' 
            ' kilépésToolStripMenuItem
            ' 
            kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem"
            kilépésToolStripMenuItem.Size = New Drawing.Size(111, 22)
            kilépésToolStripMenuItem.Text = "Kilépés"
            AddHandler kilépésToolStripMenuItem.Click, New EventHandler(AddressOf kilépésToolStripMenuItem_Click)
            ' 
            ' helpToolStripMenuItem
            ' 
            helpToolStripMenuItem.DropDownItems.AddRange(New Windows.Forms.ToolStripItem() {infoToolStripMenuItem})
            helpToolStripMenuItem.Name = "helpToolStripMenuItem"
            helpToolStripMenuItem.Size = New Drawing.Size(44, 20)
            helpToolStripMenuItem.Text = "Help"
            ' 
            ' infoToolStripMenuItem
            ' 
            infoToolStripMenuItem.Name = "infoToolStripMenuItem"
            infoToolStripMenuItem.Size = New Drawing.Size(95, 22)
            infoToolStripMenuItem.Text = "Info"
            AddHandler infoToolStripMenuItem.Click, New EventHandler(AddressOf infoToolStripMenuItem_Click)
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.BackColor = Drawing.SystemColors.ActiveCaptionText
            label2.Font = New Drawing.Font("Ink Free", 18F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label2.ForeColor = Drawing.SystemColors.Control
            label2.Location = New Drawing.Point(152, 238)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(187, 30)
            label2.TabIndex = 4
            label2.Text = "Felhasználónév:"
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.BackColor = Drawing.SystemColors.ActiveCaptionText
            label3.Font = New Drawing.Font("Ink Free", 18F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label3.ForeColor = Drawing.SystemColors.Control
            label3.Location = New Drawing.Point(152, 287)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(89, 30)
            label3.TabIndex = 5
            label3.Text = "Jelszó:"
            ' 
            ' textBox1
            ' 
            textBox1.BackColor = Drawing.SystemColors.InfoText
            textBox1.BorderStyle = Windows.Forms.BorderStyle.None
            textBox1.Font = New Drawing.Font("Ink Free", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            textBox1.ForeColor = Drawing.SystemColors.Window
            textBox1.Location = New Drawing.Point(411, 238)
            textBox1.Multiline = True
            textBox1.Name = "textBox1"
            textBox1.Size = New Drawing.Size(179, 30)
            textBox1.TabIndex = 6
            ' 
            ' textBox2
            ' 
            textBox2.BackColor = Drawing.SystemColors.MenuText
            textBox2.BorderStyle = Windows.Forms.BorderStyle.None
            textBox2.Font = New Drawing.Font("Ink Free", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            textBox2.ForeColor = Drawing.SystemColors.Window
            textBox2.Location = New Drawing.Point(411, 287)
            textBox2.Multiline = True
            textBox2.Name = "textBox2"
            textBox2.PasswordChar = "*"c
            textBox2.Size = New Drawing.Size(179, 30)
            textBox2.TabIndex = 7
            ' 
            ' button1
            ' 
            button1.Font = New Drawing.Font("Ink Free", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button1.Location = New Drawing.Point(256, 361)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(119, 56)
            button1.TabIndex = 8
            button1.Text = "Regisztráció"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' button2
            ' 
            button2.Font = New Drawing.Font("Ink Free", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button2.Location = New Drawing.Point(395, 361)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(121, 56)
            button2.TabIndex = 9
            button2.Text = "Bejelentkezés"
            button2.UseVisualStyleBackColor = True
            AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Drawing.Image)
            BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
            ClientSize = New Drawing.Size(815, 460)
            Controls.Add(button2)
            Controls.Add(button1)
            Controls.Add(textBox2)
            Controls.Add(textBox1)
            Controls.Add(label3)
            Controls.Add(label2)
            Controls.Add(radioButton2)
            Controls.Add(radioButton1)
            Controls.Add(label1)
            Controls.Add(menuStrip1)
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            MainMenuStrip = menuStrip1
            Name = "Form1"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Bejelentkezés"
            AddHandler FormClosing, New Windows.Forms.FormClosingEventHandler(AddressOf Form1_FormClosing)
            menuStrip1.ResumeLayout(False)
            menuStrip1.PerformLayout()
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private radioButton1 As Windows.Forms.RadioButton
        Private radioButton2 As Windows.Forms.RadioButton
        Private menuStrip1 As Windows.Forms.MenuStrip
        Private fileToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private helpToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private kilépésToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private infoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
        Private label2 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private textBox1 As Windows.Forms.TextBox
        Private textBox2 As Windows.Forms.TextBox
        Private button1 As Windows.Forms.Button
        Private button2 As Windows.Forms.Button
    End Class
End Namespace
