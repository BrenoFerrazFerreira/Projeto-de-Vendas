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
  public partial class FrmCadProdutos : Form
  {
    private bool incluir = false;
    private bool alterar = false;

    public FrmCadProdutos()
    {
      InitializeComponent();
    }

    private void pC_PRODUTOBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.pC_PRODUTOBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.bDDataSet);

    }

    private void FrmCadProdutos_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'bDDataSet.PC_PRODUTO' table. You can move, or remove it, as needed.
      this.pC_PRODUTOTableAdapter.Fill(this.bDDataSet.PC_PRODUTO);

    }

    private void HabilitaCampos(Control container, bool hab)
    {
      foreach (Control campo in container.Controls)
      {
        if (!(campo is Label) && !(campo is DataGridView))
        {
          campo.Enabled = hab;
        }
      }
    }

    private void HabilitaBotoes(Control container, bool hab)
    {
      foreach (Control componente in container.Controls)
      {
        if (componente is Button)
        {
          componente.Enabled = hab;
          if (componente.Name == "btnGravar" || componente.Name == "btnCancelar")
          {
            componente.Enabled = !hab;
          }
        }
      }
    }

    private void LimpaCampos(Control container)
    {
      foreach (Control control in container.Controls)
      {
        if (control is TextBox)
        {
          ((TextBox)control).Clear();
        }
        else if (control is NumericUpDown)
        {
          ((NumericUpDown)control).Value = 1;
        }
      }
    }

    private void btnIncluir_Click(object sender, EventArgs e)
    {
      HabilitaCampos(this, true);
      LimpaCampos(this);
      HabilitaBotoes(this, false);
      incluir = true;
      txtCodpro.Enabled = false;
      txtDescricao.Focus();
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
      if (dgvProdutos.SelectedRows.Count > 0)
      {
        alterar = true;
        HabilitaBotoes(this, false);
        HabilitaCampos(this, true);
        txtCodpro.Enabled = false;
        txtCodpro.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
        txtDescricao.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
        nudQuantidade.Value = (Int32)dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value;
        txtPrecounit.Text = dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value.ToString();
        txtDescricao.Focus();
      }
      else
      {
        MessageBox.Show("Selecione um produto primeiro!", "Erro:",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      try
      {
        if (dgvProdutos.SelectedRows.Count > 0)
        {
          if (MessageBox.Show("Deseja mesmo excluir o item selecionado?",
              "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            pC_PRODUTOTableAdapter.Delete((Int32)dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value);
            FrmCadProdutos_Load(null, null);
            MessageBox.Show(null, "Item excluido com sucesso!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
        }
        else
        {
          MessageBox.Show("Selecione um item primeiro:", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      try
      {
        if (txtDescricao.Enabled == false)
        {
          txtDescricao.Enabled = true;
          txtDescricao.Focus();
          HabilitaBotoes(this, false);
          btnPesquisar.Enabled = true;
          btnCancelar.Enabled = false;
          btnGravar.Enabled = false;
          MessageBox.Show("Digite o nome desejado ou\numa parte dele:",
              "Pesquisa: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else
        {
          pC_PRODUTOTableAdapter.FillByDescricao(this.bDDataSet.PC_PRODUTO, "%" + txtDescricao.Text + "%");
          btnCancelar_Click(null, null);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      incluir = false;
      alterar = false;
      LimpaCampos(this);
      HabilitaCampos(this, false);
      HabilitaBotoes(this, true);
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
      try
      {
        if (incluir)
        {
          pC_PRODUTOTableAdapter.Insert(txtDescricao.Text, (Int32)nudQuantidade.Value, Convert.ToInt32(txtPrecounit.Text));
          MessageBox.Show("Produto incluido com sucesso!", "Incluir:",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        if (alterar)
        {
          pC_PRODUTOTableAdapter.Update(txtDescricao.Text, (Int32)nudQuantidade.Value, Convert.ToInt32(txtPrecounit.Text), Int32.Parse(txtCodpro.Text));
          MessageBox.Show("Cliente alterado com sucesso!", "Alterar:",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        btnCancelar_Click(null, null);
        FrmCadProdutos_Load(null, null);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
