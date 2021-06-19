Imports MySql.Data.MySqlClient
Public Class DAOContDocs
    Inherits ContratoDocs
    Implements OpSql


    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand
    Public Sub Guardar() Implements OpSql.Guardar
        conn = Cnx.GetConection
        Me.sql.CommandText = "insert into contrato_documentos values(" & Id & "," & Contrato & "," & Documento & ",'" & Url & "') "
        Me.sql.Connection = conn
        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        conn = Cnx.GetConection
        'Me.sql.CommandText = "insert into productos_categoria values(" & Id & ",'" & Descripcion & "') "
        Me.sql.Connection = conn
        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        conn = Cnx.GetConection
        Me.sql.CommandText = "delete from contrato_documentos where id=" & Id & " "
        Me.sql.Connection = conn
        ' Console.WriteLine(Me.sql.CommandText)
        Me.sql.ExecuteNonQuery()
    End Sub


    Friend Function getCount() As Integer
        Dim r As MySqlDataReader

        Dim count As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT IFNULL(MAX(id),0)+1 from contrato_documentos"
        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()

        While r.Read()
            count = r.GetValue(0)
        End While
        r.Close()
        Return count
    End Function

    Friend Function buscarDocs() As List(Of ContratoDocs)
        Dim emp As New List(Of ContratoDocs)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT ctd.*,doc.documento from contrato_documentos ctd
INNER JOIN documentos doc on doc.id=ctd.documento
 where contrato =" & Contrato & ""

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New ContratoDocs(r.GetValue(0), r.GetValue(1), r.GetValue(2).ToString, r.GetValue(3).ToString,
                                      r.GetValue(4).ToString))

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function

    Friend Function getDocumento() As String
        Dim emp As String
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection

        Me.sql.CommandText = "SELECT url from contrato_documentos 
                                    where id =" & Id & ""

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp = r.GetValue(0)

                i += 1
            End While
        End If

        r.Close()
        'End If

        Return emp
    End Function
End Class
