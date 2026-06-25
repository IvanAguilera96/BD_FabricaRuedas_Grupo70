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
        // Guardamos la lista original en memoria para filtrar sin volver a consultar la BD
        private List<ResumenVentaCliente> listaReporte;

        public ResumenVentaForm()
        {
            InitializeComponent();
        }

        private void ResumenVenta_Load(object sender, EventArgs e)
        {
            cargarGrillaVentas();
            configurarFechasPorDefecto();
        }

        private void cargarGrillaVentas()
        {
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                listaReporte = negocio.ListarResumenVentas();
                dgvResumenVenta.DataSource = listaReporte;
                personalizarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el reporte de ventas: " + ex.Message);
            }
        }
        private void personalizarColumnas()
        {
            if (dgvResumenVenta.Columns["IdVenta"] != null) dgvResumenVenta.Columns["IdVenta"].Visible = false;
            if (dgvResumenVenta.Columns["IdCliente"] != null) dgvResumenVenta.Columns["IdCliente"].Visible = false;

            if (dgvResumenVenta.Columns["NombreCliente"] != null) dgvResumenVenta.Columns["NombreCliente"].HeaderText = "Cliente";
            if (dgvResumenVenta.Columns["Cuit"] != null) dgvResumenVenta.Columns["Cuit"].HeaderText = "CUIT";
            if (dgvResumenVenta.Columns["TotalUnidadesVendidas"] != null) dgvResumenVenta.Columns["TotalUnidadesVendidas"].HeaderText = "Total Ruedas Compradas";
            if (dgvResumenVenta.Columns["MontoTotalVendido"] != null) dgvResumenVenta.Columns["MontoTotalVendido"].HeaderText = "Total Dinero ($)";

            if (dgvResumenVenta.Columns["FechaVenta"] != null)
            {
                dgvResumenVenta.Columns["FechaVenta"].HeaderText = "Fecha de Venta";
                dgvResumenVenta.Columns["FechaVenta"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void configurarFechasPorDefecto()
        {
            // Rango lógico inicial: Desde el 1 de enero del año actual hasta hoy
            dtpDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dtpHasta.Value = DateTime.Now;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (listaReporte == null || listaReporte.Count == 0) return;

            // Filtramos las horas, minutos y segundos usando .Date
            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date;

            if (fechaDesde > fechaHasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.", "Rango Erróneo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Filtrado usando LINQ comparando contra la propiedad FechaVenta del objeto ResumenVentaCliente
            List<ResumenVentaCliente> listaFiltrada = listaReporte
                .Where(x => x.FechaVenta.Date >= fechaDesde && x.FechaVenta.Date <= fechaHasta)
                .ToList();

            // Refrescamos la grilla con los resultados del rango elegido
            dgvResumenVenta.DataSource = null;
            dgvResumenVenta.DataSource = listaFiltrada;
            personalizarColumnas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            configurarFechasPorDefecto();

            // Restauramos la lista original completa
            dgvResumenVenta.DataSource = null;
            dgvResumenVenta.DataSource = listaReporte;
            personalizarColumnas();
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvResumenVenta.CurrentRow != null)
                {
                    dynamic ventaSeleccionada = dgvResumenVenta.CurrentRow.DataBoundItem;
                    int idVenta = ventaSeleccionada.IdVenta;

                    DetalleVentaForm detalleForm = new DetalleVentaForm(idVenta);
                    detalleForm.ShowDialog();

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

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            AltaVentaForm pantallaAlta = new AltaVentaForm();
            pantallaAlta.ShowDialog();
            cargarGrillaVentas();
        }

        private void btnVolverVentas_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

