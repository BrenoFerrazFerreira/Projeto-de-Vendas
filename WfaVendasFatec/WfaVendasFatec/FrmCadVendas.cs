using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WfaVendasFatec
{
  public partial class FrmCadVendas : Form
  {
    private bool incluir = false;
    private bool editar = false;
    private bool editarItem = false;
    private bool incluirItem = false;
    private double precotemp = 0;
    public FrmCadVendas()
    {
      InitializeComponent();
    }

    private void FrmCadVendas_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'bDDataSet.PC_VENDA1' table. You can move, or remove it, as needed.
      this.pC_PRODUTOTableAdapter.Fill(this.bDDataSet.PC_PRODUTO);
      this.pC_CLIENTESTableAdapter.Fill(this.bDDataSet.PC_CLIENTES);
      this.pC_VENDATableAdapter.Fill(this.bDDataSet.PC_VENDA);

      if (dgvVendas.RowCount > 0)
      {
        dgvVendas.Rows[0].Selected = true;
      }
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

    private void HabilitaCamposItem(Control container, bool hab)
    {
      cmbProduto.Enabled = hab;
      nudQuantidade.Enabled = hab;
    }

    private void HabilitaBotoesItem(Control container, bool hab)
    {
      btnIncluirItem.Enabled = hab;
      btnIncluirItem.Enabled = hab;
      btnAlterarItem.Enabled = hab;
      btnPesquisarItem.Enabled = hab;
      btnSair.Enabled = hab;
      btnGravarItem.Enabled = hab;
      btnCancelarItem.Enabled = hab;
    }

    private void LimpaCampos(Control container)
    {
      foreach (Control control in container.Controls)
      {
        if (control is TextBox)
        {
          ((TextBox)control).Clear();
          if (control.Name == "txtPrecoUnit" ||
              control.Name == "txtSubTotal" ||
              control.Name == "txtTotal")
          {
            control.Text = "R$ 0,00";
          }
        }
        else if (control is MaskedTextBox)
        {
          ((MaskedTextBox)control).Clear();
        }
        else if (control is DateTimePicker)
        {
          ((DateTimePicker)control).Value = DateTime.Now;
        }
        else if (control is NumericUpDown)
        {
          ((NumericUpDown)control).Value = 1;
        }
        else if (control is ComboBox)
        {
          if (((ComboBox)control).Items.Count > 0)
          {
            ((ComboBox)control).SelectedIndex = 0;
          }
        }
      }
    }

    private void btnIncluir_Click(object sender, EventArgs e)
    {
      incluir = true;
      HabilitaCampos(this, true);
      HabilitaBotoes(this, false);
      cmbCodCli.Focus();
    }

    private void btnGravar_Click(object sender, EventArgs e)
    {
      try
      {
        if (incluir)
        {
          pC_VENDATableAdapter.Insert(dtpDataVenda.Value, dtpDataEntrega.Value, (Int32)cmbCodCli.SelectedIndex, txtObs.Text);
          MessageBox.Show(null, "Incluido com sucesso!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        if (editar)
        {
          pC_VENDATableAdapter.Update(dtpDataVenda.Value, dtpDataEntrega.Value, (Int32)cmbCodCli.SelectedIndex, txtObs.Text, Convert.ToInt32(txtNumVenda.Text));
          MessageBox.Show(null, "Alterado com sucesso!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        FrmCadVendas_Load(null, null);
        btnCancelar_Click(null, null);
      }
      catch (Exception ex)
      {
        MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);

      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      LimpaCampos(this);
      LimpaCampos(grpItens);
      HabilitaCampos(this, false);
      HabilitaBotoes(this, true);
      HabilitaBotoes(grpItens, false);
      editar = false;
      incluir = false;
    }

    private void btnSair_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnExcluir_Click(object sender, EventArgs e)
    {
      try
      {
        if (dgvVendas.SelectedRows.Count > 0)
        {
          if (MessageBox.Show("Deseja mesmo excluir a venda selecionada?",
              "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            pC_ITEMVENDATableAdapter.DeleteTodos((Int32)dgvVendas[0, dgvVendas.CurrentRow.Index].Value);
            pC_VENDATableAdapter.Delete((Int32)dgvVendas[0, dgvVendas.CurrentRow.Index].Value);
            FrmCadVendas_Load(null, null);
            MessageBox.Show("Venda excluida com sucesso!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            MessageBox.Show("Selecione uma venda primeiro:", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnAlterar_Click(object sender, EventArgs e)
    {
      if (dgvVendas.SelectedRows.Count > 0)
      {
        editar = true;
        HabilitaBotoes(this, false);
        HabilitaCampos(this, true);
        txtNumVenda.Enabled = false;
        int linha = dgvVendas.CurrentRow.Index;
        txtNumVenda.Text = dgvVendas[0, linha].Value.ToString();
        cmbCodCli.SelectedValue = (Int32)dgvVendas[1, linha].Value;
        dtpDataVenda.Value = (DateTime)dgvVendas[3, linha].Value;
        dtpDataEntrega.Value = (DateTime)dgvVendas[4, linha].Value;
        txtObs.Text = dgvVendas[5, linha].Value.ToString();
        cmbCodCli.Focus();
      }
      else
      {
        MessageBox.Show("Selecione uma venda primeiro:", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnPesquisar_Click(object sender, EventArgs e)
    {
      if (cmbCodCli.Enabled == false)
      {
        cmbCodCli.Enabled = true;
        cmbCodCli.Focus();
        HabilitaBotoes(this, false);
        btnPesquisar.Enabled = true;
        btnGravar.Enabled = false;
        btnCancelar.Enabled = false;
        MessageBox.Show("Digite o nome desejado ou " +
            "\n parte dele", "Pesquisa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        pC_VENDATableAdapter.FillByNome(bDDataSet.PC_VENDA, "%" + cmbCodCli.Text + "%");
        btnCancelar_Click(null, null);
      }
    }

    private void dgvVendas_SelectionChanged(object sender, EventArgs e)
    {
      try
      {
        if (dgvVendas.RowCount > 0)
        {
          int numVenda = (Int32)dgvVendas[0, dgvVendas.CurrentRow.Index].Value;
          pC_ITEMVENDATableAdapter.FillByNumVenda(bDDataSet.PC_ITEMVENDA, numVenda);
          if (dgvItem.RowCount > 0)
          {
            double total = (Double)pC_ITEMVENDATableAdapter.TotalVenda(numVenda);
            txtTotal.Text = total.ToString("R$ #,###,##0.00");
          }
          else
          {
            txtTotal.Text = "R$ #0,00";
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnTodos_Click(object sender, EventArgs e)
    {
      FrmCadVendas_Load(null, null);
    }

    private void btnIncluirItem_Click(object sender, EventArgs e)
    {
      incluirItem = true;
      HabilitaCamposItem(grpItens, true);
      HabilitaBotoesItem(grpItens, false);
      cmbProduto_SelectedIndexChanged(null, null);
      cmbProduto.Focus();
    }

    private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e)
    {
      DataTable produto = pC_PRODUTOTableAdapter.GetDataByDescricao(cmbProduto.Text);
      precotemp = 0;
      foreach (DataRow row in produto.Rows)
      {
        precotemp = Convert.ToDouble(row["precounit"].ToString());
      }
      nudQuantidade.Value = 1;
      txtPrecoUnit.Text = precotemp.ToString("R$ #,###,##0.00");
      txtSubTotal.Text = precotemp.ToString("R$ #,###,##0.00");
    }

    private void nudQuantidade_ValueChanged(object sender, EventArgs e)
    {
      double subtotal = (Int32)nudQuantidade.Value * precotemp;
      txtSubTotal.Text = subtotal.ToString("R$ #,###,##0.00");
    }

    private void btnExcluirItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (dgvItem.SelectedRows.Count > 0)
        {
          if (MessageBox.Show("Deseja mesmo excluir o item selecionado?",
              "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
          {
            pC_ITEMVENDATableAdapter.Delete1(
                (Int32)dgvVendas[0, dgvVendas.CurrentRow.Index].Value,
                (Int32)dgvItem[0, dgvItem.CurrentRow.Index].Value
            );
            dgvVendas_SelectionChanged(null, null);
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

    private void btnAlterarItem_Click(object sender, EventArgs e)
    {
      if (dgvItem.SelectedRows.Count > 0)
      {
        editarItem = true;
        HabilitaBotoesItem(grpItens, false);
        HabilitaCamposItem(grpItens, true);
        cmbProduto.Text =
            dgvItem[1, dgvItem.CurrentRow.Index].Value.ToString();
        cmbProduto_SelectedIndexChanged(null, null);
        nudQuantidade.Value = (Int32)dgvItem[2, dgvItem.CurrentRow.Index].Value;
        cmbProduto.Focus();
      }
      else
      {
        MessageBox.Show("Selecione um item primeiro:", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnPesquisarItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (dgvItem.RowCount > 0)
        {
          if (cmbProduto.Enabled == false)
          {
            cmbProduto.Enabled = true;
            cmbProduto.Focus();
            HabilitaBotoesItem(grpItens, false);
            btnPesquisarItem.Enabled = true;
            btnGravarItem.Enabled = false;
            btnCancelarItem.Enabled = false;
            MessageBox.Show("Digite o nome desejado ou " +
        "\n parte dele", "Pesquisa:", MessageBoxButtons.OK, MessageBoxIcon.Information);
          }
          else
          {
            pC_ITEMVENDATableAdapter.FillByDescricao(this.bDDataSet.PC_ITEMVENDA,
                Convert.ToString(dgvVendas[0, dgvVendas.CurrentRow.Index].Value), Convert.ToInt32("%" + cmbProduto.Text + "%"));
            btnCancelarItem_Click(null, null);
          }
        }
        else
        {
          MessageBox.Show("Cadastre um item primeiro:", "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnCancelarItem_Click(object sender, EventArgs e)
    {
      LimpaCampos(grpItens);
      HabilitaCamposItem(grpItens, false);
      HabilitaBotoesItem(grpItens, true);
      editarItem = false;
      incluirItem = false;
    }

    private void btnGravarItem_Click(object sender, EventArgs e)
    {
      try
      {
        if (incluirItem)
        {
          pC_ITEMVENDATableAdapter.Insert1(
              (Int32)dgvVendas[0, dgvVendas.CurrentRow.Index].Value,
              (Int32)cmbProduto.SelectedValue,
              (Int32)nudQuantidade.Value,
              precotemp);
          MessageBox.Show(null, "Incluido com sucesso!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        if (editarItem)
        {
          pC_ITEMVENDATableAdapter.Update1(
              (Int32)dgvVendas[0, dgvVendas.CurrentRow.Index].Value,
              (Int32)cmbProduto.SelectedValue,
              (Int32)nudQuantidade.Value,
              precotemp);
          MessageBox.Show(null, "Alterado com sucesso!", "Aviso:", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        dgvVendas_SelectionChanged(null, null);
        btnCancelarItem_Click(null, null);
      }
      catch (Exception ex)
      {
        MessageBox.Show(null, "Ocorreu um erro:\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
