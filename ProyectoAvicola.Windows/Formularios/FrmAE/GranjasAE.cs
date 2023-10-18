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
    public partial class GranjasAE : Form
    {
        public GranjasAE()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ComboBoxs.CargarComboLocalidades(ref ComboBoxLocalidades);
            if (granja!=null)
            {
                TextBoxNameGranja.Text = granja.NombreGranja;
                TextBoxDireGranja.Text = granja.Direccion;
                ComboBoxLocalidades.SelectedValue = granja.LocalidadId;
            }
        }

        private Granja granja;
        public Granja GetGranja()
        {
            return granja;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (granja == null)
                {
                    granja = new Granja();
                }
                granja.NombreGranja = TextBoxNameGranja.Text;
                granja.Direccion = TextBoxDireGranja.Text;
                granja.LocalidadId = (int)ComboBoxLocalidades.SelectedValue;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            var val = true;
            if (string.IsNullOrEmpty(TextBoxNameGranja.Text))
            {
                errorProvider1.SetError(TextBoxNameGranja,
                    "Nombre mal ingresado!!!");
                val = false;
            }
            if (string.IsNullOrEmpty(TextBoxDireGranja.Text))
            {
                errorProvider1.SetError(TextBoxDireGranja,
                    "Direccion mal ingresada!!!");
                val = false;
            }
            if (ComboBoxLocalidades.SelectedIndex == 0)
            {
                errorProvider1.SetError(ComboBoxLocalidades, "Debe seleccionar una Localidad");
                val = false;
            }
            return val;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }

        public void SetGranja(Granja granja)
        {
            this.granja= granja;
        }
    }
}
