using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioGalpones
    {
        void Agregar(Galpon galpon);
        void Borrar(int GalponId);
        void Editar(Galpon galpon);
        int GetCantidad();
        List<GalponDto> GetGalpones();
        bool Existe(Galpon galpon);
        Galpon GetGalponesPorId(int GalponId);
    }
}
