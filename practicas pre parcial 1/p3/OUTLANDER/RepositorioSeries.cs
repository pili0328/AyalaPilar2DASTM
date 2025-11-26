using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OUTLANDER
{
    public class RepositorioSeries
    {
        private string cadena = "Server=localhost\\SQLEXPRESS;Database=novelas;Trusted_Connection=True;";

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

        public List<Serie> ListadoSeries()
        {
            List<Serie> ser = new List<Serie>();

            string query = "select id,nombre,fecha_estreno,temporadas from Series";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while (reader.Read())
                    {
                        Serie sr = new Serie();

                        sr.Id = reader.GetInt32(0);
                        sr.Nombre = reader.GetString(1);
                        sr.Fecha_Estreno = reader.GetDateTime(2);
                        sr.Temporada = reader.GetInt32(3);

                        ser.Add(sr);
                    }

                    reader.Close();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }
            return ser;
        }

        public void Agregar(string nom,DateTime fecha,int tem)
        {
            string query = "insert into Series (nombre,fecha_estreno,temporadas) values " + "(@nombre,@fecha_estreno,@temporadas)";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@nombre",nom);
                comando.Parameters.AddWithValue("@fecha_estreno",fecha);
                comando.Parameters.AddWithValue("@temporadas",tem);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }
        }

        public Serie BuscarId(int? id)
        {
            string query = "select id,nombre,fecha_estreno,temporadas from Series " + " where id=@id";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id", id);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    reader.Read();

                    Serie ser = new Serie();

                    ser.Id = reader.GetInt32(0);
                    ser.Nombre = reader.GetString(1);
                    ser.Fecha_Estreno = reader.GetDateTime(2);
                    ser.Temporada = reader.GetInt32(3);
                   
                    reader.Close();
                    connection.Close();

                    return ser;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }
        }

        public void Modificar(int id, string nom, DateTime fecha, int tem)
        {
            string query = "update Series set nombre=@nombre,fecha_estreno=@fecha_estreno,temporadas=@temporadas " + "where id=@id";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nom);
                comando.Parameters.AddWithValue("@fecha_estreno", fecha);
                comando.Parameters.AddWithValue("@temporadas", tem);

                try
                {
                    connection.Open();
                    comando.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }
        }

        public void Eliminar(int id)
        {
            string query = "delete from Series " + "where id=@id";

            using(SqlConnection connection = new SqlConnection(cadena))
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
                    throw new Exception("Error!!" + ex.Message);
                }
            }
        }

        public List<Serie> FechaEstreno()
        {
            List<Serie> s = new List<Serie>();

            string query = "select id,nombre,fecha_estreno,temporadas from Series " + " where year(fecha_estreno) < 2025";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection); 
                
                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while(reader.Read())
                    {
                        Serie ser = new Serie
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nombre = Convert.ToString(reader["nombre"]),
                            Fecha_Estreno = Convert.ToDateTime(reader["fecha_estreno"]),
                            Temporada = Convert.ToInt32(reader["temporadas"]),
                        };

                        s.Add(ser);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }
            return s;
        }
        
        public List<Serie> Temporadas()
        {
            List<Serie> series = new List<Serie>();

            string query = "select id,nombre,fecha_estreno,temporadas from Series "+ "where temporadas > 1";

            using (SqlConnection connection = new SqlConnection(cadena))
            {
                SqlCommand comando = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    while( reader.Read())
                    {
                        Serie s = new Serie
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Nombre = Convert.ToString(reader["nombre"]),
                            Fecha_Estreno = Convert.ToDateTime(reader["fecha_estreno"]),
                            Temporada = Convert.ToInt32(reader["temporadas"]),
                        };
                        series.Add(s);
                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error!!" + ex.Message);
                }
            }

            return series;
        }

    }
}
