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
    public class ServicioGranjas : IServicioGranjas
    {
        private readonly IRepositorioGranjas repositorioGranjas;
        public ServicioGranjas()
        {
            repositorioGranjas = new RepositorioGranjas();
        }
        public void Borrar(int GranjaId)
        {
            try
            {
                repositorioGranjas.Borrar(GranjaId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Granja granja)
        {
            try
            {
                return repositorioGranjas.Existe(granja);
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
                return repositorioGranjas.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<GranjaDto> GetGranjas()
        {
            try
            {
                return repositorioGranjas.GetGranjas();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Granja GetGranjasPorId(int GranjaId)
        {
            try
            {
                return repositorioGranjas.GetGranjasPorId(GranjaId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Granja Granja)
        {
            try
            {
                if (Granja.GranjaId==0)
                {
                    repositorioGranjas.Agregar(Granja);
                }
                else
                {
                    repositorioGranjas.Editar(Granja);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
