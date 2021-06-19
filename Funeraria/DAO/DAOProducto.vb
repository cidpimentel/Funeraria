Imports MySql.Data.MySqlClient
Public Class DAOProducto
    Inherits Product
    Implements OpSql

    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand

    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "insert into productos values(" & Id & ",'" & Parte & "','" & Descripcion & "'," & Categoria & "," & Unidad & "," & Marca & "," & Compra & "," & Venta & "," & MostrarP & ",1,0)"
        Me.sql.Connection = conn
        Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        Me.sql.CommandText = "
                    UPDATE productos set no_parte='" & Parte & "',descripcion='" & Descripcion & "',categoria=" & Categoria & ",unidad=" & Unidad & ",marca=" & Marca & ",precio_compra=" & Compra & ",precio_venta=" & Venta & ",mostrar_precio=" & MostrarP & " where id=" & Id & "  "
        Me.sql.Connection = conn
        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Friend Function Consultar() As List(Of Product)
        Dim emp As New List(Of Product)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "SELECT * from productos where id=" & Id & ""
        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Product(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetInt32(3),
                                    r.GetInt32(4), r.GetValue(5), r.GetValue(6), r.GetValue(7), r.GetValue(8)))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = " UPDATE productos set status=" & Status & " where id=" & Id & "  "
        Me.sql.Connection = conn

        Me.sql.ExecuteNonQuery()
    End Sub

    Friend Function getCountProducto() As Integer
        Dim r As MySqlDataReader

        Dim count As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT IFNULL(MAX(id),0)+1 from productos"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            count = r.GetValue(0)
        End While
        r.Close()
        Return count
    End Function

    Friend Function BuscarProductoClave() As List(Of Product)
        Dim emp As New List(Of Product)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "SELECT pro.id,pro.no_parte,pro.descripcion,pcat.categoria,pmar.marca,puni.unidad,pro.precio_compra,pro.precio_venta ,
pmar.id as idMar, puni.id as idUni,pro.stock
from productos pro
                              INNER JOIN productos_categoria pcat on pcat.id=pro.categoria
                              INNER JOIN productos_marca pmar on pmar.id = pro.marca
                              INNER JOIN productos_unidad puni on puni.id=pro.unidad
                              where pro.`status`=1 and pcat.id<>2 and  pro.no_parte='" & Parte & "'"
        Console.WriteLine(Me.sql.CommandText)
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Product(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString,
                                    r.GetValue(4).ToString, r.GetValue(5).ToString, r.GetValue(6), r.GetValue(7), r.GetValue(8), r.GetValue(9), r.GetValue(10)))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function

    Friend Function BuscarProductoClaveTodo() As List(Of Product)
        Dim emp As New List(Of Product)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "SELECT pro.id,pro.no_parte,pro.descripcion,pcat.categoria,pmar.marca,puni.unidad,pro.precio_compra,pro.precio_venta ,
pmar.id as idMar, puni.id as idUni,pro.stock
from productos pro
                              INNER JOIN productos_categoria pcat on pcat.id=pro.categoria
                              INNER JOIN productos_marca pmar on pmar.id = pro.marca
                              INNER JOIN productos_unidad puni on puni.id=pro.unidad
                              where pro.`status`=1  and  pro.no_parte='" & Parte & "'"
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Product(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString,
                                    r.GetValue(4).ToString, r.GetValue(5).ToString, r.GetValue(6), r.GetValue(7), r.GetValue(8), r.GetValue(9), r.GetValue(10)))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function
    Friend Function BuscarProductoDescripcionTodo() As List(Of Product)
        Dim emp As New List(Of Product)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "SELECT pro.id,pro.no_parte,pro.descripcion,pcat.categoria,pmar.marca,puni.unidad,pro.precio_compra,pro.precio_venta ,
pmar.id as idMar, puni.id as idUni,pro.stock
from productos pro
                              INNER JOIN productos_categoria pcat on pcat.id=pro.categoria
                              INNER JOIN productos_marca pmar on pmar.id = pro.marca
                              INNER JOIN productos_unidad puni on puni.id=pro.unidad
                              where pro.`status`=1 and  pro.descripcion like '%" & Descripcion & "%'"

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Product(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString,
                                    r.GetValue(4).ToString, r.GetValue(5).ToString, r.GetValue(6), r.GetValue(7), r.GetValue(8), r.GetValue(9), r.GetValue(10)))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function


    Friend Function BuscarProductoDescripcion() As List(Of Product)
        Dim emp As New List(Of Product)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "SELECT pro.id,pro.no_parte,pro.descripcion,pcat.categoria,pmar.marca,puni.unidad,pro.precio_compra,pro.precio_venta ,
pmar.id as idMar, puni.id as idUni,pro.stock
from productos pro
                              INNER JOIN productos_categoria pcat on pcat.id=pro.categoria
                              INNER JOIN productos_marca pmar on pmar.id = pro.marca
                              INNER JOIN productos_unidad puni on puni.id=pro.unidad
                              where pro.`status`=1 and pcat.id<>2 and  pro.descripcion like '%" & Descripcion & "%'"
        Console.WriteLine(Me.sql.CommandText)
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Product(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString,
                                    r.GetValue(4).ToString, r.GetValue(5).ToString, r.GetValue(6), r.GetValue(7), r.GetValue(8), r.GetValue(9), r.GetValue(10)))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function

    Friend Function Listar() As List(Of Product)
        Dim emp As New List(Of Product)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection



        Me.sql.CommandText = "SELECT pro.id,pro.no_parte,pro.descripcion,pcat.categoria,pmar.marca,puni.unidad,pro.precio_compra,pro.precio_venta,pro.stock from productos pro
                              INNER JOIN productos_categoria pcat on pcat.id=pro.categoria
                              INNER JOIN productos_marca pmar on pmar.id = pro.marca
                              INNER JOIN productos_unidad puni on puni.id=pro.unidad
                              where pro.`status`=" & Status & ""
            ' Console.WriteLine(Me.sql.CommandText)
            Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()


                emp.Add(New Product(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString,
                                    r.GetValue(4).ToString, r.GetValue(5).ToString, r.GetValue(6), r.GetValue(7), r.GetValue(8)))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function
End Class
