Imports MySql.Data.MySqlClient
Public Class Cnx
    Private Shared conn As Cnx
    Private Shared conexion As MySqlConnection


    Private Sub New()
        conexion = New MySqlConnection With {
                      .ConnectionString = "database=agenci10_funerariaDB; Server=70.32.23.89; UserID=agenci10_development; password=Holamundo90@"
                 }

        If conexion.State = ConnectionState.Closed Then
            conexion.Close()
        End If
        conexion.Open()
    End Sub

    Public Shared Function GetInstance() As Cnx

        If (conn Is Nothing) Then
            conn = New Cnx()
        End If

        Return conn
    End Function

    Public Shared ReadOnly Property GetConection As MySqlConnection
        Get
            Try
                GetInstance()
                Return conexion
            Catch ex As Exception

            End Try

        End Get
    End Property

    Public Sub Close_cnx()
        Try
            conexion.Close()
        Catch ex As Exception
            MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical, "ERROR DE CONEXIÓN")
        End Try
    End Sub


End Class
