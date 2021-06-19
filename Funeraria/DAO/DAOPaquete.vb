Imports MySql.Data.MySqlClient

Public Class DAOPaquete
    Inherits Paquete
    Implements OpSql

    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand
    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "insert into paquetes values(" & Id & ",'" & Paquete & "'," & Costo & ") "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        Me.sql.CommandText = "update paquetes set costo=" & Costo & " where id=" & Id & ""
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "delete from paquetes where id=" & Id & ""
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Friend Function getCount() As Integer
        Dim r As MySqlDataReader

        Dim count As Integer = 0

        conn = Cnx.GetConection

        If conn.State = ConnectionState.Open Then

            Me.sql.CommandText = "SELECT IFNULL(MAX(id),0)+1 from paquetes"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            count = r.GetValue(0)
        End While
            r.Close()

        End If
        Return count
    End Function

    Friend Function ListarPaquetes() As List(Of Paquete)
        Dim emp As New List(Of Paquete)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection


        Me.sql.CommandText = "SELECT * from paquetes  "

            Me.sql.Connection = conn
            r = Me.sql.ExecuteReader()


            If r.HasRows Then
                While r.Read()

                    emp.Add(New Paquete(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2)))

                    i += 1
                End While
            End If

            r.Close()


            Return emp
    End Function

    Friend Function consultar() As List(Of Paquete)
        Dim emp As New List(Of Paquete)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        If conn.State = ConnectionState.Open Then


            Me.sql.CommandText = "SELECT * from paquetes where id=" & Id & " "

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Paquete(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2)))

                i += 1
            End While
        End If

        r.Close()
            'End If

        End If
        Return emp
    End Function
End Class
