using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioGranjas
    {
        void Guardar(Granja Granja);
        void Borrar(int GranjaId);
        int GetCantidad();
        List<GranjaDto> GetGranjas();
        bool Existe(Granja granja);
        Granja GetGranjasPorId(int GranjaId);
    }
}
