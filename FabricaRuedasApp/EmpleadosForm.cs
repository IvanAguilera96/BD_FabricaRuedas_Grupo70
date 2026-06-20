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
using Dominio;

namespace Presentacion
{
    public partial class EmpleadosForm : Form
    {
        private List<Empleado> listaEmpleado;

        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private void EmpleadosForm_Load(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        private void cargarGrilla()
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();

            try
            {
                listaEmpleado = negocio.listar();

                dgvEmpleados.DataSource = listaEmpleado;

                dgvEmpleados.Columns["Area"].Visible = false;
                dgvEmpleados.Columns["Supervisor"].Visible = false;
                dgvEmpleados.Columns["Cuit"].HeaderText = "Cuit";
                dgvEmpleados.Columns["NombreArea"].HeaderText = "Área";
                dgvEmpleados.Columns["NombreSupervisor"].HeaderText = "Supervisor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla de empleados: " + ex.Message);
            }
        }

        private void btnVolverEmpleados_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AltaEmpleadoForm altaEmpleado = new AltaEmpleadoForm();
            altaEmpleado.ShowDialog();

            cargarGrilla();
        }
    }
}
