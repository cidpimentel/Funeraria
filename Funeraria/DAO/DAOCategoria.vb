Imports MySql.Data.MySqlClient
Public Class DAOCategoria
    Inherits Categoria
    Implements OpSql


    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "insert into productos_categoria values(" & Id & ",'" & Descripcion & "') "
        Me.sql.Connection = conn
        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        Throw New NotImplementedException()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "delete from productos_categoria where id=" & Id & " "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Function ListarCategorias() As List(Of Categoria)

        Dim emp As New List(Of Categoria)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "select * from productos_categoria"

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Categoria(r.GetValue(0), r.GetValue(1).ToString))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp

    End Function

    Friend Function getCount() As Integer
        Dim r As MySqlDataReader

        Dim count As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT IFNULL(MAX(id),0)+1 from productos_categoria"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            count = r.GetValue(0)
        End While
        r.Close()
        Return count
    End Function
End Class
