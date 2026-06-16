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
    public partial class AltaEmpleadoForm : Form
    {
        public AltaEmpleadoForm()
        {
            InitializeComponent();

        }

        private void AltaEmpleadoForm_Load(object sender, EventArgs e)
        {
            // Creamos las instancias de negocio para llenar los combos
            AreaNegocio areaNegocio = new AreaNegocio();
            EmpleadoNegocio empleadoNegocio = new EmpleadoNegocio();

            try
            {
                // Cargo combo de areas
                cbArea.DataSource = areaNegocio.Listar();
                cbArea.DisplayMember = "NombreArea";
                cbArea.ValueMember = "IdArea";       

                // Cargo combo de Supervisores (son Empleados ya registrados)
                cbSupervisor.DataSource = empleadoNegocio.listar();
                cbSupervisor.DisplayMember = "NombreCompleto";
                cbSupervisor.ValueMember = "IdEmpleado";

                cbSupervisor.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los desplegables: " + ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EmpleadoNegocio negocio = new EmpleadoNegocio();
            Empleado nuevo = new Empleado();

            try
            {
                nuevo.Nombre = txtNombre.Text;
                nuevo.Apellido = txtApellido.Text;
                nuevo.Legajo = int.Parse(txtLegajo.Text); 
                nuevo.Telefono = txtTelefono.Text;
                nuevo.Cargo = txtCargo.Text;

                nuevo.Area = new Area();
                nuevo.Area.IdArea = (int)cbArea.SelectedValue;

                if (cbSupervisor.SelectedIndex != -1)
                {
                    nuevo.Supervisor = (Empleado)cbSupervisor.SelectedItem;
                }
                else
                {
                    nuevo.Supervisor = null;
                }

                //Invocamos metodo de negocio que ejecuta "SP_NuevoEmpleado"
                negocio.Agregar(nuevo);

                MessageBox.Show("¡Empleado registrado con éxito!");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el empleado: " + ex.Message);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
