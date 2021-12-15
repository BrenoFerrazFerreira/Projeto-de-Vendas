
namespace WfaVendasFatec
{
  partial class FrmCadProdutos
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
      System.Windows.Forms.Label cODPROLabel;
      System.Windows.Forms.Label dESCRICAOLabel;
      System.Windows.Forms.Label pRECOUNITLabel;
      System.Windows.Forms.Label qUANTIDADELabel1;
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnGravar = new System.Windows.Forms.Button();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnAlterar = new System.Windows.Forms.Button();
      this.btnIncluir = new System.Windows.Forms.Button();
      this.bDDataSet = new WfaVendasFatec.BDDataSet();
      this.pC_PRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.pC_PRODUTOTableAdapter = new WfaVendasFatec.BDDataSetTableAdapters.PC_PRODUTOTableAdapter();
      this.tableAdapterManager = new WfaVendasFatec.BDDataSetTableAdapters.TableAdapterManager();
      this.dgvProdutos = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.txtCodpro = new System.Windows.Forms.TextBox();
      this.txtDescricao = new System.Windows.Forms.TextBox();
      this.txtPrecounit = new System.Windows.Forms.TextBox();
      this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
      cODPROLabel = new System.Windows.Forms.Label();
      dESCRICAOLabel = new System.Windows.Forms.Label();
      pRECOUNITLabel = new System.Windows.Forms.Label();
      qUANTIDADELabel1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pC_PRODUTOBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
      this.SuspendLayout();
      // 
      // cODPROLabel
      // 
      cODPROLabel.AutoSize = true;
      cODPROLabel.Location = new System.Drawing.Point(12, 64);
      cODPROLabel.Name = "cODPROLabel";
      cODPROLabel.Size = new System.Drawing.Size(43, 13);
      cODPROLabel.TabIndex = 14;
      cODPROLabel.Text = "Código:";
      // 
      // dESCRICAOLabel
      // 
      dESCRICAOLabel.AutoSize = true;
      dESCRICAOLabel.Location = new System.Drawing.Point(12, 90);
      dESCRICAOLabel.Name = "dESCRICAOLabel";
      dESCRICAOLabel.Size = new System.Drawing.Size(58, 13);
      dESCRICAOLabel.TabIndex = 16;
      dESCRICAOLabel.Text = "Descrição:";
      // 
      // pRECOUNITLabel
      // 
      pRECOUNITLabel.AutoSize = true;
      pRECOUNITLabel.Location = new System.Drawing.Point(12, 142);
      pRECOUNITLabel.Name = "pRECOUNITLabel";
      pRECOUNITLabel.Size = new System.Drawing.Size(77, 13);
      pRECOUNITLabel.TabIndex = 20;
      pRECOUNITLabel.Text = "Preço Unitário:";
      // 
      // qUANTIDADELabel1
      // 
      qUANTIDADELabel1.AutoSize = true;
      qUANTIDADELabel1.Location = new System.Drawing.Point(12, 113);
      qUANTIDADELabel1.Name = "qUANTIDADELabel1";
      qUANTIDADELabel1.Size = new System.Drawing.Size(65, 13);
      qUANTIDADELabel1.TabIndex = 21;
      qUANTIDADELabel1.Text = "Quantidade:";
      // 
      // btnCancelar
      // 
      this.btnCancelar.Enabled = false;
      this.btnCancelar.Location = new System.Drawing.Point(443, 12);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(75, 23);
      this.btnCancelar.TabIndex = 13;
      this.btnCancelar.Text = "&Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = true;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnGravar
      // 
      this.btnGravar.Enabled = false;
      this.btnGravar.Location = new System.Drawing.Point(362, 12);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(75, 23);
      this.btnGravar.TabIndex = 12;
      this.btnGravar.Text = "&Gravar";
      this.btnGravar.UseVisualStyleBackColor = true;
      this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Location = new System.Drawing.Point(255, 12);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
      this.btnPesquisar.TabIndex = 11;
      this.btnPesquisar.Text = "&Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.Location = new System.Drawing.Point(174, 12);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(75, 23);
      this.btnExcluir.TabIndex = 10;
      this.btnExcluir.Text = "&Excluir";
      this.btnExcluir.UseVisualStyleBackColor = true;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnAlterar
      // 
      this.btnAlterar.Location = new System.Drawing.Point(93, 12);
      this.btnAlterar.Name = "btnAlterar";
      this.btnAlterar.Size = new System.Drawing.Size(75, 23);
      this.btnAlterar.TabIndex = 9;
      this.btnAlterar.Text = "&Alterar";
      this.btnAlterar.UseVisualStyleBackColor = true;
      this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
      // 
      // btnIncluir
      // 
      this.btnIncluir.Location = new System.Drawing.Point(12, 12);
      this.btnIncluir.Name = "btnIncluir";
      this.btnIncluir.Size = new System.Drawing.Size(75, 23);
      this.btnIncluir.TabIndex = 8;
      this.btnIncluir.Text = "&Incluir";
      this.btnIncluir.UseVisualStyleBackColor = true;
      this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
      // 
      // bDDataSet
      // 
      this.bDDataSet.DataSetName = "BDDataSet";
      this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // pC_PRODUTOBindingSource
      // 
      this.pC_PRODUTOBindingSource.DataMember = "PC_PRODUTO";
      this.pC_PRODUTOBindingSource.DataSource = this.bDDataSet;
      // 
      // pC_PRODUTOTableAdapter
      // 
      this.pC_PRODUTOTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.PC_CLIENTESTableAdapter = null;
      this.tableAdapterManager.PC_ITEMVENDATableAdapter = null;
      this.tableAdapterManager.PC_PRODUTOTableAdapter = this.pC_PRODUTOTableAdapter;
      this.tableAdapterManager.PC_VENDATableAdapter = null;
      this.tableAdapterManager.UpdateOrder = WfaVendasFatec.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // dgvProdutos
      // 
      this.dgvProdutos.AllowUserToAddRows = false;
      this.dgvProdutos.AllowUserToDeleteRows = false;
      this.dgvProdutos.AutoGenerateColumns = false;
      this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
      this.dgvProdutos.DataSource = this.pC_PRODUTOBindingSource;
      this.dgvProdutos.Location = new System.Drawing.Point(12, 191);
      this.dgvProdutos.MultiSelect = false;
      this.dgvProdutos.Name = "dgvProdutos";
      this.dgvProdutos.ReadOnly = true;
      this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvProdutos.Size = new System.Drawing.Size(506, 123);
      this.dgvProdutos.TabIndex = 14;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "CODPRO";
      this.dataGridViewTextBoxColumn1.HeaderText = "Código";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 70;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "DESCRICAO";
      this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 200;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "QUANTIDADE";
      this.dataGridViewTextBoxColumn3.HeaderText = "Quantidade";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 70;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "PRECOUNIT";
      dataGridViewCellStyle7.Format = "R$ #,###,##0.00";
      this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
      this.dataGridViewTextBoxColumn4.HeaderText = "Preço Unit.";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      // 
      // txtCodpro
      // 
      this.txtCodpro.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pC_PRODUTOBindingSource, "CODPRO", true));
      this.txtCodpro.Enabled = false;
      this.txtCodpro.Location = new System.Drawing.Point(99, 61);
      this.txtCodpro.Name = "txtCodpro";
      this.txtCodpro.Size = new System.Drawing.Size(76, 20);
      this.txtCodpro.TabIndex = 15;
      // 
      // txtDescricao
      // 
      this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pC_PRODUTOBindingSource, "DESCRICAO", true));
      this.txtDescricao.Enabled = false;
      this.txtDescricao.Location = new System.Drawing.Point(99, 87);
      this.txtDescricao.Name = "txtDescricao";
      this.txtDescricao.Size = new System.Drawing.Size(150, 20);
      this.txtDescricao.TabIndex = 17;
      // 
      // txtPrecounit
      // 
      this.txtPrecounit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pC_PRODUTOBindingSource, "PRECOUNIT", true));
      this.txtPrecounit.Enabled = false;
      this.txtPrecounit.Location = new System.Drawing.Point(99, 139);
      this.txtPrecounit.Name = "txtPrecounit";
      this.txtPrecounit.Size = new System.Drawing.Size(76, 20);
      this.txtPrecounit.TabIndex = 21;
      // 
      // nudQuantidade
      // 
      this.nudQuantidade.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.pC_PRODUTOBindingSource, "QUANTIDADE", true));
      this.nudQuantidade.Enabled = false;
      this.nudQuantidade.Location = new System.Drawing.Point(99, 113);
      this.nudQuantidade.Name = "nudQuantidade";
      this.nudQuantidade.Size = new System.Drawing.Size(76, 20);
      this.nudQuantidade.TabIndex = 22;
      // 
      // FrmCadProdutos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(538, 326);
      this.Controls.Add(qUANTIDADELabel1);
      this.Controls.Add(this.nudQuantidade);
      this.Controls.Add(cODPROLabel);
      this.Controls.Add(this.txtCodpro);
      this.Controls.Add(dESCRICAOLabel);
      this.Controls.Add(this.txtDescricao);
      this.Controls.Add(pRECOUNITLabel);
      this.Controls.Add(this.txtPrecounit);
      this.Controls.Add(this.dgvProdutos);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.btnPesquisar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnAlterar);
      this.Controls.Add(this.btnIncluir);
      this.Name = "FrmCadProdutos";
      this.Text = "Cadastro de Produtos";
      this.Load += new System.EventHandler(this.FrmCadProdutos_Load);
      ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pC_PRODUTOBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnGravar;
    private System.Windows.Forms.Button btnPesquisar;
    private System.Windows.Forms.Button btnExcluir;
    private System.Windows.Forms.Button btnAlterar;
    private System.Windows.Forms.Button btnIncluir;
    private BDDataSet bDDataSet;
    private System.Windows.Forms.BindingSource pC_PRODUTOBindingSource;
    private BDDataSetTableAdapters.PC_PRODUTOTableAdapter pC_PRODUTOTableAdapter;
    private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    private System.Windows.Forms.DataGridView dgvProdutos;
    private System.Windows.Forms.TextBox txtCodpro;
    private System.Windows.Forms.TextBox txtDescricao;
    private System.Windows.Forms.TextBox txtPrecounit;
    private System.Windows.Forms.NumericUpDown nudQuantidade;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
  }
}