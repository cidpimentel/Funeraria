Imports System.IO
Imports System.Net

Public Class ServicioFTP
    Public Property hwnd As Long

    Public Shared Sub subirFichero(ByVal RutaLocal As String)
        ' set up request...
        Dim clsRequest As System.Net.FtpWebRequest =
            DirectCast(System.Net.WebRequest.Create("ftp.agenciafunerariagarcia.a2hosted.com"), System.Net.FtpWebRequest)
        clsRequest.Credentials = New System.Net.NetworkCredential("documentos@agenciafunerariagarcia.a2hosted.com", "c?[cpyWk+}#m")
        clsRequest.Method = System.Net.WebRequestMethods.Ftp.UploadFile

        ' read in file...
        Dim bFile() As Byte = System.IO.File.ReadAllBytes(RutaLocal)

        ' upload file...
        Dim clsStream As System.IO.Stream =
            clsRequest.GetRequestStream()
        clsStream.Write(bFile, 0, bFile.Length)
        clsStream.Close()
        clsStream.Dispose()
    End Sub

    Public Shared Function upload(venta As String, ruta As String) As String

        Dim archivo As String = venta & Path.GetExtension(ruta)

        Dim request As FtpWebRequest = FtpWebRequest.Create(String.Format("ftp://{0}/{1}", "ftp.agenciafunerariagarcia.a2hosted.com", archivo))

        request.Method = WebRequestMethods.Ftp.UploadFile
        request.Credentials = New NetworkCredential("documentos@agenciafunerariagarcia.a2hosted.com", "c?[cpyWk+}#m")
        request.UsePassive = True
        request.UseBinary = True
        request.KeepAlive = True

        'RUTA DONDE ESTA UBICADO EL ARCHIVO
        Dim Stream As FileStream = File.OpenRead(ruta)
        Dim filesize As Long = Stream.Length

        Dim buffer(filesize) As Byte
        Stream.Read(buffer, 0, buffer.Length)
        Stream.Close()
        Dim reqStream As Stream = request.GetRequestStream()
        reqStream.Write(buffer, 0, buffer.Length)
        reqStream.Flush()
        reqStream.Close()

        Return archivo
    End Function


    'Descarga de un archivo por FTP

    Public Shared Sub Download(strFileNameFTP As String)

        Dim request As FtpWebRequest = WebRequest.Create("ftp://ftp.agenciafunerariagarcia.a2hosted.com/" & strFileNameFTP)
        request.Credentials = New NetworkCredential("documentos@agenciafunerariagarcia.a2hosted.com", "c?[cpyWk+}#m")
        request.Method = WebRequestMethods.Ftp.DownloadFile

        Using ftpStream As Stream = request.GetResponse().GetResponseStream(),
              fileStream As Stream = File.Create("C:\Users\Public\Documents\" & strFileNameFTP)
            ftpStream.CopyTo(fileStream)
        End Using

        MsgBox("Se ha generado correctamente en la siguiente ruta: " & "C:\Users\Public\Documents", vbInformation, "Resultado")

    End Sub


    Public Shared Sub Eliminar(strFileNameFTP As String)

        Dim request As FtpWebRequest = WebRequest.Create("ftp://ftp.agenciafunerariagarcia.a2hosted.com/" & strFileNameFTP)
        request.Credentials = New NetworkCredential("documentos@agenciafunerariagarcia.a2hosted.com", "c?[cpyWk+}#m")
        request.Method = WebRequestMethods.Ftp.DeleteFile
        request.UsePassive = False

        Try
            Dim respuestaFTP As FtpWebResponse
            respuestaFTP = CType(request.GetResponse(), FtpWebResponse)
            respuestaFTP.Close()
        Catch ex As Exception
            ' Si se produce algún fallo, se devolverá el mensaje del error
            MsgBox("Error al borrar fichero" & ex.Message)
        End Try
    End Sub



End Class
