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
    public class RepositorioAlimentos : IRepositorioAlimentos
    {
        private readonly string cadenaConexion;

        public RepositorioAlimentos()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Alimento alimento)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"insert into Alimento (TipoAlimento) values (@TipoAlimento);
                            SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, alimento);
                alimento.AlimentoId = id;
            }
        }

        public void Borrar(int AlimentoId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Alimento WHERE AlimentoId=@AlimentoId";
                conn.Execute(deleteQuery,new { AlimentoId });
            }
        }

        public void Editar(Alimento Alimento)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"UPDATE Alimento SET TipoAlimento=@TipoAlimento
                    WHERE AlimentoId=@AlimentoId";
                conn.Execute(updateQuery, Alimento);
            }
        }

        public bool Existe(Alimento alimento)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (alimento.AlimentoId == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Alimento WHERE TipoAlimento=@TipoAlimento";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, alimento);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Alimento WHERE TipoAlimento=@TipoAlimento AND AlimentoId!=@AlimentoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, alimento);
                }
            }
            return cantidad > 0;
        }

        public List<Alimento> GetAlimentos()
        {
            List<Alimento> lista = new List<Alimento>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT AlimentoId,TipoAlimento FROM Alimento";
                lista = conn.Query<Alimento>(selectQuery).ToList();
            }
            return lista;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Alimento";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }
    }
}
