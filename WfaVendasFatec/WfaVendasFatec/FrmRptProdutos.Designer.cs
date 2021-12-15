
namespace WfaVendasFatec
{
  partial class FrmRptProdutos
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
      this.PC_PRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.VendasRelatorioDataSet = new WfaVendasFatec.VendasRelatorioDataSet();
      this.PC_PRODUTOTableAdapter = new WfaVendasFatec.VendasRelatorioDataSetTableAdapters.PC_PRODUTOTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.PC_PRODUTOBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.VendasRelatorioDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // reportViewer1
      // 
      this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      reportDataSource1.Name = "DataSet1";
      reportDataSource1.Value = this.PC_PRODUTOBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "WfaVendasFatec.rptProdutos.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.Size = new System.Drawing.Size(604, 351);
      this.reportViewer1.TabIndex = 0;
      // 
      // PC_PRODUTOBindingSource
      // 
      this.PC_PRODUTOBindingSource.DataMember = "PC_PRODUTO";
      this.PC_PRODUTOBindingSource.DataSource = this.VendasRelatorioDataSet;
      // 
      // VendasRelatorioDataSet
      // 
      this.VendasRelatorioDataSet.DataSetName = "VendasRelatorioDataSet";
      this.VendasRelatorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // PC_PRODUTOTableAdapter
      // 
      this.PC_PRODUTOTableAdapter.ClearBeforeFill = true;
      // 
      // FrmRptProdutos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(604, 351);
      this.Controls.Add(this.reportViewer1);
      this.Name = "FrmRptProdutos";
      this.Text = "FrmRptProdutos";
      this.Load += new System.EventHandler(this.FrmRptProdutos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.PC_PRODUTOBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.VendasRelatorioDataSet)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    private System.Windows.Forms.BindingSource PC_PRODUTOBindingSource;
    private VendasRelatorioDataSet VendasRelatorioDataSet;
    private VendasRelatorioDataSetTableAdapters.PC_PRODUTOTableAdapter PC_PRODUTOTableAdapter;
  }
}