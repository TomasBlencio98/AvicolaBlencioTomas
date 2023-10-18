using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioProveedores
    {
        void Guardar(Proveedor proveedor);
        void Borrar(int ProveedorId);
        int GetCantidad();
        List<ProveedorDto> GetProveedores();
        bool Existe(Proveedor proveedor);
        Proveedor GetProveedorPorId(int proveedorId);
    }
}
