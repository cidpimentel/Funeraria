Imports MySql.Data.MySqlClient

Public Class DAOVenta
    Inherits Venta
    Implements OpSql

    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand
    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "insert into ventas values(" & Id & "," & Cliente & "," & Paquete & "," & Subtotal & "," & Descuento & "," & Iva & "," & Total & ",'" & ConversionHorasFecha.fechaDB(Today.Date) & "') "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        Throw New NotImplementedException()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "delete from ventas where id=" & Id & " "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Friend Function getCountVentas() As Integer
        Dim r As MySqlDataReader

        Dim count As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT IFNULL(MAX(id),0)+1 from ventas"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            count = r.GetValue(0)
        End While
        r.Close()
        Return count
    End Function

    Friend Function Listar() As List(Of Venta)

        Dim emp As New List(Of Venta)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection



        Me.sql.CommandText = "SELECT vt.id, CONCAT(per.nombre,' ',per.paterno,' ',per.materno) as cliente ,
			                  pa.paquete, vt.subtotal,vt.iva,vt.total,vt.fecha,vt.descuento from ventas vt 
                              INNER JOIN personas per on per.id = vt.cliente
                              INNER JOIN paquetes pa on pa.id = vt.paquete"

        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()


                emp.Add(New Venta(r.GetValue(0), r.GetValue(1), r.GetValue(2), r.GetValue(3), r.GetValue(4), r.GetValue(5), r.GetValue(6), r.GetValue(7)))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp

    End Function
End Class
