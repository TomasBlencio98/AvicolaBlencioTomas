using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioEmpleados
    {
        void Agregar(Empleado empleado);
        void Borrar(int EmpleadoId);
        void Editar(Empleado empleado);
        int GetCantidad();
        List<EmpleadoDto> GetEmpleados();
        bool Existe(Empleado empleado);
        Empleado GetEmpleadoPorId(int EmpleadoId);
    }
}
