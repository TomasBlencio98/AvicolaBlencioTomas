using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioAlimentos
    {
        void Agregar(Alimento alimento);
        void Borrar(int AlimentoId);
        void Editar(Alimento Alimento);
        int GetCantidad();
        List<Alimento> GetAlimentos();
        bool Existe(Alimento alimento);
    }
}
