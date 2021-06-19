Imports MySql.Data.MySqlClient

Public Class DAOPaqueteDetalle
    Inherits PaqueteDetalle
    Implements OpSql


    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "insert into paquetes_detalle values(" & IdDetalle & "," & Id & "," & Producto & "," & Cantidad & "," & Costo1 & ") "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        'Me.sql.CommandText = "insert into almacen values(" & Id & ",'" & Almacen & "') "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "delete from paquetes_detalle where id=" & IdDetalle & " "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub


    Friend Function ListarPaqueteDetalle() As List(Of PaqueteDetalle)
        Dim emp As New List(Of PaqueteDetalle)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT pro.id,pro.no_parte,pro.descripcion,pcat.categoria,pmar.marca,puni.unidad,pro.precio_compra,pro.precio_venta ,
mvd.id as idPaDet, puni.id as idUni,mvd.cantidad
from paquetes_detalle mvd 
INNER JOIN productos pro on pro.id=mvd.producto
                              INNER JOIN productos_categoria pcat on pcat.id=pro.categoria
                              INNER JOIN productos_marca pmar on pmar.id = pro.marca
                              INNER JOIN productos_unidad puni on puni.id=pro.unidad
                              where mvd.paquete=" & Id & " "

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New PaqueteDetalle(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString,
                                    r.GetValue(4).ToString, r.GetValue(5).ToString, r.GetValue(6), r.GetValue(7), r.GetValue(8), r.GetValue(9), r.GetValue(10)))


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

        Me.sql.CommandText = "SELECT IFNULL(MAX(id),0)+1 from paquetes_detalle"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            count = r.GetValue(0)
        End While
        r.Close()
        Return count
    End Function

    Friend Sub EliminarTodos()
        conn = Cnx.GetConection
        Me.sql.CommandText = "delete from paquetes_detalle where paquete=" & Id & " "
        Me.sql.Connection = conn
        Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub
End Class
