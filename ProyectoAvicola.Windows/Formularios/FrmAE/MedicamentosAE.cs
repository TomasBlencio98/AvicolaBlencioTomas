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
    public partial class MedicamentosAE : Form
    {
        public MedicamentosAE()
        {
            InitializeComponent();
        }
        private Medicamento medicamento;
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (medicamento!=null)
            {
                TextBoxMedicamento.Text = medicamento.TipoMedicamento;
            }
        }
        public Medicamento GetMedicamento()
        {
            return medicamento;
        }

        private void ButtonAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (medicamento == null)
                {
                    medicamento = new Medicamento();
                }
                medicamento.TipoMedicamento = TextBoxMedicamento.Text;

                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            if (string.IsNullOrEmpty(TextBoxMedicamento.Text))
            {
                errorProvider1.SetError(TextBoxMedicamento,
                    "Medicamento mal ingresado!!!");
                return false;
            }
            return true;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void SetMedicamento(Medicamento medicamento)
        {
            this.medicamento = medicamento;
        }
    }
}
