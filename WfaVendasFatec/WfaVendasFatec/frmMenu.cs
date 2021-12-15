using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendasFatec
{
  public partial class frmMenu : Form
  {
    public frmMenu()
    {
      InitializeComponent();
    }

    private void tmrHora_Tick(object sender, EventArgs e)
    {
      lblHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
    }

    private void toolStripButton4_Click(object sender, EventArgs e)
    {

    }

    private void relatorioDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // TODO Continuar

    }

    private void frmMenu_Load(object sender, EventArgs e)
    {

    }

    private void sairToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("Deseja mesmo sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
      {
        e.Cancel = true;
      }
    }

    private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (Form item in MdiChildren)
      {
        if (item is FrmCadClientes)
        {
          item.Focus();
          return;
        }
      }

      FrmCadClientes frmCadClientes = new FrmCadClientes();
      frmCadClientes.MdiParent = this;
      frmCadClientes.Show();
    }

    private void btnCadClientes_Click(object sender, EventArgs e)
    {
      cadastroDeClientesToolStripMenuItem_Click(null, null);
    }

    private void cadastroDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (Form item in MdiChildren)
      {
        if (item is FrmCadVendas)
        {
          item.Focus();
          return;
        }
      }

      FrmCadVendas frmCadVendas = new FrmCadVendas();
      frmCadVendas.MdiParent = this;
      frmCadVendas.Show();
    }

    private void btnCadVendas_Click(object sender, EventArgs e)
    {
      cadastroDeVendasToolStripMenuItem_Click(null, null);
    }

    private void relatorioDeClientesToolStripMenuItem_Click_1(object sender, EventArgs e)
    {
      foreach (Form item in MdiChildren)
      {
        if (item is frmRptClientes)
        {
          item.Focus();
          return;
        }
      }

      frmRptClientes FrmRptClientes = new frmRptClientes();
      FrmRptClientes.MdiParent = this;
      FrmRptClientes.Show();
    }

    private void relatórioDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      relatorioDeClientesToolStripMenuItem_Click(null, null);
    }

    private void relatórioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      relatorioDeVendasToolStripMenuItem_Click(null, null);
  }

    private void relatorioDeVendasToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (Form item in MdiChildren)
      {
        if (item is FrmRptVendas)
        {
          item.Focus();
          return;
        }
      }

      FrmRptVendas frmRptVendas = new FrmRptVendas();
      frmRptVendas.MdiParent = this;
      frmRptVendas.Show();
    }

    private void cadastroDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (Form item in MdiChildren)
      {
        if (item is FrmCadProdutos)
        {
          item.Focus();
          return;
        }
      }

      FrmCadProdutos frmCadProdutos = new FrmCadProdutos();
      frmCadProdutos.MdiParent = this;
      frmCadProdutos.Show();
  }

    private void btnCadProdutos_Click(object sender, EventArgs e)
    {
      cadastroDeProdutosToolStripMenuItem_Click(null, null);
    }
  }
}
