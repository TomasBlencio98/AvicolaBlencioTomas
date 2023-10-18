using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioMedicamentos
    {
        void Guardar(Medicamento medicamento);
        void Borrar(int MedicamentoId);
        int GetCantidad();
        List<Medicamento> GetMedicamentos();
        bool Existe(Medicamento medicamento);
    }
}
