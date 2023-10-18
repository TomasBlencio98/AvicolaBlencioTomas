using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioEmpleados
    {
        void Guardar(Empleado empleado);
        void Borrar(int EmpleadoId);
        int GetCantidad();
        List<EmpleadoDto> GetEmpleados();
        bool Existe(Empleado empleado);
        Empleado GetEmpleadosPorId(int EmpleadoId);
    }
}
