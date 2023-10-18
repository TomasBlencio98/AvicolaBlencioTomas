using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class DetalleGalpon_Alimento
    {
        public int DetalleGalponAlimentosId { get; set; }
        public int DetalleGalponId { get; set; }
        public int AlimentoId { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
