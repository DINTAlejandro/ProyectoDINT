using Microsoft.Data.Sqlite;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using ProyectoRevista.Clases;
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
            comando.CommandText = @"CREATE TABLE IF NOT EXISTS Autores 
                                    (nombre varchar(20) primary key, nickname varchar(20) DEFAULT NULL, 
                                     image varchar(20) DEFAULT NULL, imageRed varchar(20)) DEFAULT NULL";

            comando.ExecuteNonQuery();

            comando.CommandText = @"CREATE TABLE IF NOT EXISTS Articulos 
                                    (titulo varchar(20) primary key, imagen varchar(100) DEFAULT NULL, 
                                     texto varchar(200) DEFAULT NULL, seccion varchar(20) DEFAULT NULL,
                                     autor varchar(20), publicado BIT DEFAULT NULL, 
                                     FOREIGN KEY (autor) REFERENCES Autores(nombre), FOREIGN KEY (seccion) REFERENCES Secciones(name))";

            comando.ExecuteNonQuery();

            comando.CommandText = @"CREATE TABLE IF NOT EXISTS Secciones 
                                    (name varchar(20) primary key)"; 

            comando.ExecuteNonQuery();

            conexion.Close();
        }

        public List<Autor> GetAutors()
        {
            List<Autor> AllAutor = new List<Autor>();



            return AllAutor;
        }
    }
}
