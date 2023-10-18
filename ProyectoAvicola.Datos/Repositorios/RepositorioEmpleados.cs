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
    public class RepositorioEmpleados : IRepositorioEmpleados
    {
        private readonly string cadenaConexion;
        public RepositorioEmpleados()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();

        }
        public void Agregar(Empleado empleado)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = @"INSERT INTO Empleado 
                (LocalidadId, GranjaId, NombreEmpleado, ApellidoEmpleado,
                Telefono) VALUES (@LocalidadId, @GranjaId, @NombreEmpleado,
                @ApellidoEmpleado, @Telefono); SELECT SCOPE_IDENTITY()";
                int id = conn.ExecuteScalar<int>(insertQuery, empleado);
                empleado.EmpleadoId = id;

            }
        }

        public void Borrar(int EmpleadoId)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string deleteQuery = "DELETE FROM Empleado WHERE EmpleadoId=@EmpleadoId";
                conn.Execute(deleteQuery, new { EmpleadoId });
            }
        }

        public void Editar(Empleado empleado)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string updateQuery = @"UPDATE Empleado SET 
                LocalidadId=@LocalidadId, GranjaId=@GranjaId, 
                NombreEmpleado=@NombreEmpleado, ApellidoEmpleado=@ApellidoEmpleado,
                Telefono=@Telefono WHERE EmpleadoId=@EmpleadoId";
                conn.Execute(updateQuery, empleado);
            }
        }

        public bool Existe(Empleado empleado)
        {
            var cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (empleado.EmpleadoId == 0)
                {
                    selectQuery = @"SELECT COUNT(*) FROM Empleado WHERE 
                    LocalidadId=@LocalidadId AND GranjaId=@GranjaId AND 
                    NombreEmpleado=@NombreEmpleado AND 
                    ApellidoEmpleado=@ApellidoEmpleado AND 
                    Telefono=@Telefono";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, empleado);
                }
                else
                {
                    selectQuery = @"SELECT COUNT(*) FROM Empleado WHERE
                    LocalidadId=@LocalidadId AND GranjaId=@GranjaId AND
                    NombreEmpleado=@NombreEmpleado AND
                    ApellidoEmpleado=@ApellidoEmpleado AND 
                    Telefono=@Telefono AND EmpleadoId!=@EmpleadoId";
                    cantidad = conn.ExecuteScalar<int>(selectQuery, empleado);
                }
            }
            return cantidad > 0;
        }

        public int GetCantidad()
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = "SELECT COUNT(*) FROM Empleado";
                cantidad = conn.ExecuteScalar<int>(selectQuery);
            }
            return cantidad;
        }

        public Empleado GetEmpleadoPorId(int EmpleadoId)
        {
            Empleado empleado = null;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT EmpleadoId, LocalidadId, 
                GranjaId, NombreEmpleado, ApellidoEmpleado, Telefono 
                FROM Empleado WHERE EmpleadoId=@EmpleadoId";
                empleado = conn.QuerySingleOrDefault<Empleado>(selectQuery, new { EmpleadoId });
            }
            return empleado;
        }

        public List<EmpleadoDto> GetEmpleados()
        {
            List<EmpleadoDto> lista = new List<EmpleadoDto>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT E.EmpleadoId ,E.NombreEmpleado, 
                E.ApellidoEmpleado, E.Telefono, L.NombreLocalidad, 
                G.NombreGranja FROM Empleado E INNER JOIN Localidad L 
                ON L.LocalidadId=E.LocalidadId INNER JOIN Granja G ON 
                G.GranjaId=E.GranjaId";
                lista = conn.Query<EmpleadoDto>(selectQuery).ToList();
            }
            return lista;
        }
    }
}
