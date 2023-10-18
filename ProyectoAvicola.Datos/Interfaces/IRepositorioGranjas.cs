using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioGranjas
    {
        void Agregar(Granja Granja);
        void Borrar(int GranjaId);
        void Editar(Granja Granja);
        int GetCantidad();
        List<GranjaDto> GetGranjas();
        bool Existe(Granja granja);
        Granja GetGranjasPorId(int GranjaId);
    }
}
