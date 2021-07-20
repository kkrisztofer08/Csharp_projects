Imports System
Imports System.Windows.Forms
Imports System.Data.SQLite

Namespace Színház_jegyfoglaló_app
    Public Partial Class Regisztracio
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Regisztracio_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            Environment.Exit(0)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Hide()
            Dim f1 As Form1 = New Form1()
            f1.Show()
        End Sub

        Private Sub button3_Click(ByVal sender As Object, ByVal e As EventArgs)
            label4.Text = "A megadott jelszó: " & textBox2.Text
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim db As DB = New DB()
            db.openConnection()
            Dim cmd As SQLiteCommand = New SQLiteCommand("insert into belepes(felhnev, jelszo) values('" & textBox1.Text & "', '" & textBox2.Text & "')", db.getConnection())
            cmd.ExecuteNonQuery()
            db.closeConnection()
            textBox1.Text = ""
            textBox2.Text = ""
            MessageBox.Show("A regisztráció sikeres volt")
        End Sub
    End Class
End Namespace
