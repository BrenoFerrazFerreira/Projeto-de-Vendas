
namespace WfaVendasFatec
{
    partial class FrmCadClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cODCLILabel;
            System.Windows.Forms.Label nOMELabel;
            System.Windows.Forms.Label eNDERECOLabel;
            System.Windows.Forms.Label cIDADELabel;
            System.Windows.Forms.Label bAIRROLabel;
            System.Windows.Forms.Label uFLabel;
            System.Windows.Forms.Label cEPLabel;
            System.Windows.Forms.Label tELEFONELabel;
            System.Windows.Forms.Label dATANASCLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtCodcli = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.mskUf = new System.Windows.Forms.MaskedTextBox();
            this.mskCep = new System.Windows.Forms.MaskedTextBox();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.cODCLIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eNDERECODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDADEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIRRODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATANASCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pC_CLIENTESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDDataSet = new WfaVendasFatec.BDDataSet();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pC_CLIENTESTableAdapter = new WfaVendasFatec.BDDataSetTableAdapters.PC_CLIENTESTableAdapter();
            this.tableAdapterManager = new WfaVendasFatec.BDDataSetTableAdapters.TableAdapterManager();
            this.pC_VENDABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pC_VENDATableAdapter = new WfaVendasFatec.BDDataSetTableAdapters.PC_VENDATableAdapter();
            cODCLILabel = new System.Windows.Forms.Label();
            nOMELabel = new System.Windows.Forms.Label();
            eNDERECOLabel = new System.Windows.Forms.Label();
            cIDADELabel = new System.Windows.Forms.Label();
            bAIRROLabel = new System.Windows.Forms.Label();
            uFLabel = new System.Windows.Forms.Label();
            cEPLabel = new System.Windows.Forms.Label();
            tELEFONELabel = new System.Windows.Forms.Label();
            dATANASCLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_CLIENTESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_VENDABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cODCLILabel
            // 
            cODCLILabel.AutoSize = true;
            cODCLILabel.Location = new System.Drawing.Point(9, 57);
            cODCLILabel.Name = "cODCLILabel";
            cODCLILabel.Size = new System.Drawing.Size(43, 13);
            cODCLILabel.TabIndex = 1;
            cODCLILabel.Text = "Código:";
            // 
            // nOMELabel
            // 
            nOMELabel.AutoSize = true;
            nOMELabel.Location = new System.Drawing.Point(9, 83);
            nOMELabel.Name = "nOMELabel";
            nOMELabel.Size = new System.Drawing.Size(38, 13);
            nOMELabel.TabIndex = 3;
            nOMELabel.Text = "Nome:";
            // 
            // eNDERECOLabel
            // 
            eNDERECOLabel.AutoSize = true;
            eNDERECOLabel.Location = new System.Drawing.Point(9, 109);
            eNDERECOLabel.Name = "eNDERECOLabel";
            eNDERECOLabel.Size = new System.Drawing.Size(56, 13);
            eNDERECOLabel.TabIndex = 5;
            eNDERECOLabel.Text = "Endereço:";
            // 
            // cIDADELabel
            // 
            cIDADELabel.AutoSize = true;
            cIDADELabel.Location = new System.Drawing.Point(9, 135);
            cIDADELabel.Name = "cIDADELabel";
            cIDADELabel.Size = new System.Drawing.Size(43, 13);
            cIDADELabel.TabIndex = 7;
            cIDADELabel.Text = "Cidade:";
            // 
            // bAIRROLabel
            // 
            bAIRROLabel.AutoSize = true;
            bAIRROLabel.Location = new System.Drawing.Point(9, 161);
            bAIRROLabel.Name = "bAIRROLabel";
            bAIRROLabel.Size = new System.Drawing.Size(37, 13);
            bAIRROLabel.TabIndex = 9;
            bAIRROLabel.Text = "Bairro:";
            // 
            // uFLabel
            // 
            uFLabel.AutoSize = true;
            uFLabel.Location = new System.Drawing.Point(9, 187);
            uFLabel.Name = "uFLabel";
            uFLabel.Size = new System.Drawing.Size(43, 13);
            uFLabel.TabIndex = 11;
            uFLabel.Text = "Estado:";
            // 
            // cEPLabel
            // 
            cEPLabel.AutoSize = true;
            cEPLabel.Location = new System.Drawing.Point(9, 213);
            cEPLabel.Name = "cEPLabel";
            cEPLabel.Size = new System.Drawing.Size(29, 13);
            cEPLabel.TabIndex = 13;
            cEPLabel.Text = "Cep:";
            // 
            // tELEFONELabel
            // 
            tELEFONELabel.AutoSize = true;
            tELEFONELabel.Location = new System.Drawing.Point(9, 239);
            tELEFONELabel.Name = "tELEFONELabel";
            tELEFONELabel.Size = new System.Drawing.Size(52, 13);
            tELEFONELabel.TabIndex = 15;
            tELEFONELabel.Text = "Telefone:";
            // 
            // dATANASCLabel
            // 
            dATANASCLabel.AutoSize = true;
            dATANASCLabel.Location = new System.Drawing.Point(9, 266);
            dATANASCLabel.Name = "dATANASCLabel";
            dATANASCLabel.Size = new System.Drawing.Size(64, 13);
            dATANASCLabel.TabIndex = 17;
            dATANASCLabel.Text = "Data Nasc.:";
            // 
            // txtCodcli
            // 
            this.txtCodcli.Enabled = false;
            this.txtCodcli.Location = new System.Drawing.Point(79, 54);
            this.txtCodcli.Name = "txtCodcli";
            this.txtCodcli.Size = new System.Drawing.Size(79, 20);
            this.txtCodcli.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(79, 80);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(264, 20);
            this.txtNome.TabIndex = 9;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Enabled = false;
            this.txtEndereco.Location = new System.Drawing.Point(79, 106);
            this.txtEndereco.MaxLength = 50;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(264, 20);
            this.txtEndereco.TabIndex = 10;
            // 
            // txtCidade
            // 
            this.txtCidade.Enabled = false;
            this.txtCidade.Location = new System.Drawing.Point(79, 132);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(200, 20);
            this.txtCidade.TabIndex = 11;
            // 
            // txtBairro
            // 
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(79, 158);
            this.txtBairro.MaxLength = 30;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(200, 20);
            this.txtBairro.TabIndex = 12;
            // 
            // mskUf
            // 
            this.mskUf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskUf.Enabled = false;
            this.mskUf.Location = new System.Drawing.Point(79, 184);
            this.mskUf.Mask = ">LL";
            this.mskUf.Name = "mskUf";
            this.mskUf.Size = new System.Drawing.Size(54, 20);
            this.mskUf.TabIndex = 13;
            this.mskUf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskCep
            // 
            this.mskCep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskCep.Enabled = false;
            this.mskCep.Location = new System.Drawing.Point(79, 210);
            this.mskCep.Mask = "00000-000";
            this.mskCep.Name = "mskCep";
            this.mskCep.Size = new System.Drawing.Size(96, 20);
            this.mskCep.TabIndex = 14;
            this.mskCep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskTelefone
            // 
            this.mskTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mskTelefone.Enabled = false;
            this.mskTelefone.Location = new System.Drawing.Point(79, 236);
            this.mskTelefone.Mask = "(00) 90000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(110, 20);
            this.mskTelefone.TabIndex = 15;
            this.mskTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.CustomFormat = "dd/MM/yyyy";
            this.dtpDataNasc.Enabled = false;
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataNasc.Location = new System.Drawing.Point(79, 262);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(96, 20);
            this.dtpDataNasc.TabIndex = 16;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.AutoGenerateColumns = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cODCLIDataGridViewTextBoxColumn,
            this.nOMEDataGridViewTextBoxColumn,
            this.eNDERECODataGridViewTextBoxColumn,
            this.cIDADEDataGridViewTextBoxColumn,
            this.bAIRRODataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.tELEFONEDataGridViewTextBoxColumn,
            this.dATANASCDataGridViewTextBoxColumn});
            this.dgvClientes.DataSource = this.pC_CLIENTESBindingSource;
            this.dgvClientes.Location = new System.Drawing.Point(12, 324);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1002, 136);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClientes_CellFormatting_1);
            // 
            // cODCLIDataGridViewTextBoxColumn
            // 
            this.cODCLIDataGridViewTextBoxColumn.DataPropertyName = "CODCLI";
            this.cODCLIDataGridViewTextBoxColumn.HeaderText = "Código";
            this.cODCLIDataGridViewTextBoxColumn.Name = "cODCLIDataGridViewTextBoxColumn";
            this.cODCLIDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMEDataGridViewTextBoxColumn
            // 
            this.nOMEDataGridViewTextBoxColumn.DataPropertyName = "NOME";
            this.nOMEDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nOMEDataGridViewTextBoxColumn.Name = "nOMEDataGridViewTextBoxColumn";
            this.nOMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eNDERECODataGridViewTextBoxColumn
            // 
            this.eNDERECODataGridViewTextBoxColumn.DataPropertyName = "ENDERECO";
            this.eNDERECODataGridViewTextBoxColumn.HeaderText = "Eendereço";
            this.eNDERECODataGridViewTextBoxColumn.Name = "eNDERECODataGridViewTextBoxColumn";
            this.eNDERECODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cIDADEDataGridViewTextBoxColumn
            // 
            this.cIDADEDataGridViewTextBoxColumn.DataPropertyName = "CIDADE";
            this.cIDADEDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cIDADEDataGridViewTextBoxColumn.Name = "cIDADEDataGridViewTextBoxColumn";
            this.cIDADEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bAIRRODataGridViewTextBoxColumn
            // 
            this.bAIRRODataGridViewTextBoxColumn.DataPropertyName = "BAIRRO";
            this.bAIRRODataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bAIRRODataGridViewTextBoxColumn.Name = "bAIRRODataGridViewTextBoxColumn";
            this.bAIRRODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            this.uFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            this.cEPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tELEFONEDataGridViewTextBoxColumn
            // 
            this.tELEFONEDataGridViewTextBoxColumn.DataPropertyName = "TELEFONE";
            this.tELEFONEDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.tELEFONEDataGridViewTextBoxColumn.Name = "tELEFONEDataGridViewTextBoxColumn";
            this.tELEFONEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dATANASCDataGridViewTextBoxColumn
            // 
            this.dATANASCDataGridViewTextBoxColumn.DataPropertyName = "DATANASC";
            dataGridViewCellStyle3.Format = "dd/MM/yyyy";
            this.dATANASCDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.dATANASCDataGridViewTextBoxColumn.HeaderText = "Data Nasc.";
            this.dATANASCDataGridViewTextBoxColumn.Name = "dATANASCDataGridViewTextBoxColumn";
            this.dATANASCDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pC_CLIENTESBindingSource
            // 
            this.pC_CLIENTESBindingSource.DataMember = "PC_CLIENTES";
            this.pC_CLIENTESBindingSource.DataSource = this.bDDataSet;
            // 
            // bDDataSet
            // 
            this.bDDataSet.DataSetName = "BDDataSet";
            this.bDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(12, 12);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(75, 23);
            this.btnIncluir.TabIndex = 2;
            this.btnIncluir.Text = "&Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(93, 12);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 3;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(174, 12);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(255, 12);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Enabled = false;
            this.btnGravar.Location = new System.Drawing.Point(414, 12);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "&Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(495, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pC_CLIENTESTableAdapter
            // 
            this.pC_CLIENTESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PC_CLIENTESTableAdapter = this.pC_CLIENTESTableAdapter;
            this.tableAdapterManager.PC_ITEMVENDATableAdapter = null;
            this.tableAdapterManager.PC_PRODUTOTableAdapter = null;
            this.tableAdapterManager.PC_VENDATableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WfaVendasFatec.BDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pC_VENDABindingSource
            // 
            this.pC_VENDABindingSource.DataMember = "PC_VENDA";
            this.pC_VENDABindingSource.DataSource = this.bDDataSet;
            // 
            // pC_VENDATableAdapter
            // 
            this.pC_VENDATableAdapter.ClearBeforeFill = true;
            // 
            // FrmCadClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 480);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(cODCLILabel);
            this.Controls.Add(this.txtCodcli);
            this.Controls.Add(nOMELabel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(eNDERECOLabel);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(cIDADELabel);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(bAIRROLabel);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(uFLabel);
            this.Controls.Add(this.mskUf);
            this.Controls.Add(cEPLabel);
            this.Controls.Add(this.mskCep);
            this.Controls.Add(tELEFONELabel);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(dATANASCLabel);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.dgvClientes);
            this.Name = "FrmCadClientes";
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FrmCadClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_CLIENTESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_VENDABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDDataSet bDDataSet;
        private System.Windows.Forms.BindingSource pC_CLIENTESBindingSource;
        private BDDataSetTableAdapters.PC_CLIENTESTableAdapter pC_CLIENTESTableAdapter;
        private BDDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtCodcli;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.MaskedTextBox mskUf;
        private System.Windows.Forms.MaskedTextBox mskCep;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn cODCLIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eNDERECODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDADEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIRRODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATANASCDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pC_VENDABindingSource;
        private BDDataSetTableAdapters.PC_VENDATableAdapter pC_VENDATableAdapter;
    }
}

