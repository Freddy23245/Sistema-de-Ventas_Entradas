Public Class Reporte_de_Entrada

    Private Sub Reporte_de_Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'EntradasDataSet1.comprobante2' Puede moverla o quitarla según sea necesario.
        EntradasDataSet1.EnforceConstraints = False
        Me.comprobante2TableAdapter.Fill(Me.EntradasDataSet1.comprobante2, id_cliente:=txt_cliente.Text)

        Me.ReportViewer1.RefreshReport()
        txt_cliente.Visible = False
    End Sub


    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class