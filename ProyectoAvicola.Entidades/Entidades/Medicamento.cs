using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Medicamento : ICloneable
    {
        public int MedicamentoId { get; set; }
        [DisplayName("Medicamento")]
        public string TipoMedicamento { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
