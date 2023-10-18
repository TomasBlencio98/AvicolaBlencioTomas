using System.ComponentModel;

namespace ProyectoAvicola.Entidades.Entidades
{
    public class Alimento : ICloneable
    {
        public int AlimentoId { get; set; }
        [DisplayName("Alimento")]
        public string TipoAlimento { get; set; }

        public object Clone()
        {
            return MemberwiseClone();

        }
    }
}