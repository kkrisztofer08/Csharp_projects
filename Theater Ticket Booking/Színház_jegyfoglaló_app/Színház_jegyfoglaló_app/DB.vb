Imports System
Imports System.Data.SQLite

Namespace Színház_jegyfoglaló_app
    Friend Class DB
        Private con As SQLiteConnection = New SQLiteConnection("data source=adatbazis.db")

        Public Function getConnection() As SQLiteConnection
            Return con
        End Function

        Public Sub openConnection()
            If con.State = Data.ConnectionState.Closed Then
                con.Open()
            End If
        End Sub

        Public Sub closeConnection()
            If con.State = Data.ConnectionState.Open Then
                con.Close()
            End If
        End Sub
    End Class
End Namespace
