using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRevista
{
    class ServicioBD
    {
        public ServicioBD()
        {
            SqliteConnection conexion = new SqliteConnection("Data Source=RevistaAutores.db");

            conexion.Open();

            SqliteCommand comando = conexion.CreateCommand();
            comando.CommandText = @"CREATE TABLE IF NOT EXISTS Autores (nombre varchar(20) primary key, nickname varchar(20), image varchar(20), imageRed varchar(20))";

            comando.ExecuteNonQuery();


        }
    }
}
