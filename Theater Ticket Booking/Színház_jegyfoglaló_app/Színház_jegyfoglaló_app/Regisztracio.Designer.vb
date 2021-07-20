Namespace Színház_jegyfoglaló_app
    Partial Class Regisztracio
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Regisztracio))
            label1 = New Windows.Forms.Label()
            label2 = New Windows.Forms.Label()
            label3 = New Windows.Forms.Label()
            textBox1 = New Windows.Forms.TextBox()
            textBox2 = New Windows.Forms.TextBox()
            button1 = New Windows.Forms.Button()
            button2 = New Windows.Forms.Button()
            button3 = New Windows.Forms.Button()
            label4 = New Windows.Forms.Label()
            SuspendLayout()
            ' 
            ' label1
            ' 
            label1.AutoSize = True
            label1.BackColor = Drawing.SystemColors.ActiveCaptionText
            label1.Font = New Drawing.Font("Ink Free", 48F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label1.ForeColor = Drawing.SystemColors.Control
            label1.Location = New Drawing.Point(170, 0)
            label1.Name = "label1"
            label1.Size = New Drawing.Size(384, 79)
            label1.TabIndex = 0
            label1.Text = "Regisztráció"
            ' 
            ' label2
            ' 
            label2.AutoSize = True
            label2.BackColor = Drawing.SystemColors.ActiveCaptionText
            label2.Font = New Drawing.Font("Ink Free", 18F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label2.ForeColor = Drawing.SystemColors.ControlLightLight
            label2.Location = New Drawing.Point(98, 161)
            label2.Name = "label2"
            label2.Size = New Drawing.Size(195, 30)
            label2.TabIndex = 1
            label2.Text = "Felhasználónév: "
            ' 
            ' label3
            ' 
            label3.AutoSize = True
            label3.BackColor = Drawing.SystemColors.ActiveCaptionText
            label3.Font = New Drawing.Font("Ink Free", 18F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            label3.ForeColor = Drawing.SystemColors.ControlLightLight
            label3.Location = New Drawing.Point(98, 230)
            label3.Name = "label3"
            label3.Size = New Drawing.Size(89, 30)
            label3.TabIndex = 2
            label3.Text = "Jelszó:"
            ' 
            ' textBox1
            ' 
            textBox1.BackColor = Drawing.SystemColors.InfoText
            textBox1.BorderStyle = Windows.Forms.BorderStyle.None
            textBox1.Font = New Drawing.Font("Ink Free", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            textBox1.ForeColor = Drawing.SystemColors.Window
            textBox1.Location = New Drawing.Point(369, 161)
            textBox1.Multiline = True
            textBox1.Name = "textBox1"
            textBox1.Size = New Drawing.Size(146, 28)
            textBox1.TabIndex = 3
            ' 
            ' textBox2
            ' 
            textBox2.BackColor = Drawing.SystemColors.InfoText
            textBox2.BorderStyle = Windows.Forms.BorderStyle.None
            textBox2.Font = New Drawing.Font("Ink Free", 15.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            textBox2.ForeColor = Drawing.SystemColors.Window
            textBox2.Location = New Drawing.Point(369, 230)
            textBox2.Multiline = True
            textBox2.Name = "textBox2"
            textBox2.PasswordChar = "*"c
            textBox2.Size = New Drawing.Size(146, 28)
            textBox2.TabIndex = 4
            ' 
            ' button1
            ' 
            button1.Font = New Drawing.Font("Ink Free", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button1.Location = New Drawing.Point(29, 12)
            button1.Name = "button1"
            button1.Size = New Drawing.Size(88, 53)
            button1.TabIndex = 5
            button1.Text = "Vissza a főoldalra"
            button1.UseVisualStyleBackColor = True
            AddHandler button1.Click, New EventHandler(AddressOf button1_Click)
            ' 
            ' button2
            ' 
            button2.Font = New Drawing.Font("Ink Free", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button2.Location = New Drawing.Point(304, 303)
            button2.Name = "button2"
            button2.Size = New Drawing.Size(117, 58)
            button2.TabIndex = 6
            button2.Text = "Regisztrálás"
            button2.UseVisualStyleBackColor = True
            AddHandler button2.Click, New EventHandler(AddressOf button2_Click)
            ' 
            ' button3
            ' 
            button3.Font = New Drawing.Font("Ink Free", 9.75F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            button3.Location = New Drawing.Point(541, 220)
            button3.Name = "button3"
            button3.Size = New Drawing.Size(104, 51)
            button3.TabIndex = 7
            button3.Text = "Jelszó megjelenítése"
            button3.UseVisualStyleBackColor = True
            AddHandler button3.Click, New EventHandler(AddressOf button3_Click)
            ' 
            ' label4
            ' 
            label4.AutoSize = True
            label4.BackColor = Drawing.SystemColors.ActiveCaptionText
            label4.ForeColor = Drawing.SystemColors.Control
            label4.Location = New Drawing.Point(369, 265)
            label4.Name = "label4"
            label4.Size = New Drawing.Size(0, 13)
            label4.TabIndex = 8
            ' 
            ' Regisztracio
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Drawing.Image)
            BackgroundImageLayout = Windows.Forms.ImageLayout.Stretch
            ClientSize = New Drawing.Size(740, 422)
            Controls.Add(label4)
            Controls.Add(button3)
            Controls.Add(button2)
            Controls.Add(button1)
            Controls.Add(textBox2)
            Controls.Add(textBox1)
            Controls.Add(label3)
            Controls.Add(label2)
            Controls.Add(label1)
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Name = "Regisztracio"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Regisztráció"
            AddHandler FormClosing, New Windows.Forms.FormClosingEventHandler(AddressOf Regisztracio_FormClosing)
            ResumeLayout(False)
            PerformLayout()
        End Sub

#End Region

        Private label1 As Windows.Forms.Label
        Private label2 As Windows.Forms.Label
        Private label3 As Windows.Forms.Label
        Private textBox1 As Windows.Forms.TextBox
        Private textBox2 As Windows.Forms.TextBox
        Private button1 As Windows.Forms.Button
        Private button2 As Windows.Forms.Button
        Private button3 As Windows.Forms.Button
        Private label4 As Windows.Forms.Label
    End Class
End Namespace
