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

namespace ProyectoAvicola.Windows.Formularios.Alimentos
{
    public partial class AlimentosAE : Form
    {
        public AlimentosAE()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (alimento != null)
            {
                TextBoxAlimento.Text = alimento.TipoAlimento;
            }
        }
        private Alimento alimento;
        public Alimento GetAlimento()
        {
            return alimento;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (alimento == null)
                {
                    alimento = new Alimento();
                }
                alimento.TipoAlimento = TextBoxAlimento.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(TextBoxAlimento.Text))
            {
                errorProvider1.SetError(TextBoxAlimento,
                    "Alimento mal ingresado!!!");
                return false;
            }
            return true;
        }

        public void SetAlimento(Alimento alimento)
        {
            this.alimento = alimento;
        }
    }
}
