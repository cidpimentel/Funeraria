Imports MySql.Data.MySqlClient

Public Class DAOContratos
    Inherits Contratos
    Implements OpSql


    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "insert into contrato values(" & Id & "," & Cotizacion & ",'" & Nombre_finado & "',
                            '" & Domicilio_velacion & "','" & Tel_fijo & "','" & Celular & "','" & Destino & "','" & ConversionHorasFecha.fechaDB24H(Fecha_hora_cotejo) & "' ,
                            '" & Oficialia & "','" & Libro & "','" & Acta & "','" & ConversionHorasFecha.fechaDB(Fecha_registro) & "') "
        Me.sql.Connection = conn
        Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        ' Me.sql.CommandText = "insert into productos_categoria values(" & Id & ",'" & Descripcion & "') "
        Me.sql.Connection = conn
        Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "delete from contrato where id=" & Id & " "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Function ListarContratos() As List(Of Contratos)

        Dim emp As New List(Of Contratos)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT ct.id,ct.cotizacion,CONCAT(pe.nombre,' ',pe.paterno,' ',pe.materno) as cliente,
ct.nombre_finado as finado,ct.domicilio_velacion,ct.destino,ct.celular,ct.tel_fijo
 from contrato ct
INNER JOIN ventas vt on vt.id=ct.cotizacion
INNER JOIN personas pe on pe.id=vt.cliente order by ct.id desc"

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Contratos(r.GetValue(0), r.GetValue(1), r.GetValue(2).ToString, r.GetValue(3).ToString,
                                      r.GetValue(4).ToString, r.GetValue(5).ToString, r.GetValue(6).ToString, r.GetValue(7).ToString))

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

        Me.sql.CommandText = "SELECT IFNULL(MAX(id),0)+1 from contrato"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            count = r.GetValue(0)
        End While
        r.Close()
        Return count
    End Function

    Friend Function buscarContrato() As List(Of Contratos)
        Dim emp As New List(Of Contratos)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT * from contrato where cotizacion=" & Cotizacion & ""

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Contratos(r.GetValue(0), r.GetValue(1), r.GetValue(2).ToString, r.GetValue(3).ToString,
                                      r.GetValue(4).ToString, r.GetValue(5).ToString, r.GetValue(6).ToString, r.GetValue(7).ToString,
                                        r.GetValue(8).ToString, r.GetValue(9).ToString, r.GetValue(10).ToString, r.GetValue(11).ToString))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function
End Class
