using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Mortalidad
    {
        public int MortalidadId { get; set; }
        public int DetalleGalponId { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
    }
}
