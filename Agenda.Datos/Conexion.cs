using Microsoft.Data.SqlClient;

namespace Agenda.Datos
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            @"Server=.\SQLEXPRESS;
              Database=AgendaElectronica_Multicapa;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

