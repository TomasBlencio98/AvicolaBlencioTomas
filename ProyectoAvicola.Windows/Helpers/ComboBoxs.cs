using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using ProyectoAvicola.Servicios.Servicios;

namespace ProyectoAvicola.Windows.Helpers
{
    public static class ComboBoxs
    {
        public static void CargarComboLocalidades(ref ComboBox combo)
        {
            IServicioLocalidades serviciosLocalidades = new ServicioLocalidades();
            var lista = serviciosLocalidades.GetLocalidades();
            var defaultLocalidad = new Localidad()
            {
                LocalidadId = 0,
                NombreLocalidad = "Seleccione Localidad"
            };
            lista.Insert(0, defaultLocalidad);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreLocalidad";
            combo.ValueMember = "LocalidadId";
            combo.SelectedIndex = 0;
        }
        public static void CargarComboGranjas(ref ComboBox combo)
        {
            IServicioGranjas servicioGranjas = new ServicioGranjas();
            var lista=servicioGranjas.GetGranjas();
            var defaultGranja = new GranjaDto()
            {
                GranjaId = 0,
                NombreGranja = "Seleccione Granja",
            };
            lista.Insert(0, defaultGranja);
            combo.DataSource = lista;
            combo.DisplayMember = "NombreGranja";
            combo.ValueMember = "GranjaId";
            combo.SelectedIndex = 0;
        }


    }
}
