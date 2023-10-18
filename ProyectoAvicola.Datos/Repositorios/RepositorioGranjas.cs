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
    public class RepositorioGranjas:IRepositorioGranjas
    {
        private readonly string cadenaConexion;

        public RepositorioGranjas()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn=new SqlConnection(cadenaConexion))
            {
                string selectQuery= "SELECT COUNT(*) FROM Granja";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }
        public void Editar(Granja Granja)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"UPDATE Granja SET LocalidadId=@LocalidadId,
                NombreGranja=@NombreGranja, Direccion=@Direccion WHERE GranjaId=@GranjaId";
                conn.Execute(updateQuery, Granja);
            }
        }
        public void Borrar(int GranjaId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Granja WHERE GranjaId=@GranjaId";
                conn.Execute(deleteQuery, new { GranjaId });
            }
        }
        public void Agregar(Granja Granja) 
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Granja 
                (LocalidadId, NombreGranja, Direccion) 
                VALUES (@LocalidadId, @NombreGranja, @Direccion); 
                SELECT SCOPE_IDENTITY()";
                int id = conn.QuerySingle<int>(insertQuery, Granja);
                Granja.GranjaId = id;
            }
        }

        public List<GranjaDto> GetGranjas()
        {
            List<GranjaDto> lista = new List<GranjaDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT g.GranjaId ,g.NombreGranja, 
                g.Direccion, l.NombreLocalidad FROM Granja G 
                INNER JOIN Localidad L ON L.LocalidadId=G.LocalidadId";
                lista = conn.Query<GranjaDto>(selectQuery).ToList();
            }
            return lista;
        }

        public bool Existe(Granja granja)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (granja.GranjaId == 0)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Granja 
                    WHERE LocalidadId=@LocalidadId AND 
                    NombreGranja=@NombreGranja AND Direccion=@Direccion";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, granja);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Granja 
                    WHERE LocalidadId=@LocalidadId AND 
                    NombreGranja=@NombreGranja AND Direccion=@Direccion 
                    AND GranjaId!=@GranjaId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, granja);
                }
            }
            return cantidad > 0;
        }

        public Granja GetGranjasPorId(int GranjaId)
        {
            Granja granja = null;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT GranjaId, LocalidadId, NombreGranja, 
                Direccion FROM Granja WHERE GranjaId=@GranjaId";
                granja = conn.QuerySingleOrDefault<Granja>(selectQuery, new { GranjaId });
            }
            return granja;
        }
    }
}
