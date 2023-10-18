using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Granja:ICloneable
    {
        public int GranjaId { get; set; }
        public int LocalidadId { get; set; }
        public string NombreGranja { get; set; }
        public string Direccion { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
