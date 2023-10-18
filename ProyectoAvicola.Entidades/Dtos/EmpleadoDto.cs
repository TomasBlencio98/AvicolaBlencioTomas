using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Dtos
{
    public class EmpleadoDto:ICloneable
    {
        public int EmpleadoId { get; set; }
        [DisplayName("Nombre")]
        public string NombreEmpleado { get; set; }
        [DisplayName("Apellido")]
        public string ApellidoEmpleado { get; set; }
        [DisplayName("Telefono")]
        public string Telefono { get; set; }
        [DisplayName("Localidad")]
        public string NombreLocalidad { get; set; }
        [DisplayName("Granja")]
        public string NombreGranja { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
