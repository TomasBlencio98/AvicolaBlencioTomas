using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Empleado:ICloneable
    {
        public int EmpleadoId { get; set; }
        public int LocalidadId { get; set; }
        public int GranjaId { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public string Telefono { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
