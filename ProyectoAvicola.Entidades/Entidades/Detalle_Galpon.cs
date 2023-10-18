using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Detalle_Galpon
    {
        public int DetalleGalponId { get; set; }
        public int GalponId { get; set; }
        public DateTime FechaHoy { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaEgreso { get; set; }
        public int TotalIngreso { get; set; }
    }
}
