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
    public class RepositorioLocalidades : IRepositorioLocalidades
    {
        private readonly string cadenaConexion;
        public RepositorioLocalidades()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Localidad localidad)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"insert into Localidad (NombreLocalidad,CodigoPostal) values (@NombreLocalidad,@CodigoPostal);
                            SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, localidad);
                localidad.LocalidadId = id;
            }
        }

        public void Borrar(int LocalidadId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Localidad WHERE LocalidadId=@LocalidadId";
                conn.Execute(deleteQuery, new { LocalidadId });
            }
        }

        public void Editar(Localidad localidad)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"UPDATE Localidad SET NombreLocalidad=@NombreLocalidad, 
                 CodigoPostal=@CodigoPostal WHERE LocalidadId=@LocalidadId";
                conn.Execute(updateQuery, localidad);
            }
        }

        public bool Existe(Localidad localidad)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (localidad.LocalidadId == 0)
                {
                    selectQuery = "SELECT COUNT(*) FROM Localidad WHERE NombreLocalidad=@NombreLocalidad AND CodigoPostal=@CodigoPostal";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, localidad);
                }
                else
                {
                    selectQuery = "SELECT COUNT(*) FROM Localidad WHERE NombreLocalidad=@NombreLocalidad AND CodigoPostal=@CodigoPostal AND LocalidadId!=@LocalidadId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, localidad);
                }
            }
            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Localidad";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }

        public List<Localidad> GetLocalidad()
        {
            List<Localidad> lista = new List<Localidad>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT LocalidadId,NombreLocalidad,CodigoPostal FROM Localidad";
                lista = conn.Query<Localidad>(selectQuery).ToList();
            }
            return lista;
        }
    }
}
