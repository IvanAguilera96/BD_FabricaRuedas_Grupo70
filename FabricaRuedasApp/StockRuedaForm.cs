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
        public StockRuedaForm()
        {
            InitializeComponent();
        }

        private void StockRuedaForm_Load(object sender, EventArgs e)
        {
            StockRuedaNegocio negocio = new StockRuedaNegocio();

            dgvRuedaStock.DataSource = negocio.Listar();
        }
    }
}
