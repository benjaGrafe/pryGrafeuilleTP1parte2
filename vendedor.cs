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
    public partial class frmVendedor : Form
    {
        public frmVendedor()
        {
            InitializeComponent();
        }

        private void chkComisión_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarDatos_Click_1(object sender, EventArgs e)
        {
            if (chkActivo.Checked == true)
            {
                if (chkComisión.Checked == true)
                {
                    TextWriter Guardardatos = new StreamWriter("./vendedor.txt");

                    Guardardatos.WriteLine(Convert.ToString(txtIDvendedor.Text + " " + txtNombre.Text + " " + "esta activado" + "//" + "Si cobra comisión"));
                    Guardardatos.Close();

                    MessageBox.Show("se cargo con exito","piola", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (chkComisión.Checked == false)
                {
                    TextWriter Guardardatos = new StreamWriter("./vendedor.txt");

                    Guardardatos.WriteLine(Convert.ToString(txtIDvendedor.Text + " " + txtNombre.Text + " " + "esta activado" + "//" + "NO cobra comisión"));
                    Guardardatos.Close();

                    MessageBox.Show("se cargo con exito", "piola", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

            if (chkActivo.Checked == false)
            {
                if (chkComisión.Checked == true)
                {
                    TextWriter Guardardatos = new StreamWriter("./vendedor.txt");

                    Guardardatos.WriteLine(Convert.ToString(txtIDvendedor.Text + " " + txtNombre.Text + " " + "esta DESACTIVADO" + "//" + "Si cobra comisión"));
                    Guardardatos.Close();

                    MessageBox.Show("se cargo con exito", "piola", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                if (chkComisión.Checked == false)
                {
                    TextWriter Guardardatos = new StreamWriter("./vendedor.txt");

                    Guardardatos.WriteLine(Convert.ToString(txtIDvendedor.Text + " " + txtNombre.Text + " " + "esta DESACIVADO" + "//" + "NO cobra comisión"));
                    Guardardatos.Close();

                    MessageBox.Show("se cargo con exito", "piola", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }

        private void frmVendedor_Load(object sender, EventArgs e)
        {
           
        }
    }

}
