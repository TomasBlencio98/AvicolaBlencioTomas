using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioAlimentos
    {
        void Guardar(Alimento Alimento);
        void Borrar(int AlimentoId);
        int GetCantidad();
        List<Alimento> GetAlimentos();
        bool Existe(Alimento alimento);
    }
}
