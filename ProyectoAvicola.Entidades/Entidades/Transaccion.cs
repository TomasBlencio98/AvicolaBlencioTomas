using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Transaccion
    {
        public int TransaccionId { get; set; }
        public int ProveedorId { get; set; }
        public DateTime Fecha { get; set; }
    }
}
