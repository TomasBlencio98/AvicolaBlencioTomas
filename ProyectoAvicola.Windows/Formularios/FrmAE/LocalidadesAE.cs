using ProyectoAvicola.Entidades.Entidades;
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
    public partial class LocalidadesAE : Form
    {
        public LocalidadesAE()
        {
            InitializeComponent();
        }
        private Localidad localidad;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (localidad!=null)
            {
                TextBoxLocalidad.Text = localidad.NombreLocalidad;
                TexBoxCodigoPostal.Text = localidad.CodigoPostal;
            }
        }
        public Localidad GetLocalidad()
        {
            return localidad;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (localidad == null)
                {
                    localidad = new Localidad();
                }
                localidad.NombreLocalidad = TextBoxLocalidad.Text;
                localidad.CodigoPostal = TexBoxCodigoPostal.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(TextBoxLocalidad.Text))
            {
                errorProvider1.SetError(TextBoxLocalidad,
                    "Localidad mal ingresado!!!");
                return false;
            }
            if (string.IsNullOrEmpty(TexBoxCodigoPostal.Text))
            {
                errorProvider1.SetError(TexBoxCodigoPostal,
                    "Codigo Postal mal ingresado!!!");
                return false;
            }
            return true;
        }

        public void SetLocalidad(Localidad localidad)
        {
            this.localidad = localidad;
        }
    }
}
