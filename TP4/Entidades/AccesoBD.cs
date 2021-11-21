using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AccesoBD
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;

        static AccesoBD()
        {
            connectionString = @"Server=.;Database=imdb;Trusted_Connection=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static void Guardar(Pelicula pelicula)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO equipos (director, escritor, actor1, actor2, actor3, id)  VALUES (@director, @escritor, @actor1, @actor2, @actor3, @id)";
                command.Parameters.AddWithValue("@director", pelicula.Equipo.Director);
                command.Parameters.AddWithValue("@escritor", pelicula.Equipo.Escritor);
                command.Parameters.AddWithValue("@actor1", pelicula.Equipo.Actores[0]);
                command.Parameters.AddWithValue("@actor2", pelicula.Equipo.Actores[1]);
                command.Parameters.AddWithValue("@actor3", pelicula.Equipo.Actores[2]);
                command.Parameters.AddWithValue("@id", pelicula.Equipo.Id);


                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = $"INSERT INTO peliculas (titulo, año, puntuacion, genero, duracion, equipo)  VALUES (@titulo, @año, @puntuacion, @genero, @duracion, @equipo)";
                command.Parameters.AddWithValue("@titulo", pelicula.Titulo);
                command.Parameters.AddWithValue("@año", pelicula.AñoLanzamiento);
                command.Parameters.AddWithValue("@puntuacion", pelicula.Puntuacion);
                command.Parameters.AddWithValue("@genero", pelicula.Genero);
                command.Parameters.AddWithValue("@duracion", pelicula.Duracion);
                command.Parameters.AddWithValue("@equipo", pelicula.Equipo.Id);

                command.ExecuteNonQuery();

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
