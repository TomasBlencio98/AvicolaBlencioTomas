using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioMedicamentos
    {
        void Agregar(Medicamento medicamento);
        void Borrar(int MedicamentoId);
        void Editar(Medicamento medicamento);
        int GetCantidad();
        List<Medicamento> GetMedicamentos();
        bool Existe(Medicamento medicamento);
    }
}
