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
    public class ServicioMedicamentos : IServicioMedicamentos
    {
        private readonly IRepositorioMedicamentos repositorioMedicamentos;
        public ServicioMedicamentos()
        {
            repositorioMedicamentos= new RepositorioMedicamentos();
        }
        public void Borrar(int MedicamentoId)
        {
            try
            {
                repositorioMedicamentos.Borrar(MedicamentoId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Existe(Medicamento medicamento)
        {
            try
            {
                return repositorioMedicamentos.Existe(medicamento);
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
                return repositorioMedicamentos.GetCantidad();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Medicamento> GetMedicamentos()
        {
            try
            {
                return repositorioMedicamentos.GetMedicamentos();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Medicamento medicamento)
        {
            try
            {
                if (medicamento.MedicamentoId==0)
                {
                    repositorioMedicamentos.Agregar(medicamento);
                }
                else
                {
                    repositorioMedicamentos.Editar(medicamento);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
