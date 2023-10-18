using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Interfaces;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Formularios.FrmAE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Windows.Helpers
{
    public static class GridHelpers
    {
        public static void MostrarDatosEnGrilla<T>(DataGridView dgv, List<T> lista) where T : class
        {
            LimpiarGrilla(dgv);
            foreach (var item in lista)
            {
                var r = ConstruirFila(dgv);
                SetearFila(r, item);
                AgregarFila(dgv, r);
            }
        }
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }
        public static void AgregarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Add(r);
        }

        public static void QuitarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Remove(r);
        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Alimento alimento:
                    r.Cells[0].Value = alimento.TipoAlimento;
                    break;
                case Medicamento medicamento:
                    r.Cells[0].Value = medicamento.TipoMedicamento;
                    break;
                case Localidad localidad:
                    r.Cells[0].Value = localidad.NombreLocalidad;
                    r.Cells[1].Value = localidad.CodigoPostal;
                    break;
                case ProveedorDto proveedor:
                    r.Cells[0].Value = proveedor.NombreProveedor;
                    r.Cells[1].Value = proveedor.ApellidoProveedor;
                    r.Cells[2].Value = proveedor.Telefono;
                    r.Cells[3].Value = proveedor.NombreLocalidad;
                    break;
                case EmpleadoDto empleado:
                    r.Cells[0].Value = empleado.NombreEmpleado;
                    r.Cells[1].Value = empleado.ApellidoEmpleado;
                    r.Cells[2].Value = empleado.Telefono;
                    r.Cells[3].Value = empleado.NombreLocalidad;
                    r.Cells[4].Value = empleado.NombreGranja;
                    break;
                case GranjaDto granja:
                    r.Cells[0].Value = granja.NombreGranja;
                    r.Cells[1].Value = granja.NombreLocalidad;
                    r.Cells[2].Value = granja.Direccion;
                    break;

            }
            r.Tag = obj;

        }

        public static void CargarGrilla<T>(DataGridView DgvDatos, params string[] columnNames)
        {
            DgvDatos.Columns.Clear();

            foreach (var columnName in columnNames)
            {
                if (columnName != columnNames[0])
                {
                    var columna = new DataGridViewTextBoxColumn();
                    columna.Name = "Columna" + columnName;
                    columna.HeaderText = columnName;
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    DgvDatos.Columns.Add(columna);
                }
            }
        }

    }
}
