using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MUSIQUITA
{
    public class RepositorioMusica
    {

        private string cadena = "Server=localhost\\SQLEXPRESS;Database=playlist;Trusted_Connection=True;";

        public bool OK()
        {
            try
            {
                SqlConnection connection = new SqlConnection(cadena);
                connection.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Musica> ListadoMusica()
        {
            List<Musica> mu = new List<Musica>();
            string query = "select id,nombre,duracion_min,agregar from Musica";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query,connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Musica mor = new Musica();
                        mor.Id = reader.GetInt32(0);
                        mor.Nombre = reader.GetString(1);
                        mor.Duracion_Minutos = reader.GetInt32(2);
                        mor.Agrego = reader.GetBoolean(3);

                        mu.Add(mor);
                    }

                    reader.Close();
                    connection.Close();

                }
                catch(Exception ex) 
                {
                    throw new Exception("ERROR!" + ex.Message);
                }
            }

            return mu;
        }

        public void Agrego(string nom,int dur,bool agr)
        {
            string query = "insert into Musica (nombre,duracion_min,agregar) values " + "(@nombre,@duracion_min,@agregar)";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre",nom);
                comando.Parameters.AddWithValue("@duracion_min", dur);
                comando.Parameters.AddWithValue("@agregar", agr);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("ERROR!" + ex.Message);
                }
            }
        }

        public Musica Buscar(int? id)
        {
            string query = "select id,nombre,duracion_min,agregar from Musica " + "where id=@id";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query,connection);
                comando.Parameters.AddWithValue("@id",id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    reader.Read();

                    Musica mor = new Musica();
                    mor.Id = reader.GetInt32(0);
                    mor.Nombre = reader.GetString(1);
                    mor.Duracion_Minutos = reader.GetInt32(2);
                    mor.Agrego = reader.GetBoolean(3);

                    reader.Close();
                    connection.Close();

                    return mor;

                }
                catch (Exception ex)
                {
                    throw new Exception("ERROR!" + ex.Message);
                }
            }
        }

        public void Modificar(int id,string nom, int dur, bool agr)
        {
            string query = "update Musica set nombre=@nombre,duracion_min=@duracion_min,agregar=@agregar " + "where id=@id";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query,connection);
                comando.Parameters.AddWithValue("@id",id);
                comando.Parameters.AddWithValue("@nombre", nom);
                comando.Parameters.AddWithValue("@duracion_min", dur);
                comando.Parameters.AddWithValue("@agregar", agr);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("ERROR!" + ex.Message);
                }
            }
        }

        public void Eliminar(int id)
        {
            string query = "delete from Musica " + "where id=@id";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id",id);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("ERROR!" + ex.Message);
                }
            }
        }

        // metodo lo agregue a la playlist?
        public List<Musica> Playslist()
        {
            List<Musica> mus = new List<Musica>();
            string query = "select id,nombre,duracion_min,agregar from Musica " + "where agregar = 1";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Musica mor = new Musica
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nombre = Convert.ToString(reader["nombre"]),
                            Duracion_Minutos = Convert.ToInt32(reader["duracion_min"]),
                            Agrego = Convert.ToBoolean(reader["agregar"]),                 
                        };

                        mus.Add(mor);
                    }

                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("ERROR!" + ex.Message);
                }
            }

            return mus;
        }
    }
}
