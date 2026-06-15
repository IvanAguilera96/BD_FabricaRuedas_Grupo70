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
    public partial class StockRuedaForm : Form
    {
        bool cargarStockCritico = false; //Bandera para mostrar stock general al inicio

        public StockRuedaForm()
        {
            InitializeComponent();
        }

        private void StockRuedaForm_Load(object sender, EventArgs e)
        {
            CargarDatos(false);
        }

        private void btnVolverStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos(bool cargarStockCritico)
        {
            try
            {
                StockRuedaNegocio negocio = new StockRuedaNegocio();

                if (cargarStockCritico) //true = solo carga productos con stock crítico (VW_StockCritico)
                {
                    dgvRuedaStock.DataSource = negocio.ListarStockCritico();
                }
                else //false = carga stock completo
                {
                    dgvRuedaStock.DataSource = negocio.Listar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnFiltroCritico_Click(object sender, EventArgs e)
        {
            if (!cargarStockCritico)
            {
                cargarStockCritico = true;
                CargarDatos(true);
            }
            else
            {
                cargarStockCritico = false;
                CargarDatos(false);
            }
        }
    }
}
