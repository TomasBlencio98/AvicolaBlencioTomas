using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Transaccion_Alimento
    {
        public int TransaccionAlimentoId { get; set; }
        public int TransaccionId { get; set; }
        public int AlimentoId { get; set; }
        public int Cantidad { get; set; }

    }
}
