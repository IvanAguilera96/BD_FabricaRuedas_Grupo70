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
              //  dgvResumenVenta.Columns["CantidadVentas"].HeaderText = "Facturas Emitidas";
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

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResumenVenta.CurrentRow != null)
                {
                    // Capturamos el objeto de la fila seleccionada (asumiendo que tu grilla se alimenta de una clase 'VentaReporte' o 'Venta')
                    // Necesitamos el IdVenta para ir a buscar sus renglones a la base de datos.
                    dynamic ventaSeleccionada = dgvResumenVenta.CurrentRow.DataBoundItem;
                    int idVenta = ventaSeleccionada.IdVenta;

                    // Instanciamos el nuevo formulario pasándole el ID por el constructor
                    DetalleVentaForm detalleForm = new DetalleVentaForm(idVenta);
                    detalleForm.ShowDialog();

                    // Al volver, refrescamos la grilla histórica por si eliminaron algún ítem y cambió el monto total
                    cargarGrillaVentas();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una venta de la lista.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el detalle: " + ex.Message);
            }
        }

    }
}

