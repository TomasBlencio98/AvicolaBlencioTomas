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
    public class ServicioGalpones : IServicioGalpones
    {
        private readonly IRepositorioGalpones repositorioGalpones;

        public ServicioGalpones()
        {
            repositorioGalpones = new RepositorioGalpones();
        }
        public void Borrar(int GalponId)
        {
            try
            {
                repositorioGalpones.Borrar(GalponId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Galpon galpon)
        {
            try
            {
                return repositorioGalpones.Existe(galpon);
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
                return repositorioGalpones.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<GalponDto> GetGalpones()
        {
            try
            {
                return repositorioGalpones.GetGalpones();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Galpon GetGalponesPorId(int GalponId)
        {
            try
            {
                return repositorioGalpones.GetGalponesPorId(GalponId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Galpon galpon)
        {
            try
            {
                if (galpon.GalponId==0)
                {
                    repositorioGalpones.Agregar(galpon);
                }
                else
                {
                    repositorioGalpones.Editar(galpon);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
