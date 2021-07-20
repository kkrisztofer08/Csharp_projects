Imports System
Imports System.Windows.Forms

Namespace Színház_jegyfoglaló_app
    Public Partial Class Rendszergazda
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Rendszergazda_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            Environment.Exit(0)
        End Sub
    End Class
End Namespace
