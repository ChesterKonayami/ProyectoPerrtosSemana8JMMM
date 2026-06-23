using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ProyectoPerritosWCF.Data
{
    public class ConexionBD
    {
        // Cadena de conexión al servidor MySQL
        private string cadenaConexion =
            "Server=;" +
            "Port=;" +
            "Database=;" +
            "Uid=;" +
            "Pwd=;";

        // Método que devuelve una conexión
        public MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            return conexion;
        }

        public string ProbarConexion()
        {
            try
            {
                using (MySqlConnection conexion = ObtenerConexion())
                {
                    conexion.Open();
                    return "Conexion exitosa";
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        // Valida si existe un usuario con las credenciales
        // recibidas desde el formulario Login.
        public bool ValidarUsuario(
            string nombreUsuario,
            string password)
        {
            /*
             * IMPLEMENTACIÓN REAL
             * (Pendiente de restablecer la conexión con MySQL)
             *

            string consulta =
                "SELECT COUNT(*) " +
                "FROM TBL_LOGIN_JMMM " +
                "WHERE NombreUsuario = @usuario " +
                "AND Password = @password";

            using (MySqlConnection conexion = ObtenerConexion())
            {
                conexion.Open();

                MySqlCommand comando =
                    new MySqlCommand(
                        consulta,
                        conexion);

                comando.Parameters.AddWithValue(
                    "@usuario",
                    nombreUsuario);

                comando.Parameters.AddWithValue(
                    "@password",
                    password);

                int cantidad =
                    Convert.ToInt32(
                        comando.ExecuteScalar());

                return cantidad > 0;
            }
            */

            // Valor temporal mientras el servidor
            // no esté disponible.
            return false;
        }
    }
}
