using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Agenda.Entidades;

namespace Agenda.Datos
{
    public class ContactoDatos
    {
        private readonly Conexion conexion = new Conexion();

        // INSERTAR CONTACTO
        public int Insertar(Contacto contacto)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "sp_Contacto_Insertar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = contacto.Nombre;
                    cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar, 20).Value = contacto.Telefono;
                    cmd.Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value =
                        string.IsNullOrWhiteSpace(contacto.Correo) ? DBNull.Value : contacto.Correo;
                    cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value =
                        string.IsNullOrWhiteSpace(contacto.Direccion) ? DBNull.Value : contacto.Direccion;

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // MODIFICAR CONTACTO
        public int Modificar(Contacto contacto)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "sp_Contacto_Modificar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = contacto.Id;
                    cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = contacto.Nombre;
                    cmd.Parameters.Add("@Telefono", SqlDbType.NVarChar, 20).Value = contacto.Telefono;
                    cmd.Parameters.Add("@Correo", SqlDbType.NVarChar, 100).Value =
                        string.IsNullOrWhiteSpace(contacto.Correo) ? DBNull.Value : contacto.Correo;
                    cmd.Parameters.Add("@Direccion", SqlDbType.NVarChar, 200).Value =
                        string.IsNullOrWhiteSpace(contacto.Direccion) ? DBNull.Value : contacto.Direccion;

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // ELIMINAR CONTACTO
        public int Eliminar(int id)
        {
            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "sp_Contacto_Eliminar", cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        // BUSCAR CONTACTOS
        public List<Contacto> Buscar(string texto)
        {
            return EjecutarConsulta("sp_Contacto_Buscar", texto);
        }

        // LISTAR TODOS LOS CONTACTOS
        public List<Contacto> Listar()
        {
            return EjecutarConsulta("sp_Contacto_Listar");
        }

        // MÉTODO PARA EJECUTAR CONSULTAS
        private List<Contacto> EjecutarConsulta(
            string procedimiento, string texto = null)
        {
            List<Contacto> lista = new List<Contacto>();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand(procedimiento, cn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (texto != null)
                    {
                        cmd.Parameters.Add("@Texto", SqlDbType.NVarChar, 100).Value = texto;
                    }

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contacto contacto = new Contacto
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                Nombre = Convert.ToString(reader["Nombre"]) ?? "",
                                Telefono = Convert.ToString(reader["Telefono"]) ?? "",
                                Correo = Convert.ToString(reader["Correo"]) ?? "",
                                Direccion = Convert.ToString(reader["Direccion"]) ?? ""
                            };

                            lista.Add(contacto);
                        }
                    }
                }
            }

            return lista;
        }
    }
}
