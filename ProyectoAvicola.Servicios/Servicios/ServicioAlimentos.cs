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
    public class ServicioAlimentos : IServicioAlimentos
    {
        private readonly IRepositorioAlimentos repositorioAlimentos;
        public ServicioAlimentos()
        {
            repositorioAlimentos = new RepositorioAlimentos();
        }
        public void Borrar(int AlimentoId)
        {
            try
            {
                repositorioAlimentos.Borrar(AlimentoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Alimento alimento)
        {
            try
            {
                return repositorioAlimentos.Existe(alimento);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Alimento> GetAlimentos()
        {
            try
            {
                return repositorioAlimentos.GetAlimentos();
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
                return repositorioAlimentos.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Alimento Alimento)
        {
            try
            {
                if (Alimento.AlimentoId==0)
                {
                    repositorioAlimentos.Agregar(Alimento);
                }
                else
                {
                    repositorioAlimentos.Editar(Alimento);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
