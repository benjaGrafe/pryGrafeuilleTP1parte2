using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryGrafeuilleTP1parte2
{
    public partial class frmadministracion : Form
    {
        public frmadministracion()
        {
            InitializeComponent();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.ShowDialog();
        }

        private void vendedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVendedor vendedor = new frmVendedor();
            vendedor.ShowDialog();

        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente cliente = new frmCliente();
            cliente.ShowDialog();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
