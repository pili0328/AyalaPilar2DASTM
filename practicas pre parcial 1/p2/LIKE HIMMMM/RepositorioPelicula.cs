using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LIKE_HIMMMM
{
    public class RepositorioPelicula
    {
        private string conexion = "Server=localhost\\SQLEXPRESS;Database=peliculas;Trusted_Connection=True;";
       // private string conexion = "Data Source=DESKTOP-A276CKC\\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;Encrypt=False";


        public bool OK()
        {
            try
            {
                SqlConnection connection = new SqlConnection(conexion);
                connection.Open();

            }
            catch
            {
                return false;
            }
            return true;
        }

        public List<Pelicula> ListadoPeliculas()
        {
            List<Pelicula> peli = new List<Pelicula>();

            string query = "select  id,nombre,estreno,puesto_top,vista from Tematica";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Pelicula pelis = new Pelicula();

                        pelis.Id = reader.GetInt32(0);
                        pelis.Nombre = reader.GetString(1);
                        pelis.Estreno = reader.GetDateTime(2);
                        pelis.PuestoTOP = reader.GetInt32(3);
                        pelis.Vista = reader.GetBoolean(4);

                        peli.Add(pelis);
                    }

                    reader.Close();
                    connection.Close();

                }
                catch(Exception ex) 
                {
                    throw new Exception("Error! " + ex.Message);
                }
            }
            return peli;
        }

        public void Agregar(string nom,DateTime est,int top,bool ver)
        {
            string query = "insert into Tematica(nombre,estreno,puesto_top,vista) values " + "(@nombre,@estreno,@puesto_top,@vista)";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query,connection);
                comando.Parameters.AddWithValue("@nombre",nom);
                comando.Parameters.AddWithValue("@estreno",est);
                comando.Parameters.AddWithValue("@puesto_top", top);
                comando.Parameters.AddWithValue("@vista",ver);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error! " + ex.Message);
                }
            }

        }

        public Pelicula BuscarId(int id)
        {
            string query = "select  id,nombre,estreno,puesto_top,vista from Tematica " + "where id=@id";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id",id);

                try
                {
                    connection.Open();

                    SqlDataReader reader = comando.ExecuteReader();

                    reader.Read();
                    Pelicula pelis = new Pelicula();

                    pelis.Id = reader.GetInt32(0);
                    pelis.Nombre = reader.GetString(1);
                    pelis.Estreno = reader.GetDateTime(2);
                    pelis.PuestoTOP = reader.GetInt32(3);
                    pelis.Vista = reader.GetBoolean(4);

                    reader.Close();
                    connection.Close();

                    return pelis;


                }
                catch (Exception ex)
                {
                    throw new Exception("Error! " + ex.Message);
                }
            }
        }

        public void Modificar(int id,string nom,DateTime est, int top, bool ver)
        {
            string query = "update Tematica set nombre=@nombre,estreno=@estreno,puesto_top=@puesto_top,vista=@vista " + "where id=@id";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query,connection);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nom);
                comando.Parameters.AddWithValue("@estreno", est);
                comando.Parameters.AddWithValue("@puesto_top", top);
                comando.Parameters.AddWithValue("@vista", ver);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error! " + ex.Message);
                }
            }
        }

        public void Eliminar(int id)
        {
            string query = "delete from Tematica " + "where id=@id";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error! " + ex.Message);
                }
            }
        }

        public List<Pelicula> Vistas()
        {
            List<Pelicula> p = new List<Pelicula> ();

            string query = "select id,nombre,vista from Tematica " + "where vista = 1";

            using (SqlConnection connection = new SqlConnection(conexion))
            {
                SqlCommand comando = new SqlCommand(query,connection);
               

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Pelicula pelis = new Pelicula
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nombre = Convert.ToString(reader["nombre"]),
                            Vista = Convert.ToBoolean(reader["vista"]),
                        };

                        p.Add(pelis);
                    }                   

                }
                catch (Exception ex)
                {
                    throw new Exception("Error! " + ex.Message);
                }
            }

            return p;

        }

    }
}
