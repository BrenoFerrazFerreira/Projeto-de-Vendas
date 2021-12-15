
namespace WfaVendasFatec
{
    partial class frmMenu
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
      this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
      this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cadastroDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cadastroDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cadastroDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.relatoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.relatorioDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.relatorioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.relatorioDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.janelaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.organizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cascataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sobreOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stsStatus = new System.Windows.Forms.StatusStrip();
      this.lblTexto = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
      this.tmrHora = new System.Windows.Forms.Timer(this.components);
      this.toolStrip1 = new System.Windows.Forms.ToolStrip();
      this.btnCadClientes = new System.Windows.Forms.ToolStripButton();
      this.btnCadVendas = new System.Windows.Forms.ToolStripButton();
      this.btnCadProdutos = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
      this.relatórioDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.relatórioDeVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.relatórioDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
      this.MnuPrincipal.SuspendLayout();
      this.stsStatus.SuspendLayout();
      this.toolStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // MnuPrincipal
      // 
      this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.relatoriosToolStripMenuItem,
            this.janelaToolStripMenuItem,
            this.ajudaToolStripMenuItem});
      this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
      this.MnuPrincipal.MdiWindowListItem = this.janelaToolStripMenuItem;
      this.MnuPrincipal.Name = "MnuPrincipal";
      this.MnuPrincipal.Size = new System.Drawing.Size(800, 24);
      this.MnuPrincipal.TabIndex = 0;
      this.MnuPrincipal.Text = "menuStrip1";
      // 
      // arquivoToolStripMenuItem
      // 
      this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroDeClientesToolStripMenuItem,
            this.cadastroDeVendasToolStripMenuItem,
            this.cadastroDeProdutosToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
      this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
      this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.arquivoToolStripMenuItem.Text = "&Arquivo";
      // 
      // cadastroDeClientesToolStripMenuItem
      // 
      this.cadastroDeClientesToolStripMenuItem.Name = "cadastroDeClientesToolStripMenuItem";
      this.cadastroDeClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.cadastroDeClientesToolStripMenuItem.Text = "Cadastro de &Clientes";
      this.cadastroDeClientesToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
      // 
      // cadastroDeVendasToolStripMenuItem
      // 
      this.cadastroDeVendasToolStripMenuItem.Name = "cadastroDeVendasToolStripMenuItem";
      this.cadastroDeVendasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.cadastroDeVendasToolStripMenuItem.Text = "Cadastro de &Vendas";
      this.cadastroDeVendasToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeVendasToolStripMenuItem_Click);
      // 
      // cadastroDeProdutosToolStripMenuItem
      // 
      this.cadastroDeProdutosToolStripMenuItem.Name = "cadastroDeProdutosToolStripMenuItem";
      this.cadastroDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.cadastroDeProdutosToolStripMenuItem.Text = "Cadastro de &Produtos";
      this.cadastroDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.cadastroDeProdutosToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
      // 
      // sairToolStripMenuItem
      // 
      this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
      this.sairToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.sairToolStripMenuItem.Text = "Sai&r";
      this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
      // 
      // relatoriosToolStripMenuItem
      // 
      this.relatoriosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatorioDeClientesToolStripMenuItem,
            this.relatorioDeVendasToolStripMenuItem,
            this.relatorioDeProdutosToolStripMenuItem});
      this.relatoriosToolStripMenuItem.Name = "relatoriosToolStripMenuItem";
      this.relatoriosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
      this.relatoriosToolStripMenuItem.Text = "&Relatórios";
      // 
      // relatorioDeClientesToolStripMenuItem
      // 
      this.relatorioDeClientesToolStripMenuItem.Name = "relatorioDeClientesToolStripMenuItem";
      this.relatorioDeClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.relatorioDeClientesToolStripMenuItem.Text = "Relatório de &Clientes";
      this.relatorioDeClientesToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeClientesToolStripMenuItem_Click_1);
      // 
      // relatorioDeVendasToolStripMenuItem
      // 
      this.relatorioDeVendasToolStripMenuItem.Name = "relatorioDeVendasToolStripMenuItem";
      this.relatorioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.relatorioDeVendasToolStripMenuItem.Text = "Relatório de &Vendas";
      this.relatorioDeVendasToolStripMenuItem.Click += new System.EventHandler(this.relatorioDeVendasToolStripMenuItem_Click);
      // 
      // relatorioDeProdutosToolStripMenuItem
      // 
      this.relatorioDeProdutosToolStripMenuItem.Name = "relatorioDeProdutosToolStripMenuItem";
      this.relatorioDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.relatorioDeProdutosToolStripMenuItem.Text = "Relatório de &Produtos";
      // 
      // janelaToolStripMenuItem
      // 
      this.janelaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.organizarToolStripMenuItem,
            this.toolStripSeparator2});
      this.janelaToolStripMenuItem.Name = "janelaToolStripMenuItem";
      this.janelaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
      this.janelaToolStripMenuItem.Text = "&Janela";
      // 
      // organizarToolStripMenuItem
      // 
      this.organizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horizontalToolStripMenuItem,
            this.cascataToolStripMenuItem,
            this.verticalToolStripMenuItem});
      this.organizarToolStripMenuItem.Name = "organizarToolStripMenuItem";
      this.organizarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
      this.organizarToolStripMenuItem.Text = "&Organizar";
      // 
      // horizontalToolStripMenuItem
      // 
      this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
      this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.horizontalToolStripMenuItem.Text = "&Horizontal";
      // 
      // cascataToolStripMenuItem
      // 
      this.cascataToolStripMenuItem.Name = "cascataToolStripMenuItem";
      this.cascataToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.cascataToolStripMenuItem.Text = "&Cascata";
      // 
      // verticalToolStripMenuItem
      // 
      this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
      this.verticalToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
      this.verticalToolStripMenuItem.Text = "&Vertical";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(122, 6);
      // 
      // ajudaToolStripMenuItem
      // 
      this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOSistemaToolStripMenuItem});
      this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
      this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.ajudaToolStripMenuItem.Text = "Aj&uda";
      // 
      // sobreOSistemaToolStripMenuItem
      // 
      this.sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
      this.sobreOSistemaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
      this.sobreOSistemaToolStripMenuItem.Text = "&Sobre o sistema";
      // 
      // stsStatus
      // 
      this.stsStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTexto,
            this.lblHora});
      this.stsStatus.Location = new System.Drawing.Point(0, 428);
      this.stsStatus.Name = "stsStatus";
      this.stsStatus.Size = new System.Drawing.Size(800, 22);
      this.stsStatus.TabIndex = 1;
      this.stsStatus.Text = "statusStrip1";
      // 
      // lblTexto
      // 
      this.lblTexto.Name = "lblTexto";
      this.lblTexto.Size = new System.Drawing.Size(625, 17);
      this.lblTexto.Spring = true;
      this.lblTexto.Text = "toolStripStatusLabel1";
      // 
      // lblHora
      // 
      this.lblHora.AutoSize = false;
      this.lblHora.Name = "lblHora";
      this.lblHora.Size = new System.Drawing.Size(160, 17);
      this.lblHora.Text = "toolStripStatusLabel2";
      // 
      // tmrHora
      // 
      this.tmrHora.Enabled = true;
      this.tmrHora.Interval = 1000;
      this.tmrHora.Tick += new System.EventHandler(this.tmrHora_Tick);
      // 
      // toolStrip1
      // 
      this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadClientes,
            this.btnCadVendas,
            this.btnCadProdutos,
            this.toolStripSeparator3,
            this.toolStripSplitButton1,
            this.toolStripSeparator4,
            this.toolStripButton4});
      this.toolStrip1.Location = new System.Drawing.Point(0, 24);
      this.toolStrip1.Name = "toolStrip1";
      this.toolStrip1.Size = new System.Drawing.Size(800, 25);
      this.toolStrip1.TabIndex = 2;
      this.toolStrip1.Text = "toolStrip1";
      // 
      // btnCadClientes
      // 
      this.btnCadClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnCadClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCadClientes.Image")));
      this.btnCadClientes.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCadClientes.Name = "btnCadClientes";
      this.btnCadClientes.Size = new System.Drawing.Size(23, 22);
      this.btnCadClientes.Text = "Cadastro de Clientes";
      this.btnCadClientes.ToolTipText = "Cadastro de Clientes";
      this.btnCadClientes.Click += new System.EventHandler(this.btnCadClientes_Click);
      // 
      // btnCadVendas
      // 
      this.btnCadVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnCadVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnCadVendas.Image")));
      this.btnCadVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCadVendas.Name = "btnCadVendas";
      this.btnCadVendas.Size = new System.Drawing.Size(23, 22);
      this.btnCadVendas.Text = "Cadastro de Vendas";
      this.btnCadVendas.Click += new System.EventHandler(this.btnCadVendas_Click);
      // 
      // btnCadProdutos
      // 
      this.btnCadProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnCadProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnCadProdutos.Image")));
      this.btnCadProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCadProdutos.Name = "btnCadProdutos";
      this.btnCadProdutos.Size = new System.Drawing.Size(23, 22);
      this.btnCadProdutos.Text = "Cadastro de Produtos";
      this.btnCadProdutos.Click += new System.EventHandler(this.btnCadProdutos_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripSplitButton1
      // 
      this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relatórioDeClientesToolStripMenuItem,
            this.relatórioDeVendasToolStripMenuItem,
            this.relatórioDeProdutosToolStripMenuItem});
      this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
      this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripSplitButton1.Name = "toolStripSplitButton1";
      this.toolStripSplitButton1.Size = new System.Drawing.Size(32, 22);
      this.toolStripSplitButton1.Text = "toolStripSplitButton1";
      // 
      // relatórioDeClientesToolStripMenuItem
      // 
      this.relatórioDeClientesToolStripMenuItem.Name = "relatórioDeClientesToolStripMenuItem";
      this.relatórioDeClientesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.relatórioDeClientesToolStripMenuItem.Text = "Relatório de Clientes";
      this.relatórioDeClientesToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeClientesToolStripMenuItem_Click);
      // 
      // relatórioDeVendasToolStripMenuItem
      // 
      this.relatórioDeVendasToolStripMenuItem.Name = "relatórioDeVendasToolStripMenuItem";
      this.relatórioDeVendasToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.relatórioDeVendasToolStripMenuItem.Text = "Relatório de Vendas";
      this.relatórioDeVendasToolStripMenuItem.Click += new System.EventHandler(this.relatórioDeVendasToolStripMenuItem_Click);
      // 
      // relatórioDeProdutosToolStripMenuItem
      // 
      this.relatórioDeProdutosToolStripMenuItem.Name = "relatórioDeProdutosToolStripMenuItem";
      this.relatórioDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
      this.relatórioDeProdutosToolStripMenuItem.Text = "Relatório de Produtos";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripButton4
      // 
      this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
      this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton4.Name = "toolStripButton4";
      this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton4.Text = "toolStripButton4";
      // 
      // frmMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.toolStrip1);
      this.Controls.Add(this.stsStatus);
      this.Controls.Add(this.MnuPrincipal);
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.MnuPrincipal;
      this.Name = "frmMenu";
      this.Text = "Controle de Vendas";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
      this.Load += new System.EventHandler(this.frmMenu_Load);
      this.MnuPrincipal.ResumeLayout(false);
      this.MnuPrincipal.PerformLayout();
      this.stsStatus.ResumeLayout(false);
      this.stsStatus.PerformLayout();
      this.toolStrip1.ResumeLayout(false);
      this.toolStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem organizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip stsStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblTexto;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer tmrHora;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCadClientes;
        private System.Windows.Forms.ToolStripButton btnCadVendas;
        private System.Windows.Forms.ToolStripButton btnCadProdutos;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeVendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatórioDeProdutosToolStripMenuItem;
    }
}