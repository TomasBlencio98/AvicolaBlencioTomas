using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Proveedor : ICloneable
    {
        public int ProveedorId { get; set; }
        public int LocalidadId { get; set; }
        public string NombreProveedor { get; set; }
        public string ApellidoProveedor { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
