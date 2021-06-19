Imports MySql.Data.MySqlClient

Public Class DAODocumento
    Inherits Documento
    Implements OpSql

    Dim conn As MySqlConnection
    ReadOnly sql As New MySqlCommand
    Public Sub Guardar() Implements OpSql.Guardar
        Throw New NotImplementedException()
    End Sub

    Public Sub Actualizar() Implements OpSql.Actualizar
        Throw New NotImplementedException()
    End Sub

    Public Sub Eliminar() Implements OpSql.Eliminar
        Throw New NotImplementedException()
    End Sub

    Friend Function ListarDocumentos() As List(Of Documento)
        Dim emp As New List(Of Documento)
        Dim r As MySqlDataReader
        Dim i As Integer = 0

        conn = Cnx.GetConection


        Me.sql.CommandText = "SELECT * from documentos  "

        Me.sql.Connection = conn
        r = Me.sql.ExecuteReader()


        If r.HasRows Then
            While r.Read()

                emp.Add(New Documento(r.GetValue(0), r.GetValue(1).ToString))

                i += 1
            End While
        End If

        r.Close()


        Return emp
    End Function
End Class
