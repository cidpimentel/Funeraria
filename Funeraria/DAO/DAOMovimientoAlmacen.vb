Imports MySql.Data.MySqlClient

Public Class DAOMovimientoAlmacen
    Inherits MovimientoAlmacen
    Implements OpSql


    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "insert into movimientos_almacen values(" & Id & ",'" & Descripcion & "'," & Movimiento & "," & Empleado & "," & Almacen & ",'" & Fecha & "') "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        'Me.sql.CommandText = "insert into productos_marca values(" & Id & ",'" & Descripcion & "') "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "delete from movimientos_almacen where id=" & Id & ""
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Friend Function ListarMovimientos() As List(Of MovimientoAlmacen)
        Dim emp As New List(Of MovimientoAlmacen)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT mva.id,mva.descripcion,mvt.tipo_movimiento,CONCAT(per.nombre,' ',per.paterno,' ',per.materno) as empleado,
 alm.almacen,mva.fecha
from movimientos_almacen mva
INNER JOIN movimientos_tipo mvt on mvt.id=mva.movimiento_tipo 
INNER JOIN personas per on per.id=mva.empleado
INNER JOIN almacen alm on alm. id=mva.almacen
where mvt.id=" & Movimiento & " order by mva.id DESC"

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New MovimientoAlmacen(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2), r.GetValue(3).ToString, r.GetValue(4).ToString, r.GetValue(5).ToString))

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

        Me.sql.CommandText = "SELECT IFNULL(MAX(id),0)+1 from movimientos_almacen"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            count = r.GetValue(0)
        End While
        r.Close()
        Return count
    End Function

    Friend Function consultar() As List(Of MovimientoAlmacen)
        Dim emp As New List(Of MovimientoAlmacen)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT mva.id,mva.descripcion,mvt.tipo_movimiento,CONCAT(per.nombre,' ',per.paterno,' ',per.materno) as empleado,
 alm.almacen,mva.fecha
from movimientos_almacen mva
INNER JOIN movimientos_tipo mvt on mvt.id=mva.movimiento_tipo 
INNER JOIN personas per on per.id=mva.empleado
INNER JOIN almacen alm on alm. id=mva.almacen
where mva.id=" & Id & " "

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New MovimientoAlmacen(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2), r.GetValue(3).ToString, r.GetValue(4).ToString, r.GetValue(5).ToString))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function
End Class
