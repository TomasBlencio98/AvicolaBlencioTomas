using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Galpon:ICloneable
    {
        public int GalponId { get; set; }
        public int GranjaId { get; set; }
        public int Capacidad { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
