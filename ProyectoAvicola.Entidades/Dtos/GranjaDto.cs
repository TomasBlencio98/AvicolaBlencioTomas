using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Dtos
{
    public class GranjaDto:ICloneable
    {
        public int GranjaId { get; set; }
        [DisplayName("Granja")]
        public string NombreGranja { get; set; }
        [DisplayName("Localidad")]
        public string NombreLocalidad { get; set; }
        [DisplayName("Direccion")]
        public string Direccion { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
