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
    public partial class AltaVentaForm : Form
    {
        // CREAMOS LA LISTA EN MEMORIA PARA ACUMULAR LOS RENGLONES DE LA VENTA
        private List<DetalleVenta> carrito = new List<DetalleVenta>();

        public AltaVentaForm()
        {
            InitializeComponent();
        }

        private void AltaVentaForm_Load(object sender, EventArgs e)
        {
            // Cargamos el combo de clientes
            ClienteNegocio clienteNegocio = new ClienteNegocio();
            cbCliente.DataSource = clienteNegocio.ListarClientes();
            cbCliente.DisplayMember = "NombreCliente";
            cbCliente.ValueMember = "IdCliente";

            // Cargamos el combo de ruedas
            StockRuedaNegocio ruedaNegocio = new StockRuedaNegocio();
            cbRueda.DataSource = ruedaNegocio.Listar();
            cbRueda.DisplayMember = "Modelo";
            cbRueda.ValueMember = "IdRueda";

            dgvDetalleTemporal.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleTemporal.MultiSelect = false;
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            try
            {

                DetalleVenta renglon = new DetalleVenta();

                renglon.IdRueda = (int)cbRueda.SelectedValue;
                renglon.Cantidad = (int)numCantidad.Value;

                Rueda ruedaSeleccionada = (Rueda)cbRueda.SelectedItem;

                renglon.ModeloRueda = ruedaSeleccionada.Modelo;
                renglon.PrecioUnitario = ruedaSeleccionada.PrecioUnitario;

                carrito.Add(renglon);

                dgvDetalleTemporal.DataSource = null;
                dgvDetalleTemporal.DataSource = carrito;

                dgvDetalleTemporal.Columns["IdDetalle"].Visible = false;
                dgvDetalleTemporal.Columns["IdVenta"].Visible = false;
                dgvDetalleTemporal.Columns["IdRueda"].Visible = false;

                cbCliente.Enabled = false;
                numCantidad.Value = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            VentaNegocio negocio = new VentaNegocio();
            Venta nuevaVenta = new Venta();

            try
            {
                if (carrito.Count == 0)
                {
                    MessageBox.Show("Debe agregar al menos una rueda para poder registrar la venta.");
                    return;
                }

                nuevaVenta.IdCliente = (int)cbCliente.SelectedValue;
                nuevaVenta.Detalle = carrito; // Le pasamos la lista de renglones

                int idVentaFacturada = negocio.RegistrarVentaCompleta(nuevaVenta);

                MessageBox.Show("¡Venta N° " + idVentaFacturada + " registrada con éxito con todos sus productos!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}