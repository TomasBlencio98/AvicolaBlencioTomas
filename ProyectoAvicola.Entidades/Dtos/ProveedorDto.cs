using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Dtos
{
    public class ProveedorDto:ICloneable
    {
        public int ProveedorId { get; set; }

        [DisplayName("Nombre")]
        public string NombreProveedor { get; set; }

        [DisplayName("Apellido")]
        public string ApellidoProveedor { get; set; }
        [DisplayName("Telefono")]
        public string Telefono { get; set; }
        [DisplayName("Localidad")]
        public string NombreLocalidad { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
