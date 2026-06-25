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
    public partial class AltaSuministroForm : Form
    {
        public AltaSuministroForm()
        {
            InitializeComponent();
        }

        private void AltaSuministroForm_Load(object sender, EventArgs e)
        {
            try
            {
                ProveedorNegocio provNegocio = new ProveedorNegocio();

                cbProveedor.DataSource = provNegocio.Listar();

                cbProveedor.DisplayMember = "NombreEmpresa";
                cbProveedor.ValueMember = "IdProveedor";

                cbProveedor.SelectedIndex = -1; // Para que inicie limpio sin ninguno seleccionado
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de proveedores: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmarIngreso_Click(object sender, EventArgs e)
        {
            SuministroNegocio negocio = new SuministroNegocio();

            try
            {
                if (cbProveedor.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un proveedor.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("Por favor, ingrese una descripción para el insumo.");
                    return;
                }

                if (numCantidad.Value <= 0)
                {
                    MessageBox.Show("La cantidad recibida debe ser mayor a cero.");
                    return;
                }

                int idProveedor = (int)cbProveedor.SelectedValue;
                string descripcion = txtDescripcion.Text.Trim();
                int cantidadRecibida = (int)numCantidad.Value;

                negocio.Agregar(idProveedor, descripcion, cantidadRecibida);

                MessageBox.Show("Suministro registrado con éxito.");

                this.Close();
            }
            catch (Exception ex)
            {
                string mensajeLimpio = ex.Message.Replace("The transaction ended in the trigger. The batch has been aborted.", "").Trim();

                // Mostramos solo tu texto en español
                MessageBox.Show(mensajeLimpio, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
