using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Interfaz
{
    public partial class frmFactura : Form
    {
        private FacturaServicio _fs;
        private LlamadasServicio _ls;
        public frmFactura()
        {
            this._fs = new FacturaServicio();
            this._ls = new LlamadasServicio();
            InitializeComponent();
        }
        private void Tab()
        {
            txtHoraPico.TabIndex = 0;
            txtHoraNoPico.TabIndex = 1;
            txtFinde.TabIndex = 2;
            txtCentro.TabIndex = 3;
            txtLitoral.TabIndex = 4;
            txtNOA.TabIndex = 5;
            txtCuyo.TabIndex = 6;
            txtPatagonia.TabIndex = 7;
            txtLATAM.TabIndex = 8;
            txtNorteamerica.TabIndex = 9;
            txtEuropa.TabIndex = 10;
            txtAfrica.TabIndex = 11;
            txtAsia.TabIndex = 12;
            txtOceania.TabIndex = 13;
            btnFacturar.TabIndex = 14;
            btnLimpiarCampos.TabIndex = 15;
            btnSalir.TabIndex = 16;
        }
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                double totalLocal = _ls.ObtenerTotalLocal(Convert.ToInt32(txtHoraPico.Text),
                    Convert.ToInt32(txtHoraNoPico.Text), Convert.ToInt32(txtFinde.Text));
                double totalNacional = _ls.ObtenerTotalNacional(Convert.ToInt32(txtCentro.Text),
                    Convert.ToInt32(txtLitoral.Text),
                    Convert.ToInt32(txtNOA.Text),
                    Convert.ToInt32(txtCuyo.Text),
                    Convert.ToInt32(txtPatagonia.Text));
                double totalInternacional = _ls.ObtenerTotalInternacional(Convert.ToInt32(txtLATAM.Text),
                    Convert.ToInt32(txtNorteamerica.Text),
                    Convert.ToInt32(txtEuropa.Text),
                    Convert.ToInt32(txtAfrica.Text),
                    Convert.ToInt32(txtAsia.Text),
                    Convert.ToInt32(txtOceania.Text));
                Factura f = new Factura(totalLocal, totalNacional, totalInternacional);
                double total = _fs.TotalFactura(f);
                txtFactura.Text = "Abono fijo mensual: " + f.Abono +
                    "\n\nLlamadas locales:\n\tEn hora pico ($0,20 x min): " + txtHoraPico.Text + " min" +
                    "\n\tEn hora no pico ($0,10 x min): " + txtHoraNoPico.Text + " min" +
                    "\n\tFines de semana ($0'10 x min): " + txtFinde.Text + " min" +
                    "\nSubtotal: $" + totalLocal +
                    "\n\nLlamadas nacionales:\n\tAl Centro ($0,25 x min): " + txtCentro.Text + " min" +
                    "\n\tAl Litoral ($0,30 x min): " + txtLitoral.Text + " min" +
                    "\n\tAl Noroeste ($0,35 x min): " + txtNOA.Text + " min" +
                    "\n\tA Cuyo ($0,40 x min): " + txtCuyo.Text + " min" +
                    "\n\tA la Patagonia ($0,45 x min): " + txtPatagonia.Text + " min" +
                    "\nSubtotal: $" + totalNacional +
                    "\n\nLlamadas internacionales:\n\tA Latinoamérica ($0,50 x min): " + txtLATAM.Text + " min" +
                    "\n\tA Norteamérica ($0,55 x min): " + txtNorteamerica.Text + " min" +
                    "\n\tA Europa ($0,60 x min): " + txtEuropa.Text + " min" +
                    "\n\tA África ($0,65 x min): " + txtAfrica.Text + " min" +
                    "\n\tA Asia ($0,70 x min): " + txtAsia.Text + " min" +
                    "\n\tA Oceanía ($0,75 x min): " + txtOceania.Text + " min" +
                    "\nSubtotal: $" + totalInternacional +
                    "\n\nTotal facturado: $" + total;
                gbFactura.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:\n" + ex.Message);
            }
        }
        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            txtHoraPico.Text = "0";
            txtHoraNoPico.Text = "0";
            txtFinde.Text = "0";
            txtCentro.Text = "0";
            txtLitoral.Text = "0";
            txtNOA.Text = "0";
            txtCuyo.Text = "0";
            txtPatagonia.Text = "0";
            txtLATAM.Text = "0";
            txtNorteamerica.Text = "0";
            txtEuropa.Text = "0";
            txtAfrica.Text = "0";
            txtAsia.Text = "0";
            txtOceania.Text = "0";
            txtFactura.Text = string.Empty;
            gbFactura.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            Tab();
        }
    }
}
