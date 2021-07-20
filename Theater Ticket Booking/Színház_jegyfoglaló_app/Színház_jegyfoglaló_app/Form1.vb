Imports System
Imports System.Data
Imports System.Windows.Forms
Imports System.Data.SQLite

Namespace Színház_jegyfoglaló_app
    Public Partial Class Form1
        Inherits Form

        Private dt As DataTable = New DataTable()
        Private sda As SQLiteDataAdapter
        Private cmd As SQLiteCommand = New SQLiteCommand()

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub infoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("Készítette: Kőrösi Krisztofer Roland" & Microsoft.VisualBasic.Constants.vbLf & "Verziószám: 1.0" & Microsoft.VisualBasic.Constants.vbLf & "Kiadás dátuma: 2020.11.17")
        End Sub

        Private Sub kilépésToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Environment.Exit(0)
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Hide()
            Dim r As Regisztracio = New Regisztracio()
            r.Show()
        End Sub

        Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            Environment.Exit(0)
        End Sub

        Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Equals(textBox1.Text, "rendszergazda") AndAlso Equals(textBox2.Text, "rendszergazda1") AndAlso radioButton1.Checked Then
                Hide()
                Dim admin As Rendszergazda = New Rendszergazda()
                admin.Show()
            ElseIf radioButton2.Checked Then
                Dim db As DB = New DB()
                cmd = New SQLiteCommand("select count(*) from belepes where felhnev='" & textBox1.Text & "' and jelszo='" & textBox2.Text & "'", db.getConnection())
                sda = New SQLiteDataAdapter(cmd)
                sda.Fill(dt)

                If Equals(dt.Rows(0)(0).ToString(), "1") Then
                    Hide()
                    Dim u As User = New User()
                    u.Show()
                Else
                    MessageBox.Show("Hibás felhasználónév és/vagy jelszó!" & Microsoft.VisualBasic.Constants.vbLf & "Kérjük próbáld újra!")
                End If
            End If
        End Sub
    End Class
End Namespace
