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
    public partial class frmRptClientes : Form
    {
        public frmRptClientes()
        {
            InitializeComponent();
        }

        private void frmRptClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VendasRelatorioDataSet.PC_CLIENTES' table. You can move, or remove it, as needed.
            this.PC_CLIENTESTableAdapter.Fill(this.VendasRelatorioDataSet.PC_CLIENTES);
            this.reportViewer1.RefreshReport();
        }
    }
}
