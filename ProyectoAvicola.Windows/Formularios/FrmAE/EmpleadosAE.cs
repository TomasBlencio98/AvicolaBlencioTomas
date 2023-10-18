using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    public partial class EmpleadosAE : Form
    {
        public EmpleadosAE()
        {
            InitializeComponent();
        }
        private Empleado empleado;
        public Empleado GetEmpleado()
        {
            return empleado;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboBoxs.CargarComboLocalidades(ref ComboBoxLocalidades);
            ComboBoxs.CargarComboGranjas(ref ComboBoxGranjas);
            if (empleado != null)
            {
                TexBoxsNombre.Text = empleado.NombreEmpleado;
                TextBoxApellido.Text = empleado.ApellidoEmpleado;
                TextBoxTelefono.Text = empleado.Telefono;
                ComboBoxLocalidades.SelectedValue = empleado.LocalidadId;
                ComboBoxGranjas.SelectedValue = empleado.GranjaId;
            }
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (empleado == null)
                {
                    empleado = new Empleado();
                }
                empleado.NombreEmpleado = TexBoxsNombre.Text;
                empleado.ApellidoEmpleado = TextBoxApellido.Text;
                empleado.Telefono = TextBoxTelefono.Text;
                empleado.LocalidadId = (int)ComboBoxLocalidades.SelectedValue;
                empleado.GranjaId = (int)ComboBoxGranjas.SelectedValue;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            var val = true;
            if (string.IsNullOrEmpty(TexBoxsNombre.Text))
            {
                errorProvider1.SetError(TexBoxsNombre,
                    "Nombre mal ingresado!!!");
                val = false;
            }
            if (string.IsNullOrEmpty(TextBoxApellido.Text))
            {
                errorProvider1.SetError(TextBoxApellido,
                    "Apellido mal ingresado!!!");
                val = false;
            }
            if (string.IsNullOrEmpty(TextBoxTelefono.Text))
            {
                errorProvider1.SetError(TextBoxTelefono,
                    "Telefono mal ingresado!!!");
                val = false;
            }
            if (ComboBoxLocalidades.SelectedIndex == 0)
            {
                errorProvider1.SetError(ComboBoxLocalidades, "Debe seleccionar una Localidad de la cual es el empleado");
                val = false;
            }
            if (ComboBoxGranjas.SelectedIndex == 0)
            {
                errorProvider1.SetError(ComboBoxGranjas, "Debe seleccionar una Granja a la que pertenece el empleado");
                val = false;
            }
            return val;
        }

        public void SetEmpleado(Empleado empleado)
        {
            this.empleado = empleado;
        }
    }
}
