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
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            VentaNegocio negocio = new VentaNegocio();

            try
            {
                int idCliente = (int)cbCliente.SelectedValue;
                int idRueda = (int)cbRueda.SelectedValue;

                int cantidad = (int)numCantidad.Value;

                // Invocamos el método de negocio que ejecuta el SP
                negocio.RegistrarVenta(idCliente, idRueda, cantidad);

                MessageBox.Show("¡Venta registrada con éxito!");
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
