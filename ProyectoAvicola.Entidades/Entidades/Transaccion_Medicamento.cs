using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Transaccion_Medicamento
    {
        public int TransaccionMedicamentoId { get; set; }
        public int TransaccionId { get; set; }
        public int MedicamentoId { get; set; }
        public int Cantidad { get; set; }
    }
}
