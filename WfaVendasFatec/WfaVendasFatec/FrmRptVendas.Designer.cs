
namespace WfaVendasFatec
{
  partial class FrmRptVendas
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      this.VendasRelatorioDataSet = new WfaVendasFatec.VendasRelatorioDataSet();
      this.PC_VENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.PC_VENDATableAdapter = new WfaVendasFatec.VendasRelatorioDataSetTableAdapters.PC_VENDATableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.VendasRelatorioDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.PC_VENDABindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // reportViewer1
      // 
      this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      reportDataSource1.Name = "DataSet1";
      reportDataSource1.Value = this.PC_VENDABindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "WfaVendasFatec.RptVendas.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.Size = new System.Drawing.Size(957, 514);
      this.reportViewer1.TabIndex = 0;
      // 
      // VendasRelatorioDataSet
      // 
      this.VendasRelatorioDataSet.DataSetName = "VendasRelatorioDataSet";
      this.VendasRelatorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // PC_VENDABindingSource
      // 
      this.PC_VENDABindingSource.DataMember = "PC_VENDA";
      this.PC_VENDABindingSource.DataSource = this.VendasRelatorioDataSet;
      // 
      // PC_VENDATableAdapter
      // 
      this.PC_VENDATableAdapter.ClearBeforeFill = true;
      // 
      // FrmRptVendas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(957, 514);
      this.Controls.Add(this.reportViewer1);
      this.Name = "FrmRptVendas";
      this.Text = "Relatório de Vendas";
      this.Load += new System.EventHandler(this.FrmRptVendas_Load);
      ((System.ComponentModel.ISupportInitialize)(this.VendasRelatorioDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.PC_VENDABindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private System.Windows.Forms.BindingSource PC_VENDABindingSource;
    private VendasRelatorioDataSet VendasRelatorioDataSet;
    private VendasRelatorioDataSetTableAdapters.PC_VENDATableAdapter PC_VENDATableAdapter;
  }
}