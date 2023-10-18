using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Localidad : ICloneable
    {
        public int LocalidadId { get; set; }
        [DisplayName("Localidad")]
        public string NombreLocalidad { get; set; }
        [DisplayName("Codigo Postal")]
        public string CodigoPostal { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
