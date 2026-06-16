using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ResumenVentaForm : Form
    {
        public ResumenVentaForm()
        {
            InitializeComponent();
        }

        private void ResumenVenta_Load(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                List<ResumenVentaCliente> listaReporte = negocio.ListarResumenVentas();
                dgvResumenVenta.DataSource = listaReporte;

                dgvResumenVenta.Columns["IdCliente"].Visible = false;
                dgvResumenVenta.Columns["NombreCliente"].HeaderText = "Cliente";
                dgvResumenVenta.Columns["Cuit"].HeaderText = "CUIT";
                dgvResumenVenta.Columns["CantidadVentas"].HeaderText = "Facturas Emitidas";
                dgvResumenVenta.Columns["TotalUnidadesVendidas"].HeaderText = "Total Ruedas Compradas";
                dgvResumenVenta.Columns["MontoTotalVendido"].HeaderText = "Total Dinero ($)";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);
            }
        }

        private void btnVolverVentas_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        { 
            AltaVentaForm pantallaAlta = new AltaVentaForm();

            pantallaAlta.ShowDialog();
            cargarGrillaVentas();

        }
        private void cargarGrillaVentas()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                dgvResumenVenta.DataSource = negocio.ListarResumenVentas();
  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar: " + ex.Message);
            }
        }
    }
}

