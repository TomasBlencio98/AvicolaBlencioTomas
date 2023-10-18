using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Datos.Repositorios;
using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Servicios
{
    public class ServicioEmpleados : IServicioEmpleados
    {
        private readonly IRepositorioEmpleados repositorioEmpleados;

        public ServicioEmpleados()
        {
            repositorioEmpleados = new RepositorioEmpleados();
        }


        public void Borrar(int EmpleadoId)
        {
            try
            {
                repositorioEmpleados.Borrar(EmpleadoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Empleado empleado)
        {
            try
            {
                return repositorioEmpleados.Existe(empleado);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad()
        {
            try
            {
                return repositorioEmpleados.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<EmpleadoDto> GetEmpleados()
        {
            try
            {
                return repositorioEmpleados.GetEmpleados();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Empleado GetEmpleadosPorId(int EmpleadoId)
        {
            try
            {
                return repositorioEmpleados.GetEmpleadoPorId(EmpleadoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Empleado empleado)
        {
            try
            {
                if (empleado.EmpleadoId==0)
                {
                    repositorioEmpleados.Agregar(empleado);
                }
                else
                {
                    repositorioEmpleados.Editar(empleado);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
