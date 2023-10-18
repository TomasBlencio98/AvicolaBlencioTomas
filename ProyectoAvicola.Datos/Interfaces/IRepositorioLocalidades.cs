using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Interfaces
{
    public interface IRepositorioLocalidades
    {
        void Agregar(Localidad localidad);
        void Borrar(int LocalidadId);
        void Editar(Localidad localidad);
        int GetCantidad();
        List<Localidad> GetLocalidad();
        bool Existe(Localidad localidad);
    }
}
