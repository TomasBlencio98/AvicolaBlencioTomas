using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioGalpones
    {
        void Guardar(Galpon galpon);
        void Borrar(int GalponId);
        int GetCantidad();
        List<GalponDto> GetGalpones();
        bool Existe(Galpon galpon);
        Galpon GetGalponesPorId(int GalponId);
    }
}
