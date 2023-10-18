using ProyectoAvicola.Entidades.Dtos;
using ProyectoAvicola.Entidades.Entidades;
using ProyectoAvicola.Servicios.Servicios;
using ProyectoAvicola.Windows.Formularios.Alimentos;
using ProyectoAvicola.Windows.Formularios.FrmAE;
using ProyectoAvicola.Windows.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAvicola.Windows
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
            servicioAlimentos = new ServicioAlimentos();
            servicioMedicamentos = new ServicioMedicamentos();
            servicioLocalidades = new ServicioLocalidades();
            servicioProveedores = new ServicioProveedores();
            servicioEmpleados = new ServicioEmpleados();
            servicioGranjas = new ServicioGranjas();
            servicioGalpones = new ServicioGalpones();
        }

        private readonly ServicioAlimentos servicioAlimentos;
        private List<Alimento> listaAlimento;
        private readonly ServicioMedicamentos servicioMedicamentos;
        private List<Medicamento> listaMedicamento;
        private readonly ServicioLocalidades servicioLocalidades;
        private List<Localidad> listaLocalidad;
        private readonly ServicioProveedores servicioProveedores;
        private List<ProveedorDto> listaProveedores;
        private readonly ServicioEmpleados servicioEmpleados;
        private List<EmpleadoDto> listaEmpleados;
        private readonly ServicioGranjas servicioGranjas;
        private List<GranjaDto> listaGranjas;
        private readonly ServicioGalpones servicioGalpones;
        private List<GalponDto> listaGalpones;

        //Tengo todo el repo y servicio de galpones terminado
        //Falta todo lo que es formulario


        #region Entidad Alimentos

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlimentosButtonsEnabel();
            string[] columnas = typeof(Alimento).GetProperties().Select(p => { var displayNameAttribute = (DisplayNameAttribute)Attribute.GetCustomAttribute(p, typeof(DisplayNameAttribute)); return displayNameAttribute != null ? displayNameAttribute.DisplayName : p.Name; }).ToArray();
            GridHelpers.CargarGrilla<Alimento>(DgvDatos, columnas);
            RefrescarGrillaAlimentos();
        }

        private void AlimentosButtonsEnabel()
        {
            DropDownButtonGalpones.Enabled = false;
            DropDownButtonEmpleados.Enabled = false;
            DropDownButtonProveedores.Enabled = false;
            DropDownButtonTransacciones.Enabled = false;
            DropDownButtonGranja.Enabled = false;
            DropDownButtonMedicamento.Enabled = false;
            DropDownButtonLocalidades.Enabled = false;
        }

        private void RefrescarGrillaAlimentos()
        {
            listaAlimento = servicioAlimentos.GetAlimentos();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaAlimento);
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlimentosAE frm = new AlimentosAE();
            frm.Text = "Agregar Alimento";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var alimento = frm.GetAlimento();
                if (!servicioAlimentos.Existe(alimento))
                {
                    servicioAlimentos.Guardar(alimento);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, alimento);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    RefrescarGrillaAlimentos();
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            Alimento alimento = (Alimento)r.Tag;
            Alimento alimentoCopia = (Alimento)alimento.Clone();

            try
            {
                AlimentosAE frm = new AlimentosAE() { Text = "Editar Alimento" };
                frm.SetAlimento(alimento);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                alimento = frm.GetAlimento();
                if (!servicioAlimentos.Existe(alimento))
                {
                    servicioAlimentos.Guardar(alimento);
                    GridHelpers.SetearFila(r, alimento);
                    RefrescarGrillaAlimentos();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, alimentoCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, alimentoCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void borrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            Alimento alimento = (Alimento)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioAlimentos.Borrar(alimento.AlimentoId);
                GridHelpers.QuitarFila(DgvDatos, r);
                RefrescarGrillaAlimentos();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        #endregion


        #region Entidad Medicamentos
        private void listarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MedicamentosButtonsEnabel();
            string[] columnas = typeof(Medicamento).GetProperties().Select(p => { var displayNameAttribute = (DisplayNameAttribute)Attribute.GetCustomAttribute(p, typeof(DisplayNameAttribute)); return displayNameAttribute != null ? displayNameAttribute.DisplayName : p.Name; }).ToArray();
            GridHelpers.CargarGrilla<Medicamento>(DgvDatos, columnas);
            RefrescarGrillaMedicamentos();
        }

        private void MedicamentosButtonsEnabel()
        {
            DropDownButtonGalpones.Enabled = false;
            DropDownButtonEmpleados.Enabled = false;
            DropDownButtonProveedores.Enabled = false;
            DropDownButtonTransacciones.Enabled = false;
            DropDownButtonAlimento.Enabled = false;
            DropDownButtonGranja.Enabled = false;
            DropDownButtonLocalidades.Enabled = false;
        }

        private void RefrescarGrillaMedicamentos()
        {
            listaMedicamento = servicioMedicamentos.GetMedicamentos();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaMedicamento);
        }

        private void nuevoToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            MedicamentosAE frm = new MedicamentosAE();
            frm.Text = "Agregar Medicamento";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var medicamento = frm.GetMedicamento();
                if (!servicioMedicamentos.Existe(medicamento))
                {
                    servicioMedicamentos.Guardar(medicamento);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, medicamento);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    RefrescarGrillaMedicamentos();
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            Medicamento medicamento = (Medicamento)r.Tag;
            Medicamento medicamentoCopia = (Medicamento)medicamento.Clone();

            try
            {
                MedicamentosAE frm = new MedicamentosAE() { Text = "Editar Medicamento" };
                frm.SetMedicamento(medicamento);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                medicamento = frm.GetMedicamento();
                if (!servicioMedicamentos.Existe(medicamento))
                {
                    servicioMedicamentos.Guardar(medicamento);
                    GridHelpers.SetearFila(r, medicamento);
                    RefrescarGrillaMedicamentos();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, medicamentoCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, medicamentoCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void borrarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            Medicamento medicamento = (Medicamento)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioMedicamentos.Borrar(medicamento.MedicamentoId);
                GridHelpers.QuitarFila(DgvDatos, r);
                RefrescarGrillaMedicamentos();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion


        #region Entidad Localidades
        private void listarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            LocalidadesButtonsEnabel();
            string[] columnas = typeof(Localidad).GetProperties().Select(p => { var displayNameAttribute = (DisplayNameAttribute)Attribute.GetCustomAttribute(p, typeof(DisplayNameAttribute)); return displayNameAttribute != null ? displayNameAttribute.DisplayName : p.Name; }).ToArray();
            GridHelpers.CargarGrilla<Localidad>(DgvDatos, columnas);
            RefrescarGrillaLocalidades();
        }

        private void LocalidadesButtonsEnabel()
        {
            DropDownButtonGalpones.Enabled = false;
            DropDownButtonEmpleados.Enabled = false;
            DropDownButtonProveedores.Enabled = false;
            DropDownButtonTransacciones.Enabled = false;
            DropDownButtonAlimento.Enabled = false;
            DropDownButtonMedicamento.Enabled = false;
            DropDownButtonGranja.Enabled = false;
        }

        private void RefrescarGrillaLocalidades()
        {
            listaLocalidad = servicioLocalidades.GetLocalidades();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaLocalidad);
        }

        private void nuevoToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            LocalidadesAE frm = new LocalidadesAE();
            frm.Text = "Agregar Localidad";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var localidad = frm.GetLocalidad();
                if (!servicioLocalidades.Existe(localidad))
                {
                    servicioLocalidades.Guardar(localidad);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, localidad);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    RefrescarGrillaLocalidades();
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            Localidad localidad = (Localidad)r.Tag;
            Localidad localidadCopia = (Localidad)localidad.Clone();

            try
            {
                LocalidadesAE frm = new LocalidadesAE() { Text = "Editar Localidad" };
                frm.SetLocalidad(localidad);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                localidad = frm.GetLocalidad();
                if (!servicioLocalidades.Existe(localidad))
                {
                    servicioLocalidades.Guardar(localidad);
                    GridHelpers.SetearFila(r, localidad);
                    RefrescarGrillaLocalidades();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, localidadCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, localidadCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void borrarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            Localidad localidad = (Localidad)r.Tag;
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioLocalidades.Borrar(localidad.LocalidadId);
                GridHelpers.QuitarFila(DgvDatos, r);
                RefrescarGrillaLocalidades();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion


        #region Entidad Proveedores
        private void listarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ProveedoresButtonsEnabel();
            string[] columnas = typeof(ProveedorDto).GetProperties().Select(p => { var displayNameAttribute = (DisplayNameAttribute)Attribute.GetCustomAttribute(p, typeof(DisplayNameAttribute)); return displayNameAttribute != null ? displayNameAttribute.DisplayName : p.Name; }).ToArray();
            GridHelpers.CargarGrilla<ProveedorDto>(DgvDatos, columnas);
            RefrescarGrillaProveedores();
        }

        private void ProveedoresButtonsEnabel()
        {
            DropDownButtonGalpones.Enabled = false;
            DropDownButtonEmpleados.Enabled = false;
            DropDownButtonGranja.Enabled = false;
            DropDownButtonTransacciones.Enabled = false;
            DropDownButtonAlimento.Enabled = false;
            DropDownButtonMedicamento.Enabled = false;
            DropDownButtonLocalidades.Enabled = false;
        }

        private void nuevoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ProveedorAE frm = new ProveedorAE();
            frm.Text = "Agregar Proveedor";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var proveedor = frm.GetProveedor();
                if (!servicioProveedores.Existe(proveedor))
                {
                    servicioProveedores.Guardar(proveedor);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, proveedor);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    RefrescarGrillaProveedores();
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RefrescarGrillaProveedores()
        {
            listaProveedores = servicioProveedores.GetProveedores();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaProveedores);
        }

        private void editarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            ProveedorDto proveedorDto = (ProveedorDto)r.Tag;
            Proveedor proveedor = servicioProveedores.GetProveedorPorId(proveedorDto.ProveedorId);
            Proveedor proveedorCopia = (Proveedor)proveedor.Clone();

            try
            {
                ProveedorAE frm = new ProveedorAE() { Text = "Editar Proveedor" };
                frm.SetProveedor(proveedor);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                proveedor = frm.GetProveedor();
                if (!servicioProveedores.Existe(proveedor))
                {
                    servicioProveedores.Guardar(proveedor);
                    GridHelpers.SetearFila(r, proveedor);
                    RefrescarGrillaProveedores();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, proveedorCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, proveedorCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void borrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            ProveedorDto proveedorDto = (ProveedorDto)r.Tag;
            Proveedor proveedor = servicioProveedores.GetProveedorPorId(proveedorDto.ProveedorId);
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioProveedores.Borrar(proveedor.ProveedorId);
                GridHelpers.QuitarFila(DgvDatos, r);
                RefrescarGrillaProveedores();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion


        #region Entidad Granjas
        private void listarToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            GranjasButtonEnabel();
            string[] columnas = typeof(GranjaDto).GetProperties().Select(p => { var displayNameAttribute = (DisplayNameAttribute)Attribute.GetCustomAttribute(p, typeof(DisplayNameAttribute)); return displayNameAttribute != null ? displayNameAttribute.DisplayName : p.Name; }).ToArray();
            GridHelpers.CargarGrilla<GranjaDto>(DgvDatos, columnas);
            RefrescarGrillaGranjas();
        }

        private void GranjasButtonEnabel()
        {
            DropDownButtonGalpones.Enabled = false;
            DropDownButtonEmpleados.Enabled = false;
            DropDownButtonProveedores.Enabled = false;
            DropDownButtonTransacciones.Enabled = false;
            DropDownButtonAlimento.Enabled = false;
            DropDownButtonMedicamento.Enabled = false;
            DropDownButtonLocalidades.Enabled = false;
        }

        private void RefrescarGrillaGranjas()
        {
            listaGranjas = servicioGranjas.GetGranjas();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaGranjas);
        }

        private void nuevoToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            GranjasAE frm = new GranjasAE();
            frm.Text = "Agregar Granja";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var granja = frm.GetGranja();
                if (!servicioGranjas.Existe(granja))
                {
                    servicioGranjas.Guardar(granja);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, granja);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    RefrescarGrillaGranjas();
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            GranjaDto granjaDto = (GranjaDto)r.Tag;
            Granja granja = servicioGranjas.GetGranjasPorId(granjaDto.GranjaId);
            Granja granjaCopia = (Granja)granja.Clone();

            try
            {
                GranjasAE frm = new GranjasAE() { Text = "Editar Granja" };
                frm.SetGranja(granja);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                granja = frm.GetGranja();
                if (!servicioGranjas.Existe(granja))
                {
                    servicioGranjas.Guardar(granja);
                    GridHelpers.SetearFila(r, granja);
                    RefrescarGrillaGranjas();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, granjaCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, granjaCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void borrarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            GranjaDto granjaDto = (GranjaDto)r.Tag;
            Granja granja = servicioGranjas.GetGranjasPorId(granjaDto.GranjaId);
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioGranjas.Borrar(granja.GranjaId);
                GridHelpers.QuitarFila(DgvDatos, r);
                RefrescarGrillaGranjas();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion


        #region Entidad Empleados
        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmpleadosButtonsEnabel();
            string[] columnas = typeof(EmpleadoDto).GetProperties().Select(p => { var displayNameAttribute = (DisplayNameAttribute)Attribute.GetCustomAttribute(p, typeof(DisplayNameAttribute)); return displayNameAttribute != null ? displayNameAttribute.DisplayName : p.Name; }).ToArray();
            GridHelpers.CargarGrilla<EmpleadoDto>(DgvDatos, columnas);
            RefrescarGrillaEmpleados();
        }

        private void EmpleadosButtonsEnabel()
        {
            DropDownButtonGalpones.Enabled = false;
            DropDownButtonGranja.Enabled = false;
            DropDownButtonProveedores.Enabled = false;
            DropDownButtonTransacciones.Enabled = false;
            DropDownButtonAlimento.Enabled = false;
            DropDownButtonMedicamento.Enabled = false;
            DropDownButtonLocalidades.Enabled = false;
        }

        private void RefrescarGrillaEmpleados()
        {
            listaEmpleados = servicioEmpleados.GetEmpleados();
            GridHelpers.MostrarDatosEnGrilla(DgvDatos, listaEmpleados);
        }

        private void nuevoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            EmpleadosAE frm = new EmpleadosAE();
            frm.Text = "Agregar Empleado";
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                var empleado = frm.GetEmpleado();
                if (!servicioEmpleados.Existe(empleado))
                {
                    servicioEmpleados.Guardar(empleado);
                    DataGridViewRow r = GridHelpers.ConstruirFila(DgvDatos);
                    GridHelpers.SetearFila(r, empleado);
                    GridHelpers.AgregarFila(DgvDatos, r);
                    RefrescarGrillaEmpleados();
                    MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Registro existente", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void editarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            EmpleadoDto empleadoDto = (EmpleadoDto)r.Tag;
            Empleado empleado = servicioEmpleados.GetEmpleadosPorId(empleadoDto.EmpleadoId);
            Empleado empleadoCopia = (Empleado)empleado.Clone();

            try
            {
                EmpleadosAE frm = new EmpleadosAE() { Text = "Editar Empleado" };
                frm.SetEmpleado(empleado);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    return;
                }
                empleado = frm.GetEmpleado();
                if (!servicioEmpleados.Existe(empleado))
                {
                    servicioEmpleados.Guardar(empleado);
                    GridHelpers.SetearFila(r, empleado);
                    RefrescarGrillaEmpleados();
                    MessageBox.Show("Registro editado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.SetearFila(r, empleadoCopia);
                    MessageBox.Show("Registro duplicado!!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                GridHelpers.SetearFila(r, empleadoCopia);
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void borrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (DgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            var r = DgvDatos.SelectedRows[0];
            EmpleadoDto empleadoDto = (EmpleadoDto)r.Tag;
            Empleado empleado = servicioEmpleados.GetEmpleadosPorId(empleadoDto.EmpleadoId);
            try
            {
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                servicioEmpleados.Borrar(empleado.EmpleadoId);
                GridHelpers.QuitarFila(DgvDatos, r);
                RefrescarGrillaEmpleados();
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion





        private void ButtonRefrescar_Click(object sender, EventArgs e)
        {
            DropDownButtonGranja.Enabled = true;
            DropDownButtonGalpones.Enabled = true;
            DropDownButtonEmpleados.Enabled = true;
            DropDownButtonProveedores.Enabled = true;
            DropDownButtonTransacciones.Enabled = true;
            DropDownButtonAlimento.Enabled = true;
            DropDownButtonMedicamento.Enabled = true;
            DropDownButtonLocalidades.Enabled = true;
            DgvDatos.Columns.Clear();
            GridHelpers.LimpiarGrilla(DgvDatos);
        }



    }
}
