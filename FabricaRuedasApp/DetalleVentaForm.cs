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
    public partial class DetalleVentaForm : Form
    {
        private int idVentaSeleccionada;
        private VentaNegocio negocio = new VentaNegocio();

        // 🌟 Modificamos el constructor para recibir el ID de la venta elegida
        public DetalleVentaForm(int idVenta)
        {
            InitializeComponent();
            this.idVentaSeleccionada = idVenta;
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void DetalleVentaForm_Load(object sender, EventArgs e)
        {
            lblDetalleVenta.Text = "Detalle de la Venta N°: " + idVentaSeleccionada;
            cargarGrilla();
        }

        private void btnEliminarDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalleVenta.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de eliminar este ítem de la venta? Se reajustará el stock y los montos.", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (respuesta == DialogResult.Yes)
                    {
                        // Casteamos la fila seleccionada a nuestro objeto de Dominio
                        DetalleVenta seleccionado = (DetalleVenta)dgvDetalleVenta.CurrentRow.DataBoundItem;

                        // Mandamos a impactar la eliminación en las tablas correspondientes
                        negocio.EliminarRenglonDetalle(seleccionado.IdDetalle);

                        MessageBox.Show("Ítem eliminado correctamente y stock actualizado.");

                        // Volvemos a leer la base de datos para actualizar el listado visual
                        cargarGrilla();

                        // 💡 TRUCO EXTRA: Si tras eliminar el renglón la grilla queda totalmente vacía, 
                        // significa que la factura quedó sin productos. Podríamos cerrar la ventana automáticamente.
                        if (dgvDetalleVenta.Rows.Count == 0)
                        {
                            MessageBox.Show("La venta ya no contiene artículos.");
                            this.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el ítem: " + ex.Message);
            }
        }

        private void cargarGrilla()
        {
            try
            {
                // Buscamos los detalles en la base de datos usando nuestro nuevo método
                List<DetalleVenta> listaDetalle = negocio.ListarDetallePorId(idVentaSeleccionada);
                dgvDetalleVenta.DataSource = listaDetalle;
                dgvDetalleVenta.Columns["IdVenta"].Visible = false;


                if (dgvDetalleVenta.Columns.Contains("IdDetalle")) dgvDetalleVenta.Columns["IdDetalle"].Visible = false;
                if (dgvDetalleVenta.Columns.Contains("IdVenta")) dgvDetalleVenta.Columns["IdVenta"].Visible = false;
                if (dgvDetalleVenta.Columns.Contains("IdRueda")) dgvDetalleVenta.Columns["IdRueda"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles: " + ex.Message);
            }
        }

        private void btnVolverDetalle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
