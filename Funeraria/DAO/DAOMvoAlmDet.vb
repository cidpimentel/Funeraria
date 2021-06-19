Imports MySql.Data.MySqlClient

Public Class DAOMvoAlmDet
    Inherits MovAlmDet
    Implements OpSql


    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand
    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "insert into movimientos_almacen_detalle values(" & Movimiento & "," & Producto & "," & Cantidad & "," & Costo_uni & "," & Total & ") "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        Throw New NotImplementedException()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "delete from movimientos_almacen_detalle where movimiento=" & Movimiento & " "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Friend Function consultar() As List(Of MovAlmDet)
        Dim emp As New List(Of MovAlmDet)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT pro.id,pro.no_parte,pro.descripcion,pcat.categoria,pmar.marca,puni.unidad,pro.precio_compra,pro.precio_venta ,
pmar.id as idMar, puni.id as idUni,mvd.cantidad
from movimientos_almacen_detalle mvd 
INNER JOIN productos pro on pro.id=mvd.producto
                              INNER JOIN productos_categoria pcat on pcat.id=pro.categoria
                              INNER JOIN productos_marca pmar on pmar.id = pro.marca
                              INNER JOIN productos_unidad puni on puni.id=pro.unidad
                              where mvd.movimiento=" & Movimiento & " "

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New MovAlmDet(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString,
                                    r.GetValue(4).ToString, r.GetValue(5).ToString, r.GetValue(6), r.GetValue(7), r.GetValue(8), r.GetValue(9), r.GetValue(10)))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function
End Class
