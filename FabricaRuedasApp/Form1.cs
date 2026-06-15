using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            EmpleadosForm empleadoForm = new EmpleadosForm();
            empleadoForm.ShowDialog(this);
        }

        private void btnStockCritico_Click(object sender, EventArgs e)
        {
            StockRuedaForm stockForm = new StockRuedaForm();
            stockForm.ShowDialog(this);
        }

        private void btnResumenVenta_Click(object sender, EventArgs e)
        {
            ResumenVentaForm resumenVenta = new ResumenVentaForm();
            resumenVenta.ShowDialog(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

