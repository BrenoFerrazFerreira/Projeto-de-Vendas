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
  public partial class FrmRptVendas : Form
  {
    public FrmRptVendas()
    {
      InitializeComponent();
    }

    private void FrmRptVendas_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'VendasRelatorioDataSet.PC_VENDA' table. You can move, or remove it, as needed.
      this.PC_VENDATableAdapter.Fill(this.VendasRelatorioDataSet.PC_VENDA);

      this.reportViewer1.RefreshReport();
    }
  }
}
