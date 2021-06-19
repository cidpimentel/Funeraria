Imports MySql.Data.MySqlClient

Public Class DAOTipoMovimiento
    Inherits TipoMovimiento
    Implements OpSql


    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand
    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        'Me.sql.CommandText = "insert into productos_marca values(" & Id & ",'" & Descripcion & "') "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        Throw New NotImplementedException()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        Throw New NotImplementedException()
    End Sub

    Friend Function ListarTipoMovimiento() As List(Of TipoMovimiento)
        Dim emp As New List(Of TipoMovimiento)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "select * from movimientos_tipo where id<> 3 and id <> 4"

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New TipoMovimiento(r.GetValue(0), r.GetValue(1).ToString))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function

End Class
