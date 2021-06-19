Imports MySql.Data.MySqlClient
Public Class DAOUsuario
    Inherits Usuario
    Implements OpSql

    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand
    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "
                    
                insert into personas values(" & Id & ",'" & Nombre & "','" & Paterno & "','" & Materno & "','" & Tel_fijo & "','" & Celular & "','" & Domicilio & "','" & Rfc & "','" & Email & "'," & Tipo & ");

                insert into usuarios values(" & IdUsuario & ",'" & Usuario & "','" & Contraseña & "'," & Id & ")

            "
        Me.sql.Connection = conn
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        Me.sql.CommandText = "
                    UPDATE personas set nombre='" & Nombre & "',paterno='" & Paterno & "',materno='" & Materno & "',rfc='" & Rfc & "',tel_fijo='" & Tel_fijo & "',celular='" & Celular & "',email='" & Email & "',domicilio='" & Domicilio & "' where id=" & Id & ";
                
                    UPDATE usuarios set usuario='" & Usuario & "', `password`='" & Contraseña & "' WHERE id=" & Id & "
            "
        Me.sql.Connection = conn
        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Friend Function getVentaCliente(venta As Integer) As List(Of Usuario)
        Dim emp As New List(Of Usuario)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "SELECT per.*,us.usuario,us.`password` from ventas vt
INNER JOIN personas per on per.id=vt.cliente
INNER JOIN usuarios us on us.persona=per.id
                                  where vt.id=" & venta & ""
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Usuario(r.GetValue(1), r.GetValue(2), r.GetValue(3), r.GetValue(4), r.GetValue(5), r.GetValue(6),
                                    r.GetValue(8), r.GetValue(10), r.GetValue(11), r.GetValue(7)))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "delete from usuarios WHERE id=" & IdUsuario & " "
        Me.sql.Connection = conn

        Me.sql.ExecuteNonQuery()
    End Sub

    Public Function Consultar() As List(Of Usuario)
        Dim emp As New List(Of Usuario)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "SELECT per.nombre,per.paterno,per.materno,per.rfc,per.tel_fijo,per.celular,per.email,us.usuario,us.`password`,per.domicilio from usuarios us
                              INNER JOIN personas per on us.persona=per.id
                              WHERE per.id=" & Id & ""
        'Console.WriteLine(Me.sql.CommandText)
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Usuario(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString, r.GetValue(4).ToString,
                        r.GetValue(5), r.GetValue(6).ToString, r.GetValue(7).ToString, r.GetValue(8).ToString, r.GetValue(9).ToString))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function

    Public Function Listar() As List(Of Usuario)
        Dim emp As New List(Of Usuario)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "SELECT per.id,CONCAT(per.nombre,' ',per.paterno,' ',per.materno) as empleado,us.usuario,per.tel_fijo,per.celular,us.id as idUser from usuarios us
                              INNER JOIN personas per on us.persona=per.id
                              WHERE per.tipo_persona=" & Tipo & " and us.id <> " & ActiveUser.idUser & ""
        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Usuario(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString, r.GetValue(4).ToString, r.GetValue(5).ToString))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function
    Public Function ListarTodo() As List(Of Usuario)
        Dim emp As New List(Of Usuario)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection
        ' If  IsNot Nothing Then
        Me.sql.CommandText = "SELECT per.id,CONCAT(per.nombre,' ',per.paterno,' ',per.materno) as empleado,us.usuario,per.tel_fijo,per.celular,us.id as idUser from usuarios us
                              INNER JOIN personas per on us.persona=per.id order by per.tipo_persona asc "
        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Usuario(r.GetValue(0), r.GetValue(1).ToString, r.GetValue(2).ToString, r.GetValue(3).ToString, r.GetValue(4).ToString, r.GetValue(5).ToString))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function
    Friend Function ValidarUser(usuario1 As Object) As Object

        Dim r As MySqlDataReader
        Dim i As Integer = 0
        Dim consulta As Object = ""
        conn = Cnx.GetConection

        Me.sql.CommandText = "select us.*,CONCAT(per.nombre,' ',per.paterno,' ',per.materno)as nombre from usuarios us
INNER JOIN personas per on per.id=us.persona
where usuario='" & Usuario & "'"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            consulta = r.GetValue(2).ToString
            ActiveUser.idUser = r.GetValue(3)
            ActiveUser.loginName = r.GetValue(1)
            ActiveUser.password = r.GetValue(2)
            ActiveUser.userName = r.GetValue(4)
            i += 1
        End While
        r.Close()
        Return consulta

    End Function


    Public Function getCountUser() As Integer
        Dim r As MySqlDataReader

        Dim count As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT IFNULL(MAX(id),0)+1 from usuarios"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            count = r.GetValue(0)
        End While
        r.Close()
        Return count
    End Function

    Public Function getCountPersona() As Integer
        Dim r As MySqlDataReader

        Dim count As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT IFNULL(MAX(id),0)+1 from personas"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            count = r.GetValue(0)
        End While
        r.Close()
        Return count
    End Function
End Class


