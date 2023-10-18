using Dapper;
using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAvicola.Datos.Repositorios
{
    public class RepositorioMedicamentos : IRepositorioMedicamentos
    {
        private readonly string cadenaConexion;
        public RepositorioMedicamentos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();

        }
        public void Agregar(Medicamento medicamento)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"insert into Medicamento (TipoMedicamento) values (@TipoMedicamento);
                            SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, medicamento);
                medicamento.MedicamentoId = id;
            }
        }

        public void Borrar(int MedicamentoId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Medicamento WHERE MedicamentoId=@MedicamentoId";
                conn.Execute(deleteQuery, new { MedicamentoId });
            }
        }

        public void Editar(Medicamento medicamento)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"UPDATE Medicamento SET TipoMedicamento=@TipoMedicamento
                    WHERE MedicamentoId=@MedicamentoId";
                conn.Execute(updateQuery, medicamento);
            }
        }

        public bool Existe(Medicamento medicamento)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (medicamento.MedicamentoId == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Medicamento WHERE TipoMedicamento=@TipoMedicamento";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, medicamento);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Medicamento WHERE TipoMedicamento=@TipoMedicamento AND MedicamentoId!=@MedicamentoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, medicamento);
                }
            }
            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Medicamento";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }

        public List<Medicamento> GetMedicamentos()
        {
            List<Medicamento> lista = new List<Medicamento>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT MedicamentoId,TipoMedicamento FROM Medicamento";
                lista = conn.Query <Medicamento>(selectQuery).ToList();
            }
            return lista;
        }
    }
}
