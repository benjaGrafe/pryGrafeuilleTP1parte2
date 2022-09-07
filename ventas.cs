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
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            StreamReader clienteReader = new StreamReader("./cliente.txt");
            StreamReader vendedorReader = new StreamReader("./vendedor.txt");

            char separador = Convert.ToChar(" ");

            while (!clienteReader.EndOfStream)
            {
                string[] cliente = clienteReader.ReadLine().Split(separador);
                cbClienteID.Items.Add(cliente[0]);
            }

            while (!vendedorReader.EndOfStream)
            {
                string[] vendedor = vendedorReader.ReadLine().Split(separador);
                cbIDvendedor.Items.Add(vendedor[0]);
            }

            clienteReader.Close();
            vendedorReader.Close();

        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            TextWriter datos = new StreamWriter("./Datos.txt");
            datos.WriteLine(Convert.ToString("Tipo de Factura: " + cbFacturaTipo.Text + "\nNumero de Factura: " + txtNumeroFactura.Text + "\nFecha: " + dtpFecha.Text + "\nID del Cliente: " + cbClienteID + "\nID del Vendedor: " + cbIDvendedor + "\nMONTO: " + txtMonto));
            datos.Close();
        }
    }

}
