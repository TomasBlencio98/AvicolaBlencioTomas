using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Servicios.Interfaces
{
    public interface IServicioLocalidades
    {
        void Guardar(Localidad localidad);
        void Borrar(int LocalidadId);
        int GetCantidad();
        List<Localidad> GetLocalidades();
        bool Existe(Localidad localidad);
    }
}
