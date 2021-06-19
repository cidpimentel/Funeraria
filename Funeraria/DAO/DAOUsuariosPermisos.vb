Imports MySql.Data.MySqlClient
Public Class DAOUsuariosPermisos
    Inherits UsuariosPermisos
    Implements OpSql

    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand
    Public Sub Guardar() Implements OpSql.Guardar
        Throw New NotImplementedException()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        Me.sql.CommandText = "UPDATE usuarios_permisos set valor=" & Valor & " where id=" & Id & ""
        Me.sql.Connection = conn
        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        Throw New NotImplementedException()
    End Sub

    Public Function Listar() As List(Of UsuariosPermisos)
        Dim emp As New List(Of UsuariosPermisos)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT usp.id,me.menu,usp.valor from usuarios_permisos usp
                              INNER JOIN menu me on me.id=usp.menu
                              where usp.usuario=" & Usuario & ""

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New UsuariosPermisos(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function

    Friend Function GetPermisOpc(text As String) As Boolean
        Dim valor As Boolean
        Dim r As MySqlDataReader
        Dim i As Integer = 1

        Menu = getIdMenu(text)
        conn = Cnx.GetConection
        Me.sql.CommandText = "SELECT valor from usuarios_permisos where usuario=" & Usuario & " and menu= " & Menu & "  "

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        If r.HasRows Then
            While r.Read()

                If r.GetValue(0) = 1 Then
                    valor = True
                Else
                    valor = False
                End If

                i += 1
            End While
        End If

        r.Close()

        Return valor
    End Function

    Friend Function getIdMenu(text As String) As Integer
        Dim valor As Integer
        Dim r As MySqlDataReader
        Dim i As Integer = 1


        conn = Cnx.GetConection
        Me.sql.CommandText = "SELECT id from menu where menu='" & text & "' "

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        If r.HasRows Then
            While r.Read()

                valor = r.GetValue(0)

                i += 1
            End While
        End If

        r.Close()

        Return valor
    End Function
End Class
