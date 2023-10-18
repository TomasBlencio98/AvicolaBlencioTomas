using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAvicola.Windows.Formularios.FrmAE
{
    public partial class ProveedorAE : Form
    {
        public ProveedorAE()
        {
            InitializeComponent();
        }
        private Proveedor proveedor;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboBoxs.CargarComboLocalidades(ref ComboBoxLocalidades);
            if (proveedor != null)
            {
                TextBoxNombreProveedor.Text = proveedor.NombreProveedor;
                TextBoxApellidoProveedor.Text = proveedor.ApellidoProveedor;
                TextBoxTelefono.Text = proveedor.Telefono.ToString();
                TextBoxEmail.Text = proveedor.Email;
                ComboBoxLocalidades.SelectedValue = proveedor.LocalidadId;
            }
        }

        public Proveedor GetProveedor()
        {
            return proveedor;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (proveedor == null)
                {
                    proveedor = new Proveedor();
                }
                proveedor.NombreProveedor = TextBoxNombreProveedor.Text;
                proveedor.ApellidoProveedor = TextBoxApellidoProveedor.Text;
                proveedor.Telefono= TextBoxTelefono.Text;
                proveedor.Email= TextBoxEmail.Text;
                proveedor.LocalidadId =(int)ComboBoxLocalidades.SelectedValue;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            var val = true;
            if (string.IsNullOrEmpty(TextBoxNombreProveedor.Text))
            {
                errorProvider1.SetError(TextBoxNombreProveedor,
                    "Nombre mal ingresado!!!");
                val= false;
            }
            if (string.IsNullOrEmpty(TextBoxApellidoProveedor.Text))
            {
                errorProvider1.SetError(TextBoxApellidoProveedor,
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
                errorProvider1.SetError(ComboBoxLocalidades, "Debe seleccionar una Localidad");
                val = false;
            }
            return val;
        }

        public void SetProveedor(Proveedor proveedor)
        {
            this.proveedor = proveedor;
        }
    }
}
