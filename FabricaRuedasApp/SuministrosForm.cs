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
    public partial class SuministrosForm : Form
    {
        private List<Suministro> listaSuministro;
        public SuministrosForm()
        {
            InitializeComponent();
        }

        private void SuministrosForm_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            SuministroNegocio negocio = new SuministroNegocio();

            try
            {

                listaSuministro = negocio.Listar();
                dgvSuministros.DataSource = listaSuministro;

                dgvSuministros.Columns["IdSuministro"].Visible = false;
                dgvSuministros.Columns["IdProveedor"].HeaderText = "Proveedor";
                dgvSuministros.Columns["Descripcion"].HeaderText = "Insumo";
                dgvSuministros.Columns["CantdRecibida"].HeaderText = "Cantidad Recibida";
                dgvSuministros.Columns["FechaEntrega"].HeaderText = "Fecha de Entrega";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla de suministros: " + ex.Message);
            }
        }

        private void btnVolverSuministros_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarSuministro_Click(object sender, EventArgs e)
        {
            AltaSuministroForm altaSuministro = new AltaSuministroForm();
            altaSuministro.ShowDialog(this);

            cargarGrilla();
        }
    }
}
