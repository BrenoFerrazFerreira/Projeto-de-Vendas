
namespace WfaVendasFatec
{
    partial class FrmCadVendas
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
      System.Windows.Forms.Label nUMVENDALabel;
      System.Windows.Forms.Label dATAVENDALabel;
      System.Windows.Forms.Label dATAENTREGALabel;
      System.Windows.Forms.Label cODCLILabel;
      System.Windows.Forms.Label oBSLabel;
      System.Windows.Forms.Label cODPROLabel;
      System.Windows.Forms.Label qUANTIDADELabel;
      System.Windows.Forms.Label pRECOUNITLabel;
      System.Windows.Forms.Label subTotalLabel;
      System.Windows.Forms.Label label1;
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnGravar = new System.Windows.Forms.Button();
      this.btnPesquisar = new System.Windows.Forms.Button();
      this.btnExcluir = new System.Windows.Forms.Button();
      this.btnAlterar = new System.Windows.Forms.Button();
      this.btnIncluir = new System.Windows.Forms.Button();
      this.btnSair = new System.Windows.Forms.Button();
      this.txtNumVenda = new System.Windows.Forms.TextBox();
      this.dtpDataVenda = new System.Windows.Forms.DateTimePicker();
      this.dtpDataEntrega = new System.Windows.Forms.DateTimePicker();
      this.cmbCodCli = new System.Windows.Forms.ComboBox();
      this.pCCLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.bDDataSet = new WfaVendasFatec.BDDataSet();
      this.txtObs = new System.Windows.Forms.TextBox();
      this.dgvVendas = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pC_VENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.btnTodos = new System.Windows.Forms.Button();
      this.dgvItem = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.pC_ITEMVENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.cmbProduto = new System.Windows.Forms.ComboBox();
      this.pCPRODUTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
      this.txtPrecoUnit = new System.Windows.Forms.TextBox();
      this.txtSubTotal = new System.Windows.Forms.TextBox();
      this.grpItens = new System.Windows.Forms.GroupBox();
      this.btnCancelarItem = new System.Windows.Forms.Button();
      this.btnGravarItem = new System.Windows.Forms.Button();
      this.btnPesquisarItem = new System.Windows.Forms.Button();
      this.btnExcluirItem = new System.Windows.Forms.Button();
      this.btnAlterarItem = new System.Windows.Forms.Button();
      this.btnIncluirItem = new System.Windows.Forms.Button();
      this.txtTotal = new System.Windows.Forms.TextBox();
      this.pC_VENDATableAdapter = new WfaVendasFatec.BDDataSetTableAdapters.PC_VENDATableAdapter();
      this.tableAdapterManager = new WfaVendasFatec.BDDataSetTableAdapters.TableAdapterManager();
      this.pC_CLIENTESTableAdapter = new WfaVendasFatec.BDDataSetTableAdapters.PC_CLIENTESTableAdapter();
      this.pC_ITEMVENDATableAdapter = new WfaVendasFatec.BDDataSetTableAdapters.PC_ITEMVENDATableAdapter();
      this.pC_PRODUTOTableAdapter = new WfaVendasFatec.BDDataSetTableAdapters.PC_PRODUTOTableAdapter();
      nUMVENDALabel = new System.Windows.Forms.Label();
      dATAVENDALabel = new System.Windows.Forms.Label();
      dATAENTREGALabel = new System.Windows.Forms.Label();
      cODCLILabel = new System.Windows.Forms.Label();
      oBSLabel = new System.Windows.Forms.Label();
      cODPROLabel = new System.Windows.Forms.Label();
      qUANTIDADELabel = new System.Windows.Forms.Label();
      pRECOUNITLabel = new System.Windows.Forms.Label();
      subTotalLabel = new System.Windows.Forms.Label();
      label1 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pCCLIENTESBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pC_VENDABindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pC_ITEMVENDABindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pCPRODUTOBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
      this.grpItens.SuspendLayout();
      this.SuspendLayout();
      // 
      // nUMVENDALabel
      // 
      nUMVENDALabel.AutoSize = true;
      nUMVENDALabel.Location = new System.Drawing.Point(32, 47);
      nUMVENDALabel.Name = "nUMVENDALabel";
      nUMVENDALabel.Size = new System.Drawing.Size(41, 13);
      nUMVENDALabel.TabIndex = 15;
      nUMVENDALabel.Text = "Venda:";
      // 
      // dATAVENDALabel
      // 
      dATAVENDALabel.AutoSize = true;
      dATAVENDALabel.Location = new System.Drawing.Point(32, 86);
      dATAVENDALabel.Name = "dATAVENDALabel";
      dATAVENDALabel.Size = new System.Drawing.Size(82, 13);
      dATAVENDALabel.TabIndex = 17;
      dATAVENDALabel.Text = "Data da Venda:";
      // 
      // dATAENTREGALabel
      // 
      dATAENTREGALabel.AutoSize = true;
      dATAENTREGALabel.Location = new System.Drawing.Point(155, 87);
      dATAENTREGALabel.Name = "dATAENTREGALabel";
      dATAENTREGALabel.Size = new System.Drawing.Size(88, 13);
      dATAENTREGALabel.TabIndex = 19;
      dATAENTREGALabel.Text = "Data da Entrega:";
      // 
      // cODCLILabel
      // 
      cODCLILabel.AutoSize = true;
      cODCLILabel.Location = new System.Drawing.Point(155, 47);
      cODCLILabel.Name = "cODCLILabel";
      cODCLILabel.Size = new System.Drawing.Size(42, 13);
      cODCLILabel.TabIndex = 21;
      cODCLILabel.Text = "Cliente:";
      // 
      // oBSLabel
      // 
      oBSLabel.AutoSize = true;
      oBSLabel.Location = new System.Drawing.Point(32, 131);
      oBSLabel.Name = "oBSLabel";
      oBSLabel.Size = new System.Drawing.Size(29, 13);
      oBSLabel.TabIndex = 23;
      oBSLabel.Text = "Obs:";
      // 
      // cODPROLabel
      // 
      cODPROLabel.AutoSize = true;
      cODPROLabel.Location = new System.Drawing.Point(3, 57);
      cODPROLabel.Name = "cODPROLabel";
      cODPROLabel.Size = new System.Drawing.Size(47, 13);
      cODPROLabel.TabIndex = 27;
      cODPROLabel.Text = "Produto:";
      // 
      // qUANTIDADELabel
      // 
      qUANTIDADELabel.AutoSize = true;
      qUANTIDADELabel.Location = new System.Drawing.Point(225, 57);
      qUANTIDADELabel.Name = "qUANTIDADELabel";
      qUANTIDADELabel.Size = new System.Drawing.Size(65, 13);
      qUANTIDADELabel.TabIndex = 29;
      qUANTIDADELabel.Text = "Quantidade:";
      // 
      // pRECOUNITLabel
      // 
      pRECOUNITLabel.AutoSize = true;
      pRECOUNITLabel.Location = new System.Drawing.Point(293, 58);
      pRECOUNITLabel.Name = "pRECOUNITLabel";
      pRECOUNITLabel.Size = new System.Drawing.Size(77, 13);
      pRECOUNITLabel.TabIndex = 31;
      pRECOUNITLabel.Text = "Preço Unitário:";
      // 
      // subTotalLabel
      // 
      subTotalLabel.AutoSize = true;
      subTotalLabel.Location = new System.Drawing.Point(420, 58);
      subTotalLabel.Name = "subTotalLabel";
      subTotalLabel.Size = new System.Drawing.Size(56, 13);
      subTotalLabel.TabIndex = 33;
      subTotalLabel.Text = "Sub Total:";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new System.Drawing.Point(598, 57);
      label1.Name = "label1";
      label1.Size = new System.Drawing.Size(34, 13);
      label1.TabIndex = 33;
      label1.Text = "Total:";
      // 
      // btnCancelar
      // 
      this.btnCancelar.Enabled = false;
      this.btnCancelar.Location = new System.Drawing.Point(454, 12);
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
      this.btnGravar.Location = new System.Drawing.Point(365, 12);
      this.btnGravar.Name = "btnGravar";
      this.btnGravar.Size = new System.Drawing.Size(75, 23);
      this.btnGravar.TabIndex = 12;
      this.btnGravar.Text = "&Gravar";
      this.btnGravar.UseVisualStyleBackColor = true;
      this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
      // 
      // btnPesquisar
      // 
      this.btnPesquisar.Location = new System.Drawing.Point(277, 12);
      this.btnPesquisar.Name = "btnPesquisar";
      this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
      this.btnPesquisar.TabIndex = 11;
      this.btnPesquisar.Text = "&Pesquisar";
      this.btnPesquisar.UseVisualStyleBackColor = true;
      this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
      // 
      // btnExcluir
      // 
      this.btnExcluir.Location = new System.Drawing.Point(190, 12);
      this.btnExcluir.Name = "btnExcluir";
      this.btnExcluir.Size = new System.Drawing.Size(75, 23);
      this.btnExcluir.TabIndex = 10;
      this.btnExcluir.Text = "&Excluir";
      this.btnExcluir.UseVisualStyleBackColor = true;
      this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
      // 
      // btnAlterar
      // 
      this.btnAlterar.Location = new System.Drawing.Point(102, 12);
      this.btnAlterar.Name = "btnAlterar";
      this.btnAlterar.Size = new System.Drawing.Size(75, 23);
      this.btnAlterar.TabIndex = 9;
      this.btnAlterar.Text = "&Alterar";
      this.btnAlterar.UseVisualStyleBackColor = true;
      this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
      // 
      // btnIncluir
      // 
      this.btnIncluir.Location = new System.Drawing.Point(14, 12);
      this.btnIncluir.Name = "btnIncluir";
      this.btnIncluir.Size = new System.Drawing.Size(75, 23);
      this.btnIncluir.TabIndex = 8;
      this.btnIncluir.Text = "&Incluir";
      this.btnIncluir.UseVisualStyleBackColor = true;
      this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
      // 
      // btnSair
      // 
      this.btnSair.Location = new System.Drawing.Point(657, 12);
      this.btnSair.Name = "btnSair";
      this.btnSair.Size = new System.Drawing.Size(75, 23);
      this.btnSair.TabIndex = 14;
      this.btnSair.Text = "Sai&r";
      this.btnSair.UseVisualStyleBackColor = true;
      this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
      // 
      // txtNumVenda
      // 
      this.txtNumVenda.Enabled = false;
      this.txtNumVenda.Location = new System.Drawing.Point(35, 63);
      this.txtNumVenda.Name = "txtNumVenda";
      this.txtNumVenda.ReadOnly = true;
      this.txtNumVenda.Size = new System.Drawing.Size(107, 20);
      this.txtNumVenda.TabIndex = 16;
      // 
      // dtpDataVenda
      // 
      this.dtpDataVenda.CustomFormat = "dd/MM/yyyy";
      this.dtpDataVenda.Enabled = false;
      this.dtpDataVenda.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpDataVenda.Location = new System.Drawing.Point(35, 102);
      this.dtpDataVenda.Name = "dtpDataVenda";
      this.dtpDataVenda.Size = new System.Drawing.Size(107, 20);
      this.dtpDataVenda.TabIndex = 18;
      // 
      // dtpDataEntrega
      // 
      this.dtpDataEntrega.CustomFormat = "dd/MM/yyyy";
      this.dtpDataEntrega.Enabled = false;
      this.dtpDataEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpDataEntrega.Location = new System.Drawing.Point(158, 103);
      this.dtpDataEntrega.Name = "dtpDataEntrega";
      this.dtpDataEntrega.Size = new System.Drawing.Size(107, 20);
      this.dtpDataEntrega.TabIndex = 20;
      // 
      // cmbCodCli
      // 
      this.cmbCodCli.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cmbCodCli.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cmbCodCli.DataSource = this.pCCLIENTESBindingSource;
      this.cmbCodCli.DisplayMember = "NOME";
      this.cmbCodCli.Enabled = false;
      this.cmbCodCli.FormattingEnabled = true;
      this.cmbCodCli.Location = new System.Drawing.Point(158, 63);
      this.cmbCodCli.Name = "cmbCodCli";
      this.cmbCodCli.Size = new System.Drawing.Size(304, 21);
      this.cmbCodCli.TabIndex = 22;
      this.cmbCodCli.ValueMember = "CODCLI";
      // 
      // pCCLIENTESBindingSource
      // 
      this.pCCLIENTESBindingSource.DataMember = "PC_CLIENTES";
      this.pCCLIENTESBindingSource.DataSource = this.bDDataSet;
      // 
      // bDDataSet
      // 
      this.bDDataSet.DataSetName = "BDDataSet";
      this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // txtObs
      // 
      this.txtObs.Enabled = false;
      this.txtObs.Location = new System.Drawing.Point(67, 128);
      this.txtObs.Multiline = true;
      this.txtObs.Name = "txtObs";
      this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.txtObs.Size = new System.Drawing.Size(395, 69);
      this.txtObs.TabIndex = 24;
      // 
      // dgvVendas
      // 
      this.dgvVendas.AllowUserToAddRows = false;
      this.dgvVendas.AllowUserToDeleteRows = false;
      this.dgvVendas.AutoGenerateColumns = false;
      this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
      this.dgvVendas.DataSource = this.pC_VENDABindingSource;
      this.dgvVendas.Location = new System.Drawing.Point(10, 213);
      this.dgvVendas.MultiSelect = false;
      this.dgvVendas.Name = "dgvVendas";
      this.dgvVendas.ReadOnly = true;
      this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvVendas.Size = new System.Drawing.Size(751, 89);
      this.dgvVendas.TabIndex = 24;
      this.dgvVendas.SelectionChanged += new System.EventHandler(this.dgvVendas_SelectionChanged);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "NUMVENDA";
      this.dataGridViewTextBoxColumn1.HeaderText = "Venda";
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 50;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.DataPropertyName = "CODCLI";
      this.dataGridViewTextBoxColumn4.HeaderText = "Cliente";
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      this.dataGridViewTextBoxColumn4.ReadOnly = true;
      this.dataGridViewTextBoxColumn4.Width = 50;
      // 
      // dataGridViewTextBoxColumn6
      // 
      this.dataGridViewTextBoxColumn6.DataPropertyName = "NOME";
      this.dataGridViewTextBoxColumn6.HeaderText = "Nome";
      this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
      this.dataGridViewTextBoxColumn6.ReadOnly = true;
      this.dataGridViewTextBoxColumn6.Width = 220;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "DATAVENDA";
      dataGridViewCellStyle1.Format = "dd/MM/yyyy";
      this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridViewTextBoxColumn2.HeaderText = "Data da Venda";
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.ReadOnly = true;
      this.dataGridViewTextBoxColumn2.Width = 110;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "DATAENTREGA";
      dataGridViewCellStyle2.Format = "dd/MM/yyyy";
      this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridViewTextBoxColumn3.HeaderText = "Data da Entrega";
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.ReadOnly = true;
      this.dataGridViewTextBoxColumn3.Width = 110;
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.DataPropertyName = "OBS";
      this.dataGridViewTextBoxColumn5.HeaderText = "Obs";
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.ReadOnly = true;
      this.dataGridViewTextBoxColumn5.Width = 160;
      // 
      // pC_VENDABindingSource
      // 
      this.pC_VENDABindingSource.DataMember = "PC_VENDA";
      this.pC_VENDABindingSource.DataSource = this.bDDataSet;
      // 
      // btnTodos
      // 
      this.btnTodos.Location = new System.Drawing.Point(657, 174);
      this.btnTodos.Name = "btnTodos";
      this.btnTodos.Size = new System.Drawing.Size(75, 23);
      this.btnTodos.TabIndex = 25;
      this.btnTodos.Text = "&Todos";
      this.btnTodos.UseVisualStyleBackColor = true;
      this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
      // 
      // dgvItem
      // 
      this.dgvItem.AllowUserToAddRows = false;
      this.dgvItem.AllowUserToDeleteRows = false;
      this.dgvItem.AutoGenerateColumns = false;
      this.dgvItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
      this.dgvItem.DataSource = this.pC_ITEMVENDABindingSource;
      this.dgvItem.Location = new System.Drawing.Point(10, 427);
      this.dgvItem.MultiSelect = false;
      this.dgvItem.Name = "dgvItem";
      this.dgvItem.ReadOnly = true;
      this.dgvItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvItem.Size = new System.Drawing.Size(751, 105);
      this.dgvItem.TabIndex = 25;
      // 
      // dataGridViewTextBoxColumn8
      // 
      this.dataGridViewTextBoxColumn8.DataPropertyName = "CODPRO";
      this.dataGridViewTextBoxColumn8.HeaderText = "Produto";
      this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
      this.dataGridViewTextBoxColumn8.ReadOnly = true;
      this.dataGridViewTextBoxColumn8.Width = 70;
      // 
      // dataGridViewTextBoxColumn12
      // 
      this.dataGridViewTextBoxColumn12.DataPropertyName = "DESCRICAO";
      this.dataGridViewTextBoxColumn12.HeaderText = "Descrição";
      this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
      this.dataGridViewTextBoxColumn12.ReadOnly = true;
      this.dataGridViewTextBoxColumn12.Width = 220;
      // 
      // dataGridViewTextBoxColumn9
      // 
      this.dataGridViewTextBoxColumn9.DataPropertyName = "QUANTIDADE";
      this.dataGridViewTextBoxColumn9.HeaderText = "Quantidade";
      this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
      this.dataGridViewTextBoxColumn9.ReadOnly = true;
      this.dataGridViewTextBoxColumn9.Width = 80;
      // 
      // dataGridViewTextBoxColumn10
      // 
      this.dataGridViewTextBoxColumn10.DataPropertyName = "PRECOUNIT";
      dataGridViewCellStyle3.Format = "R$ #,###,##0.00";
      dataGridViewCellStyle3.NullValue = null;
      this.dataGridViewTextBoxColumn10.DefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridViewTextBoxColumn10.HeaderText = "Preço Unit.";
      this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
      this.dataGridViewTextBoxColumn10.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn11
      // 
      this.dataGridViewTextBoxColumn11.DataPropertyName = "SubTotal";
      dataGridViewCellStyle4.Format = "R$ #,###,##0.00";
      this.dataGridViewTextBoxColumn11.DefaultCellStyle = dataGridViewCellStyle4;
      this.dataGridViewTextBoxColumn11.HeaderText = "SubTotal";
      this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
      this.dataGridViewTextBoxColumn11.ReadOnly = true;
      // 
      // pC_ITEMVENDABindingSource
      // 
      this.pC_ITEMVENDABindingSource.DataMember = "PC_ITEMVENDA";
      this.pC_ITEMVENDABindingSource.DataSource = this.bDDataSet;
      // 
      // cmbProduto
      // 
      this.cmbProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
      this.cmbProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cmbProduto.DataSource = this.pCPRODUTOBindingSource;
      this.cmbProduto.DisplayMember = "DESCRICAO";
      this.cmbProduto.FormattingEnabled = true;
      this.cmbProduto.Location = new System.Drawing.Point(6, 73);
      this.cmbProduto.Name = "cmbProduto";
      this.cmbProduto.Size = new System.Drawing.Size(216, 21);
      this.cmbProduto.TabIndex = 28;
      this.cmbProduto.ValueMember = "CODPRO";
      this.cmbProduto.SelectedIndexChanged += new System.EventHandler(this.cmbProduto_SelectedIndexChanged);
      // 
      // pCPRODUTOBindingSource
      // 
      this.pCPRODUTOBindingSource.DataMember = "PC_PRODUTO";
      this.pCPRODUTOBindingSource.DataSource = this.bDDataSet;
      // 
      // nudQuantidade
      // 
      this.nudQuantidade.Location = new System.Drawing.Point(228, 74);
      this.nudQuantidade.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.nudQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudQuantidade.Name = "nudQuantidade";
      this.nudQuantidade.Size = new System.Drawing.Size(62, 20);
      this.nudQuantidade.TabIndex = 30;
      this.nudQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudQuantidade.ValueChanged += new System.EventHandler(this.nudQuantidade_ValueChanged);
      // 
      // txtPrecoUnit
      // 
      this.txtPrecoUnit.Location = new System.Drawing.Point(296, 74);
      this.txtPrecoUnit.Name = "txtPrecoUnit";
      this.txtPrecoUnit.ReadOnly = true;
      this.txtPrecoUnit.Size = new System.Drawing.Size(121, 20);
      this.txtPrecoUnit.TabIndex = 32;
      // 
      // txtSubTotal
      // 
      this.txtSubTotal.Location = new System.Drawing.Point(423, 74);
      this.txtSubTotal.Name = "txtSubTotal";
      this.txtSubTotal.ReadOnly = true;
      this.txtSubTotal.Size = new System.Drawing.Size(121, 20);
      this.txtSubTotal.TabIndex = 34;
      // 
      // grpItens
      // 
      this.grpItens.Controls.Add(this.btnCancelarItem);
      this.grpItens.Controls.Add(this.btnGravarItem);
      this.grpItens.Controls.Add(this.btnPesquisarItem);
      this.grpItens.Controls.Add(this.btnExcluirItem);
      this.grpItens.Controls.Add(this.btnAlterarItem);
      this.grpItens.Controls.Add(this.btnIncluirItem);
      this.grpItens.Controls.Add(this.cmbProduto);
      this.grpItens.Controls.Add(pRECOUNITLabel);
      this.grpItens.Controls.Add(qUANTIDADELabel);
      this.grpItens.Controls.Add(this.txtPrecoUnit);
      this.grpItens.Controls.Add(label1);
      this.grpItens.Controls.Add(subTotalLabel);
      this.grpItens.Controls.Add(cODPROLabel);
      this.grpItens.Controls.Add(this.txtTotal);
      this.grpItens.Controls.Add(this.txtSubTotal);
      this.grpItens.Controls.Add(this.nudQuantidade);
      this.grpItens.Location = new System.Drawing.Point(10, 308);
      this.grpItens.Name = "grpItens";
      this.grpItens.Size = new System.Drawing.Size(751, 103);
      this.grpItens.TabIndex = 37;
      this.grpItens.TabStop = false;
      this.grpItens.Text = "Itens da Venda:";
      // 
      // btnCancelarItem
      // 
      this.btnCancelarItem.Enabled = false;
      this.btnCancelarItem.Location = new System.Drawing.Point(444, 19);
      this.btnCancelarItem.Name = "btnCancelarItem";
      this.btnCancelarItem.Size = new System.Drawing.Size(75, 23);
      this.btnCancelarItem.TabIndex = 40;
      this.btnCancelarItem.Text = "&Cancelar";
      this.btnCancelarItem.UseVisualStyleBackColor = true;
      this.btnCancelarItem.Click += new System.EventHandler(this.btnCancelarItem_Click);
      // 
      // btnGravarItem
      // 
      this.btnGravarItem.Enabled = false;
      this.btnGravarItem.Location = new System.Drawing.Point(355, 19);
      this.btnGravarItem.Name = "btnGravarItem";
      this.btnGravarItem.Size = new System.Drawing.Size(75, 23);
      this.btnGravarItem.TabIndex = 39;
      this.btnGravarItem.Text = "&Gravar";
      this.btnGravarItem.UseVisualStyleBackColor = true;
      this.btnGravarItem.Click += new System.EventHandler(this.btnGravarItem_Click);
      // 
      // btnPesquisarItem
      // 
      this.btnPesquisarItem.Location = new System.Drawing.Point(267, 19);
      this.btnPesquisarItem.Name = "btnPesquisarItem";
      this.btnPesquisarItem.Size = new System.Drawing.Size(75, 23);
      this.btnPesquisarItem.TabIndex = 38;
      this.btnPesquisarItem.Text = "&Pesquisar";
      this.btnPesquisarItem.UseVisualStyleBackColor = true;
      this.btnPesquisarItem.Click += new System.EventHandler(this.btnPesquisarItem_Click);
      // 
      // btnExcluirItem
      // 
      this.btnExcluirItem.Location = new System.Drawing.Point(180, 19);
      this.btnExcluirItem.Name = "btnExcluirItem";
      this.btnExcluirItem.Size = new System.Drawing.Size(75, 23);
      this.btnExcluirItem.TabIndex = 37;
      this.btnExcluirItem.Text = "&Excluir";
      this.btnExcluirItem.UseVisualStyleBackColor = true;
      this.btnExcluirItem.Click += new System.EventHandler(this.btnExcluirItem_Click);
      // 
      // btnAlterarItem
      // 
      this.btnAlterarItem.Location = new System.Drawing.Point(92, 19);
      this.btnAlterarItem.Name = "btnAlterarItem";
      this.btnAlterarItem.Size = new System.Drawing.Size(75, 23);
      this.btnAlterarItem.TabIndex = 36;
      this.btnAlterarItem.Text = "&Alterar";
      this.btnAlterarItem.UseVisualStyleBackColor = true;
      this.btnAlterarItem.Click += new System.EventHandler(this.btnAlterarItem_Click);
      // 
      // btnIncluirItem
      // 
      this.btnIncluirItem.Location = new System.Drawing.Point(4, 19);
      this.btnIncluirItem.Name = "btnIncluirItem";
      this.btnIncluirItem.Size = new System.Drawing.Size(75, 23);
      this.btnIncluirItem.TabIndex = 35;
      this.btnIncluirItem.Text = "&Incluir";
      this.btnIncluirItem.UseVisualStyleBackColor = true;
      this.btnIncluirItem.Click += new System.EventHandler(this.btnIncluirItem_Click);
      // 
      // txtTotal
      // 
      this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtTotal.ForeColor = System.Drawing.Color.Red;
      this.txtTotal.Location = new System.Drawing.Point(601, 73);
      this.txtTotal.Name = "txtTotal";
      this.txtTotal.ReadOnly = true;
      this.txtTotal.Size = new System.Drawing.Size(121, 20);
      this.txtTotal.TabIndex = 34;
      // 
      // pC_VENDATableAdapter
      // 
      this.pC_VENDATableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.PC_CLIENTESTableAdapter = null;
      this.tableAdapterManager.PC_ITEMVENDATableAdapter = null;
      this.tableAdapterManager.PC_PRODUTOTableAdapter = null;
      this.tableAdapterManager.PC_VENDATableAdapter = this.pC_VENDATableAdapter;
      this.tableAdapterManager.UpdateOrder = WfaVendasFatec.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // pC_CLIENTESTableAdapter
      // 
      this.pC_CLIENTESTableAdapter.ClearBeforeFill = true;
      // 
      // pC_ITEMVENDATableAdapter
      // 
      this.pC_ITEMVENDATableAdapter.ClearBeforeFill = true;
      // 
      // pC_PRODUTOTableAdapter
      // 
      this.pC_PRODUTOTableAdapter.ClearBeforeFill = true;
      // 
      // FrmCadVendas
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(768, 552);
      this.Controls.Add(this.grpItens);
      this.Controls.Add(this.dgvItem);
      this.Controls.Add(this.btnTodos);
      this.Controls.Add(this.dgvVendas);
      this.Controls.Add(nUMVENDALabel);
      this.Controls.Add(this.txtNumVenda);
      this.Controls.Add(dATAVENDALabel);
      this.Controls.Add(this.dtpDataVenda);
      this.Controls.Add(dATAENTREGALabel);
      this.Controls.Add(this.dtpDataEntrega);
      this.Controls.Add(cODCLILabel);
      this.Controls.Add(this.cmbCodCli);
      this.Controls.Add(oBSLabel);
      this.Controls.Add(this.txtObs);
      this.Controls.Add(this.btnSair);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.btnGravar);
      this.Controls.Add(this.btnPesquisar);
      this.Controls.Add(this.btnExcluir);
      this.Controls.Add(this.btnAlterar);
      this.Controls.Add(this.btnIncluir);
      this.Name = "FrmCadVendas";
      this.Text = "Cadastro de Vendas";
      this.Load += new System.EventHandler(this.FrmCadVendas_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pCCLIENTESBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pC_VENDABindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgvItem)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pC_ITEMVENDABindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pCPRODUTOBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
      this.grpItens.ResumeLayout(false);
      this.grpItens.PerformLayout();
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
        private System.Windows.Forms.Button btnSair;
        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource pC_VENDABindingSource;
        private BDDataSetTableAdapters.PC_VENDATableAdapter pC_VENDATableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtNumVenda;
        private System.Windows.Forms.DateTimePicker dtpDataVenda;
        private System.Windows.Forms.DateTimePicker dtpDataEntrega;
        private System.Windows.Forms.ComboBox cmbCodCli;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.BindingSource pCCLIENTESBindingSource;
        private BDDataSetTableAdapters.PC_CLIENTESTableAdapter pC_CLIENTESTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.BindingSource pC_ITEMVENDABindingSource;
        private BDDataSetTableAdapters.PC_ITEMVENDATableAdapter pC_ITEMVENDATableAdapter;
        private System.Windows.Forms.DataGridView dgvItem;
        private System.Windows.Forms.ComboBox cmbProduto;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtPrecoUnit;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.GroupBox grpItens;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCancelarItem;
        private System.Windows.Forms.Button btnGravarItem;
        private System.Windows.Forms.Button btnPesquisarItem;
        private System.Windows.Forms.Button btnExcluirItem;
        private System.Windows.Forms.Button btnAlterarItem;
        private System.Windows.Forms.Button btnIncluirItem;
        private System.Windows.Forms.BindingSource pCPRODUTOBindingSource;
        private BDDataSetTableAdapters.PC_PRODUTOTableAdapter pC_PRODUTOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}