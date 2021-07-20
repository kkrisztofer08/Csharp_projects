Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Színház_jegyfoglaló_app
    Public Partial Class User
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub User_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            Environment.Exit(0)
        End Sub

        Private Sub infoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("Készítette: Kőrösi Krisztofer Roland" & Microsoft.VisualBasic.Constants.vbLf & "Programverzió: v1.0" & Microsoft.VisualBasic.Constants.vbLf & "Kiadás dátuma: 2020.11.20", "Információk")
        End Sub

        Private Sub kijelentkezésToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
            Hide()
            Dim f1 As Form1 = New Form1()
            f1.Show()
        End Sub

        Private gray As Color = Color.Gray
        Private green As Color = Color.Green
        Private gold As Color = Color.Gold
        Private red As Color = Color.Red

        Private Sub User_Load(ByVal sender As Object, ByVal e As EventArgs)
            MessageBox.Show("Tisztelt Nézőink!" & Microsoft.VisualBasic.Constants.vbLf & "Kérjük Önöket arra, hogy a koronavírus járvány (COVID-19) miatt csak úgy válasszanak ülőhelyet hogy két foglalt " & "ülőhely között minimum 2 hely távolság legyen." & Microsoft.VisualBasic.Constants.vbLf & "Együttműködésüket és megértésüket köszönjük!")
            panel1.Hide()
            Dim c As Control

            For Each c In Controls

                If TypeOf c Is PictureBox Then
                    c.Click += AddressOf pictureBox1_Click
                End If
            Next
        End Sub

        Private Sub pictureBox1_Click(ByVal sender As Object, ByVal e As EventArgs)
            If pictureBox1.BackColor = green Then
                pictureBox1.BackColor = gray
            ElseIf pictureBox1.BackColor = gold Then
                pictureBox1.BackColor = gray
            End If
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Dim utasitas = comboBox1.SelectedItem.ToString()

                Select Case utasitas
                    Case "Válaszzon az alábbi előadások közül..."
                        Throw New Exception("HIBA: Nincs előadás kiválasztva!")
                    Case "William Shakespeare: Rómeó és Júlia"
                        panel1.Show()
                End Select

            Catch ex As Exception
                MessageBox.Show("Kérem válasszon egy előadást" & ex.Message, "Exception")
            End Try
        End Sub
    End Class
End Namespace


