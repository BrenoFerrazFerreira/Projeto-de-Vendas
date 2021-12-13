namespace WfaVendasFatec
{
    partial class frmRptClientes
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
      this.PC_CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.VendasRelatorioDataSet = new WfaVendasFatec.VendasRelatorioDataSet();
      this.PC_CLIENTESTableAdapter = new WfaVendasFatec.VendasRelatorioDataSetTableAdapters.PC_CLIENTESTableAdapter();
      ((System.ComponentModel.ISupportInitialize)(this.PC_CLIENTESBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.VendasRelatorioDataSet)).BeginInit();
      this.SuspendLayout();
      // 
      // reportViewer1
      // 
      reportDataSource1.Name = "DataSet1";
      reportDataSource1.Value = this.PC_CLIENTESBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "WfaVendasFatec.Report.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.ServerReport.ReportPath = "c:\\xampp";
      this.reportViewer1.Size = new System.Drawing.Size(964, 483);
      this.reportViewer1.TabIndex = 0;
      // 
      // PC_CLIENTESBindingSource
      // 
      this.PC_CLIENTESBindingSource.DataMember = "PC_CLIENTES";
      this.PC_CLIENTESBindingSource.DataSource = this.VendasRelatorioDataSet;
      // 
      // VendasRelatorioDataSet
      // 
      this.VendasRelatorioDataSet.DataSetName = "VendasRelatorioDataSet";
      this.VendasRelatorioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // PC_CLIENTESTableAdapter
      // 
      this.PC_CLIENTESTableAdapter.ClearBeforeFill = true;
      // 
      // frmRptClientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(966, 482);
      this.Controls.Add(this.reportViewer1);
      this.Name = "frmRptClientes";
      this.Text = "Relatório de Clientes";
      this.Load += new System.EventHandler(this.frmRptClientes_Load);
      ((System.ComponentModel.ISupportInitialize)(this.PC_CLIENTESBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.VendasRelatorioDataSet)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource PC_CLIENTESBindingSource;
        private VendasRelatorioDataSet VendasRelatorioDataSet;
        private VendasRelatorioDataSetTableAdapters.PC_CLIENTESTableAdapter PC_CLIENTESTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}