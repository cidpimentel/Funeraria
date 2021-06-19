Imports Microsoft.Reporting.WinForms

Public Class PreviewVenta

    Public Shared id_venta As Integer
    Private Sub PreviewVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cargarReporte()
    End Sub


    Private Sub cargarReporte()

        Me.Venta_reporteTableAdapter1.FillBy(Me.Datos1.venta_reporte, id_venta)
        Dim consulta1 As DataTable = Datos1.venta_reporte
        Me.ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", consulta1))


        'Dim parameters As New List(Of ReportParameter)()
        'parameters.Add(New ReportParameter("ciclo", ActiveUser.periodo.ToString))
        'parameters.Add(New ReportParameter("semana", perio.Replace("Nomina del", "")))

        Me.ReportViewer1.ZoomMode = ZoomMode.Percent
        Me.ReportViewer1.ZoomPercent = 100
        ' Me.ReportViewer1.LocalReport.SetParameters(parameters)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
    End Sub

    Private Sub form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Dispose()
    End Sub
    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class