Namespace Színház_jegyfoglaló_app
    Partial Class Rendszergazda
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
            Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Rendszergazda))
            SuspendLayout()
            ' 
            ' Rendszergazda
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6F, 13F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(1019, 511)
            Icon = CType(resources.GetObject("$this.Icon"), Drawing.Icon)
            Name = "Rendszergazda"
            StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Text = "Rendszergazdai_felület"
            AddHandler FormClosing, New Windows.Forms.FormClosingEventHandler(AddressOf Rendszergazda_FormClosing)
            ResumeLayout(False)
        End Sub

#End Region
    End Class
End Namespace
