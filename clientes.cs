using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryGrafeuilleTP1parte2
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            TextWriter guardar = new StreamWriter("./cliente.txt", true);
            guardar.WriteLine(Convert.ToString(txtNombreCliente.Text + "" + txtIDcliente.Text));
            guardar.Close();

            MessageBox.Show("Guardado perfectamente bien CAPO");


            txtNombreCliente.Text = "";
            txtIDcliente.Text = "";
            txtNombreCliente.Focus();
        }

          
    }
}
