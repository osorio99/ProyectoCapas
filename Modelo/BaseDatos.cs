using Modelo.Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class BaseDatos : ConexionMysql
    {
        public List<UsuarioEntity> TraerUsuario()
        {
            List<UsuarioEntity> usuarios = new List<UsuarioEntity>();
            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "SELECT * FROM clientes";
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                UsuarioEntity usuarioActual = new UsuarioEntity();
                usuarioActual.id = dr.GetInt32(0);
                usuarioActual.nombre = dr.GetString(1);
                usuarioActual.apellido = dr.GetString(2);
                usuarios.Add(usuarioActual);
            }

            return usuarios;
        }

        public int GuardarUsuario(string nombre, string apellido)
        {
            int resultado = 0;

            MySqlCommand cmd = GetConnection().CreateCommand();
            cmd.CommandText = "INSERT INTO clientes (nombre,apellido)" +
                " VALUES ('" + nombre + "','" + apellido + "')";
            resultado = cmd.ExecuteNonQuery();

            return resultado;
        }
    }
}
