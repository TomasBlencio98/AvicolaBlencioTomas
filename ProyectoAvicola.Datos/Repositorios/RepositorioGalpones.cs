using Dapper;
using ProyectoAvicola.Datos.Interfaces;
using ProyectoAvicola.Entidades.Dtos;
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
    public class RepositorioGalpones : IRepositorioGalpones
    {
        private readonly string cadenaConexion;
        public RepositorioGalpones()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public void Agregar(Galpon galpon)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"insert into Galpon 
                (GranjaId, Capacidad) values (@GranjaId, @Capacidad); 
                SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, galpon);
                galpon.GalponId = id;
            }
        }

        public void Borrar(int GalponId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Galpon WHERE GalponId=@GalponId";
                conn.Execute(deleteQuery, new { GalponId });
            }
        }

        public void Editar(Galpon galpon)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"update Galpon set 
                GranjaId=@GranjaId, Capacidad=@Capacidad 
                where GalponId=@GalponId";
                conn.Execute(updateQuery, galpon);
            }
        }

        public bool Existe(Galpon galpon)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (galpon.GalponId == 0)
                {
                    selectQuery = @"select count(*) from Galpon 
                    where GranjaId=7 and Capacidad=999";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, galpon);
                }
                else
                {
                    selectQuery = @"select count(*) from Galpon 
                    where GranjaId=7 and Capacidad=999 and GalponId!=2";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, galpon);
                }
            }
            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Galpon";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }

        public List<GalponDto> GetGalpones()
        {
            List<GalponDto> lista = new List<GalponDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"select ga.GalponId, 
                gr.NombreGranja, ga.Capacidad from Galpon ga 
                inner join Granja gr on ga.GranjaId=gr.GranjaId";
                lista = conn.Query<GalponDto>(selectQuery).ToList();
            }
            return lista;
        }

        public Galpon GetGalponesPorId(int GalponId)
        {
            Galpon galpon = null;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"select GalponId, GranjaId, 
                Capacidad from Galpon where GalponId=@GalponId";
                galpon = conn.QuerySingleOrDefault<Galpon>(selectQuery, new { GalponId });
            }
            return galpon;
        }
    }
}
