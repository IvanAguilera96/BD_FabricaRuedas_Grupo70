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

                // 2. Ocultamos las columnas usando los nombres EXACTOS de tus propiedades de Dominio
                dgvEmpleados.Columns["Area"].Visible = false;
                dgvEmpleados.Columns["Supervisor"].Visible = false;

                // 3. (Opcional) Emprolijamos los títulos de tus propiedades calculadas
                dgvEmpleados.Columns["NombreArea"].HeaderText = "Área";
                dgvEmpleados.Columns["NombreSupervisor"].HeaderText = "Supervisor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la grilla de empleados: " + ex.Message);
            }
        }
    }
}
