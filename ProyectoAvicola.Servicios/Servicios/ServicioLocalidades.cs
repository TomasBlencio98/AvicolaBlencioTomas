using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Datos.Repositorios;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Servicios
{
    public class ServicioLocalidades:IServicioLocalidades
    {
        private readonly IRepositorioLocalidades repositorioLocalidades;
        public ServicioLocalidades()
        {
            repositorioLocalidades = new RepositorioLocalidades();
        }

        public void Borrar(int LocalidadId)
        {
            try
            {
                repositorioLocalidades.Borrar(LocalidadId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Localidad localidad)
        {
            try
            {
                return repositorioLocalidades.Existe(localidad);
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
                return repositorioLocalidades.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Localidad> GetLocalidades()
        {
            try
            {
                return repositorioLocalidades.GetLocalidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Localidad localidad)
        {
            try
            {
                if (localidad.LocalidadId==0)
                {

                    repositorioLocalidades.Agregar(localidad);
                }
                else
                {
                    repositorioLocalidades.Editar(localidad);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
