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
    public partial class FrmCadClientes : Form
    {
        private bool incluir = false;
        private bool alterar = false;
        public FrmCadClientes()
        {
            InitializeComponent();
        }

        private void FrmCadClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDDataSet.PC_VENDA' table. You can move, or remove it, as needed.
            this.pC_VENDATableAdapter.Fill(this.bDDataSet.PC_VENDA);
            this.pC_CLIENTESTableAdapter.Fill(this.bDDataSet.PC_CLIENTES);
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
                else if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            HabilitaCampos(this, true);
            LimpaCampos(this);
            HabilitaBotoes(this, false);
            incluir = true;
            txtCodcli.Enabled = false;
            txtNome.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            alterar = false;
            LimpaCampos(this);
            HabilitaCampos(this, false);
            HabilitaBotoes(this, true);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count > 0)
            {
                alterar = true;
                HabilitaBotoes(this, false);
                HabilitaCampos(this, true);
                txtCodcli.Enabled = false;
                txtCodcli.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                txtEndereco.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                txtCidade.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
                txtBairro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
                mskCep.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
                mskUf.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
                mskTelefone.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
                dtpDataNasc.Value = (DateTime)dgvClientes[8, dgvClientes.CurrentRow.Index].Value;
                txtNome.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um cliente primeiro!", "Erro:",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    pC_CLIENTESTableAdapter.Insert(txtNome.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text, mskUf.Text,
                        mskCep.Text, mskTelefone.Text, dtpDataNasc.Value);
                    MessageBox.Show("Cliente incluido com sucesso!", "Incluir:",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (alterar)
                {
                    pC_CLIENTESTableAdapter.Update(txtNome.Text, txtEndereco.Text, txtCidade.Text, txtBairro.Text, mskUf.Text,
                        mskCep.Text, mskTelefone.Text, dtpDataNasc.Value, Int32.Parse(txtCodcli.Text));
                    MessageBox.Show("Cliente alterado com sucesso!", "Alterar:",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                btnCancelar_Click(null, null);
                FrmCadClientes_Load(null, null);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro no banco de dados",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Enabled == false)
                {
                    txtNome.Enabled = true;
                    txtNome.Focus();
                    HabilitaBotoes(this, false);
                    btnPesquisar.Enabled = true;
                    btnCancelar.Enabled = false;
                    btnGravar.Enabled = false;
                    MessageBox.Show("Digite o nome desejado ou\numa parte dele:",
                        "Pesquisa: ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pC_CLIENTESTableAdapter.FillByNome(this.bDDataSet.PC_CLIENTES, "%" + txtNome.Text + "%");
                    btnCancelar_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro:\n" + ex.Message, "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvClientes_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "telefone")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = "(" + stringValue.Substring(0, 2) + ")" + stringValue.Substring(2, 5) + "-" + stringValue.Substring(7, 4);
                        e.Value = stringValue;
                    }

                }
            }
            else if (dgvClientes.Columns[e.ColumnIndex].DataPropertyName == "cep")
            {
                if (e.Value != null)
                {
                    string stringValue = (string)e.Value;
                    if (stringValue != "")
                    {
                        stringValue = stringValue.Substring(0, 5) + "-" + stringValue.Substring(5, 3);
                        e.Value = stringValue;
                    }

                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("Deseja mesmo excluir o item selecionado?",
                        "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        pC_CLIENTESTableAdapter.Delete((Int32)dgvClientes[0, dgvClientes.CurrentRow.Index].Value);
                        FrmCadClientes_Load(null, null);
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
    }
}
