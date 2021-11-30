<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_de_Entrada
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.comprobante2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EntradasDataSet1 = New Sistemas_de_Entradas.EntradasDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.comprobante2TableAdapter = New Sistemas_de_Entradas.EntradasDataSet1TableAdapters.comprobante2TableAdapter()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        CType(Me.comprobante2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EntradasDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comprobante2BindingSource
        '
        Me.comprobante2BindingSource.DataMember = "comprobante2"
        Me.comprobante2BindingSource.DataSource = Me.EntradasDataSet1
        '
        'EntradasDataSet1
        '
        Me.EntradasDataSet1.DataSetName = "EntradasDataSet1"
        Me.EntradasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.comprobante2BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Sistemas_de_Entradas.report_entradas.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(889, 363)
        Me.ReportViewer1.TabIndex = 0
        '
        'comprobante2TableAdapter
        '
        Me.comprobante2TableAdapter.ClearBeforeFill = True
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(510, 112)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(100, 20)
        Me.txt_cliente.TabIndex = 1
        '
        'Reporte_de_Entrada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 363)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Reporte_de_Entrada"
        Me.Text = "Reporte_de_Entrada"
        CType(Me.comprobante2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EntradasDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents comprobante2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EntradasDataSet1 As Sistemas_de_Entradas.EntradasDataSet1
    Friend WithEvents comprobante2TableAdapter As Sistemas_de_Entradas.EntradasDataSet1TableAdapters.comprobante2TableAdapter
    Friend WithEvents txt_cliente As System.Windows.Forms.TextBox
End Class
